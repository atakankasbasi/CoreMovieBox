using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
           var values = categoryManager.TGetList();
            return View(values);    
        }


        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            categoryManager.TInsert(category);
            return RedirectToAction("Index");
        }



        public IActionResult CategoryDelete(int id)
        {
            var values = categoryManager.TGetByID(id);
            categoryManager.TDelete(values);
            return View(values);
        }






        [HttpGet]
        public IActionResult CategoryEdit(int id)
        {
            var values = categoryManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult CategoryEdit(Category category)
        {
            categoryManager.TUpdate(category);
            return RedirectToAction("Index");
        }








    }
}

