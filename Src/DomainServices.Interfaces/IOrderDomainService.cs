using System;
using System.Collections.Generic;
using System.Text;
using Northwind.Domain.Entities;

namespace DomainServices.Interfaces
{
    public interface IOrderDomainService
    {
        decimal GetPrice(Order order, TransportInfo transportInfo);
    }
}
