using News_Project.BLL.Controller;
using News_Project.Entity.Model;
using News_Project.UI.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News_Project.UI.Controllers
{
    public class HomeController : Controller
    {
        CategoryController category = new CategoryController();
        NewsController news = new NewsController();
        GalleryController gallery = new GalleryController();
        CommentController comment = new CommentController();
        
        public ActionResult Index(int? SayfaNo)
        {
            int _sayfaNo = SayfaNo ?? 1;
            IndexModel indexModel = new IndexModel();
            indexModel.CategoryList = category.GetAll();
            indexModel.GalleryList = gallery.GetAll();
            indexModel.NewsList = news.GetAll().OrderByDescending(X=>X.NewsId).ToPagedList<News>(_sayfaNo,8);
            indexModel.CommentList = comment.GetAll();
            return View(indexModel);
        }


        public ActionResult About()
        {
          return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}