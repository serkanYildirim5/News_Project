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
    public class LoginController : Controller
    {
        // GET: Login
        UserController users = new UserController();
        CategoryController category = new CategoryController();
        CommentController comments = new CommentController();
        public string LoginName;
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult LoginControl(User user)
        {
            if (users.GetAll().Where(x=>x.Mail==user.Mail).Any() && users.GetAll().Where(x => x.Password == user.Password).Any())
            { 
                 int  ControlUs = (from us in users.GetAll() where (us.Mail == user.Mail && us.Password == user.Password) select us.RoleId).FirstOrDefault();
                LoginName = (from ad in users.GetAll() where (ad.Mail == user.Mail) select ad.FullName).FirstOrDefault();
                switch (ControlUs)
                {
                    case 0:
                        return RedirectToAction("Admin");
                    case 1:
                        return RedirectToAction("Editor");
                    case 2:
                        return RedirectToAction("Writer");
                    default:
                        return RedirectToAction("Login");
                }
                 
            }
            else
            {
                return RedirectToAction("Login");
            }            
        }

        public ActionResult Writer()
        {
            ViewBag.Ad = LoginName;
            WriterModel model = new WriterModel();
            List<Category> categories = category.GetAll();
            List<SelectListItem> ListItem= new List<SelectListItem>();
            foreach (var item in categories)
            {
                SelectListItem yeniItem = new SelectListItem();
                yeniItem.Value = item.CategoryId.ToString();
                yeniItem.Text = item.CategoryName;
                ListItem.Add(yeniItem);
            }
            model.CategoryList = ListItem;
            News news = new News();
            model.News = news;
            return View(model);
        }
        public ActionResult Editor()
        {
            ViewBag.Ad = LoginName;
            List<Comment> comment = new List<Comment>();
            comment = comments.GetAll();
            return View(comment);
        }
        public ActionResult Admin()
        {
            ViewBag.Ad = LoginName;
            AdminModel model = new AdminModel();
            model.Users = users.GetAll();
            return View(model);
        }
        public ActionResult UserDelete(User user)
        {
            users.Delete(user);
            return RedirectToAction("Admin");
        }
        [HttpPost]
        public ActionResult UserUpdate(User user)
        {
            User updateUser = new User();
            updateUser.UserId = user.UserId;
            updateUser.FullName = user.FullName;
            updateUser.Password = user.Password;
            updateUser.RoleId = user.RoleId;
            updateUser.Mail = user.Mail;
            users.Update(updateUser);
            return RedirectToAction("Admin");
        }
    }
}