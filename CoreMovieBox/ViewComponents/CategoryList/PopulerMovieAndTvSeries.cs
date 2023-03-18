using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class PopulerMovieAndTvSeries : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
