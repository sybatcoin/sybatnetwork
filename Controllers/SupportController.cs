﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sybatnetwork.Controllers
{
    public class SupportController : Controller
    {
        private const string webTitle = "Support";
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Title"] = webTitle;
            return View();
        }
        public IActionResult Legal()
        {
            ViewData["Title"] = "Terms of Service";
            return View();
        }
    }
}
