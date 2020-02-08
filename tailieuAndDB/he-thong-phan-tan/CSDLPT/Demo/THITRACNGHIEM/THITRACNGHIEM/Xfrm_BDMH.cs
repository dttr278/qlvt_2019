using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
namespace THITRACNGHIEM
{
    public partial class Xfrm_BDMH : Form
    {
        public Xfrm_BDMH()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Xfrm_BDMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void btnPre_Click(object sender, EventArgs e)
        {
                   
       Xrpt_BDMH rpt = new Xrpt_BDMH(txtMALOP.Text , txtMAMH.Text, int.Parse (cmbLAN.Text));
       rpt.lblLop.Text = cmbTENLOP.Text;
        rpt.lblMonhoc.Text = cmbTENMH.Text;
        rpt.lblLan.Text = cmbLAN.Text;
        ReportPrintTool print= new ReportPrintTool(rpt);
        print.ShowPreviewDialog();

        }
    }
}
