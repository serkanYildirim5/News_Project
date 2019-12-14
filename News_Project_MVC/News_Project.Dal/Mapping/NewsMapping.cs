using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Dal.Mapping
{
    public class NewsMapping : EntityTypeConfiguration<News>
    {
        public NewsMapping()
        {
            ToTable("News");
            HasKey(x => x.NewsId);
            Property(x => x.NewsTitle).HasColumnType("varchar").HasMaxLength(150);
            Property(x => x.NewsContent).HasColumnType("varchar").HasMaxLength(500);
            Property(x => x.CreateDate).HasColumnType("date");

        }
    }
}
