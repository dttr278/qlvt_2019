<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frpt_DSSVLOP
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
        Me.Crpt_DSSV = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rpt_DSSVLOP1 = New QUANLYDIEMSV.rpt_DSSVLOP
        Me.DS = New QUANLYDIEMSV.DS
        Me.LOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOPTableAdapter = New QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
        Me.cboTENLOP = New System.Windows.Forms.ComboBox
        Me.txtMalop = New System.Windows.Forms.TextBox
        Me.btnThoat = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        TENLOPLabel = New System.Windows.Forms.Label
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TENLOPLabel
        '
        TENLOPLabel.AutoSize = True
        TENLOPLabel.Location = New System.Drawing.Point(24, 19)
        TENLOPLabel.Name = "TENLOPLabel"
        TENLOPLabel.Size = New System.Drawing.Size(53, 13)
        TENLOPLabel.TabIndex = 2
        TENLOPLabel.Text = "TENLOP:"
        '
        'Crpt_DSSV
        '
        Me.Crpt_DSSV.AccessibleDescription = ""
        Me.Crpt_DSSV.ActiveViewIndex = 0
        Me.Crpt_DSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Crpt_DSSV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Crpt_DSSV.Location = New System.Drawing.Point(0, 46)
        Me.Crpt_DSSV.Name = "Crpt_DSSV"
        Me.Crpt_DSSV.ReportSource = Me.rpt_DSSVLOP1
        Me.Crpt_DSSV.Size = New System.Drawing.Size(690, 381)
        Me.Crpt_DSSV.TabIndex = 0
        '
        'rpt_DSSVLOP1
        '
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.EnforceConstraints = False
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LOPBindingSource
        '
        Me.LOPBindingSource.DataMember = "LOP"
        Me.LOPBindingSource.DataSource = Me.DS
        '
        'LOPTableAdapter
        '
        Me.LOPTableAdapter.ClearBeforeFill = True
        '
        'cboTENLOP
        '
        Me.cboTENLOP.DataSource = Me.LOPBindingSource
        Me.cboTENLOP.DisplayMember = "TENLOP"
        Me.cboTENLOP.FormattingEnabled = True
        Me.cboTENLOP.Location = New System.Drawing.Point(83, 16)
        Me.cboTENLOP.Name = "cboTENLOP"
        Me.cboTENLOP.Size = New System.Drawing.Size(214, 21)
        Me.cboTENLOP.TabIndex = 3
        Me.cboTENLOP.ValueMember = "MALOP"
        '
        'txtMalop
        '
        Me.txtMalop.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LOPBindingSource, "MALOP", True))
        Me.txtMalop.Location = New System.Drawing.Point(329, 17)
        Me.txtMalop.Name = "txtMalop"
        Me.txtMalop.ReadOnly = True
        Me.txtMalop.Size = New System.Drawing.Size(100, 20)
        Me.txtMalop.TabIndex = 4
        '
        'btnThoat
        '
        Me.btnThoat.Location = New System.Drawing.Point(552, 17)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(75, 23)
        Me.btnThoat.TabIndex = 5
        Me.btnThoat.Text = "Thoat"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(462, 17)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(75, 23)
        Me.btnPreview.TabIndex = 6
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(638, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(51, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "0"
        '
        'Frpt_DSSVLOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 427)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.txtMalop)
        Me.Controls.Add(TENLOPLabel)
        Me.Controls.Add(Me.cboTENLOP)
        Me.Controls.Add(Me.Crpt_DSSV)
        Me.Name = "Frpt_DSSVLOP"
        Me.Text = "Frpt_DSSVLOP"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Crpt_DSSV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rpt_DSSVLOP1 As QUANLYDIEMSV.rpt_DSSVLOP
    Friend WithEvents DS As QUANLYDIEMSV.DS
    Friend WithEvents LOPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOPTableAdapter As QUANLYDIEMSV.DSTableAdapters.LOPTableAdapter
    Friend WithEvents cboTENLOP As System.Windows.Forms.ComboBox
    Friend WithEvents txtMalop As System.Windows.Forms.TextBox
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
