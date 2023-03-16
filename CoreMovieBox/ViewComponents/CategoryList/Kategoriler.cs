using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class Kategoriler : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
