using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Domain.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Course> Courses { get; set; } = new List<Course>();

    }
}
