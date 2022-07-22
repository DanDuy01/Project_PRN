using QuanLySinhVien.Logics;
using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        List<Student> Students;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Students = StudentManagement.GetAllStudentsFromDB();
            dataGridView1.DataSource = Students;
            cbDob.DataSource = StudentManagement.GetAllYearOfDob(Students);
            cbMajor.DataSource = StudentManagement.GetMajors();
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = @"D:\PRN211\";
            dialog.Filter = "Text file|*.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = dialog.FileName;
                tbFileName.Text = FileName;
                Students = StudentManagement.GetAllStudents(FileName);
                dataGridView1.DataSource = Students;
                cbDob.DataSource = StudentManagement.GetAllYearOfDob(Students);
                cbMajor.DataSource = StudentManagement.GetAllMajors(Students);
            }
        }
        
    }
}
