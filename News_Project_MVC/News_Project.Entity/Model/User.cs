using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Entity.Model
{
    public class User
    {
        public User()
        {
            News = new HashSet<News>();
        }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public virtual ICollection<News> News { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        
    }
}
