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
            button1.Location = new Point(767, 156);
            button1.Name = "button1";
            button1.Size = new Size(126, 74);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += handleAddCollection;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(767, 280);
            button4.Name = "button4";
            button4.Size = new Size(126, 96);
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
            button5.Location = new Point(767, 420);
            button5.Name = "button5";
            button5.Size = new Size(126, 62);
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
            collectionsGridView.Location = new Point(49, 156);
            collectionsGridView.Name = "collectionsGridView";
            collectionsGridView.ReadOnly = true;
            collectionsGridView.RowHeadersWidth = 62;
            collectionsGridView.RowTemplate.Height = 33;
            collectionsGridView.Size = new Size(700, 337);
            collectionsGridView.TabIndex = 53;
            collectionsGridView.CellDoubleClick += collectionsGridView_CellDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(49, 108);
            label7.Name = "label7";
            label7.Size = new Size(286, 28);
            label7.TabIndex = 52;
            label7.Text = "Shows a full list of collections.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Quicksand", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(49, 42);
            label8.Name = "label8";
            label8.Size = new Size(238, 48);
            label8.TabIndex = 51;
            label8.Text = "Collections List";
            // 
            // CollectionControls
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(collectionsGridView);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(button1);
            Name = "CollectionControls";
            Size = new Size(934, 520);
            ((System.ComponentModel.ISupportInitialize)collectionsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button4;
        private Button button5;
        private DataGridView collectionsGridView;
        private Label label7;
        private Label label8;
    }
}
