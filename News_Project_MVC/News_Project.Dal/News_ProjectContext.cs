using News_Project.Dal.Mapping;
using News_Project.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Dal
{
    public class News_ProjectContext:DbContext
    {
        public News_ProjectContext():base(ConnectionStringContainer.ConnectionString)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Gallery> Gallery { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new GalleryMapping());
            modelBuilder.Configurations.Add(new NewsMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
