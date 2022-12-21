namespace Library_Management_System
{
    partial class Add_User
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
            this.Uname = new System.Windows.Forms.TextBox();
            this.UID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Uname
            // 
            this.Uname.Location = new System.Drawing.Point(17, 40);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(401, 25);
            this.Uname.TabIndex = 1;
            // 
            // UID
            // 
            this.UID.Location = new System.Drawing.Point(17, 111);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(401, 25);
            this.UID.TabIndex = 3;
            this.UID.Text = "XXXX-YY-ZZZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID";
            // 
            // UContact
            // 
            this.UContact.Location = new System.Drawing.Point(17, 186);
            this.UContact.Name = "UContact";
            this.UContact.Size = new System.Drawing.Size(401, 25);
            this.UContact.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(17, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Number";
            // 
            // UEmail
            // 
            this.UEmail.Location = new System.Drawing.Point(17, 265);
            this.UEmail.Name = "UEmail";
            this.UEmail.Size = new System.Drawing.Size(401, 25);
            this.UEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.Cornsilk;
            this.Save.Location = new System.Drawing.Point(17, 312);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(401, 37);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Save);
            this.Controls.Add(this.UEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Uname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Add_User";
            this.Size = new System.Drawing.Size(445, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Uname;
        private TextBox UID;
        private Label label2;
        private TextBox UContact;
        private Label label3;
        private TextBox UEmail;
        private Label label4;
        private Button Save;
        private Button button1;
    }
}
