using StudentRegistration.Data;
using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public interface IStudentRepository : IRepository<Student, int, FrameworkContext>
    {
        IList<Student> GetLatestStudents();
    }
}
