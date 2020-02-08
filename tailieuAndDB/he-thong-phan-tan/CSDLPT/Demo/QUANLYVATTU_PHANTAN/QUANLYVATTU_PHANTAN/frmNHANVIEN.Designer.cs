namespace QUANLYVATTU_PHANTAN
{
    partial class frmNHANVIEN
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label lUONGLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label hINHLabel;
            System.Windows.Forms.Label gHICHULabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnInDSNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.DS = new QUANLYVATTU_PHANTAN.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.NHANVIENTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager();
            this.gcNhanvien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGHICHU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLUONG = new System.Windows.Forms.TextBox();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.txtGHICHU = new DevExpress.XtraEditors.TextEdit();
            this.txtHINH = new DevExpress.XtraEditors.TextEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.dtpNGAYSINH = new DevExpress.XtraEditors.DateEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbPHAI = new System.Windows.Forms.ComboBox();
            this.txtTEN = new System.Windows.Forms.TextBox();
            this.txtHO = new System.Windows.Forms.TextBox();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.bdsPS = new System.Windows.Forms.BindingSource(this.components);
            this.PHATSINHTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.PHATSINHTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            lUONGLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            hINHLabel = new System.Windows.Forms.Label();
            gHICHULabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGHICHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPS)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(194, 22);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(54, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "Mã NV";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(444, 22);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(194, 76);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(34, 17);
            pHAILabel.TabIndex = 6;
            pHAILabel.Text = "Phái";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(445, 77);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(88, 17);
            nGAYSINHLabel.TabIndex = 9;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // lUONGLabel
            // 
            lUONGLabel.AutoSize = true;
            lUONGLabel.Location = new System.Drawing.Point(194, 129);
            lUONGLabel.Name = "lUONGLabel";
            lUONGLabel.Size = new System.Drawing.Size(63, 17);
            lUONGLabel.TabIndex = 11;
            lUONGLabel.Text = "LUONG:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(194, 166);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(64, 17);
            dIACHILabel.TabIndex = 13;
            dIACHILabel.Text = "DIACHI:";
            // 
            // hINHLabel
            // 
            hINHLabel.AutoSize = true;
            hINHLabel.Location = new System.Drawing.Point(194, 214);
            hINHLabel.Name = "hINHLabel";
            hINHLabel.Size = new System.Drawing.Size(49, 17);
            hINHLabel.TabIndex = 15;
            hINHLabel.Text = "HINH:";
            // 
            // gHICHULabel
            // 
            gHICHULabel.AutoSize = true;
            gHICHULabel.Location = new System.Drawing.Point(194, 262);
            gHICHULabel.Name = "gHICHULabel";
            gHICHULabel.Size = new System.Drawing.Size(69, 17);
            gHICHULabel.TabIndex = 17;
            gHICHULabel.Text = "GHICHU:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnUndo,
            this.btnReload,
            this.btnInDSNV,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnInDSNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Hiệu chỉnh";
            this.btnSua.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Text_Edit_icon_24;
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Save_icon_24;
            this.btnGhi.Id = 2;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.Id = 3;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Undo_icon_24;
            this.btnUndo.Id = 4;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Button_Refresh_icon_24;
            this.btnReload.Id = 5;
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnInDSNV
            // 
            this.btnInDSNV.Caption = "In danh sách nhân viên";
            this.btnInDSNV.Id = 6;
            this.btnInDSNV.Name = "btnInDSNV";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Exit_24_icon;
            this.btnThoat.Id = 7;
            this.btnThoat.Name = "btnThoat";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(796, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Size = new System.Drawing.Size(796, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(796, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 55);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(151, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(245, 24);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NHANVIEN";
            this.bdsNV.DataSource = this.DS;
            // 
            // NHANVIENTableAdapter
            // 
            this.NHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.NHANVIENTableAdapter;
            this.tableAdapterManager.PHATSINHTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // gcNhanvien
            // 
            this.gcNhanvien.DataSource = this.bdsNV;
            this.gcNhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNhanvien.Location = new System.Drawing.Point(0, 87);
            this.gcNhanvien.MainView = this.gridView1;
            this.gcNhanvien.MenuManager = this.barManager1;
            this.gcNhanvien.Name = "gcNhanvien";
            this.gcNhanvien.Size = new System.Drawing.Size(796, 160);
            this.gcNhanvien.TabIndex = 6;
            this.gcNhanvien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colPHAI,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colHINH,
            this.colGHICHU});
            this.gridView1.GridControl = this.gcNhanvien;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // colHINH
            // 
            this.colHINH.FieldName = "HINH";
            this.colHINH.Name = "colHINH";
            this.colHINH.Visible = true;
            this.colHINH.VisibleIndex = 8;
            // 
            // colGHICHU
            // 
            this.colGHICHU.FieldName = "GHICHU";
            this.colGHICHU.Name = "colGHICHU";
            this.colGHICHU.Visible = true;
            this.colGHICHU.VisibleIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLUONG);
            this.groupBox1.Controls.Add(this.txtMACN);
            this.groupBox1.Controls.Add(gHICHULabel);
            this.groupBox1.Controls.Add(this.txtGHICHU);
            this.groupBox1.Controls.Add(hINHLabel);
            this.groupBox1.Controls.Add(this.txtHINH);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(this.txtDIACHI);
            this.groupBox1.Controls.Add(lUONGLabel);
            this.groupBox1.Controls.Add(nGAYSINHLabel);
            this.groupBox1.Controls.Add(this.dtpNGAYSINH);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(pHAILabel);
            this.groupBox1.Controls.Add(this.cmbPHAI);
            this.groupBox1.Controls.Add(this.txtTEN);
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.txtHO);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 304);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtLUONG
            // 
            this.txtLUONG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "LUONG", true));
            this.txtLUONG.Location = new System.Drawing.Point(296, 125);
            this.txtLUONG.Name = "txtLUONG";
            this.txtLUONG.Size = new System.Drawing.Size(155, 24);
            this.txtLUONG.TabIndex = 21;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(547, 122);
            this.txtMACN.MenuManager = this.barManager1;
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(100, 20);
            this.txtMACN.TabIndex = 20;
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "GHICHU", true));
            this.txtGHICHU.Location = new System.Drawing.Point(296, 259);
            this.txtGHICHU.MenuManager = this.barManager1;
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(476, 20);
            this.txtGHICHU.TabIndex = 18;
            // 
            // txtHINH
            // 
            this.txtHINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "HINH", true));
            this.txtHINH.Location = new System.Drawing.Point(296, 214);
            this.txtHINH.MenuManager = this.barManager1;
            this.txtHINH.Name = "txtHINH";
            this.txtHINH.Size = new System.Drawing.Size(476, 20);
            this.txtHINH.TabIndex = 16;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(296, 169);
            this.txtDIACHI.MenuManager = this.barManager1;
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(476, 20);
            this.txtDIACHI.TabIndex = 14;
            // 
            // dtpNGAYSINH
            // 
            this.dtpNGAYSINH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNV, "NGAYSINH", true));
            this.dtpNGAYSINH.EditValue = null;
            this.dtpNGAYSINH.Location = new System.Drawing.Point(559, 74);
            this.dtpNGAYSINH.MenuManager = this.barManager1;
            this.dtpNGAYSINH.Name = "dtpNGAYSINH";
            this.dtpNGAYSINH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNGAYSINH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNGAYSINH.Size = new System.Drawing.Size(100, 20);
            this.dtpNGAYSINH.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 128);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // cmbPHAI
            // 
            this.cmbPHAI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "PHAI", true));
            this.cmbPHAI.FormattingEnabled = true;
            this.cmbPHAI.Items.AddRange(new object[] {
            "NAM",
            "NỮ"});
            this.cmbPHAI.Location = new System.Drawing.Point(296, 73);
            this.cmbPHAI.Name = "cmbPHAI";
            this.cmbPHAI.Size = new System.Drawing.Size(100, 24);
            this.cmbPHAI.TabIndex = 7;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(713, 22);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(100, 24);
            this.txtTEN.TabIndex = 5;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(499, 22);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(201, 24);
            this.txtHO.TabIndex = 3;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(296, 22);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 24);
            this.txtMANV.TabIndex = 1;
            // 
            // bdsPS
            // 
            this.bdsPS.DataMember = "FK_PHATSINH_NHANVIEN";
            this.bdsPS.DataSource = this.bdsNV;
            // 
            // PHATSINHTableAdapter
            // 
            this.PHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // frmNHANVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(796, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gcNhanvien);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNHANVIEN";
            this.Text = "frmNHANVIEN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNHANVIEN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGHICHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNGAYSINH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnInDSNV;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private System.Windows.Forms.Panel panel1;
        private DSTableAdapters.NHANVIENTableAdapter NHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNhanvien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colHINH;
        private DevExpress.XtraGrid.Columns.GridColumn colGHICHU;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtMACN;
        private DevExpress.XtraEditors.TextEdit txtGHICHU;
        private DevExpress.XtraEditors.TextEdit txtHINH;
        private DevExpress.XtraEditors.TextEdit txtDIACHI;
        private DevExpress.XtraEditors.DateEdit dtpNGAYSINH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbPHAI;
        private System.Windows.Forms.TextBox txtTEN;
        private System.Windows.Forms.TextBox txtHO;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox txtLUONG;
        private System.Windows.Forms.BindingSource bdsPS;
        private DSTableAdapters.PHATSINHTableAdapter PHATSINHTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}