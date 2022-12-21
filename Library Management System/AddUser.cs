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
    public partial class Add_User : UserControl
    {
        public Add_User()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (Uname.Text != "" && UID.Text != "" && UContact.Text != "" && UEmail.Text != "")
            {
                String Name = Uname.Text;
                String ID = UID.Text;
                String Contact = UContact.Text;
                String Email = UEmail.Text;

                SqlConnection Connection = new SqlConnection();
                // Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;


                Command.CommandText = "Select * From AddUser Where UserID='" + UID.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if (Data.Tables[0].Rows.Count<1)
                {
                    Connection.Open();
                    Command.CommandText = "Insert Into AddUser (UserName,UserID,UserContact,UserEmail) Values ('" + Name + "','" + ID + "','" + Contact + "','" + Email + "')";
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Uname.Clear();
                    UID.Clear();
                    UContact.Clear();
                    UEmail.Clear();
                }
                else
                {
                    MessageBox.Show("Primary Key Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Fill Complete Information or Data Type Issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
