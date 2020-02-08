using MaterialDesignThemes.Wpf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;

namespace WpfApp2
{
    internal class Common
    {
        static private string server0;
        static private string database0;
        static private string userid0;
        static private string password0;

        public const string RoleChiNhanh = "CHINHANH";
        public const string RoleNhanVien = "USER";
        public const string RoleCongTy = "CONGTY";

        public static DataRow CurrentUserInfo;

        public static string CurrentUser { get; set; }
        public static string CurrentRole { get; set; }

        public static string GetServer0 => server0;
        public static string GetDatabase0 => database0;
        public static string GetUserid0 => userid0;
        public static string GetPassword0 => password0;

        public static SqlConnection connection;

        public static Object ChiNhanhInfo;
        public static Object CurrentChiNhanh;
        public static Object CurrentChiNhanhId;
        public static Object LoginChiNhanhName;

        public static string CurrentCNName;


        public static string Server { get; set; }
        public static string Database { get; set; }
        public static string Userid { get; set; }
        public static string Password { get; set; }

        public static QLVTDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.KhoTableAdapter KhoTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.KhachHangTableAdapter KhachHangTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.NhaCungCapTableAdapter NhaCungCapTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.LoaiHangTableAdapter LoaiHangTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.MatHangTableAdapter MatHangTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.DatHangTableAdapter DatHangTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.CTDatHangTableAdapter CTDatHangTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.PhieuNhapTableAdapter PhieuNhapTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.HoaDonTableAdapter HoaDonTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.CTHoaDonTableAdapter CTHoaDonTableAdapter { get; set; }
        public static QLVTDataSetTableAdapters.CTPhieuNhapTableAdapter CTPhieuNhapTableAdapter { get; set; }

        public static QLVTDataSet.LoaiHangDataTable LoaiHangDataTable { get; set; }
        public static QLVTDataSet.NhanVienDataTable NhanVienDataTable { get; set; }
        public static QLVTDataSet.NhaCungCapDataTable NhaCungCapDataTable { get; set; }
        public static QLVTDataSet.MatHangDataTable MatHangDataTable { get; set; }
        public static QLVTDataSet.CTDatHangDataTable CTDatHangDataTable { get; set; }
        public static QLVTDataSet.CTHoaDonDataTable CTHoaDonDataTable { get; set; }
        public static QLVTDataSet.KhoDataTable KhoDataTable { get; set; }
        public static QLVTDataSet.KhachHangDataTable KhachHangDataTable { get; set; }
        public static QLVTDataSet.PhieuNhapDataTable PhieuNhapDataTable { get; set; }
        public static QLVTDataSet.CTPhieuNhapDataTable CTPhieuNhapDataTable { get; set; }

        static public string getDefaultConnectionString()
        {
            return "server=" + server0 + ";database=" + database0 + ";user id=" + userid0 + ";password=" + password0;
        }
        public static string buildConnectionString()
        {
            return "server=" + Server + ";database=" + Database + ";user id=" + Userid + ";password=" + Password;
        }

        public static int genId=-1;
        static Common()
        {
            server0 = "LAPTOP-U7HEJ86K";
            database0 = "QLVT";
            userid0 = "QLVT_HTKN";
            password0 = "123";

            LoaiHangDataTable = new QLVTDataSet.LoaiHangDataTable();
            NhanVienDataTable = new QLVTDataSet.NhanVienDataTable();
            NhaCungCapDataTable = new QLVTDataSet.NhaCungCapDataTable();
            MatHangDataTable = new QLVTDataSet.MatHangDataTable();
            CTDatHangDataTable = new QLVTDataSet.CTDatHangDataTable();
            KhoDataTable = new QLVTDataSet.KhoDataTable();
            KhachHangDataTable = new QLVTDataSet.KhachHangDataTable();
            CTHoaDonDataTable = new QLVTDataSet.CTHoaDonDataTable();
            PhieuNhapDataTable = new QLVTDataSet.PhieuNhapDataTable();
            CTPhieuNhapDataTable = new QLVTDataSet.CTPhieuNhapDataTable();

            NhanVienTableAdapter = new QLVTDataSetTableAdapters.NhanVienTableAdapter();
            NhanVienTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO NhanVien (Ten,Ho,Phai,DiaChi,SoDienThoai,TrangThai,NgaySinh,ChiNhanhId)"
                + "VALUES(@Ten,@Ho,@Phai,@DiaChi,@SoDienThoai,@TrangThai,@NgaySinh,@ChiNhanhId)";
           
            KhoTableAdapter = new QLVTDataSetTableAdapters.KhoTableAdapter();
            KhoTableAdapter.Adapter.InsertCommand.CommandText = 
                "IF(@KhoId < 0) INSERT INTO Kho (Ten,ViTri,ChiNhanhId) VALUES(@Ten,@ViTri,@ChiNhanhId) "
                + "ELSE INSERT INTO Kho (KhoId,Ten,ViTri,ChiNhanhId) VALUES(@KhoId,@Ten,@ViTri,@ChiNhanhId)";
            
            KhachHangTableAdapter = new QLVTDataSetTableAdapters.KhachHangTableAdapter();
            KhachHangTableAdapter.Adapter.InsertCommand.CommandText = 
                "IF(@KhachHangId < 0) INSERT INTO KhachHang (Ten,SoDienThoai,DiaChi,ChiNhanhId) VALUES(@Ten,@SoDienThoai,@DiaChi,@ChiNhanhId)"
                + "ELSE INSERT INTO KhachHang (KhachHangId,Ten,SoDienThoai,DiaChi,ChiNhanhId) VALUES(@KhachHangId,@Ten,@SoDienThoai,@DiaChi,@ChiNhanhId)";

            NhaCungCapTableAdapter = new QLVTDataSetTableAdapters.NhaCungCapTableAdapter();
            NhaCungCapTableAdapter.Adapter.InsertCommand.CommandText =
                "IF(@NhaCungCapId < 0) INSERT INTO NhaCungCap (Ten,SoDienThoai,DiaChi) VALUES(@Ten,@SoDienThoai,@DiaChi)"
                + "ELSE INSERT INTO NhaCungCap (NhaCungCapId,Ten,SoDienThoai,DiaChi) VALUES(@NhaCungCapId,@Ten,@SoDienThoai,@DiaChi)";

            LoaiHangTableAdapter = new QLVTDataSetTableAdapters.LoaiHangTableAdapter();
            LoaiHangTableAdapter.Adapter.InsertCommand.CommandText =
                "IF(@LoaiHangId < 0) INSERT INTO LoaiHang (Ten) VALUES(@Ten)"
                + "ELSE INSERT INTO LoaiHang (LoaiHangId,Ten) VALUES(@LoaiHangId,@Ten)";

            MatHangTableAdapter = new QLVTDataSetTableAdapters.MatHangTableAdapter();
            MatHangTableAdapter.Adapter.InsertCommand.CommandText =
                "IF(@MatHangId < 0) INSERT INTO MatHang (Ten,DonViTinh,LoaiHangId) VALUES(@Ten,@DonViTinh,@LoaiHangId)"
                + "ELSE INSERT INTO MatHang (MatHangId,Ten,DonViTinh,LoaiHangId) VALUES(@MatHangId,@Ten,@DonViTinh,@LoaiHangId)";

            DatHangTableAdapter = new QLVTDataSetTableAdapters.DatHangTableAdapter();
            //DatHangTableAdapter.Adapter.InsertCommand.CommandText =
            //   "IF(@DatHangId < 0) INSERT INTO DatHang (NhanVienId,NhaCungCapId,ThoiGian) VALUES(@NhanVienId,@NhaCungCapId)"
            //   + "ELSE INSERT INTO DatHang (DatHangId,Ten,DonViTinh,LoaiHangId) VALUES(@DatHangId,@NhanVienId,@NhaCungCapId)";

            CTDatHangTableAdapter = new QLVTDataSetTableAdapters.CTDatHangTableAdapter();
            PhieuNhapTableAdapter = new QLVTDataSetTableAdapters.PhieuNhapTableAdapter();
            PhieuNhapTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO PhieuNhap (NhanVienId,KhoId,DatHangId) VALUES(@NhanVienId,@KhoId,@DatHangId)";
            HoaDonTableAdapter = new QLVTDataSetTableAdapters.HoaDonTableAdapter();
            //HoaDonTableAdapter.Adapter.InsertCommand.CommandText= "INSERT INTO HoaDon (NhanVienId,KhoId,DatHangId) VALUES(@NhanVienId,@KhoId,@DatHangId)";
            CTHoaDonTableAdapter = new QLVTDataSetTableAdapters.CTHoaDonTableAdapter();
            CTPhieuNhapTableAdapter = new QLVTDataSetTableAdapters.CTPhieuNhapTableAdapter();


        }

        public static bool IsServerConnected(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        //public static async void ShowMessage(String mess, String root = "RootDialog")
        //{
        //    var messageDialog = new MessageDialog
        //    {
        //        Message = { Text = mess }
        //    };
        //    try
        //    {
        //        await DialogHost.Show(messageDialog, root);
        //        DialogHost.CloseDialogCommand.Execute(new object(), null);
        //    }
        //    catch (Exception ex)
        //    {
        //        DialogHost.CloseDialogCommand.Execute(new object(), null);
        //    }


        //}
    }
}
