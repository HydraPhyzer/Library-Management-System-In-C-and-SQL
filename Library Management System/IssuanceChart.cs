using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ScottPlot.Plottable.PopulationPlot;

namespace Library_Management_System
{
    public partial class IssuanceChart : UserControl
    {
        public IssuanceChart()
        {
            InitializeComponent();
        }

        private void IssuanceChart_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            // Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;


            Command.CommandText = "Select AB.BookName, Count(AB.BookName) From IssueBook as IB Inner Join AddNewBook as AB ON IB.ISBN=AB.ISBN and IB.IsReturned=0 Group By AB.BookName";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            System.Data.DataSet Data = new System.Data.DataSet();
            Adapter.Fill(Data);

            String[] X =new String[50] ;
            double[] Y =new double[50] ;
            double[] Z= new double[50] ;
            for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
            {
                String Name = Data.Tables[0].Rows[i][0].ToString();
                double Count = int.Parse(Data.Tables[0].Rows[i][1].ToString());

                X[i] = Name;
                Y[i] = Count;
                Z[i] = i;
            }

            var Label=formsPlot1.Plot.AddBar(Y, Z);
            Label.ShowValuesAboveBars = true;
            Label.FillColor = Color.LightGreen;
            formsPlot1.Plot.Title("Book Issuance Chart With Book Name and Count");
            formsPlot1.Plot.Legend();
            formsPlot1.Plot.XTicks(Z, X);
            formsPlot1.Plot.SetAxisLimits(yMin: 0);
            formsPlot1.Refresh();
        }
    }
}
