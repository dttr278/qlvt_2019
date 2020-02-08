Public Class FrptDSLOP1KHOA

    Private Sub FrptDSLOP1KHOA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frmkhoa.DA.Fill(Me.DS.KHOA)
    End Sub

    Private Sub cmbtenkhoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtenkhoa.SelectedIndexChanged
        txtmakhoa.Text = cmbtenkhoa.SelectedValue
    End Sub

    Private Sub Btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpreview.Click
        Me.rpt_DSLOP_1KHOA1.ParameterFields("@makhoa").CurrentValues.Clear()
        Crptv_DSLOP1KHOA.RefreshReport()

    End Sub

    Private Sub rpt_DSLOP_1KHOA1_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_DSLOP_1KHOA1.InitReport
        rpt_DSLOP_1KHOA1.ParameterFields("@makhoa").CurrentValues.AddValue(txtmakhoa.Text.Trim)
    End Sub

    Private Sub rpt_DSLOP_1KHOA1_RefreshReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_DSLOP_1KHOA1.RefreshReport
        rpt_DSLOP_1KHOA1.ParameterFields("@makhoa").CurrentValues.AddValue(txtmakhoa.Text.Trim)
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class