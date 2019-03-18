using System.Collections.Generic;

namespace DotNet.BLL.Interfaces.Base
{
    public interface IService<T>
    {
		IEnumerable<T> GetAll();

	    T Get(T entity);

	    void Add(T entity);

	    void Update(T entity);

	    void Remove(T entity);
	}
}
