﻿using System;
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
    public partial class DeleteBook : UserControl
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection Connection = new SqlConnection();
                //Connection.ConnectionString = "data source= DESKTOP-5MC8R35\\SQLEXPRESS; database=Library Management System;integrated security=True";
                Connection.ConnectionString = "data source= DESKTOP-5MC8R35\\SQLEXPRESS; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = "Select * From AddNewBook Where ISBN='" + textBox1.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count >= 1)
                {
                    panel1.Visible = true;
                    textBox2.Text = Data.Tables[0].Rows[0][0].ToString();
                    textBox3.Text = Data.Tables[0].Rows[0][1].ToString();
                    textBox6.Text = Data.Tables[0].Rows[0][2].ToString();
                    textBox5.Text = Data.Tables[0].Rows[0][3].ToString();
                    textBox4.Text = Data.Tables[0].Rows[0][4].ToString();
                    textBox7.Text = Data.Tables[0].Rows[0][5].ToString();

                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox5.Enabled = false;
                    textBox6.Enabled = false;
                    textBox7.Enabled = false;
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
            //Connection.ConnectionString = "data source= DESKTOP-5MC8R35\\SQLEXPRESS; database=Library Management System;integrated security=True";
            Connection.ConnectionString = "data source= DESKTOP-5MC8R35\\SQLEXPRESS; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            Command.CommandText = "Delete From AddNewBook Where ISBN='"+textBox1.Text+"'";


            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);

            MessageBox.Show("Delete Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panel1.Visible = false;
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }

}
