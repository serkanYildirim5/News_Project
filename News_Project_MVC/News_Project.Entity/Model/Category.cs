using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Entity.Model
{
    public class Category
    {
        public Category()
        {
            News =new HashSet<News>();
            SubCategories = new HashSet<Category>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ParentId { get; set; }
        public virtual ICollection<News> News { get; set; }
        public virtual ICollection<Category> SubCategories { get; set; } 
    }
}
