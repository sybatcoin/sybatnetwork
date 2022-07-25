using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sybatnetwork.Controllers
{
    public class BusinessController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = "Business";
            return View();
        }
        public IActionResult Console()
        {
            ViewData["Title"] = "Sybatcoin Console";
            return View();
        }
        public IActionResult RPC()
        {
            ViewData["Title"] = "Sybatcoin RPC";
            return View();
        }
    }
}

