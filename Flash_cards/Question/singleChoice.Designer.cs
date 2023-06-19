namespace Flash_cards.Question
{
    partial class singleChoice
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
            next = new Button();
            back = new Button();
            label1 = new Label();
            answer1 = new Button();
            answer3 = new Button();
            answer2 = new Button();
            answer4 = new Button();
            questionContent = new RichTextBox();
            SuspendLayout();
            // 
            // next
            // 
            next.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            next.Location = new Point(808, 505);
            next.Name = "next";
            next.Size = new Size(94, 34);
            next.TabIndex = 5;
            next.Text = "Next";
            next.UseVisualStyleBackColor = true;
            next.Click += next_Click;
            // 
            // back
            // 
            back.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            back.Location = new Point(67, 505);
            back.Name = "back";
            back.Size = new Size(94, 34);
            back.TabIndex = 7;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(163, 46);
            label1.TabIndex = 8;
            label1.Text = "Question:";
            // 
            // answer1
            // 
            answer1.Location = new Point(67, 314);
            answer1.Name = "answer1";
            answer1.Size = new Size(331, 71);
            answer1.TabIndex = 10;
            answer1.Text = "answer1";
            answer1.UseVisualStyleBackColor = true;
            answer1.Click += answer1_Click;
            // 
            // answer3
            // 
            answer3.Location = new Point(67, 417);
            answer3.Name = "answer3";
            answer3.Size = new Size(331, 71);
            answer3.TabIndex = 11;
            answer3.Text = "answer3";
            answer3.UseVisualStyleBackColor = true;
            answer3.Click += answer3_Click;
            // 
            // answer2
            // 
            answer2.Location = new Point(571, 408);
            answer2.Name = "answer2";
            answer2.Size = new Size(331, 71);
            answer2.TabIndex = 12;
            answer2.Text = "answer2";
            answer2.UseVisualStyleBackColor = true;
            answer2.Click += answer2_Click;
            // 
            // answer4
            // 
            answer4.Location = new Point(571, 315);
            answer4.Name = "answer4";
            answer4.Size = new Size(331, 68);
            answer4.TabIndex = 13;
            answer4.Text = "answer4";
            answer4.UseVisualStyleBackColor = true;
            answer4.Click += answer4_Click;
            // 
            // questionContent
            // 
            questionContent.Location = new Point(67, 72);
            questionContent.Name = "questionContent";
            questionContent.ReadOnly = true;
            questionContent.Size = new Size(835, 212);
            questionContent.TabIndex = 15;
            questionContent.Text = "this is a question for you, are you stupid ?";
            // 
            // singleChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 570);
            Controls.Add(questionContent);
            Controls.Add(answer4);
            Controls.Add(answer2);
            Controls.Add(answer3);
            Controls.Add(answer1);
            Controls.Add(label1);
            Controls.Add(back);
            Controls.Add(next);
            Name = "singleChoice";
            Text = "singleChoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button next;
        private Button back;
        private Label label1;
        private Button answer1;
        private Button answer3;
        private Button answer2;
        private Button answer4;
        private RichTextBox questionContent;
    }
}