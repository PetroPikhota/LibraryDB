namespace LibraryDB
{
    partial class Search
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
            this.AuthorRadio = new System.Windows.Forms.RadioButton();
            this.titleRadio = new System.Windows.Forms.RadioButton();
            this.yearRadio = new System.Windows.Forms.RadioButton();
            this.genreRadio = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find by";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genreRadio);
            this.groupBox1.Controls.Add(this.yearRadio);
            this.groupBox1.Controls.Add(this.AuthorRadio);
            this.groupBox1.Controls.Add(this.titleRadio);
            this.groupBox1.Location = new System.Drawing.Point(83, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AuthorRadio
            // 
            this.AuthorRadio.AutoSize = true;
            this.AuthorRadio.Location = new System.Drawing.Point(82, 21);
            this.AuthorRadio.Name = "AuthorRadio";
            this.AuthorRadio.Size = new System.Drawing.Size(56, 17);
            this.AuthorRadio.TabIndex = 0;
            this.AuthorRadio.TabStop = true;
            this.AuthorRadio.Text = "Author";
            this.AuthorRadio.UseVisualStyleBackColor = true;
            this.AuthorRadio.CheckedChanged += new System.EventHandler(this.AuthorRadio_CheckedChanged);
            // 
            // titleRadio
            // 
            this.titleRadio.AutoSize = true;
            this.titleRadio.Location = new System.Drawing.Point(6, 21);
            this.titleRadio.Name = "titleRadio";
            this.titleRadio.Size = new System.Drawing.Size(45, 17);
            this.titleRadio.TabIndex = 1;
            this.titleRadio.TabStop = true;
            this.titleRadio.Text = "Title";
            this.titleRadio.UseVisualStyleBackColor = true;
            this.titleRadio.CheckedChanged += new System.EventHandler(this.titleRadio_CheckedChanged);
            // 
            // yearRadio
            // 
            this.yearRadio.AutoSize = true;
            this.yearRadio.Location = new System.Drawing.Point(168, 21);
            this.yearRadio.Name = "yearRadio";
            this.yearRadio.Size = new System.Drawing.Size(47, 17);
            this.yearRadio.TabIndex = 2;
            this.yearRadio.TabStop = true;
            this.yearRadio.Text = "Year";
            this.yearRadio.UseVisualStyleBackColor = true;
            this.yearRadio.CheckedChanged += new System.EventHandler(this.yearRadio_CheckedChanged);
            // 
            // genreRadio
            // 
            this.genreRadio.AutoSize = true;
            this.genreRadio.Location = new System.Drawing.Point(245, 21);
            this.genreRadio.Name = "genreRadio";
            this.genreRadio.Size = new System.Drawing.Size(54, 17);
            this.genreRadio.TabIndex = 3;
            this.genreRadio.TabStop = true;
            this.genreRadio.Text = "Genre";
            this.genreRadio.UseVisualStyleBackColor = true;
            this.genreRadio.CheckedChanged += new System.EventHandler(this.genreRadio_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(418, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(745, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(-3, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(804, 314);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton genreRadio;
        private System.Windows.Forms.RadioButton yearRadio;
        private System.Windows.Forms.RadioButton AuthorRadio;
        private System.Windows.Forms.RadioButton titleRadio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
    }
}