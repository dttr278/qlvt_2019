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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            btnDangNhap.PerformClick();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private  void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }
        public  void HienThiMenu() {
            MANV.Text = "Mã NV : " + Program.username;
            HOTEN.Text = "Họ tên nhân viên : " + Program.mHoten;
            NHOM.Text = "Nhóm : " + Program.mGroup;
            // Phân quyền
        }

        private void btnNhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNHANVIEN));
            if (frm != null) frm.Activate();
            else
            {
                frmNHANVIEN f = new frmNHANVIEN();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnInPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmInDanhSachPhieuNVLapTrongNamTheoLoai));
            if (frm != null) frm.Activate();
            else
            {
                frmInDanhSachPhieuNVLapTrongNamTheoLoai f = new frmInDanhSachPhieuNVLapTrongNamTheoLoai();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLapPhieuNX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLapPhieu));
            if (frm != null) frm.Activate();
            else
            {
                frmLapPhieu f = new frmLapPhieu();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCacPhieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frpt_InDanhSachPhieuNVLapTrongNamTheoLoai));
            if (frm != null) frm.Activate();
            else
            {
                frpt_InDanhSachPhieuNVLapTrongNamTheoLoai f = new frpt_InDanhSachPhieuNVLapTrongNamTheoLoai();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
