﻿using StudentRegistration.FrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Areas.Admin.Models
{
    public class CreateStudentModel : StudentBaseModel
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public CreateStudentModel(IStudentService studentService) : base(studentService) { }
        public CreateStudentModel() : base() { }

        public void Create()
        {
            var student = new Student
            {
                Name = this.Name,
                UserName = this.UserName,
                Email = this.Email,
                CreateDate = DateTime.Now
            };

            _studentService.CreateStudent(student);
        }
    }
}