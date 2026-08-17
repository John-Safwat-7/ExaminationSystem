using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationSystem.Domain.Models
{
    public class Instructor
    {
       public int Id { get; set; }
      public  string Name { get; set;  }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
       public List<Course> Courses { get; set; } = new List<Course>();

    }
}
