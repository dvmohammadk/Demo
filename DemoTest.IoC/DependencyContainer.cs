using DemoTest.Applicatin.Services.Implementations;
using DemoTest.Applicatin.Services.Interfaces;
using DemoTest.DataLayer.Repository;
using DemoTest.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest.IoC
{
    public class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            #region Services
            services.AddScoped<IProductService, ProductService>();
            #endregion



            #region Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            #endregion

        }
    }
}
