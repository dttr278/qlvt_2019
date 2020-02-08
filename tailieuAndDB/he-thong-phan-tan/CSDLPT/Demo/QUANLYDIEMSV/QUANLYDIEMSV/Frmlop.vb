Public Class frmlop

    Private Sub frmlop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        ' Frmkhoa.DA.Fill(DS, "khoa")
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        txtmakhoa.Text = bdskhoa.Item(0)("makhoa")
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        bdslop.AddNew()
        txtketthuc.Text = ""
        txtkhaigiang.Text = ""
        txtmalop.Focus()
        btnthem.Enabled = False
        btnxoa.Enabled = False
    End Sub

    Private Sub btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnghi.Click
        If Trim(txtmalop.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Maõ lôùp baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmalop.Focus()
            Exit Sub
        End If
        If Trim(txttenlop.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Teân lôùp baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txttenlop.Focus()
            Exit Sub
        End If
        If Trim(txtkhaigiang.Text) = "" Then
            MsgBox("Thời gian khai giảng bạn chưa nhập. Bạn hãy nhập vào.", , MsgBoxStyle.OkOnly)
            txtkhaigiang.Focus()
            Exit Sub
        End If

        If Trim(txtketthuc.Text) = "" Then
            MsgBox("Thời gian kết thúc vẫn chưa nhập. Bạn hãy nhập đầy đủ thời gian kết thúc.", , MsgBoxStyle.OkOnly)
            txtketthuc.Focus()
            Exit Sub
        End If
        If Val(txtkhaigiang.Text) > Val(txtketthuc.Text) Then
            MsgBox("Khai giang <= Ket thuc.", , MsgBoxStyle.OkOnly)
            txtkhaigiang.Focus()
            Exit Sub
        End If
        Try
            bdslop.EndEdit()
            bdslop.ResetCurrentItem()
        Catch ex As ConstraintException
            MsgBox("Mã lớp hoặc tên lớp bị trùng. Bạn hãy nhập lại.")
            txtmalop.Focus()
        End Try
        Try
            Me.LOPTableAdapter.Update(Me.DS.LOP)
        Catch ex As Exception
            MsgBox("Mã lớp hoặc tên lớp bị trùng. Bạn hãy nhập lại.")
            txtmalop.Focus()
        End Try
        btnthem.Enabled = True
        btnxoa.Enabled = True
    End Sub



    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa lớp này? Nếu xóa thì khoa cũng sẽ mất theo.", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdslop.RemoveCurrent()
            Catch ex As ConstraintException
                MsgBox("Lớp bạn xóa đã có sinh viên nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        Me.LOPTableAdapter.Update(Me.DS.LOP)
        If bdslop.Count = 0 Then
            btnxoa.Enabled = False
            btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If
    End Sub

    Private Sub cmbtenkhoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtenkhoa.SelectedIndexChanged
        txtmakhoa1.Text = cmbtenkhoa.SelectedValue
    End Sub

    Private Sub txtkhaigiang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkhaigiang.KeyPress
        e.Handled = Module1.NhapkySo(e.KeyChar)
    End Sub

    Private Sub txtkhaigiang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkhaigiang.TextChanged

    End Sub

    Private Sub txtmalop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmalop.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtmalop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmalop.TextChanged

    End Sub

    Private Sub txttenlop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttenlop.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txttenlop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttenlop.TextChanged

    End Sub

    Private Sub txtketthuc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtketthuc.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtketthuc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtketthuc.TextChanged

    End Sub

    Private Sub txtmakhoa1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtmakhoa1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnphuchoi.Click
        bdslop.CancelEdit()
        dgvlop.Enabled = True
        If bdslop.Count <> 0 Then
            btnphuchoi.Enabled = False
        Else
            btnxoa.Enabled = False
        End If
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()

    End Sub

    
End Class