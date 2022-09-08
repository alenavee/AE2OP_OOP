
namespace QuizApplication.Forms
{
    partial class QuizForm
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
            this.labelQuestionNumber = new System.Windows.Forms.Label();
            this.labelQuestionText = new System.Windows.Forms.Label();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.labelAnswer2 = new System.Windows.Forms.Label();
            this.labelAnswer3 = new System.Windows.Forms.Label();
            this.labelAnswer4 = new System.Windows.Forms.Label();
            this.checkQuestion1 = new System.Windows.Forms.CheckBox();
            this.checkQuestion2 = new System.Windows.Forms.CheckBox();
            this.checkQuestion3 = new System.Windows.Forms.CheckBox();
            this.checkQuestion4 = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelQuestionNumber
            // 
            this.labelQuestionNumber.AutoSize = true;
            this.labelQuestionNumber.Location = new System.Drawing.Point(34, 30);
            this.labelQuestionNumber.Name = "labelQuestionNumber";
            this.labelQuestionNumber.Size = new System.Drawing.Size(111, 20);
            this.labelQuestionNumber.TabIndex = 0;
            this.labelQuestionNumber.Text = "Question X of Y";
            // 
            // labelQuestionText
            // 
            this.labelQuestionText.AutoSize = true;
            this.labelQuestionText.Location = new System.Drawing.Point(34, 76);
            this.labelQuestionText.Name = "labelQuestionText";
            this.labelQuestionText.Size = new System.Drawing.Size(68, 20);
            this.labelQuestionText.TabIndex = 1;
            this.labelQuestionText.Text = "Question";
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Location = new System.Drawing.Point(34, 142);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(50, 20);
            this.labelAnswer1.TabIndex = 2;
            this.labelAnswer1.Text = "label1";
            // 
            // labelAnswer2
            // 
            this.labelAnswer2.AutoSize = true;
            this.labelAnswer2.Location = new System.Drawing.Point(34, 189);
            this.labelAnswer2.Name = "labelAnswer2";
            this.labelAnswer2.Size = new System.Drawing.Size(50, 20);
            this.labelAnswer2.TabIndex = 3;
            this.labelAnswer2.Text = "label1";
            // 
            // labelAnswer3
            // 
            this.labelAnswer3.AutoSize = true;
            this.labelAnswer3.Location = new System.Drawing.Point(34, 235);
            this.labelAnswer3.Name = "labelAnswer3";
            this.labelAnswer3.Size = new System.Drawing.Size(50, 20);
            this.labelAnswer3.TabIndex = 4;
            this.labelAnswer3.Text = "label1";
            // 
            // labelAnswer4
            // 
            this.labelAnswer4.AutoSize = true;
            this.labelAnswer4.Location = new System.Drawing.Point(34, 281);
            this.labelAnswer4.Name = "labelAnswer4";
            this.labelAnswer4.Size = new System.Drawing.Size(50, 20);
            this.labelAnswer4.TabIndex = 5;
            this.labelAnswer4.Text = "label1";
            // 
            // checkQuestion1
            // 
            this.checkQuestion1.AutoSize = true;
            this.checkQuestion1.Location = new System.Drawing.Point(364, 145);
            this.checkQuestion1.Name = "checkQuestion1";
            this.checkQuestion1.Size = new System.Drawing.Size(18, 17);
            this.checkQuestion1.TabIndex = 6;
            this.checkQuestion1.UseVisualStyleBackColor = true;
            this.checkQuestion1.Click += new System.EventHandler(this.checkQuestion1_Click);
            // 
            // checkQuestion2
            // 
            this.checkQuestion2.AutoSize = true;
            this.checkQuestion2.Location = new System.Drawing.Point(364, 192);
            this.checkQuestion2.Name = "checkQuestion2";
            this.checkQuestion2.Size = new System.Drawing.Size(18, 17);
            this.checkQuestion2.TabIndex = 7;
            this.checkQuestion2.UseVisualStyleBackColor = true;
            this.checkQuestion2.Click += new System.EventHandler(this.checkQuestion2_Click);
            // 
            // checkQuestion3
            // 
            this.checkQuestion3.AutoSize = true;
            this.checkQuestion3.Location = new System.Drawing.Point(364, 238);
            this.checkQuestion3.Name = "checkQuestion3";
            this.checkQuestion3.Size = new System.Drawing.Size(18, 17);
            this.checkQuestion3.TabIndex = 8;
            this.checkQuestion3.UseVisualStyleBackColor = true;
            this.checkQuestion3.Click += new System.EventHandler(this.checkQuestion3_Click);
            // 
            // checkQuestion4
            // 
            this.checkQuestion4.AutoSize = true;
            this.checkQuestion4.Location = new System.Drawing.Point(364, 281);
            this.checkQuestion4.Name = "checkQuestion4";
            this.checkQuestion4.Size = new System.Drawing.Size(18, 17);
            this.checkQuestion4.TabIndex = 9;
            this.checkQuestion4.UseVisualStyleBackColor = true;
            this.checkQuestion4.Click += new System.EventHandler(this.checkQuestion4_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(34, 388);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 29);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Previous";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);

            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(378, 388);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(94, 29);
            this.ButtonNext.TabIndex = 11;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);

            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.checkQuestion4);
            this.Controls.Add(this.checkQuestion3);
            this.Controls.Add(this.checkQuestion2);
            this.Controls.Add(this.checkQuestion1);
            this.Controls.Add(this.labelAnswer4);
            this.Controls.Add(this.labelAnswer3);
            this.Controls.Add(this.labelAnswer2);
            this.Controls.Add(this.labelAnswer1);
            this.Controls.Add(this.labelQuestionText);
            this.Controls.Add(this.labelQuestionNumber);
            this.Name = "QuizForm";
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestionNumber;
        private System.Windows.Forms.Label labelQuestionText;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelAnswer2;
        private System.Windows.Forms.Label labelAnswer3;
        private System.Windows.Forms.Label labelAnswer4;
        private System.Windows.Forms.CheckBox checkQuestion1;
        private System.Windows.Forms.CheckBox checkQuestion2;
        private System.Windows.Forms.CheckBox checkQuestion3;
        private System.Windows.Forms.CheckBox checkQuestion4;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button ButtonNext;
    }
}