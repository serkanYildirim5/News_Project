using News_Project.Entity.Model;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News_Project.UI.Models
{
    public class IndexModel
    {
        public IPagedList<News> NewsList { get; set; }
        public List<Category> CategoryList { get; set; }
        public List<Gallery> GalleryList { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}