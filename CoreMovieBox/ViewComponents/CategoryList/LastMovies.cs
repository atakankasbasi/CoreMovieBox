using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class LastMovies : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
