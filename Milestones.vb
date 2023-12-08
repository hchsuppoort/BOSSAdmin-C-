Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.Misc
Imports Infragistics.Win.Layout

Imports System.Windows.Forms
Public Class Milestones
    Dim iColCheck As Integer = 60
    Dim ddNotifyCriteria As New UltraDropDown
    Dim ddGroup As New UltraDropDown

    Private Sub Milestones_Enter(sender As Object, e As System.EventArgs) Handles Me.Enter

        LoadGrid()
        LoadNotifyList()
        'LoadCriteriaList()??

    End Sub
    Private Sub LoadCriteriaList()
        Dim cDB As New DBCalls
        Dim dsCriteria As New DataSet
        Try
            If grdMilestones.Rows.Count > 0 Then
                If cDB.GetRecordsFromSP(dsCriteria, "spNotifyCriteriaGet") Then
                    'create dropdown for Owner
                    ddNotifyCriteria.SetDataBinding(dsCriteria, Nothing)
                    Me.ddNotifyCriteria.ValueMember = "NotifyCriteria"
                    Me.ddNotifyCriteria.DisplayMember = "NotifyCriteria"
                    grdMilestones.DisplayLayout.Bands(0).Columns("NotifyCriteria").ValueList = ddNotifyCriteria
                End If
            End If
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: LoadCriteriaList ")
        Finally
            cDB = Nothing
        End Try

    End Sub
    Private Sub LoadGroupList()
        '9/21/12 mrb
        Dim cDB As New DBCalls
        Dim dsGroup As New DataSet
        Try
            If grdMilestones.Rows.Count > 0 Then
                If cDB.GetRecordsFromSP(dsGroup, "spMilestoneGroupGet") Then
                    'create dropdown for Owner
                    ddGroup.SetDataBinding(dsGroup, Nothing)
                    Me.ddGroup.ValueMember = "GroupID"
                    Me.ddGroup.DisplayMember = "Group"
                    grdMilestones.DisplayLayout.Bands(0).Columns("GroupID").ValueList = ddGroup
                    Dim ugc As UltraGridColumn

                    ugc = ddGroup.DisplayLayout.Bands(0).Columns("Groupid")
                    ugc.Hidden = True
                End If
            End If
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: LoadGroupList ")
        Finally
            cDB = Nothing
        End Try

    End Sub
    Private Sub Milestones_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try 'mrb 10/28/16 
            EnableDisableToolStrip(False, tsToolStrip, grdMilestones, "Milestones", "Menu")
            If LoadGrid() Then
                ' FormatTemplate()
                LoadCriteriaList()
                LoadGroupList()
                LoadDetail()
            End If
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "Milestones: Milestones_Load ")
        End Try
    End Sub
    Private Function FormatTemplate() As Boolean
        Try
            retMilestones.Controls.Clear()

            Dim ulblDescription As New Label
            With ulblDescription
                .Text = "Description"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblDescription)

            Dim ulblUserAdded As New Label
            With ulblUserAdded
                .Text = "User Added"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblUserAdded)

            Dim ulblMessage As New Label
            With ulblMessage
                .Text = "eMail Message"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblMessage)

            Dim ulblSubject As New Label
            With ulblSubject
                .Text = "eMail Subject"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblSubject)
            Dim ulblSubjectHint As New Label
            With ulblSubjectHint
                .Text = "The description is used if there is no subject for eMail."
                .Width = 200
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblSubjectHint)
            Dim ulblGroup As New Label
            With ulblGroup
                .Text = "Group"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblGroup)

            Dim ulblOrderBy As New Label
            With ulblOrderBy
                .Text = "Order By"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblOrderBy)

            
            Dim ulblNotify As New Label
            With ulblNotify
                .Text = "Notify"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblNotify)

            Dim ulblNotifyCriteria As New Label
            With ulblNotifyCriteria
                .Text = "Notify Criteria"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblNotifyCriteria)

            Dim ulblBuilderCanCancel As New Label
            With ulblBuilderCanCancel
                .Text = "Builder Can Cancel"
                .Width = 100
                .TextAlign = ContentAlignment.MiddleRight
            End With
            retMilestones.Controls.Add(ulblBuilderCanCancel)

            ugbLayoutMgr.SetGridBagConstraint(ulblDescription, New Infragistics.Win.Layout.GridBagConstraint(0, 0, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblUserAdded, New Infragistics.Win.Layout.GridBagConstraint(0, 1, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblMessage, New Infragistics.Win.Layout.GridBagConstraint(0, 2, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblSubject, New Infragistics.Win.Layout.GridBagConstraint(0, 3, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblSubjectHint, New Infragistics.Win.Layout.GridBagConstraint(2, 3, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblNotify, New Infragistics.Win.Layout.GridBagConstraint(0, 4, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblNotifyCriteria, New Infragistics.Win.Layout.GridBagConstraint(0, 5, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblBuilderCanCancel, New Infragistics.Win.Layout.GridBagConstraint(0, 6, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblGroup, New Infragistics.Win.Layout.GridBagConstraint(0, 7, 1, 1))
            ugbLayoutMgr.SetGridBagConstraint(ulblOrderBy, New Infragistics.Win.Layout.GridBagConstraint(0, 8, 1, 1))
            'Instatiate a new UltraButton object.
            'Dim accept As Infragistics.Win.Misc.UltraButton = New Infragistics.Win.Misc.UltraButton()
            'Set the button's text.
            Dim accept As New UltraButton
            accept.Text = "OK"
            'Add the button to the template's Controls collection.
            retMilestones.Controls.Add(accept)
            'Create a handler for the accept button.
            AddHandler accept.Click, AddressOf accept_Click
            ugbLayoutMgr.SetGridBagConstraint( _
                 accept, _
                 New Infragistics.Win.Layout.GridBagConstraint(1, 9, 1, 1))

            'Instatiate a new UltraButton object.
            Dim cancel As Infragistics.Win.Misc.UltraButton = New Infragistics.Win.Misc.UltraButton()
            'Set the button's text.
            cancel.Text = "Cancel"
            'Add the button to the template's Controls collection.
            retMilestones.Controls.Add(cancel)
            'Create a handler for the cancel button.
            AddHandler cancel.Click, AddressOf cancel_Click
            'Place the button in row 3, column 2 of the grid bag's layout.
            ugbLayoutMgr.SetGridBagConstraint(cancel, New Infragistics.Win.Layout.GridBagConstraint(2, 9, 1, 1))
            'Instantiate a new UltraGridCellProxy object.


            Dim proxy1 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            'Set the proxy to show data from the ContactName column.
            proxy1.ColumnKey = "Description"
            proxy1.Size = New Size(300, 20)
            proxy1.Appearance.TextHAlign = HAlign.Left
            proxy1.UseAppStyling = True
            proxy1.UseGridAppearances = True

            '9/15/12 mrb 
            retMilestones.Enabled = True
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy1)
            'Place the proxy in row 1, column 2 of the grid bag layout.
            ugbLayoutMgr.SetGridBagConstraint(proxy1, New Infragistics.Win.Layout.GridBagConstraint(1, 0, 1, 1))


            Dim proxy2 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy2.ColumnKey = "UserAdded"
            proxy2.Size = New Size(20, 20)
            proxy2.Appearance.TextHAlign = HAlign.Left
            proxy2.UseAppStyling = True
            proxy2.UseGridAppearances = True
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy2)
            ugbLayoutMgr.SetGridBagConstraint(proxy2, New Infragistics.Win.Layout.GridBagConstraint(1, 1, 1, 1))

            Dim proxy3 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy3.ColumnKey = "Message"
            proxy3.Size = New Size(300, 20)
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy3)
            ugbLayoutMgr.SetGridBagConstraint(proxy3, New Infragistics.Win.Layout.GridBagConstraint(1, 2, 1, 1))

            Dim proxy4 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy4.ColumnKey = "Notify"
            proxy4.Size = New Size(20, 20)
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy4)
            ugbLayoutMgr.SetGridBagConstraint(proxy4, New Infragistics.Win.Layout.GridBagConstraint(1, 4, 1, 1))

            Dim proxy5 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy5.ColumnKey = "NotifyCriteria"
            proxy5.Size = New Size(100, 30)
            retMilestones.Controls.Add(proxy5)
            
            ugbLayoutMgr.SetGridBagConstraint(proxy5, New Infragistics.Win.Layout.GridBagConstraint(1, 5, 1, 1))
            Dim proxy6 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy6.ColumnKey = "BuilderCanCancel"
            proxy6.Size = New Size(20, 20)

            
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy6)
            ugbLayoutMgr.SetGridBagConstraint(proxy6, New Infragistics.Win.Layout.GridBagConstraint(1, 6, 1, 1))

            Dim proxy7 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy7.ColumnKey = "Subject"
            proxy7.Size = New Size(300, 20)
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy7)
            ugbLayoutMgr.SetGridBagConstraint(proxy7, New Infragistics.Win.Layout.GridBagConstraint(1, 3, 1, 1))

            Dim proxy8 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            proxy8.ColumnKey = "GroupID"
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(proxy8)
            ugbLayoutMgr.SetGridBagConstraint(proxy8, New Infragistics.Win.Layout.GridBagConstraint(1, 7, 1, 1))


            Dim Proxy9 As Infragistics.Win.UltraWinGrid.UltraGridCellProxy = New Infragistics.Win.UltraWinGrid.UltraGridCellProxy()
            Proxy9.ColumnKey = "OrderBy"
            'Add the proxy to the template's Controls collection.
            retMilestones.Controls.Add(Proxy9)
            ugbLayoutMgr.SetGridBagConstraint(Proxy9, New Infragistics.Win.Layout.GridBagConstraint(1, 8, 1, 1))
            retMilestones.AutoSizeMode = Windows.Forms.AutoSizeMode.GrowAndShrink
            retMilestones.AutoSize = True

            FormatTemplate = True
        Catch
            FormatTemplate = False
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: FormatTemplate ")
        End Try
    End Function
    Private Function LoadGrid() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsCriteria As New DataSet
        Try
            grdMilestones.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spMilestoneListGet") Then
                grdMilestones.DataSource = ds
                grdMilestones.DataBind()

                Dim layout As UltraGridLayout = grdMilestones.DisplayLayout
                Dim bands As BandsCollection = layout.Bands
                ' Get the first band, which is the  top-most band in case you had multple bands.
                Dim band As UltraGridBand = bands(0)
                ' Columns property off UltraGridBand returns the collection of columns associated with the band.
                Dim oColumns As ColumnsCollection = band.Columns
                grdMilestones.DisplayLayout.Bands(0).Columns("NotifyCriteria").ValueList = ddNotifyCriteria
                '9/21/12 mrb
                band.Columns("GroupID").ValueList = ddGroup
                'create column to track changes
                Dim ugc As UltraGridColumn

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("MilestoneID")
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("RelatedMilestoneID")
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("RelatedMilestone")
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("ActivityCode")
                ugc.Header.Caption = "Activity"
                ugc.Header.ToolTipText = "This milestone is created when the activity is paid"
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("GroupID")
                'ugc.Hidden = True
                ugc.Width = 100
                ugc.Header.Caption = "Group"
                ugc.CellActivation = Activation.NoEdit

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Group")
                ugc.Width = 100
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("UserAdded")
                ugc.Header.Caption = "User" & vbCrLf & "Added"
                ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                ugc.Header.ToolTipText = "If User Can Add is True, the milestone is available in the Job Maintenance screen for adding.  Otherwise, it is system added."
                ugc.Width = iColCheck

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("OrderBy")
                ugc.Header.Caption = "Order" & vbCrLf & "By"
                ugc.Header.ToolTipText = "This determines the display order within the group."
                ugc.Width = iColCheck

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Notify")
                ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                ugc.Header.ToolTipText = "This determines if anyone is notified when the milestone is completed."
                ugc.Width = iColCheck

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("ActivityCodePaid")
                ugc.Header.Caption = "Activity Code" & vbCrLf & "Paid"
                'add tool tips
                ugc.Header.ToolTipText = "This milestone is created when the activity listed is paid"
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("NotifyCriteria")
                ugc.Header.Caption = "Notify" & vbCrLf & "Criteria"
                ugc.Header.ToolTipText = "This indicates the group that is notified by this milestone."
                ugc.CellActivation = Activation.NoEdit
                ugc.Width = 80
                ugc.Hidden = False

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Action")
                ugc.Header.ToolTipText = "This is used by PO Payment module to determine an action to be taken."
                ugc.CellActivation = Activation.NoEdit
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Subject")
                ugc.Header.Caption = "eMail Subject"
                ugc.MaxLength = 50
                ugc.Width = 70

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Message")
                ugc.Header.Caption = "eMail Message"
                ugc.MaxLength = 250
                ugc.Width = 200

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Description")
                ugc.MaxLength = 100

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Description")
                ugc.Width = 230

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Other Milestone")
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("ActivityPaid")
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("ActionDescription")
                ugc.Hidden = True

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Note")
                ugc.Hidden = True

                ugc = oColumns("CanCancel")
                ugc.Header.Caption = "Can" & vbCrLf & "Cancel"
                ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                ugc.Width = iColCheck
                ugc.Header.ToolTipText = "Users can Cancel this milestone."

                ugc = oColumns("CanDelete")
                ugc.Header.Caption = "Can" & vbCrLf & "Delete"
                ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                ugc.Width = iColCheck
                ugc.Header.ToolTipText = "Users can Delete this milestone."

                ugc = oColumns("BuilderCanCancel")
                ugc.Header.Caption = "Bldr Can" & vbCrLf & "Cancel"
                ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                ugc.Width = iColCheck
                ugc.Header.ToolTipText = "Builders can Cancel this milestone from eBOSS."

                grdMilestones.DisplayLayout.Bands(0).Columns.Add("Changed", "Changed")
                grdMilestones.DisplayLayout.Bands(0).Columns("Changed").DataType = GetType(Boolean)

                ugc = grdMilestones.DisplayLayout.Bands(0).Columns("Changed")
                ugc.Header.Caption = "Chg"
                ugc.Style = Win.UltraWinGrid.ColumnStyle.CheckBox
                ugc.Width = iColCheck
                ugc.Header.ToolTipText = "This is checked if you have changed this milestone."
                band.ColHeaderLines = 2
                band.GroupHeaderLines = 2
            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            grdMilestones.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            If grdMilestones.Rows.Count > 0 Then
                If Not grdMilestones.ActiveRow Is Nothing Then '10/28/16 add check for activerow
                    grdMilestones.ActiveRow.Selected = True
                Else
                    grdMilestones.ActiveRow = grdMilestones.Rows(0) '10/28/16 mrb
                    LoadPositionToNotifyList()
                    LoadNotifyList()

                End If
            End If
            'mrb 9/3/12 take out for now
            '9/15/12 move to edit mode
            'grdMilestones.DisplayLayout.Bands(0).RowEditTemplate = retMilestones
            LoadGrid = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: LoadGrid ")
            LoadGrid = False
        End Try
    End Function

    Private Sub grdMilestones_AfterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grdMilestones.AfterSelectChange
        ' If grdMilestones.ActiveRow.Cells("Notify").Text = DefaultableBoolean.True Then
        Try
            If grdMilestones.ActiveRow.IsAddRow Then
            Else
                LoadNotifyList()
                LoadPositionToNotifyList()
                LoadDetail()
            End If ' move load to loaddetail
            '    If grdMilestones.ActiveRow.Cells("RelatedMilestone").Text <> "" Then
            '        lblRelatedMilestone.Text = "Related Milestone: " & grdMilestones.ActiveRow.Cells("RelatedMilestone").Text
            '    Else
            '        lblRelatedMilestone.Text = "Related Milestone: "
            '    End If
            '    If grdMilestones.ActiveRow.Cells("ActivityPaid").Text <> "" Then
            '        lblActivityPaid.Text = "Created when Activity Paid: " & grdMilestones.ActiveRow.Cells("ActivityPaid").Text
            '    Else
            '        lblActivityPaid.Text = "Create when Activity Paid: "
            '    End If
            '    If grdMilestones.ActiveRow.Cells("Action").Text <> "" Then
            '        lblAction.Text = "Action Performed when Activity Paid: " & grdMilestones.ActiveRow.Cells("Action").Text
            '        lblActionDescription.Text = grdMilestones.ActiveRow.Cells("ActionDescription").Text
            '        lblActionDescription.Visible = True
            '    Else
            '        lblAction.Text = "Action Performed when Activity Paid: "
            '        lblActionDescription.Visible = False
            '    End If
            '    If grdMilestones.ActiveRow.Cells("Note").Text <> "" Then
            '        lblNote.Text = "Created By: " & grdMilestones.ActiveRow.Cells("Note").Text
            '    Else
            '        lblNote.Text = "Created By: "
            '    End If
            'End If
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: grdMilestons_AfterSelectChange ")
        End Try
    End Sub
    Private Sub LoadDetail()
        Try
            If Not grdMilestones.ActiveRow Is Nothing Then
                If grdMilestones.ActiveRow.Cells("RelatedMilestone").Text <> "" Then
                    lblRelatedMilestone.Text = "Related Milestone: " & grdMilestones.ActiveRow.Cells("RelatedMilestone").Text
                Else
                    lblRelatedMilestone.Text = "Related Milestone: "
                End If
                If grdMilestones.ActiveRow.Cells("ActivityPaid").Text <> "" Then
                    lblActivityPaid.Text = "Created when Activity Paid: " & grdMilestones.ActiveRow.Cells("ActivityPaid").Text
                Else
                    lblActivityPaid.Text = "Create when Activity Paid: "
                End If
                If grdMilestones.ActiveRow.Cells("Action").Text <> "" Then
                    lblAction.Text = "Action Performed when Activity Paid: " & grdMilestones.ActiveRow.Cells("Action").Text
                    lblActionDescription.Text = grdMilestones.ActiveRow.Cells("ActionDescription").Text
                    lblActionDescription.Visible = True
                Else
                    lblAction.Text = "Action Performed when Activity Paid: "
                    lblActionDescription.Visible = False
                End If
                If grdMilestones.ActiveRow.Cells("Note").Text <> "" Then
                    lblNote.Text = "Created By: " & grdMilestones.ActiveRow.Cells("Note").Text
                Else
                    lblNote.Text = "Created By: "
                End If
            End If
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "Milestones: LoadDetail ")
        End Try
    End Sub
    Public Function LoadNotifyList() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim sNotifyCriteria As String = ""
        Try
            sNotifyCriteria = grdMilestones.ActiveRow.Cells("notifycriteria").Text

            grdNotifyList.DataSource = Nothing
            grdNotifyList.ResetDisplayLayout()
            grdNotifyList.Layouts.Clear()


            If sNotifyCriteria <> "" Then
                If dbCalls.GetRecordsFromSP(ds, "spNotifyListGet", sNotifyCriteria) Then
                    grdNotifyList.DataSource = ds
                    grdNotifyList.DataBind()
                    Dim layout As UltraGridLayout = grdNotifyList.DisplayLayout
                    Dim bands As BandsCollection = layout.Bands
                    ' Get the first band, which is the  top-most band in case you had multple bands.
                    Dim band As UltraGridBand = bands(0)
                    ' Columns property off UltraGridBand returns the collection of columns associated with the band.

                    Dim ugc As UltraGridColumn

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("ItemValue")
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("ItemValue2")
                    ugc.Width = 120
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Position")
                    ugc.Width = 180 '120
                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("ItemID")
                    ugc.Hidden = True
                End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                grdNotifyList.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                grdNotifyList.Text = "Users to Notify Criteria: " & sNotifyCriteria
                btnChangeUsers.Enabled = HasEditSecurity("milestones", "menu")
            Else
                grdNotifyList.Text = "Users to Notify"
                btnChangeUsers.Enabled = False
            End If 'If snotifycritera <> "" Then
            'grdNotifyList.Width = 375
            'grdNotifyList.Height = 200
            LoadNotifyList = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: LoadNotifyList ")
            LoadNotifyList = False
        End Try
    End Function
    Public Function LoadPositionToNotifyList() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim iMilestoneID As Int64 = 0
        Try
            If grdMilestones.ActiveRow.Cells("milestoneid").Text <> "" Then
                iMilestoneID = grdMilestones.ActiveRow.Cells("milestoneid").Text

                grdPositionsToNotify.DataSource = Nothing

                If iMilestoneID <> 0 Then
                    If dbCalls.GetRecordsFromSP(ds, "spNotifyPositionListGet", iMilestoneID) Then
                        'SELECT   p.Position, p.[rank], n.PositionToNotifyID, p.PositionID
                        grdPositionsToNotify.DataSource = ds
                        grdPositionsToNotify.DataBind()
                        Dim layout As UltraGridLayout = grdPositionsToNotify.DisplayLayout
                        Dim bands As BandsCollection = layout.Bands
                        ' Get the first band, which is the  top-most band in case you had multple bands.
                        Dim band As UltraGridBand = bands(0)
                        ' Columns property off UltraGridBand returns the collection of columns associated with the band.

                        Dim ugc As UltraGridColumn

                        '                    ugc = band.Columns("ItemValue")
                        '                   ugc.Hidden = True


                        ugc = band.Columns("PositionID")
                        ugc.Hidden = True
                        ugc = band.Columns("PositionToNotifyID")
                        ugc.Hidden = True
                    End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                    grdPositionsToNotify.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False

                Else

                    btnChangeUsers.Enabled = False
                End If 'If snotifycritera <> "" Then
                'grdPositionsToNotify.Width = 375
                'grdPositionsToNotify.Height = 200
            End If
            LoadPositionToNotifyList = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: LoadPositionToNotifyList ")
            LoadPositionToNotifyList = False
        End Try
    End Function

    'Private Sub grdMilestones_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdMilestones.ClickCellButton
    '    'If grdMilestones.ActiveRow.Cells("Edit").IsActiveCell Then

    '    'End If
    'End Sub

    'Private Sub grdMilestones_Enter(sender As Object, e As System.EventArgs) Handles grdMilestones.Enter

    'End Sub
    Private Sub grdMilestones_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdMilestones.InitializeLayout
        e.Layout.Bands(0).Override.AllowRowFiltering = DefaultableBoolean.True
        e.Layout.Bands(0).Override.RowFilterMode = RowFilterMode.AllRowsInBand
    End Sub

    Private Sub btnChangeUsers_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeUsers.Click
        Dim oUser As New UserSelect
        Try
            With oUser
                .oGridDS = grdNotifyList.DataSource
                '.oGridLayout = grdNotifyList.Layouts(0)
                grdNotifyList.DisplayLayout.Save("userlayout")
                .sCaption = grdMilestones.ActiveRow.Cells("NotifyCriteria").Text
                oUser.ShowDialog()
            End With
            LoadNotifyList()
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: btnChangeUsers_Click ")
        End Try
    End Sub
    Sub accept_Click(sender As Object, e As EventArgs)
        'Close the template and save any pending changes.
        grdMilestones.ActiveRow.Cells("Changed").Value = True
        LoadNotifyList()
        Me.retMilestones.Close(True)
        grdMilestonesLock()
    End Sub 'accept_Click


    Sub cancel_Click(sender As Object, e As EventArgs)
        'Close the template and discard any pending changes.
        'grdMilestones.ActiveRow.CancelUpdate()
        Me.retMilestones.Close(False)
        grdMilestonesLock()
    End Sub 'cancel_Click

    Private Sub tsBtnEdit_Click(sender As Object, e As System.EventArgs) Handles tsBtnEdit.Click
        'mrb 9/21/12 move to grdMilestones_RowEditTemplateRequested
        'With grdMilestones.DisplayLayout.Bands(0)
        '    .Columns("Description").CellActivation = Activation.AllowEdit
        '    .Columns("NotifyCriteria").CellActivation = Activation.AllowEdit
        '    .Columns("notifycriteria").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        '    .Columns("GroupID").CellActivation = Activation.AllowEdit
        '    .Columns("GroupID").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        'End With
        EnableDisableToolStrip(True, tsToolStrip, grdMilestones, "Milestones", "menu")
        '9/15/12 move to edit mode
        grdMilestones.DisplayLayout.Bands(0).RowEditTemplate = retMilestones

        FormatTemplate()

    End Sub

    Private Sub tsBtnUndo_Click(sender As Object, e As System.EventArgs) Handles tsBtnUndo.Click
        LoadGrid()
        EnableDisableToolStrip(False, tsToolStrip, grdMilestones, "Milestones", "menu")
        EnableDisableForm(False)
    End Sub

    Private Sub tsBtnSave_Click(sender As Object, e As System.EventArgs) Handles tsBtnSave.Click
        If SaveMilestones() Then
            LoadGrid()
            EnableDisableToolStrip(False, tsToolStrip, grdMilestones, "Milestones", "menu")
            EnableDisableForm(False)
        End If
    End Sub
    Private Sub EnableDisableForm(bEdit As Boolean)
        grdNotifyList.Enabled = Not bEdit
    End Sub
    Private Function SaveMilestones() As Boolean
        Dim cDB As New DBCalls
        Dim iMilestoneID As Int64 = 0
        Dim sDescription As String = ""
        Dim iUserAdded As Integer = 0
        Dim iOrderBy As Integer = 0
        Dim iNotify As Integer = 0
        Dim sNotifyCriteria As String = ""
        Dim sMessage As String = ""
        Dim bCanCancel As Boolean = False
        Dim bBuilderCanCancel As Boolean = False
        Dim sSubject As String = ""
        Dim sNote As String = ""
        Dim iGroupID As Integer = 0


        'create procedure spMilestoneUpdate
        '@MilestoneID as int,
        '@Description varchar(100),
        '@UserAdded tinyint,
        '@OrderBy int,
        '@Notify tinyint,
        '@NotifyCriteria varchar(50),
        '@Message varchar(250),
        '@CanCancel bit,
        '@BuilderCanCancel bit,
        '@Subject varchar(50),
        '@Note varchar(200),
        '@UpdatedBy char(10)
        Try
            Dim oRow As UltraGridRow
            Dim iRtn As Int64
            For Each oRow In grdMilestones.Rows
                'check for changes
                If oRow.Cells("Changed").Value = True Then
                    'save changes
                    If IsDBNull(oRow.Cells("MilestoneID").Value) Then
                        iMilestoneID = 0
                    Else
                        iMilestoneID = oRow.Cells("MilestoneID").Text
                    End If
                    sDescription = oRow.Cells("Description").Text
                    If oRow.Cells("UserAdded").Text <> "" Then
                        iUserAdded = oRow.Cells("UserAdded").Text
                    Else
                        iUserAdded = False
                    End If
                    If IsDBNull(oRow.Cells("OrderBy").Value) Then
                        iOrderBy = 0
                    Else
                        iOrderBy = oRow.Cells("OrderBy").Value
                    End If
                    If IsDBNull(oRow.Cells("Notify").Value) Then
                        iNotify = 0
                    Else
                        iNotify = oRow.Cells("Notify").Text
                    End If
                    'mrb 9/21/12
                    If IsDBNull(oRow.Cells("GroupID").Value) Then
                        iGroupID = 0
                    Else
                        iGroupID = oRow.Cells("GroupID").Value
                    End If

                    sNotifyCriteria = oRow.Cells("NotifyCriteria").Text
                    sMessage = oRow.Cells("Message").Text
                    If oRow.Cells("CanCancel").Text <> "" Then
                        bCanCancel = oRow.Cells("CanCancel").Text
                    Else
                        bCanCancel = False
                    End If
                    If oRow.Cells("BuilderCanCancel").Text <> "" Then
                        bBuilderCanCancel = oRow.Cells("BuilderCanCancel").Text
                    Else
                        bBuilderCanCancel = False
                    End If
                    sSubject = oRow.Cells("Subject").Text
                    sNote = oRow.Cells("Note").Text
                    iRtn = cDB.GetReturnValueFromSP("spMilestoneUpdate", iMilestoneID, sDescription, iUserAdded, _
                                                    iOrderBy, iNotify, sNotifyCriteria, _
                                                    sMessage, bCanCancel, bBuilderCanCancel, sSubject, sNote, gsUserID, iGroupID)
                    If iRtn <> 0 Then
                        ShowError("Unable to save Milestone: " & sDescription, False, "BOSSAdmin", "Milestones: SaveMilestones ")
                    End If
                End If
            Next
            SaveMilestones = True
        Catch ex As Exception
            ShowError(Err.Description, False, "BOSSAdmin", "Milestones: SaveMilestones ")
            SaveMilestones = False
        Finally
            cDB = Nothing
        End Try

    End Function

    Private Sub tsBtnAdd_Click(sender As Object, e As System.EventArgs) Handles tsBtnAdd.Click
        EnableDisableForm(True)
        EnableDisableToolStrip(True, tsToolStrip, grdMilestones, "Milestones", "Menu")
        grdMilestones.Focus()

        Dim row As UltraGridRow = grdMilestones.DisplayLayout.Bands(0).AddNew()
        row.Selected = True
        row.Cells("Description").Activate()
        '9/15/12 move to edit mode
        FormatTemplate()
        grdMilestones.DisplayLayout.Bands(0).RowEditTemplate = retMilestones
        ' grdMilestones.PerformAction(UltraGridAction.EnterEditMode)

        row.ShowEditTemplate()

    End Sub

    
    Private Sub grdMilestonesLock()
        With grdMilestones.DisplayLayout.Bands(0)
            .Columns("Description").CellActivation = Activation.NoEdit
            .Columns("NotifyCriteria").CellActivation = Activation.NoEdit
            .Columns("notifycriteria").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.OnCellActivate
            .Columns("GroupID").CellActivation = Activation.NoEdit
            .Columns("GroupID").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.OnCellActivate
        End With
    End Sub

    Private Sub grdMilestones_RowEditTemplateRequested(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEditTemplateRequestedEventArgs) Handles grdMilestones.RowEditTemplateRequested
        With grdMilestones.DisplayLayout.Bands(0)
            .Columns("Description").CellActivation = Activation.AllowEdit
            .Columns("NotifyCriteria").CellActivation = Activation.AllowEdit
            .Columns("notifycriteria").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            .Columns("GroupID").CellActivation = Activation.AllowEdit
            .Columns("GroupID").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
        End With
    End Sub
End Class