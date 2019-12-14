using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News_Project.UI.Models
{
    public class News_DetailModel
    {
        public List<Comment> Comments { get; set; }
        public News News { get; set; }
    }
}