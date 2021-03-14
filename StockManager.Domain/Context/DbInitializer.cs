using StockManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManager.Domain.Context
{
   public static class DbInitializer
    {
        public static void Initialize(StockContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product{SN="s0001",PCode="0001",Name="chair",RDate=DateTime.Parse("2020-02-23"), InStock=true },
                new Product{SN="s0002",PCode="0001",Name="chair",RDate=DateTime.Parse("2020-02-23"), InStock=true },
                new Product{SN="s0003",PCode="0001",Name="chair",RDate=DateTime.Parse("2020-02-23"), InStock=true },
                  new Product{SN="s0004",PCode="0001",Name="chair",RDate=DateTime.Parse("2020-02-23"), InStock=true }
            };
            var uniNo = new UniqueNo[]
            { new UniqueNo{ Unique_No=1} };
            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.UniqueNos.Add(uniNo.FirstOrDefault());
            context.SaveChanges();

        }
    }
}
