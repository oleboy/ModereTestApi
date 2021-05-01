using Dapper;
using DataAccess.Entities;
using DataAccess.Infrastructure.Interfaces;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ClassRepository : Repository<Class>, IClassRepository
    {

        public ClassRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<Class> GetClassAsync(int classId)
        {
            // Would normally put this in a stored procedure:
            var query = "SELECT * FROM dbo.Class WHERE ClassId = @classId";

            var param = new DynamicParameters();
            param.Add("@classId", classId);
            var cls = await SqlMapper.QuerySingleOrDefaultAsync<Class>(Connection, query, param,
                commandType: System.Data.CommandType.Text);
            return cls;
        }

        public Task<IEnumerable<Class>> GetClasses()
        {
            throw new NotImplementedException();
        }
    }
}
