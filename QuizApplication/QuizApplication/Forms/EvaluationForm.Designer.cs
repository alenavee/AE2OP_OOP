
namespace QuizApplication.Forms
{
    partial class EvaluationForm
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
            this.quizesList = new System.Windows.Forms.ListBox();
            this.gradesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quizesList
            // 
            this.quizesList.FormattingEnabled = true;
            this.quizesList.ItemHeight = 20;
            this.quizesList.Location = new System.Drawing.Point(44, 88);
            this.quizesList.Name = "quizesList";
            this.quizesList.Size = new System.Drawing.Size(178, 104);
            this.quizesList.TabIndex = 0;
            this.quizesList.SelectedIndexChanged += new System.EventHandler(this.quizesList_SelectedIndexChanged);
            // 
            // gradesList
            // 
            this.gradesList.FormattingEnabled = true;
            this.gradesList.ItemHeight = 20;
            this.gradesList.Location = new System.Drawing.Point(269, 88);
            this.gradesList.Name = "gradesList";
            this.gradesList.Size = new System.Drawing.Size(174, 104);
            this.gradesList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose quiz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grades:";
            // 
            // EvaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 287);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gradesList);
            this.Controls.Add(this.quizesList);
            this.Name = "EvaluationForm";
            this.Text = "EvaluationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox quizesList;
        private System.Windows.Forms.ListBox gradesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}