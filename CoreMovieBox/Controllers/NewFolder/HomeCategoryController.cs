using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class HomeCategoryController : Controller
    {
        public IActionResult HomeCategory()
        {
            return View();
        }
    }
}
