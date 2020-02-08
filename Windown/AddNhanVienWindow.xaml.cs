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

            EventHandler eventHandler = (o, i) => { signleton = new AddNhanVienWindow(); };
            this.Closed += eventHandler;

            this.DataContext = new ViewModel();

        }
        public AddNhanVienWindow(DataRow row)
        {
            this.DataContext = new ViewModel();
            InitializeComponent();
            btnOk.Content = "Lưu";
            List<ComboData> ListData = new List<ComboData>();
            ListData.Add(new ComboData { Name = "Nam", Value = true });
            ListData.Add(new ComboData { Name = "Nu", Value = false });

            cbxPhai.ItemsSource = ListData;
            cbxPhai.SelectedValuePath = "Value";
            cbxPhai.DisplayMemberPath = "Name";
            ViewModel context = (ViewModel)this.DataContext;

            cbxPhai.SelectedIndex = 0;
            Id = (Int64)row["NhanVienId"];
            context.Ho = tbxHo.Text = (string)row["Ho"];
            context.Ten = tbxTen.Text = (string)row["Ten"];
            cbxPhai.SelectedValue = row["Phai"];
            tbxDiaChi.Text = (string)row["DiaChi"];
            tbxSoDienThoai.Text = (string)row["SoDienThoai"];
            dpNgaySinh.SelectedDate = context.Age = (DateTime)row["NgaySinh"];
            this.row = row;

            tblTitle.Text = "ID:" + row["NhanVienId"].ToString();

            
        }
        private void Reset()
        {
            tbxHo.Text = "";
            tbxTen.Text = "";
            dpNgaySinh.SelectedDate = DateTime.Now;
            cbxPhai.SelectedIndex = 0;
            tbxSoDienThoai.Text = "";
            tbxDiaChi.Text = "";
        }
        private void ForceValidation()
        {
            tbxHo.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            tbxTen.GetBindingExpression(TextBox.TextProperty).UpdateSource();
            dpNgaySinh.GetBindingExpression(DatePicker.SelectedDateProperty).UpdateSource();
        }
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            ForceValidation();
            if (!Validation.GetHasError(tbxHo) && !Validation.GetHasError(tbxTen) && !Validation.GetHasError(dpNgaySinh))
            {
                if (row == null)
                {
                    QLVTDataSet.NhanVienDataTable nhanViens = (QLVTDataSet.NhanVienDataTable)dataGrid.ItemsSource;

                    DataRow row = nhanViens.NewRow();
                    row["Ho"] = tbxHo.Text;
                    row["Ten"] = tbxTen.Text;
                    row["Phai"] = cbxPhai.SelectedValue;
                    row["DiaChi"] = tbxDiaChi.Text;
                    row["SoDienThoai"] = tbxSoDienThoai.Text;
                    DateTime? selectedDate = dpNgaySinh.SelectedDate;
                    row["NgaySinh"] = selectedDate;
                    row["NhanVienId"] = Common.genId--;
                    row["ChiNhanhId"] = (int)Common.CurrentChiNhanhId;
                    row["TrangThai"] = 0;

                    nhanViens.Rows.Add(row);
                    //this.Close();
                    Reset();
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
}
