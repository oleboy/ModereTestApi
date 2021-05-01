using DataAccess.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.Common;

namespace DataAccess.Infrastructure
{
    public class SqlConnectionFactory : IConnectionFactory
    {
        private readonly string connectionString;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("Modere");
        }

        public IDbConnection GetConnection()
        {
            var factory = DbProviderFactories.GetFactory("Microsoft.Data.SqlClient");
            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            return connection;
        }
    }
}
