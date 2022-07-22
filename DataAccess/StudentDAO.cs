using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DataAccess
{
    class StudentDAO
    {
        public static List<Student> GetAllStudents()
        {
            string sql = "Select * from Students";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> list = new List<Student>();
            foreach (DataRow dr in dt.Rows)
                list.Add(new Student(
                    Convert.ToInt32(dr["Id"]),
                    dr["Name"].ToString(),
                    Convert.ToDateTime(dr["Dob"]),
                    dr["Major"].ToString(),
                    Convert.ToDouble(dr["Scholarship"])));
            return list;
        }

        public static int EditStudent(Student s)
        {
            string sql = @"update Students set
                            Name=@name,
                            Dob=@dob,
                            Major=@major,
                            Scholarship=@scho
                           where Id=@id";
            SqlParameter p1 = new SqlParameter("@id", SqlDbType.Int);
            p1.Value = s.Id;
            SqlParameter p2 = new SqlParameter("@name", SqlDbType.NVarChar);
            p2.Value = s.Name;
            SqlParameter p3 = new SqlParameter("@dob", SqlDbType.Date);
            p3.Value = s.Dob;
            SqlParameter p4 = new SqlParameter("@major", SqlDbType.NVarChar);
            p4.Value = s.Major;
            SqlParameter p5 = new SqlParameter("@scho", SqlDbType.Float);
            p5.Value = s.Scholarship;
            return DAO.ExecuteSql(sql, p1, p2, p3, p4, p5);
        }
    }
}
