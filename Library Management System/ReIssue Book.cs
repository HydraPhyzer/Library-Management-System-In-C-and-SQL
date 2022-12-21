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

namespace Library_Management_System
{
    public partial class ReIssue_Book : UserControl
    {
        public String UserID { get; set; }
        public ReIssue_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")
            //{
            //    SqlConnection Connection = new SqlConnection();
            //    Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            //    SqlCommand Command = new SqlCommand();
            //    Command.Connection = Connection;

            //    Command.CommandText = "Select * From IssueBoook Where UserISBN='" + textBox1.Text + "'";
            //    SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            //    DataSet Data = new DataSet();
            //    Adapter.Fill(Data);

            //}
            if (textBox1.Text != "")
            {
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Connection.Open();
                Command.CommandText = "select * from IssueBook where UserID = '" + UserID + "' and ISBN='" + textBox1.Text + "'and  IsReturned = '" + 0 + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {

                    SqlConnection Connection1 = new SqlConnection();
                    Connection1.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                    SqlCommand Command1 = new SqlCommand();
                    Command1.Connection = Connection1;
                    Connection1.Open();
                    Command1.CommandText = "Select * From AddNewBook Where ISBN='" + textBox1.Text + "'";
                    SqlDataAdapter Adapter1 = new SqlDataAdapter(Command1);
                    DataSet Data1 = new DataSet();
                    Adapter1.Fill(Data1);



                    if (Data1.Tables[0].Rows.Count >= 1)
                    {
                        panel2.Visible = true;
                        textBox2.Text = Data1.Tables[0].Rows[0][0].ToString();
                        textBox6.Text = Data1.Tables[0].Rows[0][1].ToString();
                        textBox5.Text = Data1.Tables[0].Rows[0][2].ToString();
                        textBox4.Text = Data1.Tables[0].Rows[0][3].ToString();

                        textBox2.Enabled = false;
                        textBox3.Enabled = false;
                        textBox6.Enabled = false;
                        textBox4.Enabled = false;
                        textBox5.Enabled = false;
                        dateTimePicker1.Enabled = false;
                    }
                    else
                    {
                        panel2.Visible = false;
                    }
                    Connection1.Close();
                    Connection.Close();
                }
                else
                {
                    MessageBox.Show("Book Against That ISBN Not Isueed Yet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please Enter ISBN", "Enter ISBN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReIssue_Book_Load(object sender, EventArgs e)
        {
            textBox3.Text = UserID;
            panel2.Visible = false;
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

            Command.CommandText = "Select * From IssueBook Where ISBN='" + textBox6.Text + "' and  UserID='" + textBox3.Text + "'";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            
            Connection.Open();
            Command.CommandText = "Update IssueBook Set ReturnDate ='" + dateTimePicker2.Text + "' where ISBN='" + textBox6.Text + "' and  UserID='" + textBox3.Text + "'" ;
            Command.ExecuteNonQuery();
            Connection.Close();
            MessageBox.Show("Book Re-Issued Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Parent.Controls.Remove(this);
            panel2.Visible = true;
        }
    }
}
