Public Class Frpt_DSSVLOP

    Private Sub Frpt_DSSVLOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Fill(Me.DS.LOP)

    End Sub

    Private Sub rpt_DSSVLOP1_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_DSSVLOP1.InitReport
        rpt_DSSVLOP1.ParameterFields("@malop").CurrentValues.AddValue(txtMalop.Text.Trim)
        rpt_DSSVLOP1.ParameterFields("tenlop").CurrentValues.AddValue(cboTENLOP.Text)
        rpt_DSSVLOP1.ParameterFields("tienchu").CurrentValues.AddValue(Module1.Doitien(TextBox1.Text))
    End Sub

    Private Sub rpt_DSSVLOP1_RefreshReport(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpt_DSSVLOP1.RefreshReport
        rpt_DSSVLOP1.ParameterFields("@malop").CurrentValues.AddValue(txtMalop.Text.Trim)
        rpt_DSSVLOP1.ParameterFields("tenlop").CurrentValues.AddValue(cboTENLOP.Text)
        rpt_DSSVLOP1.ParameterFields("tienchu").CurrentValues.AddValue(Module1.Doitien(TextBox1.Text))
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        rpt_DSSVLOP1.ParameterFields("@malop").CurrentValues.Clear()
        rpt_DSSVLOP1.ParameterFields("tenlop").CurrentValues.Clear()
        rpt_DSSVLOP1.ParameterFields("tienchu").CurrentValues.Clear()
        Crpt_DSSV.RefreshReport()
    End Sub
End Class