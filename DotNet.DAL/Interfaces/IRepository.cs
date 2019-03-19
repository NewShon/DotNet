using System.Collections.Generic;

namespace DotNet.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get(string id);

        void Add(T entity);

	    void Update(T entity);

	    void Remove(string id);
    }
}
