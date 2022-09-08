
namespace QuizApplication.Forms
{
    partial class StudentForm
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
            this.logInLabel = new System.Windows.Forms.Label();
            this.loggedInName = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(151, 17);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(94, 29);
            this.logOutButton.TabIndex = 0;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Location = new System.Drawing.Point(12, 21);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(122, 20);
            this.logInLabel.TabIndex = 1;
            this.logInLabel.Text = "You are signed in";
            // 
            // loggedInName
            // 
            this.loggedInName.AutoSize = true;
            this.loggedInName.ForeColor = System.Drawing.Color.Green;
            this.loggedInName.Location = new System.Drawing.Point(12, 60);
            this.loggedInName.Name = "loggedInName";
            this.loggedInName.Size = new System.Drawing.Size(49, 20);
            this.loggedInName.TabIndex = 2;
            this.loggedInName.Text = "Name";
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(151, 159);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(191, 27);
            this.codeBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter code to start the quiz:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(196, 220);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 51);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 314);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.loggedInName);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.logOutButton);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label logInLabel;
        private System.Windows.Forms.Label loggedInName;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
    }
}