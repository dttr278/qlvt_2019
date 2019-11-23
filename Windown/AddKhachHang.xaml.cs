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
    /// Interaction logic for AddKhachHang.xaml
    /// </summary>
    public partial class AddKhachHang : Window
    {
        public Int64 Id { get; set; }
        DataRow row;
        static private AddKhachHang signleton;

        public DataGrid dataGrid { get; set; }
        static public AddKhachHang Singleton => signleton;
        static AddKhachHang()
        {
            if (signleton == null)
            {
                signleton = new AddKhachHang();
               
            }
        }
        private AddKhachHang()
        {
            InitializeComponent();
            EventHandler eventHandler = (o, i) => { signleton = new AddKhachHang(); };
            this.Closed += eventHandler;
        }
        public AddKhachHang(DataRow row)
        {
            InitializeComponent();

            Id = (Int64)row["KhachHangId"];
            txbHo.Text = (string)row["Ho"];
            txbTen.Text = (string)row["Ten"];
            txbSDT.Text = (string)row["SoDienThoai"];
            txbDiaChi.Text = (string)row["DiaChi"];
            this.row = row;
            tblTitle.Text = "ID:" + row["KhachHangId"].ToString();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (row == null)
            {
                QLVTDataSet.KhachHangDataTable khachHangs = (QLVTDataSet.KhachHangDataTable)dataGrid.ItemsSource;

                DataRow row = khachHangs.NewRow();
                row["Ho"] = txbHo.Text;
                row["Ten"] = txbTen.Text;
                row["SoDienThoai"] = txbSDT.Text;
                row["DiaChi"] = txbDiaChi.Text;
                row["KhachHangId"] = Common.genId--;
                row["ChiNhanhId"] = Common.CurrentChiNhanhId;
                khachHangs.Rows.Add(row);
                this.Close();
            }
            else
            {
                row["Ho"] = txbHo.Text;
                row["Ten"] = txbTen.Text;
                row["SoDienThoai"] = txbSDT.Text;
                row["DiaChi"] = txbDiaChi.Text;
                this.Close();
            }
        }
    }
}
