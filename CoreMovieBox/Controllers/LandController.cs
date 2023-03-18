using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class LandController : Controller
    {
        public IActionResult Land()
        {
            return View();
        }
    }
}
