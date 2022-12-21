using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class AddBook : UserControl
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void BookCancel_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void BookSave_Click(object sender, EventArgs e)
        {
            if (Quantity.Text == "0")
            {
                MessageBox.Show("Please enter book quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BookName.Text!="" && ISBN.Text != "" && PublishDate.Text != "" && Category.Text != "" &&  Quantity.Text != "" && Quantity.Text.All(Char.IsDigit))
            {

                String Name = BookName.Text;
                String BookISBN = ISBN.Text;
                String Date = PublishDate.Text;
                String Categ = Category.Text;
                Int64 Quan = Int64.Parse(Quantity.Text);
                String Author = textBox1.Text;

                SqlConnection Connection = new SqlConnection();
                //Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                SqlCommand Command = new SqlCommand();
                Command.Connection = Connection;

                Command.CommandText = "Select * From AddNewBook Where ISBN='" + ISBN.Text + "'";
                SqlDataAdapter Adapter = new SqlDataAdapter(Command);
                DataSet Data = new DataSet();
                Adapter.Fill(Data);

                if(Data.Tables[0].Rows.Count < 1)
                {
                    Connection.Open();
                    Command.CommandText = "Insert Into AddNewBook (BookName,ISBN,PublishDate,Category,Quantity,AuthorName) Values ('"+Name+ "','"+BookISBN+"','"+Date+ "','"+Categ+ "','"+Quan+"','"+textBox1.Text+"') ";
                    Command.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BookName.Clear();
                    ISBN.Clear();
                    Category.Clear();
                    Quantity.Clear();


                    SqlConnection Connection1 = new SqlConnection();
                    // Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                    Connection1.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
                    SqlCommand Command1 = new SqlCommand();
                    Command1.Connection = Connection1;

                    Command1.CommandText = "Select UserEmail,UserName From AddUser Where UserEmail Like '%@%.%'";
                    SqlDataAdapter Adapter1 = new SqlDataAdapter(Command1);
                    DataSet Data1 = new DataSet();
                    Adapter1.Fill(Data1);

                    Connection1.Open();
                    for (int i = 0; i < Data1.Tables[0].Rows.Count; i++)
                    {
                        String UserEmail = Data1.Tables[0].Rows[i][0].ToString();
                        String UserName = Data1.Tables[0].Rows[i][1].ToString();
                        try
                        {
                            string mail = "huzaifahafeez85@gmail.com";
                            string pass = "wcoouqmkxmsxcagw";


                            MailMessage newMail = new MailMessage();
                            newMail.From = new MailAddress(mail);
                            newMail.Subject = "New Book Addition";
                            newMail.To.Add(new MailAddress(UserEmail));
                            SmtpClient client = new SmtpClient("smpt.gmail.com");
                            newMail.Body = "<html><body> <h4>Greeting '"+UserName+"' 👋</h4>\r\n    <p>\r\n      This is Library Management System Team. We Are Pleased to Inform About\r\n      Addition of New Book in Our Library\r\n    </p>\r\n\r\n    <p>Here Are The Book Details</p>\r\n\r\n    <strong>1) Book Name &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:</strong>\r\n    <span>'"+Name+"'</span>\r\n\r\n    <br />\r\n\r\n    <strong>2) Book Category :</strong>\r\n    <span>'"+Categ+"'</span>\r\n\r\n    <br />\r\n\r\n    <strong>3) Publish Date &nbsp;&nbsp;&nbsp; :</strong>\r\n    <span>'"+Date+"'</span>\r\n\r\n    <p>\r\n      Please, Come and Visit Our Library to Have A Look at This Marvellous Book\r\n    </p>\r\n\r\n    <p>Have a Nice Day. Good Bye.</p>\r\n\r\n    <strong>Team Library Management System</strong> </body></html>";
                            newMail.IsBodyHtml = true;

                            var smtpClient = new SmtpClient("smtp.gmail.com")
                            {
                                Port = 587,
                                Credentials = new NetworkCredential(mail, pass),
                                EnableSsl = true,
                            };

                            smtpClient.Send(newMail);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Connection1.Close();
                    MessageBox.Show("Email Send to All Users", "Email Send", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
