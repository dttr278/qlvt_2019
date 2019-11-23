using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for HoaDon.xaml
    /// </summary>
    public partial class HoaDon : UserControl, UpdateDataWindow
    {
        Paging page;
        static private HoaDon signleton;
        static public HoaDon Singleton => signleton;
        static HoaDon()
        {
            if (signleton == null)
                signleton = new HoaDon();
        }
        private HoaDon()
        {

            InitializeComponent();
            //btnRemove.IsEnabled = false;
            try
            {
                loadData(0);
            }
            catch (Exception ex)
            {
                Common.ShowMessage(ex.Message);
            }
        }

        public void add()
        {
            AddHoaDon.Singleton.HoaDon = this;
            //AddDatHang.Singleton.dataGrid = dgContent;
            AddHoaDon.Singleton.Hide();
            AddHoaDon.Singleton.Show();
            AddHoaDon.GetWindow(this).Closed += (o, ev) => { AddHoaDon.Singleton.Close(); };
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

            Common.CTHoaDonTableAdapter.Connection = Common.KhoTableAdapter.Connection = Common.KhachHangTableAdapter.Connection=Common.MatHangTableAdapter.Connection = Common.connection;
            Common.CTHoaDonTableAdapter.Fill(Common.CTHoaDonDataTable);
            Common.KhoTableAdapter.Fill(Common.KhoDataTable);
            Common.KhachHangTableAdapter.Fill(Common.KhachHangDataTable);
            Common.MatHangTableAdapter.Fill(Common.MatHangDataTable);

            page = new Paging(Common.connection, "HoaDon", "HoaDonId desc");
            QLVTDataSet.HoaDonDataTable hds = new QLVTDataSet.HoaDonDataTable();
            DataTable dataTable = page.getPage(p);
            if (dataTable != null)
            {
                hds.Merge(dataTable);
            }
            dgContent.ItemsSource = hds;
            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
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
            QLVTDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter = Common.HoaDonTableAdapter;
            HoaDonTableAdapter.Connection = Common.connection;
            return HoaDonTableAdapter.Update((QLVTDataSet.HoaDonDataTable)dgContent.ItemsSource);
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        //private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    if (update() > 0)
        //    {
        //        Common.ShowMessage("Saved!");
        //    };
        //}

        //private void btnUndo_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    try
        //    {
        //        undo();
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}

        //private void btnRedo_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    try
        //    {
        //        redo();
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //}

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
                    Common.ShowMessage("Page not found!");
                }
                else
                {
                    loadData(p);

                }
            }
            else
            {
                Common.ShowMessage("Invalid number format!");
            }
        }

        private void linkPre_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex - 1;
            if (p < 0 || p > page.totalPage)
            {
                Common.ShowMessage("Page not found!");
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
                Common.ShowMessage("Page not found!");
            }
            else
            {
                loadData(p);

            }
        }


        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            page = new Paging(Common.connection, "HoaDon where HoaDonId = '" + txbSearch.Text + "'", "HoaDonId desc");
            QLVTDataSet.HoaDonDataTable hds = new QLVTDataSet.HoaDonDataTable();
            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                hds.Merge(dataTable);
            }
            dgContent.ItemsSource = hds;
            //tableLog = new DataTableLog((DataTable)khos);
            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        //private void btnEdit_Click(object sender, RoutedEventArgs e)
        //{

        //    if (dgContent.CurrentItem != null)
        //    {
        //        //tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
        //        AddKho addKho = new AddKho(((DataRowView)dgContent.CurrentItem).Row);
        //        addKho.dataGrid = this.dgContent;
        //        addKho.Show();
        //    }
        //    else
        //    {
        //        Common.ShowMessage("Không có hàng nào được chọn!");
        //    }
        //}

        //private void btnRemove_Click(object sender, RoutedEventArgs e)
        //{

        //    if (dgContent.CurrentItem != null)
        //    {
        //        DataRow row = ((DataRowView)dgContent.CurrentItem).Row;
        //        string ms = "Đơn đặt hàng sau khi xóa sẻ không thể khôi phục. Bạn chắn chắn muốn xóa " + row["DatHangId"] + " ?";
        //        System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ms, "Xóa đơn đặt hàng", System.Windows.Forms.MessageBoxButtons.YesNo);
        //        if (result == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            try
        //            {
        //                QLVTDataSet.CTDatHangDataTable ctdh = new QLVTDataSet.CTDatHangDataTable();
        //                DataTable dataTable = ((DataRow[])dgCTContent.ItemsSource).CopyToDataTable();
        //                ctdh.Merge(dataTable);
        //                foreach (var r in ctdh)
        //                {
        //                    r.Delete();
        //                }
        //                Common.CTDatHangTableAdapter.Connection = Common.connection;
        //                Common.CTDatHangTableAdapter.Update(ctdh);

        //                ((DataRowView)dgContent.CurrentItem).Delete();
        //                Common.DatHangTableAdapter.Connection = Common.connection;
        //                Common.DatHangTableAdapter.Update((QLVTDataSet.DatHangDataTable)dgContent.ItemsSource);
        //            }
        //            catch (Exception ex)
        //            {
        //                Common.ShowMessage(ex.Message);
        //            }
        //        }
        //        else if (result == System.Windows.Forms.DialogResult.No)
        //        {
        //            //no...
        //        }

        //    }
        //    else
        //    {
        //        Common.ShowMessage("Không có hàng nào được chọn!");
        //    }
        //}

        private void dgContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgContent.SelectedItem != null)
            {
                String id = ((DataRow)((DataRowView)dgContent.SelectedItem).Row)["HoaDonid"].ToString();
                dgCTContent.ItemsSource = Common.CTHoaDonDataTable.Select("HoaDonId =" + id);

                //QLVTDataSet.PhieuNhapDataTable phieuNhaps = new QLVTDataSet.PhieuNhapDataTable();
                //Common.PhieuNhapTableAdapter.Connection = Common.connection;
                //Common.PhieuNhapTableAdapter.Fill(phieuNhaps);
                //if (phieuNhaps.Select("DatHangId = " + id).Length > 0)
                //{
                //    btnRemove.IsEnabled = false;
                //}
                //else
                //{
                //    btnRemove.IsEnabled = true;
                //}
            }
        }
    }
}