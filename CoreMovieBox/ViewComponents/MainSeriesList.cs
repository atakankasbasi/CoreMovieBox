using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreMovieBox.ViewComponents
{
    public class MainSeriesList:ViewComponent
    {
        //TvSerieManager tvSerieManager = new TvSerieManager(new EfTvSerieDal());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var values = c.Top10TvSerieLists.ToList();
            return View(values);
        }
    }
}
