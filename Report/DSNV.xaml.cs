using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows;

namespace WpfApp2.Report
{
    /// <summary>
    /// Interaction logic for DSNV.xaml
    /// </summary>
    public partial class DSNV : Window
    {
        public DSNV()
        {
            InitializeComponent();
            loadData();
        }

    

        public void loadData()
        {
            ReportDataSource rds = new ReportDataSource();
            QLVTDataSet.V_NHANVIEN_DSDataTable dsnv = new QLVTDataSet.V_NHANVIEN_DSDataTable();
            QLVTDataSetTableAdapters.V_NHANVIEN_DSTableAdapter adapter = new QLVTDataSetTableAdapters.V_NHANVIEN_DSTableAdapter();
            adapter.Connection = Common.connection;
            adapter.Fill(dsnv);
            rds.Name = "DanhSachNV";
            rds.Value = (DataTable)dsnv;
            ReportParameter cn = null;
                cn = new ReportParameter("CN", Common.CurrentCNName);
            ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString("dd/MM/yyyy"));
            _reportViewer.LocalReport.ReportEmbeddedResource = "WpfApp2.ReportTemplate.RDLC.DanhSachNV.rdlc";
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            _reportViewer.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            _reportViewer.LocalReport.DataSources.Add(rds);

            _reportViewer.LocalReport.SetParameters(new ReportParameter[] { cn,date });
            //Refresh lại báo cáo
            _reportViewer.RefreshReport();
        }
    }
}
