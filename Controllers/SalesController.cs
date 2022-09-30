using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sybatnetwork.Models;

namespace sybatnetwork.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Sales";
            return View();
        }
        // /Sales/Contact
        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Title"] = "Contact Sales";

            return View();
        }
        [HttpPost]
        public IActionResult Contact(Sales model)
        {
            ViewData["Title"] = "Contact Sales";
            var FirstName = model.Firstname;
            var LastName = model.Lastname;
            var Email = model.Email;
            var Organisation = model.Organisation;
            var OrganisationType = model.OrganisationType;
            var Country = model.Country;
            var Message = model.Message;

            ViewData["Title"] = FirstName;

            // return Json(model);
            return View(model);
        }
    }
}
