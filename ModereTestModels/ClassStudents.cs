using System.Collections.Generic;

namespace ModereTest.Models
{
    public class ClassStudents
    {
        public Class Class { get; set; }
        public IEnumerable<Student> Students { get; set; }
    }
}
