
namespace Assignment2
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
            this.addStudent = new System.Windows.Forms.Button();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SemesterNum = new System.Windows.Forms.NumericUpDown();
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.findStudent = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listStudents = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nextSemester = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.position = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SemesterNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(136, 180);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(168, 29);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Add student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(136, 44);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(168, 27);
            this.LastName.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(136, 91);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(168, 27);
            this.FirstName.TabIndex = 2;
            // 
            // SemesterNum
            // 
            this.SemesterNum.Location = new System.Drawing.Point(136, 135);
            this.SemesterNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.SemesterNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SemesterNum.Name = "SemesterNum";
            this.SemesterNum.Size = new System.Drawing.Size(43, 27);
            this.SemesterNum.TabIndex = 3;
            this.SemesterNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Location = new System.Drawing.Point(43, 98);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(83, 20);
            this.firstName_label.TabIndex = 4;
            this.firstName_label.Text = "First Name:";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Location = new System.Drawing.Point(43, 51);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(82, 20);
            this.lastName_label.TabIndex = 5;
            this.lastName_label.Text = "Last Name:";
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Location = new System.Drawing.Point(43, 142);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(73, 20);
            this.semester.TabIndex = 6;
            this.semester.Text = "Semester:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New student";
            // 
            // findStudent
            // 
            this.findStudent.Location = new System.Drawing.Point(31, 73);
            this.findStudent.Name = "findStudent";
            this.findStudent.Size = new System.Drawing.Size(125, 27);
            this.findStudent.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(365, 288);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 104);
            this.listBox1.TabIndex = 9;
            // 
            // listStudents
            // 
            this.listStudents.AutoSize = true;
            this.listStudents.Location = new System.Drawing.Point(365, 241);
            this.listStudents.Name = "listStudents";
            this.listStudents.Size = new System.Drawing.Size(111, 20);
            this.listStudents.TabIndex = 10;
            this.listStudents.Text = "List of students:";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(31, 121);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 64);
            this.listBox2.TabIndex = 11;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(177, 71);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(94, 29);
            this.search.TabIndex = 12;
            this.search.Text = "Find";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.findStudent);
            this.groupBox2.Location = new System.Drawing.Point(348, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 212);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter last name:";
            // 
            // nextSemester
            // 
            this.nextSemester.Location = new System.Drawing.Point(365, 411);
            this.nextSemester.Name = "nextSemester";
            this.nextSemester.Size = new System.Drawing.Size(271, 33);
            this.nextSemester.TabIndex = 14;
            this.nextSemester.Text = "Move to next semester";
            this.nextSemester.UseVisualStyleBackColor = true;
            this.nextSemester.Click += new System.EventHandler(this.NextSemester_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteAll);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.delete);
            this.groupBox3.Controls.Add(this.position);
            this.groupBox3.Location = new System.Drawing.Point(12, 241);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 212);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete student";
            // 
            // deleteAll
            // 
            this.deleteAll.Location = new System.Drawing.Point(177, 131);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(94, 29);
            this.deleteAll.TabIndex = 16;
            this.deleteAll.Text = "Delete All";
            this.deleteAll.UseVisualStyleBackColor = true;
            this.deleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delete all students:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter student position:";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(177, 80);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(31, 80);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(125, 27);
            this.position.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.nextSemester);
            this.Controls.Add(this.listStudents);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.SemesterNum);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SemesterNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button nextSemester;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button deleteAll;

        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox findStudent;
        private System.Windows.Forms.TextBox position;

        private System.Windows.Forms.NumericUpDown SemesterNum;

        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.Label listStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

        
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;     
        
        
    }
}

