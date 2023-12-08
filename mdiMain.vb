Public Class mdiMain

    Private Sub NotificationsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NotificationsToolStripMenuItem.Click

    End Sub

    Private Sub MilestonesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MilestonesToolStripMenuItem.Click
        Dim oForm As New Milestones
        OpenMDIChild(oForm)

    End Sub
    Private Sub VPOReasonsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VPOReasonsToolStripMenuItem.Click
        Dim oForm As New VPOReasons
        OpenMDIChild(oForm)

    End Sub
    Public Sub OpenMDIChild(ByRef oForm As Form)
        'this code adds the form to the windows list and allows multiples of the same window
        'if we open a window from within another window, we should use this module
        ' if we are setting captions based on criteria, we can set them before the form is passwed3
        Dim newMDIChild As New Form
        newMDIChild = oForm
        newMDIChild.mdiparent = Me
        newMDIChild.Show()
    End Sub
    Private Sub mdiMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sVersion As String = ""
        If gsDatabase = "" Then
            Application.Exit()
        Else 'mrb 10/21/14
            sVersion = My.Application.Info.Version.ToString
            Me.Text = "BOSSAdmin V " & sVersion
            MenusShow()
        End If
    End Sub

    Private Sub MenusShow()
        Dim bIsCostAnalysis As Boolean
        bIsCostAnalysis = gsDatabase = "HCHDataQA"
        'add security 9/15/16 mrb
        TakeoffTablesToolStripMenuItem.Visible = bIsCostAnalysis = False And HasViewSecurity("mnuTakeOffTable", "Menu")
        PlanEstimateTablesToolStripMenuItem.Visible = bIsCostAnalysis = False And HasViewSecurity("mnuPlanEstimateTable", "Menu")
        MaintenanceToolStripMenuItem.Visible = bIsCostAnalysis = False
        tsMnuItemCostAnalysis.Visible = bIsCostAnalysis
        ViewEstimateToolStripMenuItem.Visible = bIsCostAnalysis = True
        UsersToolStripMenuItem.Visible = HasViewSecurity("mnuBAUserAdmin", "Menu")
        PositionsToolStripMenuItem.Visible = HasViewSecurity("mnuBAPositions", "Menu")
        DivisionsToolstripMenu.Visible = HasViewSecurity("mnuBAAddEditDivision", "Menu")
        ProjectsToolStripMenuItem.Visible = HasViewSecurity("mnuBAProjectMaintenance", "Menu")
        SecurityToolStripMenuItem.Visible = HasViewSecurity("mnuBASecurity", "Menu")
        VPOReasonsToolStripMenuItem.Visible = HasViewSecurity("mnuBAVPOReasons", "Menu")
        MilestonesToolStripMenuItem.Visible = HasViewSecurity("mnuBAMilestones", "Menu")
        ' HelpToolStripMenuItem.Visible = False 'mrb 6/22/22
        tsMnuItemCostAnalysisReports.Visible = False 'mrb 6/22/22
    End Sub

    Private Sub PositionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PositionsToolStripMenuItem.Click
        Dim oForm As New Positions
        OpenMDIChild(oForm)
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        Dim oForm As New UserMaintenance
        OpenMDIChild(oForm)
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles DivisionsToolstripMenu.Click
        Dim oForm As New Divisions
        OpenMDIChild(oForm)
    End Sub

    Private Sub ProjectsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProjectsToolStripMenuItem.Click
        Dim oForm As New ProjectMaintenance
        OpenMDIChild(oForm)
    End Sub

    Private Sub PlanEstimateTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanEstimateTablesToolStripMenuItem.Click
        Dim oForm As New PlanEstimateTablesMaintenance
        OpenMDIChild(oForm)
    End Sub

    Private Sub tsMnuItemCostAnalysisSearch_Click(sender As Object, e As EventArgs) Handles tsMnuItemCostAnalysisSearch.Click
        Dim oForm As New CostAnalysisSearch
        OpenMDIChild(oForm)
    End Sub

    Private Sub ViewEstimateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEstimateToolStripMenuItem.Click
        Dim oForm As New EstimateView
        OpenMDIChild(oForm)
    End Sub
    Public Sub ViewEstimateForm(sJobID As String)
        Dim oForm As New EstimateView
        oForm.msJobID = sJobID
        oForm.mbLockJobs = False
        OpenMDIChild(oForm)
    End Sub

    Private Sub TakeoffTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TakeoffTablesToolStripMenuItem.Click
        Dim oForm As New PlanRoomsMaintenance
        OpenMDIChild(oForm)
    End Sub

    Private Sub VendorCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorCostToolStripMenuItem.Click
        Dim oForm As New VendorCosts
        OpenMDIChild(oForm)
    End Sub

    Private Sub MaintenanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaintenanceToolStripMenuItem.Click

    End Sub
End Class

