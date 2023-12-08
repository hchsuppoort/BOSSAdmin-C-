Option Explicit On
Imports BossAdmin.DBCalls
Imports System.Data
Imports System
Imports Infragistics.Win.UltraWinGrid
Imports System.IO

Public Class CostAnalysisPlanChooser
    Public msPlanProjectID As String
    Dim msOptions As New Infragistics.Win.UltraWinEditors.UltraOptionSet
    ' Dim mdsData As New DataSet()
    'Dim msPathCost As String
    Private Function GenerateEmptyPlanDataSet() As DataSet
        Dim dsData As New DataSet()
        Dim dtData As New DataTable()

        dtData.Columns.Add(New DataColumn("PlanID", GetType(String)))
        dtData.Columns.Add(New DataColumn("FileName", GetType(String)))
        dtData.Columns.Add(New DataColumn("PlanEstimate", GetType(Boolean)))
        dtData.Columns.Add(New DataColumn("Source"))
        dtData.Columns.Add(New DataColumn("Use"))
        dsData.Tables.Add(dtData)

        dtData = Nothing

        Return dsData

    End Function
    Private Function IsInEstimateTable(ByVal sPlanID As String) As Boolean
        Dim rs As New DataSet
        Dim dbCalls As New DBCalls
        Try
            IsInEstimateTable = dbCalls.GetDataFromSP(rs, "spPlanInEstimateTable", sPlanID)
            If Rs.tables.count > 0 Then
                If rs.Tables(0).Rows.Count > 0 Then
                    IsInEstimateTable = rs.Tables(0).Rows(0).Item(0) = 1
                Else
                    MsgBox("No Records in Plan Estimate table for this plan", MsgBoxStyle.Information, "IsInEstimateTable")
                    IsInEstimateTable = False
                End If
            Else
                IsInEstimateTable = False
                MsgBox(gCN.ConnectionString, MsgBoxStyle.Critical, "IsInEstimateTable")
            End If
        Catch ex As Exception
            MsgBox("Error checking for estimate " & ex.Message, MsgBoxStyle.Critical, "IsInEstimateTable")
            IsInEstimateTable = False
        Finally
            rs = Nothing
            dbCalls = Nothing
        End Try
    End Function
    Private Sub CostAnalysisPlanChooser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("PlanID", False)
    End Sub

    Private Sub CostAnalysisPlanChooser_Load(sender As Object, e As EventArgs) Handles Me.Load
        If gsCostAnalysisData Is Nothing Then
            gsCostAnalysisData = New DataSet
            gsCostAnalysisData = GenerateEmptyPlanDataSet()
        End If
        UltraGrid1.DataSource = gsCostAnalysisData
        UltraGrid1.DataBind()
        UltraGrid1.DisplayLayout.Bands(0).Columns("FileName").Width = 300
        UltraGrid1.DisplayLayout.Bands(0).Columns("Planid").Width = 60
        With UltraGrid1.DisplayLayout.Bands(0)
            .Columns("PlanEstimate").Width = 60
            .Columns("PlanEstimate").Header.Caption = "Plan Estimate"
            .Columns("FileName").Header.Caption = "File Name"
            .Columns("PlanID").Header.Caption = "Plan"
            .Columns("Use").Width = 150
            .Columns("Source").Width = 100
            .Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.True
        End With
        Dim valueListItem1 As New Infragistics.Win.ValueListItem()
        Dim valueListItem2 As New Infragistics.Win.ValueListItem()
        Dim valueListItem3 As New Infragistics.Win.ValueListItem()

        'Assign a data value for each option
        valueListItem1.DataValue = "Plan Estimate"
        valueListItem2.DataValue = "File"
        valueListItem3.DataValue = "Do Not Use"

        'Assign the text which will be displayed within the UltraGrid for each option
        valueListItem1.DisplayText = "Plan Estimate"
        valueListItem2.DisplayText = "File"
        valueListItem3.DisplayText = "Do Not Use"

        'Add each ValueListItem object to the items collection of the ultraOptionSet
        msOptions.Items.AddRange(New Infragistics.Win.ValueListItem() {valueListItem1, valueListItem2, valueListItem3})

        'Set the UltraOptionSet instance as the EditorComponent for the first column of the UltraGrid
        UltraGrid1.DisplayLayout.Bands(0).Columns("Use").EditorComponent = msOptions
        GetCostPlanPath()

    End Sub

    Private Sub btnProjectPlans_Click(sender As Object, e As EventArgs) Handles btnProjectPlans.Click
        Dim dsData As New DataSet
        Dim dbCalls As New DBCalls
        '  Dim vInPlanEstimate As VariantType
        Dim dRow As DataRow
        Dim sPlanId As String
        Dim sPath As String
        Dim bInEstimate As Boolean
        Dim bInFolder As Boolean = False
        Try
            Me.Enabled = False
            mdiMain.UseWaitCursor = True
            If dbCalls.GetDataFromSP(dsData, "spGetPlansForProject", msPlanProjectID, 1) Then
                'populate grid
                For Each dRow In dsData.Tables(0).Rows
                    'check for files and plan estimate rows
                    sPlanId = Trim(dRow.Item("PlanId"))
                    'If sPlanId = "2554ab" Then
                    '    sPlanId = "2554ab"
                    'End If
                    'If vInPlanEstimate = Nothing Then
                    '    bInEstimate = False
                    'Else
                    '    bInEstimate = True
                    'End If
                    '12/2/14 mrb
                    bInEstimate = IsInEstimateTable(sPlanId)
                    sPath = gsPathCost & "\" & sPlanId & ".xlsx"
                    If FileExists(sPath) Then
                        bInFolder = True
                    Else
                        bInFolder = False
                        sPath = ""
                    End If
            With UltraGrid1
                        If bInEstimate = False Then
                            If bInFolder Then
                                gsCostAnalysisData.Tables(0).Rows.Add(New Object() {sPlanId, sPath, bInEstimate, "Project Plans", "File"})
                            Else
                                gsCostAnalysisData.Tables(0).Rows.Add(New Object() {sPlanId, sPath, bInEstimate, "Project Plans"})
                            End If
                        Else
                            gsCostAnalysisData.Tables(0).Rows.Add(New Object() {sPlanId, sPath, CheckState.Checked, "Project Plans", "Plan Estimate"})
                        End If

            End With
                Next
                UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("PlanID", False)
            End If
        Catch ex As Exception
            MsgBox("Error in Loading Project Plans: " & ex.Message, MsgBoxStyle.Critical, "btnProjectPlans_Click")
        Finally
            Me.Enabled = True
            mdiMain.UseWaitCursor = True
        End Try
    End Sub

    Private Sub btnPlansFromFolder_Click(sender As Object, e As EventArgs) Handles btnPlansFromFolder.Click
        'Dim vInPlanEstimate As VariantType
        Dim bInEstimate As Boolean
        Dim sPlanID As String
        Dim sPath As String
        Dim dbCalls As New DBCalls
        Try
            ' GetCostPlanPath()
            Me.Enabled = False
            mdiMain.UseWaitCursor = True
            Dim diSource As DirectoryInfo = New DirectoryInfo(gsPathCost)
            If Directory.Exists(gsPathCost) = True Then
                ' Copy each file into it's new directory. 
                For Each fi As FileInfo In diSource.GetFiles()
                    If fi.Extension = ".xlsx" Then
                        sPlanID = fi.Name.Replace(".xlsx", "")
                        'vInPlanEstimate = dbCalls.GetReturnValueFromSP("spPlanInEstimateTable", sPlanID)
                        bInEstimate = IsInEstimateTable(sPlanID) '12/2/14

                        sPath = fi.FullName
                        'If vInPlanEstimate = Nothing Then
                        '    bInEstimate = False
                        'Else
                        '    bInEstimate = True
                        'End If
                        With UltraGrid1
                            If bInEstimate = False Then
                                gsCostAnalysisData.Tables(0).Rows.Add(New Object() {sPlanID, sPath, bInEstimate, "CostPlan Folder", "File"})
                            Else
                                gsCostAnalysisData.Tables(0).Rows.Add(New Object() {sPlanID, sPath, CheckState.Checked, "CostPlan Folder", "Plan Estimate"})
                            End If
                        End With
                    End If
                Next
                UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("PlanID", False)
            End If
        Catch ex As Exception
            MsgBox("Error listing plan files in folder: " & ex.Message, MsgBoxStyle.Critical, "btnPlansFromFolder_Click")
        Finally
            Me.Enabled = True
            mdiMain.UseWaitCursor = False
        End Try
    End Sub

    Private Sub UltraGrid1_AfterCellUpdate(sender As Object, e As CellEventArgs) Handles UltraGrid1.AfterCellUpdate
        If e.Cell.Column.Key = "PlanID" And e.Cell.Text <> "" Then
            If IsInEstimateTable(e.Cell.Text) Then
                UltraGrid1.DisplayLayout.ActiveRow.Cells("PlanEstimate").Value = CheckState.Checked
                UltraGrid1.DisplayLayout.ActiveRow.Cells("Use").Value = "Plan Estimate"
            Else
                UltraGrid1.DisplayLayout.ActiveRow.Cells("PlanEstimate").Value = CheckState.Unchecked
            End If
        End If
    End Sub

    Private Sub UltraGrid1_AfterRowInsert(sender As Object, e As RowEventArgs) Handles UltraGrid1.AfterRowInsert
        UltraGrid1.DisplayLayout.ActiveRow.Cells("Source").Value = "User Added"
 
    End Sub

 
    Private Sub btnSavePlans_Click(sender As Object, e As EventArgs) Handles btnSavePlans.Click
        Me.Close()
    End Sub

    Private Sub btnClearAllPlans_Click(sender As Object, e As EventArgs) Handles btnClearAllPlans.Click
        gsCostAnalysisData = Nothing
        gsCostAnalysisData = GenerateEmptyPlanDataSet()
        UltraGrid1.DataSource = gsCostAnalysisData
        UltraGrid1.DataBind()

    End Sub
End Class