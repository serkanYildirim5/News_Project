using News_Project.BLL.Controller;
using News_Project.Entity.Model;
using News_Project.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News_Project.UI.Controllers
{
    public class NewsViewController : Controller
    {
        // GET: News
        NewsController news = new NewsController();
        CommentController comments = new CommentController();
        public ActionResult News_Details(int newsId)
        {
            News_DetailModel model = new News_DetailModel();
            model.Comments = comments.GetAll().Where(x => x.HaberId == newsId).ToList();
            model.News = news.GetById(newsId);
            model.News.ViewsCounter = model.News.ViewsCounter + 1;
            news.Update(model.News);
            return View(model);
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CommentAdd(Comment comment)
        {
            comments.Add(comment);
            TempData["alert"] = "<script>alert('Yorumunuz Kaydedilmiştir')</script>";
            return RedirectToAction("News_Details",new { newsId = comment.HaberId });
        }
        public ActionResult CommentDelete(Comment comment)
        {
            comments.Delete(comment);
            return RedirectToAction("Editor","Login",null);
        }
        [HttpPost]
        public ActionResult CommentUpdate(Comment comment)
        {
            Comment updateComment = new Comment();
            updateComment.CommentId = comment.CommentId;
            updateComment.CommentContent = comment.CommentContent;
            updateComment.CommentTitle = comment.CommentTitle;
            updateComment.CreateDate = comment.CreateDate;
            updateComment.FullName = comment.FullName;
            updateComment.HaberId = comment.HaberId;
            comments.Update(updateComment);         
            return RedirectToAction("Editor","Login",null);
        }
    }
}