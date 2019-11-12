using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for DSNhanVienControl.xaml
    /// </summary>
    public partial class DSNhanVienControl : UserControl, UpdateDataWindow
    {
        Paging page;
        DataTableLog tableLog;
        static private DSNhanVienControl signleton;
        static public DSNhanVienControl Singleton => signleton;


        static DSNhanVienControl()
        {
            if (signleton == null)
                signleton = new DSNhanVienControl();
        }

        private DSNhanVienControl()
        {
            InitializeComponent();
            loadData(0);
        }

        public void add()
        {
            AddNhanVienWindow.Singleton.dataGrid = dgContent;
            AddNhanVienWindow.Singleton.Hide();
            AddNhanVienWindow.Singleton.Show();
            Window.GetWindow(this).Closed += (o, ev) => { AddNhanVienWindow.Singleton.Close(); };
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
            page = new Paging(Common.connection, 10, "NhanVien where TrangThai = 0", "NhanVienId desc");
            QLVTDataSet.NhanVienDataTable nhanViens = new QLVTDataSet.NhanVienDataTable();
            nhanViens.Rows.Clear();

            DataTable dataTable = page.getPage(p);
            if (dataTable != null)
            {
                nhanViens.Merge(dataTable);
            }
            dgContent.ItemsSource = nhanViens;
            tableLog = new DataTableLog((DataTable)nhanViens);

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
            QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter = Common.NhanVienTableAdapter;
            nhanVienTableAdapter.Connection = Common.connection;
            return nhanVienTableAdapter.Update((QLVTDataSet.NhanVienDataTable)dgContent.ItemsSource);
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (update() > 0) {
                Common.ShowMessage("Saved!");
                //MessageBox.Show("Saved!");
            };
        }

        private void btnUndo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            undo();
        }

        private void btnRedo_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            redo();
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
                    //MessageBox.Show("Page not found!");
                }
                else
                {
                    loadData(p);

                }
            }
            else
            {
                Common.ShowMessage("Invalid number format!");
                //MessageBox.Show("Invalid number format!");
            }
        }

        private void linkPre_Click(object sender, RoutedEventArgs e)
        {
            int p = page.currentIndex - 1;
            if (p < 0 || p > page.totalPage)
            {
                Common.ShowMessage("Page not found!");
                //MessageBox.Show("Page not found!");
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
            if (txbSearch.Text.Length > 0)
            {
                QLVTDataSet.NhanVienDataTable nhanViens = new QLVTDataSet.NhanVienDataTable();
                try
                {
                    DataTable table = ((QLVTDataSet.NhanVienDataTable)dgContent.ItemsSource).Select("NhanVienId=" + txbSearch.Text).CopyToDataTable();
                    nhanViens.Merge(table);
                    dgContent.ItemsSource = nhanViens;
                }
                catch (Exception ex)
                {
                    Common.ShowMessage("Result not found!");

                }
               
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            (new AddNhanVienWindow(((DataRowView)dgContent.CurrentItem).Row)).Show();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRowView = (DataRowView)dgContent.CurrentItem;
            dataRowView.Row["TrangThai"] = 1;
            QLVTDataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter = new QLVTDataSetTableAdapters.NhanVienTableAdapter();
            nhanVienTableAdapter.Connection = Common.connection;
            nhanVienTableAdapter.Update(dataRowView.Row);
            loadData(page.currentIndex);
        }
    }
}
