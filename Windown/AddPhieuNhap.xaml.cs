using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for AddPhieuNhap.xaml
    /// </summary>
    public partial class AddPhieuNhap : Window
    {
        static private AddPhieuNhap signleton;
        public PhieuNhap PhieuNhap { get; set; }
        //QLVTDataSet.CTDatHangDataTable ctdh;
        QLVTDataSet.CTPhieuNhapDataTable ctpn;
        public String dhId { get; set; }
        static public AddPhieuNhap Singleton => signleton;
        static AddPhieuNhap()
        {
            if (signleton == null)
            {
                signleton = new AddPhieuNhap();

            }
        }

        //public DataGrid dataGrid { get; set; }


        private AddPhieuNhap()
        {

            InitializeComponent();

            dgKho.ItemsSource = Common.KhoDataTable;
            dgMatHang.ItemsSource = Common.MatHangDataTable;

            dgCTPN.ItemsSource = ctpn = new QLVTDataSet.CTPhieuNhapDataTable();

            EventHandler eventHandler = (o, i) => { signleton = new AddPhieuNhap(); };
            this.Closed += eventHandler;

        }


        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            DataRow kho = ((DataRowView)dgKho.SelectedItem).Row;
            QLVTDataSet.PhieuNhapRow pnRow = Common.PhieuNhapDataTable.NewPhieuNhapRow();
            pnRow["DatHangId"] = dhId;
            pnRow["KhoId"] = kho["KhoId"];
            pnRow["ThoiGian"] = DateTime.Now;
            pnRow["NhanVienId"] = Common.CurrentUser;
            int rs = 0;
            try
            {
                Common.PhieuNhapDataTable.Rows.Add(pnRow);
                rs = Common.PhieuNhapTableAdapter.Update(Common.PhieuNhapDataTable);
                if (rs > 0)
                {
                    QLVTDataSet.CTPhieuNhapDataTable ctpn = (QLVTDataSet.CTPhieuNhapDataTable)dgCTPN.ItemsSource;
                    Common.CTPhieuNhapTableAdapter.Connection = Common.connection;
                    Common.CTPhieuNhapTableAdapter.Update(ctpn);
                    PhieuNhap.loadData(0);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi sảy ra!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi sảy ra! " + ex.Message);
            }


        }


        private void btnCTAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dgMatHang.SelectedItem != null)
            {
                DataRow mhRow = (DataRow)((DataRowView)dgMatHang.SelectedItem).Row;
                DataRow[] dataRows = ctpn.Select("MatHangId = '" + mhRow["MatHangId"] + "'");
                if (dataRows.Length == 0)
                {
                    DataRow ctdhRow = ctpn.NewRow();
                    ctdhRow["MatHangId"] = mhRow["MatHangId"];
                    ctdhRow["PhieuNhapId"] = dhId;
                    ctdhRow["SoLuong"] = 1;
                    ctdhRow["DonGia"] = 0;
                    ctpn.Rows.Add(ctdhRow);
                }
                else
                {
                    dataRows[0]["SoLuong"] = int.Parse(dataRows[0]["SoLuong"].ToString()) + 1;
                }
            }
        }

        private void btnCTRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgCTPN.SelectedItem != null)
            {
                ((DataRowView)dgCTPN.SelectedItem).Delete();
            }
        }

        private void tbxKho_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.KhoDataTable kho = new QLVTDataSet.KhoDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(tbxKho.Text, out rs))
                {
                    table = Common.KhoDataTable.Select("Ten like '%" + tbxKho.Text + "%' or KhoId = " + rs).CopyToDataTable();
                }
                else
                {
                    table = Common.KhoDataTable.Select("Ten like '%" + tbxKho.Text + "%'").CopyToDataTable();
                }
                kho.Merge(table);
                dgKho.ItemsSource = kho;
            }
            catch (Exception ex)
            {
            }
        }


        private void txbVT_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.MatHangDataTable matHangs = new QLVTDataSet.MatHangDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(txbVT.Text, out rs))
                {
                    table = Common.MatHangDataTable.Select("Ten like '%" + txbVT.Text + "%' or MatHangId = " + rs).CopyToDataTable();
                }
                else
                {
                    table = Common.MatHangDataTable.Select("Ten like '%" + txbVT.Text + "%'").CopyToDataTable();
                }
                matHangs.Merge(table);
                dgMatHang.ItemsSource = matHangs;
            }
            catch (Exception ex)
            {
            }
        }

        private void dgKho_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgKho.SelectedItem != null)
                tbxKho.Text = ((DataRow)((DataRowView)dgKho.SelectedItem).Row)["Ten"].ToString();
        }


    }
}