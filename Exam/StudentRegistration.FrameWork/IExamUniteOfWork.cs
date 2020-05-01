using StudentRegistration.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentRegistration.FrameWork
{
    {
    public interface IExamUnitOfWork : IUnitOfWork
    {
        IStudentRepository StudentRepositroy { get; set; }

    }
}
