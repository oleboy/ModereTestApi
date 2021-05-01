using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        IDbConnection Connection { get; }
        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
