namespace Library_Management_System
{
    partial class ViewUser
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
            this.text = new System.Windows.Forms.TextBox();
            this.BookView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBook = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.BookView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(80, 10);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(240, 23);
            this.text.TabIndex = 7;
            // 
            // BookView
            // 
            this.BookView.Controls.Add(this.dataGridView1);
            this.BookView.Location = new System.Drawing.Point(3, 39);
            this.BookView.Name = "BookView";
            this.BookView.Size = new System.Drawing.Size(439, 318);
            this.BookView.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(436, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // SearchBook
            // 
            this.SearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.SearchBook.FlatAppearance.BorderSize = 0;
            this.SearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBook.ForeColor = System.Drawing.Color.White;
            this.SearchBook.Location = new System.Drawing.Point(326, 9);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(104, 23);
            this.SearchBook.TabIndex = 5;
            this.SearchBook.Text = "Search";
            this.SearchBook.UseVisualStyleBackColor = false;
            this.SearchBook.Click += new System.EventHandler(this.SearchBook_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserID.Location = new System.Drawing.Point(6, 11);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(52, 17);
            this.UserID.TabIndex = 8;
            this.UserID.Text = "User ID";
            // 
            // ViewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.text);
            this.Controls.Add(this.BookView);
            this.Controls.Add(this.SearchBook);
            this.Name = "ViewUser";
            this.Size = new System.Drawing.Size(445, 360);
            this.BookView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox text;
        private Panel BookView;
        private DataGridView dataGridView1;
        private Button SearchBook;
        private Label UserID;
    }
}
