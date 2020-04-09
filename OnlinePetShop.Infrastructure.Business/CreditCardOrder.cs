using OnlinePetShop.Domain.Core;
using OnlinePetShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePetShop.Infrastructure.Business
{
    public class CreditCardOrder : IOrder
    {
        public void MakeOrder(Animal animal)
        {
            // код покупки при оплате картой
        }
    }
}
