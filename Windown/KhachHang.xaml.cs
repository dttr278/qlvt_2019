using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for KhachHang.xaml
    /// </summary>
    public partial class KhachHang : UserControl, UpdateDataWindow
    {
        Paging page;
        DataTableLog tableLog;
        static private KhachHang signleton;
        static public KhachHang Singleton => signleton;
        static KhachHang()
        {
            if (signleton == null)
                signleton = new KhachHang();
        }
        private KhachHang()
        {
            InitializeComponent();
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
            AddKhachHang.Singleton.dataGrid = dgContent;
            AddKhachHang.Singleton.Hide();
            AddKhachHang.Singleton.Show();
            Window.GetWindow(this).Closed += (o, ev) => { AddKhachHang.Singleton.Close(); };
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
            page = new Paging(Common.connection, "KhachHang", "KhachHangId desc");
            QLVTDataSet.KhachHangDataTable khachHangs = new QLVTDataSet.KhachHangDataTable();


            DataTable dataTable = page.getPage(p);
            if (dataTable != null)
            {
                khachHangs.Merge(dataTable);
            }
            dgContent.ItemsSource = khachHangs;
            tableLog = new DataTableLog((DataTable)dgContent.ItemsSource);

            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        public void redo()
        {
            tableLog.Redo();
        }

        public void undo()
        {
            tableLog.Undo();
        }

        public int update()
        {
            QLVTDataSetTableAdapters.KhachHangTableAdapter khachHangTableAdapter = Common.KhachHangTableAdapter;
            khachHangTableAdapter.Connection = Common.connection;
            return khachHangTableAdapter.Update((QLVTDataSet.KhachHangDataTable)dgContent.ItemsSource);
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (update() > 0)
            {
                Common.ShowMessage("Saved!");
            };
        }

        private void btnUndo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                undo();
            }
            catch (Exception ex)
            {

            }

        }

        private void btnRedo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                redo();
            }
            catch (Exception ex)
            {

            }

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
            page = new Paging(Common.connection, "KhachHang where KhachHangId= '" + txbSearch.Text + "'", "KhachHangId desc");
            QLVTDataSet.KhachHangDataTable khachHangs = new QLVTDataSet.KhachHangDataTable();


            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                khachHangs.Merge(dataTable);
            }
            dgContent.ItemsSource = khachHangs;
            tableLog = new DataTableLog((DataTable)dgContent.ItemsSource);

            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
                AddKhachHang addKhachHang = new AddKhachHang(((DataRowView)dgContent.CurrentItem).Row);
                addKhachHang.dataGrid = this.dgContent;
                addKhachHang.Show();
            }
            else
            {
                Common.ShowMessage("Không có hàng nào được chọn!");
            }

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                ((DataRowView)dgContent.CurrentItem).Delete();
            }
            else
            {
                Common.ShowMessage("Không có hàng nào được chọn!");
            }
        }
    }
}
