namespace THITRACNGHIEM
{
    partial class Xfrm_BDMH
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label tENMHLabel;
            this.dS = new THITRACNGHIEM.DS();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new THITRACNGHIEM.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new THITRACNGHIEM.DSTableAdapters.TableAdapterManager();
            this.cmbTENLOP = new System.Windows.Forms.ComboBox();
            this.txtMALOP = new System.Windows.Forms.TextBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new THITRACNGHIEM.DSTableAdapters.MONHOCTableAdapter();
            this.cmbTENMH = new System.Windows.Forms.ComboBox();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.cmbLAN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPre = new System.Windows.Forms.Button();
            tENLOPLabel = new System.Windows.Forms.Label();
            tENMHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = THITRACNGHIEM.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(11, 32);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(49, 14);
            tENLOPLabel.TabIndex = 1;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // cmbTENLOP
            // 
            this.cmbTENLOP.DataSource = this.bdsLOP;
            this.cmbTENLOP.DisplayMember = "TENLOP";
            this.cmbTENLOP.FormattingEnabled = true;
            this.cmbTENLOP.Location = new System.Drawing.Point(66, 29);
            this.cmbTENLOP.Name = "cmbTENLOP";
            this.cmbTENLOP.Size = new System.Drawing.Size(148, 22);
            this.cmbTENLOP.TabIndex = 2;
            this.cmbTENLOP.ValueMember = "MALOP";
            // 
            // txtMALOP
            // 
            this.txtMALOP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLOP, "MALOP", true));
            this.txtMALOP.Location = new System.Drawing.Point(220, 32);
            this.txtMALOP.Name = "txtMALOP";
            this.txtMALOP.Size = new System.Drawing.Size(59, 20);
            this.txtMALOP.TabIndex = 4;
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // tENMHLabel
            // 
            tENMHLabel.AutoSize = true;
            tENMHLabel.Location = new System.Drawing.Point(288, 36);
            tENMHLabel.Name = "tENMHLabel";
            tENMHLabel.Size = new System.Drawing.Size(44, 14);
            tENMHLabel.TabIndex = 4;
            tENMHLabel.Text = "TENMH:";
            // 
            // cmbTENMH
            // 
            this.cmbTENMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "TENMH", true));
            this.cmbTENMH.DataSource = this.bdsMH;
            this.cmbTENMH.DisplayMember = "TENMH";
            this.cmbTENMH.FormattingEnabled = true;
            this.cmbTENMH.Location = new System.Drawing.Point(338, 33);
            this.cmbTENMH.Name = "cmbTENMH";
            this.cmbTENMH.Size = new System.Drawing.Size(163, 22);
            this.cmbTENMH.TabIndex = 5;
            this.cmbTENMH.ValueMember = "MAMH";
            // 
            // txtMAMH
            // 
            this.txtMAMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsMH, "MAMH", true));
            this.txtMAMH.Location = new System.Drawing.Point(504, 36);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(60, 20);
            this.txtMAMH.TabIndex = 6;
            // 
            // cmbLAN
            // 
            this.cmbLAN.FormattingEnabled = true;
            this.cmbLAN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLAN.Location = new System.Drawing.Point(622, 34);
            this.cmbLAN.Name = "cmbLAN";
            this.cmbLAN.Size = new System.Drawing.Size(37, 22);
            this.cmbLAN.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "LẦN";
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(253, 73);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(188, 40);
            this.btnPre.TabIndex = 9;
            this.btnPre.Text = "PREVIEW";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // Xfrm_BDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 125);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLAN);
            this.Controls.Add(this.txtMAMH);
            this.Controls.Add(tENMHLabel);
            this.Controls.Add(this.cmbTENMH);
            this.Controls.Add(this.txtMALOP);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.cmbTENLOP);
            this.Name = "Xfrm_BDMH";
            this.Text = "Xfrm_BDMH";
            this.Load += new System.EventHandler(this.Xfrm_BDMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbTENLOP;
        private System.Windows.Forms.TextBox txtMALOP;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private System.Windows.Forms.ComboBox cmbTENMH;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.ComboBox cmbLAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPre;
    }
}