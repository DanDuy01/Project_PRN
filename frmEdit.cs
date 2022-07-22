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
    public partial class frmEdit : Form
    {
        public Student CurrentStudent { get; }

        public frmEdit()
        {
            InitializeComponent();
        }

        public frmEdit(Student s)
        {
            InitializeComponent();
            CurrentStudent = s;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if (CurrentStudent != null)
                tbId.Text = CurrentStudent.Id.ToString();
            tbName.Text = CurrentStudent.Name;
            dtpDob.Value = CurrentStudent.Dob;

            cbAddress.DataSource = AddressManagement.GetAddre();
            cbAddress.SelectedItem = CurrentStudent.Address;

            tbMajor.Text = CurrentStudent.Major;

            cbScho.DataSource = SchoManagement.GetScho();
            cbScho.SelectedItem = CurrentStudent.Scholarship;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbId.Text);
            string name = tbName.Text;
            DateTime dob = dtpDob.Value;
            string address = cbAddress.Text;
            string major = tbMajor.Text;
            string scholarship = cbScho.Text;
            DialogResult result = MessageBox.Show("Are you sure about that?", "Confirm",
                MessageBoxButtons.OKCancel);
            switch (result)
            {
                case DialogResult.OK:
                    {
                        StudentManagement.UpdateS(name, dob.ToString("MM/dd/yyyy"), address, major, scholarship, id.ToString());
                        MessageBox.Show("Update successfully!");
                        this.Text = "[OK]";
                        this.Close();

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
}
