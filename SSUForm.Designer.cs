
namespace SSU_Kotova
{
    partial class SSUForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.questionTitle = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTitle
            // 
            this.questionTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.questionTitle.AutoSize = true;
            this.questionTitle.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTitle.Location = new System.Drawing.Point(166, 88);
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(100, 31);
            this.questionTitle.TabIndex = 0;
            this.questionTitle.Text = "Вопрос:";
            // 
            // question
            // 
            this.question.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.question.Location = new System.Drawing.Point(272, 96);
            this.question.MaximumSize = new System.Drawing.Size(578, 4);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(578, 23);
            this.question.TabIndex = 1;
            this.question.TextChanged += new System.EventHandler(this.question_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.searchButton.AutoSize = true;
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Location = new System.Drawing.Point(682, 144);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(168, 25);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            this.searchButton.MouseEnter += new System.EventHandler(this.searchButton_MouseEnter);
            this.searchButton.MouseLeave += new System.EventHandler(this.searchButton_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.questionTitle);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.question);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 226);
            this.panel1.TabIndex = 3;
            // 
            // SSUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 624);
            this.Controls.Add(this.panel1);
            this.Name = "SSUForm";
            this.Text = "SSU";
            this.Load += new System.EventHandler(this.SSUForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SSUForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SSUForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionTitle;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Panel panel1;
    }
}

