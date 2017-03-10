using Ensitech.BusinessLogic.Interfaces;
using Ensitech.DataAccess.Interfaces;
using Ensitech.DataAccess.Repositories;
using Ensitech.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ensitech.BusinessLogic.Services
{
    public class ProductService : IService<Product>
    {
        IRepository<Product> _productRepository;
        CurrencyRepository _currencyRepository;
        public ProductService()
        {
            if (_productRepository == null)
                _productRepository = new ProductRepository();

            if (_currencyRepository == null)
                _currencyRepository = new CurrencyRepository();
        }
        public List<Product> Get()
        {
            var products = _productRepository.Retrieve();
            if(products.Any())
                ChangeCurrency(products);
            return products;
        }

        private void ChangeCurrency(List<Product> products)
        {
            string[] arryResponse = _currencyRepository.ChangeCurrency("MXN=X", "sl1d1t1ba");
            double pesos = double.Parse(arryResponse[4]);//Se utiliza el tipo de cambio al que se oferta el dolar "b"
            products.ForEach(p => p.price = Math.Round((p.price * pesos), 2));
        }

        public bool Create(Product product)
        {
            return _productRepository.Save(product);
        }
    }
}
