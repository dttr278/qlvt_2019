Public Class frmThongBao

    Private Sub frmThongBao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTb1.Text = tb1
        If Trim(tb2) <> "" Then
            txtTb2.Text = tb2
            txtTb2.Visible = True
        End If
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

   
End Class