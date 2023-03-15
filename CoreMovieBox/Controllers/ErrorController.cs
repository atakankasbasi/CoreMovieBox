using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Error(int code)
        {
            return View();
        }
    }
}
