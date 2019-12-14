namespace News_Project.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class veritabanı : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 250, unicode: false),
                        ParentId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryId)
                .ForeignKey("dbo.Categories", t => t.ParentId)
                .Index(t => t.ParentId);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        NewsId = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(maxLength: 150, unicode: false),
                        NewsContent = c.String(maxLength: 500, unicode: false),
                        CreateDate = c.DateTime(nullable: false, storeType: "date"),
                        Like = c.Int(nullable: false),
                        ViewsCounter = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NewsId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentTitle = c.String(maxLength: 50, unicode: false),
                        CommentContent = c.String(maxLength: 350, unicode: false),
                        CreateDate = c.DateTime(nullable: false, storeType: "date"),
                        HaberId = c.Int(nullable: false),
                        FullName = c.String(maxLength: 150, unicode: false),
                        Mail = c.String(maxLength: 150, unicode: false),
                        News_NewsId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.News", t => t.News_NewsId)
                .Index(t => t.News_NewsId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(maxLength: 500, unicode: false),
                        NewsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GalleryId)
                .ForeignKey("dbo.News", t => t.NewsId, cascadeDelete: true)
                .Index(t => t.NewsId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 250, unicode: false),
                        Mail = c.String(maxLength: 250, unicode: false),
                        Password = c.String(maxLength: 250, unicode: false),
                        RoleId = c.Int(nullable: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "ParentId", "dbo.Categories");
            DropForeignKey("dbo.News", "UserId", "dbo.Users");
            DropForeignKey("dbo.Galleries", "NewsId", "dbo.News");
            DropForeignKey("dbo.Comments", "News_NewsId", "dbo.News");
            DropForeignKey("dbo.News", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Galleries", new[] { "NewsId" });
            DropIndex("dbo.Comments", new[] { "News_NewsId" });
            DropIndex("dbo.News", new[] { "UserId" });
            DropIndex("dbo.News", new[] { "CategoryId" });
            DropIndex("dbo.Categories", new[] { "ParentId" });
            DropTable("dbo.Users");
            DropTable("dbo.Galleries");
            DropTable("dbo.Comments");
            DropTable("dbo.News");
            DropTable("dbo.Categories");
        }
    }
}
