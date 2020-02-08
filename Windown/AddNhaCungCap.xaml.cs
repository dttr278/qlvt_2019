using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for AddNhaCungCap.xaml
    /// </summary>
    public partial class AddNhaCungCap : Window
    {
        public Int64 Id { get; set; }
        DataRow row;
        static private AddNhaCungCap signleton;

        public DataGrid dataGrid { get; set; }
        static public AddNhaCungCap Singleton => signleton;
        static AddNhaCungCap()
        {
            if (signleton == null)
            {
                signleton = new AddNhaCungCap();

            }
        }
        private AddNhaCungCap()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
            EventHandler eventHandler = (o, i) => { signleton = new AddNhaCungCap(); };
            this.Closed += eventHandler;
        }
        public AddNhaCungCap(DataRow row)
        {
            InitializeComponent();
            ViewModel d = new ViewModel();
            Id = (Int64)row["NhaCungCapId"];
            d.Ten = txbTen.Text = (string)row["Ten"];
            txbSDT.Text = (string)row["SoDienThoai"];
            txbDiaChi.Text = (string)row["DiaChi"];
            this.row = row;
            tblTitle.Text = "ID:" + row["NhaCungCapId"].ToString();
            this.DataContext = d;
        }
        private void ForceValidation()
        {
            txbTen.GetBindingExpression(TextBox.TextProperty).UpdateSource();
          
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(txbTen)){
                if (row == null)
                {
                    QLVTDataSet.NhaCungCapDataTable nhaCungCaps = (QLVTDataSet.NhaCungCapDataTable)dataGrid.ItemsSource;

                    DataRow row = nhaCungCaps.NewRow();
                    row["Ten"] = txbTen.Text;
                    row["SoDienThoai"] = txbSDT.Text;
                    row["DiaChi"] = txbDiaChi.Text;
                    row["NhaCungCapId"] = Common.genId--;
                    nhaCungCaps.Rows.Add(row);

                    txbTen.Text = txbSDT.Text = txbDiaChi.Text= "";
                    MessageBox.Show("Đã thêm!");
                    //this.Close();
                }
                else
                {
                    row["Ten"] = txbTen.Text;
                    row["SoDienThoai"] = txbSDT.Text;
                    row["DiaChi"] = txbDiaChi.Text;
                    this.Close();
                }
            }
        }
    }
}
