using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        //GET: Store/Details?samsung=[value]

        public ActionResult Details(string samsung)
        {
            // check for an empty samsung
            if (samsung == null)
            {
                //return View("Error");
                return RedirectToAction("Index");
            }

            ViewBag.Samsung = samsung;
            return View(); 
        }
    }
}