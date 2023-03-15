using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class Interview : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
