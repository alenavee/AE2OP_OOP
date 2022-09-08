
namespace QuizApplication.Forms
{
    partial class ResultsForm
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
            this.labelTotalNumber = new System.Windows.Forms.Label();
            this.labelTotalA = new System.Windows.Forms.Label();
            this.labelCorrect = new System.Windows.Forms.Label();
            this.labelCorrectA = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelIncorrect = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreA = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTotalNumber
            // 
            this.labelTotalNumber.AutoSize = true;
            this.labelTotalNumber.Location = new System.Drawing.Point(18, 22);
            this.labelTotalNumber.Name = "labelTotalNumber";
            this.labelTotalNumber.Size = new System.Drawing.Size(189, 20);
            this.labelTotalNumber.TabIndex = 0;
            this.labelTotalNumber.Text = "Total number of questions: ";
            // 
            // labelTotalA
            // 
            this.labelTotalA.AutoSize = true;
            this.labelTotalA.Location = new System.Drawing.Point(214, 22);
            this.labelTotalA.Name = "labelTotalA";
            this.labelTotalA.Size = new System.Drawing.Size(42, 20);
            this.labelTotalA.TabIndex = 1;
            this.labelTotalA.Text = "Total";
            // 
            // labelCorrect
            // 
            this.labelCorrect.AutoSize = true;
            this.labelCorrect.Location = new System.Drawing.Point(147, 78);
            this.labelCorrect.Name = "labelCorrect";
            this.labelCorrect.Size = new System.Drawing.Size(60, 20);
            this.labelCorrect.TabIndex = 2;
            this.labelCorrect.Text = "Correct:";
            // 
            // labelCorrectA
            // 
            this.labelCorrectA.AutoSize = true;
            this.labelCorrectA.ForeColor = System.Drawing.Color.Green;
            this.labelCorrectA.Location = new System.Drawing.Point(214, 78);
            this.labelCorrectA.Name = "labelCorrectA";
            this.labelCorrectA.Size = new System.Drawing.Size(50, 20);
            this.labelCorrectA.TabIndex = 3;
            this.labelCorrectA.Text = "label1";
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Location = new System.Drawing.Point(150, 128);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(57, 20);
            this.labelWrong.TabIndex = 4;
            this.labelWrong.Text = "Wrong:";
            // 
            // labelIncorrect
            // 
            this.labelIncorrect.AutoSize = true;
            this.labelIncorrect.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrect.Location = new System.Drawing.Point(214, 128);
            this.labelIncorrect.Name = "labelIncorrect";
            this.labelIncorrect.Size = new System.Drawing.Size(54, 20);
            this.labelIncorrect.TabIndex = 5;
            this.labelIncorrect.Text = "Wrong";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(150, 174);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(52, 20);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Result:";
            // 
            // labelScoreA
            // 
            this.labelScoreA.AutoSize = true;
            this.labelScoreA.Location = new System.Drawing.Point(214, 174);
            this.labelScoreA.Name = "labelScoreA";
            this.labelScoreA.Size = new System.Drawing.Size(49, 20);
            this.labelScoreA.TabIndex = 7;
            this.labelScoreA.Text = "Result";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Location = new System.Drawing.Point(159, 239);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(94, 29);
            this.buttonFinish.TabIndex = 8;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 312);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.labelScoreA);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelIncorrect);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.labelCorrectA);
            this.Controls.Add(this.labelCorrect);
            this.Controls.Add(this.labelTotalA);
            this.Controls.Add(this.labelTotalNumber);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalNumber;
        private System.Windows.Forms.Label labelTotalA;
        private System.Windows.Forms.Label labelCorrect;
        private System.Windows.Forms.Label labelCorrectA;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelIncorrect;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreA;
        private System.Windows.Forms.Button buttonFinish;
    }
}