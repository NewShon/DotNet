using System;
using System.Collections.Generic;

namespace DotNet.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(Func<T, Boolean> predicate);

        IEnumerable<T> Find(Func<T, Boolean> predicate);

        void Create(T entity);

        void Update(Func<T, Boolean> predicate, T entity);

        void Delete(Func<T, Boolean> predicate);
    }
}
