namespace QUANLYVATTU_PHANTAN
{
    partial class frpt_InDanhSachPhieuNVLapTrongNamTheoLoai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.dtpTungay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Controls.Add(this.cmbLoai);
            this.panel1.Controls.Add(this.dtpDenngay);
            this.panel1.Controls.Add(this.dtpTungay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 102);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Chi nhánh ";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(144, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(245, 22);
            this.cmbChiNhanh.TabIndex = 8;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(637, 56);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(546, 56);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 6;
            this.btnPrev.Text = "Preview";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "NHẬP",
            "XUẤT"});
            this.cmbLoai.Location = new System.Drawing.Point(460, 56);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(80, 22);
            this.cmbLoai.TabIndex = 5;
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDenngay.Location = new System.Drawing.Point(272, 61);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(78, 20);
            this.dtpDenngay.TabIndex = 4;
            // 
            // dtpTungay
            // 
            this.dtpTungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTungay.Location = new System.Drawing.Point(83, 63);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(78, 20);
            this.dtpTungay.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOẠI PHIẾU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "ĐẾN NGÀY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "TỪ NGÀY";
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 102);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(803, 316);
            this.crptView.TabIndex = 1;
            // 
            // frpt_InDanhSachPhieuNVLapTrongNamTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 418);
            this.Controls.Add(this.crptView);
            this.Controls.Add(this.panel1);
            this.Name = "frpt_InDanhSachPhieuNVLapTrongNamTheoLoai";
            this.Text = "frpt_InDanhSachPhieuNVLapTrongNamTheoLoai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frpt_InDanhSachPhieuNVLapTrongNamTheoLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.DateTimePicker dtpTungay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}