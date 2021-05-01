using System.Data;

namespace DataAccess.Infrastructure.Interfaces
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
