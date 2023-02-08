namespace PaperCreationApp
{
    partial class QuestonSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MCQ = new System.Windows.Forms.TextBox();
            this.Short = new System.Windows.Forms.TextBox();
            this.Long = new System.Windows.Forms.TextBox();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.ChapterComboBox = new System.Windows.Forms.ComboBox();
            this.Generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Chapter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter MCQs Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Short Questions Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Long Questions Quantity";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MCQ
            // 
            this.MCQ.Location = new System.Drawing.Point(243, 80);
            this.MCQ.Name = "MCQ";
            this.MCQ.Size = new System.Drawing.Size(100, 20);
            this.MCQ.TabIndex = 5;
            this.MCQ.TextChanged += new System.EventHandler(this.MCQ_TextChanged);
            // 
            // Short
            // 
            this.Short.Location = new System.Drawing.Point(243, 112);
            this.Short.Name = "Short";
            this.Short.Size = new System.Drawing.Size(100, 20);
            this.Short.TabIndex = 6;
            this.Short.TextChanged += new System.EventHandler(this.Short_TextChanged);
            // 
            // Long
            // 
            this.Long.Location = new System.Drawing.Point(243, 143);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(100, 20);
            this.Long.TabIndex = 7;
            this.Long.TextChanged += new System.EventHandler(this.Long_TextChanged);
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(223, 16);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(120, 21);
            this.SubjectComboBox.TabIndex = 8;
            this.SubjectComboBox.SelectedIndexChanged += new System.EventHandler(this.SubjectComboBox_SelectedIndexChanged);
            // 
            // ChapterComboBox
            // 
            this.ChapterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ChapterComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ChapterComboBox.FormattingEnabled = true;
            this.ChapterComboBox.Location = new System.Drawing.Point(223, 47);
            this.ChapterComboBox.Name = "ChapterComboBox";
            this.ChapterComboBox.Size = new System.Drawing.Size(120, 21);
            this.ChapterComboBox.TabIndex = 9;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(268, 178);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 10;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // QuestonSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 231);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.ChapterComboBox);
            this.Controls.Add(this.SubjectComboBox);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.Short);
            this.Controls.Add(this.MCQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuestonSelection";
            this.Text = "QuesitonSelection";
            this.Load += new System.EventHandler(this.QuestonSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MCQ;
        private System.Windows.Forms.TextBox Short;
        private System.Windows.Forms.TextBox Long;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.ComboBox ChapterComboBox;
        private System.Windows.Forms.Button Generate;
    }
}