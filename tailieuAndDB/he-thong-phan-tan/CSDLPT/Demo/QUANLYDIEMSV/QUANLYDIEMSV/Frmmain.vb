Public Class Frmmain

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        mlogin = usernameTextBox.Text.Trim
        mPass = PasswordTextBox.Text.Trim
        If Module1.KetNoi() = 0 Then
            Exit Sub
        End If
        Dim cmd_user As New Odbc.OdbcCommand
        cmd_user.Connection = conn
        cmd_user.CommandText = "sp_helpuser"
        ' sp này trả về các fields theo thứ tự:
        'Username Groupname    LoginName    DfDBName  UserID
        cmd_user.CommandType = CommandType.StoredProcedure
        Dim myReader As Odbc.OdbcDataReader
        Try
            myReader = cmd_user.ExecuteReader
        Catch excep As InvalidOperationException
            MsgBox("Lỗi kết nối dữ liệu. Bạn nên thoát và khởi động lại chương trình từ đầu", MsgBoxStyle.OkOnly)
            Exit Sub
        End Try
        ' Lấy user name và group name từ login name
        Do While myReader.Read()

            Try
                If myReader.GetString(2).Trim = mlogin Then
                    mUser = myReader.GetString(0)
                    mGroup = myReader.GetString(1)
                    Exit Do
                End If
            Catch ex As InvalidCastException
                Continue Do
            End Try
        Loop
        myReader.Close()
        If IsDBNull(mUser) Then
            MsgBox("Login bạn nhập không có quyền truy cập dữ liệu" & vbCrLf & _
                   "Bạn xem lại username của cơ sở dữ liệu", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        'Lấy họ tên từ user name
        'Dim cmd_Nhanvien As New Odbc.OdbcCommand
        'cmd_Nhanvien.Connection = conn
        'cmd_Nhanvien.CommandText = "{Call Tim_Hoten (?)}"
        'Dim mypara As Odbc.OdbcParameter = cmd_Nhanvien.Parameters.Add _
        '  ("@manv", Odbc.OdbcType.Int)
        'mypara.Direction = ParameterDirection.Input
        'mypara.Value = mUser
        'myReader = cmd_Nhanvien.ExecuteReader
        'myReader.Read()
        'If myReader.HasRows Then
        '    mHoten = myReader.GetString(0) & " " & myReader.GetString(1)

        'Else
        '    MsgBox("Login bạn nhập không có họ tên trong danh sách nhân viên  ", MsgBoxStyle.OkOnly)
        '    myReader.Close()
        '    conn.Close()
        '    Exit Sub
        'End If

        myReader.Close()
        conn.Close()
        Me.MenuStrip1.Enabled = True
        'ToolStripStatusLabel1.Text = "Hoï teân nhaân vieân: " & mHoten
        'ToolStripStatusLabel1.Visible = True
        'ToolStripStatusLabel2.Text = "Nhoùm : " & mGroup
        'ToolStripStatusLabel2.Visible = True

        '' Phan quyen cho nhan vien
        If mGroup = "GiaoVien" Then
            '  TAOXOAUSERToolStripMenuItem.Enabled = True
            '    ThốngKêToolStripMenuItem.Enabled = False
            '    TaoUserToolStripMenuItem.Enabled = False
            '    SaoLuuSốLiệuToolStripMenuItem.Enabled = False
            '    LinhTinhToolStripMenuItem.Enabled = False
        Else
            '    LươngNhânViênToolStripMenuItem.Enabled = True
            '    ThốngKêToolStripMenuItem.Enabled = True
            '    TaoUserToolStripMenuItem.Enabled = True
            '    SaoLuuSốLiệuToolStripMenuItem.Enabled = True
            '    LinhTinhToolStripMenuItem.Enabled = True
        End If
        BtnOK.Enabled = False
    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()

    End Sub

    Private Sub SINHVIENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmmain As New Frmsv
        Frmsv.ShowDialog()

    End Sub


    Private Sub KHOAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KHOAToolStripMenuItem.Click
        Dim frmmain As New Frmsv
        Frmkhoa.ShowDialog()
    End Sub

    Private Sub LOPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOPToolStripMenuItem.Click
        Dim frmmain As New Frmsv
        frmlop.ShowDialog()
    End Sub

    Private Sub GIAOVIENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GIAOVIENToolStripMenuItem.Click
        Dim frmmain As New Frmsv
        Frmgv.ShowDialog()
    End Sub

    Private Sub NGANHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NGANHToolStripMenuItem.Click
        Dim frmmain As New Frmsv
        Frmnganh.ShowDialog()
    End Sub


    Private Sub KHDTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KHDTToolStripMenuItem.Click
        Dim frmmain As New Frmsv
        Frmkhdaotao.ShowDialog()
    End Sub


End Class