namespace Flash_cards.Forms.LearnForm
{
    partial class ChooseCollect
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
            button1 = new Button();
            label1 = new Label();
            collectionComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            questionNumberComboBox = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(323, 175);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(132, 42);
            button1.TabIndex = 33;
            button1.Text = "Learn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += handleLearn;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 26);
            label1.TabIndex = 27;
            label1.Text = "Choose a Collection";
            // 
            // collectionComboBox
            // 
            collectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            collectionComboBox.FormattingEnabled = true;
            collectionComboBox.Location = new Point(171, 100);
            collectionComboBox.Margin = new Padding(2, 2, 2, 2);
            collectionComboBox.Name = "collectionComboBox";
            collectionComboBox.Size = new Size(243, 23);
            collectionComboBox.TabIndex = 34;
            collectionComboBox.SelectedIndexChanged += handleLoadQuestionNumber;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(60, 98);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 29;
            label3.Text = "Your Choice";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(60, 132);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 21);
            label2.TabIndex = 35;
            label2.Text = "Number of Questions";
            // 
            // questionNumberComboBox
            // 
            questionNumberComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            questionNumberComboBox.FormattingEnabled = true;
            questionNumberComboBox.Location = new Point(323, 131);
            questionNumberComboBox.Margin = new Padding(2, 2, 2, 2);
            questionNumberComboBox.Name = "questionNumberComboBox";
            questionNumberComboBox.Size = new Size(92, 23);
            questionNumberComboBox.TabIndex = 36;
            questionNumberComboBox.SelectedIndexChanged += handleChangeQuestionNumber;
            // 
            // ChooseCollect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(questionNumberComboBox);
            Controls.Add(label2);
            Controls.Add(collectionComboBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ChooseCollect";
            Text = "Learn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private ComboBox collectionComboBox;
        private Label label3;
        private Label label2;
        private ComboBox questionNumberComboBox;
    }
}