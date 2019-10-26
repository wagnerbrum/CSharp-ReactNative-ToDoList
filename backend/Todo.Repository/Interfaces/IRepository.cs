using System.Collections.Generic;
using Todo.Domain.Entities;

namespace Todo.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity
    {
        T Get(int id);
        IEnumerable<T> Get();
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}