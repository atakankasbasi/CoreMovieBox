using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.ViewComponents
{
	public class NewReleases : ViewComponent
	{
		Context c = new Context();
		public IViewComponentResult Invoke()
		{
			var values = c.Movies.ToList();
			return View(values);
		}
	}
}