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
    public partial class ViewUser : UserControl
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void SearchBook_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            if (text.Text!="")
            {
                Command.CommandText = "Select * From AddUser Where UserID='" + text.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);
                dataGridView1.DataSource = Data.Tables[0];
            }
            else
            {
                MessageBox.Show("Please Enter ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
