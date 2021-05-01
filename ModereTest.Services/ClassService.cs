using DataAccess.Repositories.Interfaces;
using ModereTest.Models;
using ModereTest.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModereTest.Services
{
    public class ClassService : IClassService
    {
        private readonly IClassRegisterRepository classRegisterRepository;
        private readonly IClassRepository classRepository;

        public ClassService(IClassRegisterRepository classRegisterRepository, IClassRepository classRepository)
        {
            this.classRegisterRepository = classRegisterRepository;
            this.classRepository = classRepository;
        }

        public async Task<ClassStudents> GetClassRegisterByClassIdAsync(int classId)
        {
            await ClassShouldExistAsync(classId);
            var list = await classRegisterRepository.GetAllStudentsByClassAsync(classId);
            if (list.Any())
            {
                // Would normally use a library like AutoMapper for these kinds of mapping operations,
                // but this is so simple in this case it was not deemed practical
                var students = new List<Student>();
                foreach (var classRegister in list)
                {
                    students.Add(new Student
                    {
                        StudentId = classRegister.StudentId,
                        FirstName = classRegister.FirstName,
                        LastName = classRegister.LastName
                    });
                }
                var classStudents = new ClassStudents
                {
                    Class = new Class
                    {
                        ClassId = classId,
                        ClassName = list.First().ClassName
                    },
                    Students = students
                };
                return classStudents;
            }
            return null;
        }

        private async Task ClassShouldExistAsync(int classId)
        {
            var cls = await classRepository.GetClassAsync(classId);
            if (cls == null)
            {
                throw new InvalidClassException(classId);
            }
        }
    }
}
