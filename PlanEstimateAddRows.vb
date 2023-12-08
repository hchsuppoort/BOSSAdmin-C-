Imports Infragistics.Win.UltraWinGrid
Imports BossAdmin.dsDetail
Imports BossAdmin.dsDetailTableAdapters


Public Class PlanEstimateAddRows
    Public isAddNewPlan As Boolean
    Public iExteriorID As Integer
    Public sElevation As String
    Public sPlanGroup As String

    Private isOK As Boolean
    Private _theButton As MouseButtons = MouseButtons.None
    Friend PostPlanItems As spPlanEstimatesGetTableAdapter
    Private Sub PlanEstimateAddRows_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'Me.UltraGrid1.PerformAction(UltraGridAction.DeleteRows)
        'Dim icount As Integer = UltraGrid1.Rows.Count
        UltraGrid1.DataSource = Nothing '10/20/14
        HCHDataOptionsDataPlanEstimateAdd.Clear() '10/20/14
        ' Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
    Private Sub PlanEstimateAddRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCHDataDataSet2.ProjectExterior' table. You can move, or remove it, as needed.
        ProjectExteriorTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.ProjectExteriorTableAdapter.Fill(Me.HCHDataDataSet2.ProjectExterior)
        'TODO: This line of code loads data into the 'HCHDataDataSet1.PlanElevations() ' table. You can move, or remove it, as needed.
        PlanElevationsTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.PlanElevationsTableAdapter.Fill(Me.HCHDataDataSet1.PlanElevations)
        'TODO: This line of code loads data into the 'HCHDataDataSet.vwPlanGroups' table. You can move, or remove it, as needed.
        VwPlanGroupsTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.VwPlanGroupsTableAdapter.Fill(Me.HCHDataDataSet.vwPlanGroups)
        'TODO: This line of code loads data into the 'HCHDataOptionsDataPlanEstimateAdd.PlanEstimate' table. You can move, or remove it, as needed.
        If isAddNewPlan = False Then 'called by add rows
            lblConnection.Text = gsConnectionString '5/28/15 mrb for testing
            PlanEstimateTableAdapter.Connection.ConnectionString = gsConnectionString
            Me.PlanEstimateTableAdapter.Fill(Me.HCHDataOptionsDataPlanEstimateAdd.PlanEstimate)
            pnlNewPlan.Visible = False
            ulAddNewPlan.Visible = False
            pnlAddNewRows.Visible = True
        Else 'called by add new plan
            uceElevation.SelectedText = ""
            uceExterior.SelectedText = ""
            ucePlanGroup.SelectedText = ""
            lblConnection.Text = gsConnectionString '5/28/15 mrb for testing
            PlanEstimateTableAdapter.Connection.ConnectionString = gsConnectionString
            Me.PlanEstimateTableAdapter.Fill(Me.HCHDataOptionsDataPlanEstimateAdd.PlanEstimate)
            pnlNewPlan.Visible = True
            ulAddNewPlan.Visible = True
            pnlAddNewRows.Visible = False
        End If
        UltraGrid1.DataSource = HCHDataOptionsDataPlanEstimateAdd '10/20/14
        UltraGrid1.DataBind() '10/20/14

    End Sub

    Private Sub UltraToolbarsManager1_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles UltraToolbarsManager1.ToolClick
        Try
            Select Case e.Tool.Key
                Case "Undo"
                    Me.UltraGrid1.PerformAction(UltraGridAction.Undo)
                Case "Redo"
                    Me.UltraGrid1.PerformAction(UltraGridAction.Redo)
                Case "Copy"
                    Me.UltraGrid1.PerformAction(UltraGridAction.Copy)
                Case "Paste"
                    Me.UltraGrid1.PerformAction(UltraGridAction.Paste)
                Case "Cut"
                    Me.UltraGrid1.PerformAction(UltraGridAction.Cut)
                Case "Delete"
                    Me.UltraGrid1.PerformAction(UltraGridAction.DeleteCells)
                Case "Select All"
                    Dim row As UltraGridRow
                    For Each row In Me.UltraGrid1.Rows.GetRowEnumerator(GridRowType.DataRow, Nothing, Nothing)
                        row.Selected = True
                    Next row
            End Select
        Catch ex As Exception
            MsgBox("Error in Plan Estimate - Add Rows.  Error: " & ex.Message, MsgBoxStyle.Critical, "UltraToobarsManager1_ToolClick") ' 10/20/14
        End Try

    End Sub

    'Private Sub UltraGrid1_MouseDown(sender As Object, e As MouseEventArgs)
    '    '_theButton = e.Button
    'End Sub

    'Private Sub UltraGrid1_Click(sender As Object, e As EventArgs) Handles UltraGrid1.Click
    '    'If we Right Click, show the Context Menu 
    '    'If _theButton = MouseButtons.Right Then
    '    '    Me.UltraToolbarsManager1.ShowPopup("Edit")
    '    'End If
    'End Sub

    'Private Sub UltraGrid1_PressAndHoldGesture(sender As Object, e As Infragistics.Win.Touch.PressAndHoldGestureEventArgs) Handles UltraGrid1.PressAndHoldGesture
    '    'context menu
    '    'Me.UltraToolbarsManager1.ShowPopup("Edit")
    'End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim PostPlanItems As New spPlanEstimatesGetTableAdapter
        If isAddNewPlan Then
            sPlanGroup = ucePlanGroup.Text
            sElevation = uceElevation.Text.ToLower
            iExteriorID = uceExterior.Value '.GetItemText("ExteriorID")
        Else
            sPlanGroup = uLblPlan.Text
            sElevation = Trim(uLblElevation.Text) '5/28/15 mrb was causing issue with a space in it
        End If
        If sPlanGroup = "" Then 'not ready to save 10/17/14
            MsgBox("Please select a Plan Group", MsgBoxStyle.Exclamation, "Save Rows")
        Else
            If (sElevation <> "" And iExteriorID = 0) Or (sElevation = "" And iExteriorID <> 0) Then 'both must be selected or neither selected              
                MsgBox("If you select an Elevation, you must also select an Exterior.  Otherwise both must be blank", MsgBoxStyle.Exclamation, "Save Rows")
            Else
                PostPlanItems.Connection.ConnectionString = gsConnectionString
                PlanEstimateTableAdapter.Update(HCHDataOptionsDataPlanEstimateAdd)
                PostPlanItems.spPlanEstimateInsert(sPlanGroup, sElevation, iExteriorID, gsUserID)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If

    End Sub



End Class