using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{

    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var values = cm.TGetListByFilter(x=>x.Status==true);
            return View(values);
        }
        [HttpGet]       
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            category.Status = true;
            cm.TInsert(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {

            var value = cm.TGetByID(id);
            value.Status = false;
            cm.TUpdate(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var value = cm.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            category.Status = true;
            cm.TUpdate(category);
            return RedirectToAction("Index");
        }

    }
}
