using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Library_Management_System
{
    public partial class UpdateBook : UserControl
    {
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void UpdateBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                SqlConnection Connection = new SqlConnection();
                Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = "Select * From AddNewBook Where ISBN='"+textBox1.Text+"'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count>=1)
                {
                    panel1.Visible = true;
                    textBox2.Text = Data.Tables[0].Rows[0][0].ToString();
                    textBox3.Text = Data.Tables[0].Rows[0][1].ToString();
                    textBox6.Text = Data.Tables[0].Rows[0][2].ToString();
                    textBox5.Text = Data.Tables[0].Rows[0][3].ToString();
                    textBox4.Text = Data.Tables[0].Rows[0][4].ToString();
                    textBox7.Text = Data.Tables[0].Rows[0][5].ToString();

                    textBox3.Enabled = false;
                    textBox6.Enabled = false;
                }
                else
                {
                    panel1.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter ISBN", "Enter ISBN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            Command.CommandText = "Update AddNewBook Set BookName='"+textBox2.Text+"',Category='"+textBox5.Text+"',Quantity="+textBox4.Text+" Where ISBN='"+textBox1.Text+"'";


            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            MessageBox.Show("Update Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panel1.Visible = false;
        }
    }
}
