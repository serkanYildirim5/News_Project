using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Entity.Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CreateDate { get; set; }
        public int HaberId { get; set; }
        public virtual News News { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
    }
}
