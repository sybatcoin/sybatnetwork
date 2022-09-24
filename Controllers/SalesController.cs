using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sybatnetwork.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Sales";
            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Sales";
            return View();
        }
    }
}
