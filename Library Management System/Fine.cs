using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Library_Management_System
{
    public partial class Fine : UserControl
    {
        public Fine()
        {
            InitializeComponent();
        }

        private void Fine_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            //Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Connection.Open();
            if (textBox1.Text != "")
            {
                Command.CommandText = "Select IB.UserID ,AU.UserName,IB.ISBN,IB.IssueDate,IB.ReturnDate,IB.IsReturned,IB.Fine from IssueBook IB inner join AddUser AS AU on IB.UserID=AU.UserID and IB.UserID='" + textBox1.Text + "' ";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count>0)
                {
                    panel1.Visible = true;
                    label9.Text = Data.Tables[0].Rows[0][1].ToString();
                    label10.Text = Data.Tables[0].Rows[0][0].ToString();

                    Command.CommandText = "Select Sum(Fine) From IssueBook Where UserID='" + textBox1.Text + "'";
                    SqlDataAdapter Adapter3 = new SqlDataAdapter(Command);
                    DataSet Data3 = new DataSet();
                    Adapter3.Fill(Data3);


                    

                    string Fine = Data3.Tables[0].Rows[0][0].ToString();
                    label11.Text = Fine;
                    //string res = Fine;
                    //if (res != "NULL" )
                    //{
                       
                    //}


                    SqlConnection Connection4 = new SqlConnection();
                    //Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                    Connection4.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                    SqlCommand Command4 = new SqlCommand();
                    Command4.Connection = Connection4;

                    Command4.CommandText = "Select IB.Fine,IB.ISBN,AU.UserID,AB.BookName from IssueBook as IB Inner Join AddNewBook as AB on IB.ISBN=AB.ISBN Inner Join AddUser as AU on AU.UserID=IB.UserID and IB.UserID='"+ textBox1.Text +"' and IB.Fine>0;";
                    SqlDataAdapter Adapter4 = new SqlDataAdapter(Command4);
                    DataSet Data4 = new DataSet();
                    Adapter4.Fill(Data4);

                    if (Data4.Tables[0].Rows.Count>0)
                    {
                        dataGridView1.DataSource = Data4.Tables[0];
                    }
                    Connection.Close();
                }
                else
                {
                    MessageBox.Show("No Record Found Against This User", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            //Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            Command.CommandText = "Select * From IssueBook Where UserID='" + textBox1.Text + "'";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            Connection.Open();
            for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
            {
                String UserID = Data.Tables[0].Rows[i][0].ToString();
                String ISBN = Data.Tables[0].Rows[i][1].ToString();
                int Fine = (int)Data.Tables[0].Rows[i][5];

                
                if(Fine>0)
                {
                    Command.CommandText = "Update IssueBook Set Fine='" + 0 + "' , IsReturned='" + 1 + "' Where UserID='" + UserID + "' and ISBN='" + ISBN + "' and IsReturned='" + 0 + "' and Fine>'" + 0 + "'";
                    Command.ExecuteNonQuery();

                    MessageBox.Show("Fine Cleared Successfully", "Fine Clear", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Connection.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
