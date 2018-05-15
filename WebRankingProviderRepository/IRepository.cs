using System;
using System.Linq;

namespace WebRankingProviderRepository
{
    public interface IRepository<T>
    {
        IQueryable<T> List();
        bool Create(T item);
        bool Delete(long id);
        T Get(long id);
        bool SaveChanges();
    }
}
