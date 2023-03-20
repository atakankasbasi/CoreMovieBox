using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.Areas.Admin.Controllers
{
    [Area("Admin")] 
    public class Top10MovieController : Controller
    {
        Top10MovieListManager top10MovieListManager = new Top10MovieListManager(new EfTop10MovieListDal());
        public IActionResult Index()
        {
            var values = top10MovieListManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTop10Movie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTop10Movie(Top10MovieList top10MovieList)
        {
            top10MovieListManager.TInsert(top10MovieList);
            return RedirectToAction("Index", "Top10Movie", new { area = "Admin" });
        }
        public IActionResult DeleteTop10Movie(int id)
        {
            
            top10MovieListManager.TDelete(new Top10MovieList { MovieID = id});
            return RedirectToAction("Index");
        }
    }
}
