using Ensitech.DataAccess.Interfaces;
using Ensitech.DataAccess.Tools;
using Ensitech.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.DataAccess.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        public List<Product> Retrieve()
        {
            return TxtTools.RetrieveProducts();
        }

        public bool Save(Product product)
        {
            return TxtTools.SaveProduct(product);
        }
    }
}
