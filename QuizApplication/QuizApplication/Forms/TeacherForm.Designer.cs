
namespace QuizApplication.Forms
{
    partial class TeacherForm
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
            this.logOutButton = new System.Windows.Forms.Button();
            this.loggedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listQuizes = new System.Windows.Forms.ListBox();
            this.testQuiz = new System.Windows.Forms.Button();
            this.newQuiz = new System.Windows.Forms.Button();
            this.displayGrades = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.seeCode = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(166, 13);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(94, 29);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // loggedLabel
            // 
            this.loggedLabel.AutoSize = true;
            this.loggedLabel.Location = new System.Drawing.Point(26, 22);
            this.loggedLabel.Name = "loggedLabel";
            this.loggedLabel.Size = new System.Drawing.Size(122, 20);
            this.loggedLabel.TabIndex = 1;
            this.loggedLabel.Text = "You are signed in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listQuizes
            // 
            this.listQuizes.FormattingEnabled = true;
            this.listQuizes.ItemHeight = 20;
            this.listQuizes.Location = new System.Drawing.Point(26, 154);
            this.listQuizes.Name = "listQuizes";
            this.listQuizes.Size = new System.Drawing.Size(251, 184);
            this.listQuizes.TabIndex = 3;
            this.listQuizes.SelectedIndexChanged += new System.EventHandler(this.listQuizes_SelectedIndexChanged);
            // 
            // testQuiz
            // 
            this.testQuiz.Location = new System.Drawing.Point(298, 154);
            this.testQuiz.Name = "testQuiz";
            this.testQuiz.Size = new System.Drawing.Size(146, 29);
            this.testQuiz.TabIndex = 5;
            this.testQuiz.Text = "Test Quiz";
            this.testQuiz.UseVisualStyleBackColor = true;
            this.testQuiz.Click += new System.EventHandler(this.testQuiz_Click);
            // 
            // newQuiz
            // 
            this.newQuiz.Location = new System.Drawing.Point(26, 359);
            this.newQuiz.Name = "newQuiz";
            this.newQuiz.Size = new System.Drawing.Size(116, 29);
            this.newQuiz.TabIndex = 6;
            this.newQuiz.Text = "Create new";
            this.newQuiz.UseVisualStyleBackColor = true;
            this.newQuiz.Click += new System.EventHandler(this.newQuiz_Click);
            // 
            // displayGrades
            // 
            this.displayGrades.Location = new System.Drawing.Point(298, 309);
            this.displayGrades.Name = "displayGrades";
            this.displayGrades.Size = new System.Drawing.Size(146, 29);
            this.displayGrades.TabIndex = 7;
            this.displayGrades.Text = "Results Page";
            this.displayGrades.UseVisualStyleBackColor = true;
            this.displayGrades.Click += new System.EventHandler(this.displayGrades_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quiz name";
            // 
            // seeCode
            // 
            this.seeCode.Location = new System.Drawing.Point(298, 206);
            this.seeCode.Name = "seeCode";
            this.seeCode.Size = new System.Drawing.Size(146, 29);
            this.seeCode.TabIndex = 9;
            this.seeCode.Text = "See code and date";
            this.seeCode.UseVisualStyleBackColor = true;
            this.seeCode.Click += new System.EventHandler(this.seeCode_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(298, 259);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(146, 29);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete Quiz";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 413);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.seeCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayGrades);
            this.Controls.Add(this.newQuiz);
            this.Controls.Add(this.testQuiz);
            this.Controls.Add(this.listQuizes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loggedLabel);
            this.Controls.Add(this.logOutButton);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label loggedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listQuizes;
        private System.Windows.Forms.Button testQuiz;
        private System.Windows.Forms.Button newQuiz;
        private System.Windows.Forms.Button displayGrades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seeCode;
        private System.Windows.Forms.Button deleteButton;
    }
}