using DemoTest.Applicatin.Services.Interfaces;
using DemoTest.Domain.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
//using System.Web.Http;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace TestDemo.WebApi.Controllers
{
    //[ApiController]
    //[System.Web.Http.Route("[controller]")]
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region Ctor
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        #endregion
        
        [HttpGet]
        [Authorize]
        //[System.Web.Http.Route("product")]
        public IActionResult Get ([FromQuery] ProductParameters productParameters)
        {
            var products = _productService.GetAllProducts(productParameters);
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
