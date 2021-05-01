using DataAccess.Entities;
using DataAccess.Infrastructure.Interfaces;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class StudentRepository : Repository<Class>, IStudentRepository
    {
        public StudentRepository(IConnectionFactory connectionFactory) : base(connectionFactory)
        {
        }

        public async Task<Student> GetStudentAsync(int studentId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
