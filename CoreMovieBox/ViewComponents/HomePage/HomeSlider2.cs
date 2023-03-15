using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents
{
	public class HomeSlider2 : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
