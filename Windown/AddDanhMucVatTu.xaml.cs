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
    /// Interaction logic for AddDanhMucVatTu.xaml
    /// </summary>
    public partial class AddDanhMucVatTu : Window
    {
        public Int64 Id { get; set; }
        DataRow row;
        static private AddDanhMucVatTu signleton;

        public DataGrid dataGrid { get; set; }
        static public AddDanhMucVatTu Singleton => signleton;
        static AddDanhMucVatTu()
        {
            if (signleton == null)
            {
                signleton = new AddDanhMucVatTu();

            }
        }
        private AddDanhMucVatTu()
        {
            this.DataContext = new ViewModel();
            InitializeComponent();
            EventHandler eventHandler = (o, i) => { signleton = new AddDanhMucVatTu(); };
            this.Closed += eventHandler;
        }
        public AddDanhMucVatTu(DataRow row)
        {
            
            InitializeComponent();
            this.DataContext = new ViewModel();
            btnOk.Content = "Lưu";
            Id = (Int64)row["LoaiHangId"];
            ((ViewModel)this.DataContext).Ten =txbTen.Text = (string)row["Ten"];
            this.row = row;
            tblTitle.Text = "ID:" + row["LoaiHangId"].ToString();
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
                    QLVTDataSet.LoaiHangDataTable nhaCungCaps = (QLVTDataSet.LoaiHangDataTable)dataGrid.ItemsSource;
                    DataRow row = nhaCungCaps.NewRow();
                    row["Ten"] = txbTen.Text;
                    row["LoaiHangId"] = Common.genId--;
                    nhaCungCaps.Rows.Add(row);
                    //this.Close();
                    this.txbTen.Text = "";
                    MessageBox.Show("Đã thêm!");
                }
                else
                {
                    row["Ten"] = txbTen.Text;
                    this.Close();
                }
            }
        }
    }
}
