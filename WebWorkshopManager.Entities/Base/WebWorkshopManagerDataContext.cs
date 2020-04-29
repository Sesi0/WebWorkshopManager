using System;
using System.Threading;
using System.Threading.Tasks;
using BobbysUtils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebWorkshopManager.Entities.Models;
using WebWorkshopManager.Shared.ENUMS;

namespace WebWorkshopManager.Entities.Base
{
    public class WebWorkshopManagerDataContext : DbContext
    {
        private readonly string connectionString;

        public WebWorkshopManagerDataContext()
        {
            this.connectionString = "Server=localhost\\SQLEXPRESS;Database=WebWorkshopManager;Uid=bobby;Pwd=17621620;";
        }

        public WebWorkshopManagerDataContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<JobItem> JobItems { get; set; }

        public DbSet<Job> Jobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!string.IsNullOrEmpty(this.connectionString))
            {
                optionsBuilder.UseSqlServer(this.connectionString);
            }
            else
            {
                throw new ArgumentNullException("ConnectionString is empty!");
            }
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                await base.SaveChangesAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId = 1,
                Name = "Системен администратор",
                Permissions = EnumHelper.EnumSetAll<PERMISSION>(),
            });

            modelBuilder.Entity<User>().HasData(new User()
            {
                UserId = 1,
                Name = "admin",
                RoleId = 1,
                Password = CryptoHelper.GetMd5Hash("admin"),
                Email = "admin@autoservicesoft.com",
            });

            modelBuilder.Entity<Engine>().HasData(new Engine()
            {
                EngineId = 1,
                Name = "1.9 TDI",
                FuelType = FUEL_TYPE.DIESEL,
                HorsePower = 101
            });

            modelBuilder.Entity<Engine>().HasData(new Engine()
            {
                EngineId = 2,
                Name = "1.8T",
                FuelType = FUEL_TYPE.GASOLINE,
                HorsePower = 150
            });

            modelBuilder.Entity<Car>().HasData(new Car()
            {
                CarId = 1,
                Brand = "Volkswagen",
                Model = "Golf 4",
                EngineId = 1,
                EngineNumber = "ATD496532",
                Mileage = 212654.451M,
                Year = 2003,
                LicensePlate = "BP3666CC",
                Vin = "WVWZZZ1JZ3W584008"
            });

            modelBuilder.Entity<Customer>().HasData(new Customer()
            {
                CustomerId = 1,
                Name = "Борислав Николаев Николов",
                ContactNumber = "0879590946",
                Email = "borislav.nikolov.37@gmail.com"
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 1,
                Name = "Смяна на масло",
                ProductType = PRODUCT_TYPE.SERVICE,
                QuantityInStock = 1,
                UnitPrice = 2.40M
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 2,
                Name = "Масло Castrol EDGE Turbo Diesel Titanium FST 5W40 - 4Л",
                ProductType = PRODUCT_TYPE.PRODUCT,
                QuantityInStock = 5,
                UnitPrice = 57M
            });

            modelBuilder.Entity<Product>().HasData(new Product()
            {
                ProductId = 3,
                Name = "Труд",
                ProductType = PRODUCT_TYPE.LABOUR,
                QuantityInStock = 1,
                UnitPrice = 5.2M
            });
        }
    }
}