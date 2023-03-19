using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Top10TvSerieController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var values = c.Top10TvSerieLists.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTop10Movie()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTop10Movie(Top10TvSerieList top10TvSerieList)
        {
            c.Top10TvSerieLists.Add(top10TvSerieList);
            c.SaveChanges();
            return RedirectToAction("Index", "Top10Movie", new { area = "Admin" });
        }
        public IActionResult DeleteTop10Movie(int id)
        {
            var value = c.Top10TvSerieLists.Find(id);
            c.Top10TvSerieLists.Remove(value);
            c.SaveChanges();
            return RedirectToAction("Index", "Top10Movie", new { area = "Admin" });
        }
    }
}
