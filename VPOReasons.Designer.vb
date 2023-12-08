<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VPOReasons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VPOReasons))
        Me.grdReasons = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.tsBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnUndo = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnTip = New System.Windows.Forms.ToolStripButton()
        Me.tsToolStrip = New System.Windows.Forms.ToolStrip()
        CType(Me.grdReasons, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdReasons
        '
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.grdReasons.DisplayLayout.Appearance = Appearance1
        Me.grdReasons.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        Me.grdReasons.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdReasons.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.grdReasons.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdReasons.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.grdReasons.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.grdReasons.DisplayLayout.GroupByBox.Hidden = True
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.grdReasons.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.grdReasons.DisplayLayout.MaxColScrollRegions = 1
        Me.grdReasons.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grdReasons.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.grdReasons.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.grdReasons.DisplayLayout.Override.AllowColMoving = Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed
        Me.grdReasons.DisplayLayout.Override.AllowColSizing = Infragistics.Win.UltraWinGrid.AllowColSizing.Free
        Me.grdReasons.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.grdReasons.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.grdReasons.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.grdReasons.DisplayLayout.Override.CellAppearance = Appearance8
        Me.grdReasons.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.grdReasons.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.grdReasons.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.grdReasons.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.grdReasons.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle
        Me.grdReasons.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.grdReasons.DisplayLayout.Override.RowAppearance = Appearance11
        Me.grdReasons.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Me.grdReasons.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.[Single]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grdReasons.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.grdReasons.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.grdReasons.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.grdReasons.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.grdReasons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdReasons.Location = New System.Drawing.Point(0, 31)
        Me.grdReasons.Name = "grdReasons"
        Me.grdReasons.Size = New System.Drawing.Size(906, 535)
        Me.grdReasons.TabIndex = 0
        Me.grdReasons.Text = "UltraGrid1"
        '
        'tsBtnAdd
        '
        Me.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnAdd.Enabled = False
        Me.tsBtnAdd.Image = Global.BossAdmin.My.Resources.Resources.NewCard
        Me.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAdd.Name = "tsBtnAdd"
        Me.tsBtnAdd.Size = New System.Drawing.Size(28, 28)
        Me.tsBtnAdd.Text = "Add New"
        Me.tsBtnAdd.ToolTipText = "Click to Add New Record"
        '
        'tsBtnEdit
        '
        Me.tsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnEdit.Enabled = False
        Me.tsBtnEdit.Image = Global.BossAdmin.My.Resources.Resources.EditBrightContrast
        Me.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnEdit.Name = "tsBtnEdit"
        Me.tsBtnEdit.Size = New System.Drawing.Size(28, 28)
        Me.tsBtnEdit.Text = "Edit"
        Me.tsBtnEdit.ToolTipText = "Click to Edit Records"
        '
        'tsBtnUndo
        '
        Me.tsBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnUndo.Enabled = False
        Me.tsBtnUndo.Image = Global.BossAdmin.My.Resources.Resources.Edit_Undo
        Me.tsBtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnUndo.Name = "tsBtnUndo"
        Me.tsBtnUndo.Size = New System.Drawing.Size(28, 28)
        Me.tsBtnUndo.Text = "Cancel Changes"
        Me.tsBtnUndo.ToolTipText = "Click to Cancel Changes"
        '
        'tsBtnSave
        '
        Me.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnSave.Enabled = False
        Me.tsBtnSave.Image = Global.BossAdmin.My.Resources.Resources.Save
        Me.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnSave.Name = "tsBtnSave"
        Me.tsBtnSave.Size = New System.Drawing.Size(28, 28)
        Me.tsBtnSave.Text = "Save"
        Me.tsBtnSave.ToolTipText = "Click to Save Changes"
        '
        'tsBtnPrint
        '
        Me.tsBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnPrint.Image = Global.BossAdmin.My.Resources.Resources.Print
        Me.tsBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPrint.Name = "tsBtnPrint"
        Me.tsBtnPrint.Size = New System.Drawing.Size(28, 28)
        Me.tsBtnPrint.Text = "Print"
        Me.tsBtnPrint.ToolTipText = "Click to Print Report"
        '
        'tsBtnTip
        '
        Me.tsBtnTip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnTip.Image = CType(resources.GetObject("tsBtnTip.Image"), System.Drawing.Image)
        Me.tsBtnTip.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnTip.Name = "tsBtnTip"
        Me.tsBtnTip.Size = New System.Drawing.Size(256, 28)
        Me.tsBtnTip.Text = "Click on Grid Header to Sort Columns or Apply Filter"
        '
        'tsToolStrip
        '
        Me.tsToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnAdd, Me.tsBtnEdit, Me.tsBtnUndo, Me.tsBtnSave, Me.tsBtnPrint, Me.tsBtnTip})
        Me.tsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.tsToolStrip.Name = "tsToolStrip"
        Me.tsToolStrip.Size = New System.Drawing.Size(906, 31)
        Me.tsToolStrip.Stretch = True
        Me.tsToolStrip.TabIndex = 1
        Me.tsToolStrip.Text = "ToolStrip1"
        '
        'VPOReasons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 566)
        Me.Controls.Add(Me.grdReasons)
        Me.Controls.Add(Me.tsToolStrip)
        Me.Name = "VPOReasons"
        Me.Text = "VPOReasons"
        CType(Me.grdReasons, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsToolStrip.ResumeLayout(False)
        Me.tsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdReasons As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents tsBtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnTip As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsToolStrip As System.Windows.Forms.ToolStrip
End Class
