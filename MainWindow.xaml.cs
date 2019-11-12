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
            QLVTDataSet dataSet = new QLVTDataSet();
            QLVTDataSetTableAdapters.V_CNTableAdapter v_CNTableAdapter = new QLVTDataSetTableAdapters.V_CNTableAdapter();
            v_CNTableAdapter.Connection.ConnectionString = Common.getDefaultConnectionString();
            v_CNTableAdapter.Fill(dataSet.V_CN);
            cbxCN.ItemsSource = dataSet.V_CN;
            Common.ChiNhanhInfo = dataSet.V_CN;
            cbxCN.DisplayMemberPath = "Ten";
            cbxCN.SelectedValuePath = "ChiNhanhId";

            
            cbxCN.SelectedIndex = 0;

            QLVTDataSetTableAdapters.V_INFO_CNTableAdapter v_INFO_CNTableAdapter = new QLVTDataSetTableAdapters.V_INFO_CNTableAdapter();
            v_INFO_CNTableAdapter.Fill(dataSet.V_INFO_CN);

        }
        //private void ForceValidation()
        //{
        //    tbxUsername.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        //}

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //ForceValidation();

            string username = (string)tbxUsername.Text;
            string pass = (string)tbxPass.Password;

            Common dBConnection = new Common();
            dBConnection
                .setDatabase(Common.GetDatabase0)
                .setServer((string)Common.CurrentChiNhanh)
                .setUserid(username)
                .setPassword(pass);
            Common.singleton = dBConnection;

            string connectionString = dBConnection.buildConnectionString();
            try
            {
                if (Common.IsServerConnected(connectionString))
                {
                    this.Hide();
                    Common.connection = new SqlConnection(connectionString);
                    MainContentWindow.Signleton.cbxCN.ItemsSource = this.cbxCN.ItemsSource;
                    MainContentWindow.Signleton.cbxCN.SelectedValuePath = this.cbxCN.SelectedValuePath;
                    MainContentWindow.Signleton.cbxCN.DisplayMemberPath = this.cbxCN.DisplayMemberPath;
                    MainContentWindow.Signleton.cbxCN.SelectedIndex = this.cbxCN.SelectedIndex;
                    MainContentWindow.Signleton.cbxCN.SelectionChanged += cbxCN_SelectionChanged;
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
            Common dBConnection = new Common();
            dBConnection
                .setDatabase(Common.GetDatabase0)
                .setServer((string)Common.CurrentChiNhanh)
                .setUserid(Common.GetUserid0)
                .setPassword(Common.GetPassword0);
            Common.singleton = dBConnection;

            string connectionString = dBConnection.buildConnectionString();
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

            }catch(Exception ex)
            {
                Common.ShowMessage("Lỗi kết nối", "MainDialog");
            }
        }
    }
}
