using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace WpfApp2
{
    public class ComboData
    {
        public string Name { get; set; }
        public bool Value { get; set; }
    }
    /// <summary>
    /// Interaction logic for AddNhanVienWindow.xaml
    /// </summary>
    public partial class AddNhanVienWindow : Window
    {
        
        public Int64 Id { get; set; }
        DataRow row;
        static private AddNhanVienWindow signleton;


        static public AddNhanVienWindow Singleton => signleton;
        static AddNhanVienWindow()
        {
            if (signleton == null)
            {
                signleton = new AddNhanVienWindow();
                EventHandler eventHandler = (o, i) => { signleton = new AddNhanVienWindow(); };
                signleton.Closed += eventHandler;
            }
        }

        public DataGrid dataGrid { get; set; }


        private AddNhanVienWindow()
        {

            InitializeComponent();
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Name = "Nam", Value = true });
            ListData.Add(new ComboData { Name = "Nu", Value = false });

            cbxPhai.ItemsSource = ListData;
            cbxPhai.SelectedValuePath = "Value";
            cbxPhai.DisplayMemberPath = "Name";

            cbxPhai.SelectedIndex = 0;

            Id = 0;


        }
        public AddNhanVienWindow(DataRow row)
        {
            InitializeComponent();
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Name = "Nam", Value = true });
            ListData.Add(new ComboData { Name = "Nu", Value = false });

            cbxPhai.ItemsSource = ListData;
            cbxPhai.SelectedValuePath = "Value";
            cbxPhai.DisplayMemberPath = "Name";

            cbxPhai.SelectedIndex = 0;
            Id = (Int64)row["NhanVienId"];
            tbxHo.Text= (string)row["Ho"];
            tbxTen.Text=(string)row["Ten"] ;
            cbxPhai.SelectedValue=row["Phai"] ;
            tbxDiaChi.Text=(string)row["DiaChi"];
            tbxSoDienThoai.Text=(string)row["SoDienThoai"] ;
            dpNgaySinh.SelectedDate=(DateTime)row["NgaySinh"];
            this.row = row;

            tblTitle.Text = "ID:" + row["NhanVienId"].ToString();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (row == null)
            {
                QLVTDataSet.NhanVienDataTable nhanViens = (QLVTDataSet.NhanVienDataTable)dataGrid.ItemsSource;
                //nhanVienTableAdapter.Fill(nhanViens);
                DataRow row = nhanViens.NewRow();
                if(!row["Ho"].ToString().Equals(tbxHo.Text))
                    row["Ho"] = tbxHo.Text;
                if(!row["Ten"].ToString().Equals(tbxTen.Text))
                    row["Ten"] = tbxTen.Text;
                row["Phai"] = cbxPhai.SelectedValue;
                row["DiaChi"] = tbxDiaChi.Text;
                row["SoDienThoai"] = tbxSoDienThoai.Text;
                DateTime? selectedDate = dpNgaySinh.SelectedDate;
                row["NgaySinh"] = selectedDate;
                row["NhanVienId"] =  -1;
                row["ChiNhanhId"] = (int)Common.CurrentChiNhanhId;
                row["TrangThai"] = 0;
                
                nhanViens.Rows.Add(row);
                this.Close();
            }
            else
            {
                row["Ho"] = tbxHo.Text;
                row["Ten"] = tbxTen.Text;
                row["Phai"] = cbxPhai.SelectedValue;
                row["DiaChi"] = tbxDiaChi.Text;
                row["SoDienThoai"] = tbxSoDienThoai.Text;

                DateTime? selectedDate = dpNgaySinh.SelectedDate;
                row["NgaySinh"] = selectedDate;
                this.Close();
            }

            //nhanViens.AddNhanVienRow()

        }


    }
}
