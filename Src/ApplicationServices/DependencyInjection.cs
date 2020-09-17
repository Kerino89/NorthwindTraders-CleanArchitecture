using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Common.Interfaces;
using Northwind.Infrastructure.Files;

namespace ApplicationServices
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<ICsvFileBuilder, CsvFileBuilder>();
        }
    }

}
