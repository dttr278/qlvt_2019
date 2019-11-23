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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for DatHang.xaml
    /// </summary>
    public partial class DatHang : UserControl, UpdateDataWindow
    {
        Paging page;
        static private DatHang signleton;
        static public DatHang Singleton => signleton;
        static DatHang()
        {
            if (signleton == null)
                signleton = new DatHang();
        }
        private DatHang()
        {

            InitializeComponent();
            btnRemove.IsEnabled = false;
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
            AddDatHang.Singleton.DatHang = this;
            AddDatHang.Singleton.dataGrid = dgContent;
            AddDatHang.Singleton.Hide();
            AddDatHang.Singleton.Show();
            AddDatHang.GetWindow(this).Closed += (o, ev) => { AddKho.Singleton.Close(); };
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
            Common.NhaCungCapTableAdapter.Connection = Common.CTDatHangTableAdapter.Connection = Common.NhanVienTableAdapter.Connection = Common.MatHangTableAdapter.Connection = Common.connection;
            Common.NhaCungCapTableAdapter.Fill(Common.NhaCungCapDataTable);
            Common.NhanVienTableAdapter.Fill(Common.NhanVienDataTable);
            Common.MatHangTableAdapter.Fill(Common.MatHangDataTable);
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
            QLVTDataSetTableAdapters.DatHangTableAdapter DatHangTableAdapter = Common.DatHangTableAdapter;
            DatHangTableAdapter.Connection = Common.connection;
            return DatHangTableAdapter.Update((QLVTDataSet.DatHangDataTable)dgContent.ItemsSource);
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
            page = new Paging(Common.connection, "DatHang where DatHangId = '" + txbSearch.Text + "'", "DatHangId desc");
            QLVTDataSet.DatHangDataTable khos = new QLVTDataSet.DatHangDataTable();
            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                khos.Merge(dataTable);
            }
            dgContent.ItemsSource = khos;
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

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

            if (dgContent.CurrentItem != null)
            {
                DataRow row = ((DataRowView)dgContent.CurrentItem).Row;
                string ms = "Đơn đặt hàng sau khi xóa sẻ không thể khôi phục. Bạn chắn chắn muốn xóa " + row["DatHangId"] + " ?";
                System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ms, "Xóa đơn đặt hàng", System.Windows.Forms.MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        QLVTDataSet.CTDatHangDataTable ctdh = new QLVTDataSet.CTDatHangDataTable();
                        DataTable dataTable = ((DataRow[])dgCTContent.ItemsSource).CopyToDataTable();
                        ctdh.Merge(dataTable);
                        foreach (var r in ctdh)
                        {
                            r.Delete();
                        }
                        Common.CTDatHangTableAdapter.Connection = Common.connection;
                        Common.CTDatHangTableAdapter.Update(ctdh);

                        ((DataRowView)dgContent.CurrentItem).Delete();
                        Common.DatHangTableAdapter.Connection = Common.connection;
                        Common.DatHangTableAdapter.Update((QLVTDataSet.DatHangDataTable)dgContent.ItemsSource);
                    }
                    catch (Exception ex)
                    {
                        Common.ShowMessage(ex.Message);
                    }
                }
                else if (result == System.Windows.Forms.DialogResult.No)
                {
                    //no...
                }
               
            }
            else
            {
                Common.ShowMessage("Không có hàng nào được chọn!");
            }
        }

        private void dgContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgContent.SelectedItem != null)
            {
                String id = ((DataRow)((DataRowView)dgContent.SelectedItem).Row)["DatHangId"].ToString();
                dgCTContent.ItemsSource = Common.CTDatHangDataTable.Select("DatHangId =" + id);
                QLVTDataSet.PhieuNhapDataTable phieuNhaps = new QLVTDataSet.PhieuNhapDataTable();
                Common.PhieuNhapTableAdapter.Connection = Common.connection;
                Common.PhieuNhapTableAdapter.Fill(phieuNhaps);
                if(phieuNhaps.Select("DatHangId = "+ id).Length > 0)
                {
                    btnRemove.IsEnabled = false;
                }
                else
                {
                    btnRemove.IsEnabled = true;
                }
            }
        }
    }
}

