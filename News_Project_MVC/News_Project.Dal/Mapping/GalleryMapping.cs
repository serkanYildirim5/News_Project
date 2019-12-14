using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Dal.Mapping
{
    public class GalleryMapping : EntityTypeConfiguration<Gallery>
    {
        public GalleryMapping()
        {
            ToTable("Galleries");
            HasKey(x => x.GalleryId);
            Property(x => x.ImagePath).HasColumnType("varchar").HasMaxLength(500);
        }
    }
}
