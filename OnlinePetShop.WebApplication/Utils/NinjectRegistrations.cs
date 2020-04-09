using Ninject.Modules;
using OnlinePetShop.Domain.Interfaces;
using OnlinePetShop.Infrastructure.Business;
using OnlinePetShop.Infrastructure.Data;
using OnlinePetShop.Services.Interfaces;

namespace OnlinePetShop.WebApplication.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IAnimalRepository>().To<AnimalRepository>();
            Bind<IOrder>().To<CacheOrder>();
        }
    }
}