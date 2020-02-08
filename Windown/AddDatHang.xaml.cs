using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for AddDatHang.xaml
    /// </summary>
    public partial class AddDatHang : Window
    {
        static private AddDatHang signleton;
        public DatHang DatHang { get; set; }
        QLVTDataSet.CTDatHangDataTable ctdh;
        static public AddDatHang Singleton => signleton;
        static AddDatHang()
        {
            if (signleton == null)
            {
                signleton = new AddDatHang();

            }
        }

        public DataGrid dataGrid { get; set; }


        private AddDatHang()
        {
           
            InitializeComponent();
            ViewModel viewModel = new ViewModel();
            this.DataContext = viewModel;
            dgNhaCungCap.ItemsSource = Common.NhaCungCapDataTable;
            dgMatHang.ItemsSource = Common.MatHangDataTable;

            dgCTDH.ItemsSource = ctdh = new QLVTDataSet.CTDatHangDataTable();

            EventHandler eventHandler = (o, i) => { signleton = new AddDatHang(); };
            this.Closed += eventHandler;

            //viewModel.NhaCungCap = dgNhaCungCap.SelectedValue;
            //viewModel.ChiTietDatHang = dgCTDH.SelectedValue;
            



        }
        private void ForceValidation()
        {
            dgNhaCungCap.GetBindingExpression(DataGrid.SelectedValueProperty).UpdateSource();
            //dgCTDH.GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateSource();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(dgNhaCungCap) && dgCTDH.Items.Count>0)
            {
                DataRow ncc = ((DataRowView)dgNhaCungCap.SelectedItem).Row;
                string sql = "exec SP_DATHANG @NhanVien = " + Common.CurrentUser + " ,@NhaCungCap = " + ncc["NhaCungCapId"];
                SqlCommand c = new SqlCommand(sql, Common.connection);
                if (Common.connection.State != ConnectionState.Open)
                    Common.connection.Open();
                SqlDataReader reader = c.ExecuteReader();
                reader.Read();
                String dhId = reader.GetValue(0).ToString();
                reader.Close();
                QLVTDataSet.CTDatHangDataTable datHangRows = (QLVTDataSet.CTDatHangDataTable)dgCTDH.ItemsSource;
                foreach (DataRow row in datHangRows.Rows)
                {
                    row["DatHangId"] = dhId;
                }
                Common.CTDatHangTableAdapter.Connection = Common.connection;
                Common.CTDatHangTableAdapter.Update(datHangRows);
                DatHang.loadData(0);
                //this.Close();
                dgCTDH.SelectedIndex = -1;
                dgNhaCungCap.SelectedIndex = -1;
                dgMatHang.SelectedIndex = -1;
                dgCTDH.ItemsSource = ctdh = new QLVTDataSet.CTDatHangDataTable();
                MessageBox.Show("Đã thêm!");
            }else
            if(dgCTDH.Items.Count == 0)
            {
                MessageBox.Show("Không được bỏ trống chi tiết đặt hàng.");
            }
        }

        private void dgNhaCungCap_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgNhaCungCap.SelectedItem != null)
                txbNCC.Text = ((DataRow)((DataRowView)dgNhaCungCap.SelectedItem).Row)["Ten"].ToString();
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
                    table = Common.MatHangDataTable.Select("Ten like '%" + txbVT.Text + "%' or MatHangId = " + rs).Take(5).CopyToDataTable();
                }
                else
                {
                    table = Common.MatHangDataTable.Select("Ten like '%" + txbVT.Text + "%'").Take(5).CopyToDataTable();
                }
                matHangs.Merge(table);
                dgMatHang.ItemsSource = matHangs;
            }
            catch (Exception ex)
            {
            }
        }

        private void txbNCC_KeyUp(object sender, KeyEventArgs e)
        {
            QLVTDataSet.NhaCungCapDataTable ncc = new QLVTDataSet.NhaCungCapDataTable();
            try
            {
                DataTable table;
                int rs;
                if (int.TryParse(txbNCC.Text, out rs))
                {
                    table = Common.NhaCungCapDataTable.Select("Ten like '%" + txbNCC.Text + "%' or NhaCungCapId = " + rs).Take(5).CopyToDataTable();
                }
                else
                {
                    table = Common.NhaCungCapDataTable.Select("Ten like '%" + txbNCC.Text + "%'").Take(5).CopyToDataTable();
                }
                ncc.Merge(table);
                dgNhaCungCap.ItemsSource = ncc;
            }
            catch (Exception ex)
            {
            }
        }

        private void btnCTAdd_Click(object sender, RoutedEventArgs e)
        {
            if (dgMatHang.SelectedItem != null)
            {
                DataRow mhRow = (DataRow)((DataRowView)dgMatHang.SelectedItem).Row;
                DataRow[] dataRows = ctdh.Select("MatHangId = '" + mhRow["MatHangId"] + "'");
                if (dataRows.Length == 0)
                {
                    DataRow ctdhRow = ctdh.NewRow();
                    ctdhRow["MatHangId"] = mhRow["MatHangId"];
                    ctdhRow["DatHangId"] = -1;
                    ctdhRow["SoLuong"] = 1;
                    ctdhRow["DonGia"] = 0;
                    ctdh.Rows.Add(ctdhRow);
                }
                else
                {
                    dataRows[0]["SoLuong"] = int.Parse(dataRows[0]["SoLuong"].ToString()) + 1;
                }
            }
        }

        private void btnCTRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgCTDH.SelectedItem != null)
            {
                ((DataRowView)dgCTDH.SelectedItem).Delete();
            }
        }
    }
}
