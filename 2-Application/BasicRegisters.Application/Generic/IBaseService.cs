using System;

namespace BasicRegisters.Application.Generic
{
    public interface IBaseService<T>
    {
        bool Delete(Guid id);

        T Edit(T dto);

        T GetById(Guid id);

        T RegitrarErros();

        T Save(T dto);
    }
}