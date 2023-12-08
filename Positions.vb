Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Windows.Forms
Public Class Positions
    Private Function LoadGrid() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Try
            grdPositions.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spPositionsListGet") Then
                grdPositions.DataSource = ds
                grdPositions.DataBind()
                Dim layout As UltraGridLayout = grdPositions.DisplayLayout
                Dim bands As BandsCollection = layout.Bands
                ' Get the first band, which is the  top-most band in case you had multple bands.
                Dim band As UltraGridBand = bands(0)
                ' Columns property off UltraGridBand returns the collection of columns associated with the band.
                Dim oColumns As ColumnsCollection = band.Columns

                'create column to track changes
                ' Dim ugc As UltraGridColumn

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("MilestoneID")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("RelatedMilestoneID")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("RelatedMilestone")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActivityCode")
                'ugc.Header.Caption = "Activity"
                'ugc.Header.ToolTipText = "This milestone is created when the activity is paid"
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("GroupID")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Group")
                'ugc.Width = 100

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("UserAdded")
                'ugc.Header.Caption = "User" & vbCrLf & "Added"
                'ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                'ugc.Header.ToolTipText = "If User Can Add is True, the milestone is available in the Job Maintenance screen for adding.  Otherwise, it is system added."
                'ugc.Width = iColCheck

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("OrderBy")
                'ugc.Header.Caption = "Order" & vbCrLf & "By"
                'ugc.Header.ToolTipText = "This determines the display order within the group."
                'ugc.Width = iColCheck

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Notify")
                'ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                'ugc.Header.ToolTipText = "This determines if anyone is notified when the milestone is completed."
                'ugc.Width = iColCheck

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActivityCodePaid")
                'ugc.Header.Caption = "Activity Code" & vbCrLf & "Paid"
                ''add tool tips
                'ugc.Header.ToolTipText = "This milestone is created when the activity listed is paid"
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("NotifyCriteria")
                'ugc.Header.Caption = "Notify" & vbCrLf & "Criteria"
                'ugc.Header.ToolTipText = "This indicates the group that is notified by this milestone."
                'ugc.CellActivation = Activation.NoEdit
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Action")
                'ugc.Header.ToolTipText = "This is used by PO Payment module to determine an action to be taken."
                'ugc.CellActivation = Activation.NoEdit
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Message")
                'ugc.Width = 200

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Description")
                'ugc.Width = 230

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Other Milestone")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActivityPaid")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActionDescription")
                'ugc.Hidden = True

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Note")
                'ugc.Hidden = True

                'ugc = oColumns("CanCancel")
                'ugc.Header.Caption = "Can" & vbCrLf & "Cancel"
                'ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                'ugc.Width = iColCheck
                'ugc.Header.ToolTipText = "Users can Cancel this milestone."

                'ugc = oColumns("CanDelete")
                'ugc.Header.Caption = "Can" & vbCrLf & "Delete"
                'ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                'ugc.Width = iColCheck
                'ugc.Header.ToolTipText = "Users can Delete this milestone."

                'ugc = oColumns("BuilderCanCancel")
                'ugc.Header.Caption = "Bldr Can" & vbCrLf & "Cancel"
                'ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                'ugc.Width = iColCheck
                'ugc.Header.ToolTipText = "Builders can Cancel this milestone from eBOSS."

                'grdPositions.DisplayLayout.Bands(0).Columns.Add("Changed", "Changed")
                'grdPositions.DisplayLayout.Bands(0).Columns("Changed").DataType = GetType(Boolean)

                'ugc = grdPositions.DisplayLayout.Bands(0).Columns("Changed")
                'ugc.Header.Caption = "Chg"
                'ugc.Style = Win.UltraWinGrid.ColumnStyle.CheckBox
                'ugc.Width = iColCheck
                'ugc.Header.ToolTipText = "This is checked if you have changed this milestone."
                'band.ColHeaderLines = 2
                'band.GroupHeaderLines = 2
            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            grdPositions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
            If grdPositions.Rows.Count > 0 Then
                If Not grdPositions.ActiveRow Is Nothing Then '9/16/16 mrb
                    grdPositions.ActiveRow.Selected = True
                End If
            End If


            LoadGrid = True
        Catch
            MsgBox("Error in VPOReasons LoadGrid: " & Err.Description, vbCritical)
            LoadGrid = False
        End Try
    End Function

    Private Sub Positions_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadGrid()
        LoadUserGrid()
        LoadSecurityGrid()
    End Sub
    Private Function LoadUserGrid() As Boolean
        Dim ds2 As New DataSet
        Dim cDB As New DBCalls
        Dim iPositionID As Integer
        iPositionID = grdPositions.ActiveRow.Cells("PositionID").Value
        Try
            If cDB.GetRecordsFromSP(ds2, "spUsersByPositionGet", iPositionID) Then
                grdUsers.DataSource = ds2
                grdUsers.DataBind()
                grdUsers.Height = 200
                grdUsers.Width = 375
            End If
           
            grdUsers.DisplayLayout.Bands(0).Columns("Type").Hidden = True '9/20/16 mrb
            LoadUserGrid = True
        Catch
            LoadUserGrid = False
        Finally
            cDB = Nothing

        End Try
    End Function
    Private Function LoadSecurityGrid() As Boolean
        Dim ds2 As New DataSet
        Dim cDB As New DBCalls
        Dim iPositionID As Integer
        iPositionID = grdPositions.ActiveRow.Cells("PositionID").Value
        Try
            If cDB.GetRecordsFromSP(ds2, "spSecurityByPositionIDGet", iPositionID) Then
                grdSecurity.DataSource = ds2
                grdSecurity.DataBind()
                grdSecurity.Height = 200
                grdSecurity.Width = 375

                ' Dim ugc As UltraGridColumn

                'ugc = grdSecurity.DisplayLayout.Bands(0).Columns("siid")
                'ugc.Hidden = True
            End If
            LoadSecurityGrid = True
        Catch
            LoadSecurityGrid = False
        Finally
            '9/16/16 mrb    
            If Not cDB Is Nothing Then
                cDB = Nothing
            End If
            If Not ds2 Is Nothing Then
                ds2 = Nothing
            End If
        End Try
    End Function
    Private Sub grdpositions_AfterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grdPositions.AfterSelectChange
        LoadUserGrid()
        LoadSecurityGrid()
    End Sub
    
End Class