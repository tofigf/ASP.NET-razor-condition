using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asp.netHomework3ProductTable.Models;

namespace Asp.netHomework3ProductTable.Controllers
{
    public class HomeController : Controller
    {
        ProductsAspOneTableEntities db = new ProductsAspOneTableEntities();
        public ActionResult Index()
        {
            ViewProducts model = new ViewProducts
            {
                Products = db.Products.ToList()
            };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}