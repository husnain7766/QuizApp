namespace QuizApp
{
    partial class Form1
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
            this.QuestionNoLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.OptionRadioButton1 = new System.Windows.Forms.RadioButton();
            this.OptionRadioButton2 = new System.Windows.Forms.RadioButton();
            this.OptionRadioButton3 = new System.Windows.Forms.RadioButton();
            this.OptionRadioButton4 = new System.Windows.Forms.RadioButton();
            this.QuestionTextBox1 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionNoLabel
            // 
            this.QuestionNoLabel.AutoSize = true;
            this.QuestionNoLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.QuestionNoLabel.Location = new System.Drawing.Point(26, 11);
            this.QuestionNoLabel.Name = "QuestionNoLabel";
            this.QuestionNoLabel.Size = new System.Drawing.Size(141, 27);
            this.QuestionNoLabel.TabIndex = 0;
            this.QuestionNoLabel.Text = "Question No";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.ScoreLabel.Location = new System.Drawing.Point(631, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(121, 26);
            this.ScoreLabel.TabIndex = 7;
            this.ScoreLabel.Text = "SCORE : 0";
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(502, 99);
            this.PictureBox.MaximumSize = new System.Drawing.Size(250, 250);
            this.PictureBox.MinimumSize = new System.Drawing.Size(200, 200);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(250, 250);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 8;
            this.PictureBox.TabStop = false;
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(130)))), ((int)(((byte)(48)))));
            this.NextQuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextQuestionButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextQuestionButton.Location = new System.Drawing.Point(31, 396);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(184, 55);
            this.NextQuestionButton.TabIndex = 9;
            this.NextQuestionButton.Text = "Next";
            this.NextQuestionButton.UseVisualStyleBackColor = false;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click);
            // 
            // OptionRadioButton1
            // 
            this.OptionRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.OptionRadioButton1.AutoSize = true;
            this.OptionRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(130)))), ((int)(((byte)(48)))));
            this.OptionRadioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.OptionRadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionRadioButton1.Font = new System.Drawing.Font("Arial", 10F);
            this.OptionRadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OptionRadioButton1.Location = new System.Drawing.Point(30, 182);
            this.OptionRadioButton1.MinimumSize = new System.Drawing.Size(350, 30);
            this.OptionRadioButton1.Name = "OptionRadioButton1";
            this.OptionRadioButton1.Size = new System.Drawing.Size(350, 30);
            this.OptionRadioButton1.TabIndex = 10;
            this.OptionRadioButton1.Text = "radioButton1";
            this.OptionRadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OptionRadioButton1.UseVisualStyleBackColor = false;
            this.OptionRadioButton1.CheckedChanged += new System.EventHandler(this.OptionRadioButton1_CheckedChanged);
            // 
            // OptionRadioButton2
            // 
            this.OptionRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.OptionRadioButton2.AutoSize = true;
            this.OptionRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(130)))), ((int)(((byte)(48)))));
            this.OptionRadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionRadioButton2.Font = new System.Drawing.Font("Arial", 10F);
            this.OptionRadioButton2.Location = new System.Drawing.Point(30, 230);
            this.OptionRadioButton2.MinimumSize = new System.Drawing.Size(350, 30);
            this.OptionRadioButton2.Name = "OptionRadioButton2";
            this.OptionRadioButton2.Size = new System.Drawing.Size(350, 30);
            this.OptionRadioButton2.TabIndex = 11;
            this.OptionRadioButton2.Text = "radioButton2";
            this.OptionRadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OptionRadioButton2.UseVisualStyleBackColor = false;
            this.OptionRadioButton2.CheckedChanged += new System.EventHandler(this.OptionRadioButton2_CheckedChanged);
            // 
            // OptionRadioButton3
            // 
            this.OptionRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.OptionRadioButton3.AutoSize = true;
            this.OptionRadioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(130)))), ((int)(((byte)(48)))));
            this.OptionRadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionRadioButton3.Font = new System.Drawing.Font("Arial", 10F);
            this.OptionRadioButton3.Location = new System.Drawing.Point(30, 275);
            this.OptionRadioButton3.MaximumSize = new System.Drawing.Size(250, 30);
            this.OptionRadioButton3.MinimumSize = new System.Drawing.Size(350, 30);
            this.OptionRadioButton3.Name = "OptionRadioButton3";
            this.OptionRadioButton3.Size = new System.Drawing.Size(350, 30);
            this.OptionRadioButton3.TabIndex = 12;
            this.OptionRadioButton3.Text = "radioButton3";
            this.OptionRadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OptionRadioButton3.UseVisualStyleBackColor = false;
            this.OptionRadioButton3.CheckedChanged += new System.EventHandler(this.OptionRadioButton3_CheckedChanged);
            // 
            // OptionRadioButton4
            // 
            this.OptionRadioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.OptionRadioButton4.AutoSize = true;
            this.OptionRadioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(130)))), ((int)(((byte)(48)))));
            this.OptionRadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionRadioButton4.Font = new System.Drawing.Font("Arial", 10F);
            this.OptionRadioButton4.Location = new System.Drawing.Point(30, 319);
            this.OptionRadioButton4.MinimumSize = new System.Drawing.Size(350, 30);
            this.OptionRadioButton4.Name = "OptionRadioButton4";
            this.OptionRadioButton4.Size = new System.Drawing.Size(350, 30);
            this.OptionRadioButton4.TabIndex = 13;
            this.OptionRadioButton4.Text = "radioButton4";
            this.OptionRadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OptionRadioButton4.UseVisualStyleBackColor = false;
            this.OptionRadioButton4.CheckedChanged += new System.EventHandler(this.OptionRadioButton4_CheckedChanged);
            // 
            // QuestionTextBox1
            // 
            this.QuestionTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.QuestionTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QuestionTextBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.QuestionTextBox1.Font = new System.Drawing.Font("Arial", 12.5F);
            this.QuestionTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.QuestionTextBox1.Location = new System.Drawing.Point(30, 60);
            this.QuestionTextBox1.Multiline = true;
            this.QuestionTextBox1.Name = "QuestionTextBox1";
            this.QuestionTextBox1.ReadOnly = true;
            this.QuestionTextBox1.Size = new System.Drawing.Size(350, 85);
            this.QuestionTextBox1.TabIndex = 14;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(568, 396);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(184, 55);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.QuestionTextBox1);
            this.Controls.Add(this.OptionRadioButton4);
            this.Controls.Add(this.OptionRadioButton3);
            this.Controls.Add(this.OptionRadioButton2);
            this.Controls.Add(this.OptionRadioButton1);
            this.Controls.Add(this.NextQuestionButton);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.QuestionNoLabel);
            this.Name = "Form1";
            this.Text = "Quiz App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionNoLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.RadioButton OptionRadioButton1;
        private System.Windows.Forms.RadioButton OptionRadioButton2;
        private System.Windows.Forms.RadioButton OptionRadioButton3;
        private System.Windows.Forms.RadioButton OptionRadioButton4;
        private System.Windows.Forms.TextBox QuestionTextBox1;
        private System.Windows.Forms.Button Exit;
    }
}

