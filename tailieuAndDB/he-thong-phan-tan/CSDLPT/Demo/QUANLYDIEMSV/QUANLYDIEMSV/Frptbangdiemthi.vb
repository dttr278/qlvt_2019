Public Class Frptbangdiemthi


    Private Sub Frptbangdiemthi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        Me.MONHOCTableAdapter.Fill(Me.DS.MONHOC)

        txttenlop.Text = cmbmalop.SelectedValue
        txtmamon.Text = cmbtenmon.SelectedValue

    End Sub

    Private Sub cmbmalop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbmalop.SelectedIndexChanged
        txttenlop.Text = cmbmalop.SelectedValue

    End Sub

    Private Sub cmbtenmon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtenmon.SelectedIndexChanged
        txtmamon.Text = cmbtenmon.SelectedValue

    End Sub

    Private Sub Btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpreview.Click
        Me.rpt_BANGDIEMTHI1.ParameterFields("@mamon").CurrentValues.Clear()
        Me.rpt_BANGDIEMTHI1.ParameterFields("@malop").CurrentValues.Clear()
        Me.rpt_BANGDIEMTHI1.ParameterFields("@lan").CurrentValues.Clear()
        Crptv_bangdiemthi.RefreshReport()
    End Sub

    Private Sub rpt_BANGDIEMTHI1_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_BANGDIEMTHI1.InitReport
        rpt_BANGDIEMTHI1.ParameterFields("@mamon").CurrentValues.AddValue(txtmamon.Text.Trim)
        rpt_BANGDIEMTHI1.ParameterFields("@malop").CurrentValues.AddValue(cmbmalop.Text.Trim)
        rpt_BANGDIEMTHI1.ParameterFields("@lan").CurrentValues.AddValue(Val(cmblan.Text.Trim))
    End Sub

    Private Sub rpt_BANGDIEMTHI1_RefreshReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_BANGDIEMTHI1.RefreshReport
        rpt_BANGDIEMTHI1.ParameterFields("@mamon").CurrentValues.AddValue(txtmamon.Text.Trim)
        rpt_BANGDIEMTHI1.ParameterFields("@malop").CurrentValues.AddValue(cmbmalop.Text.Trim)
        rpt_BANGDIEMTHI1.ParameterFields("@lan").CurrentValues.AddValue(Val(cmblan.Text.Trim))
    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()

    End Sub
End Class