using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePetShop.Domain.Core
{
    public class Animal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public decimal Price { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }

    }
}
