using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManager.Web.Controllers
{
    public class MainController : Controller
    {
        public MainController()
        {

        }

        public ViewResult Index()
        {

            return View();
        }
    }
}
