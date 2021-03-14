using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManager.Domain;
using StockManager.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        private readonly StockContext _context;
        //public ProductController(IProductRepository productRepository)
        //   {
        //       this.repository = productRepository;
        //   }

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }
        public ViewResult List()
        {
            return View(repository.Products);
        }

        public  IActionResult Details(string sn)
        {
            if (string.IsNullOrEmpty(sn))
            {
                return NotFound();
            }

            var product =  _context.Products.FirstOrDefault( x=> x.SN.Equals(sn));

            return View(product);
        }
    }
}
