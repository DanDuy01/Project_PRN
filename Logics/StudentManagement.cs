using QuanLySinhVien.DataAccess;
using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Logics
{
    class StudentManagement
    {
        public static List<Student> GetAllStudents(string FileName)
        {
            FileIO file = new FileIO(FileName);
            return file.ReadFromFile();
        }

        public static List<Student> GetAllStudentsFromDB()
        {
            //FileIO file = new FileIO(FileName);
            //return file.ReadFromFile();
            return StudentDAO.GetAllStudents();
        }

        public static int EditStudent(Student s)
        {
            return StudentDAO.EditStudent(s);
        }

        public static List<string> GetMajors()
        {
            return new List<string> { "SE" };
        }

        public static Student SearchById(List<Student> Students, int Id)
        {
            return Students.FirstOrDefault(x => x.Id == Id);
        }

        public static List<Student> SearchByName(List<Student> Students, string Name)
        {
            return Students.Where(x => x.Name.ToLower().Contains(Name.ToLower())).ToList();
        }

        public static List<Student> SearchByYearOfDob(List<Student> Students, int Year)
        {
            return Students.Where(x => x.Dob.Year == Year).ToList();
        }

        public static List<Student> SearchByMajors(List<Student> Students, List<string> Majors)
        {
            return Students.Where(x => Majors.IndexOf(x.Major) >= 0).ToList();
        }

        public static List<string> GetAllMajors(List<Student> Students)
        {
            return Students.Select(x => x.Major).Distinct().ToList();
        }

        public static List<string> GetAllYearOfDob(List<Student> Students)
        {
            List<string> items = Students.Select(x => x.Dob.Year.ToString()).Distinct().ToList();
            items.Insert(0, "All years");
            return items;
        }
    }
}
