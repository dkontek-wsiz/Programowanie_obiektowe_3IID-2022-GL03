using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Repositories
{
    public interface IBaseRepository<T, TEntity> where T: IEntity<TEntity>
    {
        void Create(T input);
        void Update(T input);
        List<T> GetAll();
        T Get(TEntity id);
        void Delete(TEntity id);
    }
}
