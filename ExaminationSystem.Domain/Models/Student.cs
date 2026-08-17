using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public string PasswordHash { get; set; }
        public Department Department { get; set; }

    }
}
