using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace WpfApp2.Report
{
    /// <summary>
    /// Interaction logic for CTNX.xaml
    /// </summary>
    public partial class CTNX : Window
    {
        public CTNX()
        {
            InitializeComponent();
            dpBegin.SelectedDate = DateTime.Now;
            dpEnd.SelectedDate = DateTime.Now;
        }
        public void loadData(string begindate, string enddate, int ct)
        {
            ReportDataSource rds = new ReportDataSource();
            QLVTDataSet.THCTNX_THANGDataTable th = new QLVTDataSet.THCTNX_THANGDataTable();


            string sql = "exec SP_TONG_HOP_CTNX_THANG @begin = N'" + begindate + "', @end = N'" + enddate + "', @ct = " + ct;
            SqlCommand c = new SqlCommand(sql, Common.connection);
            if (Common.connection.State != ConnectionState.Open)
                Common.connection.Open();
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = th.NewRow();
                IDataRecord dataRecord = (IDataRecord)reader;
                row["Year"] = dataRecord["Year"];
                row["MonthYear"] = dataRecord["MonthYear"];
                row["MatHangId"] = dataRecord["MatHangId"];
                row["Ten"] = dataRecord["Ten"];
                row["SoLuongNhap"] = dataRecord["SoLuongNhap"];
                row["TongNhap"] = dataRecord["TongNhap"];
                row["SoLuongXuat"] = dataRecord["SoLuongXuat"];
                row["TongXuat"] = dataRecord["TongXuat"];
                th.Rows.Add(row);
            }

            reader.Close();


            rds.Name = "DataSet1";
            rds.Value = (DataTable)th;
            ReportParameter bg = new ReportParameter("FromDate", begindate);
            ReportParameter end = new ReportParameter("ToDate", enddate);
            ReportParameter cn=null;
            if (Common.CurrentRole == Common.RoleCongTy)
            {
               cn= new ReportParameter("CN", "Công ty");
            }
            else
            {
                cn = new ReportParameter("CN", Common.CurrentCNName);
            }

            _reportViewer.LocalReport.ReportEmbeddedResource = "WpfApp2.ReportTemplate.RDLC.CTNXThang.rdlc";
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            _reportViewer.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            _reportViewer.LocalReport.DataSources.Add(rds);

            _reportViewer.LocalReport.SetParameters(new ReportParameter[] { bg, end, cn });
            //Refresh lại báo cáo
            _reportViewer.RefreshReport();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DateTime? beginDate = dpBegin.SelectedDate;
            DateTime? endDate = dpEnd.SelectedDate;
            if (beginDate == null || endDate == null)
            {
                MessageBox.Show("Chưa chọn ngày bắt đầu và ngày kết thúc!");
            }
            else
            {
                if (((DateTime)beginDate) > ((DateTime)endDate))
                {

                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc!");
                }
                else
                {
                    int ct = 0;
                   
                    if (Common.CurrentRole == Common.RoleCongTy)
                    {
                        ct = 1;
                    }
                    loadData(((DateTime)beginDate).ToString("dd/MM/yyyy"), ((DateTime)endDate).ToString("dd/MM/yyyy"), ct);
                }
            }
        }
    }
}
