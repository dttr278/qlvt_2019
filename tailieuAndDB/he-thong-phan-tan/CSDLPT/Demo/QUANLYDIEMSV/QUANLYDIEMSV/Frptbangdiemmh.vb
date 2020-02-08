Public Class Frptbangdiemmh

  

    Private Sub Frptbangdiemmh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.BANGDIEM' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
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

    
    Private Sub btnpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpreview.Click
        Me.rpt_BDMH1.ParameterFields("@mamon").CurrentValues.Clear()
        Me.rpt_BDMH1.ParameterFields("@malop").CurrentValues.Clear()
        Me.rpt_BDMH1.ParameterFields("@lan").CurrentValues.Clear()
        Crptv_BDMH.RefreshReport()

    End Sub


    Private Sub rpt_BDMH1_InitReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_BDMH1.InitReport
        rpt_BDMH1.ParameterFields("@mamon").CurrentValues.AddValue(txtmamon.Text.Trim)
        rpt_BDMH1.ParameterFields("@malop").CurrentValues.AddValue(cmbmalop.Text.Trim)
        rpt_BDMH1.ParameterFields("@lan").CurrentValues.AddValue(Val(cmbLan.Text.Trim))
    End Sub

    Private Sub rpt_BDMH1_RefreshReport(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_BDMH1.RefreshReport
        rpt_BDMH1.ParameterFields("@mamon").CurrentValues.AddValue(txtmamon.Text.Trim)
        rpt_BDMH1.ParameterFields("@malop").CurrentValues.AddValue(cmbmalop.Text.Trim)
        rpt_BDMH1.ParameterFields("@lan").CurrentValues.AddValue(Val(cmbLan.Text.Trim))
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    
End Class