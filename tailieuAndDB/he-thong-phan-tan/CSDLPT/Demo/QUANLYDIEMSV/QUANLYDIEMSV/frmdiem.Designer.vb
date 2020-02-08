<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdiem
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
        Dim MALOPLabel As System.Windows.Forms.Label
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim LANLabel As System.Windows.Forms.Label
        Dim MAMONLabel As System.Windows.Forms.Label
        Dim TENMONLabel As System.Windows.Forms.Label
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdslop = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.cmbmalop = New System.Windows.Forms.ComboBox
        Me.txttenlop = New System.Windows.Forms.TextBox
        Me.cmblan = New System.Windows.Forms.ComboBox
        Me.MONHOCTableAdapter = New QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
        Me.bdsmonhoc = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbtenmon = New System.Windows.Forms.ComboBox
        Me.txtmamon = New System.Windows.Forms.TextBox
        Me.BtnBatDau = New System.Windows.Forms.Button
        Me.BtnGhi = New System.Windows.Forms.Button
        Me.dgv_Diem = New System.Windows.Forms.DataGridView
        Me.Btnthoat = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbHocky = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        MALOPLabel = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        LANLabel = New System.Windows.Forms.Label
        MAMONLabel = New System.Windows.Forms.Label
        TENMONLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Diem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(17, 22)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(57, 21)
        MALOPLabel.TabIndex = 1
        MALOPLabel.Text = "Maõ lôùp"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLOPLabel.Location = New System.Drawing.Point(17, 69)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(61, 21)
        TENLOPLabel.TabIndex = 3
        TENLOPLabel.Text = "Teân lôùp"
        '
        'LANLabel
        '
        LANLabel.AutoSize = True
        LANLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LANLabel.Location = New System.Drawing.Point(271, 160)
        LANLabel.Name = "LANLabel"
        LANLabel.Size = New System.Drawing.Size(36, 21)
        LANLabel.TabIndex = 5
        LANLabel.Text = "Laàn"
        '
        'MAMONLabel
        '
        MAMONLabel.AutoSize = True
        MAMONLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMONLabel.Location = New System.Drawing.Point(18, 154)
        MAMONLabel.Name = "MAMONLabel"
        MAMONLabel.Size = New System.Drawing.Size(65, 21)
        MAMONLabel.TabIndex = 7
        MAMONLabel.Text = "Maõ moân"
        '
        'TENMONLabel
        '
        TENMONLabel.AutoSize = True
        TENMONLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENMONLabel.Location = New System.Drawing.Point(16, 113)
        TENMONLabel.Name = "TENMONLabel"
        TENMONLabel.Size = New System.Drawing.Size(69, 21)
        TENMONLabel.TabIndex = 9
        TENMONLabel.Text = "Teân moân"
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
        'cmbmalop
        '
        Me.cmbmalop.DataSource = Me.bdslop
        Me.cmbmalop.DisplayMember = "MALOP"
        Me.cmbmalop.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmalop.FormattingEnabled = True
        Me.cmbmalop.Location = New System.Drawing.Point(124, 20)
        Me.cmbmalop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbmalop.Name = "cmbmalop"
        Me.cmbmalop.Size = New System.Drawing.Size(141, 25)
        Me.cmbmalop.TabIndex = 2
        Me.cmbmalop.ValueMember = "TENLOP"
        '
        'txttenlop
        '
        Me.txttenlop.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenlop.Location = New System.Drawing.Point(124, 68)
        Me.txttenlop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.ReadOnly = True
        Me.txttenlop.Size = New System.Drawing.Size(256, 24)
        Me.txttenlop.TabIndex = 4
        '
        'cmblan
        '
        Me.cmblan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmblan.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblan.FormattingEnabled = True
        Me.cmblan.Items.AddRange(New Object() {"1", "2"})
        Me.cmblan.Location = New System.Drawing.Point(324, 154)
        Me.cmblan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmblan.Name = "cmblan"
        Me.cmblan.Size = New System.Drawing.Size(56, 25)
        Me.cmblan.TabIndex = 6
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'bdsmonhoc
        '
        Me.bdsmonhoc.DataMember = "MONHOC"
        Me.bdsmonhoc.DataSource = Me.DS
        '
        'cmbtenmon
        '
        Me.cmbtenmon.DataSource = Me.bdsmonhoc
        Me.cmbtenmon.DisplayMember = "TENMON"
        Me.cmbtenmon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtenmon.FormattingEnabled = True
        Me.cmbtenmon.Location = New System.Drawing.Point(124, 113)
        Me.cmbtenmon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbtenmon.Name = "cmbtenmon"
        Me.cmbtenmon.Size = New System.Drawing.Size(256, 25)
        Me.cmbtenmon.TabIndex = 16
        Me.cmbtenmon.ValueMember = "MAMON"
        '
        'txtmamon
        '
        Me.txtmamon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamon.Location = New System.Drawing.Point(124, 156)
        Me.txtmamon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtmamon.Name = "txtmamon"
        Me.txtmamon.ReadOnly = True
        Me.txtmamon.Size = New System.Drawing.Size(128, 24)
        Me.txtmamon.TabIndex = 17
        '
        'BtnBatDau
        '
        Me.BtnBatDau.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBatDau.Location = New System.Drawing.Point(638, 81)
        Me.BtnBatDau.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnBatDau.Name = "BtnBatDau"
        Me.BtnBatDau.Size = New System.Drawing.Size(120, 41)
        Me.BtnBatDau.TabIndex = 22
        Me.BtnBatDau.Text = "Baét ñaàu"
        Me.BtnBatDau.UseVisualStyleBackColor = True
        '
        'BtnGhi
        '
        Me.BtnGhi.Enabled = False
        Me.BtnGhi.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGhi.Location = New System.Drawing.Point(638, 181)
        Me.BtnGhi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnGhi.Name = "BtnGhi"
        Me.BtnGhi.Size = New System.Drawing.Size(120, 41)
        Me.BtnGhi.TabIndex = 23
        Me.BtnGhi.Text = "Ghi"
        Me.BtnGhi.UseVisualStyleBackColor = True
        '
        'dgv_Diem
        '
        Me.dgv_Diem.AllowUserToAddRows = False
        Me.dgv_Diem.AllowUserToDeleteRows = False
        Me.dgv_Diem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Diem.Location = New System.Drawing.Point(189, 333)
        Me.dgv_Diem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv_Diem.Name = "dgv_Diem"
        Me.dgv_Diem.Size = New System.Drawing.Size(569, 184)
        Me.dgv_Diem.TabIndex = 23
        Me.dgv_Diem.Visible = False
        '
        'Btnthoat
        '
        Me.Btnthoat.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.Location = New System.Drawing.Point(638, 274)
        Me.Btnthoat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(120, 41)
        Me.Btnthoat.TabIndex = 30
        Me.Btnthoat.Text = "Thoaùt"
        Me.Btnthoat.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbHocky)
        Me.GroupBox1.Controls.Add(Me.txtmamon)
        Me.GroupBox1.Controls.Add(Me.cmbtenmon)
        Me.GroupBox1.Controls.Add(TENMONLabel)
        Me.GroupBox1.Controls.Add(MAMONLabel)
        Me.GroupBox1.Controls.Add(LANLabel)
        Me.GroupBox1.Controls.Add(Me.cmblan)
        Me.GroupBox1.Controls.Add(TENLOPLabel)
        Me.GroupBox1.Controls.Add(Me.txttenlop)
        Me.GroupBox1.Controls.Add(MALOPLabel)
        Me.GroupBox1.Controls.Add(Me.cmbmalop)
        Me.GroupBox1.Location = New System.Drawing.Point(189, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(396, 247)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Hoc ky"
        '
        'cmbHocky
        '
        Me.cmbHocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHocky.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHocky.FormattingEnabled = True
        Me.cmbHocky.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cmbHocky.Location = New System.Drawing.Point(124, 201)
        Me.cmbHocky.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbHocky.Name = "cmbHocky"
        Me.cmbHocky.Size = New System.Drawing.Size(126, 25)
        Me.cmbHocky.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("VNI-Times", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(199, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 28)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "CAÄP NHAÄT ÑIEÅM MOÂN HOÏC"
        '
        'frmdiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 568)
        Me.Controls.Add(Me.Btnthoat)
        Me.Controls.Add(Me.BtnGhi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnBatDau)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_Diem)
        Me.Font = New System.Drawing.Font("VNI-Times", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmdiem"
        Me.Text = "frmdiem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Diem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdslop As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents cmbmalop As System.Windows.Forms.ComboBox
    Friend WithEvents txttenlop As System.Windows.Forms.TextBox
    Friend WithEvents cmblan As System.Windows.Forms.ComboBox
    Friend WithEvents MONHOCTableAdapter As QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents bdsmonhoc As System.Windows.Forms.BindingSource
    Friend WithEvents cmbtenmon As System.Windows.Forms.ComboBox
    Friend WithEvents txtmamon As System.Windows.Forms.TextBox
    Friend WithEvents BtnBatDau As System.Windows.Forms.Button
    Friend WithEvents BtnGhi As System.Windows.Forms.Button
    Friend WithEvents dgv_Diem As System.Windows.Forms.DataGridView
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbHocky As System.Windows.Forms.ComboBox
End Class
