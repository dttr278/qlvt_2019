namespace QUANLYVATTU_PHANTAN
{
    partial class frmInDanhSachPhieuNVLapTrongNamTheoLoai
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hOTENLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QUANLYVATTU_PHANTAN.DS();
            this.cmbHoten = new System.Windows.Forms.ComboBox();
            this.hOTENNVTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.HOTENNVTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager();
            this.crptView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            hOTENLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(286, 28);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(44, 14);
            hOTENLabel.TabIndex = 0;
            hOTENLabel.Text = "HOTEN:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.cmbNam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbLoai);
            this.panel1.Controls.Add(this.txtManv);
            this.panel1.Controls.Add(hOTENLabel);
            this.panel1.Controls.Add(this.cmbHoten);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 69);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chi nhánh ";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(63, 22);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(207, 22);
            this.cmbChiNhanh.TabIndex = 10;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(764, 41);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 25);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(764, 8);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 25);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Items.AddRange(new object[] {
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2016"});
            this.cmbNam.Location = new System.Drawing.Point(689, 27);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(59, 22);
            this.cmbNam.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "NĂM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOẠI";
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "NHẬP",
            "XUẤT"});
            this.cmbLoai.Location = new System.Drawing.Point(583, 24);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(59, 22);
            this.cmbLoai.TabIndex = 4;
            // 
            // txtManv
            // 
            this.txtManv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.txtManv.Location = new System.Drawing.Point(490, 24);
            this.txtManv.Name = "txtManv";
            this.txtManv.ReadOnly = true;
            this.txtManv.Size = new System.Drawing.Size(45, 20);
            this.txtManv.TabIndex = 3;
            this.txtManv.TabStop = false;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "HOTENNV";
            this.bdsNV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbHoten
            // 
            this.cmbHoten.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HOTEN", true));
            this.cmbHoten.DataSource = this.bdsNV;
            this.cmbHoten.DisplayMember = "HOTEN";
            this.cmbHoten.FormattingEnabled = true;
            this.cmbHoten.Location = new System.Drawing.Point(339, 23);
            this.cmbHoten.Name = "cmbHoten";
            this.cmbHoten.Size = new System.Drawing.Size(145, 22);
            this.cmbHoten.TabIndex = 1;
            this.cmbHoten.ValueMember = "MANV";
            // 
            // hOTENNVTableAdapter
            // 
            this.hOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHATSINHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // crptView
            // 
            this.crptView.ActiveViewIndex = -1;
            this.crptView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptView.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptView.Location = new System.Drawing.Point(0, 69);
            this.crptView.Name = "crptView";
            this.crptView.Size = new System.Drawing.Size(887, 416);
            this.crptView.TabIndex = 1;
            // 
            // frmInDanhSachPhieuNVLapTrongNamTheoLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 485);
            this.Controls.Add(this.crptView);
            this.Controls.Add(this.panel1);
            this.Name = "frmInDanhSachPhieuNVLapTrongNamTheoLoai";
            this.Text = "frmInDanhSachPhieuNVLapTrongNamTheoLoai";
            this.Load += new System.EventHandler(this.frmInDanhSachPhieuNVLapTrongNamTheoLoai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.HOTENNVTableAdapter hOTENNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHoten;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txtManv;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}