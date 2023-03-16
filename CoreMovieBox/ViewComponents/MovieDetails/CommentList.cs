using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.ViewComponents.MovieDetails
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
