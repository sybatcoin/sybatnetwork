using Microsoft.AspNetCore.Mvc;

namespace sybatnetwork.Controllers
{
    public class DocsController : Controller
    {
        private const string WebTitle = "Docs";
        public IActionResult Index()
        {
            ViewData["Title"] = WebTitle;
            return View();
        }
    }
}
