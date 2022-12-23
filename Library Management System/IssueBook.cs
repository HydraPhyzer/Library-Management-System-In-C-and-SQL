using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class IssueBook : UserControl
    {
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = "Select * From AddUser Where UserID='" + textBox1.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                Command.CommandText = "Select Count(*) From IssueBook Where UserID='" + textBox1.Text + "' and IsReturned='" + 0 + "'";
                SqlDataAdapter Adapter1 = new SqlDataAdapter(Command);
                DataSet Data1 = new DataSet();
                Adapter1.Fill(Data1);

                Command.CommandText = "Select Count(*) From IssueBook Where UserID='" + textBox1.Text + "'";
                SqlDataAdapter Adapter2 = new SqlDataAdapter(Command);
                DataSet Data2 = new DataSet();
                Adapter2.Fill(Data2);

                Command.CommandText = "Select Sum(Fine) From IssueBook Where UserID='" + textBox1.Text + "'";
                SqlDataAdapter Adapter3 = new SqlDataAdapter(Command);
                DataSet Data3 = new DataSet();
                Adapter3.Fill(Data3);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    panel2.Visible = true;
                    panel3.Visible = true;
                    textBox2.Text = Data.Tables[0].Rows[0][0].ToString();
                    textBox3.Text = Data.Tables[0].Rows[0][1].ToString();
                    textBox4.Text = Data.Tables[0].Rows[0][2].ToString();
                    textBox5.Text = Data.Tables[0].Rows[0][3].ToString();

                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    label9.Text = Data1.Tables[0].Rows[0][0].ToString();


                    int N1 = (int)Data1.Tables[0].Rows[0][0];
                    int N2 = (int)Data2.Tables[0].Rows[0][0];
                    label10.Text = (N2-N1).ToString();

                    string Fine = Data3.Tables[0].Rows[0][0].ToString();
                    label11.Text = Fine;
                }
                else
                {
                    panel2.Visible = false;
                    panel3.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void AddUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(UserControl);
            UserControl.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            Command.CommandText = "Select Count(*) From IssueBook Where UserID='" + textBox1.Text + "' and IsReturned='" + 0 + "'";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            if((int)Data.Tables[0].Rows[0][0]>=3)
            {
                //label13.Text = "Maximum Books Are Already Issued and Limit Reached";
                MessageBox.Show("Maximum Books Are Already Issued and Limit Reached", "Maximum Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GrantBook GBook = new GrantBook();
                GBook.UserID = textBox1.Text;
                AddUserControl(GBook);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string size = label9.Text;
            if ( size != "0")
            {
                ReIssue_Book RBook = new ReIssue_Book();
                RBook.UserID = textBox1.Text;
                AddUserControl(RBook);
            }
            else
            {
                MessageBox.Show("No Book Issued Yet", "Issue Book Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
