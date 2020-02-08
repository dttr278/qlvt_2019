<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrptDSLOP1KHOA
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
        Me.DS = New QUANLYDIEMSV.DS
        Me.bdskhoa = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbtenkhoa = New System.Windows.Forms.ComboBox
        Me.txtmakhoa = New System.Windows.Forms.TextBox
        Me.Crptv_DSLOP1KHOA = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rpt_DSLOP_1KHOA1 = New QUANLYDIEMSV.rpt_DSLOP_1KHOA
        Me.Btnpreview = New System.Windows.Forms.Button
        Me.btnexit = New System.Windows.Forms.Button
        TENKHOALabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TENKHOALabel
        '
        TENKHOALabel.AutoSize = True
        TENKHOALabel.Location = New System.Drawing.Point(26, 30)
        TENKHOALabel.Name = "TENKHOALabel"
        TENKHOALabel.Size = New System.Drawing.Size(40, 13)
        TENKHOALabel.TabIndex = 1
        TENKHOALabel.Text = "KHOA:"
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
        Me.cmbtenkhoa.Location = New System.Drawing.Point(98, 26)
        Me.cmbtenkhoa.Name = "cmbtenkhoa"
        Me.cmbtenkhoa.Size = New System.Drawing.Size(261, 25)
        Me.cmbtenkhoa.TabIndex = 2
        Me.cmbtenkhoa.ValueMember = "MAKHOA"
        '
        'txtmakhoa
        '
        Me.txtmakhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "MAKHOA", True))
        Me.txtmakhoa.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.Location = New System.Drawing.Point(399, 27)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.Size = New System.Drawing.Size(99, 24)
        Me.txtmakhoa.TabIndex = 4
        '
        'Crptv_DSLOP1KHOA
        '
        Me.Crptv_DSLOP1KHOA.ActiveViewIndex = 0
        Me.Crptv_DSLOP1KHOA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crptv_DSLOP1KHOA.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crptv_DSLOP1KHOA.Location = New System.Drawing.Point(29, 83)
        Me.Crptv_DSLOP1KHOA.Name = "Crptv_DSLOP1KHOA"
        Me.Crptv_DSLOP1KHOA.ReportSource = Me.rpt_DSLOP_1KHOA1
        Me.Crptv_DSLOP1KHOA.Size = New System.Drawing.Size(791, 299)
        Me.Crptv_DSLOP1KHOA.TabIndex = 5
        '
        'rpt_DSLOP_1KHOA1
        '
        '
        'Btnpreview
        '
        Me.Btnpreview.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnpreview.Location = New System.Drawing.Point(551, 27)
        Me.Btnpreview.Name = "Btnpreview"
        Me.Btnpreview.Size = New System.Drawing.Size(75, 23)
        Me.Btnpreview.TabIndex = 6
        Me.Btnpreview.Text = "Preview"
        Me.Btnpreview.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(672, 27)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 7
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'FrptDSLOP1KHOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 500)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.Btnpreview)
        Me.Controls.Add(Me.Crptv_DSLOP1KHOA)
        Me.Controls.Add(Me.txtmakhoa)
        Me.Controls.Add(TENKHOALabel)
        Me.Controls.Add(Me.cmbtenkhoa)
        Me.Name = "FrptDSLOP1KHOA"
        Me.Text = "FrptDSLOP1KHOA"
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents bdskhoa As System.Windows.Forms.BindingSource
    Friend WithEvents cmbtenkhoa As System.Windows.Forms.ComboBox
    Friend WithEvents txtmakhoa As System.Windows.Forms.TextBox
    Friend WithEvents Crptv_DSLOP1KHOA As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Btnpreview As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents rpt_DSLOP_1KHOA1 As QUANLYDIEMSV.rpt_DSLOP_1KHOA
End Class
