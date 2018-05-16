using System;
using System.Collections.Generic;
using System.Linq;

namespace WebRankingProviderRepository
{
    public interface IRepository<T>
    {
        IEnumerable<T> List();
        bool Create(T item);
        bool Delete(long id);
        T Get(long id);
        bool SaveChanges();
    }
}
