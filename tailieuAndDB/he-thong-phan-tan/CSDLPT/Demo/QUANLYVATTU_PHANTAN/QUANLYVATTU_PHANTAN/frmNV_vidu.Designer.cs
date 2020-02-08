namespace QUANLYVATTU_PHANTAN
{
    partial class frmNV_vidu
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DS = new QUANLYVATTU_PHANTAN.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
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
            this.mANVTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.bdsPS = new System.Windows.Forms.BindingSource(this.components);
            this.pHATSINHTableAdapter = new QUANLYVATTU_PHANTAN.DSTableAdapters.PHATSINHTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPS)).BeginInit();
            this.SuspendLayout();
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
            this.btnThem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 1;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::QUANLYVATTU_PHANTAN.Properties.Resources.Teacher_male_icon_24;
            this.btnThem.Id = 0;
            this.btnThem.Name = "btnThem";
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
            this.barDockControlTop.Size = new System.Drawing.Size(800, 61);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 493);
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 432);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 61);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 432);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 4;
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(124, 15);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(400, 25);
            this.cmbChinhanh.TabIndex = 0;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh";
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
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.CT_PHATSINHTableAdapter = null;
            this.tableAdapterManager.KHOTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.PHATSINHTableAdapter = this.pHATSINHTableAdapter;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU_PHANTAN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.bdsNV;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(0, 127);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.MenuManager = this.barManager1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(800, 174);
            this.nHANVIENGridControl.TabIndex = 6;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã NV";
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
            this.groupBox1.Controls.Add(hOLabel);
            this.groupBox1.Controls.Add(this.hOTextBox);
            this.groupBox1.Controls.Add(mANVLabel);
            this.groupBox1.Controls.Add(this.mANVTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(250, 41);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(56, 17);
            mANVLabel.TabIndex = 0;
            mANVLabel.Text = "MANV:";
            // 
            // mANVTextBox
            // 
            this.mANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "MANV", true));
            this.mANVTextBox.Location = new System.Drawing.Point(312, 38);
            this.mANVTextBox.Name = "mANVTextBox";
            this.mANVTextBox.Size = new System.Drawing.Size(100, 25);
            this.mANVTextBox.TabIndex = 1;
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(250, 86);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(33, 17);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HO", true));
            this.hOTextBox.Location = new System.Drawing.Point(289, 83);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.Size = new System.Drawing.Size(100, 25);
            this.hOTextBox.TabIndex = 3;
            // 
            // bdsPS
            // 
            this.bdsPS.DataMember = "PHATSINH";
            this.bdsPS.DataSource = this.DS;
            // 
            // pHATSINHTableAdapter
            // 
            this.pHATSINHTableAdapter.ClearBeforeFill = true;
            // 
            // frmNV_vidu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nHANVIENGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNV_vidu";
            this.Text = "frmNV_vidu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNV_vidu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPS)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.BindingSource bdsNV;
        private DS DS;
        private DSTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
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
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.TextBox mANVTextBox;
        private DSTableAdapters.PHATSINHTableAdapter pHATSINHTableAdapter;
        private System.Windows.Forms.BindingSource bdsPS;
    }
}