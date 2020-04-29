using AutoMapper;
using WebWorkshopManager.Entities.Base;

namespace WebWorkshopManager.Services.Base
{
    public abstract class BaseService
    {
        protected WebWorkshopManagerDataContext context;
        protected IMapper mapper;

        protected BaseService(WebWorkshopManagerDataContext webWorkshopManagerDataContext, IMapper mapper)
        {
            this.context = webWorkshopManagerDataContext;
            this.mapper = mapper;
        }
    }
}
