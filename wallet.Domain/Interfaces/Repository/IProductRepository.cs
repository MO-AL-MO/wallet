using InventorySystem.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wallet.Domain.Entities.Category;
using wallet.Domain.Entities.Product;

namespace wallet.Domain.Interfaces.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        
    }
}
