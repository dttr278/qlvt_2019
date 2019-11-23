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
    /// Interaction logic for AddVatTu.xaml
    /// </summary>
    public partial class AddVatTu : Window
    {

        public Int64 Id { get; set; }
        DataRow row;
        static private AddVatTu signleton;


        static public AddVatTu Singleton => signleton;
        static AddVatTu()
        {
            if (signleton == null)
            {
                signleton = new AddVatTu();

            }
        }

        public DataGrid dataGrid { get; set; }


        private AddVatTu()
        {

            InitializeComponent();
            QLVTDataSet.LoaiHangDataTable loaiHangs = new QLVTDataSet.LoaiHangDataTable();
            Common.LoaiHangTableAdapter.Connection = Common.connection;
            Common.LoaiHangTableAdapter.Fill(loaiHangs);
            dgLoaiMatHang.ItemsSource = loaiHangs;

            Id = 0;

            EventHandler eventHandler = (o, i) => { signleton = new AddVatTu(); };
            this.Closed += eventHandler;


        }
        public AddVatTu(DataRow row)
        {
            InitializeComponent();
            QLVTDataSet.LoaiHangDataTable loaiHangs = new QLVTDataSet.LoaiHangDataTable();
            Common.LoaiHangTableAdapter.Connection = Common.connection;
            Common.LoaiHangTableAdapter.Fill(loaiHangs);
            dgLoaiMatHang.ItemsSource = loaiHangs;

            tbxTen.Text = row["Ten"] as string;
            tbxDVT.Text = row["DonViTinh"] as string;
            dgLoaiMatHang.SelectedValue = row["LoaiHangId"].ToString();
            this.row = row;

            tblTitle.Text = "ID:" + row["MatHangId"].ToString();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (row == null)
            {
                QLVTDataSet.MatHangDataTable matHangs = (QLVTDataSet.MatHangDataTable)dataGrid.ItemsSource;

                DataRow row = matHangs.NewRow();
                row["Ten"] = tbxTen.Text;
                row["DonViTinh"] = tbxDVT.Text;
                row["MatHangId"] = Common.genId--;
                row["LoaiHangId"]= ((DataRow)((DataRowView)dgLoaiMatHang.SelectedItem).Row)["LoaiHangId"];
                matHangs.Rows.Add(row);
                this.Close();
            }
            else
            {
                row["Ten"] = tbxTen.Text;
                row["DonViTinh"] = tbxDVT.Text;
                row["LoaiHangId"] = ((DataRow)((DataRowView)dgLoaiMatHang.SelectedItem).Row)["LoaiHangId"];
                this.Close();
            }

        }

        private void dgLoaiMatHang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbxLoaiHang.Text = ((DataRow)((DataRowView)dgLoaiMatHang.SelectedItem).Row)["Ten"].ToString();
        }

        private void tbxLoaiHang_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.LoaiHangDataTable loaiHangs = new QLVTDataSet.LoaiHangDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(tbxLoaiHang.Text,out rs))
                {
                    table = Common.LoaiHangDataTable.Select("Ten like '%" + tbxLoaiHang.Text + "%' or LoaiHangId = " + rs).CopyToDataTable();
                }
                else
                {
                    table = Common.LoaiHangDataTable.Select("Ten like '%" + tbxLoaiHang.Text + "%'").CopyToDataTable();
                }
                loaiHangs.Merge(table);
                dgLoaiMatHang.ItemsSource = loaiHangs;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
