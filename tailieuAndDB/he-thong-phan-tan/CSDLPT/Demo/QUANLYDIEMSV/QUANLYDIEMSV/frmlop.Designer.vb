<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TENKHOALabel As System.Windows.Forms.Label
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim MAKHOALabel1 As System.Windows.Forms.Label
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim KHAIGIANGLabel As System.Windows.Forms.Label
        Dim KETTHUCLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlop))
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdskhoa = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbtenkhoa = New System.Windows.Forms.ComboBox
        Me.bdslop = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.dgvlop = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txttenlop = New System.Windows.Forms.TextBox
        Me.txtkhaigiang = New System.Windows.Forms.TextBox
        Me.txtketthuc = New System.Windows.Forms.TextBox
        Me.txtmalop = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtmakhoa1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnthoat = New System.Windows.Forms.Button
        Me.btnxoa = New System.Windows.Forms.Button
        Me.btnghi = New System.Windows.Forms.Button
        Me.btnthem = New System.Windows.Forms.Button
        Me.btnphuchoi = New System.Windows.Forms.Button
        Me.txtmakhoa = New System.Windows.Forms.TextBox
        TENKHOALabel = New System.Windows.Forms.Label
        MALOPLabel = New System.Windows.Forms.Label
        MAKHOALabel1 = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        KHAIGIANGLabel = New System.Windows.Forms.Label
        KETTHUCLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TENKHOALabel
        '
        TENKHOALabel.AutoSize = True
        TENKHOALabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENKHOALabel.Location = New System.Drawing.Point(250, 100)
        TENKHOALabel.Name = "TENKHOALabel"
        TENKHOALabel.Size = New System.Drawing.Size(57, 26)
        TENKHOALabel.TabIndex = 1
        TENKHOALabel.Text = "Khoa"
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(30, 34)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(71, 26)
        MALOPLabel.TabIndex = 5
        MALOPLabel.Text = "Maõ lôùp"
        '
        'MAKHOALabel1
        '
        MAKHOALabel1.AutoSize = True
        MAKHOALabel1.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAKHOALabel1.Location = New System.Drawing.Point(257, 37)
        MAKHOALabel1.Name = "MAKHOALabel1"
        MAKHOALabel1.Size = New System.Drawing.Size(85, 26)
        MAKHOALabel1.TabIndex = 7
        MAKHOALabel1.Text = "Maõ khoa"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLOPLabel.Location = New System.Drawing.Point(30, 92)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(75, 26)
        TENLOPLabel.TabIndex = 9
        TENLOPLabel.Text = "Teân lôùp"
        '
        'KHAIGIANGLabel
        '
        KHAIGIANGLabel.AutoSize = True
        KHAIGIANGLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KHAIGIANGLabel.Location = New System.Drawing.Point(30, 144)
        KHAIGIANGLabel.Name = "KHAIGIANGLabel"
        KHAIGIANGLabel.Size = New System.Drawing.Size(104, 26)
        KHAIGIANGLabel.TabIndex = 11
        KHAIGIANGLabel.Text = "Khai giaûng"
        '
        'KETTHUCLabel
        '
        KETTHUCLabel.AutoSize = True
        KETTHUCLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KETTHUCLabel.Location = New System.Drawing.Point(257, 144)
        KETTHUCLabel.Name = "KETTHUCLabel"
        KETTHUCLabel.Size = New System.Drawing.Size(83, 26)
        KETTHUCLabel.TabIndex = 13
        KETTHUCLabel.Text = "Keát thuùc"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdskhoa
        '
        Me.bdskhoa.DataMember = "KHOA"
        Me.bdskhoa.DataSource = Me.DS
        '
        'cmbtenkhoa
        '
        Me.cmbtenkhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "TENKHOA", True))
        Me.cmbtenkhoa.DataSource = Me.bdskhoa
        Me.cmbtenkhoa.DisplayMember = "TENKHOA"
        Me.cmbtenkhoa.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtenkhoa.FormattingEnabled = True
        Me.cmbtenkhoa.Location = New System.Drawing.Point(309, 99)
        Me.cmbtenkhoa.Name = "cmbtenkhoa"
        Me.cmbtenkhoa.Size = New System.Drawing.Size(331, 29)
        Me.cmbtenkhoa.TabIndex = 2
        Me.cmbtenkhoa.ValueMember = "MAKHOA"
        '
        'bdslop
        '
        Me.bdslop.DataMember = "FK_KHOA_LOP"
        Me.bdslop.DataSource = Me.bdskhoa
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'dgvlop
        '
        Me.dgvlop.AllowUserToAddRows = False
        Me.dgvlop.AllowUserToDeleteRows = False
        Me.dgvlop.AutoGenerateColumns = False
        Me.dgvlop.BackgroundColor = System.Drawing.Color.LightGreen
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvlop.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvlop.DataSource = Me.bdslop
        Me.dgvlop.GridColor = System.Drawing.Color.Red
        Me.dgvlop.Location = New System.Drawing.Point(232, 147)
        Me.dgvlop.Name = "dgvlop"
        Me.dgvlop.ReadOnly = True
        Me.dgvlop.RowTemplate.Height = 24
        Me.dgvlop.Size = New System.Drawing.Size(694, 222)
        Me.dgvlop.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MALOP"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ lôùp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MAKHOA"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Maõ khoa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TENLOP"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Teân lôùp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KHAIGIANG"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Khai giaûng"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "KETTHUC"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "Keát thuùc"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'txttenlop
        '
        Me.txttenlop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "TENLOP", True))
        Me.txttenlop.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenlop.Location = New System.Drawing.Point(135, 85)
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.Size = New System.Drawing.Size(530, 34)
        Me.txttenlop.TabIndex = 10
        '
        'txtkhaigiang
        '
        Me.txtkhaigiang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "KHAIGIANG", True))
        Me.txtkhaigiang.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkhaigiang.Location = New System.Drawing.Point(135, 141)
        Me.txtkhaigiang.Name = "txtkhaigiang"
        Me.txtkhaigiang.Size = New System.Drawing.Size(100, 34)
        Me.txtkhaigiang.TabIndex = 12
        '
        'txtketthuc
        '
        Me.txtketthuc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "KETTHUC", True))
        Me.txtketthuc.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtketthuc.Location = New System.Drawing.Point(349, 144)
        Me.txtketthuc.Name = "txtketthuc"
        Me.txtketthuc.Size = New System.Drawing.Size(100, 34)
        Me.txtketthuc.TabIndex = 14
        '
        'txtmalop
        '
        Me.txtmalop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "MALOP", True))
        Me.txtmalop.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmalop.Location = New System.Drawing.Point(135, 37)
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.Size = New System.Drawing.Size(100, 34)
        Me.txtmalop.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleGreen
        Me.GroupBox1.Controls.Add(Me.txtmakhoa1)
        Me.GroupBox1.Controls.Add(Me.txttenlop)
        Me.GroupBox1.Controls.Add(MALOPLabel)
        Me.GroupBox1.Controls.Add(MAKHOALabel1)
        Me.GroupBox1.Controls.Add(TENLOPLabel)
        Me.GroupBox1.Controls.Add(Me.txtmalop)
        Me.GroupBox1.Controls.Add(Me.txtkhaigiang)
        Me.GroupBox1.Controls.Add(KETTHUCLabel)
        Me.GroupBox1.Controls.Add(KHAIGIANGLabel)
        Me.GroupBox1.Controls.Add(Me.txtketthuc)
        Me.GroupBox1.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(232, 409)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 210)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "THOÂNG TIN VEÀ LÔÙP"
        '
        'txtmakhoa1
        '
        Me.txtmakhoa1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "MAKHOA", True))
        Me.txtmakhoa1.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa1.Location = New System.Drawing.Point(349, 37)
        Me.txtmakhoa1.Name = "txtmakhoa1"
        Me.txtmakhoa1.ReadOnly = True
        Me.txtmakhoa1.Size = New System.Drawing.Size(100, 34)
        Me.txtmakhoa1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("VNI-Thufap3", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(458, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 36)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "DANH SAÙCH LÔÙP"
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.ForeColor = System.Drawing.Color.Navy
        Me.btnthoat.Image = CType(resources.GetObject("btnthoat.Image"), System.Drawing.Image)
        Me.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthoat.Location = New System.Drawing.Point(817, 640)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(109, 66)
        Me.btnthoat.TabIndex = 20
        Me.btnthoat.Text = "Thoaùt"
        Me.btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.ForeColor = System.Drawing.Color.Navy
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(517, 640)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(109, 66)
        Me.btnxoa.TabIndex = 18
        Me.btnxoa.Text = "Xoùa"
        Me.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnghi
        '
        Me.btnghi.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnghi.ForeColor = System.Drawing.Color.Navy
        Me.btnghi.Image = CType(resources.GetObject("btnghi.Image"), System.Drawing.Image)
        Me.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnghi.Location = New System.Drawing.Point(352, 640)
        Me.btnghi.Name = "btnghi"
        Me.btnghi.Size = New System.Drawing.Size(109, 66)
        Me.btnghi.TabIndex = 17
        Me.btnghi.Text = "Ghi"
        Me.btnghi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnghi.UseVisualStyleBackColor = True
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnthem.Image = CType(resources.GetObject("btnthem.Image"), System.Drawing.Image)
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnthem.Location = New System.Drawing.Point(219, 640)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(109, 66)
        Me.btnthem.TabIndex = 16
        Me.btnthem.Text = "Theâm"
        Me.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnphuchoi
        '
        Me.btnphuchoi.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnphuchoi.ForeColor = System.Drawing.Color.Navy
        Me.btnphuchoi.Image = CType(resources.GetObject("btnphuchoi.Image"), System.Drawing.Image)
        Me.btnphuchoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnphuchoi.Location = New System.Drawing.Point(671, 640)
        Me.btnphuchoi.Name = "btnphuchoi"
        Me.btnphuchoi.Size = New System.Drawing.Size(109, 66)
        Me.btnphuchoi.TabIndex = 19
        Me.btnphuchoi.Text = "Phuïc hoài"
        Me.btnphuchoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnphuchoi.UseVisualStyleBackColor = True
        '
        'txtmakhoa
        '
        Me.txtmakhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "MAKHOA", True))
        Me.txtmakhoa.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.Location = New System.Drawing.Point(704, 100)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.ReadOnly = True
        Me.txtmakhoa.Size = New System.Drawing.Size(100, 29)
        Me.txtmakhoa.TabIndex = 23
        '
        'frmlop
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 718)
        Me.Controls.Add(Me.txtmakhoa)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnphuchoi)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnghi)
        Me.Controls.Add(Me.dgvlop)
        Me.Controls.Add(TENKHOALabel)
        Me.Controls.Add(Me.cmbtenkhoa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmlop"
        Me.Text = "frmlop"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdskhoa As System.Windows.Forms.BindingSource
    Friend WithEvents cmbtenkhoa As System.Windows.Forms.ComboBox
    Friend WithEvents bdslop As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents dgvlop As System.Windows.Forms.DataGridView
    Friend WithEvents txttenlop As System.Windows.Forms.TextBox
    Friend WithEvents txtkhaigiang As System.Windows.Forms.TextBox
    Friend WithEvents txtketthuc As System.Windows.Forms.TextBox
    Friend WithEvents txtmalop As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnghi As System.Windows.Forms.Button
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtmakhoa1 As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhoa As System.Windows.Forms.TextBox
End Class
