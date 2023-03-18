using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
	public class CategoryListController : Controller
	{
		public IActionResult CategoryList()
		{
			return View();
		}
	}
}
