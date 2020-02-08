using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace THITRACNGHIEM
{
    public partial class frmGiangVien : Form
    {
        int vitri = 0;
        int macn ;
        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
            
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);

            // phân quyền cho phép chọn cơ sở
            macn = Program.mChinhanh;
            cmbCoSo.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
            cmbCoSo.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "TRUONG") cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
            else cmbCoSo.Enabled = false;

        }

        private void cmbTENKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKH.Text = cmbTENKH.SelectedValue.ToString();
            }
            catch (Exception) { return; }
        }

        private void txtMAKH_EditValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < kHOABindingSource.Count; i++)
                if (((DataRowView)kHOABindingSource[i])["MAKH"].ToString() == txtMAKH.Text)
                {
                    kHOABindingSource.Position = i;
                    return;
                }
                    
        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
                Program.servername = cmbCoSo.SelectedValue.ToString();

                if (cmbCoSo.SelectedIndex != Program.mChinhanh) // khác với cơ sở đăng nhập ban đầu
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
                    MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
                else
                {
                    this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.KHOATableAdapter.Fill(this.DS.KHOA);
                    this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

                    macn = cmbCoSo.SelectedIndex;
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.AddNew();

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kiểm tra thông tin nhập trước khi ghi
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);

            }
            catch (Exception ex) {
                if (ex.Message.Contains("MAGV") )
                    MessageBox.Show("Mã giảng viên không được trùng", "", MessageBoxButtons.OK); 
                else
                MessageBox.Show("Lỗi ghi giảng viên . " + ex.Message, "", MessageBoxButtons.OK); 
            }

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0) {
                MessageBox.Show("Giảng viên đã đăng ký thi nên khg thể xóa", "", MessageBoxButtons.OK);
                return;
         
            }
            if (bdsBODE.Count > 0)
            {
                MessageBox.Show("Giảng viên đã soạn câu hỏi thi nên khg thể xóa", "", MessageBoxButtons.OK);
                return;

            }
            try
            {
                bdsGV.RemoveCurrent();
                this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa giảng viên . " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

    }
}
