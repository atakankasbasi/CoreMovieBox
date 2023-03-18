using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MovieDetailController : Controller
    {
        public IActionResult MovieDetail()
        {
            return View();
        }
    }
}
