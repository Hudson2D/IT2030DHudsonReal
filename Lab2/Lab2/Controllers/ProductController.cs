using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public string Index()
        {
            return "Product/Index is displayed";
        }

        public string Browse()
        {
            return "Browse displayed";
        }

        public string Details(int id)
        {
            return "Details displayed for ID = " + id;
        }

        public string Location(int zip)
        {
            return "Location displayed for zip = " + zip;
        }
    }
}