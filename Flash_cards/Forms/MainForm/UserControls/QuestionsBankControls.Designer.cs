﻿namespace Flash_cards.UserControls
{
    partial class QuestionsBankControls
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
            button2 = new Button();
            button1 = new Button();
            searchFilterComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(524, 140);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(65, 27);
            button2.TabIndex = 24;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(453, 140);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(65, 27);
            button1.TabIndex = 23;
            button1.Text = "Go";
            button1.UseVisualStyleBackColor = false;
            // 
            // searchFilterComboBox
            // 
            searchFilterComboBox.FormattingEnabled = true;
            searchFilterComboBox.Location = new Point(327, 140);
            searchFilterComboBox.Margin = new Padding(2, 2, 2, 2);
            searchFilterComboBox.Name = "searchFilterComboBox";
            searchFilterComboBox.Size = new Size(112, 28);
            searchFilterComboBox.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(290, 137);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(34, 28);
            label4.TabIndex = 21;
            label4.Text = "By";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(31, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 20;
            label3.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 140);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 27);
            textBox1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 185);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(558, 231);
            dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(330, 23);
            label2.TabIndex = 17;
            label2.Text = "A full list of Questions from all Collections";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 16;
            label1.Text = "All Questions";
            // 
            // QuestionsBankControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchFilterComboBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "QuestionsBankControls";
            Size = new Size(632, 494);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private ComboBox searchFilterComboBox;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
    }
}
