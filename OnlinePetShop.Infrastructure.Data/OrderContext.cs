using System;
using System.Collections.Generic;
using System.Data.Entity;
using OnlinePetShop.Domain.Core;

namespace OnlinePetShop.Infrastructure.Data
{
    public class OrderContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
    }
}
