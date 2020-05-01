using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class StudentService : IStudentService, IDisposable
    {
        private IExamUnitOfWork _examUnitOfWork;

        public StudentService(IExamUnitOfWork examUnitOfWork)
        {
            _examUnitOfWork = examUnitOfWork;
        }

        public void CreateStudent(Student student)
        {
            _examUnitOfWork.StudentRepositroy.Add(student);
            _examUnitOfWork.Save();
        }

        public void Dispose()
        {
            _examUnitOfWork?.Dispose();
        }

        public (IList<Student> records, int total, int totalDisplay) GetStudents(int pageIndex, int pageSize, string searchText, string sortText)
        {
            var result = _examUnitOfWork.StudentRepositroy.GetAll().ToList();
            return (result, 0, 0);
        }
    }
}
