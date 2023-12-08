Partial Class dsDetail
    Partial Class spPlanEstimatesGetDataTable

        Private Sub spPlanEstimatesGetDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.ActivityCodeColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub spPlanEstimatesGetDataTable_RowChanged(sender As Object, e As DataRowChangeEventArgs) Handles Me.RowChanged
            ''            e.Row.Item("UpdatedBy") = gsUserID
            ' Me. = e.Row.Item("PlanEstimateID")
        End Sub
    End Class

End Class

Namespace dsDetailTableAdapters
    
    Partial Public Class spPlanEstimatesGetTableAdapter

    End Class
End Namespace
