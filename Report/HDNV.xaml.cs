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
    /// Interaction logic for HDNV.xaml
    /// </summary>
    public partial class HDNV : Window
    {
        public HDNV()
        {
            InitializeComponent();
            Common.NhanVienTableAdapter.Connection = Common.connection;
            Common.NhanVienTableAdapter.Fill(Common.NhanVienDataTable);
            cbxMaNhanVien.ItemsSource = Common.NhanVienDataTable;
            cbxMaNhanVien.DisplayMemberPath = cbxMaNhanVien.SelectedValuePath = "NhanVienId";

            dpBegin.SelectedDate = DateTime.Now;
            dpEnd.SelectedDate = DateTime.Now;
        }
        public void loadData(string begindate, string enddate, Int64 nv)
        {
            ReportDataSource rds = new ReportDataSource();
            QLVTDataSet.HOAT_DONG_NVDataTable th = new QLVTDataSet.HOAT_DONG_NVDataTable();


            string sql = "exec SP_HOAT_DONG_NV @begin = N'" + begindate + "', @end = N'" + enddate + "', @nv = " + nv;
            SqlCommand c = new SqlCommand(sql, Common.connection);
            if (Common.connection.State != ConnectionState.Open)
                Common.connection.Open();
            SqlDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                DataRow row = th.NewRow();
                IDataRecord dataRecord = (IDataRecord)reader;
                row["KhoId"] = dataRecord["KhoId"];
                row["TenKho"] = dataRecord["TenKho"];
                row["ThoiGian"] = dataRecord["ThoiGian"];
                row["Ma"] = dataRecord["Ma"];
                row["Loai"] = dataRecord["Loai"];
                row["SoLuong"] = dataRecord["SoLuong"];
                row["DonGia"] = dataRecord["DonGia"];
                row["ThanhTien"] = dataRecord["ThanhTien"];
                row["MatHangId"] = dataRecord["MatHangId"];
                row["TenMatHang"] = dataRecord["TenMatHang"];
                th.Rows.Add(row);
            }

            reader.Close();


            rds.Name = "DataSet1";
            rds.Value = (DataTable)th;
            DataRowView infoNV = (DataRowView)cbxMaNhanVien.SelectedItem;
            ReportParameter bg = new ReportParameter("FromDate", begindate);
            ReportParameter end = new ReportParameter("ToDate", enddate);
            ReportParameter cn = new ReportParameter("CN", Common.CurrentCNName);
            ReportParameter maNV = new ReportParameter("MaNV", nv.ToString());
            ReportParameter ten = new ReportParameter("TenNV", infoNV["Ten"].ToString());
            ReportParameter phai = new ReportParameter("Phai", (bool)infoNV["Phai"] ? "Nam" : "Nữ");
            ReportParameter ngaySinh = new ReportParameter("NgaySinh",((DateTime)infoNV["NgaySinh"]).ToString("dd/MM/yyyy"));
            ReportParameter sdt = new ReportParameter("SDT", infoNV["SoDienThoai"].ToString());
            ReportParameter diaChi = new ReportParameter("DiaChi", infoNV["DiaChi"].ToString());



            _reportViewer.LocalReport.ReportEmbeddedResource = "WpfApp2.ReportTemplate.RDLC.NVHD.rdlc";
            //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
            _reportViewer.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            _reportViewer.LocalReport.DataSources.Add(rds);

            _reportViewer.LocalReport.SetParameters(new ReportParameter[] { bg, end, cn, ten, phai, ngaySinh, sdt, diaChi,maNV });
            //Refresh lại báo cáo
            _reportViewer.RefreshReport();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (cbxMaNhanVien.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn một nhân viên!");
            }
            else
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
                        Int64 nv = (Int64)((DataRowView)cbxMaNhanVien.SelectedItem)["NhanVienId"];
                        loadData(((DateTime)beginDate).ToString("dd/MM/yyyy"), ((DateTime)endDate).ToString("dd/MM/yyyy"), nv);
                    }
                }
            }

        }

        private void cbxMaNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbxMaNhanVien.SelectedItem != null)
            {
                tbxTenNhanVien.Text = ((DataRowView)cbxMaNhanVien.SelectedItem)["Ho"].ToString() + " " + ((DataRowView)cbxMaNhanVien.SelectedItem)["Ten"].ToString();
            }
            else
            {
                tbxTenNhanVien.Text = "";
            }
        }
    }
}
