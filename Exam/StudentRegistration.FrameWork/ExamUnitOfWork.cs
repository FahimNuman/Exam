using StudentRegistration.Data;
using StudentRegistration.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    public class ExamUnitOfWork : UnitOfWork, IExamUnitOfWork
    {
        public IStudentRepository StudentRepositroy { get; set; }

        public ExamUnitOfWork(FrameworkContext context, IStudentRepository studentRepositroy)
            : base(context)
        {
            StudentRepositroy = studentRepositroy;

        }
    }
}
