using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYVATTU_PHANTAN
{
    public partial class frmInDanhSachPhieuNVLapTrongNamTheoLoai : Form
    {
        public frmInDanhSachPhieuNVLapTrongNamTheoLoai()
        {
            InitializeComponent();
        }

        private void frmInDanhSachPhieuNVLapTrongNamTheoLoai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HOTENNV' table. You can move, or remove it, as needed.
            this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);
            cmbHoten.SelectedIndex = cmbLoai.SelectedIndex = cmbNam.SelectedIndex = 0;

            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TenCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY") cmbChiNhanh.Enabled = true;
            else cmbChiNhanh.Enabled = false;

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
               BaoCao.rptPhieuNVLapTrongNamTheoLoai     obj ; 
            obj = new BaoCao.rptPhieuNVLapTrongNamTheoLoai();

        string strLenh ;
        strLenh = "EXEC sp_PhieuNvLapTrongNamTheoLoai " + txtManv.Text.Trim() + ", '" +
             cmbLoai.Text.Substring(0, 1) + "' ," + cmbNam.Text;
        DataTable MyTable ;
        MyTable = Program.ExecSqlDataTable(strLenh, Program.connstr);
       
        obj.SetDataSource(MyTable);
        obj.SetParameterValue("HOTEN", cmbHoten.Text);
        obj.SetParameterValue("LOAI", cmbLoai.Text);
        obj.SetParameterValue("NAM", cmbNam.Text);
        crptView.ReportSource = obj;

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
                this.hOTENNVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hOTENNVTableAdapter.Fill(this.dS.HOTENNV);
            }   
        }
    }
}
