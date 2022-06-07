using DemoTest.Applicatin.Services.Interfaces;
using DemoTest.Domain.Dto;
using DemoTest.Domain.Interfaces;
using DemoTest.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.Applicatin.Services.Implementations
{
    public class ProductService : IProductService
    {
        #region Ctor
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        #endregion
        #region Products
        public PagedList<ProductViewModel> SearchProducts(ProductParameters productParameters)
        {
            return  _productRepository.SearchProducts( productParameters);
        }
        public PagedList<ProductViewModel> GetAll(ProductList productList)
        {
            return _productRepository.GetAll(productList);
        }
        #endregion
    }
}
