using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.MovieDetails
{
	public class Testimonial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
