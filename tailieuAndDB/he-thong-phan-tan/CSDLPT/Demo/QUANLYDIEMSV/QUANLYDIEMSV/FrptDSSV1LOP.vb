Public Class FrptDSSV1LOP

  

    Private Sub FrptDSSV1LOP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
        Me.LOPTableAdapter.Fill(Me.DS.LOP)
        txtmalop.Text = cmbtenlop.SelectedValue
    End Sub

    Private Sub Btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnpreview.Click
        Me.rpt_DSSV_1Lop1.ParameterFields("@malop").CurrentValues.Clear()
        Crptv_DSSV1LOP.RefreshReport()
    End Sub

   
    Private Sub rpt_DSSV_1Lop1_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_DSSV_1Lop1.InitReport
        rpt_DSSV_1Lop1.ParameterFields("@malop").CurrentValues.AddValue(txtmalop.Text.Trim)
    End Sub

    Private Sub rpt_DSSV_1Lop1_RefreshReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_DSSV_1Lop1.RefreshReport
        rpt_DSSV_1Lop1.ParameterFields("@malop").CurrentValues.AddValue(txtmalop.Text.Trim)
    End Sub

    Private Sub cmbtenlop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtenlop.SelectedIndexChanged
        txtmalop.Text = cmbtenlop.SelectedValue
    End Sub

    Private Sub Btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnexit.Click
        Me.Close()

    End Sub
End Class