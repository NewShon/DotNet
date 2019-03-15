using System;
using System.Collections.Generic;

namespace DotNet.BLL.Interfaces.Base
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        IEnumerable<T> Find(T entity);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
