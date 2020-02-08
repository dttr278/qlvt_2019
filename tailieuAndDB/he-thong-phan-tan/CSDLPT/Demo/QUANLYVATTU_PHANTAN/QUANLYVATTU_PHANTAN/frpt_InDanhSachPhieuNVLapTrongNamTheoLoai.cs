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
    public partial class frpt_InDanhSachPhieuNVLapTrongNamTheoLoai : Form
    {
        public frpt_InDanhSachPhieuNVLapTrongNamTheoLoai()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            rpt_BaoCaoCacPhieuTrongKhoangThoiGian obj;
            obj = new rpt_BaoCaoCacPhieuTrongKhoangThoiGian();

            string strLenh;
            strLenh = "EXEC SP_PHIEUNHAPXUAT_TRONGKHOANGTHOIGIAN '" + dtpTungay.Value.ToString() + "', '" +
                 dtpDenngay.Value.ToString() + "', '"+ cmbLoai.Text.Substring(0, 1) + "' " ;
            DataTable MyTable;
            MyTable = Program.ExecSqlDataTable(strLenh, Program.connstr);

            obj.SetDataSource(MyTable);
            obj.SetParameterValue("TENCN", cmbChiNhanh.Text);
            obj.SetParameterValue("LP", cmbLoai.Text);
            obj.SetParameterValue("TUNG", dtpTungay.Value.ToString());
            obj.SetParameterValue("DENNG", dtpDenngay.Value.ToString());
            crptView.ReportSource = obj;

        }

        private void frpt_InDanhSachPhieuNVLapTrongNamTheoLoai_Load(object sender, EventArgs e)
        {
            
            cmbChiNhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY") cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
            else cmbChiNhanh.Enabled = false;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
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
            else
            {
               
                
            }   
        }

       
    }
}
