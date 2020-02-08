Public Class Frmnganh

    Private Sub Frmnganh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frmkhoa.DA.Fill(DS, "khoa")
        Me.NGANHTableAdapter.Fill(Me.DS.NGANH)

        txtmakhoa.Text = bdskhoa.Item(0)("makhoa")
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        bdsnganh.AddNew()
        txtmanganh.Focus()
        btnthem.Enabled = False
        Btnxoa.Enabled = False

    End Sub

    Private Sub Btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnghi.Click
        If Trim(txtmanganh.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Maõ ngaønh baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmanganh.Focus()
            Exit Sub
        End If
        If Trim(txttennganh.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Teân ngaønh baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txttennganh.Focus()
            Exit Sub
        End If
        Try
            bdsnganh.EndEdit()
            bdsnganh.ResetCurrentItem()
        Catch ex As ConstraintException
            MsgBox("Mã ngành bạn nhập bị trùng.")
            txtmanganh.Focus()
        End Try
        Try
            Me.NGANHTableAdapter.Update(Me.DS.NGANH)
        Catch ex As Exception
            MsgBox("Mã ngành bạn nhập bị trùng.")
            txtmanganh.Focus()
        End Try
        btnthem.Enabled = True
        Btnxoa.Enabled = True
    End Sub

    Private Sub Btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa ngành này? Nếu xóa thì khoa cũng mất theo.", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsnganh.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Ngành của bạn đã có môn học nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        Me.NGANHTableAdapter.Update(Me.DS.NGANH)
        If bdsnganh.Count = 0 Then
            Btnxoa.Enabled = False
            Btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If
    End Sub

    
    Private Sub Btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnphuchoi.Click
        bdsnganh.CancelEdit()
        dgvnganh.Enabled = True
        If bdsnganh.Count <> 0 Then
            Btnphuchoi.Enabled = False
        Else
            Btnxoa.Enabled = False
        End If
    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()

    End Sub

    Private Sub txttennganh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttennganh.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txttennganh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txttennganh.TextChanged

    End Sub

    Private Sub txtmanganh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmanganh.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtmanganh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmanganh.TextChanged

    End Sub
End Class