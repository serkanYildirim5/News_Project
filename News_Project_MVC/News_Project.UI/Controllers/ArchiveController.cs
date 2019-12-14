using News_Project.BLL.Controller;
using News_Project.Entity.Model;
using News_Project.UI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News_Project.UI.Controllers
{
    public class ArchiveController : Controller
    {
        NewsController news =new NewsController();
        CategoryController category = new CategoryController();
        GalleryController gallery = new GalleryController();
        // GET: Archive
        public ActionResult Archive(int? CategoryNo)
        {
            ArchiveModel model = new ArchiveModel();
            model.News = from us in news.GetAll() where(us.CategoryId == CategoryNo || us.Category.ParentId==CategoryNo) select us ;
            model.Category = from cat in category.GetAll() where (cat.ParentId == CategoryNo) select cat;
            return View(model);
        }
        [HttpPost] 
        public ActionResult NewsAdd(WriterModel model)
        {

            if (ModelState.IsValid)
            {
                List<Gallery> fotoList = new List<Gallery>();
                News AddNew = new News();
                AddNew.NewsContent =RemoveHtml.Delete(model.NewsContent);
                AddNew.CreateDate = DateTime.Now;
                AddNew.CategoryId = model.News.CategoryId;
                AddNew.NewsTitle = model.NewsTitle;
                AddNew.UserId = 2;
                news.Add(AddNew);
                foreach (HttpPostedFileBase file in model.files)
                {
                    //Checking file is available to save.  
                    if (file != null)
                    {
                        var InputFileName = Path.GetFileName(file.FileName);
                        var ServerSavePath = Path.Combine(Server.MapPath("~/Assets/img/") + InputFileName);
                        Gallery newPage = new Gallery();
                        newPage.ImagePath = "Assets/img/" + InputFileName;
                        newPage.NewsId = news.GetAll().Select(x=>x.NewsId).LastOrDefault();
                        fotoList.Add(newPage);
                        gallery.Add(newPage);
                        //Save file to server folder  
                        file.SaveAs(ServerSavePath);
                    }
                }
                
            }

            ViewBag.Kayit = "Kaydedildi";
            return RedirectToAction("Writer", "Login",null);
        }
    }
}