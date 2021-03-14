using StockManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager.Domain
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
