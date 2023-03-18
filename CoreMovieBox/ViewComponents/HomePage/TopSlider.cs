using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.ViewComponents
{
	public class TopSlider : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
