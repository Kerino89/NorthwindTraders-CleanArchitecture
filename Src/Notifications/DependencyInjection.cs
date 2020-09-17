using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Common.Interfaces;
using Northwind.Infrastructure;

namespace Notifications
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddNotifications(this IServiceCollection services)
        {
            services.AddTransient<INotificationService, NotificationService>();
            return services;
        }
    }
}