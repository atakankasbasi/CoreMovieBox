using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class Categories : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
