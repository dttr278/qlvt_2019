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
            switch (Common.CurrentRole)
            {
                case Common.RoleNhanVien:
                    break;
                case Common.RoleChiNhanh:
                    break;
                case Common.RoleCongTy:
                    btnAdd.IsEnabled = false;
                    break;
                default:
                    break;
            }
            //btnRemove.IsEnabled = false;
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
            try
            {

                Common.CTHoaDonTableAdapter.Connection = Common.KhoTableAdapter.Connection = Common.KhachHangTableAdapter.Connection = Common.MatHangTableAdapter.Connection = Common.connection;
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
            QLVTDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter = Common.HoaDonTableAdapter;
            HoaDonTableAdapter.Connection = Common.connection;
            return HoaDonTableAdapter.Update((QLVTDataSet.HoaDonDataTable)dgContent.ItemsSource);
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


        private void dgContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgContent.SelectedItem != null)
            {
                String id = ((DataRow)((DataRowView)dgContent.SelectedItem).Row)["HoaDonid"].ToString();
                dgCTContent.ItemsSource = Common.CTHoaDonDataTable.Select("HoaDonId =" + id);
            }
        }
    }
}