using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for NhaCungCap.xaml
    /// </summary>
    public partial class NhaCungCap : UserControl, UpdateDataWindow
    {
        Paging page;
        DataTableLog tableLog;
        static private NhaCungCap signleton;
        static public NhaCungCap Singleton => signleton;
        static NhaCungCap()
        {
            if (signleton == null)
                signleton = new NhaCungCap();
        }
        private NhaCungCap()
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
            AddNhaCungCap.Singleton.dataGrid = dgContent;
            AddNhaCungCap.Singleton.Hide();
            AddNhaCungCap.Singleton.Show();
            Window.GetWindow(this).Closed += (o, ev) => { AddNhaCungCap.Singleton.Close(); };
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
            page = new Paging(Common.connection, "NhaCungCap", "NhaCungCapId desc");
            QLVTDataSet.NhaCungCapDataTable nhaCungCaps = new QLVTDataSet.NhaCungCapDataTable();


            DataTable dataTable = page.getPage(p);
            if (dataTable != null)
            {
                nhaCungCaps.Merge(dataTable);
            }
            dgContent.ItemsSource = nhaCungCaps;
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
            QLVTDataSetTableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter = Common.NhaCungCapTableAdapter;
            nhaCungCapTableAdapter.Connection = Common.connection;
            return nhaCungCapTableAdapter.Update((QLVTDataSet.NhaCungCapDataTable)dgContent.ItemsSource);
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
            try{
                undo();
            }
            catch(Exception ex)
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
            page = new Paging(Common.connection, "NhaCungCap where NhaCungCapId= '" + txbSearch.Text + "'", "NhaCungCapId desc");
            QLVTDataSet.NhaCungCapDataTable nhaCungCaps = new QLVTDataSet.NhaCungCapDataTable();


            DataTable dataTable = page.getPage(0);
            if (dataTable != null)
            {
                nhaCungCaps.Merge(dataTable);
            }
            dgContent.ItemsSource = nhaCungCaps;
            tableLog = new DataTableLog((DataTable)dgContent.ItemsSource);

            tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
                AddNhaCungCap addKhachHang = new AddNhaCungCap(((DataRowView)dgContent.CurrentItem).Row);
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
