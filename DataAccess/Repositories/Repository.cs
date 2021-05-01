using DataAccess.Infrastructure.Interfaces;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly IDbConnection connection;

        public Repository(IConnectionFactory connectionFactory)
        {
            connection = connectionFactory.GetConnection();
        }

        public IDbConnection Connection => connection;

        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }

        public TEntity Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
