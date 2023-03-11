using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreMovieBox.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal()); 
        public IActionResult Index()
        {
            var values = commentManager.TGetList();
            return View(values);
        }


        [HttpGet]
        public IActionResult CommentAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CommentAdd(Comment comment)
        {
            commentManager.TInsert(comment);
            return RedirectToAction("Index");
        }


        public IActionResult CommentDelete(int id)
        {
            var values = commentManager.TGetByID(id);
            commentManager.TDelete(values);
            return RedirectToAction("Index");

        }




        [HttpGet]
        public IActionResult CommentEdit(int id)
        {
            var values = commentManager.TGetByID(id);
            return View();
        }
        [HttpPost]
        public IActionResult CommentEdit(Comment comment)
        {
            commentManager.TUpdate(comment);
            return RedirectToAction("Index");
        }
    }
}
