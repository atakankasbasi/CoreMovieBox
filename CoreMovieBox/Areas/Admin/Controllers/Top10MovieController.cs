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
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Top10MovieLists.ToList();
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
            c.Add(top10MovieList);
            c.SaveChanges();
            return RedirectToAction("Index", "Top10Movie");
        }
        public IActionResult DeleteTop10Movie(int id)
        {

            var value = c.Top10MovieLists.Find(id);
            c.Top10MovieLists.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index", "Top10Movie");
        }
    }
}
