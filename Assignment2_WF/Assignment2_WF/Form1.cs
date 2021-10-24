using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_WF
{
    public partial class Form1 : Form

    {

        List<Student> studentList = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            
            string last_name = LastName.Text;
            string first_name = FirstName.Text;
            int semester = Convert.ToInt32(SemesterNum.Value);
            Student newStudent = new Student(last_name, first_name, semester);
            studentList.Add(newStudent);
            Update_listBox();

        }
        private void DeleteAll_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete all students?";
            string caption = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                studentList.Clear();
                Update_listBox();
            }
        }

        private void Update_listBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = studentList;
            listBox1.DisplayMember = "StudentInfo";
        }
        private void Search_Click(object sender, EventArgs e)
        {
                    
            listBox2.Items.Clear();
            string search_name = findStudent.Text;
            var foundStudents = studentList.FindAll(st => st.LastName == search_name);
            foreach (var st in foundStudents)
            {
                listBox2.Items.Add(st.StudentInfo);
            }
            if (listBox2.Items.Count == 0)
            {
                MessageBox.Show("User not found");
            }

        }

        private void NextSemester_Click(object sender, EventArgs e)
        {
            foreach (var st in studentList)
            {
                st.GoToNextSemester();
            }

            Update_listBox();
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(position.Text) || !Int32.TryParse(position.Text, out _))
            {
                MessageBox.Show("Invalid input");
            }

            try
            {
                int id = Convert.ToInt32(position.Text);
                studentList.RemoveAt(id);
                Update_listBox();
            }
            catch (Exception)
            {
                MessageBox.Show("Position out of range");
            }
        }
    }
}

