using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_interfejs.Interface
{
    public interface IBaseRepository<T, TEntity> where T : IEntity<TEntity>
    {
        void Create(T item);
        void Update(T item);
        List<T> GetAll();
        T Get(TEntity Id);
        void Delete(T item);
    }
}
