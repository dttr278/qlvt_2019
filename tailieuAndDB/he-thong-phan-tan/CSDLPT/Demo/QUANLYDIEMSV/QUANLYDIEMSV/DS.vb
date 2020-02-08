Partial Class DS
    Partial Class MONHOCDataTable

        Private Sub MONHOCDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MAMONColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class KEHOACHDAOTAODataTable

        Private Sub KEHOACHDAOTAODataTable_KEHOACHDAOTAORowChanging(ByVal sender As System.Object, ByVal e As KEHOACHDAOTAORowChangeEvent) Handles Me.KEHOACHDAOTAORowChanging

        End Sub

        Private Sub KEHOACHDAOTAODataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.MAMONColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace DSTableAdapters
    
    Partial Public Class KEHOACHDAOTAOTableAdapter
    End Class
End Namespace
