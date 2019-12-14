using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace News_Project.UI.Models
{
    public class ArchiveModel
    {
        public IEnumerable<News> News { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}