using System;

namespace QuanLySinhVien.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public string Major { get; set; }
        public string Scholarship { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, DateTime dob, string address, string major, string scholarship)
        {
            Id = id;
            Name = name;
            Dob = dob;
            Address = address;
            Major = major;
            Scholarship = scholarship;
        }

        public override string? ToString()
        {
            return Id + "|" + Name + "|" + Dob.ToString("dd MMM yyyy") + "|" + Address + "|" + Major + "|" + Scholarship + "\n";
        }
    }
}
