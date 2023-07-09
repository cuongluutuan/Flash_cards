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
            this.questionLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Quicksand SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questionLabel.Location = new System.Drawing.Point(104, 73);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(283, 48);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Dummy Question";
            // 
            // answer1
            // 
            this.answer1.Location = new System.Drawing.Point(104, 170);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(471, 74);
            this.answer1.TabIndex = 1;
            this.answer1.Text = "button1";
            this.answer1.UseVisualStyleBackColor = true;
            // 
            // answer2
            // 
            this.answer2.Location = new System.Drawing.Point(628, 170);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(470, 74);
            this.answer2.TabIndex = 2;
            this.answer2.Text = "button2";
            this.answer2.UseVisualStyleBackColor = true;
            // 
            // answer3
            // 
            this.answer3.Location = new System.Drawing.Point(104, 289);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(471, 74);
            this.answer3.TabIndex = 3;
            this.answer3.Text = "button3";
            this.answer3.UseVisualStyleBackColor = true;
            // 
            // answer4
            // 
            this.answer4.Location = new System.Drawing.Point(628, 289);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(471, 74);
            this.answer4.TabIndex = 4;
            this.answer4.Text = "button4";
            this.answer4.UseVisualStyleBackColor = true;
            // 
            // QuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.questionLabel);
            this.Name = "QuestionControl";
            this.Size = new System.Drawing.Size(1208, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label questionLabel;
        private Button answer1;
        private Button answer2;
        private Button answer3;
        private Button answer4;
    }
}
