using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents
{
	public class BottomSlider : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
