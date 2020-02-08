using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainContentWindow.xaml
    /// </summary>
    public partial class MainContentWindow : Window
    {
        static private MainContentWindow signleton;
        static public MainContentWindow Signleton => signleton;
        static MainContentWindow()
        {
            if (signleton == null)
            {
                signleton = new MainContentWindow();
            }
        }
        private MainContentWindow()
        {
            InitializeComponent();
          
            cbxCN.SelectionChanged += cbxCN_SelectionChanged;
            tbxTitle.Text = "";

            try
            {
                string sql = "exec SP_INFOLOGIN @lgname = N'" + Common.Userid + "'";
                SqlCommand c = new SqlCommand(sql, Common.connection);
                if (Common.connection.State != ConnectionState.Open)
                    Common.connection.Open();
                SqlDataReader reader = c.ExecuteReader();
                reader.Read();
                tblLogin.Text = Common.Userid;
                tblUserName.Text = reader.GetValue(0).ToString();
                tblNhom.Text = reader.GetValue(1).ToString();
                tblChiNhanh.Text = Common.LoginChiNhanhName.ToString();
                reader.Close();

                Common.CurrentUser = tblUserName.Text;
                Common.CurrentRole = tblNhom.Text;

                Common.NhanVienTableAdapter.Connection = Common.connection;
                Common.NhanVienTableAdapter.Fill(Common.NhanVienDataTable);
                DataRow[] dataRows = Common.NhanVienDataTable.Select("NhanVienId = "+tblUserName.Text);
                if (dataRows.Length == 0)
                {
                    MessageBox.Show("Role not found!");
                    //Common.connection.Close();
                    //this.Close();
                }
                else
                {
                    Common.CurrentUserInfo = dataRows[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            switch (Common.CurrentRole)
            {
                case Common.RoleNhanVien:
                    cbxCN.IsEnabled = false;
                    rpMenu.IsEnabled = false;
                    break;
                case Common.RoleChiNhanh:
                    cbxCN.IsEnabled = false;
                    break;
                case Common.RoleCongTy:
                    break;
                default:
                    break;
            }
        }

        private void btnDSNhanVien_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Danh sách nhân viên";
                pnContent.Children.Clear();
                pnContent.Children.Add(DSNhanVienControl.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDSKho_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Quản lý kho";
                pnContent.Children.Clear();
                //KhoControl.Singleton.loadData(0);
                pnContent.Children.Add(KhoControl.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxCN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbxCN = (ComboBox)sender;
            QLVTDataSet.V_CNDataTable cn = (QLVTDataSet.V_CNDataTable)Common.ChiNhanhInfo;
            DataRow[] rows = cn.Select("ChiNhanhId =" + (int)cbxCN.SelectedValue);
            string sv = (string)rows[0]["subscriber_server"];
            Common.CurrentChiNhanh = sv;
            Common.CurrentChiNhanhId = cbxCN.SelectedValue;
            Common.CurrentCNName = ((DataRowView)cbxCN.SelectedItem).Row["Ten"].ToString();

            Common.Database = (Common.GetDatabase0);
            Common.Server = ((string)Common.CurrentChiNhanh);
            Common.Userid = (Common.GetUserid0);
            Common.Password = (Common.GetPassword0);

            string connectionString = Common.buildConnectionString();
            try
            {
                if (Common.IsServerConnected(connectionString))
                {
                    Common.connection = new SqlConnection(connectionString);
                    if (pnContent.Children.Count > 0)
                    {
                        UpdateDataWindow w = (UpdateDataWindow)pnContent.Children[0];
                        w.loadData(0);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi kết nối");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }

        }

        private void btnDSKhachHang_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Quản lý khách hàng";
                pnContent.Children.Clear();
                //KhachHang.Singleton.loadData(0);
                pnContent.Children.Add(KhachHang.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window w in App.Current.Windows)
            {
                if (w.DataContext != this)
                    w.Close();
            }
            if (Common.connection.State == ConnectionState.Open)
                Common.connection.Close();
            Application.Current.Shutdown();
        }

        private void btnDSNCC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Nhà cung cấp";
                pnContent.Children.Clear();
                //NhaCungCap.Singleton.loadData(0);
                pnContent.Children.Add(NhaCungCap.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDanhMucVT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Danh mục vật tư";
                pnContent.Children.Clear();
                //DanhMucVatTu.Singleton.loadData(0);
                pnContent.Children.Add(DanhMucVatTu.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Quản lý vật tư";
                pnContent.Children.Clear();
                //VatTu.Singleton.loadData(0);
                pnContent.Children.Add(VatTu.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDH_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Đặt hàng";
                pnContent.Children.Clear();
                pnContent.Children.Add(DatHang.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Hóa đơn";
                pnContent.Children.Clear();
                pnContent.Children.Add(HoaDon.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tbxTitle.Text = "Phiếu nhập";
                pnContent.Children.Clear();
                pnContent.Children.Add(PhieuNhap.Singleton);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRPNhanView_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               (new Report.DSNV()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRPVatTu_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                //(new Report.VatTu()).Show();
                (new Report.THVatTu()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRPNhapXuatNgay_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                (new Report.THNXNgay()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRPCTNXThang_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                (new Report.CTNX()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRPHDNV_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                (new Report.HDNV()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRPNhapThang_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                (new Report.NhapTheoThang()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRPXuatThang_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                (new Report.XuatTheoThang()).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void linkLogout_Click(object sender, RoutedEventArgs e)
        //{
        //    this.MainWindow.Show();
        //    this.Close();
        //}
    }
}
