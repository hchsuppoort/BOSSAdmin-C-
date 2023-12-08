<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EstimatingMaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanEstimateTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TakeoffTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewEstimateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DivisionsToolstripMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MilestonesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotificationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PositionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecurityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VPOReasonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorCostToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMnuItemCostAnalysis = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMnuItemCostAnalysisSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsMnuItemCostAnalysisReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowMaintenanceToolStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppStylistRuntime1 = New Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstimatingMaintenanceToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.VendorsToolStripMenuItem, Me.tsMnuItemCostAnalysis, Me.WindowMaintenanceToolStripItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.WindowMaintenanceToolStripItem
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(16, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(2103, 56)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EstimatingMaintenanceToolStripMenuItem
        '
        Me.EstimatingMaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanEstimateTablesToolStripMenuItem, Me.TakeoffTablesToolStripMenuItem, Me.ViewEstimateToolStripMenuItem})
        Me.EstimatingMaintenanceToolStripMenuItem.Name = "EstimatingMaintenanceToolStripMenuItem"
        Me.EstimatingMaintenanceToolStripMenuItem.Size = New System.Drawing.Size(379, 48)
        Me.EstimatingMaintenanceToolStripMenuItem.Text = "Maintenance - Estimating"
        '
        'PlanEstimateTablesToolStripMenuItem
        '
        Me.PlanEstimateTablesToolStripMenuItem.Name = "PlanEstimateTablesToolStripMenuItem"
        Me.PlanEstimateTablesToolStripMenuItem.Size = New System.Drawing.Size(450, 54)
        Me.PlanEstimateTablesToolStripMenuItem.Text = "Plan Estimate Tables"
        '
        'TakeoffTablesToolStripMenuItem
        '
        Me.TakeoffTablesToolStripMenuItem.Name = "TakeoffTablesToolStripMenuItem"
        Me.TakeoffTablesToolStripMenuItem.Size = New System.Drawing.Size(450, 54)
        Me.TakeoffTablesToolStripMenuItem.Text = "Take-off Tables"
        '
        'ViewEstimateToolStripMenuItem
        '
        Me.ViewEstimateToolStripMenuItem.Name = "ViewEstimateToolStripMenuItem"
        Me.ViewEstimateToolStripMenuItem.Size = New System.Drawing.Size(450, 54)
        Me.ViewEstimateToolStripMenuItem.Text = "View Estimate"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DivisionsToolstripMenu, Me.MilestonesToolStripMenuItem, Me.NotificationsToolStripMenuItem, Me.PositionsToolStripMenuItem, Me.ProjectsToolStripMenuItem, Me.SecurityToolStripMenuItem, Me.UsersToolStripMenuItem, Me.VPOReasonsToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(431, 48)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance - Lookup Tables"
        '
        'DivisionsToolstripMenu
        '
        Me.DivisionsToolstripMenu.Name = "DivisionsToolstripMenu"
        Me.DivisionsToolstripMenu.Size = New System.Drawing.Size(448, 54)
        Me.DivisionsToolstripMenu.Text = "Divisions"
        '
        'MilestonesToolStripMenuItem
        '
        Me.MilestonesToolStripMenuItem.Name = "MilestonesToolStripMenuItem"
        Me.MilestonesToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.MilestonesToolStripMenuItem.Text = "Milestones"
        '
        'NotificationsToolStripMenuItem
        '
        Me.NotificationsToolStripMenuItem.Name = "NotificationsToolStripMenuItem"
        Me.NotificationsToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.NotificationsToolStripMenuItem.Text = "Notifications"
        Me.NotificationsToolStripMenuItem.Visible = False
        '
        'PositionsToolStripMenuItem
        '
        Me.PositionsToolStripMenuItem.Name = "PositionsToolStripMenuItem"
        Me.PositionsToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.PositionsToolStripMenuItem.Text = "Positions"
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.ProjectsToolStripMenuItem.Text = "Projects"
        '
        'SecurityToolStripMenuItem
        '
        Me.SecurityToolStripMenuItem.Name = "SecurityToolStripMenuItem"
        Me.SecurityToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.SecurityToolStripMenuItem.Text = "Security"
        Me.SecurityToolStripMenuItem.Visible = False
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'VPOReasonsToolStripMenuItem
        '
        Me.VPOReasonsToolStripMenuItem.Name = "VPOReasonsToolStripMenuItem"
        Me.VPOReasonsToolStripMenuItem.Size = New System.Drawing.Size(448, 54)
        Me.VPOReasonsToolStripMenuItem.Text = "VPO Reasons"
        '
        'VendorsToolStripMenuItem
        '
        Me.VendorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendorCostToolStripMenuItem})
        Me.VendorsToolStripMenuItem.Name = "VendorsToolStripMenuItem"
        Me.VendorsToolStripMenuItem.Size = New System.Drawing.Size(151, 48)
        Me.VendorsToolStripMenuItem.Text = "Vendors"
        '
        'VendorCostToolStripMenuItem
        '
        Me.VendorCostToolStripMenuItem.Name = "VendorCostToolStripMenuItem"
        Me.VendorCostToolStripMenuItem.Size = New System.Drawing.Size(553, 54)
        Me.VendorCostToolStripMenuItem.Text = "Vendor Costs and Contracts"
        '
        'tsMnuItemCostAnalysis
        '
        Me.tsMnuItemCostAnalysis.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsMnuItemCostAnalysisSearch, Me.tsMnuItemCostAnalysisReports})
        Me.tsMnuItemCostAnalysis.Name = "tsMnuItemCostAnalysis"
        Me.tsMnuItemCostAnalysis.Size = New System.Drawing.Size(216, 48)
        Me.tsMnuItemCostAnalysis.Text = "Cost Analysis"
        '
        'tsMnuItemCostAnalysisSearch
        '
        Me.tsMnuItemCostAnalysisSearch.Name = "tsMnuItemCostAnalysisSearch"
        Me.tsMnuItemCostAnalysisSearch.Size = New System.Drawing.Size(468, 54)
        Me.tsMnuItemCostAnalysisSearch.Text = "Cost Analysis Search"
        '
        'tsMnuItemCostAnalysisReports
        '
        Me.tsMnuItemCostAnalysisReports.Name = "tsMnuItemCostAnalysisReports"
        Me.tsMnuItemCostAnalysisReports.Size = New System.Drawing.Size(468, 54)
        Me.tsMnuItemCostAnalysisReports.Text = "Cost Analysis Reports"
        '
        'WindowMaintenanceToolStripItem
        '
        Me.WindowMaintenanceToolStripItem.Name = "WindowMaintenanceToolStripItem"
        Me.WindowMaintenanceToolStripItem.Size = New System.Drawing.Size(152, 48)
        Me.WindowMaintenanceToolStripItem.Text = "Window"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(104, 48)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(304, 54)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(304, 54)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(304, 54)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(301, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(304, 54)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(2103, 1173)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(8)
        Me.Name = "mdiMain"
        Me.Text = "BOSSAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MilestonesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotificationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecurityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VPOReasonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowMaintenanceToolStripItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DivisionsToolstripMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppStylistRuntime1 As Infragistics.Win.AppStyling.Runtime.AppStylistRuntime
    Friend WithEvents EstimatingMaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanEstimateTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TakeoffTablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuItemCostAnalysis As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuItemCostAnalysisSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsMnuItemCostAnalysisReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewEstimateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorCostToolStripMenuItem As ToolStripMenuItem
End Class
