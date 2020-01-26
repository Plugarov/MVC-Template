using System.Data.Entity;
using Data.Models;

namespace Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("DefaultConnection")
        {

        }

        public new IDbSet<T> Set<T>()
            where T : class
        {
            return base.Set<T>();
        }

        public IDbSet<Server> Server { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            OnServerCreating(modelBuilder);
        }

        public void OnServerCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Server>()
                .Property(s => s.DateTimeCreated).IsRequired();
        }
    }
}
