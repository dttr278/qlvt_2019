using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            this.DataContext = new ViewModel();
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
            this.DataContext = new ViewModel();

            InitializeComponent();
            QLVTDataSet.LoaiHangDataTable loaiHangs = new QLVTDataSet.LoaiHangDataTable();
            Common.LoaiHangTableAdapter.Connection = Common.connection;
            Common.LoaiHangTableAdapter.Fill(loaiHangs);
            dgLoaiMatHang.ItemsSource = loaiHangs;

            ((ViewModel)this.DataContext).Ten = tbxTen.Text = row["Ten"] as string;
            ((ViewModel)this.DataContext).DonVi = tbxDVT.Text = row["DonViTinh"] as string;
            ((ViewModel)this.DataContext).LoaiVatTu = dgLoaiMatHang.SelectedValue = row["LoaiHangId"].ToString();
            this.row = row;
            tblTitle.Text = "Chỉnh sửa";

            tblTitle.Text = "ID:" + row["MatHangId"].ToString();
        }
        private void ForceValidation()
        {
            tbxTen.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbxDVT.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            dgLoaiMatHang.GetBindingExpression(DataGrid.SelectedValueProperty).UpdateSource();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(tbxTen) && !Validation.GetHasError(tbxDVT) && !Validation.GetHasError(dgLoaiMatHang))
            {
                if (row == null)
                {
                    QLVTDataSet.MatHangDataTable matHangs = (QLVTDataSet.MatHangDataTable)dataGrid.ItemsSource;

                    DataRow row = matHangs.NewRow();
                    row["Ten"] = tbxTen.Text;
                    row["DonViTinh"] = tbxDVT.Text;
                    row["MatHangId"] = Common.genId--;
                    row["LoaiHangId"] = ((DataRow)((DataRowView)dgLoaiMatHang.SelectedItem).Row)["LoaiHangId"];
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
                if (int.TryParse(tbxLoaiHang.Text, out rs))
                {
                    table = Common.LoaiHangDataTable.Select("Ten like '%" + tbxLoaiHang.Text + "%' or LoaiHangId = " + rs).Take(5).CopyToDataTable();
                }
                else
                {
                    table = Common.LoaiHangDataTable.Select("Ten like '%" + tbxLoaiHang.Text + "%'").Take(5).CopyToDataTable();
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
