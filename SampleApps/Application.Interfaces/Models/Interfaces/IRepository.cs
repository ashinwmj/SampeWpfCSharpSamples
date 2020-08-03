using System;
using System.Collections.Generic;

namespace Application.Interfaces.Models.Interfaces
{
    public interface IRepository<T> where T:EntityBase
    {
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}
