using QuanLySinhVien.Logics;
using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        List<Student> Students;
        StudentManagement stu = new StudentManagement();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
            editcol.Name = "EditRow";
            editcol.Text = "Edit";
            editcol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editcol);
            
            Students = StudentManagement.GetAllStudentsFromDB();
            dataGridView1.DataSource = Students;
            cbDob.DataSource = StudentManagement.GetAllYearOfDob(Students);
            cbAddress.DataSource = AddressManagement.GetAddre();

            DataGridViewButtonColumn deleteStu = new DataGridViewButtonColumn();
            deleteStu.Name = "DeleteRow";
            deleteStu.Text = "Delete";
            deleteStu.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(deleteStu);
        }

        private void loadDataGirdView(Object sender, EventArgs e)
        {
            dataGridView1.DataSource = StudentManagement.GetAllStudentsFromDB();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("EditRow"))
            {
                List<Student> students = (List<Student>)dataGridView1.DataSource;
                string Name = students[e.RowIndex].Name;
                int Id = Convert.ToInt32(students[e.RowIndex].Id);
                students = StudentManagement.GetAllStudentsFromDB();
                dataGridView1.DataSource = students;

                //frmEdit newform = new frmEdit(students[e.RowIndex]);
                //newform.FormClosed += loadDataGirdView;
                //newform.Show();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("DeleteRow"))
            {
                List<Student> students = (List<Student>)dataGridView1.DataSource;
                string id = students[e.RowIndex].Id.ToString();
                DialogResult result = MessageBox.Show("Are you sure about that?", "Confirm",
                MessageBoxButtons.OKCancel);
                switch (result)
                {

                    case DialogResult.OK:
                        {
                            StudentManagement.DeleteS(id);
                            StudentManagement.DeleteS(id);
                            MessageBox.Show("Delete successfully!");
                            this.Text = "[OK]";
                            students = StudentManagement.GetAllStudentsFromDB();
                            dataGridView1.DataSource = students;
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            this.Text = "[Cancel]";
                            break;
                        }
                }
            }
        }

        private void frmEdit_Close(object sender, EventArgs e)
        {
            Students = StudentManagement.GetAllStudentsFromDB();
            btSearch_Click(sender, null);
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "OPEN";
            dialog.InitialDirectory = @"D:\PRN211\Project\QuanLySinhVien";
            dialog.Filter = "Text file|*.txt";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string FileName = dialog.FileName;
                tbFileName.Text = FileName;
                Students = StudentManagement.GetAllStudents(FileName);
                dataGridView1.DataSource = Students;
                cbDob.DataSource = StudentManagement.GetAllYearOfDob(Students);
                cbAddress.DataSource = StudentManagement.GetAllAddress(Students);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (Students is null)
            {
                MessageBox.Show("Need load data first!");
                return;
            }
            List<Student> Results = new List<Student>();

            if (!tbId.Text.Trim().Equals(String.Empty))
            {
                Results.Add(StudentManagement.SearchById(Students, Convert.ToInt32(tbId.Text.Trim())));
            }
            else
            {
                Results.AddRange(Students);
                //co dieu kien Name ko?
                if (!tbName.Text.Trim().Equals(String.Empty))
                    Results = StudentManagement.SearchByName(Results, tbName.Text.Trim());
                //co dieu kien Year of Dob?
                if (cbDob.SelectedIndex != 0)
                    Results = StudentManagement.SearchByYearOfDob(Results, Convert.ToInt32(cbDob.SelectedItem));
                //co dieu kien Address?
                if (cbAddress.SelectedIndex != 0)
                    Results = StudentManagement.SearchByAddress(Results, Convert.ToString(cbAddress.SelectedItem));
            }
            dataGridView1.DataSource = Results;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Students is null)
            {
                MessageBox.Show("Need to load data!");
                return;
            }
            string content1 = "";
            string path = tbFileName.Text;
            foreach (Student s in Students)
            {
                content1 += s.ToString();
            }
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text file|*.txt";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sf.FileName);
                sw.Write(content1);
                MessageBox.Show("Save successfuly!");
                sw.Dispose();
                sw.Close();
            }
        }
    }
}
