<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plan_Estimate
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
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraTreeColumnSet1 As Infragistics.Win.UltraWinTree.UltraTreeColumnSet = New Infragistics.Win.UltraWinTree.UltraTreeColumnSet()
        Dim UltraTreeNodeColumn1 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeColumnSet2 As Infragistics.Win.UltraWinTree.UltraTreeColumnSet = New Infragistics.Win.UltraWinTree.UltraTreeColumnSet()
        Dim UltraTreeNodeColumn2 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Dim UltraTreeNodeColumn3 As Infragistics.Win.UltraWinTree.UltraTreeNodeColumn = New Infragistics.Win.UltraWinTree.UltraTreeNodeColumn()
        Me.UltraGridFilterUIProvider1 = New Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider(Me.components)
        Me.ugPlanEstimate = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.uTreePlans = New Infragistics.Win.UltraWinTree.UltraTree()
        Me.udSourcePlans = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.HCHDataDataSetPlans = New BossAdmin.HCHDataDataSetPlans()
        Me.HCHDataDataSetPlansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPlanEstimatePlanElevationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPlanEstimatePlanElevationsTableAdapter = New BossAdmin.HCHDataDataSetPlansTableAdapters.vwPlanEstimatePlanElevationsTableAdapter()
        CType(Me.ugPlanEstimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uTreePlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udSourcePlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataDataSetPlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataDataSetPlansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPlanEstimatePlanElevationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ugPlanEstimate
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugPlanEstimate.DisplayLayout.Appearance = Appearance1
        Me.ugPlanEstimate.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugPlanEstimate.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugPlanEstimate.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugPlanEstimate.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugPlanEstimate.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugPlanEstimate.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugPlanEstimate.DisplayLayout.MaxColScrollRegions = 1
        Me.ugPlanEstimate.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugPlanEstimate.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugPlanEstimate.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugPlanEstimate.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugPlanEstimate.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugPlanEstimate.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugPlanEstimate.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugPlanEstimate.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugPlanEstimate.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugPlanEstimate.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugPlanEstimate.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugPlanEstimate.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugPlanEstimate.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugPlanEstimate.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugPlanEstimate.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugPlanEstimate.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugPlanEstimate.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugPlanEstimate.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugPlanEstimate.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugPlanEstimate.Location = New System.Drawing.Point(182, 12)
        Me.ugPlanEstimate.Name = "ugPlanEstimate"
        Me.ugPlanEstimate.Size = New System.Drawing.Size(1501, 562)
        Me.ugPlanEstimate.TabIndex = 0
        Me.ugPlanEstimate.Text = "UltraGrid1"
        '
        'uTreePlans
        '
        UltraTreeNodeColumn1.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn1.DataType = GetType(String)
        UltraTreeNodeColumn1.Key = "PlanGroup"
        UltraTreeNodeColumn1.LayoutInfo.OriginX = 0
        UltraTreeNodeColumn1.LayoutInfo.OriginY = 0
        UltraTreeNodeColumn1.LayoutInfo.SpanX = 2
        UltraTreeNodeColumn1.LayoutInfo.SpanY = 2
        UltraTreeColumnSet1.Columns.Add(UltraTreeNodeColumn1)
        UltraTreeColumnSet1.IsAutoGenerated = True
        UltraTreeColumnSet1.Key = "vwPlanEstimatePlans"
        UltraTreeNodeColumn2.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn2.DataType = GetType(String)
        UltraTreeNodeColumn2.Key = "PlanGroup"
        UltraTreeNodeColumn3.ButtonDisplayStyle = Infragistics.Win.UltraWinTree.ButtonDisplayStyle.Always
        UltraTreeNodeColumn3.DataType = GetType(String)
        UltraTreeNodeColumn3.Key = "Elevation"
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn2)
        UltraTreeColumnSet2.Columns.Add(UltraTreeNodeColumn3)
        UltraTreeColumnSet2.IsAutoGenerated = True
        Me.uTreePlans.ColumnSettings.ColumnSets.Add(UltraTreeColumnSet1)
        Me.uTreePlans.ColumnSettings.ColumnSets.Add(UltraTreeColumnSet2)
        Me.uTreePlans.DataSource = Me.VwPlanEstimatePlanElevationsBindingSource
        Me.uTreePlans.Location = New System.Drawing.Point(12, 12)
        Me.uTreePlans.Name = "uTreePlans"
        Me.uTreePlans.Size = New System.Drawing.Size(154, 329)
        Me.uTreePlans.TabIndex = 1
        '
        'udSourcePlans
        '
        Me.udSourcePlans.AllowAdd = False
        Me.udSourcePlans.AllowDelete = False
        Me.udSourcePlans.ReadOnly = True
        '
        'HCHDataDataSetPlans
        '
        Me.HCHDataDataSetPlans.DataSetName = "HCHDataDataSetPlans"
        Me.HCHDataDataSetPlans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HCHDataDataSetPlansBindingSource
        '
        Me.HCHDataDataSetPlansBindingSource.DataSource = Me.HCHDataDataSetPlans
        Me.HCHDataDataSetPlansBindingSource.Position = 0
        '
        'VwPlanEstimatePlanElevationsBindingSource
        '
        Me.VwPlanEstimatePlanElevationsBindingSource.DataMember = "vwPlanEstimatePlanElevations"
        Me.VwPlanEstimatePlanElevationsBindingSource.DataSource = Me.HCHDataDataSetPlansBindingSource
        '
        'VwPlanEstimatePlanElevationsTableAdapter
        '
        Me.VwPlanEstimatePlanElevationsTableAdapter.ClearBeforeFill = True
        '
        'Plan_Estimate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1525, 711)
        Me.Controls.Add(Me.uTreePlans)
        Me.Controls.Add(Me.ugPlanEstimate)
        Me.Name = "Plan_Estimate"
        Me.Text = "Plan Estimate Tables"
        CType(Me.ugPlanEstimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uTreePlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udSourcePlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataDataSetPlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataDataSetPlansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPlanEstimatePlanElevationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UltraGridFilterUIProvider1 As Infragistics.Win.SupportDialogs.FilterUIProvider.UltraGridFilterUIProvider
    Friend WithEvents ugPlanEstimate As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents uTreePlans As Infragistics.Win.UltraWinTree.UltraTree
    Friend WithEvents udSourcePlans As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents HCHDataDataSetPlansBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataDataSetPlans As BossAdmin.HCHDataDataSetPlans
    Friend WithEvents VwPlanEstimatePlanElevationsBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents VwPlanEstimatePlanElevationsTableAdapter As BossAdmin.HCHDataDataSetPlansTableAdapters.vwPlanEstimatePlanElevationsTableAdapter
End Class
