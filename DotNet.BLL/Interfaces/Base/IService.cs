﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet.BLL.Interfaces.Base
{
    public interface IService<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        IEnumerable<T> Find(Func<T, Boolean> predicate);

        void Create();

        void Update();

        void Delete();
    }
}