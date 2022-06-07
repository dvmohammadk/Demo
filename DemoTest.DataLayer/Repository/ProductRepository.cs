using DemoTest.DataLayer.Context;
using DemoTest.Domain.Dto;
using DemoTest.Domain.Entites.Product;
using DemoTest.Domain.Enum;
using DemoTest.Domain.Interfaces;
using DemoTest.Domain.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = DemoTest.Domain.Enum.Type;

namespace DemoTest.DataLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        #region cotr
        private readonly TestDemoDbContext _demoDbContext;
        public ProductRepository(TestDemoDbContext demoDbContext)
        {
            _demoDbContext = demoDbContext;
        }




        #endregion
        public PagedList<ProductViewModel> GetAll(ProductList productList)
        {
            var products = _demoDbContext.Products.AsQueryable();
            return PagedList<ProductViewModel>.ToPagedList(products
                .OrderBy(p => p.Tilte)
                .Select(pro => new ProductViewModel
                {
                    Id = pro.Id,
                    Color = pro.Color.ToString(),
                    Price = pro.Price,
                    Tilte = pro.Tilte,
                    Type = pro.Type.ToString()
                })
                .AsQueryable(),
                productList.PageNumber,
                productList.PageSize);
        }
        public PagedList<ProductViewModel> SearchProducts(ProductParameters productParameters)
        {
            var products = _demoDbContext.Products.AsQueryable();
            //.Select(pro => new ProductDto
            //{
            //    Id = pro.Id,
            //    Color = pro.Color,
            //    Price = pro.Price,
            //    Tilte = pro.Tilte,
            //    Type = pro.Type
            //});
            Search(ref products, productParameters.Color, productParameters.Type);

            return PagedList<ProductViewModel>.ToPagedList(products
                .OrderBy(p => p.Tilte)
                .Select(pro => new ProductViewModel
                {
                    Id = pro.Id,
                    Color = pro.Color.ToString(),
                    Price = pro.Price,
                    Tilte = pro.Tilte,
                    Type = pro.Type.ToString()
                })
                .AsQueryable(),
                productParameters.PageNumber,
                productParameters.PageSize);
        }
        private void Search(ref IQueryable<Product> products, Color? productColor, Type? productType)
        {

            //if (!products.Any()) return;
            if (productColor != null)
            {
                products = products.Where(e => e.Color == productColor);
            }
            if (productType != null)
            {
                products = products.Where(e => e.Type == productType);
            }
        }


    }
}
