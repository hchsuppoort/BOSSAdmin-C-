Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Windows.Forms
Imports Infragistics.Win

Public Class VPOReasons
    Dim tooltip2 As System.Windows.Forms.ToolTip
    Dim ds As New DataSet
    Dim ddOwner As New UltraDropDown
    Dim ddAssignTo As New UltraDropDown
    Dim ultraDropDown1 As UltraDropDown
    'Instantiate an UltraGridRowEditTemplate object.
    Dim templateReason As New UltraGridRowEditTemplate()
    Dim bAddNew As Boolean = False
    Private Sub VPOReasons_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If LoadGrid() Then
            EnableDisableToolStrip(False)
            'Set the template's size, caption, backcolor, 
            'and add it to the Controls collection.
            'With templateReason
            '    .Size = New Size(320, 240)
            '    .DialogSettings.Caption = "Contact Information"
            '    .Appearance.BackColor = Color.White
            '    .Visible = False
            '    Me.Controls.Add(templateReason)
            '    ' Me.grdReasons.DisplayLayout.Bands(0).RowEditTemplate = Me.templateReason
            'End With
        End If
    End Sub
    Private Function LoadGrid() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Try
            grdReasons.DataSource = Nothing
            If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                grdReasons.DataSource = ds
                If dbCalls.GetRecordsFromSP(dsPositions, "spGetPositions") Then

                End If
                grdReasons.DataBind()
                Dim layout As UltraGridLayout = grdReasons.DisplayLayout
                Dim bands As BandsCollection = layout.Bands
                ' Get the first band, which is the  top-most band in case you had multple bands.
                Dim band As UltraGridBand = bands(0)
                ' Columns property off UltraGridBand returns the collection of columns associated with the band.
                Dim oColumns As ColumnsCollection = band.Columns
                ' You can get a particular column using the column name.
                Dim oColumnResponsiblePosition As UltraGridColumn = oColumns("ResponsiblePositionID")
                Dim oColumnAssignmentTo As UltraGridColumn = oColumns("AssignmentToPosition")
                'create dropdown for Owner
                Me.ddOwner.SetDataBinding(dsPositions, Nothing)
                Me.ddOwner.ValueMember = "PositionID"
                Me.ddOwner.DisplayMember = "Position"
                grdReasons.DisplayLayout.Bands(0).Columns("ResponsiblePositionID").ValueList = ddOwner
                'create dropdown for AssignTo
                Me.ddAssignTo.SetDataBinding(dsPositions, Nothing)
                Me.ddAssignTo.ValueMember = "PositionID"
                Me.ddAssignTo.DisplayMember = "Position"
                grdReasons.DisplayLayout.Bands(0).Columns("AssignmentToPosition").ValueList = ddAssignTo
                'create column to track changes
                grdReasons.DisplayLayout.Bands(0).Columns.Add("Changed", "Changed")
                grdReasons.DisplayLayout.Bands(0).Columns("Changed").DataType = GetType(Boolean)
                Dim ugc As UltraGridColumn
                ugc = grdReasons.DisplayLayout.Bands(0).Columns("Changed")
                ugc.Style = Win.UltraWinGrid.ColumnStyle.CheckBox

            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False

            LoadGrid = True
        Catch
            MsgBox("Error in VPOReasons LoadGrid: " & Err.Description, vbCritical)
            LoadGrid = False
        End Try
    End Function

    Private Sub grdReasons_CellChange(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdReasons.CellChange
        grdReasons.ActiveRow.Cells("Changed").Value = True
    End Sub
    Private Sub grdReasons_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdReasons.InitializeLayout
        ' e.Layout.Bands(0).Columns("Int32 1").ValueList = Me.ultraDropDown1
        With e.Layout.Bands(0)
            .Columns("ResponsiblePositionID").Header.Caption = "Owner"

            .Columns("AssignmentToPosition").Header.Caption = "Assign To"

            .Columns("Reason").MaxLength = 30

            .Columns("ReasonCode").Header.Caption = "Code"
            .Columns("ReasonCode").Width = 48
            .Columns("ReasonCode").CellActivation = Activation.Disabled ' we don't want this column edited

            .Columns("Message").MaxLength = 100

            .Columns("Inactive").Width = 48
            .Columns("Inactive").DefaultCellValue = vbFalse
        End With
    End Sub

    Private Sub grdReasons_MouseEnterElement(sender As Object, e As Infragistics.Win.UIElementEventArgs) Handles grdReasons.MouseEnterElement
        ' tool tip over cell 
        Dim sTip As String = ""
        Dim acell As UltraGridCell = e.Element.GetContext(GetType(Infragistics.Win.UltraWinGrid.UltraGridCell))
        tooltip2 = New System.Windows.Forms.ToolTip()

        'If Not acell Is Nothing Then
        '    sTip = "cell tool tip for " + acell.Column.Key
        '    tooltip2.Active = True
        '    Select Case acell.Column.Key
        '        Case "ReasonCode"
        '            sTip = "This code is used in the Purchase Order"
        '        Case "Reason"
        '            sTip = "Description of the VPO Reason"
        '        Case "ResponsiblePositionID"
        '            sTip = "New VPO Investigations will be assigned to this Position"
        '        Case "AssignmentToPosition"
        '            sTip = "New VPO Investigations will assigned to this Position for review before the Owner review"
        '        Case "Message"
        '            sTip = "This message is used in the VPO Investigation actions"
        '    End Select
        '    tooltip2.SetToolTip(sender, sTip)

        'End If

        ' tool tip over column header 
        Dim aColumnHeader As Infragistics.Win.UltraWinGrid.ColumnHeader = e.Element.GetContext(GetType(Infragistics.Win.UltraWinGrid.ColumnHeader))

        If Not aColumnHeader Is Nothing Then
            sTip = "Column Header Tool Tip for " + aColumnHeader.Column.Key
            tooltip2.Active = True
            Select Case aColumnHeader.Column.Key
                Case "ReasonCode"
                    sTip = "This code is used in the Purchase Order. It cannot be changed by the user."
                Case "Reason"
                    sTip = "Description of the VPO Reason"
                Case "ResponsiblePositionID"
                    sTip = "New VPO Investigations will be assigned to this Position"
                Case "AssignmentToPosition"
                    sTip = "New VPO Investigations will assigned to this Position for review before the Owner review"
                Case "Message"
                    sTip = "This message is used in the VPO Investigation actions"
            End Select
            tooltip2.SetToolTip(sender, sTip)
        End If

    End Sub



    Private Sub tsToolStrip_ItemClicked(sender As Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles tsToolStrip.ItemClicked
        Select Case e.ClickedItem.Name
            Case "tsBtnAdd"
                'Me.templateReason.Visible = True
                grdReasons.DisplayLayout.Bands(0).AddNew()
                EnableDisableToolStrip(True)
                bAddNew = True
            Case "tsBtnEdit"
                EnableDisableToolStrip(True)
            Case "tsBtnSave"
                If bAddNew Then
                    If SaveNewReason() Then
                        LoadGrid()
                        EnableDisableToolStrip(False)
                        MsgBox("Add new VPOReason: Changes Saved", MsgBoxStyle.Information)
                    End If
                Else
                    If UpdateReason() Then
                        LoadGrid()
                        EnableDisableToolStrip(False)
                        MsgBox("Update VPOReason: Changes Saved", MsgBoxStyle.Information)
                    End If
                End If

            Case "tsBtnUndo"
                LoadGrid()
                EnableDisableToolStrip(False)
            Case "tsBtnPrint"
            Case "tsBtnTip"
        End Select
    End Sub
    Private Sub EnableDisableToolStrip(bEdit As Boolean)
        Dim bCanEdit As Boolean

        bCanEdit = HasEditSecurity("VPOReasons", "Menu") And Not bEdit
        tsToolStrip.Items("tsBtnAdd").Enabled = bCanEdit
        tsToolStrip.Items("tsBtnEdit").Enabled = bCanEdit
        tsToolStrip.Items("tsBtnUndo").Enabled = bEdit
        tsToolStrip.Items("tsBtnSave").Enabled = bEdit
        tsToolStrip.Items("tsBtnPrint").Enabled = Not bEdit
        If bEdit Then
            grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
        Else
            grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        End If
    End Sub
    Private Function SaveNewReason()
        Dim oDB As New DBCalls
        Dim lRtn As Long = 0
        Dim sReason As String = grdReasons.ActiveRow.Cells("Reason").Text
        Dim iOwner As Integer = grdReasons.ActiveRow.Cells("ResponsiblePositionID").Value
        Dim iAssignTo As Integer = grdReasons.ActiveRow.Cells("AssignmentToPosition").Value
        Dim sMessage As String = grdReasons.ActiveRow.Cells("Message").Text
        Dim bInactive As Boolean = grdReasons.ActiveRow.Cells("Inactive").Value
        Dim iInactive As Integer
        Try
            If grdReasons.ActiveRow.Cells("Inactive").Value = True Then
                iInactive = 1
            Else
                iInactive = 0
            End If
            '@CreatedBy char(10),
            '@Reason char(30),
            '@Inactive bit,
            '@ResponsiblePositionID int,
            '@AssignmentToPosition int,
            '@Message varchar(100)

            lRtn = oDB.GetReturnValueFromSP("spVPOReasonInsert", gsUserID, sReason, bInactive, iOwner, iAssignTo, sMessage)
            SaveNewReason = lRtn = 0
        Catch
            MsgBox("Error in SaveNewReason: " & Err.Description, MsgBoxStyle.Critical, "Save New Reason")
            SaveNewReason = False
        Finally
            Cursor = Cursors.Default
        End Try
    End Function

    Private Function UpdateReason() As Boolean
        Dim oDB As New DBCalls
        Dim lRtn As Long = 0
        Dim bOk As Boolean = True
        Try
            Cursor = Cursors.WaitCursor
            Dim oRow As UltraGridRow

            For Each oRow In grdReasons.Rows
                If bOk Then
                    If oRow.Cells("Changed").Value = True Then
                        Dim iReason As Integer = grdReasons.ActiveRow.Cells("ReasonCode").Value
                        Dim sReason As String = grdReasons.ActiveRow.Cells("Reason").Text
                        Dim iOwner As Integer = grdReasons.ActiveRow.Cells("ResponsiblePositionID").Value
                        ' Dim iAssignTo As Integer = 0
                        'If Not IsDBNull(grdReasons.ActiveRow.Cells("AssignmentToPosition").Value) Then
                        Dim iAssignTo = grdReasons.ActiveRow.Cells("AssignmentToPosition").Value
                        'End If
                        Dim sMessage As String = grdReasons.ActiveRow.Cells("Message").Text
                        Dim bInactive As Boolean = grdReasons.ActiveRow.Cells("Inactive").Value
                        Dim iInactive As Integer
                        If grdReasons.ActiveRow.Cells("Inactive").Text = True Then
                            iInactive = 1
                        Else
                            iInactive = 0
                        End If
                        'alter procedure spVPOReasonUpdate
                        ' @UpdatedBy char(10),
                        ' @ReasonCode int,
                        ' @Reason char(30),
                        ' @Inactive bit,
                        ' @ResponsiblePositionID int,
                        ' @AssignmentToPosition int,
                        ' @Message varchar(100)

                        lRtn = oDB.GetReturnValueFromSP("spVPOReasonUpdate", gsUserID, iReason, sReason, iInactive, iOwner, iAssignTo, sMessage)
                        'UpdateReason = lRtn = 0
                        bOk = lRtn = 0
                    End If 'if row changed
                End If ' if bok
            Next
            UpdateReason = bOk
        Catch
            MsgBox("Error in UpdateReason: " & Err.Description, MsgBoxStyle.Critical, "Update VPO Reason")
            UpdateReason = False
        Finally
            Cursor = Cursors.Default
        End Try
    End Function
End Class