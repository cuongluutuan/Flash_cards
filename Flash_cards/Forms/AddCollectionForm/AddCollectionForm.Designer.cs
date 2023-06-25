namespace Flash_cards.Forms.AddCollectionForm
{
    partial class AddCollectionForm
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
            this.collectionDescTxt = new System.Windows.Forms.TextBox();
            this.collectionNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // collectionDescTxt
            // 
            this.collectionDescTxt.Location = new System.Drawing.Point(191, 277);
            this.collectionDescTxt.Name = "collectionDescTxt";
            this.collectionDescTxt.Size = new System.Drawing.Size(427, 31);
            this.collectionDescTxt.TabIndex = 11;
            // 
            // collectionNameTxt
            // 
            this.collectionNameTxt.Location = new System.Drawing.Point(191, 208);
            this.collectionNameTxt.Name = "collectionNameTxt";
            this.collectionNameTxt.Size = new System.Drawing.Size(427, 31);
            this.collectionNameTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(630, 56);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter the new collection details, then click Create to add a new one.\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add a Collection";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handleAddCollection);
            // 
            // AddCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.collectionDescTxt);
            this.Controls.Add(this.collectionNameTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddCollectionForm";
            this.Text = "AddCollectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox collectionDescTxt;
        private TextBox collectionNameTxt;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}