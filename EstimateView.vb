Public Class EstimateView
    Friend msJobID As String
    Friend mbLockJobs As Boolean = False
    Private Sub EstimateView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCHDataQADataSet1.spGetAllJobs' table. You can move, or remove it, as needed.
        SpGetAllJobsTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.SpGetAllJobsTableAdapter.Fill(Me.HCHDataQADataSet1.spGetAllJobs)
        If Not msJobID = Nothing And msJobID <> "" Then
            'ucJobs.Text = msJobID
            ucJobs.SelectedText = msJobID

        Else
            ucJobs.Text = ""
        End If
        ucJobs.Enabled = Not mbLockJobs
    End Sub

    Private Sub ucJobs_RowSelected(sender As Object, e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles ucJobs.RowSelected
        If Not e.Row Is Nothing Then
            msJobID = e.Row.Cells("JobID").Text
            SpGetJobDetailsTableAdapter.Connection.ConnectionString = gsConnectionString
            SpGetJobDetailsTableAdapter.Fill(HCHDataQAJobDetails.Tables(0), msJobID)
            ulPlanID.Text = e.Row.Cells("PlanID").Text
        End If
    End Sub
End Class