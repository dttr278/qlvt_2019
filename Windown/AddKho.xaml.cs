using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for AddKho.xaml
    /// </summary>
    public partial class AddKho : Window
    {
        public Int64 Id { get; set; }
        DataRow row;
        static private AddKho signleton;
        public DataGrid dataGrid { get; set; }
        static public AddKho Singleton => signleton;
        static AddKho()
        {
            if (signleton == null)
            {
                signleton = new AddKho();

            }
        }

        private AddKho()
        {
            InitializeComponent();
            this.DataContext = new ViewModel();
            EventHandler eventHandler = (o, i) => { signleton = new AddKho(); };
            this.Closed += eventHandler;
        }
        public AddKho(DataRow row)
        {
            InitializeComponent();
            ViewModel d = new ViewModel();
            Id = (Int64)row["KhoId"];
            d.Ten = txbTenKho.Text = (string)row["Ten"];
            d.ViTri = txbViTriKho.Text = (string)row["ViTri"];
            this.row = row;
            tblTitle.Text = "ID:" + row["KhoId"].ToString();
            this.DataContext = d;
        }
        private void ForceValidation()
        {
            txbTenKho.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            txbViTriKho.GetBindingExpression(TextBox.TextProperty).UpdateSource();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(txbTenKho) && !Validation.GetHasError(txbViTriKho))
            {
                QLVTDataSet.KhoDataTable khos = (QLVTDataSet.KhoDataTable)dataGrid.ItemsSource;
                if (row == null)
                {


                    DataRow row = khos.NewRow();
                    row["Ten"] = txbTenKho.Text;
                    row["ViTri"] = txbViTriKho.Text;
                    row["KhoId"] = Common.genId--;
                    row["ChiNhanhId"] = Common.CurrentChiNhanhId;
                    khos.Rows.Add(row);
                    txbTenKho.Text = txbViTriKho.Text = "";
                    MessageBox.Show("Đã thêm!");
                    //this.Close();
                }
                else
                {
                    row["Ten"] = txbTenKho.Text;
                    row["ViTri"] = txbViTriKho.Text;

                    this.Close();
                }
            }
        }

    }
}
