using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Library_Management_System
{
    public partial class GrantBook : UserControl
    {
        public String UserID { get; set; }
        public GrantBook()
        {
            InitializeComponent();
        }

        private void GrantBook_Load(object sender, EventArgs e)
        {
            textBox3.Text = UserID;
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = "Select * From AddNewBook Where ISBN='" + textBox1.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    panel2.Visible = true;
                    textBox2.Text = Data.Tables[0].Rows[0][0].ToString();
                    textBox6.Text = Data.Tables[0].Rows[0][1].ToString();
                    textBox5.Text = Data.Tables[0].Rows[0][2].ToString();
                    textBox4.Text = Data.Tables[0].Rows[0][3].ToString();

                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox6.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                }
                else
                {
                    panel2.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter ISBN", "Enter ISBN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;



            Command.CommandText = "Select * From IssueBook Where ISBN='" + textBox6.Text + "' and  UserID='" + UserID + "' and IsReturned='" + 0 + "'";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);


            int res;
            if (Data.Tables[0].Rows.Count < 1)
            {
                Connection.Open();

                Command.CommandText = "Select Quantity from AddNewBook where ISBN = '" + textBox6.Text + "'";
                Command.ExecuteNonQuery();
                res = (int)Command.ExecuteScalar();
                if (res == 0)
                {
                    MessageBox.Show("Book Quantity is Zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Command.CommandText = "Insert Into IssueBook (UserID,ISBN,IssueDate,ReturnDate,IsReturned,Fine) Values ('" + textBox3.Text + "','" + textBox6.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + 0 + "','" + 0 + "') ";
                    Command.ExecuteNonQuery();
                    Command.CommandText = "update AddNewBook set Quantity = Quantity - 1 where ISBN = '" + textBox6.Text + "'";
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Book Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.Parent.Controls.Remove(this);
                panel2.Visible = true;
                Connection.Close();
            }
            else
            {
                MessageBox.Show("Book Issued Already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
