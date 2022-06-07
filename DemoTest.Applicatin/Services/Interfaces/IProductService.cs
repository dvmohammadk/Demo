using DemoTest.Domain.Dto;
using DemoTest.Domain.Interfaces;
using DemoTest.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.Applicatin.Services.Interfaces
{
    public interface IProductService
    {
        #region Products
        PagedList<ProductViewModel> GetAllProducts(ProductParameters productParameters);
        #endregion
    }

}
