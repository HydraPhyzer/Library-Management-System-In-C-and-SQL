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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        private void Home_Page_Load(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

            SqlConnection Connection = new SqlConnection();
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;

            Command.CommandText = "Select * From IssueBook Where IsReturned='" + 0 + "'";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            DataSet Data = new DataSet();
            Adapter.Fill(Data);


            SqlCommand Command1 = new SqlCommand();
            Command1.Connection = Connection;
            Connection.Open();

            for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
            {
                String UserID = Data.Tables[0].Rows[i][0].ToString();
                String ISBN= Data.Tables[0].Rows[i][1].ToString();
                String IssueDate = Data.Tables[0].Rows[i][2].ToString();
                String ReturnDate = Data.Tables[0].Rows[i][3].ToString();

                DateTime TodayDate = DateTime.Now;
                String Today = TodayDate.ToString("dddd, MMMM dd, yyyy");

                int N1 = (DateTime.Parse(ReturnDate) - DateTime.Parse(IssueDate)).Days;
                int N2 = (DateTime.Parse(Today) - DateTime.Parse(IssueDate)).Days;
                int N3 = (DateTime.Parse(Today) - DateTime.Parse(ReturnDate)).Days;

                int Fine = N3*10;
                if(N2>N1)
                {
                    Command1.CommandText = "Update IssueBook Set Fine='" + Fine + "' Where UserID='" + UserID + "' and ISBN='" + ISBN + "' and IsReturned='" + 0 + "'";

                    Command1.ExecuteNonQuery();
                }

            }
            Connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel2.Visible = true;
            panel1.Visible = false;
            panel3.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }
        private void AddUserControl(UserControl UserControl)
        {
            UserControl.Dock = DockStyle.Fill;
            panel4.Controls.Clear();
            panel4.Controls.Add(UserControl);
            UserControl.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add_User Add = new Add_User();
            AddUserControl(Add);    
        }

        private void button13_Click(object sender, EventArgs e)
        {
            AddBook BookAdd = new AddBook();
            AddUserControl(BookAdd);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ViewBook View = new ViewBook();
            AddUserControl(View);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            UpdateBook Update = new UpdateBook();
            AddUserControl(Update);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteBook Delete = new DeleteBook();
            AddUserControl(Delete);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewUser View = new ViewUser();
            AddUserControl(View);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UpdateUser Update = new UpdateUser();
            AddUserControl(Update);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            DeleteUser Delete = new DeleteUser();
            AddUserControl(Delete);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            IssueBook Issue = new IssueBook();
            AddUserControl(Issue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            ReturnBook Return = new ReturnBook();
            AddUserControl(Return);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            Fine Fn = new Fine();
            AddUserControl(Fn);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            IssuanceChart IC = new IssuanceChart();
            AddUserControl(IC);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ThresholdChart TC = new ThresholdChart();
            AddUserControl(TC);
        }
    }

}
