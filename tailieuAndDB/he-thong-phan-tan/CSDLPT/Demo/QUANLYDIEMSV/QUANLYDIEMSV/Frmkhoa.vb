Public Class Frmkhoa

    Private Sub Frmkhoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        DA.Fill(Ds1, "khoa")
    End Sub

    Private Sub Btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthem.Click
        bdskhoa.AddNew()
        txtmakhoa.Focus()
        Btnthem.Enabled = False
        Btnxoa.Enabled = False
    End Sub

    Private Sub Btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnghi.Click
        If Trim(txtmakhoa.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Maõ khoa baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmakhoa.Focus()
            Exit Sub
        End If
        If Trim(txttenkhoa.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Teân khoa baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmakhoa.Focus()
            Exit Sub
        End If
        Try
            bdskhoa.EndEdit()
            bdskhoa.ResetCurrentItem()
        Catch ex As ConstraintException
            MsgBox("Mã khoa bạn nhập bị trùng.")
            txtmakhoa.Focus()
        End Try
        DA.Update(Ds1, "khoa")
        Btnthem.Enabled = True
        Btnxoa.Enabled = True
    End Sub

    Private Sub Btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa khoa này? Nếu xóa thì ngành cũng sẽ mất theo", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdskhoa.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Khoa của bạn đã có lớp nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        DA.Update(Ds1, "khoa")
        If bdskhoa.Count = 0 Then
            Btnxoa.Enabled = False
            Btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If

    End Sub

    Private Sub Btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnphuchoi.Click
        bdskhoa.CancelEdit()
        dgvkhoa.Enabled = True
        Btnthem.Enabled = True
        If bdskhoa.Count <> 0 Then
            Btnxoa.Enabled = True
        Else
            Btnxoa.Enabled = False
        End If
    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()
    End Sub

    Private Sub txtmakhoa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmakhoa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtmakhoa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmakhoa.TextChanged

    End Sub

    Private Sub txttenkhoa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttenkhoa.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txttenkhoa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttenkhoa.TextChanged

    End Sub
End Class
