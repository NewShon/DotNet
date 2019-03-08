using System;
using System.Collections.Generic;

namespace DotNet.DAL.Interfaces
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T Get();

        IEnumerable<T> Find(Func<T, Boolean> predicate);

        void Create();

        void Update();

        void Delete();
    }
}
