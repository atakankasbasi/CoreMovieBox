using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents
{
    public class MainSeriesList:ViewComponent
    {
        TvSerieManager tvSerieManager = new TvSerieManager(new EfTvSerieDal());
        public IViewComponentResult Invoke()
        {
            var values = tvSerieManager.TGetList();
            return View(values);
        }
    }
}
