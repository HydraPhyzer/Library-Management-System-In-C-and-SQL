namespace Library_Management_System
{
    partial class ViewBook
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchBook = new System.Windows.Forms.Button();
            this.BookView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SelectType = new System.Windows.Forms.TextBox();
            this.BookView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ISBN",
            "Book Name",
            "Category"});
            this.comboBox1.Location = new System.Drawing.Point(3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Select From Dropdown";
            // 
            // SearchBook
            // 
            this.SearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.SearchBook.FlatAppearance.BorderSize = 0;
            this.SearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBook.ForeColor = System.Drawing.Color.White;
            this.SearchBook.Location = new System.Drawing.Point(362, 3);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(77, 23);
            this.SearchBook.TabIndex = 1;
            this.SearchBook.Text = "Search";
            this.SearchBook.UseVisualStyleBackColor = false;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // BookView
            // 
            this.BookView.Controls.Add(this.dataGridView1);
            this.BookView.Location = new System.Drawing.Point(3, 33);
            this.BookView.Name = "BookView";
            this.BookView.Size = new System.Drawing.Size(439, 324);
            this.BookView.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(439, 328);
            this.dataGridView1.TabIndex = 0;
            // 
            // SelectType
            // 
            this.SelectType.Location = new System.Drawing.Point(165, 3);
            this.SelectType.Name = "SelectType";
            this.SelectType.Size = new System.Drawing.Size(191, 23);
            this.SelectType.TabIndex = 3;
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SelectType);
            this.Controls.Add(this.BookView);
            this.Controls.Add(this.SearchBook);
            this.Controls.Add(this.comboBox1);
            this.Name = "ViewBook";
            this.Size = new System.Drawing.Size(445, 360);
            this.BookView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBox1;
        private Button SearchBook;
        private Panel BookView;
        private DataGridView dataGridView1;
        private TextBox SelectType;
    }
}
