<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmsv
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
        Dim MASVLabel As System.Windows.Forms.Label
        Dim MANGANHLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim PHAILabel As System.Windows.Forms.Label
        Dim NGAYSINHLabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim GHICHULabel As System.Windows.Forms.Label
        Dim DANGHIHOCLabel As System.Windows.Forms.Label
        Dim KETTHUCLabel As System.Windows.Forms.Label
        Dim KHAIGIANGLabel As System.Windows.Forms.Label
        Dim MAKHOALabel As System.Windows.Forms.Label
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmsv))
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdslop = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.bdssv = New System.Windows.Forms.BindingSource(Me.components)
        Me.SINHVIENTableAdapter = New QUANLYDIEMSV.DSTableAdapters.SINHVIENTableAdapter
        Me.dgvsv = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.txtmasv = New System.Windows.Forms.TextBox
        Me.txtho = New System.Windows.Forms.TextBox
        Me.txtten = New System.Windows.Forms.TextBox
        Me.cmbphai = New System.Windows.Forms.ComboBox
        Me.dtpngaysinh = New System.Windows.Forms.DateTimePicker
        Me.txtdiachi = New System.Windows.Forms.TextBox
        Me.txtghichu = New System.Windows.Forms.TextBox
        Me.chkdanghihoc = New System.Windows.Forms.CheckBox
        Me.Btnthem = New System.Windows.Forms.Button
        Me.Btnghi = New System.Windows.Forms.Button
        Me.Btnxoa = New System.Windows.Forms.Button
        Me.Btnphuchoi = New System.Windows.Forms.Button
        Me.Btnthoat = New System.Windows.Forms.Button
        Me.txtMALOPSV = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbmanganh = New System.Windows.Forms.ComboBox
        Me.bdsnganh = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtketthuc = New System.Windows.Forms.TextBox
        Me.txtkhaigiang = New System.Windows.Forms.TextBox
        Me.txtmakhoa = New System.Windows.Forms.TextBox
        Me.txttenlop = New System.Windows.Forms.TextBox
        Me.cmbmalop = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.NGANHTableAdapter = New QUANLYDIEMSV.DSTableAdapters.NGANHTableAdapter
        MASVLabel = New System.Windows.Forms.Label
        MANGANHLabel = New System.Windows.Forms.Label
        HOLabel = New System.Windows.Forms.Label
        PHAILabel = New System.Windows.Forms.Label
        NGAYSINHLabel = New System.Windows.Forms.Label
        DIACHILabel = New System.Windows.Forms.Label
        GHICHULabel = New System.Windows.Forms.Label
        DANGHIHOCLabel = New System.Windows.Forms.Label
        KETTHUCLabel = New System.Windows.Forms.Label
        KHAIGIANGLabel = New System.Windows.Forms.Label
        MAKHOALabel = New System.Windows.Forms.Label
        MALOPLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdssv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bdsnganh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MASVLabel
        '
        MASVLabel.AutoSize = True
        MASVLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MASVLabel.ForeColor = System.Drawing.Color.Blue
        MASVLabel.Location = New System.Drawing.Point(45, 33)
        MASVLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MASVLabel.Name = "MASVLabel"
        MASVLabel.Size = New System.Drawing.Size(71, 26)
        MASVLabel.TabIndex = 11
        MASVLabel.Text = "Maõ SV"
        '
        'MANGANHLabel
        '
        MANGANHLabel.AutoSize = True
        MANGANHLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MANGANHLabel.ForeColor = System.Drawing.Color.Blue
        MANGANHLabel.Location = New System.Drawing.Point(316, 30)
        MANGANHLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MANGANHLabel.Name = "MANGANHLabel"
        MANGANHLabel.Size = New System.Drawing.Size(95, 26)
        MANGANHLabel.TabIndex = 13
        MANGANHLabel.Text = "Maõ ngaønh"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOLabel.ForeColor = System.Drawing.Color.Blue
        HOLabel.Location = New System.Drawing.Point(45, 71)
        HOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(93, 26)
        HOLabel.TabIndex = 15
        HOLabel.Text = "Hoï vaø teân"
        '
        'PHAILabel
        '
        PHAILabel.AutoSize = True
        PHAILabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PHAILabel.ForeColor = System.Drawing.Color.Blue
        PHAILabel.Location = New System.Drawing.Point(610, 73)
        PHAILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PHAILabel.Name = "PHAILabel"
        PHAILabel.Size = New System.Drawing.Size(49, 26)
        PHAILabel.TabIndex = 19
        PHAILabel.Text = "Phaùi"
        '
        'NGAYSINHLabel
        '
        NGAYSINHLabel.AutoSize = True
        NGAYSINHLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NGAYSINHLabel.ForeColor = System.Drawing.Color.Blue
        NGAYSINHLabel.Location = New System.Drawing.Point(610, 125)
        NGAYSINHLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NGAYSINHLabel.Name = "NGAYSINHLabel"
        NGAYSINHLabel.Size = New System.Drawing.Size(96, 26)
        NGAYSINHLabel.TabIndex = 21
        NGAYSINHLabel.Text = "Ngaøy sinh"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIACHILabel.ForeColor = System.Drawing.Color.Blue
        DIACHILabel.Location = New System.Drawing.Point(45, 116)
        DIACHILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(73, 26)
        DIACHILabel.TabIndex = 23
        DIACHILabel.Text = "Ñòa chæ"
        '
        'GHICHULabel
        '
        GHICHULabel.AutoSize = True
        GHICHULabel.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GHICHULabel.ForeColor = System.Drawing.Color.Blue
        GHICHULabel.Location = New System.Drawing.Point(848, 125)
        GHICHULabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GHICHULabel.Name = "GHICHULabel"
        GHICHULabel.Size = New System.Drawing.Size(73, 24)
        GHICHULabel.TabIndex = 25
        GHICHULabel.Text = "Ghi chuù"
        '
        'DANGHIHOCLabel
        '
        DANGHIHOCLabel.AutoSize = True
        DANGHIHOCLabel.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DANGHIHOCLabel.ForeColor = System.Drawing.Color.Blue
        DANGHIHOCLabel.Location = New System.Drawing.Point(848, 77)
        DANGHIHOCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DANGHIHOCLabel.Name = "DANGHIHOCLabel"
        DANGHIHOCLabel.Size = New System.Drawing.Size(107, 24)
        DANGHIHOCLabel.TabIndex = 27
        DANGHIHOCLabel.Text = "Ñaõ nghæ hoïc"
        '
        'KETTHUCLabel
        '
        KETTHUCLabel.AutoSize = True
        KETTHUCLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KETTHUCLabel.ForeColor = System.Drawing.Color.Blue
        KETTHUCLabel.Location = New System.Drawing.Point(1050, 399)
        KETTHUCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KETTHUCLabel.Name = "KETTHUCLabel"
        KETTHUCLabel.Size = New System.Drawing.Size(85, 25)
        KETTHUCLabel.TabIndex = 45
        KETTHUCLabel.Text = "Keát thuùc"
        '
        'KHAIGIANGLabel
        '
        KHAIGIANGLabel.AutoSize = True
        KHAIGIANGLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KHAIGIANGLabel.ForeColor = System.Drawing.Color.Blue
        KHAIGIANGLabel.Location = New System.Drawing.Point(843, 398)
        KHAIGIANGLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        KHAIGIANGLabel.Name = "KHAIGIANGLabel"
        KHAIGIANGLabel.Size = New System.Drawing.Size(109, 25)
        KHAIGIANGLabel.TabIndex = 43
        KHAIGIANGLabel.Text = "Khai giaûng"
        '
        'MAKHOALabel
        '
        MAKHOALabel.AutoSize = True
        MAKHOALabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAKHOALabel.ForeColor = System.Drawing.Color.Blue
        MAKHOALabel.Location = New System.Drawing.Point(646, 396)
        MAKHOALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MAKHOALabel.Name = "MAKHOALabel"
        MAKHOALabel.Size = New System.Drawing.Size(86, 25)
        MAKHOALabel.TabIndex = 41
        MAKHOALabel.Text = "Maõ khoa"
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.ForeColor = System.Drawing.Color.Blue
        MALOPLabel.Location = New System.Drawing.Point(143, 396)
        MALOPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(46, 25)
        MALOPLabel.TabIndex = 38
        MALOPLabel.Text = "Lôùp"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdslop
        '
        Me.bdslop.DataMember = "LOP"
        Me.bdslop.DataSource = Me.DS
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'bdssv
        '
        Me.bdssv.DataMember = "FK_LOP_SINHVIEN"
        Me.bdssv.DataSource = Me.bdslop
        '
        'SINHVIENTableAdapter
        '
        Me.SINHVIENTableAdapter.ClearBeforeFill = True
        '
        'dgvsv
        '
        Me.dgvsv.AllowUserToAddRows = False
        Me.dgvsv.AllowUserToDeleteRows = False
        Me.dgvsv.AutoGenerateColumns = False
        Me.dgvsv.BackgroundColor = System.Drawing.Color.Bisque
        Me.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1})
        Me.dgvsv.DataSource = Me.bdssv
        Me.dgvsv.GridColor = System.Drawing.Color.Blue
        Me.dgvsv.Location = New System.Drawing.Point(132, 433)
        Me.dgvsv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvsv.Name = "dgvsv"
        Me.dgvsv.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvsv.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvsv.RowTemplate.Height = 24
        Me.dgvsv.Size = New System.Drawing.Size(1085, 277)
        Me.dgvsv.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MASV"
        DataGridViewCellStyle1.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ sinh vieân"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MALOP"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Maõ lôùp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MANGANH"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Maõ ngaønh"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HO"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hoï"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TEN"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn5.HeaderText = "Teân"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PHAI"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phaùi"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NGAYSINH"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ngaøy sinh"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DIACHI"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn8.HeaderText = "Ñòa chæ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "GHICHU"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ghi chuù"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "DANGHIHOC"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.NullValue = False
        Me.DataGridViewCheckBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Ñaõ nghæ hoïc"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'txtmasv
        '
        Me.txtmasv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "MASV", True))
        Me.txtmasv.ForeColor = System.Drawing.Color.Red
        Me.txtmasv.Location = New System.Drawing.Point(140, 30)
        Me.txtmasv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmasv.Name = "txtmasv"
        Me.txtmasv.Size = New System.Drawing.Size(150, 36)
        Me.txtmasv.TabIndex = 12
        '
        'txtho
        '
        Me.txtho.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "HO", True))
        Me.txtho.ForeColor = System.Drawing.Color.Red
        Me.txtho.Location = New System.Drawing.Point(140, 68)
        Me.txtho.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtho.Name = "txtho"
        Me.txtho.Size = New System.Drawing.Size(251, 36)
        Me.txtho.TabIndex = 16
        '
        'txtten
        '
        Me.txtten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "TEN", True))
        Me.txtten.ForeColor = System.Drawing.Color.Red
        Me.txtten.Location = New System.Drawing.Point(402, 71)
        Me.txtten.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(121, 36)
        Me.txtten.TabIndex = 18
        '
        'cmbphai
        '
        Me.cmbphai.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "PHAI", True))
        Me.cmbphai.ForeColor = System.Drawing.Color.Red
        Me.cmbphai.FormattingEnabled = True
        Me.cmbphai.Items.AddRange(New Object() {"NAM", "NU"})
        Me.cmbphai.Location = New System.Drawing.Point(692, 69)
        Me.cmbphai.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbphai.Name = "cmbphai"
        Me.cmbphai.Size = New System.Drawing.Size(98, 36)
        Me.cmbphai.TabIndex = 20
        '
        'dtpngaysinh
        '
        Me.dtpngaysinh.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dtpngaysinh.CalendarTitleForeColor = System.Drawing.Color.Red
        Me.dtpngaysinh.CustomFormat = ""
        Me.dtpngaysinh.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdssv, "NGAYSINH", True))
        Me.dtpngaysinh.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngaysinh.Location = New System.Drawing.Point(692, 118)
        Me.dtpngaysinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpngaysinh.Name = "dtpngaysinh"
        Me.dtpngaysinh.Size = New System.Drawing.Size(98, 34)
        Me.dtpngaysinh.TabIndex = 22
        '
        'txtdiachi
        '
        Me.txtdiachi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "DIACHI", True))
        Me.txtdiachi.ForeColor = System.Drawing.Color.Red
        Me.txtdiachi.Location = New System.Drawing.Point(140, 116)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(383, 36)
        Me.txtdiachi.TabIndex = 24
        '
        'txtghichu
        '
        Me.txtghichu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "GHICHU", True))
        Me.txtghichu.ForeColor = System.Drawing.Color.Red
        Me.txtghichu.Location = New System.Drawing.Point(957, 118)
        Me.txtghichu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtghichu.Name = "txtghichu"
        Me.txtghichu.Size = New System.Drawing.Size(107, 36)
        Me.txtghichu.TabIndex = 26
        '
        'chkdanghihoc
        '
        Me.chkdanghihoc.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bdssv, "DANGHIHOC", True))
        Me.chkdanghihoc.ForeColor = System.Drawing.Color.Red
        Me.chkdanghihoc.Location = New System.Drawing.Point(957, 68)
        Me.chkdanghihoc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkdanghihoc.Name = "chkdanghihoc"
        Me.chkdanghihoc.Size = New System.Drawing.Size(45, 40)
        Me.chkdanghihoc.TabIndex = 28
        Me.chkdanghihoc.UseVisualStyleBackColor = True
        '
        'Btnthem
        '
        Me.Btnthem.Font = New System.Drawing.Font("VNI-Souvir", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthem.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Btnthem.Image = CType(resources.GetObject("Btnthem.Image"), System.Drawing.Image)
        Me.Btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnthem.Location = New System.Drawing.Point(29, 22)
        Me.Btnthem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(162, 45)
        Me.Btnthem.TabIndex = 29
        Me.Btnthem.Text = "Theâm"
        Me.Btnthem.UseVisualStyleBackColor = True
        '
        'Btnghi
        '
        Me.Btnghi.Font = New System.Drawing.Font("VNI-Souvir", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnghi.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Btnghi.Image = CType(resources.GetObject("Btnghi.Image"), System.Drawing.Image)
        Me.Btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnghi.Location = New System.Drawing.Point(218, 22)
        Me.Btnghi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnghi.Name = "Btnghi"
        Me.Btnghi.Size = New System.Drawing.Size(165, 45)
        Me.Btnghi.TabIndex = 30
        Me.Btnghi.Text = "Ghi"
        Me.Btnghi.UseVisualStyleBackColor = True
        '
        'Btnxoa
        '
        Me.Btnxoa.Font = New System.Drawing.Font("VNI-Souvir", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnxoa.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Btnxoa.Image = CType(resources.GetObject("Btnxoa.Image"), System.Drawing.Image)
        Me.Btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnxoa.Location = New System.Drawing.Point(429, 22)
        Me.Btnxoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnxoa.Name = "Btnxoa"
        Me.Btnxoa.Size = New System.Drawing.Size(162, 45)
        Me.Btnxoa.TabIndex = 31
        Me.Btnxoa.Text = "Xoùa"
        Me.Btnxoa.UseVisualStyleBackColor = True
        '
        'Btnphuchoi
        '
        Me.Btnphuchoi.Font = New System.Drawing.Font("VNI-Souvir", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnphuchoi.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Btnphuchoi.Image = CType(resources.GetObject("Btnphuchoi.Image"), System.Drawing.Image)
        Me.Btnphuchoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnphuchoi.Location = New System.Drawing.Point(650, 22)
        Me.Btnphuchoi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btnphuchoi.Name = "Btnphuchoi"
        Me.Btnphuchoi.Size = New System.Drawing.Size(168, 45)
        Me.Btnphuchoi.TabIndex = 32
        Me.Btnphuchoi.Text = "Phuïc hoài"
        Me.Btnphuchoi.UseVisualStyleBackColor = True
        '
        'Btnthoat
        '
        Me.Btnthoat.Font = New System.Drawing.Font("VNI-Souvir", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Btnthoat.Image = CType(resources.GetObject("Btnthoat.Image"), System.Drawing.Image)
        Me.Btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnthoat.Location = New System.Drawing.Point(878, 19)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(172, 48)
        Me.Btnthoat.TabIndex = 34
        Me.Btnthoat.Text = "Thoaùt"
        Me.Btnthoat.UseVisualStyleBackColor = True
        '
        'txtMALOPSV
        '
        Me.txtMALOPSV.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "MALOP", True))
        Me.txtMALOPSV.ForeColor = System.Drawing.Color.Red
        Me.txtMALOPSV.Location = New System.Drawing.Point(692, 29)
        Me.txtMALOPSV.Name = "txtMALOPSV"
        Me.txtMALOPSV.ReadOnly = True
        Me.txtMALOPSV.Size = New System.Drawing.Size(98, 36)
        Me.txtMALOPSV.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Pink
        Me.GroupBox1.Controls.Add(Me.cmbmanganh)
        Me.GroupBox1.Controls.Add(Me.txtho)
        Me.GroupBox1.Controls.Add(Me.txtmasv)
        Me.GroupBox1.Controls.Add(Me.txtMALOPSV)
        Me.GroupBox1.Controls.Add(MASVLabel)
        Me.GroupBox1.Controls.Add(MANGANHLabel)
        Me.GroupBox1.Controls.Add(HOLabel)
        Me.GroupBox1.Controls.Add(Me.txtten)
        Me.GroupBox1.Controls.Add(Me.cmbphai)
        Me.GroupBox1.Controls.Add(PHAILabel)
        Me.GroupBox1.Controls.Add(DANGHIHOCLabel)
        Me.GroupBox1.Controls.Add(Me.dtpngaysinh)
        Me.GroupBox1.Controls.Add(Me.chkdanghihoc)
        Me.GroupBox1.Controls.Add(NGAYSINHLabel)
        Me.GroupBox1.Controls.Add(GHICHULabel)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(Me.txtghichu)
        Me.GroupBox1.Controls.Add(DIACHILabel)
        Me.GroupBox1.Font = New System.Drawing.Font("VNI-Souvir", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(129, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1084, 170)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "THOÂNG TIN SINH VIEÂN"
        '
        'cmbmanganh
        '
        Me.cmbmanganh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdssv, "MANGANH", True))
        Me.cmbmanganh.FormattingEnabled = True
        Me.cmbmanganh.Location = New System.Drawing.Point(402, 27)
        Me.cmbmanganh.Name = "cmbmanganh"
        Me.cmbmanganh.Size = New System.Drawing.Size(121, 36)
        Me.cmbmanganh.TabIndex = 40
        '
        'bdsnganh
        '
        Me.bdsnganh.DataMember = "NGANH"
        Me.bdsnganh.DataSource = Me.DS
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("VNI-Bodon", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(127, 350)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 36)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "DANH SAÙCH SINH VIEÂN"
        '
        'txtketthuc
        '
        Me.txtketthuc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "KETTHUC", True))
        Me.txtketthuc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtketthuc.Location = New System.Drawing.Point(1126, 396)
        Me.txtketthuc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtketthuc.Name = "txtketthuc"
        Me.txtketthuc.ReadOnly = True
        Me.txtketthuc.Size = New System.Drawing.Size(91, 32)
        Me.txtketthuc.TabIndex = 46
        '
        'txtkhaigiang
        '
        Me.txtkhaigiang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "KHAIGIANG", True))
        Me.txtkhaigiang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtkhaigiang.Location = New System.Drawing.Point(938, 393)
        Me.txtkhaigiang.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtkhaigiang.Name = "txtkhaigiang"
        Me.txtkhaigiang.ReadOnly = True
        Me.txtkhaigiang.Size = New System.Drawing.Size(93, 32)
        Me.txtkhaigiang.TabIndex = 44
        '
        'txtmakhoa
        '
        Me.txtmakhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "MAKHOA", True))
        Me.txtmakhoa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtmakhoa.Location = New System.Drawing.Point(722, 393)
        Me.txtmakhoa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.ReadOnly = True
        Me.txtmakhoa.Size = New System.Drawing.Size(95, 32)
        Me.txtmakhoa.TabIndex = 42
        '
        'txttenlop
        '
        Me.txttenlop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "TENLOP", True))
        Me.txttenlop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttenlop.Location = New System.Drawing.Point(322, 393)
        Me.txttenlop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.ReadOnly = True
        Me.txttenlop.Size = New System.Drawing.Size(311, 32)
        Me.txttenlop.TabIndex = 40
        '
        'cmbmalop
        '
        Me.cmbmalop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "MALOP", True))
        Me.cmbmalop.DataSource = Me.bdslop
        Me.cmbmalop.DisplayMember = "MALOP"
        Me.cmbmalop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbmalop.FormattingEnabled = True
        Me.cmbmalop.Location = New System.Drawing.Point(187, 392)
        Me.cmbmalop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbmalop.Name = "cmbmalop"
        Me.cmbmalop.Size = New System.Drawing.Size(119, 32)
        Me.cmbmalop.TabIndex = 39
        Me.cmbmalop.ValueMember = "TENLOP"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnthem)
        Me.Panel1.Controls.Add(Me.Btnghi)
        Me.Panel1.Controls.Add(Me.Btnxoa)
        Me.Panel1.Controls.Add(Me.Btnphuchoi)
        Me.Panel1.Controls.Add(Me.Btnthoat)
        Me.Panel1.Location = New System.Drawing.Point(128, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1085, 81)
        Me.Panel1.TabIndex = 48
        '
        'NGANHTableAdapter
        '
        Me.NGANHTableAdapter.ClearBeforeFill = True
        '
        'Frmsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1274, 758)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(KETTHUCLabel)
        Me.Controls.Add(Me.txtketthuc)
        Me.Controls.Add(KHAIGIANGLabel)
        Me.Controls.Add(Me.txtkhaigiang)
        Me.Controls.Add(MAKHOALabel)
        Me.Controls.Add(Me.txtmakhoa)
        Me.Controls.Add(Me.txttenlop)
        Me.Controls.Add(MALOPLabel)
        Me.Controls.Add(Me.cmbmalop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvsv)
        Me.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frmsv"
        Me.Text = "Frmsv"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdssv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bdsnganh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdslop As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents bdssv As System.Windows.Forms.BindingSource
    Friend WithEvents SINHVIENTableAdapter As QUANLYDIEMSV.DSTableAdapters.SINHVIENTableAdapter
    Friend WithEvents dgvsv As System.Windows.Forms.DataGridView
    Friend WithEvents txtmasv As System.Windows.Forms.TextBox
    Friend WithEvents txtho As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents cmbphai As System.Windows.Forms.ComboBox
    Friend WithEvents dtpngaysinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtghichu As System.Windows.Forms.TextBox
    Friend WithEvents chkdanghihoc As System.Windows.Forms.CheckBox
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents Btnghi As System.Windows.Forms.Button
    Friend WithEvents Btnxoa As System.Windows.Forms.Button
    Friend WithEvents Btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtMALOPSV As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtketthuc As System.Windows.Forms.TextBox
    Friend WithEvents txtkhaigiang As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhoa As System.Windows.Forms.TextBox
    Friend WithEvents txttenlop As System.Windows.Forms.TextBox
    Friend WithEvents cmbmalop As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents bdsnganh As System.Windows.Forms.BindingSource
    Friend WithEvents NGANHTableAdapter As QUANLYDIEMSV.DSTableAdapters.NGANHTableAdapter
    Friend WithEvents cmbmanganh As System.Windows.Forms.ComboBox
End Class
