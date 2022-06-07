using DemoTest.Domain.Dto;
using DemoTest.Domain.ViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.Domain.Interfaces
{
    public interface IProductRepository
    {
        PagedList<ProductViewModel> GetAllProducts(ProductParameters productParameters);
        
    }
}
