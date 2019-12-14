using System;
using System.Collections.Generic;

namespace News_Project.Entity.Model
{
    public class News
    {
        public News()
        {
            Galleries = new HashSet<Gallery>();
            Comments = new HashSet<Comment>();
        }
        public int NewsId { get; set; }
        public string NewsTitle { get; set; }

        public string NewsContent { get; set; }
        public DateTime CreateDate { get; set; }
        public int Like { get; set; }
        public int ViewsCounter { get; set; }
        public virtual ICollection<Gallery> Galleries { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}