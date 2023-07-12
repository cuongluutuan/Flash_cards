namespace Flash_cards.Forms.Flashcards.UserControls
{
    partial class QuestionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionLabel = new Label();
            answer1 = new Button();
            answer2 = new Button();
            answer3 = new Button();
            answer4 = new Button();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.Font = new Font("Quicksand SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            questionLabel.Location = new Point(104, 73);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(283, 48);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "Dummy Question";
            // 
            // answer1
            // 
            answer1.Location = new Point(104, 170);
            answer1.Name = "answer1";
            answer1.Size = new Size(471, 74);
            answer1.TabIndex = 1;
            answer1.Text = "button1";
            answer1.UseVisualStyleBackColor = true;
            answer1.Click += answer1_Click;
            // 
            // answer2
            // 
            answer2.Location = new Point(628, 170);
            answer2.Name = "answer2";
            answer2.Size = new Size(470, 74);
            answer2.TabIndex = 2;
            answer2.Text = "button2";
            answer2.UseVisualStyleBackColor = true;
            answer2.Click += answer2_Click;
            // 
            // answer3
            // 
            answer3.Location = new Point(104, 289);
            answer3.Name = "answer3";
            answer3.Size = new Size(471, 74);
            answer3.TabIndex = 3;
            answer3.Text = "button3";
            answer3.UseVisualStyleBackColor = true;
            answer3.Click += answer_3_click;
            // 
            // answer4
            // 
            answer4.Location = new Point(628, 289);
            answer4.Name = "answer4";
            answer4.Size = new Size(471, 74);
            answer4.TabIndex = 4;
            answer4.Text = "button4";
            answer4.UseVisualStyleBackColor = true;
            answer4.Click += answer_4_click;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(920, 452);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(112, 34);
            nextBtn.TabIndex = 5;
            nextBtn.Text = "next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Visible = false;
            nextBtn.Click += handleNextQuestion;
            // 
            // QuestionControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(nextBtn);
            Controls.Add(answer4);
            Controls.Add(answer3);
            Controls.Add(answer2);
            Controls.Add(answer1);
            Controls.Add(questionLabel);
            Name = "QuestionControl";
            Size = new Size(1208, 585);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label questionLabel;
        private Button answer1;
        private Button answer2;
        private Button button3;
        private Button button4;
        private Button nextBtn;
        private Button answer3;
        private Button answer4;
    }
}
