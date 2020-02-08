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
    public partial class frmGV : Form
    {
        string dsmakh = "";
        public frmGV()
        {
            InitializeComponent();
        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGV_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DS.BODE' table. You can move, or remove it, as needed.
            this.BODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.BODETableAdapter.Fill(this.DS.BODE);
            // TODO: This line of code loads data into the 'DS.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dS.KHOA' table. You can move, or remove it, as needed.
            this.KHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHOATableAdapter.Fill(this.DS.KHOA);
            // TODO: This line of code loads data into the 'dS.GIAOVIEN' table. You can move, or remove it, as needed.
            this.GIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GIAOVIENTableAdapter.Fill(this.DS.GIAOVIEN);

            cmbCoso.DataSource = Program.bds_dspm;
            cmbCoso.DisplayMember = "TENCN";
            cmbCoso.ValueMember = "TENSERVER";
           
            if (Program.mGroup == "TRUONG")
            {
                cmbCoso.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnPhuchoi.Enabled = false;
            }
            else cmbCoso.Enabled = false;
            dsmakh = DsMaKhoa();
            bdsGV.Filter = "MAKH IN (" + dsmakh + ")"; 
        }

        private string DsMaKhoa() {
            string ds = "";
            for (int i = 0; i < bdsKhoa.Count; i++)
                ds += "'"+ ((DataRowView)bdsKhoa[i])["MAKH"].ToString() + "',";

            return ds.Substring(0,ds.Length-1);
        }
        private void cmbTENKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMAKH.Text = cmbTENKH.SelectedValue.ToString();
            }
            catch (Exception ex) { }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.AddNew();
            txtMAGV.Focus();
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kiểm tra thông tin nhập trước khi ghi
            if (txtMAGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được rỗng", "", MessageBoxButtons.OK);
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ giảng viên không được rỗng", "", MessageBoxButtons.OK);
                return;
            }
            // ......
            try
            {
                bdsGV.EndEdit();
                bdsGV.ResetCurrentItem();
                this.GIAOVIENTableAdapter.Update(this.DS.GIAOVIEN);

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("'MAGV' is constrained to be unique"))
                    MessageBox.Show("Mã giảng viên không được trùng", "", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Lỗi ghi giảng viên . " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoso.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbCoso.SelectedValue.ToString();

            if (cmbCoso.SelectedIndex != Program.mChinhanh) // khác với cơ sở đăng nhập ban đầu
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
                this.GIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.GIAOVIEN_DANGKYTableAdapter.Fill(this.DS.GIAOVIEN_DANGKY);
                
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBode.Count > 0)
            {
                MessageBox.Show("Giảng viên muốn xóa đã soạn câu hỏi thi nên không được xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Giảng viên muốn xóa đã đăng ký thi nên không được xóa", "", MessageBoxButtons.OK);
                return;
            }
            if ( MessageBox.Show("Muốn xóa GV này ?", "", MessageBoxButtons.YesNo)==DialogResult.Yes)
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

        private void txtMAKH_EditValueChanged(object sender, EventArgs e)
        {
            int i;
            for (i=0; i < bdsKhoa.Count ; i++)
           
                if (((DataRowView)bdsKhoa[i])["MAKH"].ToString() == txtMAKH.Text)
                {
                    bdsKhoa.Position = i; return;
               }
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.CancelEdit();
        }
    }
}
