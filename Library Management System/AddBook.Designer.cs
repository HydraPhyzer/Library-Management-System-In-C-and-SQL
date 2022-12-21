namespace Library_Management_System
{
    partial class AddBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.PublishDate = new System.Windows.Forms.DateTimePicker();
            this.BookSave = new System.Windows.Forms.Button();
            this.BookCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publish Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // BookName
            // 
            this.BookName.Location = new System.Drawing.Point(99, 28);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(333, 23);
            this.BookName.TabIndex = 5;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(99, 71);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(333, 23);
            this.ISBN.TabIndex = 6;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(99, 167);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(333, 23);
            this.Category.TabIndex = 8;
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(99, 215);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(333, 23);
            this.Quantity.TabIndex = 9;
            // 
            // PublishDate
            // 
            this.PublishDate.Location = new System.Drawing.Point(99, 121);
            this.PublishDate.Name = "PublishDate";
            this.PublishDate.Size = new System.Drawing.Size(333, 23);
            this.PublishDate.TabIndex = 10;
            // 
            // BookSave
            // 
            this.BookSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.BookSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.BookSave.Location = new System.Drawing.Point(14, 295);
            this.BookSave.Name = "BookSave";
            this.BookSave.Size = new System.Drawing.Size(418, 29);
            this.BookSave.TabIndex = 11;
            this.BookSave.Text = "Save";
            this.BookSave.UseVisualStyleBackColor = false;
            this.BookSave.Click += new System.EventHandler(this.BookSave_Click);
            // 
            // BookCancel
            // 
            this.BookCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BookCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookCancel.ForeColor = System.Drawing.Color.Cornsilk;
            this.BookCancel.Location = new System.Drawing.Point(14, 330);
            this.BookCancel.Name = "BookCancel";
            this.BookCancel.Size = new System.Drawing.Size(418, 27);
            this.BookCancel.TabIndex = 12;
            this.BookCancel.Text = "Cancel";
            this.BookCancel.UseVisualStyleBackColor = false;
            this.BookCancel.Click += new System.EventHandler(this.BookCancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Author";
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BookCancel);
            this.Controls.Add(this.BookSave);
            this.Controls.Add(this.PublishDate);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(445, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox BookName;
        private TextBox ISBN;
        private TextBox Category;
        private TextBox Quantity;
        private DateTimePicker PublishDate;
        private Button BookSave;
        public Button BookCancel;
        private TextBox textBox1;
        private Label label6;
    }
}
