<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmThongBao
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
        Me.txtTb1 = New System.Windows.Forms.TextBox
        Me.txtTb2 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtTb1
        '
        Me.txtTb1.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTb1.Location = New System.Drawing.Point(38, 28)
        Me.txtTb1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTb1.Name = "txtTb1"
        Me.txtTb1.ReadOnly = True
        Me.txtTb1.Size = New System.Drawing.Size(572, 32)
        Me.txtTb1.TabIndex = 0
        '
        'txtTb2
        '
        Me.txtTb2.Font = New System.Drawing.Font("VNI-Times", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTb2.Location = New System.Drawing.Point(38, 102)
        Me.txtTb2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTb2.Name = "txtTb2"
        Me.txtTb2.Size = New System.Drawing.Size(568, 32)
        Me.txtTb2.TabIndex = 1
        Me.txtTb2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("VNI-Times", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(219, 173)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmThongBao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 255)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTb2)
        Me.Controls.Add(Me.txtTb1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmThongBao"
        Me.Text = "frmThongBao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTb1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTb2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
