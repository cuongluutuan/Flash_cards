namespace Flash_cards.Forms.MainForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            button4 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            mainUIPanel = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopCenter;
            button4.Location = new Point(24, 11);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Size = new Size(120, 103);
            button4.TabIndex = 4;
            button4.Text = "FlashCardz";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.UseVisualStyleBackColor = false;
            button4.Click += handleWelcome;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 413);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(24, 273);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(120, 91);
            button2.TabIndex = 11;
            button2.Text = "Question Bank";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += handleQuestionBank;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(24, 149);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(120, 91);
            button1.TabIndex = 10;
            button1.Text = "Import";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += handleCollections;
            // 
            // mainUIPanel
            // 
            mainUIPanel.Location = new Point(180, 20);
            mainUIPanel.Margin = new Padding(2, 2, 2, 2);
            mainUIPanel.Name = "mainUIPanel";
            mainUIPanel.Size = new Size(654, 371);
            mainUIPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 413);
            Controls.Add(mainUIPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel mainUIPanel;
    }
}