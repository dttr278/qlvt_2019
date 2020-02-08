using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for LoginInfo.xaml
    /// </summary>
    public partial class AddLogin : Window
    {
        string id;
        public AddLogin(string id)
        {
            this.id = id;
            InitializeComponent();
            lbId.Content = id;
            string[] roles;
            switch (Common.CurrentRole)
            {
                case Common.RoleChiNhanh:
                    roles = new string[] { Common.RoleNhanVien, Common.RoleChiNhanh };
                    cbxRole.ItemsSource = roles;
                    cbxRole.SelectedIndex = 0;
                    break;
                case Common.RoleCongTy:
                    roles = new string[] { Common.RoleCongTy };
                    cbxRole.ItemsSource = roles;
                    cbxRole.SelectedIndex = 0;
                    break;
                default:
                    MessageBox.Show("Bạn không có quyền sử dụng chức năng này!");
                    this.Close();
                    break;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (tbxLogin.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống login!");
                return;
            }
            else
            {
                if (tbxPass.Password.Trim() == "")
                {
                    MessageBox.Show("Không được bỏ trống password!");
                    return;
                }
                else
                {
                    if (tbxRePass.Password != tbxPass.Password)
                    {
                        MessageBox.Show("Mật khẩu nhập lại không giống với mật khẩu!");
                        return;
                    }
                    else
                    {
                        try
                        {
                            int rs=CreateLogin(tbxLogin.Text.Trim(), tbxPass.Password,this.id,cbxRole.Text);
                            if (rs == 1)
                            {
                                MessageBox.Show("Tài khoản đã tồn tại trong hệ thống.");
                            }
                            else
                            {
                                if (rs == 2)
                                {
                                    MessageBox.Show("Username đã tồn tại - nhân viên đã có tài khoản.");
                                }
                                else
                                {
                                    MessageBox.Show("Tạo tài khoản thành công.");
                                    this.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã có lỗi sảy ra trong quá trình tạo tài khoản("+ex.Message+")");
                        }
                    }
                }
            }
        }
        int CreateLogin(string lgName, string passWord, string username, string role)
        {
            string sql = "SP_TAOTAIKHOAN";
            SqlCommand commander = new SqlCommand(sql, Common.connection);
            commander.CommandType = CommandType.StoredProcedure;
            commander.Parameters.AddWithValue("@LGNAME", lgName);
            commander.Parameters.AddWithValue("@PASS", passWord);
            commander.Parameters.AddWithValue("@USERNAME", username);
            commander.Parameters.AddWithValue("@ROLE", role);

            SqlParameter retVal = new SqlParameter("@return", SqlDbType.Int);
            retVal.Direction = ParameterDirection.Output;
            retVal.Value = -1;
            commander.Parameters.Add(retVal);

            SqlDataReader reader = commander.ExecuteReader();
            reader.Read();
            reader.Close();
            return Convert.ToInt32(retVal.Value);
        }
    }
}
