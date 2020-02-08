<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmgv
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
        Dim MAGVLabel As System.Windows.Forms.Label
        Dim HOLabel As System.Windows.Forms.Label
        Dim PHAILabel As System.Windows.Forms.Label
        Dim NGAYSINHLabel As System.Windows.Forms.Label
        Dim DIACHIMAILLabel As System.Windows.Forms.Label
        Dim MAKHOALabel1 As System.Windows.Forms.Label
        Dim HOCVILabel As System.Windows.Forms.Label
        Dim DIACHILabel As System.Windows.Forms.Label
        Dim TENKHOALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmgv))
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdskhoa = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsgv = New System.Windows.Forms.BindingSource(Me.components)
        Me.GIAOVIENTableAdapter = New QUANLYDIEMSV.DSTableAdapters.GIAOVIENTableAdapter
        Me.txtmagv = New System.Windows.Forms.TextBox
        Me.txtho = New System.Windows.Forms.TextBox
        Me.txtten = New System.Windows.Forms.TextBox
        Me.cmbphai = New System.Windows.Forms.ComboBox
        Me.dtpngaysinh = New System.Windows.Forms.DateTimePicker
        Me.txtdiachimail = New System.Windows.Forms.TextBox
        Me.txtmakhoa = New System.Windows.Forms.TextBox
        Me.txthocvi = New System.Windows.Forms.TextBox
        Me.Btnthem = New System.Windows.Forms.Button
        Me.Btnghi = New System.Windows.Forms.Button
        Me.Btnxoa = New System.Windows.Forms.Button
        Me.Btnphuchoi = New System.Windows.Forms.Button
        Me.Btnthoat = New System.Windows.Forms.Button
        Me.txtdiachi = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvgv = New System.Windows.Forms.DataGridView
        Me.cmbtenkhoa = New System.Windows.Forms.ComboBox
        Me.txtmakhoa1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        MAGVLabel = New System.Windows.Forms.Label
        HOLabel = New System.Windows.Forms.Label
        PHAILabel = New System.Windows.Forms.Label
        NGAYSINHLabel = New System.Windows.Forms.Label
        DIACHIMAILLabel = New System.Windows.Forms.Label
        MAKHOALabel1 = New System.Windows.Forms.Label
        HOCVILabel = New System.Windows.Forms.Label
        DIACHILabel = New System.Windows.Forms.Label
        TENKHOALabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAGVLabel
        '
        MAGVLabel.AutoSize = True
        MAGVLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAGVLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        MAGVLabel.Location = New System.Drawing.Point(38, 46)
        MAGVLabel.Name = "MAGVLabel"
        MAGVLabel.Size = New System.Drawing.Size(63, 20)
        MAGVLabel.TabIndex = 5
        MAGVLabel.Text = "Maõ GV"
        '
        'HOLabel
        '
        HOLabel.AutoSize = True
        HOLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        HOLabel.Location = New System.Drawing.Point(39, 89)
        HOLabel.Name = "HOLabel"
        HOLabel.Size = New System.Drawing.Size(76, 20)
        HOLabel.TabIndex = 7
        HOLabel.Text = "Hoï vaø teân"
        '
        'PHAILabel
        '
        PHAILabel.AutoSize = True
        PHAILabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PHAILabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        PHAILabel.Location = New System.Drawing.Point(621, 94)
        PHAILabel.Name = "PHAILabel"
        PHAILabel.Size = New System.Drawing.Size(46, 20)
        PHAILabel.TabIndex = 11
        PHAILabel.Text = "Phaùi"
        '
        'NGAYSINHLabel
        '
        NGAYSINHLabel.AutoSize = True
        NGAYSINHLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NGAYSINHLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        NGAYSINHLabel.Location = New System.Drawing.Point(36, 133)
        NGAYSINHLabel.Name = "NGAYSINHLabel"
        NGAYSINHLabel.Size = New System.Drawing.Size(80, 20)
        NGAYSINHLabel.TabIndex = 13
        NGAYSINHLabel.Text = "Ngaøy sinh"
        '
        'DIACHIMAILLabel
        '
        DIACHIMAILLabel.AutoSize = True
        DIACHIMAILLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIACHIMAILLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DIACHIMAILLabel.Location = New System.Drawing.Point(616, 178)
        DIACHIMAILLabel.Name = "DIACHIMAILLabel"
        DIACHIMAILLabel.Size = New System.Drawing.Size(94, 20)
        DIACHIMAILLabel.TabIndex = 17
        DIACHIMAILLabel.Text = "Ñòa chæ mail"
        '
        'MAKHOALabel1
        '
        MAKHOALabel1.AutoSize = True
        MAKHOALabel1.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAKHOALabel1.Location = New System.Drawing.Point(259, 48)
        MAKHOALabel1.Name = "MAKHOALabel1"
        MAKHOALabel1.Size = New System.Drawing.Size(0, 20)
        MAKHOALabel1.TabIndex = 19
        '
        'HOCVILabel
        '
        HOCVILabel.AutoSize = True
        HOCVILabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOCVILabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        HOCVILabel.Location = New System.Drawing.Point(36, 178)
        HOCVILabel.Name = "HOCVILabel"
        HOCVILabel.Size = New System.Drawing.Size(54, 20)
        HOCVILabel.TabIndex = 21
        HOCVILabel.Text = "Hoïc vò"
        '
        'DIACHILabel
        '
        DIACHILabel.AutoSize = True
        DIACHILabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DIACHILabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        DIACHILabel.Location = New System.Drawing.Point(621, 138)
        DIACHILabel.Name = "DIACHILabel"
        DIACHILabel.Size = New System.Drawing.Size(60, 20)
        DIACHILabel.TabIndex = 29
        DIACHILabel.Text = "Ñòa chæ"
        '
        'TENKHOALabel
        '
        TENKHOALabel.AutoSize = True
        TENKHOALabel.BackColor = System.Drawing.Color.White
        TENKHOALabel.Location = New System.Drawing.Point(25, 53)
        TENKHOALabel.Name = "TENKHOALabel"
        TENKHOALabel.Size = New System.Drawing.Size(37, 17)
        TENKHOALabel.TabIndex = 1
        TENKHOALabel.Text = "Khoa"
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
        'bdsgv
        '
        Me.bdsgv.DataMember = "FK_KHOA_GIAOVIEN"
        Me.bdsgv.DataSource = Me.bdskhoa
        '
        'GIAOVIENTableAdapter
        '
        Me.GIAOVIENTableAdapter.ClearBeforeFill = True
        '
        'txtmagv
        '
        Me.txtmagv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "MAGV", True))
        Me.txtmagv.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmagv.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtmagv.Location = New System.Drawing.Point(119, 44)
        Me.txtmagv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmagv.Name = "txtmagv"
        Me.txtmagv.Size = New System.Drawing.Size(116, 24)
        Me.txtmagv.TabIndex = 6
        '
        'txtho
        '
        Me.txtho.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "HO", True))
        Me.txtho.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtho.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtho.Location = New System.Drawing.Point(119, 89)
        Me.txtho.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtho.Name = "txtho"
        Me.txtho.Size = New System.Drawing.Size(268, 24)
        Me.txtho.TabIndex = 8
        '
        'txtten
        '
        Me.txtten.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "TEN", True))
        Me.txtten.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtten.Location = New System.Drawing.Point(410, 90)
        Me.txtten.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(143, 24)
        Me.txtten.TabIndex = 10
        '
        'cmbphai
        '
        Me.cmbphai.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "PHAI", True))
        Me.cmbphai.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbphai.ForeColor = System.Drawing.SystemColors.Desktop
        Me.cmbphai.FormattingEnabled = True
        Me.cmbphai.Items.AddRange(New Object() {"NAM", "NU"})
        Me.cmbphai.Location = New System.Drawing.Point(716, 94)
        Me.cmbphai.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbphai.Name = "cmbphai"
        Me.cmbphai.Size = New System.Drawing.Size(68, 25)
        Me.cmbphai.TabIndex = 12
        '
        'dtpngaysinh
        '
        Me.dtpngaysinh.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bdsgv, "NGAYSINH", True))
        Me.dtpngaysinh.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpngaysinh.Location = New System.Drawing.Point(119, 132)
        Me.dtpngaysinh.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpngaysinh.Name = "dtpngaysinh"
        Me.dtpngaysinh.Size = New System.Drawing.Size(116, 24)
        Me.dtpngaysinh.TabIndex = 14
        '
        'txtdiachimail
        '
        Me.txtdiachimail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "DIACHIMAIL", True))
        Me.txtdiachimail.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachimail.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtdiachimail.Location = New System.Drawing.Point(716, 174)
        Me.txtdiachimail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdiachimail.Name = "txtdiachimail"
        Me.txtdiachimail.Size = New System.Drawing.Size(218, 24)
        Me.txtdiachimail.TabIndex = 18
        '
        'txtmakhoa
        '
        Me.txtmakhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "MAKHOA", True))
        Me.txtmakhoa.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtmakhoa.Location = New System.Drawing.Point(410, 43)
        Me.txtmakhoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.ReadOnly = True
        Me.txtmakhoa.Size = New System.Drawing.Size(143, 24)
        Me.txtmakhoa.TabIndex = 20
        '
        'txthocvi
        '
        Me.txthocvi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "HOCVI", True))
        Me.txthocvi.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthocvi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txthocvi.Location = New System.Drawing.Point(119, 178)
        Me.txthocvi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txthocvi.Name = "txthocvi"
        Me.txthocvi.Size = New System.Drawing.Size(116, 24)
        Me.txthocvi.TabIndex = 22
        '
        'Btnthem
        '
        Me.Btnthem.BackColor = System.Drawing.Color.White
        Me.Btnthem.Font = New System.Drawing.Font("VNI-Times", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthem.Image = CType(resources.GetObject("Btnthem.Image"), System.Drawing.Image)
        Me.Btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnthem.Location = New System.Drawing.Point(12, 24)
        Me.Btnthem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(133, 50)
        Me.Btnthem.TabIndex = 23
        Me.Btnthem.Text = "Theâm"
        Me.Btnthem.UseVisualStyleBackColor = False
        '
        'Btnghi
        '
        Me.Btnghi.BackColor = System.Drawing.Color.White
        Me.Btnghi.Font = New System.Drawing.Font("VNI-Times", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnghi.Image = CType(resources.GetObject("Btnghi.Image"), System.Drawing.Image)
        Me.Btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnghi.Location = New System.Drawing.Point(207, 24)
        Me.Btnghi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnghi.Name = "Btnghi"
        Me.Btnghi.Size = New System.Drawing.Size(133, 50)
        Me.Btnghi.TabIndex = 24
        Me.Btnghi.Text = "Ghi"
        Me.Btnghi.UseVisualStyleBackColor = False
        '
        'Btnxoa
        '
        Me.Btnxoa.BackColor = System.Drawing.Color.White
        Me.Btnxoa.Font = New System.Drawing.Font("VNI-Times", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnxoa.Image = CType(resources.GetObject("Btnxoa.Image"), System.Drawing.Image)
        Me.Btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnxoa.Location = New System.Drawing.Point(410, 24)
        Me.Btnxoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnxoa.Name = "Btnxoa"
        Me.Btnxoa.Size = New System.Drawing.Size(133, 50)
        Me.Btnxoa.TabIndex = 25
        Me.Btnxoa.Text = "Xoùa"
        Me.Btnxoa.UseVisualStyleBackColor = False
        '
        'Btnphuchoi
        '
        Me.Btnphuchoi.BackColor = System.Drawing.Color.White
        Me.Btnphuchoi.Font = New System.Drawing.Font("VNI-Times", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnphuchoi.Image = CType(resources.GetObject("Btnphuchoi.Image"), System.Drawing.Image)
        Me.Btnphuchoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnphuchoi.Location = New System.Drawing.Point(616, 24)
        Me.Btnphuchoi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnphuchoi.Name = "Btnphuchoi"
        Me.Btnphuchoi.Size = New System.Drawing.Size(133, 50)
        Me.Btnphuchoi.TabIndex = 26
        Me.Btnphuchoi.Text = "Phuïc hoài"
        Me.Btnphuchoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnphuchoi.UseVisualStyleBackColor = False
        '
        'Btnthoat
        '
        Me.Btnthoat.BackColor = System.Drawing.Color.White
        Me.Btnthoat.Font = New System.Drawing.Font("VNI-Times", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.Image = CType(resources.GetObject("Btnthoat.Image"), System.Drawing.Image)
        Me.Btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnthoat.Location = New System.Drawing.Point(801, 24)
        Me.Btnthoat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(133, 50)
        Me.Btnthoat.TabIndex = 27
        Me.Btnthoat.Text = "Thoaùt"
        Me.Btnthoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnthoat.UseVisualStyleBackColor = False
        '
        'txtdiachi
        '
        Me.txtdiachi.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsgv, "DIACHI", True))
        Me.txtdiachi.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtdiachi.Location = New System.Drawing.Point(716, 134)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(218, 24)
        Me.txtdiachi.TabIndex = 30
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(DIACHILabel)
        Me.GroupBox1.Controls.Add(Me.txtdiachi)
        Me.GroupBox1.Controls.Add(HOCVILabel)
        Me.GroupBox1.Controls.Add(MAKHOALabel1)
        Me.GroupBox1.Controls.Add(Me.txtmakhoa)
        Me.GroupBox1.Controls.Add(Me.cmbphai)
        Me.GroupBox1.Controls.Add(Me.txthocvi)
        Me.GroupBox1.Controls.Add(DIACHIMAILLabel)
        Me.GroupBox1.Controls.Add(Me.dtpngaysinh)
        Me.GroupBox1.Controls.Add(Me.txtdiachimail)
        Me.GroupBox1.Controls.Add(NGAYSINHLabel)
        Me.GroupBox1.Controls.Add(PHAILabel)
        Me.GroupBox1.Controls.Add(Me.txtten)
        Me.GroupBox1.Controls.Add(HOLabel)
        Me.GroupBox1.Controls.Add(Me.txtho)
        Me.GroupBox1.Controls.Add(MAGVLabel)
        Me.GroupBox1.Controls.Add(Me.txtmagv)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(982, 209)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "THOÂNG TIN VEÀ GIAÙO VIEÂN"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "HOCVI"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Hoïc vò"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "MAKHOA"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Maõ khoa"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DIACHIMAIL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Ñòa chæ mail"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DIACHI"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ñòa chæ"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NGAYSINH"
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ngaøy sinh"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PHAI"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Phaùi"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TEN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Teân"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "HO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hoï"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAGV"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ GV"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 120
        '
        'dgvgv
        '
        Me.dgvgv.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.dgvgv.AllowUserToAddRows = False
        Me.dgvgv.AllowUserToDeleteRows = False
        Me.dgvgv.AutoGenerateColumns = False
        Me.dgvgv.BackgroundColor = System.Drawing.Color.White
        Me.dgvgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.dgvgv.DataSource = Me.bdsgv
        Me.dgvgv.GridColor = System.Drawing.Color.Red
        Me.dgvgv.Location = New System.Drawing.Point(11, 91)
        Me.dgvgv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvgv.Name = "dgvgv"
        Me.dgvgv.ReadOnly = True
        Me.dgvgv.Size = New System.Drawing.Size(965, 205)
        Me.dgvgv.TabIndex = 4
        '
        'cmbtenkhoa
        '
        Me.cmbtenkhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "TENKHOA", True))
        Me.cmbtenkhoa.DataSource = Me.bdskhoa
        Me.cmbtenkhoa.DisplayMember = "TENKHOA"
        Me.cmbtenkhoa.ForeColor = System.Drawing.Color.Red
        Me.cmbtenkhoa.FormattingEnabled = True
        Me.cmbtenkhoa.Location = New System.Drawing.Point(123, 49)
        Me.cmbtenkhoa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbtenkhoa.Name = "cmbtenkhoa"
        Me.cmbtenkhoa.Size = New System.Drawing.Size(304, 25)
        Me.cmbtenkhoa.TabIndex = 2
        Me.cmbtenkhoa.ValueMember = "MAKHOA"
        '
        'txtmakhoa1
        '
        Me.txtmakhoa1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "MAKHOA", True))
        Me.txtmakhoa1.ForeColor = System.Drawing.Color.Red
        Me.txtmakhoa1.Location = New System.Drawing.Point(491, 50)
        Me.txtmakhoa1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmakhoa1.Name = "txtmakhoa1"
        Me.txtmakhoa1.ReadOnly = True
        Me.txtmakhoa1.Size = New System.Drawing.Size(116, 24)
        Me.txtmakhoa1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 17)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "DANH SAÙCH GIAÙO VIEÂN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtmakhoa1)
        Me.Panel1.Controls.Add(TENKHOALabel)
        Me.Panel1.Controls.Add(Me.cmbtenkhoa)
        Me.Panel1.Location = New System.Drawing.Point(11, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(965, 83)
        Me.Panel1.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Btnxoa)
        Me.GroupBox2.Controls.Add(Me.Btnthoat)
        Me.GroupBox2.Controls.Add(Me.Btnghi)
        Me.GroupBox2.Controls.Add(Me.Btnphuchoi)
        Me.GroupBox2.Controls.Add(Me.Btnthem)
        Me.GroupBox2.Location = New System.Drawing.Point(127, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(976, 87)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.dgvgv)
        Me.GroupBox3.Location = New System.Drawing.Point(127, 359)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(982, 313)
        Me.GroupBox3.TabIndex = 37
        Me.GroupBox3.TabStop = False
        '
        'Frmgv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1205, 706)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("VNI-Times", 9.749999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frmgv"
        Me.Text = "Frmgv"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdskhoa As System.Windows.Forms.BindingSource
    Friend WithEvents bdsgv As System.Windows.Forms.BindingSource
    Friend WithEvents GIAOVIENTableAdapter As QUANLYDIEMSV.DSTableAdapters.GIAOVIENTableAdapter
    Friend WithEvents txtmagv As System.Windows.Forms.TextBox
    Friend WithEvents txtho As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents cmbphai As System.Windows.Forms.ComboBox
    Friend WithEvents dtpngaysinh As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtdiachimail As System.Windows.Forms.TextBox
    Friend WithEvents txtmakhoa As System.Windows.Forms.TextBox
    Friend WithEvents txthocvi As System.Windows.Forms.TextBox
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents Btnghi As System.Windows.Forms.Button
    Friend WithEvents Btnxoa As System.Windows.Forms.Button
    Friend WithEvents Btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvgv As System.Windows.Forms.DataGridView
    Friend WithEvents cmbtenkhoa As System.Windows.Forms.ComboBox
    Friend WithEvents txtmakhoa1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
