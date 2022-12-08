using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? std { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
