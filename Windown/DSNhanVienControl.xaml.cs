using System;
using System.Data;
using System.Data.SqlClient;
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
            switch (Common.CurrentRole)
            {
                case Common.RoleNhanVien:
                    btnAddLogin.IsEnabled =false;
                    break;
                case Common.RoleChiNhanh:
                    break;
                case Common.RoleCongTy:
                    btnAdd.IsEnabled = false;
                    btnEdit.IsEnabled = false;
                    btnRemove.IsEnabled = false;
                    btnSave.IsEnabled = false;
                    btnUndo.IsEnabled = false;
                    btnRedo.IsEnabled = false;
                    break;
                default:
                    break;
            }
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
            try
            {
                page = new Paging(Common.connection, "NhanVien where TrangThai = 0", "NhanVienId desc");
                QLVTDataSet.NhanVienDataTable nhanViens = new QLVTDataSet.NhanVienDataTable();
                nhanViens.Rows.Clear();

                DataTable dataTable = page.getPage(p);
                if (dataTable != null)
                {
                    nhanViens.Merge(dataTable);

                }
                nhanViens.DefaultView.RowFilter = "TrangThai <> 1";
                dgContent.ItemsSource = nhanViens;
                tableLog = new DataTableLog((DataTable)nhanViens);
                tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
            int rs = 0;
            try{
                rs = nhanVienTableAdapter.Update((QLVTDataSet.NhanVienDataTable)dgContent.ItemsSource);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rs;
        }

        private void btnAdd_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            add();
        }

        private void btnSave_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                if (update() > 0)
                {
                    loadData(0);
                    MessageBox.Show("Saved!");
                };
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi sảy ra trong quá trình cập nhật dữ liệu!");
            }

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
            if (txbSearch.Text.Length > 0)
            {
                page = new Paging(Common.connection, "NhanVien where TrangThai = 0 and NhanVienId = '" + txbSearch.Text + "'", "NhanVienId desc");
                QLVTDataSet.NhanVienDataTable nhanViens = new QLVTDataSet.NhanVienDataTable();
                nhanViens.Rows.Clear();

                DataTable dataTable = page.getPage(0);
                if (dataTable != null)
                {
                    nhanViens.Merge(dataTable);
                    nhanViens.DefaultView.RowFilter = "TrangThai <> 1";

                }
                dgContent.ItemsSource = nhanViens;
                tableLog = new DataTableLog((DataTable)nhanViens);
                tblNumPage.Text = (page.currentIndex + 1) + "/" + (page.totalPage + 1);

                //QLVTDataSet.NhanVienDataTable nhanViens = new QLVTDataSet.NhanVienDataTable();
                //try
                //{
                //    DataTable table = ((QLVTDataSet.NhanVienDataTable)dgContent.ItemsSource).Select("NhanVienId=" + txbSearch.Text).CopyToDataTable();
                //    nhanViens.Merge(table);
                //    dgContent.ItemsSource = nhanViens;
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Result not found!");

                //}

            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

            if (dgContent.CurrentItem != null)
            {
                tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
                AddNhanVienWindow addNhanVienWindow = new AddNhanVienWindow(((DataRowView)dgContent.CurrentItem).Row);
                addNhanVienWindow.dataGrid = this.dgContent;
                addNhanVienWindow.Show();
            }
            else
            {
                MessageBox.Show("Không có hàng nào được chọn!");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                tableLog.SetRowChange(((DataRowView)dgContent.CurrentItem).Row);
                DataRowView dataRowView = (DataRowView)dgContent.CurrentItem;
                dataRowView.Row["TrangThai"] = 1;
            }
            else
            {
                MessageBox.Show("Không có nhân viên nào được chọn!");
            }

        }

        private void btnAddLogin_Click(object sender, RoutedEventArgs e)
        {
            if (dgContent.CurrentItem != null)
            {
                try
                {
                    string id = ((DataRowView)dgContent.CurrentItem).Row["NhanVienId"].ToString();
                    if (id != null)
                    {
                        if (GetLogin(id) != null)
                        {
                            MessageBox.Show("Nhân viên đã có tài khoản đăng nhập!");
                        }
                        else
                        {
                            (new AddLogin(id)).Show();
                        }
                           
                    }
                    else
                        MessageBox.Show("Username must be not null!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có nhân viên nào được chọn!");
            }
        }
        string GetLogin(string manv)
        {
            string rs = null;
            string sql = "SP_GET_LOGIN_FROM_USER";
            SqlCommand commander = new SqlCommand(sql, Common.connection);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.AddWithValue("@username", manv);

            SqlDataReader reader = commander.ExecuteReader();

            if (reader.Read() && reader.HasRows)
            {
                rs = reader.GetValue(0).ToString();
                reader.Close();
            }
            return rs;
        }
    }
}
