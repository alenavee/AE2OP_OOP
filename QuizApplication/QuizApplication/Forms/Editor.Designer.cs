
namespace QuizApplication.Forms
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameQuiz = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.codeQuiz = new System.Windows.Forms.TextBox();
            this.codeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.questionBox = new System.Windows.Forms.TextBox();
            this.option1Box = new System.Windows.Forms.TextBox();
            this.option2Box = new System.Windows.Forms.TextBox();
            this.option3Box = new System.Windows.Forms.TextBox();
            this.option4Box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkOptionA = new System.Windows.Forms.CheckBox();
            this.checkOptionB = new System.Windows.Forms.CheckBox();
            this.checkOptionC = new System.Windows.Forms.CheckBox();
            this.checkOptionD = new System.Windows.Forms.CheckBox();
            this.createQuiz = new System.Windows.Forms.Button();
            this.addQuestion = new System.Windows.Forms.Button();
            this.listQuestions = new System.Windows.Forms.ListBox();
            this.deleteQuestion = new System.Windows.Forms.Button();
            this.saveQuiz = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.seeAnswers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // nameQuiz
            // 
            this.nameQuiz.Location = new System.Drawing.Point(106, 85);
            this.nameQuiz.Name = "nameQuiz";
            this.nameQuiz.Size = new System.Drawing.Size(125, 27);
            this.nameQuiz.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(27, 88);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name: ";
            // 
            // codeQuiz
            // 
            this.codeQuiz.Location = new System.Drawing.Point(106, 133);
            this.codeQuiz.Name = "codeQuiz";
            this.codeQuiz.Size = new System.Drawing.Size(125, 27);
            this.codeQuiz.TabIndex = 2;
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(27, 140);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(51, 20);
            this.codeLabel.TabIndex = 3;
            this.codeLabel.Text = "Code: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 193);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // questionBox
            // 
            this.questionBox.Location = new System.Drawing.Point(454, 26);
            this.questionBox.Name = "questionBox";
            this.questionBox.Size = new System.Drawing.Size(217, 27);
            this.questionBox.TabIndex = 5;
            // 
            // option1Box
            // 
            this.option1Box.Location = new System.Drawing.Point(546, 100);
            this.option1Box.Name = "option1Box";
            this.option1Box.Size = new System.Drawing.Size(125, 27);
            this.option1Box.TabIndex = 6;
            // 
            // option2Box
            // 
            this.option2Box.Location = new System.Drawing.Point(546, 148);
            this.option2Box.Name = "option2Box";
            this.option2Box.Size = new System.Drawing.Size(125, 27);
            this.option2Box.TabIndex = 7;
            // 
            // option3Box
            // 
            this.option3Box.Location = new System.Drawing.Point(546, 198);
            this.option3Box.Name = "option3Box";
            this.option3Box.Size = new System.Drawing.Size(125, 27);
            this.option3Box.TabIndex = 8;
            // 
            // option4Box
            // 
            this.option4Box.Location = new System.Drawing.Point(546, 244);
            this.option4Box.Name = "option4Box";
            this.option4Box.Size = new System.Drawing.Size(125, 27);
            this.option4Box.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Option A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Option B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Option C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Option D";
            // 
            // checkOptionA
            // 
            this.checkOptionA.AutoSize = true;
            this.checkOptionA.Location = new System.Drawing.Point(700, 106);
            this.checkOptionA.Name = "checkOptionA";
            this.checkOptionA.Size = new System.Drawing.Size(18, 17);
            this.checkOptionA.TabIndex = 15;
            this.checkOptionA.UseVisualStyleBackColor = true;
            this.checkOptionA.Click += new System.EventHandler(this.checkOptionA_Clicked);
            // 
            // checkOptionB
            // 
            this.checkOptionB.AutoSize = true;
            this.checkOptionB.Location = new System.Drawing.Point(700, 154);
            this.checkOptionB.Name = "checkOptionB";
            this.checkOptionB.Size = new System.Drawing.Size(18, 17);
            this.checkOptionB.TabIndex = 16;
            this.checkOptionB.UseVisualStyleBackColor = true;
            this.checkOptionB.Click += new System.EventHandler(this.checkOptionB_Clicked);
            // 
            // checkOptionC
            // 
            this.checkOptionC.AutoSize = true;
            this.checkOptionC.Location = new System.Drawing.Point(700, 204);
            this.checkOptionC.Name = "checkOptionC";
            this.checkOptionC.Size = new System.Drawing.Size(18, 17);
            this.checkOptionC.TabIndex = 17;
            this.checkOptionC.UseVisualStyleBackColor = true;
            this.checkOptionC.Click += new System.EventHandler(this.checkOptionC_Clicked);
            // 
            // checkOptionD
            // 
            this.checkOptionD.AutoSize = true;
            this.checkOptionD.Location = new System.Drawing.Point(700, 251);
            this.checkOptionD.Name = "checkOptionD";
            this.checkOptionD.Size = new System.Drawing.Size(18, 17);
            this.checkOptionD.TabIndex = 18;
            this.checkOptionD.UseVisualStyleBackColor = true;
            this.checkOptionD.Click += new System.EventHandler(this.checkOptionD_Clicked);
            // 
            // createQuiz
            // 
            this.createQuiz.Location = new System.Drawing.Point(106, 242);
            this.createQuiz.Name = "createQuiz";
            this.createQuiz.Size = new System.Drawing.Size(94, 29);
            this.createQuiz.TabIndex = 19;
            this.createQuiz.Text = "Create";
            this.createQuiz.UseVisualStyleBackColor = true;
            this.createQuiz.Click += new System.EventHandler(this.createQuiz_Click);
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(561, 293);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(94, 29);
            this.addQuestion.TabIndex = 20;
            this.addQuestion.Text = "Add Question";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // listQuestions
            // 
            this.listQuestions.FormattingEnabled = true;
            this.listQuestions.ItemHeight = 20;
            this.listQuestions.Location = new System.Drawing.Point(12, 310);
            this.listQuestions.Name = "listQuestions";
            this.listQuestions.Size = new System.Drawing.Size(291, 124);
            this.listQuestions.TabIndex = 21;
            this.listQuestions.SelectedIndexChanged += new System.EventHandler(this.listQuestions_SelectedIndexChanged);
            // 
            // deleteQuestion
            // 
            this.deleteQuestion.Location = new System.Drawing.Point(329, 355);
            this.deleteQuestion.Name = "deleteQuestion";
            this.deleteQuestion.Size = new System.Drawing.Size(125, 29);
            this.deleteQuestion.TabIndex = 22;
            this.deleteQuestion.Text = "Delete";
            this.deleteQuestion.UseVisualStyleBackColor = true;
            this.deleteQuestion.Click += new System.EventHandler(this.deleteQuestion_Click);
            // 
            // saveQuiz
            // 
            this.saveQuiz.Location = new System.Drawing.Point(542, 376);
            this.saveQuiz.Name = "saveQuiz";
            this.saveQuiz.Size = new System.Drawing.Size(129, 54);
            this.saveQuiz.TabIndex = 23;
            this.saveQuiz.Text = "Save";
            this.saveQuiz.UseVisualStyleBackColor = true;
            this.saveQuiz.Click += new System.EventHandler(this.saveQuiz_Click);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(12, 12);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(94, 29);
            this.goBack.TabIndex = 24;
            this.goBack.Text = "Go Back";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Solution";
            // 
            // seeAnswers
            // 
            this.seeAnswers.Location = new System.Drawing.Point(329, 310);
            this.seeAnswers.Name = "seeAnswers";
            this.seeAnswers.Size = new System.Drawing.Size(125, 29);
            this.seeAnswers.TabIndex = 26;
            this.seeAnswers.Text = "See answers";
            this.seeAnswers.UseVisualStyleBackColor = true;
            this.seeAnswers.Click += new System.EventHandler(this.seeAnswers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 224);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz Info";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 478);
            this.Controls.Add(this.seeAnswers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.saveQuiz);
            this.Controls.Add(this.deleteQuestion);
            this.Controls.Add(this.listQuestions);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.createQuiz);
            this.Controls.Add(this.checkOptionD);
            this.Controls.Add(this.checkOptionC);
            this.Controls.Add(this.checkOptionB);
            this.Controls.Add(this.checkOptionA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.option4Box);
            this.Controls.Add(this.option3Box);
            this.Controls.Add(this.option2Box);
            this.Controls.Add(this.option1Box);
            this.Controls.Add(this.questionBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.codeLabel);
            this.Controls.Add(this.codeQuiz);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameQuiz);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameQuiz;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox codeQuiz;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox questionBox;
        private System.Windows.Forms.TextBox option1Box;
        private System.Windows.Forms.TextBox option2Box;
        private System.Windows.Forms.TextBox option3Box;
        private System.Windows.Forms.TextBox option4Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkOptionA;
        private System.Windows.Forms.CheckBox checkOptionB;
        private System.Windows.Forms.CheckBox checkOptionC;
        private System.Windows.Forms.CheckBox checkOptionD;
        private System.Windows.Forms.Button createQuiz;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.ListBox listQuestions;
        private System.Windows.Forms.Button deleteQuestion;
        private System.Windows.Forms.Button saveQuiz;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button seeAnswers;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}