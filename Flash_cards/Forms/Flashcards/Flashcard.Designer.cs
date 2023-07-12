namespace Flash_cards.Question
{
    partial class FlashcardForm
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
            panel1 = new Panel();
            label1 = new Label();
            questionLayoutPanel = new FlowLayoutPanel();
            correctAnswers = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(correctAnswers);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1210, 128);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand SemiBold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(61, 37);
            label1.Name = "label1";
            label1.Size = new Size(353, 59);
            label1.TabIndex = 7;
            label1.Text = "Learn Flashcards";
            // 
            // questionLayoutPanel
            // 
            questionLayoutPanel.AutoScroll = true;
            questionLayoutPanel.Dock = DockStyle.Bottom;
            questionLayoutPanel.Location = new Point(0, 125);
            questionLayoutPanel.Name = "questionLayoutPanel";
            questionLayoutPanel.Size = new Size(1210, 587);
            questionLayoutPanel.TabIndex = 15;
            questionLayoutPanel.Paint += questionLayoutPanel_Paint;
            // 
            // correctAnswers
            // 
            correctAnswers.AutoSize = true;
            correctAnswers.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            correctAnswers.ForeColor = Color.Transparent;
            correctAnswers.Location = new Point(779, 51);
            correctAnswers.Name = "correctAnswers";
            correctAnswers.Size = new Size(258, 45);
            correctAnswers.TabIndex = 8;
            correctAnswers.Text = "Correct Answers: ";
            // 
            // FlashcardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1210, 712);
            Controls.Add(questionLayoutPanel);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "FlashcardForm";
            Text = "Learn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel questionLayoutPanel;
        private Label correctAnswers;
    }
}