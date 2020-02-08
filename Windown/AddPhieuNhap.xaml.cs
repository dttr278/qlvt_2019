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
        //static AddPhieuNhap()
        //{
        //    if (signleton == null)
        //    {
        //        signleton = new AddPhieuNhap();

        //    }
        //}
        
        public AddPhieuNhap(string dhid)
        {
            this.dhId = dhid;


            InitializeComponent();
            ViewModel d = new ViewModel();
            dgKho.ItemsSource = Common.KhoDataTable;
            QLVTDataSet.CTDatHangDataTable dhs = new QLVTDataSet.CTDatHangDataTable();
            DataTable tb = Common.CTDatHangDataTable.Select("DatHangId = " + dhId).CopyToDataTable();
            if (tb.Rows.Count > 0)
                dhs.Merge(tb);
            dgCTDH.ItemsSource = dhs;

            dgCTPN.ItemsSource = ctpn = new QLVTDataSet.CTPhieuNhapDataTable();
            d.Kho = dgKho.SelectedValue;
            this.DataContext = d;
            //ctpn.ColumnChanging += (e, v) => {
            //    if (v.Row.RowState == DataRowState.Detached)
            //        return;
            //    id = v.Row["MatHangId"];
            //    old= v.Row["SoLuong"];
            //};
            bool change = false;
            ctpn.ColumnChanged += (e, v) => {
                if (v.Row.RowState == DataRowState.Detached|| change)
                    return;
                Object current, id;
                id = v.Row["MatHangId"];
                current = v.Row["SoLuong"];
                DataRow[] dataRows = ((QLVTDataSet.CTDatHangDataTable)dgCTDH.ItemsSource).Select("MatHangId = '" + id + "'");
                if (dataRows.Length > 0)
                {
                    int sl = (int)dataRows[0]["SoLuong"];
                    if (sl < ((int)current))
                    {
                        change = true;
                        v.Row["SoLuong"]= dataRows[0]["SoLuong"];
                        MessageBox.Show("Số lượng mặt hàng đang chọn không thể lớn hơn " + sl);
                    }
                }
                change = false;
            };
            //EventHandler eventHandler = (o, i) => { signleton = new AddPhieuNhap(); };
            //this.Closed += eventHandler;
        }

        //private AddPhieuNhap()
        //{

        //    InitializeComponent();
        //    ViewModel d = new ViewModel();
        //    dgKho.ItemsSource = Common.KhoDataTable;
        //    QLVTDataSet.CTDatHangDataTable dhs = new QLVTDataSet.CTDatHangDataTable();

        //    dhs.Merge(Common.CTDatHangDataTable.Select("DatHangId = " + dhId).CopyToDataTable());
        //    dgCTDH.ItemsSource = dhs;

        //    dgCTPN.ItemsSource = ctpn = new QLVTDataSet.CTPhieuNhapDataTable();
        //    d.Kho = dgKho.SelectedValue;
        //    this.DataContext = d;

        //    EventHandler eventHandler = (o, i) => { signleton = new AddPhieuNhap(); };
        //    this.Closed += eventHandler;

        //}
        private void ForceValidation()
        {
            dgKho.GetBindingExpression(DataGrid.SelectedValueProperty).UpdateSource();
        }


        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(dgKho) && dgCTPN.Items.Count > 0)
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
            else
            {
                if (dgCTPN.Items.Count == 0)
                {
                    MessageBox.Show("Không được bỏ trống chi tiết phiếu nhập!");
                }
            }


        }


        private void btnCTAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dgCTDH.SelectedItem != null)
            {
                DataRow mhRow = (DataRow)((DataRowView)dgCTDH.SelectedItem).Row;
                DataRow[] dataRows = ctpn.Select("MatHangId = '" + mhRow["MatHangId"] + "'");
                if (dataRows.Length == 0)
                {
                    DataRow ctdhRow = ctpn.NewRow();
                    ctdhRow["MatHangId"] = mhRow["MatHangId"];
                    ctdhRow["PhieuNhapId"] = dhId;
                    ctdhRow["SoLuong"] = mhRow["SoLuong"];
                    ctdhRow["DonGia"] = mhRow["DonGia"];
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
            QLVTDataSet.CTDatHangDataTable matHangs = new QLVTDataSet.CTDatHangDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(txbVT.Text, out rs))
                {
                    table = Common.CTDatHangDataTable.Select("MatHangId = " + rs).CopyToDataTable();
                    matHangs.Merge(table);
                    dgCTDH.ItemsSource = matHangs;
                }
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