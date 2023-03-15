using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents
{
	public class TabMenuBar : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}


