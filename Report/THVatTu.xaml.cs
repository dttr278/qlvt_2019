using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2.Report
{
    /// <summary>
    /// Interaction logic for THVatTu.xaml
    /// </summary>
    public partial class THVatTu : Window
    {
        public THVatTu()
        {
            InitializeComponent();
            loadData();
        }
        public void loadData()
        {
            ReportDataSource rds = new ReportDataSource();
            QLVTDataSet.TongHopVatTuDataTable th = new QLVTDataSet.TongHopVatTuDataTable();


            string sql = "exec SP_TONGHOP_VT";
            SqlCommand c = new SqlCommand(sql, Common.connection);
            if (Common.connection.State != ConnectionState.Open)
                Common.connection.Open();
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = th.NewRow();
                IDataRecord dataRecord = (IDataRecord)reader;
                row["MatHangId"] = dataRecord["MatHangId"];
                row["Ten"] = dataRecord["Ten"];
                row["LoaiHangId"] = dataRecord["TenLoaiHang"];
                row["TenLoaiHang"] = dataRecord["TenLoaiHang"];
                row["SoLuong"] = dataRecord["SoLuong"];
                row["DonViTinh"] = dataRecord["DonViTinh"];
                th.Rows.Add(row);
            }

            reader.Close();


            rds.Name = "DataSet1";
            rds.Value = (DataTable)th;
            ReportParameter ngay = new ReportParameter("Ngay", DateTime.Now.ToString("dd/MM/yyyy"));
            _reportViewer.LocalReport.ReportEmbeddedResource = "WpfApp2.ReportTemplate.RDLC.THVatTu.rdlc";
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            _reportViewer.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            _reportViewer.LocalReport.DataSources.Add(rds);

            _reportViewer.LocalReport.SetParameters(new ReportParameter[] { ngay });
            //Refresh lại báo cáo
            _reportViewer.RefreshReport();
        }
    }
}
