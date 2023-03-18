using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class CategoryByMovie : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult CatList(int id)
        { 
            ViewBag.x = id;
            var values = categoryManager.TGetListByFilter(x => x.CategoryID == id);
            return View(values);
        }
      
    }
}
