Imports System.Data
Imports Infragistics.Win.UltraWinDataSource
Imports Infragistics.Win.UltraWinGrid
Public Class CostAnalysisSearch
    Dim miAnalysisID As Int64
    Dim msProjectID As String
    Private Sub CostAnalysisSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetDataDate()
        LoadSearchGrid()
        'Me.SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.Tables(0))
        'UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Clear()
        'UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("AnalysisDate", True)
        'UltraGrid1.DataBind()

    End Sub

  

    Private Sub tsBtnAdd_Click(sender As Object, e As EventArgs) Handles tsBtnAdd.Click
        'CostAnalysisDetail.miAnalysisID = 0
        Dim mDetailForm As New CostAnalysisDetail(Me)

        'CostAnalysisDetail.ShowDialog()
        mDetailForm.miAnalysisID = 0
        mDetailForm.ShowDialog()
    End Sub
    Private Sub GetDataDate()
        Dim cDB As DBCalls
        Dim ds As New DataSet

        Try
            cDB = New DBCalls
            Dim row As DataRow
            Dim sDate As DateTime
            If cDB.GetRecordsFromSP(ds, "spCostAnalysisDateGet") Then
                For Each row In ds.Tables(0).Rows
                    sDate = row.Item("UpdateEnded").ToString
                    tsLblLastReloadDate.Text = "Last Reload Date: " & sDate
                Next
            End If

            'ds = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GetDataDate")
        Finally
            cDB = Nothing
            ds = Nothing
        End Try
    End Sub

    Private Sub tsBtnReloadData_Click(sender As Object, e As EventArgs) Handles tsBtnReloadData.Click
        Me.Enabled = False
        ReloadCostAnalysisData()
        Me.Enabled = True
        GetDataDate()
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles tsBtnHelp.Click
        ShowPDFHelp(Application.StartupPath & "\BOSS Cost Analysis.pdf")
    End Sub

    Private Sub tsBtnRefreshGrid_Click(sender As Object, e As EventArgs) Handles tsBtnRefreshGrid.Click
        LoadSearchGrid()
       
    End Sub
    Friend Sub LoadSearchGrid()
        SpGetAnalysesSummaryTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.Tables(0))
        UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Clear()
        UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("AnalysisDate", True)
        UltraGrid1.DataBind()

    End Sub
    Private Sub UltraGrid1_Click(sender As Object, e As EventArgs) Handles UltraGrid1.Click
        If UltraGrid1.Selected.Rows.Count > 0 Then
            miAnalysisID = UltraGrid1.Selected.Rows(0).Cells("AnalysisID").Value
            msProjectID = UltraGrid1.Selected.Rows(0).Cells("ProjectID").Value
            tsBtnPrint.Enabled = True
            btnPrintRpt2.Enabled = True
        Else
            tsBtnPrint.Enabled = False
            btnPrintRpt2.Enabled = False

        End If
    End Sub

    Private Sub tsBtnDelete_Click(sender As Object, e As EventArgs) Handles tsBtnDelete.Click
        Dim dbCalls As New DBCalls
        Dim lRtn As Long
        Dim iAnalysisID As Int64
        Dim oRow As UltraGridRow

        Try
            If UltraGrid1.Selected.Rows.Count < 1 Then
                'If MsgBox("Are you sure you want to delete the selected rows?", MsgBoxStyle.YesNo, "Delete Rows from Cost Analysis") = MsgBoxResult.Yes Then
                '    For Each oRow In UltraGrid1.Selected.Rows
                '        iAnalysisID = oRow.Cells("AnalysisID").Value
                '        lRtn = dbCalls.GetReturnValueFromSP("spCostAnalysisDelete", iAnalysisID)
                '    Next
                '    SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.Tables(0))
                '    UltraGrid1.DataBind()
                '    UltraGrid1.ActiveRow = Nothing
                '    UltraGrid1.Selected.Rows.Clear()

                'End If
                MsgBox("You must select rows to delete Cost Analysis records", MsgBoxStyle.OkOnly, "tsBtnDelete_Click")
            Else 'apparently lost my mind 10/27/15 mrb move down into proper end of if statement
                If MsgBox("Are you sure you want to delete the selected rows?", MsgBoxStyle.YesNo, "Delete Rows from Cost Analysis") = MsgBoxResult.Yes Then
                    For Each oRow In UltraGrid1.Selected.Rows
                        iAnalysisID = oRow.Cells("AnalysisID").Value
                        lRtn = dbCalls.GetReturnValueFromSP("spCostAnalysisDelete", iAnalysisID)
                    Next
                    SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.Tables(0))
                    UltraGrid1.DataBind()
                    UltraGrid1.ActiveRow = Nothing
                    UltraGrid1.Selected.Rows.Clear()

                End If
            End If
        Catch ex As Exception
            MsgBox("Error Deleting Analysis records: " & ex.Message, MsgBoxStyle.Critical, "tsBtnDelete_Click")
        Finally
            dbCalls = Nothing
        End Try
    End Sub

    Private Sub UltraGrid1_DoubleClick(sender As Object, e As EventArgs) Handles UltraGrid1.DoubleClick
        Dim iAnalysisID As Int64
        Dim mDetailForm As New CostAnalysisDetail(Me)

        Try
            If UltraGrid1.Selected.Rows.Count > 0 Then

                Me.Enabled = False
                If UltraGrid1.Selected.Rows.Count > 0 Then
                    ' Dim DetailForm As New CostAnalysisDetail(Me)
                    iAnalysisID = UltraGrid1.Selected.Rows(0).Cells("AnalysisID").Value
                    mDetailForm.miAnalysisID = iAnalysisID

                    mDetailForm.ShowDialog(Me)
                    'CostAnalysisDetail.miAnalysisID = iAnalysisID
                    'CostAnalysisDetail.ShowDialog(Me)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error selecting row in grid: " & ex.Message, MsgBoxStyle.Critical, "UltraGrid1_AfterSelectChange")
        Finally
            Me.Enabled = True
        End Try
    End Sub
    Private Sub tsBtnPrint_Click(sender As Object, e As EventArgs) Handles tsBtnPrint.Click
        Dim rptViewer As New ReportViewer
        With RptViewer
            .sReportToRun = "Cost Analysis - Review"
            .sReportTitle = "Cost Analysis - Review for: " & msProjectID
            .sCriteria = miAnalysisID.ToString
            .Show()
        End With
    End Sub

   

    Private Sub btnPrintRpt2_Click(sender As Object, e As EventArgs) Handles btnPrintRpt2.Click
        Dim rptViewer As New ReportViewer
        With rptViewer
            .sReportToRun = "Cost Analysis - Sales"
            .sReportTitle = "Cost Analysis - Sales: " & msProjectID
            .sCriteria = miAnalysisID.ToString
            .Show()

        End With
    End Sub
End Class