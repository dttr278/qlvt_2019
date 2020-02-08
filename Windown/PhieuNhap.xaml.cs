using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for PhieuNhap.xaml
    /// </summary>
    public partial class PhieuNhap : UserControl, UpdateDataWindow
    {
        Paging page;
        static private PhieuNhap signleton;
        static public PhieuNhap Singleton => signleton;
        static PhieuNhap()
        {
            if (signleton == null)
                signleton = new PhieuNhap();
        }
        private PhieuNhap()
        {
            InitializeComponent();
            btnRemove.IsEnabled = false;
            try
            {
                loadData(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void add()
        {
            if (dgContent.CurrentItem != null)
            {
                DataRow dhRow = ((DataRowView)dgContent.SelectedItem).Row;
                string dhId = dhRow["DatHangId"].ToString();
                AddPhieuNhap pn = new AddPhieuNhap(dhId);
                pn.PhieuNhap = this;
                pn.Show();
                AddPhieuNhap.GetWindow(this).Closed += (o, ev) => { pn.Close(); };
            }
            else
            {
                MessageBox.Show("Không có đơn đặt hàng nào được chọn!");
            }

        }

        public void delete()
        {
            throw new NotImplementedException();
        }

        public void edit()
        {
            throw new NotImplementedException();
        }
        public void loadData(int p)
        {
            try
            {
                dgPN.ItemsSource = null;
                dgCTPN.ItemsSource = null;
                Common.NhaCungCapTableAdapter.Connection = Common.KhoTableAdapter.Connection = Common.NhanVienTableAdapter.Connection = Common.MatHangTableAdapter.Connection =
                    Common.PhieuNhapTableAdapter.Connection = Common.CTPhieuNhapTableAdapter.Connection = Common.CTDatHangTableAdapter.Connection = Common.connection;

                Common.NhaCungCapTableAdapter.Fill(Common.NhaCungCapDataTable);
                Common.NhanVienTableAdapter.Fill(Common.NhanVienDataTable);
                Common.MatHangTableAdapter.Fill(Common.MatHangDataTable);
                Common.KhoTableAdapter.Fill(Common.KhoDataTable);
                Common.PhieuNhapTableAdapter.Fill(Common.PhieuNhapDataTable);
                Common.CTPhieuNhapTableAdapter.Fill(Common.CTPhieuNhapDataTable);
                Common.CTDatHangTableAdapter.Fill(Common.CTDatHangDataTable);


                page = new Paging(Common.connection, "DatHang", "DatHangId desc");
                QLVTDataSet.DatHangDataTable khos = new QLVTDataSet.DatHangDataTable();
                DataTable dataTable = page.getPage(p);
                if (dataTable != null)
                {
                    khos.Merge(dataTable);
                }
                dgContent.ItemsSource = khos;
                tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void redo()
        {
            //tableLog.Redo();
        }

        public void undo()
        {
            //tableLog.Undo();
        }

        public int update()
        {
            //QLVTDataSetTableAdapters.DatHangTableAdapter DatHangTableAdapter = Common.DatHangTableAdapter;
            //DatHangTableAdapter.Connection = Common.connection;
            //return DatHangTableAdapter.Update((QLVTDataSet.DatHangDataTable)dgContent.ItemsSource);
            return 0;
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnRefresh_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            loadData(0);
        }

        private void linkGo_Click(object sender, RoutedEventArgs e)
        {
            int p;
            if (Int32.TryParse(tbxPage.Text, out p))
            {
                p--;
                if (p < 0 || p > page.totalPage)
                {
                    MessageBox.Show("Page not found!");
                }
                else
                {
                    loadData(p);

                }
            }
            else
            {
                MessageBox.Show("Invalid number format!");
            }
        }

        private void linkPre_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex - 1;
            if (p < 0 || p > page.totalPage)
            {
                MessageBox.Show("Page not found!");
            }
            else
            {
                loadData(p);

            }

        }

        private void linkNext_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex + 1;
            if (p < 0 || p > page.totalPage)
            {
                MessageBox.Show("Page not found!");
            }
            else
            {
                loadData(p);

            }
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            page = new Paging(Common.connection, "DatHang where DatHangId = '" + txbSearch.Text + "'", "DatHangId desc");
            QLVTDataSet.DatHangDataTable khos = new QLVTDataSet.DatHangDataTable();
            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                khos.Merge(dataTable);
            }
            dgContent.ItemsSource = khos;
            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            DataRow row = ((DataRowView)dgContent.CurrentItem).Row;
            string ms = "Xóa phiếu nhập trống?";
            System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ms, "Xóa phiếu nhập", System.Windows.Forms.MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    QLVTDataSet.PhieuNhapDataTable pn = new QLVTDataSet.PhieuNhapDataTable();
                    DataTable dataTable = ((DataRow[])dgPN.ItemsSource).CopyToDataTable();
                    pn.Merge(dataTable);
                    foreach (var r in pn)
                    {
                        r.Delete();
                        break;
                    }
                    Common.PhieuNhapTableAdapter.Connection = Common.connection;
                    Common.PhieuNhapTableAdapter.Update(pn);
                    dgPN.ItemsSource = null;
                    dgCTPN.ItemsSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                //no...
            }
        }

        private void dgContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgContent.SelectedItem != null)
            {
                DataRow dhRow = ((DataRowView)dgContent.SelectedItem).Row;
                string dhId = dhRow["DatHangId"].ToString();
                Common.PhieuNhapTableAdapter.Connection = Common.CTPhieuNhapTableAdapter.Connection = Common.connection;
                dgPN.ItemsSource = Common.PhieuNhapDataTable.Select("DatHangId = " + dhId);
                dgCTPN.ItemsSource = Common.CTPhieuNhapDataTable.Select("PhieuNhapId = " + dhId);
                if (Common.CurrentRole != Common.RoleCongTy)
                {
                    QLVTDataSet.PhieuNhapRow[] pns = (QLVTDataSet.PhieuNhapRow[])dgPN.ItemsSource;
                    if (pns.Length > 0)
                    {
                        btnAdd.IsEnabled = false;
                        btnRemove.IsEnabled = false;
                        QLVTDataSet.CTPhieuNhapRow[] ctphRows = (QLVTDataSet.CTPhieuNhapRow[])dgCTPN.ItemsSource;
                        if (ctphRows.Length == 0)
                        {
                            btnRemove.IsEnabled = true;
                        }
                    }
                    else
                    {
                        btnAdd.IsEnabled = true;
                    }
                }
            }
        }
    }
}

