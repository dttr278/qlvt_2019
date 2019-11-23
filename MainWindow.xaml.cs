using MaterialDesignThemes.Wpf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public String Name { get; set; }

        public MainWindow()
        {


            InitializeComponent();

            QLVTDataSet.V_CNDataTable v_CNs = new QLVTDataSet.V_CNDataTable();
            QLVTDataSetTableAdapters.V_CNTableAdapter v_CNTableAdapter = new QLVTDataSetTableAdapters.V_CNTableAdapter();
            v_CNTableAdapter.Connection.ConnectionString = Common.getDefaultConnectionString();
            v_CNTableAdapter.Fill(v_CNs);
            cbxCN.ItemsSource = v_CNs;
            Common.ChiNhanhInfo = v_CNs;
            cbxCN.DisplayMemberPath = "Ten";
            cbxCN.SelectedValuePath = "ChiNhanhId";
            cbxCN.SelectedIndex = 0;
        }


        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //ForceValidation();

            string username = (string)tbxUsername.Text;
            string pass = (string)tbxPass.Password;

            Common.Database = Common.GetDatabase0;
            Common.Server = ((string)Common.CurrentChiNhanh);
            Common.Userid = username;
            Common.Password = pass;

            string connectionString = Common.buildConnectionString();
            try
            {
                if (Common.IsServerConnected(connectionString))
                {
                    this.Hide();
                    Common.LoginChiNhanhName = cbxCN.Text;
                    Common.connection = new SqlConnection(connectionString);
                    MainContentWindow.Signleton.cbxCN.ItemsSource = this.cbxCN.ItemsSource;
                    MainContentWindow.Signleton.cbxCN.SelectedValuePath = this.cbxCN.SelectedValuePath;
                    MainContentWindow.Signleton.cbxCN.DisplayMemberPath = this.cbxCN.DisplayMemberPath;
                    MainContentWindow.Signleton.cbxCN.SelectedIndex = this.cbxCN.SelectedIndex;

                    MainContentWindow.Signleton.Show();

                    MainContentWindow.Signleton.Closed += (o, ev) => { System.Windows.Application.Current.Shutdown(); };
                }
                else
                {
                    Common.ShowMessage("Đăng nhập không thành công", "MainDialog");
                }

            }
            catch (Exception ex)
            {
                Common.ShowMessage("Đã xãy ra lỗi trong quá trình đăng nhập", "MainDialog");
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
                }
                else
                {
                    Common.ShowMessage("Lỗi kết nối", "MainDialog");
                }

            }
            catch (Exception ex)
            {
                Common.ShowMessage("Lỗi kết nối", "MainDialog");
            }
        }
    }
}
