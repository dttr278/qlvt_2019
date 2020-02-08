Imports System.Data.Odbc
Public Class frmdiem
    Dim DiemDA As OdbcDataAdapter
    Dim DiemCmd As OdbcCommand
    Dim DiemIns As OdbcCommand
    Dim diemDS As DataSet
    Private Sub frmdiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
        Me.MONHOCTableAdapter.Fill(Me.DS.MONHOC)
        Me.LOPTableAdapter.Fill(Me.DS.LOP)

        txttenlop.Text = bdslop.Item(0)("tenlop")
        txtmamon.Text = bdsmonhoc.Item(0)("mamon")
        cmblan.SelectedIndex = 0
        cmbHocky.SelectedIndex = 0
    End Sub

    Private Sub cmbmalop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmalop.SelectedIndexChanged
        txttenlop.Text = cmbmalop.SelectedValue

    End Sub

    Private Sub cmbtenmon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtenmon.SelectedIndexChanged
        txtmamon.Text = cmbtenmon.SelectedValue

    End Sub


    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()

    End Sub
    Private Sub btnBatdau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatDau.Click
        If cmbmalop.Text.Trim = "" Or txtmamon.Text.Trim = "" Or _
            cmblan.SelectedIndex = -1 Or cmbHocky.SelectedIndex = -1 Then
            MsgBox("Bạn phải nhập đủ các thông tin (tên lớp, môn học, học kỳ, lần thi)", MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        ' Tạo dl DiemCMd liên kết với sp DS_DIEM
        DiemCmd = New OdbcCommand("{ ?=CALL SP_NHAPDIEM(?,?,?) }", conn)
        DiemCmd.CommandType = CommandType.StoredProcedure
        ' Tạo 3 tham số đặt vào myParm
        Dim myParm As OdbcParameter = DiemCmd.Parameters.Add("RETURN_VALUE", OdbcType.Int)
        myParm.Direction = ParameterDirection.ReturnValue

        myParm = DiemCmd.Parameters.Add("@malop", OdbcType.VarChar, 10)
        myParm.Direction = ParameterDirection.Input
        myParm.Value = cmbmalop.Text.Trim

        myParm = DiemCmd.Parameters.Add("@mamh", OdbcType.VarChar, 10)
        myParm.Direction = ParameterDirection.Input
        myParm.Value = txtmamon.Text.Trim

        myParm = DiemCmd.Parameters.Add("@lan", OdbcType.Int)
        ' myParm.Direction = ParameterDirection.Input
        myParm.Value = cmblan.SelectedItem


        DiemDA = New OdbcDataAdapter
        DiemDA.SelectCommand = DiemCmd

        Module1.KetNoi()  ' Gọi module ketnoi với tham số là DSN, còn login và pass là 2 biến toàn cục

        diemDS = New DataSet
        DiemDA.Fill(diemDS)

        conn.Close()
        If DiemCmd.Parameters("return_value").Value = -1 Then
            MsgBox("Lớp bạn chọn chưa nhập sinh viên. ", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If DiemCmd.Parameters("return_value").Value = 2 Then
            MsgBox("Lần thi 1 chưa nhập nên không thể nhập điểm lần 2.", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
       
        With dgv_Diem
            .AutoGenerateColumns = True
            .Font = New System.Drawing.Font("vni-times", 13, FontStyle.Regular, GraphicsUnit.Pixel)
            'Liên kết DataGridView với DataSet diemDS
            .DataSource = diemDS
            .DataMember = diemDS.Tables.Item(0).TableName 'Lấy tên table trong dataset
            'Thiết lập thuộc tính cho từng column
            .Columns(0).HeaderText = "Maõ sinh vieân"
            .Columns(0).ReadOnly = True
            .Columns(0).MinimumWidth = 150

            .Columns(1).HeaderText = "Hoï vaø  teân"
            .Columns(1).ReadOnly = True
            .Columns(1).MinimumWidth = 300

            .Columns(2).HeaderText = "Ñieåm"
            .Columns(2).ReadOnly = False
            .Columns(2).MinimumWidth = 60

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader

            'MsgBox(diemDS.Tables(0).Rows(bds.Position)("masv").ToString)
            .AutoSizeRowsMode = _
                  DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

            ' Set the DataGridView control's border.
            .BorderStyle = BorderStyle.Fixed3D

            ' Put the cells in edit mode when user enters them.
            .EditMode = DataGridViewEditMode.EditOnEnter            '.Refresh()
            .Visible = True
            .Focus()
            My.Computer.Keyboard.SendKeys("{TAB}", False)
            My.Computer.Keyboard.SendKeys("{TAB}", False)
        End With

        BtnBatDau.Enabled = False
        BtnGhi.Enabled = True
        GroupBox1.Enabled = False

    End Sub

    Private Sub BtnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGhi.Click
        Dim state As Integer = DiemCmd.Parameters("return_value").Value
        If state = 0 Or state = 1 Then
            Dim diemDA As OdbcDataAdapter = New OdbcDataAdapter("SELECT * FROM BANGDIEM where masv='000'", conn)

            diemDA.InsertCommand = New OdbcCommand("{? = call SP_INSERT_DIEM(?,?,?,?,?) }", conn)
            diemDA.InsertCommand.CommandType = CommandType.StoredProcedure

            Dim myParm As OdbcParameter = diemDA.InsertCommand.Parameters.Add("@RowCount", OdbcType.Int)
            myParm.Direction = ParameterDirection.ReturnValue

            diemDA.InsertCommand.Parameters.Add("@masv", OdbcType.Char, 10, "masv")
            diemDA.InsertCommand.Parameters.Add("@maMH", OdbcType.Char, 10, "mamon")
            diemDA.InsertCommand.Parameters.Add("@LAN", OdbcType.TinyInt, 1, "lan")
            diemDA.InsertCommand.Parameters.Add("@HOCKY", OdbcType.TinyInt, 1, "hocky")
            diemDA.InsertCommand.Parameters.Add("@DIEM", OdbcType.Double, 8, "DIEM")

            Dim DSInsertDiem As DataSet = New DataSet()
            diemDA.Fill(DSInsertDiem, "BANGDIEM")
            'Chuyển 'toàn bộ điểm trong dataset diemDS vào dataSet DSInsertDiem, để insert 
            ' 1 lần về csdl 

            Do While diemDS.Tables(0).Rows.Count <> 0
                Dim newRow As DataRow = DSInsertDiem.Tables("bangdiem").NewRow
                newRow("masv") = diemDS.Tables(0).Rows(0)("masv")
                newRow("mamon") = txtmamon.Text
                newRow("lan") = cmblan.SelectedItem
                newRow("hocky") = cmbHocky.SelectedItem
                newRow("diem") = diemDS.Tables(0).Rows(0)("diem")
                DSInsertDiem.Tables("bangdiem").Rows.Add(newRow)
                diemDS.Tables(0).Rows.RemoveAt(0)
            Loop
            If state = 1 Then ' đã có ở table Diem nên ta xóa điểm cũ trớc khi insert diem mới
                Dim strdelete As String
                strdelete = "delete from bangdiem where mamon = '" & txtmamon.Text.Trim & "' and lan =" & _
                    cmblan.SelectedItem & " and masv in (select masv from sinhvien where malop ='" & cmbmalop.Text.Trim & "')"
                Dim deleteCmd As OdbcCommand = New OdbcCommand(strdelete, conn)
                Module1.KetNoi()
                deleteCmd.ExecuteNonQuery()
            End If
            diemDA.Update(DSInsertDiem, "bangdiem")
            conn.Close()
        End If

        BtnBatDau.Enabled = True
        BtnGhi.Enabled = False
        GroupBox1.Enabled = True
        dgv_Diem.Visible = False
    End Sub
End Class