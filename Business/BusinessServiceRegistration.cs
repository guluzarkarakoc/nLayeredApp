using Business.Abstract;
using Business.Concrete;
using Business.DTOs.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
            public static IServiceCollection AddBusinessServices(this IServiceCollection services)
            {
              services.AddScoped<IProductService, ProductManager>();
             services.AddAutoMapper(typeof(MapperProfile).Assembly);

            // services.AddAutoMapper(Assembly.GetExecutingAssembly());
              return services;
            }
        
    }
}
