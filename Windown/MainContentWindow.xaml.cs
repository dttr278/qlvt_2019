using MaterialDesignThemes.Wpf;
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

            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }

        }

        private void btnDSNhanVien_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                //DSNhanVienControl.Singleton.loadData(0);
                pnContent.Children.Add(DSNhanVienControl.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void btnDSKho_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                //KhoControl.Singleton.loadData(0);
                pnContent.Children.Add(KhoControl.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
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
                    Common.ShowMessage("Lỗi kết nối");
                }

            }
            catch (Exception ex)
            {
                Common.ShowMessage("Lỗi kết nối");
            }

        }

        private void btnDSKhachHang_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                //KhachHang.Singleton.loadData(0);
                pnContent.Children.Add(KhachHang.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            foreach (Window w in App.Current.Windows)
            {
                if (w.DataContext != this)
                    w.Close();
            }
            Application.Current.Shutdown();
        }

        private void btnDSNCC_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                //NhaCungCap.Singleton.loadData(0);
                pnContent.Children.Add(NhaCungCap.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void btnDanhMucVT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                //DanhMucVatTu.Singleton.loadData(0);
                pnContent.Children.Add(DanhMucVatTu.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void btnVT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                //VatTu.Singleton.loadData(0);
                pnContent.Children.Add(VatTu.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void btnDH_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                pnContent.Children.Add(DatHang.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void btnHD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                pnContent.Children.Add(HoaDon.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        private void btnPN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pnContent.Children.Clear();
                pnContent.Children.Add(PhieuNhap.Singleton);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }
    }
}
