using Lend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lend.Domain.Services
{
    public class PriceQuotesService
    {
        private readonly IProductRepository _productRepository;

        public PriceQuotesService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public void GetPriceQuotesByProductCategory(string productCategory) 
        {

        }

        public void GetPriceQuotesByProductName(string productName)
        {
            var products = _productRepository.
        }

    }
}
