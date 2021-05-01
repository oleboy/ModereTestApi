using System;

namespace ModereTest.Services
{
    public class InvalidClassException : Exception
    {
        public InvalidClassException(int classId) : base($"Class does not exist: {classId}")
        {
        }
    }
}
