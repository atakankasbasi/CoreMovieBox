using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.MovieDetails
{
	public class MovieDetails : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
