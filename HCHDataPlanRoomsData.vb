Partial Class HCHDataPlanRoomsData
    Partial Class SpPlanRoomsGetTableAdapter
        Public Property ConnectionString() As String
            Get
                Return Connection.ConnectionString
            End Get
            Set(value As String)
                Connection.ConnectionString = value
            End Set
        End Property

        Private Property Connection As Object

    End Class

    Private Sub HCHDataPlanRoomsData_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

    End Sub
End Class
