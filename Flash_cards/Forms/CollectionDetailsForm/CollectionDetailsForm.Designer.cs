namespace Flash_cards.Forms.QuestionForm
{
    partial class CollectionDetailsForm
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
            questionFormTitle = new Label();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            questionsGridView = new DataGridView();
            collectionDescTxt = new TextBox();
            collectionNameTxt = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionsGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(questionFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 82);
            panel1.TabIndex = 0;
            // 
            // questionFormTitle
            // 
            questionFormTitle.AutoSize = true;
            questionFormTitle.Font = new Font("Quicksand SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            questionFormTitle.ForeColor = Color.Transparent;
            questionFormTitle.Location = new Point(36, 21);
            questionFormTitle.Name = "questionFormTitle";
            questionFormTitle.Size = new Size(42, 41);
            questionFormTitle.TabIndex = 0;
            questionFormTitle.Text = "\"\"";
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(626, 584);
            button4.Name = "button4";
            button4.Size = new Size(101, 34);
            button4.TabIndex = 47;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += handleQuestionUpdate;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(626, 527);
            button2.Name = "button2";
            button2.Size = new Size(101, 34);
            button2.TabIndex = 46;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += handleAddQuestion;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(626, 644);
            button1.Name = "button1";
            button1.Size = new Size(101, 34);
            button1.TabIndex = 45;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += handleDeleteQuestion;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 461);
            label1.Name = "label1";
            label1.Size = new Size(225, 48);
            label1.TabIndex = 44;
            label1.Text = "Questions List";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(538, 393);
            button3.Name = "button3";
            button3.Size = new Size(118, 34);
            button3.TabIndex = 42;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += handleUpdateCollectionDetails;
            // 
            // questionsGridView
            // 
            questionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsGridView.Location = new Point(46, 527);
            questionsGridView.Name = "questionsGridView";
            questionsGridView.ReadOnly = true;
            questionsGridView.RowHeadersWidth = 62;
            questionsGridView.RowTemplate.Height = 33;
            questionsGridView.Size = new Size(560, 225);
            questionsGridView.TabIndex = 41;
            questionsGridView.CellMouseDoubleClick += questionsGridView_CellMouseDoubleClick;
            // 
            // collectionDescTxt
            // 
            collectionDescTxt.Location = new Point(187, 325);
            collectionDescTxt.Name = "collectionDescTxt";
            collectionDescTxt.Size = new Size(469, 31);
            collectionDescTxt.TabIndex = 40;
            // 
            // collectionNameTxt
            // 
            collectionNameTxt.Location = new Point(187, 256);
            collectionNameTxt.Name = "collectionNameTxt";
            collectionNameTxt.Size = new Size(469, 31);
            collectionNameTxt.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(45, 322);
            label4.Name = "label4";
            label4.Size = new Size(137, 32);
            label4.TabIndex = 38;
            label4.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 253);
            label2.Name = "label2";
            label2.Size = new Size(79, 32);
            label2.TabIndex = 37;
            label2.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(46, 173);
            label5.Name = "label5";
            label5.Size = new Size(428, 28);
            label5.TabIndex = 36;
            label5.Text = "Changes the collection name and description.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Quicksand", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 107);
            label3.Name = "label3";
            label3.Size = new Size(273, 48);
            label3.TabIndex = 35;
            label3.Text = "Collection Details";
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(0, 0, 64);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(626, 705);
            button5.Name = "button5";
            button5.Size = new Size(101, 47);
            button5.TabIndex = 43;
            button5.Text = "Learn";
            button5.UseVisualStyleBackColor = false;
            // 
            // CollectionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 768);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(questionsGridView);
            Controls.Add(collectionDescTxt);
            Controls.Add(collectionNameTxt);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CollectionDetailsForm";
            Text = "QuestionForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)questionsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label questionFormTitle;
        private Button button4;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button button3;
        private DataGridView questionsGridView;
        private TextBox collectionDescTxt;
        private TextBox collectionNameTxt;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label3;
        private Button button5;
    }
}