namespace LibraryDB
{
    partial class DeleteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleRadioButton = new System.Windows.Forms.RadioButton();
            this.AuthorRadioButton = new System.Windows.Forms.RadioButton();
            this.GenreRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delete by";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GenreRadioButton);
            this.groupBox1.Controls.Add(this.AuthorRadioButton);
            this.groupBox1.Controls.Add(this.TitleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(94, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // TitleRadioButton
            // 
            this.TitleRadioButton.AutoSize = true;
            this.TitleRadioButton.Location = new System.Drawing.Point(7, 10);
            this.TitleRadioButton.Name = "TitleRadioButton";
            this.TitleRadioButton.Size = new System.Drawing.Size(45, 17);
            this.TitleRadioButton.TabIndex = 0;
            this.TitleRadioButton.TabStop = true;
            this.TitleRadioButton.Text = "Title";
            this.TitleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AuthorRadioButton
            // 
            this.AuthorRadioButton.AutoSize = true;
            this.AuthorRadioButton.Location = new System.Drawing.Point(7, 33);
            this.AuthorRadioButton.Name = "AuthorRadioButton";
            this.AuthorRadioButton.Size = new System.Drawing.Size(56, 17);
            this.AuthorRadioButton.TabIndex = 1;
            this.AuthorRadioButton.TabStop = true;
            this.AuthorRadioButton.Text = "Author";
            this.AuthorRadioButton.UseVisualStyleBackColor = true;
            // 
            // GenreRadioButton
            // 
            this.GenreRadioButton.AutoSize = true;
            this.GenreRadioButton.Location = new System.Drawing.Point(6, 56);
            this.GenreRadioButton.Name = "GenreRadioButton";
            this.GenreRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GenreRadioButton.TabIndex = 3;
            this.GenreRadioButton.TabStop = true;
            this.GenreRadioButton.Text = "Genre";
            this.GenreRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(185, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(465, 67);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 40);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(477, 129);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 164);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton GenreRadioButton;
        private System.Windows.Forms.RadioButton AuthorRadioButton;
        private System.Windows.Forms.RadioButton TitleRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CloseButton;
    }
}