using Dapper;
using DataAccess.Entities;
using DataAccess.Infrastructure.Interfaces;
using DataAccess.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class ClassRegisterRepository : Repository<ClassRegister>, IClassRegisterRepository
    {
        public ClassRegisterRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<IEnumerable<ClassRegister>> GetAllStudentsByClassAsync(int classId)
        {
            var query = "GetClassRegisterByClassId";
            var param = new DynamicParameters();
            param.Add("@classId", classId);
            var registeredStudents = await SqlMapper.QueryAsync<ClassRegister>(Connection, query, param,
                commandType: System.Data.CommandType.StoredProcedure);
            return registeredStudents;
        }
    }
}
