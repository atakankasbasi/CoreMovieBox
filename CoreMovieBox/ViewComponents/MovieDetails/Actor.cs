using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.MovieDetails
{
	public class Actor : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
