<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmnganh
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
        Dim MANGANHLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmnganh))
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdskhoa = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbtenkhoa = New System.Windows.Forms.ComboBox
        Me.txtmakhoa = New System.Windows.Forms.TextBox
        Me.bdsnganh = New System.Windows.Forms.BindingSource(Me.components)
        Me.NGANHTableAdapter = New QUANLYDIEMSV.DSTableAdapters.NGANHTableAdapter
        Me.dgvnganh = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtmanganh = New System.Windows.Forms.TextBox
        Me.txttennganh = New System.Windows.Forms.TextBox
        Me.btnthem = New System.Windows.Forms.Button
        Me.Btnghi = New System.Windows.Forms.Button
        Me.Btnxoa = New System.Windows.Forms.Button
        Me.Btnphuchoi = New System.Windows.Forms.Button
        Me.Btnthoat = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        TENKHOALabel = New System.Windows.Forms.Label
        MANGANHLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsnganh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvnganh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TENKHOALabel
        '
        TENKHOALabel.AutoSize = True
        TENKHOALabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        TENKHOALabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENKHOALabel.Location = New System.Drawing.Point(4, 32)
        TENKHOALabel.Name = "TENKHOALabel"
        TENKHOALabel.Size = New System.Drawing.Size(46, 21)
        TENKHOALabel.TabIndex = 1
        TENKHOALabel.Text = "Khoa"
        '
        'MANGANHLabel
        '
        MANGANHLabel.AutoSize = True
        MANGANHLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        MANGANHLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MANGANHLabel.Location = New System.Drawing.Point(4, 105)
        MANGANHLabel.Name = "MANGANHLabel"
        MANGANHLabel.Size = New System.Drawing.Size(55, 21)
        MANGANHLabel.TabIndex = 5
        MANGANHLabel.Text = "Ngaønh"
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
        Me.cmbtenkhoa.Location = New System.Drawing.Point(64, 35)
        Me.cmbtenkhoa.Name = "cmbtenkhoa"
        Me.cmbtenkhoa.Size = New System.Drawing.Size(339, 25)
        Me.cmbtenkhoa.TabIndex = 2
        Me.cmbtenkhoa.ValueMember = "MAKHOA"
        '
        'txtmakhoa
        '
        Me.txtmakhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "MAKHOA", True))
        Me.txtmakhoa.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.Location = New System.Drawing.Point(420, 35)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.ReadOnly = True
        Me.txtmakhoa.Size = New System.Drawing.Size(136, 24)
        Me.txtmakhoa.TabIndex = 4
        '
        'bdsnganh
        '
        Me.bdsnganh.DataMember = "FK_KHOA_NGANH"
        Me.bdsnganh.DataSource = Me.bdskhoa
        '
        'NGANHTableAdapter
        '
        Me.NGANHTableAdapter.ClearBeforeFill = True
        '
        'dgvnganh
        '
        Me.dgvnganh.AllowUserToAddRows = False
        Me.dgvnganh.AllowUserToDeleteRows = False
        Me.dgvnganh.AutoGenerateColumns = False
        Me.dgvnganh.BackgroundColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("VNI-Avo", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvnganh.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvnganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvnganh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvnganh.DataSource = Me.bdsnganh
        Me.dgvnganh.Location = New System.Drawing.Point(383, 347)
        Me.dgvnganh.Name = "dgvnganh"
        Me.dgvnganh.ReadOnly = True
        Me.dgvnganh.Size = New System.Drawing.Size(553, 236)
        Me.dgvnganh.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MANGANH"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ ngaønh"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TENNGANH"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.HeaderText = "Teân ngaønh"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'txtmanganh
        '
        Me.txtmanganh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsnganh, "MANGANH", True))
        Me.txtmanganh.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmanganh.Location = New System.Drawing.Point(420, 103)
        Me.txtmanganh.Name = "txtmanganh"
        Me.txtmanganh.Size = New System.Drawing.Size(135, 24)
        Me.txtmanganh.TabIndex = 6
        '
        'txttennganh
        '
        Me.txttennganh.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsnganh, "TENNGANH", True))
        Me.txttennganh.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttennganh.Location = New System.Drawing.Point(63, 103)
        Me.txttennganh.Name = "txttennganh"
        Me.txttennganh.Size = New System.Drawing.Size(339, 24)
        Me.txttennganh.TabIndex = 10
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.Location = New System.Drawing.Point(0, 2)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(119, 51)
        Me.btnthem.TabIndex = 11
        Me.btnthem.Text = "Theâm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Btnghi
        '
        Me.Btnghi.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnghi.Location = New System.Drawing.Point(65, 57)
        Me.Btnghi.Name = "Btnghi"
        Me.Btnghi.Size = New System.Drawing.Size(119, 51)
        Me.Btnghi.TabIndex = 12
        Me.Btnghi.Text = "Ghi"
        Me.Btnghi.UseVisualStyleBackColor = True
        '
        'Btnxoa
        '
        Me.Btnxoa.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnxoa.Location = New System.Drawing.Point(125, 2)
        Me.Btnxoa.Name = "Btnxoa"
        Me.Btnxoa.Size = New System.Drawing.Size(119, 51)
        Me.Btnxoa.TabIndex = 13
        Me.Btnxoa.Text = "Xoùa"
        Me.Btnxoa.UseVisualStyleBackColor = True
        '
        'Btnphuchoi
        '
        Me.Btnphuchoi.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnphuchoi.Location = New System.Drawing.Point(3, 116)
        Me.Btnphuchoi.Name = "Btnphuchoi"
        Me.Btnphuchoi.Size = New System.Drawing.Size(119, 51)
        Me.Btnphuchoi.TabIndex = 14
        Me.Btnphuchoi.Text = "Phuïc hoài"
        Me.Btnphuchoi.UseVisualStyleBackColor = True
        '
        'Btnthoat
        '
        Me.Btnthoat.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.Location = New System.Drawing.Point(125, 114)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(119, 51)
        Me.Btnthoat.TabIndex = 15
        Me.Btnthoat.Text = "Thoaùt"
        Me.Btnthoat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Khaki
        Me.Label1.Font = New System.Drawing.Font("VNI-Times", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "THOÂNG TIN NGAØNH"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Btnthoat)
        Me.Panel1.Controls.Add(Me.btnthem)
        Me.Panel1.Controls.Add(Me.Btnphuchoi)
        Me.Panel1.Controls.Add(Me.Btnghi)
        Me.Panel1.Controls.Add(Me.Btnxoa)
        Me.Panel1.Location = New System.Drawing.Point(952, 130)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(247, 167)
        Me.Panel1.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.txtmanganh)
        Me.Panel2.Controls.Add(Me.txttennganh)
        Me.Panel2.Controls.Add(MANGANHLabel)
        Me.Panel2.Controls.Add(Me.txtmakhoa)
        Me.Panel2.Controls.Add(Me.cmbtenkhoa)
        Me.Panel2.Controls.Add(TENKHOALabel)
        Me.Panel2.Location = New System.Drawing.Point(383, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(563, 167)
        Me.Panel2.TabIndex = 18
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(179, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1020, 548)
        Me.Panel4.TabIndex = 20
        '
        'Frmnganh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1142, 710)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvnganh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Frmnganh"
        Me.Text = "Frmnganh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsnganh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvnganh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdskhoa As System.Windows.Forms.BindingSource
    Friend WithEvents cmbtenkhoa As System.Windows.Forms.ComboBox
    Friend WithEvents txtmakhoa As System.Windows.Forms.TextBox
    Friend WithEvents bdsnganh As System.Windows.Forms.BindingSource
    Friend WithEvents NGANHTableAdapter As QUANLYDIEMSV.DSTableAdapters.NGANHTableAdapter
    Friend WithEvents dgvnganh As System.Windows.Forms.DataGridView
    Friend WithEvents txtmanganh As System.Windows.Forms.TextBox
    Friend WithEvents txttennganh As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Btnghi As System.Windows.Forms.Button
    Friend WithEvents Btnxoa As System.Windows.Forms.Button
    Friend WithEvents Btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
