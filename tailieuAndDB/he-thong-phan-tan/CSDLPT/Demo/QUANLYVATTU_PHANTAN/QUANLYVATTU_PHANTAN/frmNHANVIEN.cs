using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYVATTU_PHANTAN
{
    public partial class frmNHANVIEN : Form
    {
        int vitri = 0;
        string macn = "";
        public frmNHANVIEN()
        {
            InitializeComponent();
            

        }

         private void frmNHANVIEN_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            this.PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.PHATSINHTableAdapter.Fill(this.DS.PHATSINH);
           
             macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
             cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY") cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
            else cmbChiNhanh.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = macn;
            dtpNGAYSINH.EditValue = "";
            cmbPHAI.SelectedValue = 0;
            
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled =  btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanvien.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled =  btnReload.Enabled = btnThoat.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            gcNhanvien.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            // Kiểm tra MACN, PHAI, NGAYSINH  phải có
            // LUONg thỏa Miền giá trị
            // MANV không được trùng trên các phân mảnh

            try
            {
                    bdsNV.EndEdit();
                    bdsNV.ResetCurrentItem();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NHANVIEN);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNhanvien.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled =  btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;

           groupBox1.Enabled = false; 
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            gcNhanvien.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled =  btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                  this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            if (bdsPS.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu", "", 
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận", 
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString()); // giữ lại để khi xóa bij lỗi thì ta sẽ quay về lại
                    bdsNV.RemoveCurrent();
                    this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.NHANVIENTableAdapter.Update(this.DS.NHANVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", 
                        MessageBoxButtons.OK);
                    this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }

            if (bdsNV.Count == 0) btnXoa.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")        return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else {
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                this.PHATSINHTableAdapter.Connection.ConnectionString = Program.connstr;
                this.PHATSINHTableAdapter.Fill(this.DS.PHATSINH);
                macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
