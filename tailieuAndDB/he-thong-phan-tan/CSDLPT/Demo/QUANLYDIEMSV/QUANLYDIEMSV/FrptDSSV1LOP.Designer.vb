<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrptDSSV1LOP
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
        Dim TENLOPLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrptDSSV1LOP))
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdslop = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.cmbtenlop = New System.Windows.Forms.ComboBox
        Me.txtmalop = New System.Windows.Forms.TextBox
        Me.Crptv_DSSV1LOP = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rpt_DSSV_1Lop1 = New QUANLYDIEMSV.rpt_DSSV_1LOP
        Me.Btnpreview = New System.Windows.Forms.Button
        Me.Btnexit = New System.Windows.Forms.Button
        TENLOPLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        TENLOPLabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENLOPLabel.Location = New System.Drawing.Point(175, 50)
        TENLOPLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(44, 26)
        TENLOPLabel.TabIndex = 1
        TENLOPLabel.Text = "Lôùp"
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
        'cmbtenlop
        '
        Me.cmbtenlop.DataSource = Me.bdslop
        Me.cmbtenlop.DisplayMember = "TENLOP"
        Me.cmbtenlop.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtenlop.FormattingEnabled = True
        Me.cmbtenlop.Location = New System.Drawing.Point(253, 47)
        Me.cmbtenlop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbtenlop.Name = "cmbtenlop"
        Me.cmbtenlop.Size = New System.Drawing.Size(448, 34)
        Me.cmbtenlop.TabIndex = 2
        Me.cmbtenlop.ValueMember = "MALOP"
        '
        'txtmalop
        '
        Me.txtmalop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdslop, "MALOP", True))
        Me.txtmalop.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmalop.Location = New System.Drawing.Point(711, 47)
        Me.txtmalop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmalop.Name = "txtmalop"
        Me.txtmalop.Size = New System.Drawing.Size(156, 34)
        Me.txtmalop.TabIndex = 4
        '
        'Crptv_DSSV1LOP
        '
        Me.Crptv_DSSV1LOP.ActiveViewIndex = 0
        Me.Crptv_DSSV1LOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crptv_DSSV1LOP.Location = New System.Drawing.Point(31, 90)
        Me.Crptv_DSSV1LOP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Crptv_DSSV1LOP.Name = "Crptv_DSSV1LOP"
        Me.Crptv_DSSV1LOP.ReportSource = Me.rpt_DSSV_1Lop1
        Me.Crptv_DSSV1LOP.Size = New System.Drawing.Size(1613, 699)
        Me.Crptv_DSSV1LOP.TabIndex = 5
        '
        'rpt_DSSV_1Lop1
        '
        '
        'Btnpreview
        '
        Me.Btnpreview.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnpreview.Location = New System.Drawing.Point(917, 47)
        Me.Btnpreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnpreview.Name = "Btnpreview"
        Me.Btnpreview.Size = New System.Drawing.Size(115, 39)
        Me.Btnpreview.TabIndex = 6
        Me.Btnpreview.Text = "Preview"
        Me.Btnpreview.UseVisualStyleBackColor = True
        '
        'Btnexit
        '
        Me.Btnexit.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(1080, 48)
        Me.Btnexit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(115, 39)
        Me.Btnexit.TabIndex = 7
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'FrptDSSV1LOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1018, 735)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnpreview)
        Me.Controls.Add(Me.Crptv_DSSV1LOP)
        Me.Controls.Add(Me.txtmalop)
        Me.Controls.Add(TENLOPLabel)
        Me.Controls.Add(Me.cmbtenlop)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrptDSSV1LOP"
        Me.Text = "FrptDSSV1LOP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdslop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdslop As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents cmbtenlop As System.Windows.Forms.ComboBox
    Friend WithEvents txtmalop As System.Windows.Forms.TextBox
    Friend WithEvents Crptv_DSSV1LOP As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt_DSSV_1Lop1 As QUANLYDIEMSV.rpt_DSSV_1Lop
    Friend WithEvents Btnpreview As System.Windows.Forms.Button
    Friend WithEvents Btnexit As System.Windows.Forms.Button
End Class
