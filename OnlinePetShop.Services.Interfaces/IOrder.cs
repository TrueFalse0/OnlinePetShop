using OnlinePetShop.Domain.Core;

namespace OnlinePetShop.Services.Interfaces
{
    public interface IOrder
    {
        void MakeOrder(Animal animal);
    }
}
