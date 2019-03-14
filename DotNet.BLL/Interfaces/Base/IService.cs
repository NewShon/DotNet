using System;
using System.Collections.Generic;

namespace DotNet.BLL.Interfaces.Base
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        IEnumerable<T> Find(Func<T, bool> predicate);

        void Create();

        void Update();

        void Delete();
    }
}
