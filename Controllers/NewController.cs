using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sybatnetwork.Controllers
{
    public class NewController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = "What's new";
            return View();
        }
        public IActionResult Lavender()
        {
            ViewData["Title"] = "Syabtcoin Lavender";
            return View();
        }
        public IActionResult Core()
        {
            ViewData["Title"] = "Sybatcoin Core";
            return View();
        }
        public IActionResult QubitnaryNumbers()
        {
            ViewData["Title"] = "Qubitnary Numbers";
            return View();
        }
        public IActionResult QoKa()
        {
            ViewData["Title"] = "QoKa";
            return View();
        }
    }
}

