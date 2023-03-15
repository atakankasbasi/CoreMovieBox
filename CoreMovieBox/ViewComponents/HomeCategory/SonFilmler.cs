using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class SonFilmler : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
