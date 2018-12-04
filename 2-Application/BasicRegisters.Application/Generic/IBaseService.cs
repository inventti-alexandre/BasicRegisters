using System;
using System.Collections.Generic;

namespace BasicRegisters.Application.Generic
{
    public interface IBaseService<T>
    {
        bool Delete(Guid id);

        T Edit(T dto);

        T GetById(Guid id);

        T RegitrarErros();

        List<T> GetAll();

        T Add(T dto);
    }
}