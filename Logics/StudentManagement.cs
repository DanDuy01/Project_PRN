using QuanLySinhVien.DataAccess;
using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien.Logics
{
    class StudentManagement
    {
        List<Student> lstSt = new List<Student>();
        public List<Student> List { get; set; }

        public static List<Student> GetAllStudents(string FileName)
        {
            FileIO file = new FileIO(FileName);
            return file.ReadFromFile();
        }

        public static List<Student> GetAllStudentsFromDB()
        {
            return StudentDAO.GetAllStudents();
        }

        public static int EditStudent(Student s)
        {
            return StudentDAO.EditStudent(s);
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

        public static List<Student> SearchByAddress(List<Student> Students, string Address)
        {
            return Students.Where(x => x.Address.ToLower().Contains(Address.ToLower())).ToList();
        }

        public static List<Student> SearchByScho(List<Student> Students, string Scho)
        {
            return Students.Where(x => x.Scholarship.ToLower().Contains(Scho.ToLower())).ToList();
        }

        public static List<string> GetAllAddress(List<Student> Students)
        {
            List<string> items= Students.Select(x => x.Address.ToString()).Distinct().ToList();
            items.Insert(0, "All address");
            return items;
        }

        public static List<string> GetAllYearOfDob(List<Student> Students)
        {
            List<string> items = Students.Select(x => x.Dob.Year.ToString()).Distinct().ToList();
            items.Insert(0, "All years");
            return items;
        }

        public static List<string> GetAllScho(List<Student> Students)
        {
            List<string> items = Students.Select(x => x.Scholarship.ToString()).Distinct().ToList();
            items.Insert(0, "All scholarship");
            return items;
        }

        public static void UpdateS(string Name, String Dob, String Address, String Major, string Scholarship, string Id)
        {
            StudentDAO.UpdateStudent(Name, Dob, Address, Major, Scholarship, Id);
        }

        public static void DeleteS(string id)
        {
            StudentDAO.DeleteStudent(id);
        }

        public static void AddStudent(string id, string name, string dob, string address, string major, string scholar)
        {
            StudentManagement.AddStudent(id, name, dob, address, major, scholar);
        }

        public static bool isNumber(string s)
        {
            return s.All(char.IsNumber);
        }

        public static bool IsDateTime(string txtDate)
        {
            DateTime tempDate;
            return DateTime.TryParse(txtDate, out tempDate);
        }
    }
}
