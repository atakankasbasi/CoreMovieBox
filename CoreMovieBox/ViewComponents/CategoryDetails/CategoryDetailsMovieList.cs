using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.CategoryDetails
{
    public class CategoryDetailsMovieList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
