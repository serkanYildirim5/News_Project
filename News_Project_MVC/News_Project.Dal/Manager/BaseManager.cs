using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Project.Dal.Manager
{
    public class BaseManager<TEntity> where TEntity : class
    {
        News_ProjectContext context;
        public BaseManager()
        {
            context = new News_ProjectContext();

        }

        public void AddManager(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void UpdateManager(TEntity entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteManager(TEntity entity)
        {

            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public void DeleteIdManager(TEntity entity)
        {

            context.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
        public TEntity GetByIdManager(int id)
        {

            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAllManager()
        {

            return context.Set<TEntity>().ToList();
        }
    }
}
