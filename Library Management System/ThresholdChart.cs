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
    public partial class ThresholdChart : UserControl
    {
        public ThresholdChart()
        {
            InitializeComponent();
        }

        private void ThresholdChart_Load(object sender, EventArgs e)
        {
            SqlConnection Connection = new SqlConnection();
            // Connection.ConnectionString = "data source= ZUBAIR-PC; database=Library Management System;integrated security=True";
            Connection.ConnectionString = "data source= DESKTOP-ERBJH3F; database=Library Management System;integrated security=True";
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;


            Command.CommandText = "Select AB.BookName, AB.Quantity From AddNewBook as AB where AB.Quantity < 10";
            SqlDataAdapter Adapter = new SqlDataAdapter(Command);
            System.Data.DataSet Data = new System.Data.DataSet();
            Adapter.Fill(Data);


            String[] X = new String[50];
            double[] Y = new double[50];
            double[] Z = new double[50];

            for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
            {
                String Name = Data.Tables[0].Rows[i][0].ToString();
                double Count = int.Parse(Data.Tables[0].Rows[i][1].ToString());

                X[i] = Name;
                Y[i] = Count;
                Z[i] = i;
            }

            var Label = formsPlot1.Plot.AddLollipop(Y, Z);
            formsPlot1.Plot.Title("Threshold Chart With Book Name and Quantity < 10");
            formsPlot1.Plot.Legend();
            formsPlot1.Plot.XTicks(Z, X);
            Label.LollipopRadius = 10;
            Label.BorderColor = Color.Green;
            formsPlot1.Plot.SetAxisLimits(yMin: 0);
            formsPlot1.Refresh();
        }
    }
}
