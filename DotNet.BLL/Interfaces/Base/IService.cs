using System.Collections.Generic;

namespace DotNet.BLL.Interfaces.Base
{
    public interface IService<T>
    {
		IEnumerable<T> GetAll();

	    T Get(string id);

	    void Add(T entity);

	    void Update(T entity);

	    void Remove(string id);
	}
}
