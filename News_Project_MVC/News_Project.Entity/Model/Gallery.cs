using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Entity.Model
{
    public class Gallery
    {
        public int GalleryId { get; set; }
        public string ImagePath { get; set; }
        public int NewsId { get; set; }
        public virtual News News { get; set; }
    }
}
