﻿using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MovieListController : Controller
    {
        public IActionResult MovieList()
        {
            return View();
        }
    }
}
