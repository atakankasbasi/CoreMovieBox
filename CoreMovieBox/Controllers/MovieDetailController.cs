﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class MovieDetailController : Controller
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IActionResult MovieDetail(int id)
        {
            var values = movieManager.GetMoviesByID(id);
            return View(values);
        }

    }
}
