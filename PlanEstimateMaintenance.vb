
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class PlanEstimateTablesMaintenance
    Private msPlanGroup As String
    Private msElevation As String
    Private miExteriorID As Integer

    'Private Property HCHDataPlanEstimateSetBindingSource As BindingSource
    'Private Property HCHDataPlanEstimateBindingSource As BindingSource

    Private Sub PlanEstimateTablesMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCHDataPlanEstimate.vwPlanEstimatePlanExteriors' table. You can move, or remove it, as needed.
        Dim bCanEdit As Boolean = HasEditSecurity("mnuPlanEstimateTable", "Menu")
        'TODO: This line of code loads data into the 'HCHDataOptionsDataSet2.spPlanRoomsGet' table. You can move, or remove it, as needed.

        'add security 9/15/16
        If bCanEdit Then
            Me.ugPlanGroups.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.Yes
            Me.ugPlanGroups.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.True
            Me.ugPlanGroups.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
            Me.ugPlanGroups.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
            Me.ugPlanEstimateDetail.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.Yes
            Me.ugPlanEstimateDetail.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.True
            Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
            Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
        Else
            Me.ugPlanGroups.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.No
            Me.ugPlanGroups.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
            Me.ugPlanGroups.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
            Me.ugPlanGroups.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            Me.ugPlanEstimateDetail.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.No
            Me.ugPlanEstimateDetail.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
            Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
            Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        End If
        btnAddRows.Enabled = bCanEdit
        btnAddPlan.Enabled = bCanEdit
        VwPlanEstimatePlanExteriorsTableAdapter1.Connection.ConnectionString = gsConnectionString
        Me.VwPlanEstimatePlanExteriorsTableAdapter1.Fill(Me.HCHDataPlanEstimate.vwPlanEstimatePlanExteriors)

        Dim bGoOn As Boolean
        Try
            bGoOn = LoadPlanExteriors()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
    Private Function LoadPlanExteriors() As Boolean
        ' Me.VwPlanEstimatePlanExteriorsTableAdapter.Fill(Me.HCHDataPlanEstimate.vwPlanEstimatePlanExteriors)

        'Me.VwPlanEstimatePlanExteriorsTableAdapter.Fill(Me.HCHDataPlanEstimateSet.vwPlanEstimatePlanExteriors)
        ''HCHDataOptionsDataSetBindingSource.Sort = "PlanGroup, Elevation, ExteriorShortName"
        ugPlanGroups.DataBind()
        LoadPlanExteriors = True
        ugPlanGroups.DisplayLayout.Bands(0).SortedColumns.Add("PlanGroup", False, True)
        ugPlanGroups.DisplayLayout.Bands(0).SortedColumns.Add("Elevation", False, False)
        ugPlanGroups.DisplayLayout.Bands(0).SortedColumns.Add("ExteriorShortName", False, False)
    End Function

    'Private Sub HCHDataOptionsDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

    'End Sub

    Private Sub ugPlanGroups_AfterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles ugPlanGroups.AfterSelectChange
        ugPlanEstimateDetail.Visible = False
    End Sub

    Private Sub ugPlanGroups_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles ugPlanGroups.InitializeLayout

    End Sub
    Private Sub PopulateDetailGrid()
        Dim sFilter As String = ""
        Dim sPlanGroup As String
        Dim sElevation As String
        Dim sExteriorID As String
        Try
            Dim oRow As UltraGridRow
            If ugPlanGroups.Selected.Rows.Count > 0 Then
                For Each oRow In ugPlanGroups.Selected.Rows
                    With oRow
                        sPlanGroup = oRow.Cells("PlanGroup").Text
                        sElevation = oRow.Cells("Elevation").Text
                        sExteriorID = oRow.Cells("ExteriorID").Text

                    End With
                    If sFilter.Length > 0 Then
                        sFilter += " OR "
                    End If
                    sFilter += " (p.PlanGroup=**" & sPlanGroup & "** and isnull(p.Elevation,****)=**" & sElevation & "**"
                    If sExteriorID <> "" Then
                        sFilter += " and p.ExteriorID=**" & sExteriorID & "**"
                    End If
                    sFilter += ")"
                Next
            End If
            If sFilter.Length > 0 Then
                SpPlanEstimatesGetTableAdapter.Connection.ConnectionString = gsConnectionString
                Me.SpPlanEstimatesGetTableAdapter.Fill(Me.DsDetail.spPlanEstimatesGet, sFilter)
                ugPlanEstimateDetail.DataBind()
            End If
            ugPlanEstimateDetail.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "PopulateDetailGrid")
        End Try
    End Sub

    Private Sub ugPlanEstimateDetail_AfterRowsDeleted(sender As Object, e As EventArgs) Handles ugPlanEstimateDetail.AfterRowsDeleted
        Dim row As DataRow 'UltraGridRow

        Dim iPlanEstimateID As Integer
        Try
            For Each row In DsDetail.Tables(0).Rows 'ugPlanEstimateDetail.Rows
                If row.RowState = DataRowState.Deleted Then
                    iPlanEstimateID = row("PlanEstimateID", DataRowVersion.Original)
                    SpPlanEstimatesGetTableAdapter.Connection.ConnectionString = gsConnectionString '5/28/15
                    SpPlanEstimatesGetTableAdapter.spPlanEstimateDelete(iPlanEstimateID)   'row.Cells("PlanEstimateID").Value)
                End If
            Next
            DsDetail.AcceptChanges()

        Catch ex As Exception
            MsgBox("Error Deleting rows: " & ex.Message, MsgBoxStyle.Critical, "ugPlanEstimateDetail.AfterRowsDeleted")
        End Try


    End Sub


    Private Sub ugPlanEstimateDetail_AfterRowUpdate(sender As Object, e As RowEventArgs) Handles ugPlanEstimateDetail.AfterRowUpdate
        Try
            Dim sResourceID As String = e.Row.Cells("ResourceID").Text
            Dim iPlanEstimateID As Integer = e.Row.Cells("PlanEstimateID").Value
            Dim iActivityCode As Integer = e.Row.Cells("ActivityCode").Value
            Dim sResUsage As String = e.Row.Cells("ResUsage").Text
            Dim cBudgetQty As Decimal = e.Row.Cells("BudgetQty").Value
            Dim sNotes As String = e.Row.Cells("Notes").Text

            ' Me.SpPlanEstimatesGetTableAdapter.spPlanEstimateUpdate(iPlanEstimateID, sResourceID, iActivityCode, sResUsage, cBudgetQty, gsUserID, sNotes)
            'Me.ugPlanEstimateDetail.UpdateData()
            ' e.Row.Cells("UpdatedBy").Value = gsUserID
            ' Me.ugPlanEstimateDetail.UpdateData()
            'Dim gCN2 As New System.Data.SqlClient.SqlConnection(BossAdmin.My.MySettings.HCHDataConnectionString)
            '	spPlanEstimateUpdate (@PlanEstimateID, @ResourceID, @ActivityCode, @ResUsage, @BudgetQty, @UpdatedBy, @Notes)
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.StoredProcedure
            cmd.CommandText = "spPlanEstimateUpdate"
            cmd.Parameters.AddWithValue("@PlanEstimateID", iPlanEstimateID)
            cmd.Parameters.AddWithValue("@ResourceID", sResourceID)
            cmd.Parameters.AddWithValue("@ActivityCode", iActivityCode)
            cmd.Parameters.AddWithValue("@ResUsage", sResUsage)
            cmd.Parameters.AddWithValue("@BudgetQty", cBudgetQty)
            cmd.Parameters.AddWithValue("@Notes", sNotes)
            cmd.Parameters.AddWithValue("@Updatedby", gsUserID)
            cmd.Connection = gCN
            'gCN.Open()
            cmd.ExecuteNonQuery()
            'gCN.Close()

            'Me.DsDetail
            ' DsDetail.AcceptChanges()
        Catch ex As Exception
            MsgBox("Error in Plan Estimate Maintenance: " & ex.Message, MsgBoxStyle.Critical, "ugPlanEstimateDetail_AfterRowUpdate")
        End Try
    End Sub


    Private Sub btnAddPlan_Click(sender As Object, e As EventArgs) Handles btnAddPlan.Click


        Try
            PlanEstimateAddRows.isAddNewPlan = True
            miExteriorID = 0
            msPlanGroup = ""
            msElevation = ""

            If PlanEstimateAddRows.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                msPlanGroup = PlanEstimateAddRows.sPlanGroup
                msElevation = PlanEstimateAddRows.sElevation
                miExteriorID = PlanEstimateAddRows.iExteriorID
                LoadPlanExteriors()
                PlanEstimateAddRows.sPlanGroup = ""
                PlanEstimateAddRows.sElevation = ""
                PlanEstimateAddRows.iExteriorID = 0
                'miExteriorID = 0
                'msPlanGroup = ""
                'msElevation = ""
                'save records
                ' SpPlanEstimatesGetTableAdapter.spPlanEstimateInsert(iPlanGroup.ToString, sElevation, iExteriorID, gsUserID)
                ' PopulateDetailGrid()
            End If
        Catch ex As Exception
            MsgBox("Error in BossAdmn " & ex.Message, MsgBoxStyle.Critical, "btnAddRows_Click")
        End Try

    End Sub

    Private Sub btnAddRows_Click1(sender As Object, e As EventArgs) Handles btnAddRows.Click
        'Dim iPlanGroup As Integer
        'Dim sElevation As String
        'Dim iExteriorID As Integer
        Try
            If ugPlanGroups.Selected.Rows.Count > 0 And Not ugPlanGroups.Selected.Rows(0).Cells Is Nothing = True Then
                msPlanGroup = ugPlanGroups.Selected.Rows(0).Cells("PlanGroup").Text
                msElevation = ugPlanGroups.Selected.Rows(0).Cells("Elevation").Text
                If ugPlanGroups.Selected.Rows(0).Cells("ExteriorID").Text <> "" Then
                    miExteriorID = ugPlanGroups.Selected.Rows(0).Cells("ExteriorID").Text
                Else
                    miExteriorID = 0
                End If

                Select Case ugPlanGroups.Selected.Rows.Count
                    'Case 0
                    '    MsgBox("Please select one Plan row in the Plan Selection grid to Add New Rows.", MsgBoxStyle.Information, "Add New Rows")
                    Case Is > 1
                        MsgBox("Please select only ONE row in the Plan Selection grid to add new records.", MsgBoxStyle.Information, "Add New Rows")
                    Case Else
                        With PlanEstimateAddRows
                            .uLblPlan.Text = msPlanGroup
                            .uLblElevation.Text = msElevation
                            .uLblExterior.Text = ugPlanGroups.Selected.Rows(0).Cells("ExteriorName").Text
                            .iExteriorID = miExteriorID
                            .isAddNewPlan = False
                        End With
                        If PlanEstimateAddRows.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                            'save records
                            'SpPlanEstimatesGetTableAdapter.spPlanEstimateInsert(iPlanGroup.ToString, sElevation, iExteriorID, gsUserID)
                            PopulateDetailGrid()
                            miExteriorID = 0
                            msPlanGroup = ""
                            msElevation = ""
                        End If
                End Select
            Else
                MsgBox("Please select one Plan Detail row in the Plan Selection grid to Add New Rows.", MsgBoxStyle.Information, "Add New Rows")
            End If
        Catch ex As Exception
            MsgBox("Error in BossAdmn " & ex.Message, MsgBoxStyle.Critical, "btnAddRows_Click")
        End Try

    End Sub

    Private Sub btnPopulateDetail_Click1(sender As Object, e As EventArgs) Handles btnPopulateDetail.Click
        If ugPlanGroups.Selected.Rows.Count > 0 Then 'added 5/10/15
            If Not ugPlanGroups.Selected.Rows(0).Cells Is Nothing = True Then '10/21/14
                PopulateDetailGrid()
            End If
        Else
            MsgBox("Please select a row in the Plan Group grid to Populate the Plan Estimate Detail grid.")
        End If
    End Sub


End Class