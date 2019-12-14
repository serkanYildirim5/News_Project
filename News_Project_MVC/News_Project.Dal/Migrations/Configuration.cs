namespace News_Project.Dal.Migrations
{
    using News_Project.Entity.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<News_ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(News_ProjectContext context)
        {
            //    List<Category> Kategoriler = new List<Category>() {
            //        new Category(){CategoryName="Spor"},
            //        new Category(){CategoryName="Finans"},
            //        new Category(){CategoryName="Ekonomi"},
            //        new Category(){CategoryName="Magazin"},
            //        new Category(){CategoryName="Dünya"},
            //    };
            //    context.Categories.AddRange(Kategoriler);
            //    context.SaveChanges();


            //    List<Category> AltKategoriler = new List<Category>()
            //    {
            //        new Category(){CategoryName="Futbol",ParentId=1},
            //        new Category(){CategoryName="Basketbol",ParentId=1},
            //        new Category(){CategoryName="Spor+",ParentId=1},
            //        new Category(){CategoryName="Borsa",ParentId=2},
            //        new Category(){CategoryName="Döviz",ParentId=2},
            //        new Category(){CategoryName="Altın",ParentId=2},
            //        new Category(){CategoryName="Kripto Paralar",ParentId=2},
            //        new Category(){CategoryName="Faiz",ParentId=2},
            //        new Category(){CategoryName="Dış Piyasalar",ParentId=2},

            //    };
            //    context.Categories.AddRange(AltKategoriler);
            //    context.SaveChanges();




            //List<User> userList = new List<User>() {

            //        new User(){Mail="admin@gmail.com",Password="1234",RoleId=0},
            //        new User(){Mail="salih@gmail.com",Password="1234",RoleId=1}
            //    };

            //context.User.AddRange(userList);
            //context.SaveChanges();


            //List<News> newsList = new List<News>() {

            // new News(){NewsTitle="Falcao Geldi",NewsContent="Kolombiyalı süper yıldız 2 aylık sahalara uzak kalmasından sonra taraftarın yüzünü güldürmek istiyor.",CategoryId=1,CreateDate=DateTime.Now,UserId=1},
            // new News(){NewsTitle="Falcao Geldi",NewsContent="Kolombiyalı süper yıldız 2 aylık sahalara uzak kalmasından sonra taraftarın yüzünü güldürmek istiyor.",CategoryId=2,CreateDate=DateTime.Now,UserId=1},
            // new News(){NewsTitle="Falcao Geldi",NewsContent="Kolombiyalı süper yıldız 2 aylık sahalara uzak kalmasından sonra taraftarın yüzünü güldürmek istiyor.",CategoryId=3,CreateDate=DateTime.Now,UserId=2},
            // new News(){NewsTitle="Falcao Geldi",NewsContent="Kolombiyalı süper yıldız 2 aylık sahalara uzak kalmasından sonra taraftarın yüzünü güldürmek istiyor.",CategoryId=4,CreateDate=DateTime.Now,UserId=2},
            // new News(){NewsTitle="Falcao Geldi",NewsContent="Amerikanın yaptırım kararını yasadan geçmesi ile dolarda yükseliş gözlemlendi",CategoryId=9,CreateDate=DateTime.Now,UserId=1}
            //};
            //context.News.AddRange(newsList);
            //context.SaveChanges();
            //List<Gallery> fotoList = new List<Gallery>()
            //{
            //    new Gallery(){NewsId=6,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=7,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=7,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=8,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=8,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=9,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=9,ImagePath="Assets/img/falcao2.jpg"},
            //    new Gallery(){NewsId=10,ImagePath="Assets/img/falcao2.jpg"}
            //};
            //context.Gallery.AddRange(fotoList);
            //context.SaveChanges();


            //List<Gallery> fotoList = new List<Gallery>()
            //{
            //    new Gallery(){NewsId=1,ImagePath="Assets/img/falcao.jpg"},
            //    new Gallery(){NewsId=2,ImagePath="Assets/img/falcao.jpg"},
            //    new Gallery(){NewsId=3,ImagePath="Assets/img/falcao.jpg"},
            //    new Gallery(){NewsId=4,ImagePath="Assets/img/falcao.jpg"},
            //    new Gallery(){NewsId=5,ImagePath="Assets/img/dolar.jpg"},
            //};
            //context.Gallery.AddRange(fotoList);
            //context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
