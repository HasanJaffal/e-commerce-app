using Microsoft.AspNetCore.Mvc;

namespace Server.API.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
