using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Models
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Major { get; set; }
        public Double Scholarship { get; set; }

        public Student(int id, string name, DateTime dob, string major, double scholarship)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Major = major;
            Scholarship = scholarship;
        }
    }
}
