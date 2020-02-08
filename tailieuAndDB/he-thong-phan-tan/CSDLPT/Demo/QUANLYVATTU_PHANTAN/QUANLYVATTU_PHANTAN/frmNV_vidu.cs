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
    public partial class frmNV_vidu : Form
    {
        public frmNV_vidu()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNV_vidu_Load(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            // TODO: This line of code loads data into the 'DS.PHATSINH' table. You can move, or remove it, as needed.
            this.pHATSINHTableAdapter.Fill(this.DS.PHATSINH);
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
         

        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
