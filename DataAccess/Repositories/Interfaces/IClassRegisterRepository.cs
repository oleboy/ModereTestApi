using DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Interfaces
{
    public interface IClassRegisterRepository
    {
        Task<IEnumerable<ClassRegister>> GetAllStudentsByClassAsync(int classId);
    }
}
