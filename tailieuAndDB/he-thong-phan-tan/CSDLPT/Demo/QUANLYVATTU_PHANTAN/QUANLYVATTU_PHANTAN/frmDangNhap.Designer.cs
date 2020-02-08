namespace QUANLYVATTU_PHANTAN
{
    partial class frmDangNhap
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
            System.Windows.Forms.Label tENCNLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.bdsPM = new System.Windows.Forms.BindingSource(this.components);
            this.DS_CSDLCHINH = new QUANLYVATTU_PHANTAN.DS_CSDLCHINH();
            this.v_DS_PHANMANHTableAdapter = new QUANLYVATTU_PHANTAN.DS_CSDLCHINHTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QUANLYVATTU_PHANTAN.DS_CSDLCHINHTableAdapters.TableAdapterManager();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            tENCNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_CSDLCHINH)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(31, 43);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(69, 19);
            tENCNLabel.TabIndex = 0;
            tENCNLabel.Text = "Chi nhánh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(tENCNLabel);
            this.groupBox1.Controls.Add(this.cmbChinhanh);
            this.groupBox1.Location = new System.Drawing.Point(53, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(113, 145);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(327, 26);
            this.txtPass.TabIndex = 5;
            this.txtPass.Text = "123456";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(113, 94);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(327, 26);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "QLA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật mã";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.DataSource = this.bdsPM;
            this.cmbChinhanh.DisplayMember = "TENCN";
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(113, 40);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(327, 27);
            this.cmbChinhanh.TabIndex = 1;
            this.cmbChinhanh.ValueMember = "TENSERVER";
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // bdsPM
            // 
            this.bdsPM.DataMember = "V_DS_PHANMANH";
            this.bdsPM.DataSource = this.DS_CSDLCHINH;
            // 
            // DS_CSDLCHINH
            // 
            this.DS_CSDLCHINH.DataSetName = "DS_CSDLCHINH";
            this.DS_CSDLCHINH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QUANLYVATTU_PHANTAN.DS_CSDLCHINHTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(166, 292);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(99, 33);
            this.btnDangnhap.TabIndex = 1;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(342, 292);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 33);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 389);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_CSDLCHINH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DS_CSDLCHINH DS_CSDLCHINH;
        private System.Windows.Forms.BindingSource bdsPM;
        private DS_CSDLCHINHTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private DS_CSDLCHINHTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
    }
}