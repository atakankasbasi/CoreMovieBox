﻿using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.HomeCategory
{
	public class PopulerFilmler : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}