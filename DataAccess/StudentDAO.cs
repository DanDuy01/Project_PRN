using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLySinhVien.DataAccess
{
    class StudentDAO
    {
        public static List<Student> GetAllStudents()
        {
            string sql = "Select * from Student";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> list = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Student(
                    Convert.ToInt32(dr["Id"]),
                    dr["Name"].ToString(),
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Address"].ToString(),
                    dr["Major"].ToString(),
                    dr["Scholarship"].ToString()));
            return list;
        }

        public static List<Student> GetStudentByID(int st_id)
        {
            List<Student> list = new List<Student>();
            string sql = "select * from Student where id = @st_id";
            DataTable dt = DAO.GetDataBySql(sql);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Student(st_id, 
                    dr["Name"].ToString(),
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Address"].ToString(),
                    dr["major"].ToString(),
                    dr["scholarship"].ToString()));
            }
            return list;
        }

        public static void UpdateStudent(string name, string dob, string address, string major, string scholarship, string id)
        {
            string sql = "update Student set" +
                " Name='" + name + " ', " +
                " Dob= '" + dob + "'," +
                " Address = '" + address + "' ," +
                " Major = '" + major + "', " +
                " scholarship = " + scholarship + " " +
                "where id = " + id;
            DAO.CRUD(sql);
        }

        public static void DeleteStudent(string id)
        {
            string sql = "delete from Student where id = " + id;
            DAO.CRUD(sql);
        }

        public static int EditStudent(Student s)
        {
            string sql = @"update Student set
                            Name=@name,
                            Dob=@dob,
                            Address=@address,
                            Major=@major,
                            scholarship=@scho
                           where Id=@id";
            SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = s.Id;
            SqlParameter p2 = new SqlParameter("@name", SqlDbType.NVarChar);
            p2.Value = s.Name;
            SqlParameter p3 = new SqlParameter("@dob", SqlDbType.Date);
            p3.Value = s.Dob;
            SqlParameter p4 = new SqlParameter("@address", SqlDbType.NVarChar);
            p4.Value = s.Address;
            SqlParameter p5 = new SqlParameter("@major", SqlDbType.NVarChar);
            p5.Value = s.Major;            
            SqlParameter p6 = new SqlParameter("@scho", SqlDbType.NVarChar);
            p6.Value = s.Scholarship;
            return DAO.ExecuteSql(sql, p1, p2, p3, p4, p5, p6);
        }

        public static void AddStudent(string id, string name, string dob, string address, string major, string scholarship)
        {
            string sql = "insert into Student(id, name, dob, address, major, scholarship) " +
                " values(" + id + " , '" + name + "' , '" + dob + "' , '" + address + "' , " + major + " , " + scholarship + ")";
            DAO.CRUD(sql);
        }

    }
}
