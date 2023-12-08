<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanEstimateTablesMaintenance
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("vwPlanEstimatePlanExteriors", -1)
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanGroup")
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Elevation", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorID")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorName")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorShortName")
        Dim GridBagConstraint3 As Infragistics.Win.Layout.GridBagConstraint = New Infragistics.Win.Layout.GridBagConstraint()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spPlanEstimatesGet", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanEstimateID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanGroup")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Elevation")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Exterior")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorID")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceID")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceName")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActivityCode")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Activity")
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ResUsage", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetQty")
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedDate")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedDate")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Notes")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedBy")
        Dim RowLayout1 As Infragistics.Win.UltraWinGrid.RowLayout = New Infragistics.Win.UltraWinGrid.RowLayout("test")
        Dim RowLayoutColumnInfo1 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PlanEstimateID", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo2 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PlanGroup", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo3 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Elevation", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo4 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Exterior", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo5 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ExteriorID", -1, Infragistics.Win.DefaultableBoolean.[True])
        Dim RowLayoutColumnInfo6 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ResourceID", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo7 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ResourceName", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo8 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ActivityCode", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo9 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activity", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo10 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ResUsage", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo11 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "BudgetQty", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo12 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CreatedDate", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo13 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CreatedBy", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo14 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UpdatedDate", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo15 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Notes", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim RowLayoutColumnInfo16 As Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo = New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UpdatedBy", -1, Infragistics.Win.DefaultableBoolean.[False])
        Dim GridBagConstraint2 As Infragistics.Win.Layout.GridBagConstraint = New Infragistics.Win.Layout.GridBagConstraint()
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Edit")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Undo")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Edit")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Undo")
        Dim GridBagConstraint4 As Infragistics.Win.Layout.GridBagConstraint = New Infragistics.Win.Layout.GridBagConstraint()
        Dim GridBagConstraint1 As Infragistics.Win.Layout.GridBagConstraint = New Infragistics.Win.Layout.GridBagConstraint()
        Me.ugPlanGroups = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.HCHDataPlanEstimateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataPlanEstimate = New BossAdmin.HCHDataPlanEstimate()
        Me.ugPlanEstimateDetail = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.SpPlanEstimatesGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDetail = New BossAdmin.dsDetail()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me.PlanEstimateTablesMaintenance_Fill_Panel = New Infragistics.Win.Misc.UltraPanel()
        Me.btnPopulateDetail = New System.Windows.Forms.Button()
        Me.UltraPanel3 = New Infragistics.Win.Misc.UltraPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UltraPanel1 = New Infragistics.Win.Misc.UltraPanel()
        Me.btnAddRows = New System.Windows.Forms.Button()
        Me.btnAddPlan = New System.Windows.Forms.Button()
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.UltraGridBagLayoutManager1 = New Infragistics.Win.Misc.UltraGridBagLayoutManager(Me.components)
        Me.SpPlanEstimatesGetTableAdapter = New BossAdmin.dsDetailTableAdapters.spPlanEstimatesGetTableAdapter()
        Me.VwPlanEstimatePlanExteriorsTableAdapter1 = New BossAdmin.HCHDataPlanEstimateTableAdapters.vwPlanEstimatePlanExteriorsTableAdapter()
        CType(Me.ugPlanGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataPlanEstimateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataPlanEstimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugPlanEstimateDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPlanEstimatesGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.SuspendLayout()
        Me.PlanEstimateTablesMaintenance_Fill_Panel.SuspendLayout()
        Me.UltraPanel3.ClientArea.SuspendLayout()
        Me.UltraPanel3.SuspendLayout()
        Me.UltraPanel1.ClientArea.SuspendLayout()
        Me.UltraPanel1.SuspendLayout()
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugPlanGroups
        '
        Me.ugPlanGroups.DataSource = Me.HCHDataPlanEstimateBindingSource
        UltraGridColumn17.Header.Caption = "Plan"
        UltraGridColumn17.Header.VisiblePosition = 0
        UltraGridColumn17.Width = 62
        UltraGridColumn18.Header.VisiblePosition = 2
        UltraGridColumn18.Width = 85
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn19.Hidden = True
        UltraGridColumn20.Header.Caption = "Exterior"
        UltraGridColumn20.Header.VisiblePosition = 4
        UltraGridColumn20.Width = 145
        UltraGridColumn21.Header.Caption = "Exterior Code"
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.Width = 66
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21})
        UltraGridBand1.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanGroups.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugPlanGroups.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanGroups.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugPlanGroups.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanGroups.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugPlanGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridBagConstraint3.Anchor = Infragistics.Win.Layout.AnchorType.TopLeft
        GridBagConstraint3.Fill = Infragistics.Win.Layout.FillType.Both
        GridBagConstraint3.Insets.Right = 5
        GridBagConstraint3.OriginX = 0
        GridBagConstraint3.OriginY = 1
        Me.UltraGridBagLayoutManager1.SetGridBagConstraint(Me.ugPlanGroups, GridBagConstraint3)
        Me.ugPlanGroups.Location = New System.Drawing.Point(5, 57)
        Me.ugPlanGroups.MaximumSize = New System.Drawing.Size(395, 653)
        Me.ugPlanGroups.Name = "ugPlanGroups"
        Me.UltraGridBagLayoutManager1.SetPreferredSize(Me.ugPlanGroups, New System.Drawing.Size(395, 653))
        Me.ugPlanGroups.Size = New System.Drawing.Size(395, 653)
        Me.ugPlanGroups.TabIndex = 0
        Me.ugPlanGroups.Text = "Plan Groups"
        '
        'HCHDataPlanEstimateBindingSource
        '
        Me.HCHDataPlanEstimateBindingSource.DataMember = "vwPlanEstimatePlanExteriors"
        Me.HCHDataPlanEstimateBindingSource.DataSource = Me.HCHDataPlanEstimate
        '
        'HCHDataPlanEstimate
        '
        Me.HCHDataPlanEstimate.DataSetName = "HCHDataPlanEstimate"
        Me.HCHDataPlanEstimate.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ugPlanEstimateDetail
        '
        Me.ugPlanEstimateDetail.DataSource = Me.SpPlanEstimatesGetBindingSource
        UltraGridBand2.AddButtonCaption = "Add Plan Estimate Detail"
        UltraGridBand2.ColHeaderLines = 2
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn1.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn1.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn1.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn2.Header.Caption = "Plan"
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.RowLayoutColumnInfo.OriginX = 0
        UltraGridColumn2.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(50, 0)
        UltraGridColumn2.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn2.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn2.Width = 62
        UltraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn3.Header.Caption = "Elev"
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginX = 2
        UltraGridColumn3.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn3.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn3.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn3.Width = 37
        UltraGridColumn4.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn4.Header.Caption = "Ext"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.RowLayoutColumnInfo.OriginX = 4
        UltraGridColumn4.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn4.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn4.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn4.Width = 49
        UltraGridColumn5.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn5.Header.VisiblePosition = 6
        UltraGridColumn5.Hidden = True
        UltraGridColumn5.RowLayoutColumnInfo.OriginX = 9
        UltraGridColumn5.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn5.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn5.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Header.Caption = "Resource"
        UltraGridColumn6.Header.VisiblePosition = 7
        UltraGridColumn6.RowLayoutColumnInfo.OriginX = 9
        UltraGridColumn6.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(134, 0)
        UltraGridColumn6.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn6.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn6.Width = 135
        UltraGridColumn7.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn7.Header.Caption = "Resource Name"
        UltraGridColumn7.Header.VisiblePosition = 8
        UltraGridColumn7.RowLayoutColumnInfo.OriginX = 11
        UltraGridColumn7.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(175, 0)
        UltraGridColumn7.RowLayoutColumnInfo.SpanX = 3
        UltraGridColumn7.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn7.Width = 221
        UltraGridColumn8.Header.Caption = "Activity Code"
        UltraGridColumn8.Header.VisiblePosition = 4
        UltraGridColumn8.RowLayoutColumnInfo.OriginX = 6
        UltraGridColumn8.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(58, 0)
        UltraGridColumn8.RowLayoutColumnInfo.SpanX = 1
        UltraGridColumn8.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn8.Width = 66
        UltraGridColumn9.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn9.Header.VisiblePosition = 5
        UltraGridColumn9.RowLayoutColumnInfo.OriginX = 7
        UltraGridColumn9.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(236, 0)
        UltraGridColumn9.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn9.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn9.Width = 275
        UltraGridColumn10.Header.Caption = "Use Code"
        UltraGridColumn10.Header.VisiblePosition = 9
        UltraGridColumn10.RowLayoutColumnInfo.OriginX = 14
        UltraGridColumn10.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn10.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn10.RowLayoutColumnInfo.SpanY = 2
        Appearance1.TextHAlignAsString = "Right"
        UltraGridColumn11.CellAppearance = Appearance1
        UltraGridColumn11.Header.Caption = "Qty"
        UltraGridColumn11.Header.VisiblePosition = 10
        UltraGridColumn11.RowLayoutColumnInfo.OriginX = 16
        UltraGridColumn11.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn11.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn11.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn11.Width = 59
        UltraGridColumn12.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn12.Format = "MM/dd/yy"
        UltraGridColumn12.Header.Caption = "Created"
        UltraGridColumn12.Header.VisiblePosition = 12
        UltraGridColumn12.RowLayoutColumnInfo.OriginX = 18
        UltraGridColumn12.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(76, 0)
        UltraGridColumn12.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn12.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn12.Width = 64
        UltraGridColumn13.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn13.Header.Caption = "Created By"
        UltraGridColumn13.Header.VisiblePosition = 13
        UltraGridColumn13.RowLayoutColumnInfo.OriginX = 20
        UltraGridColumn13.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(82, 0)
        UltraGridColumn13.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn13.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn13.Width = 79
        UltraGridColumn14.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn14.Format = "MM/dd/yy"
        UltraGridColumn14.Header.Caption = "Updated"
        UltraGridColumn14.Header.VisiblePosition = 14
        UltraGridColumn14.RowLayoutColumnInfo.OriginX = 22
        UltraGridColumn14.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(72, 0)
        UltraGridColumn14.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn14.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn14.Width = 62
        UltraGridColumn15.Header.VisiblePosition = 11
        UltraGridColumn15.RowLayoutColumnInfo.OriginX = 26
        UltraGridColumn15.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(357, 0)
        UltraGridColumn15.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn15.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn15.Width = 308
        UltraGridColumn16.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn16.Header.Caption = "Updated By"
        UltraGridColumn16.Header.VisiblePosition = 15
        UltraGridColumn16.RowLayoutColumnInfo.OriginX = 24
        UltraGridColumn16.RowLayoutColumnInfo.OriginY = 0
        UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize = New System.Drawing.Size(80, 0)
        UltraGridColumn16.RowLayoutColumnInfo.SpanX = 2
        UltraGridColumn16.RowLayoutColumnInfo.SpanY = 2
        UltraGridColumn16.Width = 66
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16})
        UltraGridBand2.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        UltraGridBand2.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand2.Override.AllowGroupSwapping = Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed
        UltraGridBand2.Override.AllowMultiCellOperations = CType((Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy Or Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste), Infragistics.Win.UltraWinGrid.AllowMultiCellOperation)
        UltraGridBand2.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        UltraGridBand2.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[False]
        RowLayoutColumnInfo1.OriginX = 0
        RowLayoutColumnInfo1.OriginY = 0
        RowLayoutColumnInfo1.SpanX = 2
        RowLayoutColumnInfo1.SpanY = 2
        RowLayoutColumnInfo2.OriginX = 0
        RowLayoutColumnInfo2.OriginY = 0
        RowLayoutColumnInfo2.PreferredCellSize = New System.Drawing.Size(50, 0)
        RowLayoutColumnInfo2.SpanX = 2
        RowLayoutColumnInfo2.SpanY = 2
        RowLayoutColumnInfo3.OriginX = 2
        RowLayoutColumnInfo3.OriginY = 0
        RowLayoutColumnInfo3.SpanX = 2
        RowLayoutColumnInfo3.SpanY = 2
        RowLayoutColumnInfo4.OriginX = 4
        RowLayoutColumnInfo4.OriginY = 0
        RowLayoutColumnInfo4.PreferredCellSize = New System.Drawing.Size(58, 0)
        RowLayoutColumnInfo4.SpanX = 2
        RowLayoutColumnInfo4.SpanY = 2
        RowLayoutColumnInfo5.OriginX = 9
        RowLayoutColumnInfo5.OriginY = 0
        RowLayoutColumnInfo5.SpanX = 2
        RowLayoutColumnInfo5.SpanY = 2
        RowLayoutColumnInfo6.OriginX = 9
        RowLayoutColumnInfo6.OriginY = 0
        RowLayoutColumnInfo6.PreferredCellSize = New System.Drawing.Size(134, 0)
        RowLayoutColumnInfo6.SpanX = 2
        RowLayoutColumnInfo6.SpanY = 2
        RowLayoutColumnInfo7.OriginX = 11
        RowLayoutColumnInfo7.OriginY = 0
        RowLayoutColumnInfo7.PreferredCellSize = New System.Drawing.Size(175, 0)
        RowLayoutColumnInfo7.SpanX = 3
        RowLayoutColumnInfo7.SpanY = 2
        RowLayoutColumnInfo8.OriginX = 6
        RowLayoutColumnInfo8.OriginY = 0
        RowLayoutColumnInfo8.PreferredCellSize = New System.Drawing.Size(58, 0)
        RowLayoutColumnInfo8.SpanX = 1
        RowLayoutColumnInfo8.SpanY = 2
        RowLayoutColumnInfo9.OriginX = 7
        RowLayoutColumnInfo9.OriginY = 0
        RowLayoutColumnInfo9.PreferredCellSize = New System.Drawing.Size(236, 0)
        RowLayoutColumnInfo9.SpanX = 2
        RowLayoutColumnInfo9.SpanY = 2
        RowLayoutColumnInfo10.OriginX = 14
        RowLayoutColumnInfo10.OriginY = 0
        RowLayoutColumnInfo10.SpanX = 2
        RowLayoutColumnInfo10.SpanY = 2
        RowLayoutColumnInfo11.OriginX = 16
        RowLayoutColumnInfo11.OriginY = 0
        RowLayoutColumnInfo11.SpanX = 2
        RowLayoutColumnInfo11.SpanY = 2
        RowLayoutColumnInfo12.OriginX = 18
        RowLayoutColumnInfo12.OriginY = 0
        RowLayoutColumnInfo12.PreferredCellSize = New System.Drawing.Size(76, 0)
        RowLayoutColumnInfo12.SpanX = 2
        RowLayoutColumnInfo12.SpanY = 2
        RowLayoutColumnInfo13.OriginX = 20
        RowLayoutColumnInfo13.OriginY = 0
        RowLayoutColumnInfo13.PreferredCellSize = New System.Drawing.Size(82, 0)
        RowLayoutColumnInfo13.SpanX = 2
        RowLayoutColumnInfo13.SpanY = 2
        RowLayoutColumnInfo14.OriginX = 22
        RowLayoutColumnInfo14.OriginY = 0
        RowLayoutColumnInfo14.PreferredCellSize = New System.Drawing.Size(72, 0)
        RowLayoutColumnInfo14.SpanX = 2
        RowLayoutColumnInfo14.SpanY = 2
        RowLayoutColumnInfo15.OriginX = 26
        RowLayoutColumnInfo15.OriginY = 0
        RowLayoutColumnInfo15.PreferredCellSize = New System.Drawing.Size(357, 0)
        RowLayoutColumnInfo15.SpanX = 2
        RowLayoutColumnInfo15.SpanY = 2
        RowLayoutColumnInfo16.OriginX = 24
        RowLayoutColumnInfo16.OriginY = 0
        RowLayoutColumnInfo16.PreferredCellSize = New System.Drawing.Size(80, 0)
        RowLayoutColumnInfo16.SpanX = 2
        RowLayoutColumnInfo16.SpanY = 2
        RowLayout1.ColumnInfos.AddRange(New Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo() {RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16})
        RowLayout1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout
        UltraGridBand2.RowLayouts.AddRange(New Infragistics.Win.UltraWinGrid.RowLayout() {RowLayout1})
        Me.ugPlanEstimateDetail.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ugPlanEstimateDetail.DisplayLayout.Override.ActiveAppearancesEnabled = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanEstimateDetail.DisplayLayout.Override.AddRowEditNotificationInterface = Infragistics.Win.UltraWinGrid.AddRowEditNotificationInterface.ICancelAddNewAndIEditableObject
        Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanEstimateDetail.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanEstimateDetail.DisplayLayout.Override.Key = "PlanEstimateID"
        Me.ugPlanEstimateDetail.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanEstimateDetail.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugPlanEstimateDetail.DisplayLayout.UseFixedHeaders = True
        Me.ugPlanEstimateDetail.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        GridBagConstraint2.Anchor = Infragistics.Win.Layout.AnchorType.TopLeft
        GridBagConstraint2.Fill = Infragistics.Win.Layout.FillType.Both
        GridBagConstraint2.Insets.Left = 5
        GridBagConstraint2.Insets.Top = 5
        GridBagConstraint2.OriginX = 1
        GridBagConstraint2.OriginY = 1
        Me.UltraGridBagLayoutManager1.SetGridBagConstraint(Me.ugPlanEstimateDetail, GridBagConstraint2)
        Me.ugPlanEstimateDetail.Location = New System.Drawing.Point(412, 62)
        Me.ugPlanEstimateDetail.Name = "ugPlanEstimateDetail"
        Me.UltraGridBagLayoutManager1.SetPreferredSize(Me.ugPlanEstimateDetail, New System.Drawing.Size(1369, 653))
        Me.ugPlanEstimateDetail.Size = New System.Drawing.Size(1377, 658)
        Me.ugPlanEstimateDetail.TabIndex = 1
        Me.ugPlanEstimateDetail.Text = "Plan Estimate Detail"
        '
        'SpPlanEstimatesGetBindingSource
        '
        Me.SpPlanEstimatesGetBindingSource.DataMember = "spPlanEstimatesGet"
        Me.SpPlanEstimatesGetBindingSource.DataSource = Me.DsDetail
        '
        'DsDetail
        '
        Me.DsDetail.DataSetName = "dsDetail"
        Me.DsDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.UltraToolbarsManager1.MiniToolbar.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool2})
        ButtonTool3.SharedPropsInternal.Caption = "Edit"
        ButtonTool4.SharedPropsInternal.Caption = "Undo"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool3, ButtonTool4})
        '
        'PlanEstimateTablesMaintenance_Fill_Panel
        '
        '
        'PlanEstimateTablesMaintenance_Fill_Panel.ClientArea
        '
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(Me.btnPopulateDetail)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(Me.UltraPanel3)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(Me.UltraPanel1)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(Me.ugPlanEstimateDetail)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(Me.ugPlanGroups)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.PlanEstimateTablesMaintenance_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlanEstimateTablesMaintenance_Fill_Panel.Location = New System.Drawing.Point(0, 0)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.Name = "PlanEstimateTablesMaintenance_Fill_Panel"
        Me.PlanEstimateTablesMaintenance_Fill_Panel.Size = New System.Drawing.Size(1794, 725)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.TabIndex = 0
        '
        'btnPopulateDetail
        '
        Me.btnPopulateDetail.Location = New System.Drawing.Point(119, 12)
        Me.btnPopulateDetail.Name = "btnPopulateDetail"
        Me.btnPopulateDetail.Size = New System.Drawing.Size(174, 37)
        Me.btnPopulateDetail.TabIndex = 8
        Me.btnPopulateDetail.Text = "Populate Detail Grid"
        Me.btnPopulateDetail.UseVisualStyleBackColor = True
        '
        'UltraPanel3
        '
        '
        'UltraPanel3.ClientArea
        '
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Label2)
        Me.UltraPanel3.ClientArea.Controls.Add(Me.Label1)
        GridBagConstraint4.Anchor = Infragistics.Win.Layout.AnchorType.TopLeft
        GridBagConstraint4.OriginX = 1
        GridBagConstraint4.OriginY = 0
        Me.UltraGridBagLayoutManager1.SetGridBagConstraint(Me.UltraPanel3, GridBagConstraint4)
        Me.UltraPanel3.Location = New System.Drawing.Point(407, 5)
        Me.UltraPanel3.Name = "UltraPanel3"
        Me.UltraPanel3.Size = New System.Drawing.Size(867, 52)
        Me.UltraPanel3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(688, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To Group a grid, drag the headers for that column into the Group Box.  To Ungroup" & _
    ", drag Header out of box"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(824, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "To Populate Grid, expand the Plan Group for the Plan or Plans you want to view.  " & _
    "Select the rows, then press Populate Detail Grid"
        '
        'UltraPanel1
        '
        '
        'UltraPanel1.ClientArea
        '
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnAddRows)
        Me.UltraPanel1.ClientArea.Controls.Add(Me.btnAddPlan)
        GridBagConstraint1.Anchor = Infragistics.Win.Layout.AnchorType.TopRight
        GridBagConstraint1.OriginX = 1
        GridBagConstraint1.OriginY = 0
        Me.UltraGridBagLayoutManager1.SetGridBagConstraint(Me.UltraPanel1, GridBagConstraint1)
        Me.UltraPanel1.Location = New System.Drawing.Point(1439, 5)
        Me.UltraPanel1.Name = "UltraPanel1"
        Me.UltraGridBagLayoutManager1.SetPreferredSize(Me.UltraPanel1, New System.Drawing.Size(350, 47))
        Me.UltraPanel1.Size = New System.Drawing.Size(350, 47)
        Me.UltraPanel1.TabIndex = 5
        '
        'btnAddRows
        '
        Me.btnAddRows.Location = New System.Drawing.Point(39, 4)
        Me.btnAddRows.Name = "btnAddRows"
        Me.btnAddRows.Size = New System.Drawing.Size(149, 37)
        Me.btnAddRows.TabIndex = 6
        Me.btnAddRows.Text = "Add Rows"
        Me.btnAddRows.UseVisualStyleBackColor = True
        '
        'btnAddPlan
        '
        Me.btnAddPlan.Location = New System.Drawing.Point(194, 3)
        Me.btnAddPlan.Name = "btnAddPlan"
        Me.btnAddPlan.Size = New System.Drawing.Size(149, 37)
        Me.btnAddPlan.TabIndex = 5
        Me.btnAddPlan.Text = "Add New Plan"
        Me.btnAddPlan.UseVisualStyleBackColor = True
        '
        '_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left
        '
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 0)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.Name = "_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left"
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 725)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right
        '
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(1794, 0)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.Name = "_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right"
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 725)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top
        '
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.Name = "_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top"
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(1794, 0)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom
        '
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 725)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.Name = "_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom"
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(1794, 0)
        Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'UltraGridBagLayoutManager1
        '
        Me.UltraGridBagLayoutManager1.ContainerControl = Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea
        Me.UltraGridBagLayoutManager1.ExpandToFitHeight = True
        Me.UltraGridBagLayoutManager1.ExpandToFitWidth = True
        Me.UltraGridBagLayoutManager1.Margins.Bottom = 5
        Me.UltraGridBagLayoutManager1.Margins.Left = 5
        Me.UltraGridBagLayoutManager1.Margins.Right = 5
        Me.UltraGridBagLayoutManager1.Margins.Top = 5
        '
        'SpPlanEstimatesGetTableAdapter
        '
        Me.SpPlanEstimatesGetTableAdapter.ClearBeforeFill = True
        '
        'VwPlanEstimatePlanExteriorsTableAdapter1
        '
        Me.VwPlanEstimatePlanExteriorsTableAdapter1.ClearBeforeFill = True
        '
        'PlanEstimateTablesMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1794, 725)
        Me.Controls.Add(Me.PlanEstimateTablesMaintenance_Fill_Panel)
        Me.Controls.Add(Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me._PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top)
        Me.Name = "PlanEstimateTablesMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plan Estimate Tables"
        CType(Me.ugPlanGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataPlanEstimateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataPlanEstimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugPlanEstimateDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPlanEstimatesGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.ResumeLayout(False)
        Me.PlanEstimateTablesMaintenance_Fill_Panel.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.ResumeLayout(False)
        Me.UltraPanel3.ClientArea.PerformLayout()
        Me.UltraPanel3.ResumeLayout(False)
        Me.UltraPanel1.ClientArea.ResumeLayout(False)
        Me.UltraPanel1.ResumeLayout(False)
        CType(Me.UltraGridBagLayoutManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents HCHDataPlanEstimateSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataPlanEstimateSet As BossAdmin.HCHDataPlanEstimate
    Friend WithEvents VwPlanEstimatePlanExteriorsTableAdapter As BossAdmin.HCHDataPlanEstimateTableAdapters.vwPlanEstimatePlanExteriorsTableAdapter
    Friend WithEvents ugPlanGroups As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents ugPlanEstimateDetail As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SpPlanEstimatesGetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpPlanEstimatesGetTableAdapter As BossAdmin.dsDetailTableAdapters.spPlanEstimatesGetTableAdapter
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents PlanEstimateTablesMaintenance_Fill_Panel As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraGridBagLayoutManager1 As Infragistics.Win.Misc.UltraGridBagLayoutManager
    Friend WithEvents btnPopulateDetail As System.Windows.Forms.Button
    Friend WithEvents UltraPanel3 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UltraPanel1 As Infragistics.Win.Misc.UltraPanel
    Friend WithEvents btnAddRows As System.Windows.Forms.Button
    Friend WithEvents btnAddPlan As System.Windows.Forms.Button
    Friend WithEvents DsDetail As BossAdmin.dsDetail
    Friend WithEvents HCHDataPlanEstimateBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataPlanEstimate As BossAdmin.HCHDataPlanEstimate
    Friend WithEvents VwPlanEstimatePlanExteriorsTableAdapter1 As BossAdmin.HCHDataPlanEstimateTableAdapters.vwPlanEstimatePlanExteriorsTableAdapter
End Class
