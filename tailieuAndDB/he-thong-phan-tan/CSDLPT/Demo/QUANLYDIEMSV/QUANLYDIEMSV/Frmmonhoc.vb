Public Class Frmmonhoc

    Private Sub Frmmonhoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MONHOCTableAdapter.Fill(Me.DS.MONHOC)

    End Sub

    Private Sub Btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthem.Click
        bdsmonhoc.AddNew()
        txtmamon.Focus()
        Btnthem.Enabled = False
        btnxoa.Enabled = False
    End Sub

    Private Sub Btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnghi.Click
        If Trim(txtmamon.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Maõ moân baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmamon.Focus()
            Exit Sub
        End If
        If Trim(txttenmon.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Teân moân baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txttenmon.Focus()
            Exit Sub
        End If
        Try
            bdsmonhoc.EndEdit()
            bdsmonhoc.ResetCurrentItem()
        Catch ex As ConstraintException
            MsgBox("Mã môn bạn nhập bị trùng. Bạn phải nhập lại.")
            txtmamon.Focus()
            Exit Sub
        End Try
        MONHOCTableAdapter.Update(DS.MONHOC)
        Btnthem.Enabled = True
        btnxoa.Enabled = True

    End Sub


    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa môn học này? Nếu xóa thì điểm của môn cũng mất theo.", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsmonhoc.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Môn bạn muốn xóa đã có điểm nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        MONHOCTableAdapter.Update(DS.MONHOC)
        If bdsmonhoc.Count = 0 Then
            btnxoa.Enabled = False
            btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If
    End Sub

    Private Sub Btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnphuchoi.Click
        bdsmonhoc.CancelEdit()
        dgvmonhoc.Enabled = True
        Btnthem.Enabled = True
        If bdsmonhoc.Count <> 0 Then
            btnxoa.Enabled = True
        Else
            btnxoa.Enabled = False
        End If
    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()
    End Sub

    Private Sub txtmamon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmamon.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False

    End Sub

   
   

    Private Sub txttenmon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttenmon.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txttenmon_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttenmon.TextChanged

    End Sub

    Private Sub txtsotiet_th_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsotiet_th.KeyPress
        e.Handled = Module1.NhapkySo(e.KeyChar)

    End Sub

    Private Sub txtsotiet_th_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsotiet_th.TextChanged

    End Sub

    Private Sub txtsotiet_lt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsotiet_lt.KeyPress
        e.Handled = Module1.NhapkySo(e.KeyChar)
    End Sub

    Private Sub txtsotiet_lt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsotiet_lt.TextChanged

    End Sub
End Class