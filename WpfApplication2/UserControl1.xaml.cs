using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.Reporting.WinForms;
namespace WpfApplication2
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            List<SalseOrderDomain> List = new List<SalseOrderDomain>();
            List = new List<SalseOrderDomain>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["DB"].ToString();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Top 100 * from SalseOrder;";
            conn.Open();
            var reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                var orderno = reader["OrderNo"].ToString();
                var approveDate = (DateTime)reader["ApproveDate"];
                List.Add(new SalseOrderDomain() { OrderNo = orderno, ApproveDate = approveDate });
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1"; // Name of the DataSet we set in .rdlc
            reportDataSource.Value = List;
            //reportViewer.LocalReport.ReportPath = "D:\\MonsterBusinessInc \\Report\\CustomerReport.rdlc"; // Path of the rdlc file
            this._reportViewer.LocalReport.ReportEmbeddedResource = "WpfApplication2.Report1.rdlc";
            _reportViewer.LocalReport.DataSources.Add(reportDataSource);
            _reportViewer.RefreshReport();
        }
    }
}
