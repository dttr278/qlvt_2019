using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace THITRACNGHIEM
{
    public partial class Xrpt_BDMH : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_BDMH(string malop, string mamh, int lan)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            // kiểm tra lại trên phân mảnh 2
            this.sP_BDMHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_BDMHTableAdapter.Fill(ds1.SP_BDMH, malop, mamh, lan);

        }

    }
}
