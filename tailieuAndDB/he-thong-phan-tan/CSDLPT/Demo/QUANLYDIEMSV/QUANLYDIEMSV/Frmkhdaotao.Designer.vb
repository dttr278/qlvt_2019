<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmkhdaotao
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
        Dim HOCKYLabel As System.Windows.Forms.Label
        Dim SOTIETLabel As System.Windows.Forms.Label
        Dim TENNGANHLabel As System.Windows.Forms.Label
        Dim MAMONLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmkhdaotao))
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdsnganh = New System.Windows.Forms.BindingSource(Me.components)
        Me.NGANHTableAdapter = New QUANLYDIEMSV.DSTableAdapters.NGANHTableAdapter
        Me.bdskhdaotao = New System.Windows.Forms.BindingSource(Me.components)
        Me.KEHOACHDAOTAOTableAdapter = New QUANLYDIEMSV.DSTableAdapters.KEHOACHDAOTAOTableAdapter
        Me.dgvkhdaotao = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtsotiet = New System.Windows.Forms.TextBox
        Me.cmbtennganh = New System.Windows.Forms.ComboBox
        Me.txtmanganh = New System.Windows.Forms.TextBox
        Me.cmbhocky = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CMBTENMON = New System.Windows.Forms.ComboBox
        Me.bdsmon = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtmamon = New System.Windows.Forms.TextBox
        Me.btnthoat = New System.Windows.Forms.Button
        Me.btnphuchoi = New System.Windows.Forms.Button
        Me.Btnxoa = New System.Windows.Forms.Button
        Me.Btnghi = New System.Windows.Forms.Button
        Me.Btnthem = New System.Windows.Forms.Button
        Me.MONHOCTableAdapter = New QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        HOCKYLabel = New System.Windows.Forms.Label
        SOTIETLabel = New System.Windows.Forms.Label
        TENNGANHLabel = New System.Windows.Forms.Label
        MAMONLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsnganh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdskhdaotao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvkhdaotao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.bdsmon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HOCKYLabel
        '
        HOCKYLabel.AutoSize = True
        HOCKYLabel.Font = New System.Drawing.Font("VNI-Bodon-Poster", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOCKYLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        HOCKYLabel.Location = New System.Drawing.Point(5, 77)
        HOCKYLabel.Name = "HOCKYLabel"
        HOCKYLabel.Size = New System.Drawing.Size(61, 18)
        HOCKYLabel.TabIndex = 12
        HOCKYLabel.Text = "Hoïc kyø"
        '
        'SOTIETLabel
        '
        SOTIETLabel.AutoSize = True
        SOTIETLabel.Font = New System.Drawing.Font("VNI-Bodon-Poster", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOTIETLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        SOTIETLabel.Location = New System.Drawing.Point(207, 82)
        SOTIETLabel.Name = "SOTIETLabel"
        SOTIETLabel.Size = New System.Drawing.Size(58, 18)
        SOTIETLabel.TabIndex = 14
        SOTIETLabel.Text = "Soá tieát"
        '
        'TENNGANHLabel
        '
        TENNGANHLabel.AutoSize = True
        TENNGANHLabel.Font = New System.Drawing.Font("VNI-Bodon-Poster", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENNGANHLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        TENNGANHLabel.Location = New System.Drawing.Point(5, 29)
        TENNGANHLabel.Name = "TENNGANHLabel"
        TENNGANHLabel.Size = New System.Drawing.Size(54, 18)
        TENNGANHLabel.TabIndex = 18
        TENNGANHLabel.Text = "Ngaønh"
        '
        'MAMONLabel
        '
        MAMONLabel.AutoSize = True
        MAMONLabel.Font = New System.Drawing.Font("VNI-Bodon-Poster", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMONLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        MAMONLabel.Location = New System.Drawing.Point(6, 126)
        MAMONLabel.Name = "MAMONLabel"
        MAMONLabel.Size = New System.Drawing.Size(40, 18)
        MAMONLabel.TabIndex = 22
        MAMONLabel.Text = "Moân"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdsnganh
        '
        Me.bdsnganh.DataMember = "NGANH"
        Me.bdsnganh.DataSource = Me.DS
        '
        'NGANHTableAdapter
        '
        Me.NGANHTableAdapter.ClearBeforeFill = True
        '
        'bdskhdaotao
        '
        Me.bdskhdaotao.DataMember = "FK_NGANH_KEHOACHDAOTAO"
        Me.bdskhdaotao.DataSource = Me.bdsnganh
        '
        'KEHOACHDAOTAOTableAdapter
        '
        Me.KEHOACHDAOTAOTableAdapter.ClearBeforeFill = True
        '
        'dgvkhdaotao
        '
        Me.dgvkhdaotao.AllowUserToAddRows = False
        Me.dgvkhdaotao.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvkhdaotao.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvkhdaotao.AutoGenerateColumns = False
        Me.dgvkhdaotao.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkhdaotao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvkhdaotao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhdaotao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvkhdaotao.DataSource = Me.bdskhdaotao
        Me.dgvkhdaotao.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvkhdaotao.Location = New System.Drawing.Point(9, 41)
        Me.dgvkhdaotao.Name = "dgvkhdaotao"
        Me.dgvkhdaotao.ReadOnly = True
        Me.dgvkhdaotao.Size = New System.Drawing.Size(544, 131)
        Me.dgvkhdaotao.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MANGANH"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ ngaønh"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MAMON"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn2.HeaderText = "Maõ moân"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "HOCKY"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn3.HeaderText = "Hoïc kyø"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SOTIET"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Soá tieát"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'txtsotiet
        '
        Me.txtsotiet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhdaotao, "SOTIET", True))
        Me.txtsotiet.Location = New System.Drawing.Point(285, 72)
        Me.txtsotiet.Name = "txtsotiet"
        Me.txtsotiet.Size = New System.Drawing.Size(75, 28)
        Me.txtsotiet.TabIndex = 15
        '
        'cmbtennganh
        '
        Me.cmbtennganh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsnganh, "TENNGANH", True))
        Me.cmbtennganh.DataSource = Me.bdsnganh
        Me.cmbtennganh.DisplayMember = "TENNGANH"
        Me.cmbtennganh.FormattingEnabled = True
        Me.cmbtennganh.Location = New System.Drawing.Point(90, 26)
        Me.cmbtennganh.Name = "cmbtennganh"
        Me.cmbtennganh.Size = New System.Drawing.Size(270, 29)
        Me.cmbtennganh.TabIndex = 19
        Me.cmbtennganh.ValueMember = "MANGANH"
        '
        'txtmanganh
        '
        Me.txtmanganh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhdaotao, "MANGANH", True))
        Me.txtmanganh.Location = New System.Drawing.Point(403, 27)
        Me.txtmanganh.Name = "txtmanganh"
        Me.txtmanganh.ReadOnly = True
        Me.txtmanganh.Size = New System.Drawing.Size(121, 28)
        Me.txtmanganh.TabIndex = 20
        '
        'cmbhocky
        '
        Me.cmbhocky.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhdaotao, "HOCKY", True))
        Me.cmbhocky.FormattingEnabled = True
        Me.cmbhocky.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbhocky.Location = New System.Drawing.Point(90, 72)
        Me.cmbhocky.Name = "cmbhocky"
        Me.cmbhocky.Size = New System.Drawing.Size(68, 29)
        Me.cmbhocky.TabIndex = 22
        Me.cmbhocky.Text = "1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.CMBTENMON)
        Me.GroupBox1.Controls.Add(Me.txtmamon)
        Me.GroupBox1.Controls.Add(Me.btnthoat)
        Me.GroupBox1.Controls.Add(Me.btnphuchoi)
        Me.GroupBox1.Controls.Add(Me.Btnxoa)
        Me.GroupBox1.Controls.Add(Me.Btnghi)
        Me.GroupBox1.Controls.Add(MAMONLabel)
        Me.GroupBox1.Controls.Add(Me.Btnthem)
        Me.GroupBox1.Controls.Add(Me.txtmanganh)
        Me.GroupBox1.Controls.Add(Me.cmbhocky)
        Me.GroupBox1.Controls.Add(TENNGANHLabel)
        Me.GroupBox1.Controls.Add(Me.cmbtennganh)
        Me.GroupBox1.Controls.Add(SOTIETLabel)
        Me.GroupBox1.Controls.Add(Me.txtsotiet)
        Me.GroupBox1.Controls.Add(HOCKYLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(14, 259)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 197)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "KEÁ HOAÏCH ÑAØO TAÏO"
        '
        'CMBTENMON
        '
        Me.CMBTENMON.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsnganh, "TENNGANH", True))
        Me.CMBTENMON.DataSource = Me.bdsmon
        Me.CMBTENMON.DisplayMember = "TENMON"
        Me.CMBTENMON.FormattingEnabled = True
        Me.CMBTENMON.Location = New System.Drawing.Point(90, 122)
        Me.CMBTENMON.Name = "CMBTENMON"
        Me.CMBTENMON.Size = New System.Drawing.Size(270, 29)
        Me.CMBTENMON.TabIndex = 33
        Me.CMBTENMON.ValueMember = "MAMON"
        '
        'bdsmon
        '
        Me.bdsmon.DataMember = "FK_KEHOACHDAOTAO_MONHOC"
        Me.bdsmon.DataSource = Me.bdskhdaotao
        '
        'txtmamon
        '
        Me.txtmamon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhdaotao, "MAMON", True))
        Me.txtmamon.Location = New System.Drawing.Point(403, 122)
        Me.txtmamon.Name = "txtmamon"
        Me.txtmamon.Size = New System.Drawing.Size(121, 28)
        Me.txtmamon.TabIndex = 32
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("VNI-Bodon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Location = New System.Drawing.Point(685, 122)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(100, 43)
        Me.btnthoat.TabIndex = 28
        Me.btnthoat.Text = "Thoaùt"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btnphuchoi
        '
        Me.btnphuchoi.Font = New System.Drawing.Font("VNI-Bodon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnphuchoi.Location = New System.Drawing.Point(555, 122)
        Me.btnphuchoi.Name = "btnphuchoi"
        Me.btnphuchoi.Size = New System.Drawing.Size(119, 44)
        Me.btnphuchoi.TabIndex = 27
        Me.btnphuchoi.Text = "Phuïc hoài"
        Me.btnphuchoi.UseVisualStyleBackColor = True
        '
        'Btnxoa
        '
        Me.Btnxoa.Font = New System.Drawing.Font("VNI-Bodon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnxoa.Location = New System.Drawing.Point(685, 31)
        Me.Btnxoa.Name = "Btnxoa"
        Me.Btnxoa.Size = New System.Drawing.Size(100, 44)
        Me.Btnxoa.TabIndex = 26
        Me.Btnxoa.Text = "Xoùa"
        Me.Btnxoa.UseVisualStyleBackColor = True
        '
        'Btnghi
        '
        Me.Btnghi.Font = New System.Drawing.Font("VNI-Bodon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnghi.Location = New System.Drawing.Point(620, 77)
        Me.Btnghi.Name = "Btnghi"
        Me.Btnghi.Size = New System.Drawing.Size(109, 45)
        Me.Btnghi.TabIndex = 25
        Me.Btnghi.Text = "Ghi"
        Me.Btnghi.UseVisualStyleBackColor = True
        '
        'Btnthem
        '
        Me.Btnthem.Font = New System.Drawing.Font("VNI-Bodon", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthem.Location = New System.Drawing.Point(555, 27)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(119, 46)
        Me.Btnthem.TabIndex = 24
        Me.Btnthem.Text = "Theâm"
        Me.Btnthem.UseVisualStyleBackColor = True
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("VNI-Times", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "THOÂNG TIN KEÁ HOAÏCH ÑAØO TAÏO"
        '
        'Frmkhdaotao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1035, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvkhdaotao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frmkhdaotao"
        Me.Text = "Frmkhdaotao"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsnganh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdskhdaotao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvkhdaotao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.bdsmon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdsnganh As System.Windows.Forms.BindingSource
    Friend WithEvents NGANHTableAdapter As QUANLYDIEMSV.DSTableAdapters.NGANHTableAdapter
    Friend WithEvents bdskhdaotao As System.Windows.Forms.BindingSource
    Friend WithEvents KEHOACHDAOTAOTableAdapter As QUANLYDIEMSV.DSTableAdapters.KEHOACHDAOTAOTableAdapter
    Friend WithEvents dgvkhdaotao As System.Windows.Forms.DataGridView
    Friend WithEvents txtsotiet As System.Windows.Forms.TextBox
    Friend WithEvents cmbtennganh As System.Windows.Forms.ComboBox
    Friend WithEvents txtmanganh As System.Windows.Forms.TextBox
    Friend WithEvents cmbhocky As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents Btnghi As System.Windows.Forms.Button
    Friend WithEvents Btnxoa As System.Windows.Forms.Button
    Friend WithEvents MONHOCTableAdapter As QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents bdsmon As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmamon As System.Windows.Forms.TextBox
    Friend WithEvents CMBTENMON As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
