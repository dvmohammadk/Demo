using DemoTest.Applicatin.Services.Interfaces;
using DemoTest.Domain.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TestDemo.WebApi.Controllers
{
    [Route("api/products")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        #region Ctor
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion


        //public IActionResult Get([FromQuery] ProductParameters productParameters)
        //{
        //    var products = _productService.GetAllProducts(productParameters);
        //    var metadata = new
        //    {
        //        products.TotalCount,
        //        products.PageSize,
        //        products.CurrentPage,
        //        products.TotalPages,
        //        products.HasNext,
        //        products.HasPrevious
        //    };

        //    Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
        //    return Ok(products);
        //}
        [HttpGet]
        public IActionResult Get([FromQuery] ProductList productList)
        {
            var products = _productService.GetAll(productList);
            var metadata = new
            {
                products.TotalCount,
                products.PageSize,
                products.CurrentPage,
                products.TotalPages,
                products.HasNext,
                products.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            return Ok(products);
        }
        [HttpGet]
        [Route("search")]
        public IActionResult Search([FromQuery] ProductParameters productParameters)
        {
            var products = _productService.SearchProducts(productParameters);
            var metadata = new
            {
                products.TotalCount,
                products.PageSize,
                products.CurrentPage,
                products.TotalPages,
                products.HasNext,
                products.HasPrevious
            };

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            return Ok(products);
        }
    }
}