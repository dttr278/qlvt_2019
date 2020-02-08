Public Class Frmkhdaotao


    Private Sub cmbtennganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtennganh.SelectedIndexChanged

        txtmanganh.Text = cmbtennganh.SelectedValue

    End Sub

    Private Sub Frmkhdaotao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.


        MONHOCTableAdapter.Fill(Me.DS.MONHOC)
        NGANHTableAdapter.Fill(Me.DS.NGANH)
        Me.KEHOACHDAOTAOTableAdapter.Fill(Me.DS.KEHOACHDAOTAO)
        txtmanganh.Text = bdsnganh.Item(0)("manganh")
    End Sub

    Private Sub Btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnthem.Click
        bdskhdaotao.AddNew()
        txtmamon.Focus()

        Btnthem.Enabled = False
        Btnxoa.Enabled = False
    End Sub

    Private Sub Btnghi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnghi.Click
        If Trim(txtmamon.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "maõ moân baïn chöa nhaäp."
            tb2 = "baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtmamon.Focus()
            Exit Sub
        End If

        If Trim(cmbhocky.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "hoïc kyø baïn chöa nhaäp."
            tb2 = "baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            cmbhocky.Focus()
            Exit Sub
        End If

        If Trim(txtsotiet.Text) = "" Then
            Dim frmtb As New frmThongBao
            tb1 = "soá tieát baïn chöa nhaäp."
            tb2 = "baïn phaûi nhaäp laïi."
            frmtb.ShowDialog()
            txtsotiet.Focus()
            Exit Sub
        End If

        Try
            bdskhdaotao.EndEdit()
            bdskhdaotao.ResetCurrentItem()
        Catch ex As Exception
            MsgBox("Mã môn bị trùng. Bạn hãy nhập lại.")
            Exit Sub
        End Try
        'Me.KEHOACHDAOTAOTableAdapter.Update(Me.DS.KEHOACHDAOTAO)
        Btnthem.Enabled = True
        Btnxoa.Enabled = True
    End Sub

    Private Sub Btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnxoa.Click
        Dim yn As DialogResult
        yn = MsgBox("Bạn có thật sự muốn xóa ngành này? Nếu xóa thì môn của ngành sẽ mất theo", MsgBoxStyle.YesNo)
        If yn = Windows.Forms.DialogResult.Yes Then
            Try
                bdskhdaotao.RemoveCurrent()
            Catch ex As Exception
                MsgBox("Ngành bạn muốn xóa đã có môn nên không thể xóa.", MsgBoxStyle.Information)
                Exit Sub
            End Try
        End If
        Me.KEHOACHDAOTAOTableAdapter.Update(DS.KEHOACHDAOTAO)
        If bdskhdaotao.Count = 0 Then
            Btnxoa.Enabled = False
            Btnghi.Enabled = True
        Else
            'modul1.setenableofbutton(me,true)
            'btnundo.enable= false
        End If

    End Sub


    Private Sub btnphuchoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnphuchoi.Click
        bdskhdaotao.CancelEdit()
        dgvkhdaotao.Enabled = True
        If bdskhdaotao.Count <> 0 Then
            btnphuchoi.Enabled = True
        Else
            Btnxoa.Enabled = False
        End If
    End Sub

    Private Sub btnthoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthoat.Click
        Me.Close()

    End Sub

 


    Private Sub CMBTENMON_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBTENMON.SelectedIndexChanged
        txtmamon.Text = CMBTENMON.SelectedValue
    End Sub

    Private Sub txtsotiet_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsotiet.KeyPress
        e.Handled = Module1.NhapkySo(e.KeyChar)
    End Sub

    Private Sub txtsotiet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsotiet.TextChanged

    End Sub
End Class