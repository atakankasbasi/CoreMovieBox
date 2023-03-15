using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.ViewComponents
{
	public class HomeSlider : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
