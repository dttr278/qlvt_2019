namespace THITRACNGHIEM
{
    partial class frmMain
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGV = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grbDangNhap = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRACNGHIEMDataSet = new THITRACNGHIEM.TRACNGHIEMDataSet();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.v_DS_PHANMANHTableAdapter = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.MAGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnBDMH = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.grbDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnGV,
            this.btnBDMH});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1026, 144);
            // 
            // btnGV
            // 
            this.btnGV.Caption = "GIẢNG VIÊN";
            this.btnGV.Id = 1;
            this.btnGV.Name = "btnGV";
            this.btnGV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGV_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "DANH MỤC";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGV);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // grbDangNhap
            // 
            this.grbDangNhap.Controls.Add(this.btnThoat);
            this.grbDangNhap.Controls.Add(this.btnDangNhap);
            this.grbDangNhap.Controls.Add(this.cmbCoso);
            this.grbDangNhap.Controls.Add(this.txtPass);
            this.grbDangNhap.Controls.Add(this.txtLogin);
            this.grbDangNhap.Controls.Add(this.label3);
            this.grbDangNhap.Controls.Add(this.label2);
            this.grbDangNhap.Controls.Add(this.label1);
            this.grbDangNhap.Location = new System.Drawing.Point(53, 169);
            this.grbDangNhap.Name = "grbDangNhap";
            this.grbDangNhap.Size = new System.Drawing.Size(527, 280);
            this.grbDangNhap.TabIndex = 1;
            this.grbDangNhap.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(313, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 37);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(150, 211);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(127, 37);
            this.btnDangNhap.TabIndex = 7;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click_1);
            // 
            // cmbCoso
            // 
            this.cmbCoso.DataSource = this.v_DS_PHANMANHBindingSource;
            this.cmbCoso.DisplayMember = "TENCN";
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(150, 46);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(282, 27);
            this.cmbCoso.TabIndex = 6;
            this.cmbCoso.ValueMember = "TENSERVER";
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(150, 155);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(282, 26);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "123";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(150, 99);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(282, 26);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.Text = "PVH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cơ sở";
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // MAGV
            // 
            this.MAGV.Name = "MAGV";
            this.MAGV.Size = new System.Drawing.Size(41, 17);
            this.MAGV.Text = "MAGV";
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(47, 17);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(45, 17);
            this.NHOM.Text = "NHOM";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MAGV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "BÁO CÁO";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBDMH);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // btnBDMH
            // 
            this.btnBDMH.Caption = "BẢNG ĐIỂM MÔN HỌC";
            this.btnBDMH.Id = 3;
            this.btnBDMH.Name = "btnBDMH";
            this.btnBDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBDMH_ItemClick);
            // 
            // frmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 501);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbDangNhap);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.grbDangNhap.ResumeLayout(false);
            this.grbDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.GroupBox grbDangNhap;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnGV;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel MAGV;
        private System.Windows.Forms.ToolStripStatusLabel HOTEN;
        private System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarButtonItem btnBDMH;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}

