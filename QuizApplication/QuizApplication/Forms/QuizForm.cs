using QuizApplication.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace QuizApplication.Forms
{
    public partial class QuizForm : Form
    {
        private int QuestionNumber;
        private Dictionary<int, Tuple<String, CheckBox>> chosenAnswers = new Dictionary<int, Tuple<string, CheckBox>>(); //Question, answerChosen
        private List<Question> QuizQuestions;
        User user_logged;
        string quiz_name;
        public QuizForm(List<Question> questions, User user, string quiz_name)
        {
            InitializeComponent();
            this.QuizQuestions = questions;
            this.user_logged = user;
            this.quiz_name = quiz_name;

            QuestionNumber = 0;

            initQuestions();

            if (QuizQuestions.First() == QuizQuestions.Last())
            {
                ButtonNext.Text = "Finish";
            }
        }

        private void initQuestions()
        {
            labelQuestionNumber.Text = "Question " + (QuestionNumber + 1);

            labelQuestionText.Text = QuizQuestions[QuestionNumber].question;

            //Posible answers
            labelAnswer1.Text = QuizQuestions[QuestionNumber].answerA;
            labelAnswer2.Text = QuizQuestions[QuestionNumber].answerB;
            labelAnswer3.Text = QuizQuestions[QuestionNumber].answerC;
            labelAnswer4.Text = QuizQuestions[QuestionNumber].answerD;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {

        }

        private void checkQuestion1_Click(object sender, EventArgs e)
        {

            checkQuestion2.Checked = false;
            checkQuestion3.Checked = false;
            checkQuestion4.Checked = false;

            if (checkQuestion1.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuestionNumber))
                {
                    chosenAnswers[QuestionNumber] = Tuple.Create(labelAnswer1.Text, checkQuestion1);
                }
                else
                {
                    chosenAnswers.Add(QuestionNumber, Tuple.Create(labelAnswer1.Text, checkQuestion1));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }

            }
            else
            {
                chosenAnswers.Remove(QuestionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }

            }


        }

        private void checkQuestion2_Click(object sender, EventArgs e)
        {
            checkQuestion1.Checked = false;
            checkQuestion3.Checked = false;
            checkQuestion4.Checked = false;
            if (checkQuestion2.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuestionNumber))
                {
                    chosenAnswers[QuestionNumber] = Tuple.Create(labelAnswer2.Text, checkQuestion2);
                }
                else
                {
                    chosenAnswers.Add(QuestionNumber, Tuple.Create(labelAnswer2.Text, checkQuestion2));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }
            }
            else
            {
                chosenAnswers.Remove(QuestionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }
            }

        }

        private void checkQuestion3_Click(object sender, EventArgs e)
        {

            checkQuestion1.Checked = false;
            checkQuestion2.Checked = false;
            checkQuestion4.Checked = false;
            if (checkQuestion3.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuestionNumber))
                {
                    chosenAnswers[QuestionNumber] = Tuple.Create(labelAnswer3.Text, checkQuestion3);
                }
                else
                {
                    chosenAnswers.Add(QuestionNumber, Tuple.Create(labelAnswer3.Text, checkQuestion3));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }
            }
            else
            {
                chosenAnswers.Remove(QuestionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }
            }
        }

        private void checkQuestion4_Click(object sender, EventArgs e)
        {

            checkQuestion1.Checked = false;
            checkQuestion2.Checked = false;
            checkQuestion3.Checked = false;

            if (checkQuestion4.Checked)
            {
                //Override the previous answer
                if (chosenAnswers.ContainsKey(QuestionNumber))
                {
                    chosenAnswers[QuestionNumber] = Tuple.Create(labelAnswer4.Text, checkQuestion4);
                }
                else
                {
                    chosenAnswers.Add(QuestionNumber, Tuple.Create(labelAnswer4.Text, checkQuestion4));
                }
                if (QuizQuestions.Count == chosenAnswers.Count)
                {
                    ButtonNext.Enabled = true;
                }
            }
            else
            {
                chosenAnswers.Remove(QuestionNumber);
                if (ButtonNext.Text == "Finish")
                {
                    ButtonNext.Enabled = false;
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {

            QuestionNumber -= 1;

            ButtonNext.Enabled = true;

            ButtonNext.Text = "Next";

            //If first question, Disable back button
            if (QuestionNumber == 0)
            {
                buttonBack.Enabled = false;
            }

            //Clear the button
            checkQuestion1.Checked = false;
            checkQuestion2.Checked = false;
            checkQuestion3.Checked = false;
            checkQuestion4.Checked = false;

            if (chosenAnswers.ContainsKey(QuestionNumber))
            {
                chosenAnswers[QuestionNumber].Item2.Checked = true;
            }

            initQuestions();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            //Check if this is the 2nd last
            if ((QuestionNumber + 1) == (QuizQuestions.Count - 1))
            {
                //Change NextBox text to Finish
                ButtonNext.Text = "Finish";

                if (chosenAnswers.Count != QuizQuestions.Count)
                {
                    ButtonNext.Enabled = false;
                }
                else
                {
                    ButtonNext.Enabled = true;
                }

            }

            //Check if this is the last question
            //If so, end the quiz and show results screen
            if ((QuestionNumber + 1) == QuizQuestions.Count)
            {
                //Hide Quiz Screen
                this.Close();
                //Show results screen
                ResultsForm resultsScreen = new ResultsForm(QuizQuestions, chosenAnswers, QuestionNumber + 1, user_logged, quiz_name);
                resultsScreen.Show();
                this.Hide();
            }
            else
            {
                QuestionNumber += 1;

                buttonBack.Enabled = true;

                checkQuestion1.Checked = false;
                checkQuestion2.Checked = false;
                checkQuestion3.Checked = false;
                checkQuestion4.Checked = false;

                if (chosenAnswers.ContainsKey(QuestionNumber))
                {
                    chosenAnswers[QuestionNumber].Item2.Checked = true;
                }

                initQuestions();
            }
        }

    }
}
