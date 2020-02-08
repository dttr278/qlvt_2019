
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

            this.DataContext = new ViewModel();

        }

        private void ForceValidation()
        {
            tbxUsername.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            //tbxPass.GetBindingExpression(PasswordBox.DataContextProperty).UpdateSource();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(tbxUsername)&& !Validation.GetHasError(tbxPass))
            {
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
                        //this.Hide();
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
                        MessageBox.Show("Đăng nhập không thành công");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xãy ra lỗi trong quá trình đăng nhập");
                }
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
            Common.CurrentCNName  = ((DataRowView)cbxCN.SelectedItem).Row["Ten"].ToString();

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
                    MessageBox.Show("Lỗi kết nối");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
}
