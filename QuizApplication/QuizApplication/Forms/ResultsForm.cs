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
    public partial class ResultsForm : Form
    {
        User user_logged;
        string quiz_name;
        public ResultsForm(List<Question> quizQuestions, Dictionary<int, Tuple<String, CheckBox>> chosenAnswers, 
            int numberOfQuestions, User user_info, string quiz)
        {
            InitializeComponent();

            this.user_logged = user_info;
            this.quiz_name = quiz;

            //Total Questions
            labelTotalA.Text = numberOfQuestions.ToString();

            //Calculate Correct Answers
            double correctAnswers = checkAnswers(quizQuestions, chosenAnswers);
            labelCorrectA.Text = correctAnswers.ToString();

            //Calculate IncorrectAnswer Answers
            double incorrectAnswers = (quizQuestions.Count - correctAnswers);
            labelIncorrect.Text = incorrectAnswers.ToString();

            //Calculate Score
            double score = Math.Round(correctAnswers / quizQuestions.Count * 100, 0);
            labelScoreA.Text = score.ToString() + "%";

            if (user_logged.Role == 0) {
                Evaluation result = new Evaluation();
                result.student_name = user_logged.FirstName+" "+user_logged.LastName;
                result.quiz_name = quiz_name;
                result.grade = score;

                string path = @"D:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Results.json";

                string json = File.ReadAllText(path);
                var list = JsonConvert.DeserializeObject<List<Evaluation>>(json);
                list.Add(result);
                JsonSerializer serializer = new JsonSerializer();
                serializer.NullValueHandling = NullValueHandling.Ignore;

                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, list);
                }

            }

        }

        private int checkAnswers(List<Question> quizQuestions, Dictionary<int, Tuple<String, CheckBox>> chosenAnswers)
        {
            int correctAnswers = 0;
            for (int i = 0; i < quizQuestions.Count; i++)
            {
                if (quizQuestions[i].correctAnswer == chosenAnswers[i].Item1)
                {
                    correctAnswers++;
                }
            }
            return correctAnswers;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
