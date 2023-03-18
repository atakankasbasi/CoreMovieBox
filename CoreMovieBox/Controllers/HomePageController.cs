using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
