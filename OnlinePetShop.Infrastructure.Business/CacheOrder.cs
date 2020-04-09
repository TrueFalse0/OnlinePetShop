using OnlinePetShop.Domain.Core;
using OnlinePetShop.Services.Interfaces;


namespace OnlinePetShop.Infrastructure.Business
{
    public class CacheOrder : IOrder
    {
        public void MakeOrder(Animal animal)
        {
            // код покупки при оплате наличностью
        }
    }
}
