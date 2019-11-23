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
            EventHandler eventHandler = (o, i) => { signleton = new AddKho(); };
            this.Closed += eventHandler;
        }
        public AddKho(DataRow row)
        {
            InitializeComponent();

            Id = (Int64)row["KhoId"];
            txbTenKho.Text = (string)row["Ten"];
            txbViTriKho.Text = (string)row["ViTri"];
            this.row = row;
            tblTitle.Text = "ID:" + row["KhoId"].ToString();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
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
                this.Close();
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
