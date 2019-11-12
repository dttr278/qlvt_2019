using MaterialDesignThemes.Wpf;
using System;
using System.Data.SqlClient;

namespace WpfApp2
{
    internal class Common
    {
        static private string server0;
        static private string database0;
        static private string userid0;
        static private string password0;


        static public Common singleton;

        public static string GetServer0 => server0;
        public static string GetDatabase0 => database0;
        public static string GetUserid0 => userid0;
        public static string GetPassword0 => password0;

        public static SqlConnection connection;

        public static Object ChiNhanhInfo;
        public static Object CurrentChiNhanh;
        public static Object CurrentChiNhanhId;

        private string server { get; set; }
        private string database { get; set; }
        private string userid { get; set; }
        private string password { get; set; }

        public static QLVTDataSet DataSet { get; set; }
        public static QLVTDataSetTableAdapters.NhanVienTableAdapter NhanVienTableAdapter{ get; set; }
        public static QLVTDataSetTableAdapters.KhoTableAdapter KhoTableAdapter { get; set; }

        public Common setServer(string s)
        {
            this.server = s;
            return this;
        }
        public Common setDatabase(string s)
        {
            this.database = s;
            return this;
        }
        public Common setUserid(string s)
        {
            this.userid = s;
            return this;
        }
        public Common setPassword(string s)
        {
            this.password = s;
            return this;
        }

        static public string getDefaultConnectionString()
        {
            return "server=" + server0 + ";database=" + database0 + ";user id=" + userid0 + ";password=" + password0;
        }
        public string buildConnectionString()
        {
            return "server=" + server + ";database=" + database + ";user id=" + userid + ";password=" + password;
        }


        static Common()
        {
            server0 = "DESKTOP-DOH5CIJ";
            database0 = "QLVT";
            userid0 = "QLVT_HTKN";
            password0 = "123456";

            DataSet = new QLVTDataSet();
            DataSet.EnforceConstraints = true;
            NhanVienTableAdapter = new QLVTDataSetTableAdapters.NhanVienTableAdapter();
            NhanVienTableAdapter.Adapter.InsertCommand.CommandText= "INSERT INTO QLVT.dbo.NhanVien (Ten,Ho,Phai,DiaChi,SoDienThoai,TrangThai,NgaySinh,ChiNhanhId)"
                + "VALUES(@Ten,@Ho,@Phai,@DiaChi,@SoDienThoai,@TrangThai,@NgaySinh,@ChiNhanhId)";
            KhoTableAdapter = new QLVTDataSetTableAdapters.KhoTableAdapter();
            KhoTableAdapter.Adapter.InsertCommand.CommandText = "INSERT INTO QLVT.dbo.Kho (Ten,ViTri,ChiNhanhId)"
                + "VALUES(@Ten,@ViTri,@ChiNhanhId)";
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

        public static async void ShowMessage(String mess,String root= "RootDialog")
        {
            var messageDialog = new MessageDialog
            {
                Message = { Text = mess }
            };
            try
            {
                await DialogHost.Show(messageDialog, root);
                DialogHost.CloseDialogCommand.Execute(new object(), null);
            }
            catch(Exception ex)
            {
                DialogHost.CloseDialogCommand.Execute(new object(), null);
            }
           
           
        }
    }
}
