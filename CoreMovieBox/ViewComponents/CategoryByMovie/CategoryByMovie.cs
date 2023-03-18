using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.CategoryByMovie
{
    public class CategoryByMovie : ViewComponent
    {
        MovieManager movieManager = new MovieManager(new EfMovieDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = movieManager.TGetListByFilter(x => x.CategoryID == id);
            return View(values);
        }
    }
}
