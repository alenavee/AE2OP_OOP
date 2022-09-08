using QuizApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Linq;

namespace QuizApplication.Forms
{
    public partial class TeacherForm : Form
    {
        private User Teacher;
        private List<Quiz> quiz_list;
        private string selectedItem;
        
        public TeacherForm(User loggedIn)
        {
            InitializeComponent();
            this.Teacher = loggedIn;
            label1.Text = Teacher.FirstName + ' ' + Teacher.LastName;
            string path = @"E:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Quizes.json";
            string json = File.ReadAllText(path);
            quiz_list = JsonConvert.DeserializeObject<List<Quiz>>(json);

            foreach (var q in quiz_list)
            {
                listQuizes.Items.Add(q.Name);
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginUI = new LoginForm();
            loginUI.Show();
            this.Close();
        }

        private void newQuiz_Click(object sender, EventArgs e)
        {
            Editor editorUI = new Editor(Teacher);
            editorUI.Show();
            this.Close();
        }

        private void listQuizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = listQuizes.SelectedItem.ToString();
        }

        private void testQuiz_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Select quiz or create new");
            }
            else
            {
                var findQuiz = quiz_list.Find(q => q.Name == selectedItem);
                var questions = findQuiz.Questions;
                QuizForm quizUI = new QuizForm(questions, Teacher, findQuiz.Name);
                quizUI.Show();
            }
        }

        private void seeCode_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Select quiz or create new");
            }
            else
            {
                var findQuiz = quiz_list.Find(q => q.Name == selectedItem);
                MessageBox.Show("Code for the quiz is " + findQuiz.Code + " and it is valid until " + findQuiz.Date.ToShortDateString());
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Select quiz or create new");
            }
            else {
                var findQuiz = quiz_list.Find(q => q.Name == selectedItem);
                string message = "Are you sure you want to delete the quiz " + "'" + findQuiz.Name+"'"+"?";
                string caption = "Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var item = quiz_list.Single(x => x.Name == selectedItem);
                    quiz_list.Remove(item);
                    listQuizes.Items.Clear();
                    foreach (var q in quiz_list)
                    {
                        listQuizes.Items.Add(q.Name);
                    }

                    string path = @"E:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Quizes.json";
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.NullValueHandling = NullValueHandling.Ignore;

                    using (StreamWriter sw = new StreamWriter(path))
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, quiz_list);
                    }

                    MessageBox.Show("The quiz has been deleted");

                }
            }
        }

        private void displayGrades_Click(object sender, EventArgs e)
        {
            EvaluationForm gradesUI = new EvaluationForm(quiz_list);
            gradesUI.Show();
        }
    }
}
