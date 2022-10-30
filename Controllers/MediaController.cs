using Microsoft.AspNetCore.Mvc;

namespace sybatnetwork.Controllers
{
    public class MediaController : Controller
    {
        private const string webTitle = "Media";
        public IActionResult Index()
        {
            ViewData["Title"] = webTitle;
            return View();
        }
    }
}
