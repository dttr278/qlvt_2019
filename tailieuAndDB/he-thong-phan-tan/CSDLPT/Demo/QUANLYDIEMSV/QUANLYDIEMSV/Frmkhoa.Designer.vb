<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmkhoa
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
        Dim MAKHOALabel As System.Windows.Forms.Label
        Dim TENKHOALabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmkhoa))
        Me.OdbcSelectCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcConnection1 = New System.Data.Odbc.OdbcConnection
        Me.OdbcInsertCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcUpdateCommand1 = New System.Data.Odbc.OdbcCommand
        Me.OdbcDeleteCommand1 = New System.Data.Odbc.OdbcCommand
        Me.DA = New System.Data.Odbc.OdbcDataAdapter
        Me.Ds1 = New QUANLYDIEMSV.DS
        Me.bdskhoa = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvkhoa = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtmakhoa = New System.Windows.Forms.TextBox
        Me.txttenkhoa = New System.Windows.Forms.TextBox
        Me.Btnthem = New System.Windows.Forms.Button
        Me.Btnghi = New System.Windows.Forms.Button
        Me.Btnxoa = New System.Windows.Forms.Button
        Me.Btnphuchoi = New System.Windows.Forms.Button
        Me.Btnthoat = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        MAKHOALabel = New System.Windows.Forms.Label
        TENKHOALabel = New System.Windows.Forms.Label
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvkhoa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAKHOALabel
        '
        MAKHOALabel.AutoSize = True
        MAKHOALabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MAKHOALabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        MAKHOALabel.Location = New System.Drawing.Point(17, 42)
        MAKHOALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        MAKHOALabel.Name = "MAKHOALabel"
        MAKHOALabel.Size = New System.Drawing.Size(85, 26)
        MAKHOALabel.TabIndex = 1
        MAKHOALabel.Text = "Maõ khoa"
        '
        'TENKHOALabel
        '
        TENKHOALabel.AutoSize = True
        TENKHOALabel.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TENKHOALabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        TENKHOALabel.Location = New System.Drawing.Point(17, 85)
        TENKHOALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TENKHOALabel.Name = "TENKHOALabel"
        TENKHOALabel.Size = New System.Drawing.Size(89, 26)
        TENKHOALabel.TabIndex = 3
        TENKHOALabel.Text = "Teân khoa"
        '
        'OdbcSelectCommand1
        '
        Me.OdbcSelectCommand1.CommandText = "SELECT     MAKHOA, TENKHOA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         KHOA"
        Me.OdbcSelectCommand1.Connection = Me.OdbcConnection1
        '
        'OdbcConnection1
        '
        Me.OdbcConnection1.ConnectionString = "Dsn=QUANLYDIEMSV;uid=SA;app=Microsoft® Visual Studio® 2008;wsid=CTY;database=QUAN" & _
            "LYDIEMSV"
        '
        'OdbcInsertCommand1
        '
        Me.OdbcInsertCommand1.CommandText = "INSERT INTO [KHOA] ([MAKHOA], [TENKHOA]) VALUES (?, ?)"
        Me.OdbcInsertCommand1.Connection = Me.OdbcConnection1
        Me.OdbcInsertCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("MAKHOA", System.Data.Odbc.OdbcType.[Char], 0, "MAKHOA"), New System.Data.Odbc.OdbcParameter("TENKHOA", System.Data.Odbc.OdbcType.VarChar, 0, "TENKHOA")})
        '
        'OdbcUpdateCommand1
        '
        Me.OdbcUpdateCommand1.CommandText = "UPDATE [KHOA] SET [MAKHOA] = ?, [TENKHOA] = ? WHERE (([MAKHOA] = ?) AND ((? = 1 A" & _
            "ND [TENKHOA] IS NULL) OR ([TENKHOA] = ?)))"
        Me.OdbcUpdateCommand1.Connection = Me.OdbcConnection1
        Me.OdbcUpdateCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("MAKHOA", System.Data.Odbc.OdbcType.[Char], 0, "MAKHOA"), New System.Data.Odbc.OdbcParameter("TENKHOA", System.Data.Odbc.OdbcType.VarChar, 0, "TENKHOA"), New System.Data.Odbc.OdbcParameter("Original_MAKHOA", System.Data.Odbc.OdbcType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAKHOA", System.Data.DataRowVersion.Original, Nothing), New System.Data.Odbc.OdbcParameter("IsNull_TENKHOA", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TENKHOA", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.Odbc.OdbcParameter("Original_TENKHOA", System.Data.Odbc.OdbcType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENKHOA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'OdbcDeleteCommand1
        '
        Me.OdbcDeleteCommand1.CommandText = "DELETE FROM [KHOA] WHERE (([MAKHOA] = ?) AND ((? = 1 AND [TENKHOA] IS NULL) OR ([" & _
            "TENKHOA] = ?)))"
        Me.OdbcDeleteCommand1.Connection = Me.OdbcConnection1
        Me.OdbcDeleteCommand1.Parameters.AddRange(New System.Data.Odbc.OdbcParameter() {New System.Data.Odbc.OdbcParameter("Original_MAKHOA", System.Data.Odbc.OdbcType.[Char], 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MAKHOA", System.Data.DataRowVersion.Original, Nothing), New System.Data.Odbc.OdbcParameter("IsNull_TENKHOA", System.Data.Odbc.OdbcType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "TENKHOA", System.Data.DataRowVersion.Original, True, Nothing), New System.Data.Odbc.OdbcParameter("Original_TENKHOA", System.Data.Odbc.OdbcType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TENKHOA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'DA
        '
        Me.DA.DeleteCommand = Me.OdbcDeleteCommand1
        Me.DA.InsertCommand = Me.OdbcInsertCommand1
        Me.DA.SelectCommand = Me.OdbcSelectCommand1
        Me.DA.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "KHOA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MAKHOA", "MAKHOA"), New System.Data.Common.DataColumnMapping("TENKHOA", "TENKHOA")})})
        Me.DA.UpdateCommand = Me.OdbcUpdateCommand1
        '
        'Ds1
        '
        Me.Ds1.DataSetName = "DS"
        Me.Ds1.EnforceConstraints = False
        Me.Ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bdskhoa
        '
        Me.bdskhoa.DataMember = "KHOA"
        Me.bdskhoa.DataSource = Me.Ds1
        '
        'dgvkhoa
        '
        Me.dgvkhoa.AllowUserToAddRows = False
        Me.dgvkhoa.AllowUserToDeleteRows = False
        Me.dgvkhoa.AutoGenerateColumns = False
        Me.dgvkhoa.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("VNI-Times", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkhoa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvkhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkhoa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvkhoa.DataSource = Me.bdskhoa
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvkhoa.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvkhoa.GridColor = System.Drawing.Color.Red
        Me.dgvkhoa.Location = New System.Drawing.Point(51, 288)
        Me.dgvkhoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvkhoa.Name = "dgvkhoa"
        Me.dgvkhoa.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvkhoa.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvkhoa.RowTemplate.Height = 24
        Me.dgvkhoa.Size = New System.Drawing.Size(663, 191)
        Me.dgvkhoa.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MAKHOA"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Maõ khoa"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TENKHOA"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Teân khoa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'txtmakhoa
        '
        Me.txtmakhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "MAKHOA", True))
        Me.txtmakhoa.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmakhoa.ForeColor = System.Drawing.Color.Red
        Me.txtmakhoa.Location = New System.Drawing.Point(144, 38)
        Me.txtmakhoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmakhoa.Name = "txtmakhoa"
        Me.txtmakhoa.Size = New System.Drawing.Size(152, 34)
        Me.txtmakhoa.TabIndex = 2
        '
        'txttenkhoa
        '
        Me.txttenkhoa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdskhoa, "TENKHOA", True))
        Me.txttenkhoa.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenkhoa.ForeColor = System.Drawing.Color.Red
        Me.txttenkhoa.Location = New System.Drawing.Point(144, 89)
        Me.txttenkhoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txttenkhoa.Name = "txttenkhoa"
        Me.txttenkhoa.Size = New System.Drawing.Size(481, 34)
        Me.txttenkhoa.TabIndex = 4
        '
        'Btnthem
        '
        Me.Btnthem.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnthem.Location = New System.Drawing.Point(801, 101)
        Me.Btnthem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnthem.Name = "Btnthem"
        Me.Btnthem.Size = New System.Drawing.Size(156, 38)
        Me.Btnthem.TabIndex = 5
        Me.Btnthem.Text = "Theâm"
        Me.Btnthem.UseVisualStyleBackColor = True
        '
        'Btnghi
        '
        Me.Btnghi.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnghi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnghi.Location = New System.Drawing.Point(907, 153)
        Me.Btnghi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnghi.Name = "Btnghi"
        Me.Btnghi.Size = New System.Drawing.Size(128, 38)
        Me.Btnghi.TabIndex = 6
        Me.Btnghi.Text = "Ghi"
        Me.Btnghi.UseVisualStyleBackColor = True
        '
        'Btnxoa
        '
        Me.Btnxoa.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnxoa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnxoa.Location = New System.Drawing.Point(721, 153)
        Me.Btnxoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnxoa.Name = "Btnxoa"
        Me.Btnxoa.Size = New System.Drawing.Size(128, 38)
        Me.Btnxoa.TabIndex = 7
        Me.Btnxoa.Text = "Xoùa"
        Me.Btnxoa.UseVisualStyleBackColor = True
        '
        'Btnphuchoi
        '
        Me.Btnphuchoi.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnphuchoi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnphuchoi.Location = New System.Drawing.Point(721, 220)
        Me.Btnphuchoi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnphuchoi.Name = "Btnphuchoi"
        Me.Btnphuchoi.Size = New System.Drawing.Size(128, 38)
        Me.Btnphuchoi.TabIndex = 8
        Me.Btnphuchoi.Text = "Phuïc hoài"
        Me.Btnphuchoi.UseVisualStyleBackColor = True
        '
        'Btnthoat
        '
        Me.Btnthoat.Font = New System.Drawing.Font("VNI-Times", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnthoat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btnthoat.Location = New System.Drawing.Point(907, 220)
        Me.Btnthoat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btnthoat.Name = "Btnthoat"
        Me.Btnthoat.Size = New System.Drawing.Size(128, 38)
        Me.Btnthoat.TabIndex = 9
        Me.Btnthoat.Text = "Thoaùt"
        Me.Btnthoat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("VNI-Avo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 38)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DANH MUÏC KHOA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.txttenkhoa)
        Me.GroupBox1.Controls.Add(Me.txtmakhoa)
        Me.GroupBox1.Controls.Add(MAKHOALabel)
        Me.GroupBox1.Controls.Add(TENKHOALabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(635, 133)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(51, 101)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 158)
        Me.Panel1.TabIndex = 12
        '
        'Frmkhoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1076, 612)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btnthoat)
        Me.Controls.Add(Me.Btnphuchoi)
        Me.Controls.Add(Me.Btnxoa)
        Me.Controls.Add(Me.Btnghi)
        Me.Controls.Add(Me.Btnthem)
        Me.Controls.Add(Me.dgvkhoa)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Frmkhoa"
        Me.Text = "Form1"
        CType(Me.Ds1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdskhoa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvkhoa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OdbcSelectCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcConnection1 As System.Data.Odbc.OdbcConnection
    Friend WithEvents OdbcInsertCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcUpdateCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents OdbcDeleteCommand1 As System.Data.Odbc.OdbcCommand
    Friend WithEvents DA As System.Data.Odbc.OdbcDataAdapter
    Friend WithEvents Ds1 As QUANLYDIEMSV.DS
    Friend WithEvents bdskhoa As System.Windows.Forms.BindingSource
    Friend WithEvents dgvkhoa As System.Windows.Forms.DataGridView
    Friend WithEvents txtmakhoa As System.Windows.Forms.TextBox
    Friend WithEvents txttenkhoa As System.Windows.Forms.TextBox
    Friend WithEvents Btnthem As System.Windows.Forms.Button
    Friend WithEvents Btnghi As System.Windows.Forms.Button
    Friend WithEvents Btnxoa As System.Windows.Forms.Button
    Friend WithEvents Btnphuchoi As System.Windows.Forms.Button
    Friend WithEvents Btnthoat As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
