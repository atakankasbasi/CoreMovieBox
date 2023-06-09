﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
	public class CategoryListController : Controller
	{
		CategoryManager categoryManager = new CategoryManager(new EfCategoryDal()); 
        public IActionResult CategoryList()
        {
            var values = categoryManager.TGetListByFilter(x => x.Status == true);
            return View(values);
        }

    }
}
