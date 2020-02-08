Public Class Frmgv

    Private Sub Frmgv_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frmkhoa.DA.Fill(DS, "khoa")
        Me.GIAOVIENTableAdapter.Fill(Me.DS.GIAOVIEN)
        txtmakhoa.Text = bdskhoa.Item(0)("makhoa")
    End Sub

    Private Sub Btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthem.Click
        bdsgv.AddNew()
        txtmagv.Focus()
        Btnthem.Enabled = False
        Btnxoa.Enabled = False

    End Sub

    Private Sub Btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnghi.Click
        If Trim(txtmagv.Text) = "" Then
            MsgBox("Mã giáo viên bạn chưa nhập. Bạn hãy nhập mã giáo viên", MsgBoxStyle.OkOnly)
            txtmagv.Focus()
            Exit Sub
        End If
        If Trim(txtho.Text) = "" Then
            MsgBox("Họ giáo viên bạn chưa nhập. Bạn hãy nhập vào!", , MsgBoxStyle.OkOnly)
            txtho.Focus()
            Exit Sub
        End If
        If Trim(txtten.Text) = "" Then
            MsgBox("Tên giáo viên bạn chưa nhập. Bạn hãy nhập vào.", , MsgBoxStyle.OkOnly)
            txtten.Focus()
            Exit Sub
        End If
        If Trim(cmbphai.Text) = "" Then
            MsgBox("Bạn hãy nhập phái của giáo viên.", , MsgBoxStyle.OkOnly)
            cmbphai.Focus()
            Exit Sub
        End If
        If Trim(txthocvi.Text) = " " Then
            MsgBox("Bạn hãy cho biết học vị học hàm của giáo viên.", , MsgBoxStyle.OkOnly)
            txthocvi.Focus()
            Exit Sub
        End If

        Try
            bdsgv.EndEdit()
            bdsgv.ResetCurrentItem()
        Catch ex As Exception
            MsgBox("Mã khoa hoặc tên giáo viên bị trùng. Bạn phải nhập lại.")
            Exit Sub

        End Try
        Me.GIAOVIENTableAdapter.Update(Me.DS.GIAOVIEN)
        Btnthem.Enabled = True
        Btnxoa.Enabled = True
    End Sub
    Private Sub cmbtenkhoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtenkhoa.SelectedIndexChanged
        txtmakhoa.Text = cmbtenkhoa.SelectedValue

    End Sub

    Private Sub Btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa giáo viên này? Nếu bạn xóa thì mã khoa của giáo viên cũng sẽ mất theo!", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdsgv.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Giáo viên bạn muốn xóa đã có giờ dạy nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        Me.GIAOVIENTableAdapter.Update(Me.DS.GIAOVIEN)
        If bdsgv.Count = 0 Then
            Btnxoa.Enabled = False
            Btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If
    End Sub

    Private Sub Btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnphuchoi.Click
        bdsgv.CancelEdit()
        dgvgv.Enabled = True
        If bdsgv.Count <> 0 Then
            Btnphuchoi.Enabled = False
        Else
            Btnxoa.Enabled = False
        End If
    End Sub

    Private Sub Btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthoat.Click
        Me.Close()

    End Sub

    Private Sub txtmagv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmagv.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    
    
    Private Sub txtmagv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmagv.TextChanged

    End Sub

    Private Sub txtho_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtho.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtho_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtho.TextChanged

    End Sub

    Private Sub txtdiachi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiachi.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtdiachi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiachi.TextChanged

    End Sub

    Private Sub txtten_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtten.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtten_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtten.TextChanged

    End Sub

    Private Sub txtdiachimail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdiachimail.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub

    Private Sub txtdiachimail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdiachimail.TextChanged

    End Sub

    Private Sub txthocvi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthocvi.KeyPress
        e.KeyChar = UCase(e.KeyChar)
        e.Handled = False
    End Sub


End Class