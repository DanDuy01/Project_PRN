﻿namespace QuanLySinhVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbOpen = new System.Windows.Forms.TextBox();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.btSaveAs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.lbDOB = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(714, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbOpen
            // 
            this.tbOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOpen.Location = new System.Drawing.Point(55, 28);
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(555, 30);
            this.tbOpen.TabIndex = 1;
            // 
            // btOpen
            // 
            this.btOpen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btOpen.Location = new System.Drawing.Point(616, 19);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(94, 42);
            this.btOpen.TabIndex = 2;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSave.Location = new System.Drawing.Point(744, 19);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(94, 42);
            this.btSave.TabIndex = 3;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btSaveAs
            // 
            this.btSaveAs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSaveAs.Location = new System.Drawing.Point(871, 19);
            this.btSaveAs.Name = "btSaveAs";
            this.btSaveAs.Size = new System.Drawing.Size(94, 42);
            this.btSaveAs.TabIndex = 4;
            this.btSaveAs.Text = "SaveAs";
            this.btSaveAs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbID);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.rbFemale);
            this.panel1.Controls.Add(this.rbMale);
            this.panel1.Controls.Add(this.rbAll);
            this.panel1.Controls.Add(this.lbDOB);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Location = new System.Drawing.Point(752, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 365);
            this.panel1.TabIndex = 5;
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbID.Location = new System.Drawing.Point(69, 32);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(134, 30);
            this.tbID.TabIndex = 8;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbID.Location = new System.Drawing.Point(5, 32);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(27, 23);
            this.lbID.TabIndex = 7;
            this.lbID.Text = "ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbName.Location = new System.Drawing.Point(69, 82);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(279, 30);
            this.tbName.TabIndex = 5;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbFemale.Location = new System.Drawing.Point(83, 294);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 27);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMale.Location = new System.Drawing.Point(83, 249);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 27);
            this.rbMale.TabIndex = 3;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAll.Location = new System.Drawing.Point(83, 201);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(129, 27);
            this.rbAll.TabIndex = 2;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "Male/Female";
            this.rbAll.UseVisualStyleBackColor = true;
            // 
            // lbDOB
            // 
            this.lbDOB.AutoSize = true;
            this.lbDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDOB.Location = new System.Drawing.Point(5, 144);
            this.lbDOB.Name = "lbDOB";
            this.lbDOB.Size = new System.Drawing.Size(45, 23);
            this.lbDOB.TabIndex = 1;
            this.lbDOB.Text = "DOB";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(5, 85);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(56, 23);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(905, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAdd.Location = new System.Drawing.Point(821, 551);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(207, 42);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Add New Student";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 647);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSaveAs);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.tbOpen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "QuanLySinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbOpen;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btSaveAs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.Label lbDOB;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btAdd;
    }
}