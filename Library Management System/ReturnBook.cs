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
using static System.Net.Mime.MediaTypeNames;

namespace Library_Management_System
{
    public partial class ReturnBook : UserControl
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            if (textBox1.Text != "")
            {
                Command.CommandText = "Select * From IssueBook Where UserID='" + textBox1.Text + "' and IsReturned='" + 0 + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count>=1)
                {
                    dataGridView1.DataSource = Data.Tables[0];
                }
                else
                {
                    dataGridView1.Columns.Clear();
                    MessageBox.Show("No Data Found for User About Issueing Book ", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please Enter User ID", "Enter ID", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
        String User;
        String Book;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            button2.Enabled = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                User = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                Book = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Connection.Open();
            Command.CommandText = "Update IssueBook Set IsReturned='" + 1 + "' Where UserID='" + User + "' and ISBN='" + Book + "'";
            
            Command.ExecuteNonQuery();
            Command.CommandText = "update AddNewBook set Quantity = Quantity + 1 where ISBN = '" + Book + "'";
            Command.ExecuteNonQuery();

            MessageBox.Show("Book Returned Successfully !!", "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Connection.Close();
        }
    }
}
