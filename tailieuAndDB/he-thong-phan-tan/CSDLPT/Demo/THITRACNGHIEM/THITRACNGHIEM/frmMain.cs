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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            cmbCoso.SelectedIndex = 1;
            cmbCoso.SelectedIndex = 0;
        }

       

        private void cmbCoso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cmbCoso.SelectedValue.ToString();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGV));
            if (frm != null) frm.Activate();
            else
            {
                frmGV f = new frmGV();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            Program.mlogin = txtLogin.Text;
            Program.password = txtPass.Text;
            int kq = Program.KetNoi();
            if (kq == 0) return;

            Program.mChinhanh = cmbCoso.SelectedIndex;
            Program.bds_dspm = v_DS_PHANMANHBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            String strlenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            Program.username = Program.myReader.GetString(0);
            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            MAGV.Text = "Mã GV : " + Program.username;
            HOTEN.Text = "Họ tên :" + Program.mHoten;
            NHOM.Text = "Quyền : " + Program.mGroup;
            // Bật tắt menu theo phân quyền
            grbDangNhap.Visible = false;
         }

        private void btnBDMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(Xfrm_BDMH));
            if (frm != null) frm.Activate();
            else
            {
                Xfrm_BDMH f = new Xfrm_BDMH();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
