using Newtonsoft.Json;
using QuizApplication.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuizApplication.Forms
{
    public partial class EvaluationForm : Form
    {
        List<Quiz> list_of_quizes;
        List<Evaluation> list_of_grades;
        string selectedItem;
        public EvaluationForm(List<Quiz> quizes)
        {
            InitializeComponent();

            this.list_of_quizes = quizes;
            string path = @"D:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Results.json";
            string json = File.ReadAllText(path);
            list_of_grades = JsonConvert.DeserializeObject<List<Evaluation>>(json);

            foreach (var q in list_of_quizes)
            {
                quizesList.Items.Add(q.Name);
            }

        }

        private void quizesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = quizesList.SelectedItem.ToString();

            List<Evaluation> grades_for_quiz = list_of_grades.FindAll(q => q.quiz_name == selectedItem);

            gradesList.Items.Clear();

            foreach (var g in grades_for_quiz)
            {
                gradesList.Items.Add(g.student_name + " " + g.grade + "%");
            }

        }
    }
}
