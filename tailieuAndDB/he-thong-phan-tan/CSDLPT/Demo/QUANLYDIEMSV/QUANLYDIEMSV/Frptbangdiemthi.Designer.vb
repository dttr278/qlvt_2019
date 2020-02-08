<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frptbangdiemthi
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
        Dim TENMONLabel As System.Windows.Forms.Label
        Dim MAMONLabel As System.Windows.Forms.Label
        Dim LANLabel As System.Windows.Forms.Label
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdslop = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.cmbmalop = New System.Windows.Forms.ComboBox
        Me.txttenlop = New System.Windows.Forms.TextBox
        Me.bdsmonhoc = New System.Windows.Forms.BindingSource(Me.components)
        Me.MONHOCTableAdapter = New QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
        Me.cmbtenmon = New System.Windows.Forms.ComboBox
        Me.txtmamon = New System.Windows.Forms.TextBox
        Me.cmblan = New System.Windows.Forms.ComboBox
        Me.Crptv_bangdiemthi = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rpt_BANGDIEMTHI1 = New QUANLYDIEMSV.rpt_BANGDIEMTHI
        Me.Btnpreview = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        MALOPLabel = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        TENMONLabel = New System.Windows.Forms.Label
        MAMONLabel = New System.Windows.Forms.Label
        LANLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(12, 38)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(59, 21)
        MALOPLabel.TabIndex = 1
        MALOPLabel.Text = "Maõ lôùp"
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLOPLabel.Location = New System.Drawing.Point(439, 41)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(63, 21)
        TENLOPLabel.TabIndex = 3
        TENLOPLabel.Text = "Teân lôùp"
        '
        'TENMONLabel
        '
        TENMONLabel.AutoSize = True
        TENMONLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENMONLabel.Location = New System.Drawing.Point(12, 86)
        TENMONLabel.Name = "TENMONLabel"
        TENMONLabel.Size = New System.Drawing.Size(71, 21)
        TENMONLabel.TabIndex = 5
        TENMONLabel.Text = "Teân moân"
        '
        'MAMONLabel
        '
        MAMONLabel.AutoSize = True
        MAMONLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMONLabel.Location = New System.Drawing.Point(441, 92)
        MAMONLabel.Name = "MAMONLabel"
        MAMONLabel.Size = New System.Drawing.Size(67, 21)
        MAMONLabel.TabIndex = 7
        MAMONLabel.Text = "Maõ moân"
        '
        'LANLabel
        '
        LANLabel.AutoSize = True
        LANLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LANLabel.Location = New System.Drawing.Point(12, 130)
        LANLabel.Name = "LANLabel"
        LANLabel.Size = New System.Drawing.Size(37, 21)
        LANLabel.TabIndex = 9
        LANLabel.Text = "Laàn"
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
        Me.cmbmalop.Location = New System.Drawing.Point(99, 37)
        Me.cmbmalop.Name = "cmbmalop"
        Me.cmbmalop.Size = New System.Drawing.Size(315, 25)
        Me.cmbmalop.TabIndex = 2
        Me.cmbmalop.ValueMember = "TENLOP"
        '
        'txttenlop
        '
        Me.txttenlop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "TENLOP", True))
        Me.txttenlop.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenlop.Location = New System.Drawing.Point(519, 38)
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.ReadOnly = True
        Me.txttenlop.Size = New System.Drawing.Size(197, 24)
        Me.txttenlop.TabIndex = 4
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
        'cmbtenmon
        '
        Me.cmbtenmon.DataSource = Me.bdsmonhoc
        Me.cmbtenmon.DisplayMember = "TENMON"
        Me.cmbtenmon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtenmon.FormattingEnabled = True
        Me.cmbtenmon.Location = New System.Drawing.Point(99, 86)
        Me.cmbtenmon.Name = "cmbtenmon"
        Me.cmbtenmon.Size = New System.Drawing.Size(315, 25)
        Me.cmbtenmon.TabIndex = 6
        Me.cmbtenmon.ValueMember = "MAMON"
        '
        'txtmamon
        '
        Me.txtmamon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsmonhoc, "MAMON", True))
        Me.txtmamon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamon.Location = New System.Drawing.Point(519, 89)
        Me.txtmamon.Name = "txtmamon"
        Me.txtmamon.ReadOnly = True
        Me.txtmamon.Size = New System.Drawing.Size(128, 24)
        Me.txtmamon.TabIndex = 8
        '
        'cmblan
        '
        Me.cmblan.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblan.FormattingEnabled = True
        Me.cmblan.Items.AddRange(New Object() {"1", "2"})
        Me.cmblan.Location = New System.Drawing.Point(99, 130)
        Me.cmblan.Name = "cmblan"
        Me.cmblan.Size = New System.Drawing.Size(121, 25)
        Me.cmblan.TabIndex = 10
        Me.cmblan.Text = "1"
        '
        'Crptv_bangdiemthi
        '
        Me.Crptv_bangdiemthi.ActiveViewIndex = 0
        Me.Crptv_bangdiemthi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crptv_bangdiemthi.Location = New System.Drawing.Point(79, 185)
        Me.Crptv_bangdiemthi.Name = "Crptv_bangdiemthi"
        Me.Crptv_bangdiemthi.ReportSource = Me.rpt_BANGDIEMTHI1
        Me.Crptv_bangdiemthi.Size = New System.Drawing.Size(991, 530)
        Me.Crptv_bangdiemthi.TabIndex = 11
        '
        'rpt_BANGDIEMTHI1
        '
        '
        'Btnpreview
        '
        Me.Btnpreview.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnpreview.Location = New System.Drawing.Point(755, 38)
        Me.Btnpreview.Name = "Btnpreview"
        Me.Btnpreview.Size = New System.Drawing.Size(92, 40)
        Me.Btnpreview.TabIndex = 12
        Me.Btnpreview.Text = "Preview"
        Me.Btnpreview.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(864, 38)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(92, 40)
        Me.Btnexit.TabIndex = 13
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Frptbangdiemthi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 674)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnpreview)
        Me.Controls.Add(Me.Crptv_bangdiemthi)
        Me.Controls.Add(LANLabel)
        Me.Controls.Add(Me.cmblan)
        Me.Controls.Add(MAMONLabel)
        Me.Controls.Add(Me.txtmamon)
        Me.Controls.Add(TENMONLabel)
        Me.Controls.Add(Me.cmbtenmon)
        Me.Controls.Add(TENLOPLabel)
        Me.Controls.Add(Me.txttenlop)
        Me.Controls.Add(MALOPLabel)
        Me.Controls.Add(Me.cmbmalop)
        Me.Name = "Frptbangdiemthi"
        Me.Text = "Frptbangdiemthi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdslop As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents cmbmalop As System.Windows.Forms.ComboBox
    Friend WithEvents txttenlop As System.Windows.Forms.TextBox
    Friend WithEvents bdsmonhoc As System.Windows.Forms.BindingSource
    Friend WithEvents MONHOCTableAdapter As QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents cmbtenmon As System.Windows.Forms.ComboBox
    Friend WithEvents txtmamon As System.Windows.Forms.TextBox
    Friend WithEvents cmblan As System.Windows.Forms.ComboBox
    Friend WithEvents Crptv_bangdiemthi As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt_BANGDIEMTHI1 As QUANLYDIEMSV.rpt_BANGDIEMTHI
    Friend WithEvents Btnpreview As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
End Class
