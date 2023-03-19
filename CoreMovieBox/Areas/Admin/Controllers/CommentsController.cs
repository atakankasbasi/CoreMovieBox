using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CommentsController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            var values = cm.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddComment(Comment comment)
        {
            comment.Status = true;
            cm.TInsert(comment);
            return RedirectToAction("Index", "Comment", new { area = "Admin" });
        }
    }
}
