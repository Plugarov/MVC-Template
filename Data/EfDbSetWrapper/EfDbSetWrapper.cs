using Data.Contacts;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace Data.EFWrapper
{
    public class EfDbSetWrapper<T> : IEfDbSetWrapper<T>
            where T : class
    {
        private readonly DemoDbContext efDbContext;
        private readonly IDbSet<T> dbSet;

        public EfDbSetWrapper(DemoDbContext efDbContext)
        {
            this.efDbContext = efDbContext;
            this.dbSet = efDbContext.Set<T>();
        }

        public IQueryable<T> All
        {
            get
            {
                return this.dbSet;
            }
        }

        public void Add(T entity)
        {
            DbEntityEntry entry = this.efDbContext.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.dbSet.Add(entity);
            }
        }

        public void Delete(T entity)
        {
            DbEntityEntry entry = this.efDbContext.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.dbSet.Attach(entity);
                this.dbSet.Remove(entity);
            }
        }
    }
}
