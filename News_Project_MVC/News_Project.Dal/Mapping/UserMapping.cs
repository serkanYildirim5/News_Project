using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Dal.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            ToTable("Users");
            HasKey(x => x.UserId);
            Property(x => x.FullName).HasColumnType("varchar").HasMaxLength(250);
            Property(x => x.Mail).HasColumnType("varchar").HasMaxLength(250);
            Property(x => x.Password).HasColumnType("varchar").HasMaxLength(250);
        }
    }
}
