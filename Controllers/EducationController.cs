﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace sybatnetwork.Controllers
{
    public class EducationController : Controller
    {
        // GET: /<controller>/
        private const string webTitle = "Education";
        public IActionResult Index()
        {
            ViewData["Title"] = webTitle;
            return View();
        }
        public IActionResult QKD()
        {
            ViewData["Title"] = "Quantum Key Distribution";
            return View();
        }
        public IActionResult QPoS()
        {
            ViewData["Title"] = "Quantum Proof of State";
            return View();
        }
        public IActionResult QuantumBlockchainTechnology()
        {
            ViewData["Title"] = "Quantum Blockchain Technology";
            return View();
        }
        public IActionResult QuantumChanneling()
        {
            ViewData["Title"] = "Quantum Channeling";
            return View();
        }
        public IActionResult QuantumNetwork()
        {
            ViewData["Title"] = "Quantum Network";
            return View();
        }
    }
}

