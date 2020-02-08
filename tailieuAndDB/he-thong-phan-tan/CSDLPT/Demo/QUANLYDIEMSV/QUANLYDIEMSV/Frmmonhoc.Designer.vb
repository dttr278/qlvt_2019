<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmonhoc
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
        Dim MAMONLabel As System.Windows.Forms.Label
        Dim TENMONLabel As System.Windows.Forms.Label
        Dim SOTIET_LTLabel As System.Windows.Forms.Label
        Dim SOTIET_THLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmonhoc))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdsmonhoc = New System.Windows.Forms.BindingSource(Me.components)
        Me.MONHOCTableAdapter = New QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
        Me.txtmamon = New System.Windows.Forms.TextBox
        Me.txttenmon = New System.Windows.Forms.TextBox
        Me.txtsotiet_lt = New System.Windows.Forms.TextBox
        Me.txtsotiet_th = New System.Windows.Forms.TextBox
        Me.Btnthem = New System.Windows.Forms.Button
        Me.btnghi = New System.Windows.Forms.Button
        Me.btnxoa = New System.Windows.Forms.Button
        Me.Btnphuchoi = New System.Windows.Forms.Button
        Me.Btnthoat = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgvmonhoc = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        MAMONLabel = New System.Windows.Forms.Label
        TENMONLabel = New System.Windows.Forms.Label
        SOTIET_LTLabel = New System.Windows.Forms.Label
        SOTIET_THLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvmonhoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAMONLabel
        '
        MAMONLabel.AutoSize = True
        MAMONLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMONLabel.Location = New System.Drawing.Point(5, 46)
        MAMONLabel.Name = "MAMONLabel"
        MAMONLabel.Size = New System.Drawing.Size(63, 20)
        MAMONLabel.TabIndex = 1
        MAMONLabel.Text = "Maõ moân"
        '
        'TENMONLabel
        '
        TENMONLabel.AutoSize = True
        TENMONLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENMONLabel.Location = New System.Drawing.Point(3, 96)
        TENMONLabel.Name = "TENMONLabel"
        TENMONLabel.Size = New System.Drawing.Size(68, 20)
        TENMONLabel.TabIndex = 3
        TENMONLabel.Text = "Teân moân"
        '
        'SOTIET_LTLabel
        '
        SOTIET_LTLabel.AutoSize = True
        SOTIET_LTLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOTIET_LTLabel.Location = New System.Drawing.Point(5, 183)
        SOTIET_LTLabel.Name = "SOTIET_LTLabel"
        SOTIET_LTLabel.Size = New System.Drawing.Size(79, 20)
        SOTIET_LTLabel.TabIndex = 5
        SOTIET_LTLabel.Text = "Soá tieát LT"
        '
        'SOTIET_THLabel
        '
        SOTIET_THLabel.AutoSize = True
        SOTIET_THLabel.Font = New System.Drawing.Font("VNI-Ariston", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SOTIET_THLabel.Location = New System.Drawing.Point(5, 134)
        SOTIET_THLabel.Name = "SOTIET_THLabel"
        SOTIET_THLabel.Size = New System.Drawing.Size(84, 20)
        SOTIET_THLabel.TabIndex = 7
        SOTIET_THLabel.Text = "Soá tieát TH"
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdsmonhoc
        '
        Me.bdsmonhoc.DataMember = "MONHOC"
        Me.bdsmonhoc.DataSource = Me.DS
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'txtmamon
        '
        Me.txtmamon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsmonhoc, "MAMON", True))
        Me.txtmamon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamon.Location = New System.Drawing.Point(114, 46)
        Me.txtmamon.Name = "txtmamon"
        Me.txtmamon.Size = New System.Drawing.Size(100, 24)
        Me.txtmamon.TabIndex = 2
        '
        'txttenmon
        '
        Me.txttenmon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsmonhoc, "TENMON", True))
        Me.txttenmon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenmon.Location = New System.Drawing.Point(115, 96)
        Me.txttenmon.Name = "txttenmon"
        Me.txttenmon.Size = New System.Drawing.Size(323, 24)
        Me.txttenmon.TabIndex = 4
        '
        'txtsotiet_lt
        '
        Me.txtsotiet_lt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsmonhoc, "SOTIET_LT", True))
        Me.txtsotiet_lt.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsotiet_lt.Location = New System.Drawing.Point(115, 183)
        Me.txtsotiet_lt.Name = "txtsotiet_lt"
        Me.txtsotiet_lt.Size = New System.Drawing.Size(141, 24)
        Me.txtsotiet_lt.TabIndex = 6
        '
        'txtsotiet_th
        '
        Me.txtsotiet_th.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsmonhoc, "SOTIET_TH", True))
        Me.txtsotiet_th.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsotiet_th.Location = New System.Drawing.Point(115, 134)
        Me.txtsotiet_th.Name = "txtsotiet_th"
        Me.txtsotiet_th.Size = New System.Drawing.Size(141, 24)
        Me.txtsotiet_th.TabIndex = 8
        '
        'Btnthem
        '
        Me.Btnthem.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Btnthem.Font = New System.Drawing.Font("VNI-Times", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthem.Image = CType(resources.GetObject("Btnthem.Image"), System.Drawing.Image)
        Me.Btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnthem.Location = New System.Drawing.Point(636, 116)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(143, 62)
        Me.Btnthem.TabIndex = 10
        Me.Btnthem.Text = "Theâm"
        Me.Btnthem.UseVisualStyleBackColor = False
        '
        'btnghi
        '
        Me.btnghi.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnghi.Font = New System.Drawing.Font("VNI-Times", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnghi.Image = CType(resources.GetObject("btnghi.Image"), System.Drawing.Image)
        Me.btnghi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnghi.Location = New System.Drawing.Point(795, 116)
        Me.btnghi.Name = "btnghi"
        Me.btnghi.Size = New System.Drawing.Size(143, 62)
        Me.btnghi.TabIndex = 11
        Me.btnghi.Text = "Ghi"
        Me.btnghi.UseVisualStyleBackColor = False
        '
        'btnxoa
        '
        Me.btnxoa.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.btnxoa.Font = New System.Drawing.Font("VNI-Times", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnxoa.Image = CType(resources.GetObject("btnxoa.Image"), System.Drawing.Image)
        Me.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnxoa.Location = New System.Drawing.Point(636, 206)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(143, 62)
        Me.btnxoa.TabIndex = 12
        Me.btnxoa.Text = "Xoùa"
        Me.btnxoa.UseVisualStyleBackColor = False
        '
        'Btnphuchoi
        '
        Me.Btnphuchoi.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Btnphuchoi.Font = New System.Drawing.Font("VNI-Times", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnphuchoi.Image = CType(resources.GetObject("Btnphuchoi.Image"), System.Drawing.Image)
        Me.Btnphuchoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btnphuchoi.Location = New System.Drawing.Point(795, 206)
        Me.Btnphuchoi.Name = "Btnphuchoi"
        Me.Btnphuchoi.Size = New System.Drawing.Size(143, 62)
        Me.Btnphuchoi.TabIndex = 13
        Me.Btnphuchoi.Text = "Phuïc hoài"
        Me.Btnphuchoi.UseVisualStyleBackColor = False
        '
        'Btnthoat
        '
        Me.Btnthoat.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.Btnthoat.Font = New System.Drawing.Font("VNI-Times", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.Image = CType(resources.GetObject("Btnthoat.Image"), System.Drawing.Image)
        Me.Btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btnthoat.Location = New System.Drawing.Point(715, 303)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(142, 62)
        Me.Btnthoat.TabIndex = 14
        Me.Btnthoat.Text = "Thoaùt"
        Me.Btnthoat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "THOÂNG TIN VEÀ MOÂN HOÏC"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(SOTIET_THLabel)
        Me.Panel1.Controls.Add(Me.txtsotiet_lt)
        Me.Panel1.Controls.Add(Me.txtsotiet_th)
        Me.Panel1.Controls.Add(SOTIET_LTLabel)
        Me.Panel1.Controls.Add(TENMONLabel)
        Me.Panel1.Controls.Add(Me.txttenmon)
        Me.Panel1.Controls.Add(MAMONLabel)
        Me.Panel1.Controls.Add(Me.txtmamon)
        Me.Panel1.Location = New System.Drawing.Point(157, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 257)
        Me.Panel1.TabIndex = 17
        '
        'dgvmonhoc
        '
        Me.dgvmonhoc.AllowUserToAddRows = False
        Me.dgvmonhoc.AllowUserToDeleteRows = False
        Me.dgvmonhoc.AutoGenerateColumns = False
        Me.dgvmonhoc.BackgroundColor = System.Drawing.Color.PowderBlue
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvmonhoc.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvmonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmonhoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dgvmonhoc.DataSource = Me.bdsmonhoc
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("VNI-Bodon-Poster", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvmonhoc.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvmonhoc.Location = New System.Drawing.Point(157, 423)
        Me.dgvmonhoc.Name = "dgvmonhoc"
        Me.dgvmonhoc.ReadOnly = True
        Me.dgvmonhoc.Size = New System.Drawing.Size(674, 284)
        Me.dgvmonhoc.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAMON"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ moân"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 110
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TENMON"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("VNI-Bodon-Poster", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Teân moân"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SOTIET_LT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Soá tieát LT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SOTIET_TH"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Soá tieát TH"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "DANH MUÏC CAÙC MOÂN HOÏC"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(157, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 25)
        Me.Panel2.TabIndex = 18
        '
        'Frmmonhoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1255, 752)
        Me.Controls.Add(Me.Btnthoat)
        Me.Controls.Add(Me.Btnphuchoi)
        Me.Controls.Add(Me.btnghi)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.dgvmonhoc)
        Me.Controls.Add(Me.Btnthem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frmmonhoc"
        Me.Text = "Frmmonhoc"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvmonhoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdsmonhoc As System.Windows.Forms.BindingSource
    Friend WithEvents MONHOCTableAdapter As QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents txtmamon As System.Windows.Forms.TextBox
    Friend WithEvents txttenmon As System.Windows.Forms.TextBox
    Friend WithEvents txtsotiet_lt As System.Windows.Forms.TextBox
    Friend WithEvents txtsotiet_th As System.Windows.Forms.TextBox
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents btnghi As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents Btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvmonhoc As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
