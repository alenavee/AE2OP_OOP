using Newtonsoft.Json;
using QuizApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuizApplication.Forms
{
    public partial class StudentForm : Form
    {
        private User Student;
        List<Quiz> quiz_list;

        public StudentForm(User student)
        {
            InitializeComponent();
            this.Student = student;
            loggedInName.Text = Student.FirstName + ' ' + Student.LastName;

            string path = @"E:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Quizes.json";
            string json = File.ReadAllText(path);
            quiz_list = JsonConvert.DeserializeObject<List<Quiz>>(json);                   

        }

        
        private void logOutButton_Click(object sender, EventArgs e)
        {
            
                LoginForm loginUI = new LoginForm();
                loginUI.Show();
                this.Close();
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(codeBox.Text))
            {
                MessageBox.Show("Entered code was empty");
            }
            else
            {
                var findQuiz = quiz_list.Find(q => q.Code == codeBox.Text);
                if (findQuiz == null)
                {
                    MessageBox.Show("The quiz with entered code has not been found");
                }
                else
                {
                    string path = @"E:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Results.json";
                    string json = File.ReadAllText(path);


                    List<Evaluation> list_of_grades = JsonConvert.DeserializeObject<List<Evaluation>>(json);
                    if (list_of_grades.Exists(q =>q.quiz_name == findQuiz.Name & q.student_name ==
                    Student.FirstName + " " + Student.LastName)){
                        MessageBox.Show("You've already taken this quiz"); }
                    else { 

                    var questions = findQuiz.Questions;
                    MessageBox.Show("You entered the code for " + "'" + findQuiz.Name + "'" + ". You can start the attempt now");
                    QuizForm quizUI = new QuizForm(questions, Student, findQuiz.Name);
                    quizUI.Show();
                }
                }

            }
        }
    }
}
