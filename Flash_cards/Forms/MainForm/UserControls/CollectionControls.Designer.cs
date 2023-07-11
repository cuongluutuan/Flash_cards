namespace Flash_cards.UserControls
{
    partial class CollectionControls
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            collectionsGridView = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)collectionsGridView).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(614, 138);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(101, 59);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += handleAddCollection;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(614, 389);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(101, 59);
            button2.TabIndex = 9;
            button2.Text = "Import";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(614, 219);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(101, 59);
            button4.TabIndex = 55;
            button4.Text = "Details";
            button4.UseVisualStyleBackColor = true;
            button4.Click += handleCollectionDetails;
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(614, 303);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Size = new Size(101, 59);
            button5.TabIndex = 54;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += handleCollectionDelete;
            // 
            // collectionsGridView
            // 
            collectionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            collectionsGridView.DefaultCellStyle = dataGridViewCellStyle1;
            collectionsGridView.Location = new Point(39, 138);
            collectionsGridView.Margin = new Padding(2, 2, 2, 2);
            collectionsGridView.Name = "collectionsGridView";
            collectionsGridView.ReadOnly = true;
            collectionsGridView.RowHeadersWidth = 62;
            collectionsGridView.RowTemplate.Height = 33;
            collectionsGridView.Size = new Size(560, 310);
            collectionsGridView.TabIndex = 53;
            collectionsGridView.CellDoubleClick += collectionsGridView_CellDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(39, 86);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(238, 23);
            label7.TabIndex = 52;
            label7.Text = "Shows a full list of collections.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Quicksand", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(39, 34);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(201, 40);
            label8.TabIndex = 51;
            label8.Text = "Collections List";
            // 
            // CollectionControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(collectionsGridView);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CollectionControls";
            Size = new Size(747, 494);
            ((System.ComponentModel.ISupportInitialize)collectionsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private DataGridView collectionsGridView;
        private Label label7;
        private Label label8;
    }
}
