using Microsoft.EntityFrameworkCore;
using StockManager.Domain.Context;
using StockManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager.Domain.Repository
{
    public class ProductRepository : IProductRepository
    {
        private StockContext context;
        public ProductRepository(StockContext context)
        {
            this.context = context;
        }
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }


    }
}
