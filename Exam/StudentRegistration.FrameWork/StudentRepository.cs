using StudentRegistration.Data;
using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class StudentRepository : Repository<Student, int, FrameworkContext>, IStudentRepository
    {
        public StudentRepository(FrameworkContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Student> GetLatestStudents()
        {
            return Get(x => x.CreateDate < DateTime.Now.AddDays(-7)).ToList();
        }
    }
}
