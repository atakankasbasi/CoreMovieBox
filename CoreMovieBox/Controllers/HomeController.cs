﻿using CoreMovieBox.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMovieBox.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Landing()
        {
            return View();
        }
        public IActionResult Anasayfa()
        {
            return View();
        }
        public IActionResult KategoriList()
        {
            return View();
        }
        public IActionResult KategoriDetay()
        {
            return View();
        }

        public IActionResult FilmDetay()
        {
            return View();
        }

		public IActionResult Test()
		{
			return View();
		}

		public IActionResult Deneme()
		{
			return View();
		}

        public IActionResult Catolog()
        {
            return View();
        }

    }
}
