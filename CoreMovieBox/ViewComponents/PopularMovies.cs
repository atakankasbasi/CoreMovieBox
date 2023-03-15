using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents
{
	public class PopularMovies : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}