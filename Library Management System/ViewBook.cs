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
    public partial class ViewBook : UserControl
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem!=null && SelectType.Text!="")
            {

            string X = comboBox1.SelectedItem.ToString();
            string Y = SelectType.Text.ToString();

            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            if (X=="ISBN")
            {
                Command.CommandText = "Select * From AddNewBook Where ISBN='"+Y+"'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data.Tables[0];
            }
            else if (X=="Book Name")
            {
                Command.CommandText = "Select * From AddNewBook Where BookName='"+Y+"'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data.Tables[0];
            }
            else if (X=="Category")
            {
                Command.CommandText = "Select * From AddNewBook Where Category='"+Y+"'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data.Tables[0];
            }
            else
            {
                MessageBox.Show("No Item Found" , "Select Item" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }}
            else
            {
                MessageBox.Show("Please Select Properly", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
