using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sybatnetwork.Models;

namespace sybatnetwork.Controllers
{
    public class HomeController : Controller
    {
        private const string bm1 = "Sybat Network believes in the unstoppable power of blockchain ";
        private const string bm2 = " technologies on quantum hardwares, sybatcoin is built on ";
        private const string bm3 = "HDQKD cryptographic algorithm. ";
        private const string apis = "Discover our APIs";
        private const string shops = "Get Sybatcoin";
        private const string exchanges = "Exchanges";
        private const string whitepaper = "Read our Whitepaper";
        private const string explorer = "Block Explorer";
        private readonly ILogger<HomeController> _logger;

        public static string Bm3 => bm3;

        public static string Bm2 => bm2;

        public static string Bm1 => bm1;

        public static string Shops => Shops;

        public static string Apis => apis;

        public static string Exchanges => exchanges;

        public static string Whitepaper => whitepaper;

        public static string Explorer => explorer;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["BuisnessModel1"] = Bm1;
            ViewData["BuisnessModel2"] = Bm2;
            ViewData["BuisnessModel3"] = Bm3;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Dev()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
