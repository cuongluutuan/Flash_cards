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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(466, 254);
            button1.Name = "button1";
            button1.Size = new Size(189, 70);
            button1.TabIndex = 33;
            button1.Text = "Learn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += handleLearn;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Quicksand", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(86, 74);
            label1.Name = "label1";
            label1.Size = new Size(311, 48);
            label1.TabIndex = 27;
            label1.Text = "Choose a Collection";
            // 
            // collectionComboBox
            // 
            collectionComboBox.DisplayMember = "Text";
            collectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            collectionComboBox.FormattingEnabled = true;
            collectionComboBox.Location = new Point(244, 166);
            collectionComboBox.Name = "collectionComboBox";
            collectionComboBox.Size = new Size(346, 33);
            collectionComboBox.TabIndex = 34;
            collectionComboBox.ValueMember = "Value";            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(86, 163);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 29;
            label3.Text = "Your Choice";
            // 
            // ChooseCollect
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(collectionComboBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
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
    }
}