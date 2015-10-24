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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            
            InitializeComponent();
            
            
            
        }
       
        //private bool _isReportViewerLoaded;
        //private void ReportViewer_Load(object sender, EventArgs e)
        //{
        //    if (!_isReportViewerLoaded)
        //    {
        //        var dataSource = new ReportDataSource();
        //        dataSource.Name = "s1";
        //        dataSource.Value = List;

        //        this._reportViewer.LocalReport.ReportEmbeddedResource = "WpfApplication2.Report1.rdlc";
                
        //        _reportViewer.LocalReport.DataSources.Add(dataSource);
        //        _reportViewer.RefreshReport();
        //        _isReportViewerLoaded = true;
        //    }
        //}
        
    }
}
