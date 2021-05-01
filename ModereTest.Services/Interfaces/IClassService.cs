using ModereTest.Models;
using System.Threading.Tasks;

namespace ModereTest.Services.Interfaces
{
    public interface IClassService
    {
        Task<ClassStudents> GetClassRegisterByClassIdAsync(int classId);
    }
}
