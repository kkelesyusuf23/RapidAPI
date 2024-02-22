using Microsoft.AspNetCore.Mvc;

namespace RapidAPI.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
