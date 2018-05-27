using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CinemaBookingSystem.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Get 
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        //Add
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);


        //Delete
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
