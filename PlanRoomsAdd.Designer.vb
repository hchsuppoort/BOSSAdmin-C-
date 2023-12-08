<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanRoomsAdd
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("vwPlanGroups", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanGroup")
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
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("vwRooms", -1)
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ResUsage")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UsageDescription")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Room")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sqft", 0)
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("lftrim", 1)
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.VwPlanGroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataDataSet = New BossAdmin.HCHDataDataSet()
        Me.VwPlanGroupsTableAdapter = New BossAdmin.HCHDataDataSetTableAdapters.vwPlanGroupsTableAdapter()
        Me.SpPlanRoomsGetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataPlanRoomsDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataPlanRoomsData = New BossAdmin.HCHDataPlanRoomsData()
        Me.SpPlanRoomsGetTableAdapter = New BossAdmin.HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter()
        Me.HCHDataRooms = New BossAdmin.HCHDataRooms()
        Me.HCHDataRoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwRoomsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwRoomsTableAdapter = New BossAdmin.HCHDataRoomsTableAdapters.vwRoomsTableAdapter()
        Me.HCHDataDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VwPlanGroupsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataDataSetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ucPlanGroups = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.ubtnSaveNewPlanRooms = New Infragistics.Win.Misc.UltraButton()
        Me.UltraGrid1 = New Infragistics.Win.UltraWinGrid.UltraGrid()
        CType(Me.VwPlanGroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpPlanRoomsGetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataPlanRoomsDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataPlanRoomsData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataRoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwRoomsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPlanGroupsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataDataSetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucPlanGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VwPlanGroupsBindingSource
        '
        Me.VwPlanGroupsBindingSource.DataMember = "vwPlanGroups"
        Me.VwPlanGroupsBindingSource.DataSource = Me.HCHDataDataSet
        '
        'HCHDataDataSet
        '
        Me.HCHDataDataSet.DataSetName = "HCHDataDataSet"
        Me.HCHDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VwPlanGroupsTableAdapter
        '
        Me.VwPlanGroupsTableAdapter.ClearBeforeFill = True
        '
        'SpPlanRoomsGetBindingSource
        '
        Me.SpPlanRoomsGetBindingSource.DataMember = "spPlanRoomsGet"
        Me.SpPlanRoomsGetBindingSource.DataSource = Me.HCHDataPlanRoomsDataBindingSource
        '
        'HCHDataPlanRoomsDataBindingSource
        '
        Me.HCHDataPlanRoomsDataBindingSource.DataSource = Me.HCHDataPlanRoomsData
        Me.HCHDataPlanRoomsDataBindingSource.Position = 0
        '
        'HCHDataPlanRoomsData
        '
        Me.HCHDataPlanRoomsData.DataSetName = "HCHDataPlanRoomsData"
        Me.HCHDataPlanRoomsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpPlanRoomsGetTableAdapter
        '
        Me.SpPlanRoomsGetTableAdapter.ClearBeforeFill = True
        '
        'HCHDataRooms
        '
        Me.HCHDataRooms.DataSetName = "HCHDataRooms"
        Me.HCHDataRooms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HCHDataRoomsBindingSource
        '
        Me.HCHDataRoomsBindingSource.DataSource = Me.HCHDataRooms
        Me.HCHDataRoomsBindingSource.Position = 0
        '
        'VwRoomsBindingSource
        '
        Me.VwRoomsBindingSource.DataMember = "vwRooms"
        Me.VwRoomsBindingSource.DataSource = Me.HCHDataRoomsBindingSource
        '
        'VwRoomsTableAdapter
        '
        Me.VwRoomsTableAdapter.ClearBeforeFill = True
        '
        'HCHDataDataSetBindingSource
        '
        Me.HCHDataDataSetBindingSource.DataSource = Me.HCHDataDataSet
        Me.HCHDataDataSetBindingSource.Position = 0
        '
        'VwPlanGroupsBindingSource1
        '
        Me.VwPlanGroupsBindingSource1.DataMember = "vwPlanGroups"
        Me.VwPlanGroupsBindingSource1.DataSource = Me.HCHDataDataSetBindingSource
        '
        'HCHDataDataSetBindingSource2
        '
        Me.HCHDataDataSetBindingSource2.DataSource = Me.HCHDataDataSet
        Me.HCHDataDataSetBindingSource2.Position = 0
        '
        'ucPlanGroups
        '
        Me.ucPlanGroups.DataSource = Me.VwPlanGroupsBindingSource1
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucPlanGroups.DisplayLayout.Appearance = Appearance1
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1})
        Me.ucPlanGroups.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ucPlanGroups.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucPlanGroups.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ucPlanGroups.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucPlanGroups.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ucPlanGroups.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucPlanGroups.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ucPlanGroups.DisplayLayout.MaxColScrollRegions = 1
        Me.ucPlanGroups.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucPlanGroups.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucPlanGroups.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ucPlanGroups.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ucPlanGroups.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucPlanGroups.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ucPlanGroups.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucPlanGroups.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ucPlanGroups.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucPlanGroups.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ucPlanGroups.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.ucPlanGroups.DisplayLayout.Override.CellPadding = 0
        Me.ucPlanGroups.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ucPlanGroups.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ucPlanGroups.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ucPlanGroups.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucPlanGroups.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ucPlanGroups.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ucPlanGroups.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucPlanGroups.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None
        Me.ucPlanGroups.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucPlanGroups.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ucPlanGroups.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucPlanGroups.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucPlanGroups.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl
        Me.ucPlanGroups.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand
        Me.ucPlanGroups.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucPlanGroups.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucPlanGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucPlanGroups.Location = New System.Drawing.Point(12, 24)
        Me.ucPlanGroups.Name = "ucPlanGroups"
        Me.ucPlanGroups.NullText = "Select Plan Group"
        Me.ucPlanGroups.Size = New System.Drawing.Size(173, 25)
        Me.ucPlanGroups.TabIndex = 3
        '
        'ubtnSaveNewPlanRooms
        '
        Me.ubtnSaveNewPlanRooms.Location = New System.Drawing.Point(695, 713)
        Me.ubtnSaveNewPlanRooms.Name = "ubtnSaveNewPlanRooms"
        Me.ubtnSaveNewPlanRooms.Size = New System.Drawing.Size(160, 23)
        Me.ubtnSaveNewPlanRooms.TabIndex = 5
        Me.ubtnSaveNewPlanRooms.Text = "Save New Plan Rooms"
        '
        'UltraGrid1
        '
        Me.UltraGrid1.DataSource = Me.VwRoomsBindingSource
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.UltraGrid1.DisplayLayout.Appearance = Appearance13
        UltraGridColumn2.Header.VisiblePosition = 0
        UltraGridColumn3.Header.VisiblePosition = 1
        UltraGridColumn4.Header.VisiblePosition = 2
        UltraGridColumn4.Hidden = True
        UltraGridColumn6.DataType = GetType(Short)
        UltraGridColumn6.Header.Caption = "SqFt"
        UltraGridColumn6.Header.VisiblePosition = 3
        UltraGridColumn7.DataType = GetType(Short)
        UltraGridColumn7.Header.Caption = "LF Trim"
        UltraGridColumn7.Header.VisiblePosition = 4
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn6, UltraGridColumn7})
        Me.UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.UltraGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.UltraGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.UltraGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.UltraGrid1.DisplayLayout.MaxColScrollRegions = 1
        Me.UltraGrid1.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UltraGrid1.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UltraGrid1.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.UltraGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.UltraGrid1.DisplayLayout.Override.CellAppearance = Appearance20
        Me.UltraGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.UltraGrid1.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.UltraGrid1.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.UltraGrid1.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.UltraGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.UltraGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.UltraGrid1.DisplayLayout.Override.RowAppearance = Appearance23
        Me.UltraGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.UltraGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.UltraGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.UltraGrid1.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.UltraGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UltraGrid1.Location = New System.Drawing.Point(233, 24)
        Me.UltraGrid1.Name = "UltraGrid1"
        Me.UltraGrid1.Size = New System.Drawing.Size(622, 683)
        Me.UltraGrid1.TabIndex = 6
        Me.UltraGrid1.Text = "UltraGrid1"
        '
        'PlanRoomsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 748)
        Me.Controls.Add(Me.UltraGrid1)
        Me.Controls.Add(Me.ubtnSaveNewPlanRooms)
        Me.Controls.Add(Me.ucPlanGroups)
        Me.Name = "PlanRoomsAdd"
        Me.Text = "Add Plan Rooms"
        CType(Me.VwPlanGroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpPlanRoomsGetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataPlanRoomsDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataPlanRoomsData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataRooms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataRoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwRoomsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPlanGroupsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataDataSetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucPlanGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VwPlanGroupsTableAdapter As BossAdmin.HCHDataDataSetTableAdapters.vwPlanGroupsTableAdapter
    Friend WithEvents VwRoomsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VwPlanGroupsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ucPlanGroups As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ubtnSaveNewPlanRooms As Infragistics.Win.Misc.UltraButton
    Friend WithEvents UltraGrid1 As Infragistics.Win.UltraWinGrid.UltraGrid
    Public WithEvents HCHDataPlanRoomsData As BossAdmin.HCHDataPlanRoomsData
    Public WithEvents HCHDataPlanRoomsDataBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents HCHDataRoomsBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents SpPlanRoomsGetTableAdapter As BossAdmin.HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter
    Public WithEvents VwRoomsTableAdapter As BossAdmin.HCHDataRoomsTableAdapters.vwRoomsTableAdapter
    Public WithEvents HCHDataDataSet As BossAdmin.HCHDataDataSet
    Public WithEvents VwPlanGroupsBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents SpPlanRoomsGetBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents HCHDataRooms As BossAdmin.HCHDataRooms
    Public WithEvents HCHDataDataSetBindingSource2 As System.Windows.Forms.BindingSource
End Class
