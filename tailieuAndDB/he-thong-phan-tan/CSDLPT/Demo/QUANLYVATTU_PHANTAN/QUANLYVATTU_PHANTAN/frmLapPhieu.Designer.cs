namespace QUANLYVATTU_PHANTAN
{
    partial class frmLapPhieu
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
            System.Windows.Forms.Label pHIEULabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label lOAILabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label lYDOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label pHIEULabel1;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label trigiaLabel;
            System.Windows.Forms.Label dONGIALabel1;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiPhieu = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barCheckItem1 = new DevExpress.XtraBars.BarCheckItem();
            this.DS = new QUANLYVATTU_PHANTAN.DS();
            this.bdsPS = new System.Windows.Forms.BindingSource(this.components);
            this.PHATSINHTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.PHATSINHTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager();
            this.CT_PHATSINHTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.CT_PHATSINHTableAdapter();
            this.VATTUTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.VATTUTableAdapter();
            this.pHATSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelPS = new System.Windows.Forms.Panel();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.cmbHotenNV = new System.Windows.Forms.ComboBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.txtMakho = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenkho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.lYDOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTENKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lOAIComboBox = new System.Windows.Forms.ComboBox();
            this.NGAYDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtPhieuPS = new DevExpress.XtraEditors.TextEdit();
            this.CHONKHOTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.CHONKHOTableAdapter();
            this.HOTENNVTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.HOTENNVTableAdapter();
            this.bdsCTPS = new System.Windows.Forms.BindingSource(this.components);
            this.cT_PHATSINHGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dONGIATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.trigiaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sOLUONGSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.cmbTENVT = new System.Windows.Forms.ComboBox();
            this.bdsVATTU = new System.Windows.Forms.BindingSource(this.components);
            this.txtPhieuCTPS = new DevExpress.XtraEditors.TextEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.colPHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLYDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            pHIEULabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            lOAILabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            lYDOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            pHIEULabel1 = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            trigiaLabel = new System.Windows.Forms.Label();
            dONGIALabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panelPS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lYDOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieuPS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigiaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVATTU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieuCTPS.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHIEULabel
            // 
            pHIEULabel.AutoSize = true;
            pHIEULabel.Location = new System.Drawing.Point(32, 29);
            pHIEULabel.Name = "pHIEULabel";
            pHIEULabel.Size = new System.Drawing.Size(46, 15);
            pHIEULabel.TabIndex = 0;
            pHIEULabel.Text = "PHIEU:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(244, 30);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(43, 15);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // lOAILabel
            // 
            lOAILabel.AutoSize = true;
            lOAILabel.Location = new System.Drawing.Point(33, 65);
            lOAILabel.Name = "lOAILabel";
            lOAILabel.Size = new System.Drawing.Size(40, 15);
            lOAILabel.TabIndex = 4;
            lOAILabel.Text = "LOAI:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(449, 27);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(70, 15);
            hOTENKHLabel.TabIndex = 6;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // lYDOLabel
            // 
            lYDOLabel.AutoSize = true;
            lYDOLabel.Location = new System.Drawing.Point(36, 156);
            lYDOLabel.Name = "lYDOLabel";
            lYDOLabel.Size = new System.Drawing.Size(42, 15);
            lYDOLabel.TabIndex = 8;
            lYDOLabel.Text = "LYDO:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(244, 66);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(61, 15);
            tENKHOLabel.TabIndex = 10;
            tENKHOLabel.Text = "TENKHO:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(449, 66);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(59, 15);
            mAKHOLabel.TabIndex = 12;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(37, 111);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(62, 15);
            hOTENLabel.TabIndex = 14;
            hOTENLabel.Text = "Nhân viên";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(244, 117);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 15);
            mANVLabel.TabIndex = 16;
            mANVLabel.Text = "MANV:";
            // 
            // pHIEULabel1
            // 
            pHIEULabel1.AutoSize = true;
            pHIEULabel1.Location = new System.Drawing.Point(23, 35);
            pHIEULabel1.Name = "pHIEULabel1";
            pHIEULabel1.Size = new System.Drawing.Size(46, 15);
            pHIEULabel1.TabIndex = 0;
            pHIEULabel1.Text = "PHIEU:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(23, 80);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(49, 15);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "TENVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(23, 122);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(68, 15);
            sOLUONGLabel.TabIndex = 6;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // trigiaLabel
            // 
            trigiaLabel.AutoSize = true;
            trigiaLabel.Location = new System.Drawing.Point(23, 174);
            trigiaLabel.Name = "trigiaLabel";
            trigiaLabel.Size = new System.Drawing.Size(37, 15);
            trigiaLabel.TabIndex = 10;
            trigiaLabel.Text = "trigia:";
            // 
            // dONGIALabel1
            // 
            dONGIALabel1.AutoSize = true;
            dONGIALabel1.Location = new System.Drawing.Point(259, 120);
            dONGIALabel1.Name = "dONGIALabel1";
            dONGIALabel1.Size = new System.Drawing.Size(59, 15);
            dONGIALabel1.TabIndex = 12;
            dONGIALabel1.Text = "DONGIA:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThemPhieu,
            this.btnXoaPhieu,
            this.barCheckItem1,
            this.btnGhiPhieu,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThemPhieu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoaPhieu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhiPhieu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar1.Text = "Tools";
            // 
            // btnThemPhieu
            // 
            this.btnThemPhieu.Caption = "Thêm phiếu";
            this.btnThemPhieu.Id = 0;
            this.btnThemPhieu.Name = "btnThemPhieu";
            this.btnThemPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPhieu_ItemClick);
            // 
            // btnXoaPhieu
            // 
            this.btnXoaPhieu.Caption = "Xóa phiếu";
            this.btnXoaPhieu.Id = 1;
            this.btnXoaPhieu.Name = "btnXoaPhieu";
            this.btnXoaPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaPhieu_ItemClick);
            // 
            // btnGhiPhieu
            // 
            this.btnGhiPhieu.Caption = "Ghi Phiếu";
            this.btnGhiPhieu.Id = 3;
            this.btnGhiPhieu.Name = "btnGhiPhieu";
            this.btnGhiPhieu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiPhieu_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
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
            this.barDockControlTop.Size = new System.Drawing.Size(796, 49);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 502);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(796, 49);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 502);
            // 
            // barCheckItem1
            // 
            this.barCheckItem1.Caption = "barCheckItem1";
            this.barCheckItem1.Id = 2;
            this.barCheckItem1.Name = "barCheckItem1";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.EnforceConstraints = false;
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPS
            // 
            this.bdsPS.DataMember = "PHATSINH";
            this.bdsPS.DataSource = this.DS;
            // 
            // PHATSINHTableAdapter
            // 
            this.PHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = this.CT_PHATSINHTableAdapter;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHATSINHTableAdapter = this.PHATSINHTableAdapter;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = this.VATTUTableAdapter;
            // 
            // CT_PHATSINHTableAdapter
            // 
            this.CT_PHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // VATTUTableAdapter
            // 
            this.VATTUTableAdapter.ClearBeforeFill = true;
            // 
            // pHATSINHGridControl
            // 
            this.pHATSINHGridControl.DataSource = this.bdsPS;
            this.pHATSINHGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHATSINHGridControl.Location = new System.Drawing.Point(0, 49);
            this.pHATSINHGridControl.MainView = this.gridView1;
            this.pHATSINHGridControl.MenuManager = this.barManager1;
            this.pHATSINHGridControl.Name = "pHATSINHGridControl";
            this.pHATSINHGridControl.Size = new System.Drawing.Size(796, 111);
            this.pHATSINHGridControl.TabIndex = 5;
            this.pHATSINHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPHIEU,
            this.colNGAY,
            this.colLOAI,
            this.colHOTENKH,
            this.colLYDO,
            this.colMAKHO,
            this.colMANV});
            this.gridView1.GridControl = this.pHATSINHGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panelPS
            // 
            this.panelPS.Controls.Add(this.txtMANV);
            this.panelPS.Controls.Add(mANVLabel);
            this.panelPS.Controls.Add(hOTENLabel);
            this.panelPS.Controls.Add(this.cmbHotenNV);
            this.panelPS.Controls.Add(mAKHOLabel);
            this.panelPS.Controls.Add(this.txtMakho);
            this.panelPS.Controls.Add(tENKHOLabel);
            this.panelPS.Controls.Add(this.cmbTenkho);
            this.panelPS.Controls.Add(lYDOLabel);
            this.panelPS.Controls.Add(this.lYDOTextEdit);
            this.panelPS.Controls.Add(hOTENKHLabel);
            this.panelPS.Controls.Add(this.hOTENKHTextEdit);
            this.panelPS.Controls.Add(lOAILabel);
            this.panelPS.Controls.Add(this.lOAIComboBox);
            this.panelPS.Controls.Add(nGAYLabel);
            this.panelPS.Controls.Add(this.NGAYDateEdit);
            this.panelPS.Controls.Add(pHIEULabel);
            this.panelPS.Controls.Add(this.txtPhieuPS);
            this.panelPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPS.Location = new System.Drawing.Point(0, 160);
            this.panelPS.Name = "panelPS";
            this.panelPS.Size = new System.Drawing.Size(796, 210);
            this.panelPS.TabIndex = 6;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPS, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(308, 115);
            this.txtMANV.MenuManager = this.barManager1;
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 18;
            this.txtMANV.EditValueChanged += new System.EventHandler(this.txtMANV_EditValueChanged);
            // 
            // cmbHotenNV
            // 
            this.cmbHotenNV.DataSource = this.bdsNV;
            this.cmbHotenNV.DisplayMember = "HOTEN";
            this.cmbHotenNV.FormattingEnabled = true;
            this.cmbHotenNV.Location = new System.Drawing.Point(109, 108);
            this.cmbHotenNV.Name = "cmbHotenNV";
            this.cmbHotenNV.Size = new System.Drawing.Size(121, 23);
            this.cmbHotenNV.TabIndex = 15;
            this.cmbHotenNV.ValueMember = "MANV";
            this.cmbHotenNV.SelectedIndexChanged += new System.EventHandler(this.cmbHotenNV_SelectedIndexChanged);
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "HOTENNV";
            this.bdsNV.DataSource = this.DS;
            // 
            // txtMakho
            // 
            this.txtMakho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPS, "MAKHO", true));
            this.txtMakho.Location = new System.Drawing.Point(524, 63);
            this.txtMakho.MenuManager = this.barManager1;
            this.txtMakho.Name = "txtMakho";
            this.txtMakho.Size = new System.Drawing.Size(100, 20);
            this.txtMakho.TabIndex = 13;
            // 
            // cmbTenkho
            // 
            this.cmbTenkho.DataSource = this.bdsKho;
            this.cmbTenkho.DisplayMember = "TENKHO";
            this.cmbTenkho.FormattingEnabled = true;
            this.cmbTenkho.Location = new System.Drawing.Point(308, 63);
            this.cmbTenkho.Name = "cmbTenkho";
            this.cmbTenkho.Size = new System.Drawing.Size(121, 23);
            this.cmbTenkho.TabIndex = 11;
            this.cmbTenkho.ValueMember = "MAKHO";
            this.cmbTenkho.SelectedIndexChanged += new System.EventHandler(this.cmbTenkho_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "CHONKHO";
            this.bdsKho.DataSource = this.DS;
            // 
            // lYDOTextEdit
            // 
            this.lYDOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPS, "LYDO", true));
            this.lYDOTextEdit.Location = new System.Drawing.Point(109, 153);
            this.lYDOTextEdit.MenuManager = this.barManager1;
            this.lYDOTextEdit.Name = "lYDOTextEdit";
            this.lYDOTextEdit.Size = new System.Drawing.Size(574, 20);
            this.lYDOTextEdit.TabIndex = 9;
            // 
            // hOTENKHTextEdit
            // 
            this.hOTENKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPS, "HOTENKH", true));
            this.hOTENKHTextEdit.Location = new System.Drawing.Point(525, 24);
            this.hOTENKHTextEdit.MenuManager = this.barManager1;
            this.hOTENKHTextEdit.Name = "hOTENKHTextEdit";
            this.hOTENKHTextEdit.Size = new System.Drawing.Size(168, 20);
            this.hOTENKHTextEdit.TabIndex = 7;
            // 
            // lOAIComboBox
            // 
            this.lOAIComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPS, "LOAI", true));
            this.lOAIComboBox.FormattingEnabled = true;
            this.lOAIComboBox.Items.AddRange(new object[] {
            "N",
            "X"});
            this.lOAIComboBox.Location = new System.Drawing.Point(109, 62);
            this.lOAIComboBox.Name = "lOAIComboBox";
            this.lOAIComboBox.Size = new System.Drawing.Size(121, 23);
            this.lOAIComboBox.TabIndex = 5;
            // 
            // NGAYDateEdit
            // 
            this.NGAYDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPS, "NGAY", true));
            this.NGAYDateEdit.EditValue = null;
            this.NGAYDateEdit.Location = new System.Drawing.Point(308, 27);
            this.NGAYDateEdit.MenuManager = this.barManager1;
            this.NGAYDateEdit.Name = "NGAYDateEdit";
            this.NGAYDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NGAYDateEdit.Size = new System.Drawing.Size(100, 20);
            this.NGAYDateEdit.TabIndex = 3;
            // 
            // txtPhieuPS
            // 
            this.txtPhieuPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPS, "PHIEU", true));
            this.txtPhieuPS.Location = new System.Drawing.Point(109, 26);
            this.txtPhieuPS.MenuManager = this.barManager1;
            this.txtPhieuPS.Name = "txtPhieuPS";
            this.txtPhieuPS.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhieuPS.Size = new System.Drawing.Size(121, 20);
            this.txtPhieuPS.TabIndex = 1;
            // 
            // CHONKHOTableAdapter
            // 
            this.CHONKHOTableAdapter.ClearBeforeFill = true;
            // 
            // HOTENNVTableAdapter
            // 
            this.HOTENNVTableAdapter.ClearBeforeFill = true;
            // 
            // bdsCTPS
            // 
            this.bdsCTPS.DataMember = "FK_CT_PHATSINH_PHATSINH";
            this.bdsCTPS.DataSource = this.bdsPS;
            // 
            // cT_PHATSINHGridControl
            // 
            this.cT_PHATSINHGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.cT_PHATSINHGridControl.DataSource = this.bdsCTPS;
            this.cT_PHATSINHGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.cT_PHATSINHGridControl.Location = new System.Drawing.Point(0, 370);
            this.cT_PHATSINHGridControl.MainView = this.gridView2;
            this.cT_PHATSINHGridControl.MenuManager = this.barManager1;
            this.cT_PHATSINHGridControl.Name = "cT_PHATSINHGridControl";
            this.cT_PHATSINHGridControl.Size = new System.Drawing.Size(305, 181);
            this.cT_PHATSINHGridControl.TabIndex = 6;
            this.cT_PHATSINHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.cT_PHATSINHGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(dONGIALabel1);
            this.panel1.Controls.Add(this.dONGIATextEdit);
            this.panel1.Controls.Add(this.trigiaTextEdit);
            this.panel1.Controls.Add(trigiaLabel);
            this.panel1.Controls.Add(sOLUONGLabel);
            this.panel1.Controls.Add(this.sOLUONGSpinEdit);
            this.panel1.Controls.Add(this.txtMAVT);
            this.panel1.Controls.Add(tENVTLabel);
            this.panel1.Controls.Add(this.cmbTENVT);
            this.panel1.Controls.Add(pHIEULabel1);
            this.panel1.Controls.Add(this.txtPhieuCTPS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(305, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 181);
            this.panel1.TabIndex = 7;
            // 
            // dONGIATextEdit
            // 
            this.dONGIATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPS, "DONGIA", true));
            this.dONGIATextEdit.Location = new System.Drawing.Point(332, 118);
            this.dONGIATextEdit.MenuManager = this.barManager1;
            this.dONGIATextEdit.Name = "dONGIATextEdit";
            this.dONGIATextEdit.Properties.Mask.EditMask = "n0";
            this.dONGIATextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.dONGIATextEdit.Size = new System.Drawing.Size(100, 20);
            this.dONGIATextEdit.TabIndex = 13;
            // 
            // trigiaTextEdit
            // 
            this.trigiaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPS, "trigia", true));
            this.trigiaTextEdit.Location = new System.Drawing.Point(104, 169);
            this.trigiaTextEdit.MenuManager = this.barManager1;
            this.trigiaTextEdit.Name = "trigiaTextEdit";
            this.trigiaTextEdit.Size = new System.Drawing.Size(100, 20);
            this.trigiaTextEdit.TabIndex = 12;
            // 
            // sOLUONGSpinEdit
            // 
            this.sOLUONGSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPS, "SOLUONG", true));
            this.sOLUONGSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sOLUONGSpinEdit.Location = new System.Drawing.Point(104, 119);
            this.sOLUONGSpinEdit.MenuManager = this.barManager1;
            this.sOLUONGSpinEdit.Name = "sOLUONGSpinEdit";
            this.sOLUONGSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sOLUONGSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sOLUONGSpinEdit.TabIndex = 7;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPS, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(332, 75);
            this.txtMAVT.MenuManager = this.barManager1;
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(100, 20);
            this.txtMAVT.TabIndex = 5;
            // 
            // cmbTENVT
            // 
            this.cmbTENVT.DataSource = this.bdsVATTU;
            this.cmbTENVT.DisplayMember = "TENVT";
            this.cmbTENVT.Font = new System.Drawing.Font("VNI-Times", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTENVT.FormattingEnabled = true;
            this.cmbTENVT.Location = new System.Drawing.Point(104, 77);
            this.cmbTENVT.Name = "cmbTENVT";
            this.cmbTENVT.Size = new System.Drawing.Size(210, 25);
            this.cmbTENVT.TabIndex = 3;
            this.cmbTENVT.ValueMember = "MAVT";
            this.cmbTENVT.SelectedIndexChanged += new System.EventHandler(this.cmbTENVT_SelectedIndexChanged);
            // 
            // bdsVATTU
            // 
            this.bdsVATTU.DataMember = "VATTU";
            this.bdsVATTU.DataSource = this.DS;
            // 
            // txtPhieuCTPS
            // 
            this.txtPhieuCTPS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPS, "PHIEU", true));
            this.txtPhieuCTPS.Location = new System.Drawing.Point(104, 32);
            this.txtPhieuCTPS.MenuManager = this.barManager1;
            this.txtPhieuCTPS.Name = "txtPhieuCTPS";
            this.txtPhieuCTPS.Size = new System.Drawing.Size(100, 20);
            this.txtPhieuCTPS.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVT,
            this.btnGhiVT,
            this.btnXoaVT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 92);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(193, 22);
            this.btnThemVT.Text = "Thêm vật tư vào phiếu";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(193, 22);
            this.btnGhiVT.Text = "Ghi vật tư vào phiếu";
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 4;
            this.btnThoat.Name = "btnThoat";
            // 
            // colPHIEU
            // 
            this.colPHIEU.FieldName = "PHIEU";
            this.colPHIEU.Name = "colPHIEU";
            this.colPHIEU.Visible = true;
            this.colPHIEU.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colLOAI
            // 
            this.colLOAI.FieldName = "LOAI";
            this.colLOAI.Name = "colLOAI";
            this.colLOAI.Visible = true;
            this.colLOAI.VisibleIndex = 2;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 3;
            // 
            // colLYDO
            // 
            this.colLYDO.FieldName = "LYDO";
            this.colLYDO.Name = "colLYDO";
            this.colLYDO.Visible = true;
            this.colLYDO.VisibleIndex = 4;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 5;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 6;
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(193, 22);
            this.btnXoaVT.Text = "Xóa vật tư khỏi phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chi nhánh ";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(387, 19);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(245, 23);
            this.cmbChiNhanh.TabIndex = 12;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // frmLapPhieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 574);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbChiNhanh);
            this.Controls.Add(this.cT_PHATSINHGridControl);
            this.Controls.Add(this.panelPS);
            this.Controls.Add(this.pHATSINHGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLapPhieu";
            this.Text = "frmLapPhieu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLapPhieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHATSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panelPS.ResumeLayout(false);
            this.panelPS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMakho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lYDOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NGAYDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieuPS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cT_PHATSINHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trigiaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVATTU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhieuCTPS.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThemPhieu;
        private DevExpress.XtraBars.BarButtonItem btnXoaPhieu;
        private DevExpress.XtraBars.BarButtonItem btnGhiPhieu;
        private System.Windows.Forms.BindingSource bdsPS;
        private DS DS;
        private DevExpress.XtraBars.BarCheckItem barCheckItem1;
        private DSTableAdapters.PHATSINHTableAdapter PHATSINHTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl pHATSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panelPS;
        private DevExpress.XtraEditors.TextEdit lYDOTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTENKHTextEdit;
        private System.Windows.Forms.ComboBox lOAIComboBox;
        private DevExpress.XtraEditors.DateEdit NGAYDateEdit;
        private DevExpress.XtraEditors.TextEdit txtPhieuPS;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.CHONKHOTableAdapter CHONKHOTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMakho;
        private System.Windows.Forms.ComboBox cmbTenkho;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.HOTENNVTableAdapter HOTENNVTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private System.Windows.Forms.ComboBox cmbHotenNV;
        private DSTableAdapters.CT_PHATSINHTableAdapter CT_PHATSINHTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPS;
        private DevExpress.XtraGrid.GridControl cT_PHATSINHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtPhieuCTPS;
        private DSTableAdapters.VATTUTableAdapter VATTUTableAdapter;
        private System.Windows.Forms.BindingSource bdsVATTU;
        private DevExpress.XtraEditors.TextEdit dONGIATextEdit;
        private DevExpress.XtraEditors.TextEdit trigiaTextEdit;
        private DevExpress.XtraEditors.SpinEdit sOLUONGSpinEdit;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private System.Windows.Forms.ComboBox cmbTENVT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private DevExpress.XtraGrid.Columns.GridColumn colPHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAI;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colLYDO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
    }
}