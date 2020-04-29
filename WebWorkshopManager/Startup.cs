using System;
using System.Linq;
using System.Net.Http;
using AutoMapper;
using MatBlazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebWorkshopManager.Entities.Base;
using WebWorkshopManager.Mapper.Profiles;
using WebWorkshopManager.Services;
using WebWorkshopManager.Services.Contracts;

namespace WebWorkshopManager.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<WebWorkshopManagerDataContext>(options =>
                options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new RolesDtosProfile());
                mc.AddProfile(new UsersDtosProfile());
                mc.AddProfile(new EnginesDtosProfile());
                mc.AddProfile(new CarsDtosProfile());
                mc.AddProfile(new ProductsDtosProfile());
                mc.AddProfile(new CustomersDtosProfile());
                mc.AddProfile(new JobsDtosProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICarService, CarService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IJobService, JobService>();

            if (services.All(x => x.ServiceType != typeof(HttpClient)))
            {
                services.AddScoped(
                    s =>
                    {
                        var navigationManager = s.GetRequiredService<NavigationManager>();
                        return new HttpClient
                        {
                            BaseAddress = new Uri(navigationManager.BaseUri)
                        };
                    });
            }

            services.AddMatToaster(config =>
            {
                config.Position = MatToastPosition.BottomRight;
                config.PreventDuplicates = true;
                config.NewestOnTop = true;
                config.ShowCloseButton = true;
                config.MaximumOpacity = 95;
                config.VisibleStateDuration = 3000;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
