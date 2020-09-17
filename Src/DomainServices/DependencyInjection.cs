using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using DomainServices.Interfaces;

namespace DomainServices
{
    public static class DependencyInjection
    {
        public static void AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderDomainService, OrderDomainService>();
        }
    }
}
