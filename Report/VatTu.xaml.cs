using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows;

namespace WpfApp2.Report
{
    /// <summary>
    /// Interaction logic for VatTu.xaml
    /// </summary>
    public partial class VatTu : Window
    {
        public VatTu()
        {
            InitializeComponent();
            loadData();
        }


        public void loadData()
        {
            ReportDataSource rds = new ReportDataSource();
            QLVTDataSet.V_MATHANGDataTable dsvt = new QLVTDataSet.V_MATHANGDataTable();
            QLVTDataSetTableAdapters.V_MATHANGTableAdapter adapter = new QLVTDataSetTableAdapters.V_MATHANGTableAdapter();
            adapter.Connection = Common.connection;
            adapter.Fill(dsvt);
            rds.Name = "DataSet1";
            rds.Value = (DataTable)dsvt;
            ReportParameter cn = null;
            if (Common.CurrentRole == Common.RoleCongTy)
            {
                cn = new ReportParameter("CN", "Công ty");
            }
            else
            {
                cn = new ReportParameter("CN", Common.CurrentCNName);
            }
            ReportParameter date = new ReportParameter("Date",DateTime.Now.ToString("dd/MM/yyyy"));
            _reportViewer.LocalReport.ReportEmbeddedResource = "WpfApp2.ReportTemplate.RDLC.VatTu.rdlc";
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            _reportViewer.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            _reportViewer.LocalReport.DataSources.Add(rds);

            _reportViewer.LocalReport.SetParameters(new ReportParameter[] { cn, date });
            //Refresh lại báo cáo
            _reportViewer.RefreshReport();
        }
    }
}
