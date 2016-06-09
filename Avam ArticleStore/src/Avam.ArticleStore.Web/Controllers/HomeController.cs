using Microsoft.AspNetCore.Mvc;

namespace Avam.ArticleStore.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ControlPanel()
        {
            return View();
        }
    }
}
