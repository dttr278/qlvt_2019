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
            EventHandler eventHandler = (o, i) => { signleton = new AddNhaCungCap(); };
            this.Closed += eventHandler;
        }
        public AddNhaCungCap(DataRow row)
        {
            InitializeComponent();

            Id = (Int64)row["NhaCungCapId"];
            txbTen.Text = (string)row["Ten"];
            txbSDT.Text = (string)row["SoDienThoai"];
            txbDiaChi.Text = (string)row["DiaChi"];
            this.row = row;
            tblTitle.Text = "ID:" + row["NhaCungCapId"].ToString();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (row == null)
            {
                QLVTDataSet.NhaCungCapDataTable nhaCungCaps = (QLVTDataSet.NhaCungCapDataTable)dataGrid.ItemsSource;

                DataRow row = nhaCungCaps.NewRow();
                row["Ten"] = txbTen.Text;
                row["SoDienThoai"] = txbSDT.Text;
                row["DiaChi"] = txbDiaChi.Text;
                row["NhaCungCapId"] = Common.genId--;
                nhaCungCaps.Rows.Add(row);
                this.Close();
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
