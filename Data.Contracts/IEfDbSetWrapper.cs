using System.Linq;

namespace Data.Contacts
{
    public interface IEfDbSetWrapper<T>
        where T : class
    {
        IQueryable<T> All { get; }

        void Add(T entity);

        void Delete(T entity);
    }
}
