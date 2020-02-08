<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frptbangdiemmh
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
        Dim HOCKYLabel As System.Windows.Forms.Label
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdslop = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.bdsmonhoc = New System.Windows.Forms.BindingSource(Me.components)
        Me.MONHOCTableAdapter = New QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
        Me.Crptv_BDMH = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rpt_BDMH1 = New QUANLYDIEMSV.rpt_BDMH
        Me.cmbmalop = New System.Windows.Forms.ComboBox
        Me.txttenlop = New System.Windows.Forms.TextBox
        Me.cmbtenmon = New System.Windows.Forms.ComboBox
        Me.txtmamon = New System.Windows.Forms.TextBox
        Me.cmbLan = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnpreview = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        MALOPLabel = New System.Windows.Forms.Label
        TENLOPLabel = New System.Windows.Forms.Label
        TENMONLabel = New System.Windows.Forms.Label
        MAMONLabel = New System.Windows.Forms.Label
        HOCKYLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'bdsmonhoc
        '
        Me.bdsmonhoc.DataMember = "MONHOC"
        Me.bdsmonhoc.DataSource = Me.DS
        '
        'MONHOCTableAdapter
        '
        Me.MONHOCTableAdapter.ClearBeforeFill = True
        '
        'Crptv_BDMH
        '
        Me.Crptv_BDMH.ActiveViewIndex = 0
        Me.Crptv_BDMH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crptv_BDMH.Location = New System.Drawing.Point(115, 227)
        Me.Crptv_BDMH.Name = "Crptv_BDMH"
        Me.Crptv_BDMH.ReportSource = Me.rpt_BDMH1
        Me.Crptv_BDMH.Size = New System.Drawing.Size(1016, 512)
        Me.Crptv_BDMH.TabIndex = 11
        '
        'rpt_BDMH1
        '
        '
        'cmbmalop
        '
        Me.cmbmalop.DataSource = Me.bdslop
        Me.cmbmalop.DisplayMember = "MALOP"
        Me.cmbmalop.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbmalop.FormattingEnabled = True
        Me.cmbmalop.Location = New System.Drawing.Point(87, 15)
        Me.cmbmalop.Name = "cmbmalop"
        Me.cmbmalop.Size = New System.Drawing.Size(212, 26)
        Me.cmbmalop.TabIndex = 2
        Me.cmbmalop.ValueMember = "TENLOP"
        '
        'MALOPLabel
        '
        MALOPLabel.AutoSize = True
        MALOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MALOPLabel.Location = New System.Drawing.Point(10, 18)
        MALOPLabel.Name = "MALOPLabel"
        MALOPLabel.Size = New System.Drawing.Size(60, 21)
        MALOPLabel.TabIndex = 1
        MALOPLabel.Text = "Maõ lôùp"
        '
        'txttenlop
        '
        Me.txttenlop.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenlop.Location = New System.Drawing.Point(468, 19)
        Me.txttenlop.Name = "txttenlop"
        Me.txttenlop.ReadOnly = True
        Me.txttenlop.Size = New System.Drawing.Size(315, 25)
        Me.txttenlop.TabIndex = 4
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLOPLabel.Location = New System.Drawing.Point(363, 21)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(65, 21)
        TENLOPLabel.TabIndex = 3
        TENLOPLabel.Text = "Teân lôùp"
        '
        'cmbtenmon
        '
        Me.cmbtenmon.DataSource = Me.bdsmonhoc
        Me.cmbtenmon.DisplayMember = "TENMON"
        Me.cmbtenmon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtenmon.FormattingEnabled = True
        Me.cmbtenmon.Location = New System.Drawing.Point(87, 52)
        Me.cmbtenmon.Name = "cmbtenmon"
        Me.cmbtenmon.Size = New System.Drawing.Size(212, 26)
        Me.cmbtenmon.TabIndex = 6
        Me.cmbtenmon.ValueMember = "MAMON"
        '
        'TENMONLabel
        '
        TENMONLabel.AutoSize = True
        TENMONLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENMONLabel.Location = New System.Drawing.Point(10, 60)
        TENMONLabel.Name = "TENMONLabel"
        TENMONLabel.Size = New System.Drawing.Size(74, 21)
        TENMONLabel.TabIndex = 5
        TENMONLabel.Text = "Teân moân"
        '
        'txtmamon
        '
        Me.txtmamon.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmamon.Location = New System.Drawing.Point(468, 51)
        Me.txtmamon.Name = "txtmamon"
        Me.txtmamon.ReadOnly = True
        Me.txtmamon.Size = New System.Drawing.Size(156, 25)
        Me.txtmamon.TabIndex = 8
        '
        'MAMONLabel
        '
        MAMONLabel.AutoSize = True
        MAMONLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAMONLabel.Location = New System.Drawing.Point(365, 54)
        MAMONLabel.Name = "MAMONLabel"
        MAMONLabel.Size = New System.Drawing.Size(69, 21)
        MAMONLabel.TabIndex = 7
        MAMONLabel.Text = "Maõ moân"
        '
        'cmbLan
        '
        Me.cmbLan.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLan.FormattingEnabled = True
        Me.cmbLan.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cmbLan.Location = New System.Drawing.Point(88, 82)
        Me.cmbLan.Name = "cmbLan"
        Me.cmbLan.Size = New System.Drawing.Size(121, 26)
        Me.cmbLan.TabIndex = 10
        Me.cmbLan.Text = "1"
        '
        'HOCKYLabel
        '
        HOCKYLabel.AutoSize = True
        HOCKYLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HOCKYLabel.Location = New System.Drawing.Point(10, 90)
        HOCKYLabel.Name = "HOCKYLabel"
        HOCKYLabel.Size = New System.Drawing.Size(39, 21)
        HOCKYLabel.TabIndex = 9
        HOCKYLabel.Text = "Laàn"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(HOCKYLabel)
        Me.GroupBox1.Controls.Add(Me.cmbLan)
        Me.GroupBox1.Controls.Add(MAMONLabel)
        Me.GroupBox1.Controls.Add(Me.txtmamon)
        Me.GroupBox1.Controls.Add(TENMONLabel)
        Me.GroupBox1.Controls.Add(Me.cmbtenmon)
        Me.GroupBox1.Controls.Add(TENLOPLabel)
        Me.GroupBox1.Controls.Add(Me.txttenlop)
        Me.GroupBox1.Controls.Add(MALOPLabel)
        Me.GroupBox1.Controls.Add(Me.cmbmalop)
        Me.GroupBox1.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 135)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NUÙT CHOÏN"
        '
        'btnpreview
        '
        Me.btnpreview.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreview.Location = New System.Drawing.Point(21, 20)
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(90, 41)
        Me.btnpreview.TabIndex = 12
        Me.btnpreview.Text = "Preview"
        Me.btnpreview.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(147, 20)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(90, 41)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnpreview)
        Me.GroupBox2.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(863, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 76)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NUÙT LEÄNH"
        '
        'Frptbangdiemmh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1224, 778)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Crptv_BDMH)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "Frptbangdiemmh"
        Me.Text = "Frptbangdiemmh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsmonhoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdslop As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents bdsmonhoc As System.Windows.Forms.BindingSource
    Friend WithEvents MONHOCTableAdapter As QUANLYDIEMSV.DSTableAdapters.MONHOCTableAdapter
    Friend WithEvents Crptv_BDMH As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt_BDMH1 As QUANLYDIEMSV.rpt_BDMH
    Friend WithEvents cmbmalop As System.Windows.Forms.ComboBox
    Friend WithEvents txttenlop As System.Windows.Forms.TextBox
    Friend WithEvents cmbtenmon As System.Windows.Forms.ComboBox
    Friend WithEvents txtmamon As System.Windows.Forms.TextBox
    Friend WithEvents cmbLan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpreview As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
