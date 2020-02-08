using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QUANLYVATTU_PHANTAN
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_CSDLCHINH.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.DS_CSDLCHINH.V_DS_PHANMANH);
            cmbChinhanh.SelectedIndex = 1; cmbChinhanh.SelectedIndex = 0;
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cmbChinhanh.SelectedValue.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtLogin.Text; Program.password = txtPass.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = cmbChinhanh.SelectedIndex;
            Program.bds_dspm = bdsPM;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();


            Program.username = Program.myReader.GetString(0);     // Lay user name
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "Mã NV = " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên= " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
            Program.frmChinh.HienThiMenu();
        }
    }
}
