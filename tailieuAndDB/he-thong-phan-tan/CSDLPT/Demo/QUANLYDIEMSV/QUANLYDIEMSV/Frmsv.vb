Public Class Frmsv

    Private Sub Frmsv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.NGANH' table. You can move, or remove it, as needed.
        'Me.NGANHTableAdapter.Fill(Me.DS.NGANH)
        'TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
        Frmkhoa.DA.Fill(DS, "khoa")
        LOPTableAdapter.Fill(Me.DS.LOP)
        Me.SINHVIENTableAdapter.Fill(Me.DS.SINHVIEN)
        txttenlop.Text = bdslop.Item(0)("TENLOP")
    End Sub

    Private Sub Btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthem.Click
        bdssv.AddNew()
        txtMALOPSV.Text = cmbmalop.Text
        chkdanghihoc.CheckState = CheckState.Unchecked
        Btnthem.Enabled = False
        Btnxoa.Enabled = False

        txtmasv.Focus()
    End Sub

    Private Sub cmbmalop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txttenlop.Text = cmbmalop.SelectedValue

    End Sub

    Private Sub Btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnghi.Click
        If Trim(txtmasv.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "maõ sinh vieân baïn chöa nhaäp."
            tb2 = "baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmasv.Focus()
            Exit Sub
        End If
        If Trim(txttenlop.Text) = "" Then
            MsgBox("teân lop baïn chöa nhaäp.", , MsgBoxStyle.OkOnly)
            txttenlop.Focus()
            Exit Sub
        End If
        If Trim(txtho.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Hoï sinh vieân baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi"
            frmtb.ShowDialog()
            txtmakhoa.Focus()
            Exit Sub
        End If
        If Trim(txtten.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "Teân sinh vieân baïn chöa nhaäp."
            tb2 = "Baïn phaûi nhaäp laïi"
            frmtb.ShowDialog()
            txtmakhoa.Focus()
            Exit Sub
        End If

        Try
            bdssv.EndEdit()
            bdssv.ResetCurrentItem()
        Catch ex As Exception
            MsgBox("Mã sinh viên bị trùng. Bạn phải nhập lại.")
            Exit Sub
        End Try
        Me.SINHVIENTableAdapter.Update(DS.SINHVIEN)


        Btnthem.Enabled = True
        Btnxoa.Enabled = True
    End Sub

    Private Sub Btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa sinh viên này? Nếu xóa thì mã lớp cũng mất theo.", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdssv.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Sinh viên đã có mã lớp nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        Me.SINHVIENTableAdapter.Update(DS.SINHVIEN)
        If bdssv.Count = 0 Then
            Btnxoa.Enabled = False
            Btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If
    End Sub

    Private Sub Btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnphuchoi.Click
        bdssv.CancelEdit()
        dgvsv.Enabled = True
        If bdssv.Count <> 0 Then
            Btnphuchoi.Enabled = True
        Else
            Btnxoa.Enabled = False
        End If
    End Sub


    
    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()

    End Sub

    Private Sub txtmasv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmasv.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False

    End Sub

    
   
    Private Sub txtmasv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmasv.TextChanged

    End Sub

    Private Sub txtho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtho.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False


    End Sub

    Private Sub txtho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtho.TextChanged

    End Sub

    Private Sub txtten_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtten.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtten_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtten.TextChanged

    End Sub

    Private Sub txtdiachi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiachi.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtdiachi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiachi.TextChanged

    End Sub

    Private Sub txtghichu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtghichu.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtghichu_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtghichu.TextChanged

    End Sub

    
    
 
End Class