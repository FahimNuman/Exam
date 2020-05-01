using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Areas.Admin.Models
{
    public class StudentModel : StudentBaseModel
    {
        public StudentModel(IStudentService studentService) : base(studentService) { }
        public StudentModel() : base() { }

        internal object GetStudents(DataTablesAjaxRequestModel tableModel)
        {
            var data = _studentService.GetStudents(
                tableModel.PageIndex,
                tableModel.PageSize,
                tableModel.SearchText,
                tableModel.GetSortText(new string[] { "Name", "UserName", "Email", "CreateDate" }));

            return new
            {
                recordsTotal = data.total,
                recordsFiltered = data.totalDisplay,
                data = (from record in data.records
                        select new string[]
                        {
                                record.Name,
                                record.UserName,
                                record.Email,
                                record.CreateDate.ToString()
                        }
                    ).ToArray()

            };
        }
    }
}
