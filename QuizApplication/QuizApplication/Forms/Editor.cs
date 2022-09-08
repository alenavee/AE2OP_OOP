using QuizApplication.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;

namespace QuizApplication.Forms
{
    public partial class Editor : Form
    {
        Quiz new_quiz = new Quiz();
        private User Teacher;

        private string selectedItem;
        public Editor(User teacher)
        {
            InitializeComponent();
            disableQuestionAdd();

            this.Teacher = teacher;
        }

        private void createQuiz_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameQuiz.Text) || String.IsNullOrEmpty(codeQuiz.Text))
            {
                MessageBox.Show("Name or code cannot be empty");
            }
            else
            {
                string name = nameQuiz.Text;
                string code = codeQuiz.Text;;
                new_quiz.Name = name;
                new_quiz.Code = code;
                new_quiz.Date = dateTimePicker1.Value;
                new_quiz.Questions = new List<Question>();

                enableQuestionAdd();

                createQuiz.Enabled = false;
                nameQuiz.Enabled = false;
                codeQuiz.Enabled = false;
                dateTimePicker1.Enabled = false;
                                
            }
        }
                          
        private void addQuestion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(questionBox.Text) || String.IsNullOrEmpty(option1Box.Text) || String.IsNullOrEmpty(option2Box.Text)
                || String.IsNullOrEmpty(option3Box.Text) || String.IsNullOrEmpty(option4Box.Text))
            {
                MessageBox.Show("Question and answers cannot be empty");
            }
            else
            {
                string correct = correctAnswer();
                Question q = new Question();
                q.question = questionBox.Text;
                q.answerA = option1Box.Text;
                q.answerB = option2Box.Text;
                q.answerC = option3Box.Text;
                q.answerD = option4Box.Text;
                q.correctAnswer = correctAnswer();
                                
                new_quiz.Questions.Add(q);
                Update_listBox();
                clearOptionBoxes();

                MessageBox.Show("Question has been added!");
            } 
         }

        private void disableQuestionAdd()
        {
            questionBox.Enabled = false;
            option1Box.Enabled = false;
            option2Box.Enabled = false;
            option3Box.Enabled = false;
            option4Box.Enabled = false;

            checkOptionA.Enabled = false;
            checkOptionB.Enabled = false;
            checkOptionC.Enabled = false;
            checkOptionD.Enabled = false;

            addQuestion.Enabled = false;
            deleteQuestion.Enabled = false;
            seeAnswers.Enabled = false;
            saveQuiz.Enabled = false;
        }

        private void enableQuestionAdd()
        {
            questionBox.Enabled = true;
            option1Box.Enabled = true;
            option2Box.Enabled = true;
            option3Box.Enabled = true;
            option4Box.Enabled = true;

            checkOptionA.Enabled = true;
            checkOptionB.Enabled = true;
            checkOptionC.Enabled = true;
            checkOptionD.Enabled = true;

            addQuestion.Enabled = true;
            deleteQuestion.Enabled = true;
            seeAnswers.Enabled = true;
            saveQuiz.Enabled = true;
        }

        private void clearOptionBoxes()
        {
            questionBox.Clear();
            option1Box.Clear();
            option2Box.Clear();
            option3Box.Clear();
            option4Box.Clear();
        }

        private string correctAnswer()
        {
            string correct = "";
            if (checkOptionA.Checked)
            {
                correct = option1Box.Text;
            }
            else if(checkOptionB.Checked){
                correct = option2Box.Text;
            }else if (checkOptionC.Checked)
            {
                correct = option3Box.Text;
            }else if (checkOptionD.Checked)
            {
                correct = option4Box.Text;
            }
            return correct;
        }

        private void Update_listBox()
        {
            listQuestions.Items.Clear();
                        
            foreach (var q in new_quiz.Questions)
            {
                listQuestions.Items.Add(q.question);
            }
        }


        private void checkOptionA_Clicked(object sender, EventArgs e)
        {
            checkOptionA.Checked = true;
            checkOptionB.Checked = false;
            checkOptionC.Checked = false;
            checkOptionD.Checked = false;
        }

        private void checkOptionB_Clicked(object sender, EventArgs e)
        {
            checkOptionB.Checked = true;
            checkOptionA.Checked = false;
            checkOptionC.Checked = false;
            checkOptionD.Checked = false;
        }
        private void checkOptionC_Clicked(object sender, EventArgs e)
        {
            checkOptionC.Checked = true;
            checkOptionB.Checked = false;
            checkOptionA.Checked = false;
            checkOptionD.Checked = false;
        }
        private void checkOptionD_Clicked(object sender, EventArgs e)
        {
            checkOptionD.Checked = true;
            checkOptionB.Checked = false;
            checkOptionC.Checked = false;
            checkOptionA.Checked = false;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            string message = "Make sure you saved the quiz. Click OK to quit this window and go back";
            string caption = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.OK)
            {
                TeacherForm TeacherUI = new TeacherForm(Teacher);
                TeacherUI.Show();
                this.Close();
            }
        }

        private void saveQuiz_Click(object sender, EventArgs e)
        {

            string path = @"D:\AE2OP_OOP\QuizApplication\QuizApplication\Data\Quizes.json";
            
            string json = File.ReadAllText(path);
            var list= JsonConvert.DeserializeObject<List<Quiz>>(json);
            list.Add(new_quiz);

            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, list);
            }

            MessageBox.Show("The quiz has been saved");
        }

        private void listQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = listQuestions.SelectedItem.ToString();
        }

        private void seeAnswers_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Select question or add new");
            }
            else
            {
                var findQuestion = new_quiz.Questions.Find(q => q.question == selectedItem);
                MessageBox.Show("Option 1: " + findQuestion.answerA +
                    "\nOption 2: " + findQuestion.answerB +
                    "\nOption 3: " + findQuestion.answerC +
                    "\nOption 4: " + findQuestion.answerD +
                    "\nCorrect: " + findQuestion.correctAnswer);
                
            }
        }

        private void deleteQuestion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Select question or add new");
            }
            else {            
                    var findQuestion = new_quiz.Questions.Find(q => q.question == selectedItem);
                    string message = "Are you sure you want to delete the selected question?";
                    string caption = "Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                    var item = new_quiz.Questions.Single(x => x.question == selectedItem);
                    new_quiz.Questions.Remove(item);

                    Update_listBox();
                    
                }
            }
         }
    }
}
