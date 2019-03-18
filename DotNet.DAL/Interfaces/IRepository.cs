using System.Collections.Generic;

namespace DotNet.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(T entity);

        void Add(T entity);

	    void Update(T entity);

	    void Remove(T entity);
    }
}
