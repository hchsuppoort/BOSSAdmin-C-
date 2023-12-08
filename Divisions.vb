Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Windows.Forms
Public Class Divisions
    Dim ddNSMs As New UltraDropDown
    Dim bAddNew As Boolean = False
    Dim iDivisionManagerID As Integer
    Dim iProductionManagerID As Integer
    Dim iSalesManagerID As Integer
    Private Sub Divisions_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Try
            Dim bGoOn As Boolean
            bGoOn = LoadDivisions()
            If bGoOn Then
                bGoOn = LoadDivisionManagers()
            End If

            If bGoOn Then
                bGoOn = LoadProductionManagers()
            End If
            If bGoOn Then
                bGoOn = LoadSalesManagers()
            End If
            '11/1/16 mrb
            iDivisionManagerID = uCboDivisionManagers.Value
            iProductionManagerID = uCboProductionManagers.Value
            iSalesManagerID = ucboSalesManagers.Value
            If bGoOn Then
                bGoOn = LoadNSMGrid()
            End If
            If bGoOn Then
                EnableDisableToolStrip(False, "Divisions_Load")
            Else
                ShowError("Unable to load form.  Divisions_Load", False, "LoadError", "BOSSAdmin")
                Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Divisions_Load")
        End Try
    End Sub
    Private Function LoadDivisions() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim sNotifyCriteria As String = ""
        Try

            grdDivisions.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spDivisionDataGet") Then
                grdDivisions.DataSource = ds
                grdDivisions.DataBind()
                Dim layout As UltraGridLayout = grdDivisions.DisplayLayout
                Dim bands As BandsCollection = layout.Bands
                ' Get the first band, which is the  top-most band in case you had multple bands.
                Dim band As UltraGridBand = bands(0)
                ' Columns property off UltraGridBand returns the collection of columns associated with the band.

                Dim ugc As UltraGridColumn

                ugc = grdDivisions.DisplayLayout.Bands(0).Columns("DivisionID")
                ugc.Hidden = True

                ugc = grdDivisions.DisplayLayout.Bands(0).Columns("Division")
                ugc.Width = 150

                ugc = grdDivisions.DisplayLayout.Bands(0).Columns("DivisionManagerID")

                'ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Position")
                'ugc.Width = 120

            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            ' select first row
            grdDivisions.Rows(0).Activate()
            grdDivisions.ActiveRow.Selected = True

            LoadDivisions = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Divisions: LoadDivisions ")
            LoadDivisions = False
        End Try
    End Function
    Private Function LoadDivisionManagers() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim sNotifyCriteria As String = ""
        Dim sManager As String = ""
        Try

            uCboDivisionManagers.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spUsersByPositionGet", 3) Then '"spGetUserListByPosition", 3) Then
                uCboDivisionManagers.DataSource = ds
                uCboDivisionManagers.DataBind()

                Dim ugc As UltraGridColumn

                ugc = uCboDivisionManagers.DisplayLayout.Bands(0).Columns("SIID")
                ugc.Hidden = True
                ugc = uCboDivisionManagers.DisplayLayout.Bands(0).Columns("fname")
                ugc.Hidden = True
                ugc = uCboDivisionManagers.DisplayLayout.Bands(0).Columns("lname")
                ugc.Hidden = True
                ugc = uCboDivisionManagers.DisplayLayout.Bands(0).Columns("inactive") '11/1/16 mrb
                ugc.Hidden = True

                ugc = uCboDivisionManagers.DisplayLayout.Bands(0).Columns("UserName")
                ugc.Header.Caption = "User Name"
                ugc.Width = 150


            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            LoadDivisionManagers = True
            uCboDivisionManagers.Enabled = True
            uCboDivisionManagers.DisplayMember = "UserName"
            uCboDivisionManagers.ValueMember = "siid"

        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Divisions: LoadDivisionManagers ")
            LoadDivisionManagers = False
        End Try
    End Function
    Private Function LoadProductionManagers() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim sNotifyCriteria As String = ""
        Try

            uCboProductionManagers.DataSource = Nothing
            If dbCalls.GetRecordsFromSP(ds, "spUsersByPositionGet", 2) Then '"spGetUserListByPosition", 2) Then 11/1/16
                uCboProductionManagers.DataSource = ds
                uCboProductionManagers.DataBind()

                Dim ugc As UltraGridColumn

                ugc = uCboProductionManagers.DisplayLayout.Bands(0).Columns("SIID")
                ugc.Hidden = True
                ugc = uCboProductionManagers.DisplayLayout.Bands(0).Columns("fname")
                ugc.Hidden = True
                ugc = uCboProductionManagers.DisplayLayout.Bands(0).Columns("lname")
                ugc.Hidden = True
                ugc = uCboProductionManagers.DisplayLayout.Bands(0).Columns("inactive")
                ugc.Hidden = True

                ugc = uCboProductionManagers.DisplayLayout.Bands(0).Columns("UserName")
                ugc.Header.Caption = "User Name"
                ugc.Width = 150


            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            uCboProductionManagers.Enabled = True
            uCboProductionManagers.DisplayMember = "UserName"
            uCboProductionManagers.ValueMember = "siid"
            LoadProductionManagers = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Divisions: LoadProductionManagers ")
            LoadProductionManagers = False
        End Try
    End Function
    Private Function LoadSalesManagers() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls

        Dim sNotifyCriteria As String = ""
        Try

            ucboSalesManagers.DataSource = Nothing
            If dbCalls.GetRecordsFromSP(ds, "spusersbypositionget", 28) Then '"spGetUserListByPosition", 28) Then

                ucboSalesManagers.DataSource = ds
                ucboSalesManagers.DataBind()

                Dim ugc As UltraGridColumn

                ugc = ucboSalesManagers.DisplayLayout.Bands(0).Columns("SIID")
                ugc.Hidden = True
                ugc = ucboSalesManagers.DisplayLayout.Bands(0).Columns("fname")
                ugc.Hidden = True
                ugc = ucboSalesManagers.DisplayLayout.Bands(0).Columns("lname")
                ugc.Hidden = True
                ugc = ucboSalesManagers.DisplayLayout.Bands(0).Columns("inactive") '11/1/16 mrb
                ugc.Hidden = True

                ugc = ucboSalesManagers.DisplayLayout.Bands(0).Columns("UserName")
                ugc.Header.Caption = "User Name"
                ugc.Width = 150


            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            ucboSalesManagers.Enabled = True
            ucboSalesManagers.DisplayMember = "UserName"
            ucboSalesManagers.ValueMember = "siid"
            LoadSalesManagers = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Divisions: LoadSalesManagers ")
            LoadSalesManagers = False
        End Try
    End Function

    Private Sub EnableDisableToolStrip(bEdit As Boolean, sCalledBy As String)
        Dim bCanEdit As Boolean
        Try
            bCanEdit = HasEditSecurity("Divisions", "Menu") And Not bEdit
            tsToolStrip.Items("tsBtnAdd").Enabled = False ' change the way we do adds mrb 11/1/16 bCanEdit
            tsToolStrip.Items("tsBtnEdit").Enabled = bCanEdit
            tsToolStrip.Items("tsBtnUndo").Enabled = bEdit
            tsToolStrip.Items("tsBtnSave").Enabled = bEdit
            tsToolStrip.Items("tsBtnPrint").Enabled = False ' no report at this time 11/1/16 mrb Not bEdit
            If bCanEdit And bEdit Then '11/1/16
                grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.FixedAddRowOnBottom
            Else
                grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.No '11/1/16 mrb
            End If
            If bEdit Then ' bCanEdit Then  11/1/16 mrb
                'uCboDivisionManagers.ReadOnly = bCanEdit
                'uCboProductionManagers.ReadOnly = bCanEdit
                'ucboSalesManagers.ReadOnly = bCanEdit
                'If sCalledBy = "tsBtnAdd" Then 'this part isn't used anymore mrb 11/1/16
                '    'grdDivisions.DisplayLayout.AddNewBox.Hidden = False
                '    'grdDivisions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                '    'grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                '    'grdNSM.DisplayLayout.AddNewBox.Hidden = True
                '    'grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
                'Else
                If bCanEdit Then
                    grdDivisions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Add(FilterComparisionOperator.Equals, grdDivisions.ActiveRow.Cells("divisionid").Value)
                    grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.FixedAddRowOnBottom 'AllowAddNew.Yes 'AllowAddNew.No
                    'grdDivisions.DisplayLayout.AddNewBox.Hidden = True
                    'grdNSM.DisplayLayout.AddNewBox.Hidden = bCanEdit
                    grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    If sCalledBy = "tsBtnAdd" Then
                        grdNSM.DisplayLayout.Bands(0).Columns("SIID").CellActivation = Activation.AllowEdit
                    End If
                    If sCalledBy = "tsBtnEdit" Then
                        grdNSM.DisplayLayout.Bands(0).Columns("SIID").CellActivation = Activation.NoEdit
                    End If
                    '11/1/16 mrb
                    If sCalledBy = "tsBtnAdd" Then
                        grdNSM.DisplayLayout.Bands(0).Columns("StartDate").CellActivation = Activation.AllowEdit
                    Else
                        grdNSM.DisplayLayout.Bands(0).Columns("StartDate").CellActivation = Activation.NoEdit
                    End If
                    If sCalledBy = "tsBtnEdit" Then
                        grdNSM.DisplayLayout.Bands(0).Columns("EndDate").CellActivation = Activation.AllowEdit
                    Else
                        grdNSM.DisplayLayout.Bands(0).Columns("EndDate").CellActivation = Activation.NoEdit
                    End If
                    grdNSM.DisplayLayout.Bands(0).Columns("Inactive").CellActivation = Activation.NoEdit
                    grdNSM.DisplayLayout.Override.AllowAddNew = AllowAddNew.FixedAddRowOnBottom 'AllowAddNew.Yes
                    'End If
                End If
            Else 'if not bedit
                grdDivisions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                'grdDivisions.DisplayLayout.AddNewBox.Hidden = True
                grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                uCboDivisionManagers.ReadOnly = True
                uCboProductionManagers.ReadOnly = True
                ucboSalesManagers.ReadOnly = True
                'grdNSM.DisplayLayout.AddNewBox.Hidden = True
            End If
            'uCboDivisionManagers.ReadOnly = bCanEdit
            'uCboProductionManagers.ReadOnly = bCanEdit
            'ucboSalesManagers.ReadOnly = bCanEdit
            'grdNSM.DisplayLayout.AddNewBox.Hidden = bCanEdit

            'grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        Catch
            ShowError("Error in EnableDisableToolStrip" & Err.Description, False, "BOSSAdmin", "Divisions: EnableDisableToolStrip ")
        End Try

    End Sub

    Private Sub tsBtnAdd_Click(sender As Object, e As System.EventArgs) Handles tsBtnAdd.Click
        EnableDisableToolStrip(True, "tsBtnAdd")

    End Sub

    Private Sub tsBtnEdit_Click(sender As Object, e As System.EventArgs) Handles tsBtnEdit.Click

        EnableDisableToolStrip(True, "tsBtnEdit")
        bAddNew = False
    End Sub

    Private Sub tsBtnSave_Click(sender As Object, e As System.EventArgs) Handles tsBtnSave.Click
        Dim bSaved As Boolean = False
        If bAddNew Then
            bSaved = SaveNewDivision()
        Else
            bSaved = saveDivisionChanges
        End If
        If bSaved Then
            LoadNSMGrid()
            EnableDisableToolStrip(False, "tsBtnSave")
            bAddNew = True
        End If
    End Sub
    Private Function SaveNewDivision() As Boolean
        Dim sDivision As String = ""
        Dim iDivisionManagerID As Integer = 0
        Dim iProductionManagerID As Integer = 0
        Dim iSalesManagerID As Integer = 0
        Dim cdb As New DBCalls
        SaveNewDivision = False
        Try
            sDivision = grdDivisions.ActiveRow.Cells("division").Text
            iDivisionManagerID = uCboDivisionManagers.ActiveRow.Cells("siid").Value
            iProductionManagerID = uCboProductionManagers.ActiveRow.Cells("siid").Value
            iSalesManagerID = ucboSalesManagers.ActiveRow.Cells("siid").Value
            'create procedure spDivisionInsert
            ' @Division varchar(50),
            ' @CreatedBy char(10),
            ' @DivisionManagerID int, 
            ' @SalesManagerID int, 
            ' @ProductionManagerID int
            If cdb.GetReturnValueFromSP("spDivisionInsert", sDivision, gsUserID, iDivisionManagerID, iSalesManagerID, iProductionManagerID) = 0 Then
                SaveNewDivision = True
            Else
                ShowError("Unknown Error in savenewdivision ", True, "BOSSAdmin", "Divisions: SaveNewDivision ")
            End If
        Catch
            ShowError("Error in savenewdivision: " & Err.Description, False, "BOSSAdmin", "Divisions: SaveNewDivision ")
            SaveNewDivision = False
        Finally
            cdb = Nothing
        End Try
    End Function
    Private Function SaveDivisionChanges() As Boolean
        Dim iDivisionID As Integer = 0
        Dim iDivisionManagerID As Integer = 0
        Dim iProductionManagerID As Integer = 0
        Dim iSalesManagerID As Integer = 0
        Dim cdb As New DBCalls
        Dim bSaved As Boolean = False
        Dim bChangesMade As Boolean = False
        SaveDivisionChanges = False
        Try
            iDivisionID = grdDivisions.ActiveRow.Cells("DivisionID").Value
            If uCboDivisionManagers.Value <> iDivisionManagerID Then 'mrb 11/1/16
                If uCboDivisionManagers.Text <> "" Then
                    iDivisionManagerID = uCboDivisionManagers.ActiveRow.Cells("siid").Text
                End If
                bChangesMade = True
            End If
            If uCboProductionManagers.Value <> iProductionManagerID Then 'mrb 11/1/16
                If uCboProductionManagers.Text <> "" Then
                    iProductionManagerID = uCboProductionManagers.ActiveRow.Cells("siid").Text
                End If
                bChangesMade = True
            End If
            If ucboSalesManagers.Value <> iSalesManagerID Then 'mrb 11/1/16
                If ucboSalesManagers.Text <> "" Then
                    iSalesManagerID = ucboSalesManagers.ActiveRow.Cells("siid").Text
                End If
                bChangesMade = True
            End If
            'create procedure spDivisionUpdate
            '	@DivisionID int,
            '	@UpdatedBy char(10),
            '	@DivisionManagerID int, 
            '	@SalesManagerID int, 
            '   @ProductionManagerID int
            If bChangesMade Then '11/1/16 mrb
                If cdb.GetReturnValueFromSP("spDivisionUpdate", iDivisionID, gsUserID, iDivisionManagerID, iSalesManagerID, iProductionManagerID) = 0 Then
                    bSaved = True
                    bSaved = SaveSalesManagers()
                    If bSaved Then
                        SaveDivisionChanges = True
                    End If
                End If
            Else '11/1/16 mrb
                bSaved = SaveSalesManagers()
                If bSaved Then
                    SaveDivisionChanges = True
                End If
            End If
            If Not bSaved Then
                ShowError("Unknown Error in SaveDivisionchanges ", True, "BOSSAdmin", "Divisions: SaveDivisionChanges ")
            End If
        Catch
            ShowError("Error in saveDivisonChanges: " & Err.Description, False, "BOSSAdmin", "Divisions: SaveDivisionChanges ")
            SaveDivisionChanges = False
        Finally
            cdb = Nothing
        End Try
    End Function
    Private Function SaveSalesManagers() As Boolean
        Dim iSIID As Integer = 0
        Dim iDivisionid As Integer = 0
        Dim cdb As New DBCalls
        Dim bSaved As Boolean = False
        Dim bOK As Boolean = False
        Dim lRtn As Long = 0
        Dim dStartDate As Date = Nothing
        Dim dEndDate As Date = Nothing
        Dim iDivisionNSMID As Integer = 0
        Dim sNSM As String = ""
        SaveSalesManagers = True
        Try
            iDivisionid = grdDivisions.ActiveRow.Cells("DivisionID").Value
            'create procedure spDivisionNSMUpdate
            ' @DivisionNSMID int,
            ' @EndDate smalldatetime,
            ' @UpdatedBy char(10)
            'create procedure spDivisionNSMInsert
            ' @DivisionID int,
            ' @CreatedBy char(10),
            ' @SIID INT,
            ' @StartDate smalldatetime
            Cursor = Cursors.WaitCursor
            Dim oRow As UltraGridRow

            For Each oRow In grdNSM.Rows
                If oRow.DataChanged Then '11/1/16 mrb
                    If Not IsDBNull(grdNSM.ActiveRow.Cells("DivisionNSMID").Value) Then
                        iDivisionNSMID = grdNSM.ActiveRow.Cells("DivisionNSMID").Value
                    Else
                        iDivisionNSMID = 0
                    End If
                    dStartDate = grdNSM.ActiveRow.Cells("StartDate").Text
                    If grdNSM.ActiveRow.Cells("EndDate").Text <> "" Then
                        dEndDate = grdNSM.ActiveRow.Cells("EndDate").Text
                    Else
                        dEndDate = Nothing
                    End If
                    sNSM = grdNSM.ActiveRow.Cells("siid").Text
                    iSIID = grdNSM.ActiveRow.Cells("siid").Value
                    If iDivisionNSMID <> 0 And Not IsNothing(dEndDate) And IsDBNull(grdNSM.ActiveRow.Cells("EndDate").OriginalValue) Then
                        lRtn = cdb.GetReturnValueFromSP("spDivisionNSMUpdate", iDivisionNSMID, dEndDate, gsUserID)
                    Else
                        'new nsm for this division
                        lRtn = cdb.GetReturnValueFromSP("spDivisionNSMInsert", iDivisionid, gsUserID, iSIID, dStartDate)
                    End If
                    bOK = (lRtn = 0)
                    If Not bOK Then
                        ShowError("Unknown Error in savedivisionNSM " & sNSM, True, "BOSSAdmin", "Divisions: SaveNewDivision ")
                        SaveSalesManagers = False
                    Else
                        SaveSalesManagers = True
                    End If
                End If
            Next
        Catch
            ShowError("Error in savenewdivision: " & Err.Description, False, "BOSSAdmin", "Divisions: SaveNewDivision ")
            SaveSalesManagers = False
        Finally
            cdb = Nothing
            Cursor = Cursors.Default
        End Try
    End Function
    Private Sub tsBtnUndo_Click(sender As Object, e As System.EventArgs) Handles tsBtnUndo.Click
        EnableDisableToolStrip(False, "tsBtnUndo")
        LoadDivisions()
        bAddNew = False
    End Sub

    Private Sub grdDivisions_AfterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grdDivisions.AfterSelectChange
        If bAddNew Then
        Else
            uCboDivisionManagers.Value = grdDivisions.ActiveRow.Cells("DivisionManagerID").Value
            uCboProductionManagers.Value = grdDivisions.ActiveRow.Cells("ProductionManagerID").Value
            ucboSalesManagers.Value = grdDivisions.ActiveRow.Cells("SalesManagerID").Value
            LoadNSMGrid()
        End If
    End Sub
    Private Function LoadNSMGrid() As Boolean
        Dim ds2 As New DataSet
        Dim cDB As New DBCalls
        Dim iDivisionID As Integer
        Dim dsNSMs As New DataSet
        Try
            'select n.SIID, StartDate, EndDate, Inactive, FName, LName, rtrim(FName) + LName as NSMName
            iDivisionID = grdDivisions.ActiveRow.Cells("divisionid").Value
            grdNSM.DataSource = Nothing
            If cDB.GetRecordsFromSP(ds2, "spUsersDivisionNSMsGet", iDivisionID) Then

            End If
            grdNSM.DataSource = ds2
            grdNSM.DataBind()
            'grdNSM.Height = 200
            ' grdNSM.Width = 375
            If cDB.GetRecordsFromSP(dsNSMs, "spUsersByPositionGet", 5) Then
                Dim layout As UltraGridLayout = grdNSM.DisplayLayout
                Dim bands As BandsCollection = layout.Bands
                ' Get the first band, which is the  top-most band in case you had multple bands.
                Dim band As UltraGridBand = bands(0)
                ' Columns property off UltraGridBand returns the collection of columns associated with the band.
                Dim oColumns As ColumnsCollection = band.Columns
                Dim oColumnSIID As UltraGridColumn = oColumns("SIID")
                'create dropdown for Owner
                Me.ddNSMs.SetDataBinding(dsNSMs, Nothing)
                Me.ddNSMs.ValueMember = "SIID"
                Me.ddNSMs.DisplayMember = "UserName"
                grdNSM.DisplayLayout.Bands(0).Columns("siid").ValueList = ddNSMs
                ddNSMs.DisplayLayout.Bands(0).Columns("SIID").Hidden = True
                ddNSMs.DisplayLayout.Bands(0).Columns("lname").Hidden = True
                ddNSMs.DisplayLayout.Bands(0).Columns("fname").Hidden = True
                ddNSMs.DisplayLayout.Bands(0).ColumnFilters("Inactive").ResetKey() '11/1/16 mrb
                ddNSMs.DisplayLayout.Bands(0).Columns("Inactive").Hidden = True

                Dim ugc As UltraGridColumn
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("divisionnsmid")
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("siid")
                ' do not allow edit until in edit mode
                ugc.CellActivation = Activation.Disabled

                'ugc.Hidden = True
                ugc.Width = 200
                ugc.Header.Caption = "NSM"
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("fname")
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("lname")
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("nsmname")
                ugc.Header.Caption = "NSM Name"
                ugc.Width = 250 '150 11/1/16 mrb
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("startdate")
                ugc.Header.Caption = "Start Date"
                ' do not allow edit until in edit mode
                ugc.CellActivation = Activation.Disabled

                ugc = grdNSM.DisplayLayout.Bands(0).Columns("enddate")
                ugc.Header.Caption = "End Date"
                ' do not allow edit until in edit mode
                ugc.CellActivation = Activation.Disabled

                ugc = grdNSM.DisplayLayout.Bands(0).Columns("inactive")

                ' do not allow edit until in edit mode
                ugc.CellActivation = Activation.Disabled
                LoadNSMGrid = True
                'this makes the add new button say nsm
                grdNSM.DisplayLayout.Bands(0).Header.Caption = "NSM"
                If grdNSM.Rows.Count > 0 Then
                    grdNSM.Rows(0).Activate()
                    grdNSM.ActiveRow.Selected = True
                    '11/1/16 mrb add filters
                    grdNSM.Text = "NSMs filtered by Active Only - change filters on End Date and Inactive to see ALL"
                    grdNSM.DisplayLayout.Bands(0).ColumnFilters("Inactive").FilterConditions.Add(FilterComparisionOperator.Equals, False)
                    grdNSM.DisplayLayout.Bands(0).ColumnFilters("EndDate").FilterConditions.Add(FilterComparisionOperator.Equals, DBNull.Value)

                End If
            Else
                LoadNSMGrid = False
                ShowError("Error in LoadNSMGrid: " & Err.Description, False, "BOSSAdmin", "Divisions: LoadNSMGrid ")
            End If
        Catch
            LoadNSMGrid = False
            ShowError("Error in LoadNSMGrid: " & Err.Description, False, "BOSSAdmin", "Divisions: LoadNSMGrid ")
        Finally
            cDB = Nothing
        End Try

    End Function

    Private Sub grdNSM_BeforeCellActivate(sender As Object, e As CancelableCellEventArgs) Handles grdNSM.BeforeCellActivate
        If e.Cell.Column.Key = "SIID" Then '11/1/16 MRB
            ddNSMs.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True
            ddNSMs.DisplayLayout.Bands(0).ColumnFilters("inactive").FilterConditions.Add(FilterComparisionOperator.Equals, "False")
        End If
    End Sub
    Private Sub grdNSM_BeforeRowInsert(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowInsertEventArgs) Handles grdNSM.BeforeRowInsert
        'add new button is clicked
        'this makes sure that the user cannot change the nsm on the existing rows
        Dim ugc As UltraGridColumn
        'enable edit on these two columns
        ugc = grdNSM.DisplayLayout.Bands(0).Columns("startdate")
        ugc.CellActivation = Activation.AllowEdit
        ugc = grdNSM.DisplayLayout.Bands(0).Columns("siid")
        ugc.CellActivation = Activation.AllowEdit
        ugc = grdNSM.DisplayLayout.Bands(0).Columns("enddate")
        ugc.CellActivation = Activation.Disabled

        'grdNSM.ActiveRow.Cells("siid").Activation = Activation.AllowEdit
        grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True

    End Sub

    Private Sub grdNSM_afterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles grdNSM.BeforeSelectChange
        'add mode
        If grdNSM.ActiveRow.Cells("siid").Text = "" Then
            grdNSM.ActiveRow.Cells("siid").Activation = Activation.AllowEdit

        Else
            grdNSM.ActiveRow.Cells("siid").Activation = Activation.Disabled
        End If
        If grdNSM.ActiveRow.Cells("startdate").Text = "" Then
            grdNSM.ActiveRow.Cells("startdate").Activation = Activation.AllowEdit
        Else
            grdNSM.ActiveRow.Cells("startdate").Activation = Activation.Disabled
        End If
        'edit mode
        If grdNSM.ActiveRow.Cells("enddate").Text = "" And grdNSM.ActiveRow.Cells("startdate").Text <> "" Then
            grdNSM.ActiveRow.Cells("enddate").Activation = Activation.AllowEdit
            grdNSM.DisplayLayout.Bands(0).Columns("enddate").CellActivation = Activation.AllowEdit
        Else
            grdNSM.ActiveRow.Cells("enddate").Activation = Activation.Disabled
        End If

    End Sub

    Private Sub grdNSM_InitializeLayout(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles grdNSM.InitializeLayout

    End Sub

    Private Sub ucboSalesManagers_AfterCloseUp(sender As Object, e As EventArgs) Handles ucboSalesManagers.AfterCloseUp
        ucboSalesManagers.DisplayLayout.Bands(0).ColumnFilters("inactive").ResetKey()
    End Sub

    Private Sub ucboSalesManagers_BeforeDropDown(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ucboSalesManagers.BeforeDropDown
        ucboSalesManagers.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True
        ucboSalesManagers.DisplayLayout.Bands(0).ColumnFilters("inactive").FilterConditions.Add(FilterComparisionOperator.Equals, "False")

    End Sub

    Private Sub uCboDivisionManagers_AfterCloseUp(sender As Object, e As EventArgs) Handles uCboDivisionManagers.AfterCloseUp
        uCboDivisionManagers.DisplayLayout.Bands(0).ColumnFilters("inactive").ResetKey()
    End Sub

    Private Sub uCboDivisionManagers_BeforeDropDown(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles uCboDivisionManagers.BeforeDropDown
        uCboDivisionManagers.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True
        uCboDivisionManagers.DisplayLayout.Bands(0).ColumnFilters("inactive").FilterConditions.Add(FilterComparisionOperator.Equals, "False")
    End Sub

    Private Sub uCboProductionManagers_AfterCloseUp(sender As Object, e As EventArgs) Handles uCboProductionManagers.AfterCloseUp
        uCboProductionManagers.DisplayLayout.Bands(0).ColumnFilters("inactive").ResetKey()
    End Sub

    Private Sub uCboProductionManagers_BeforeDropDown(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles uCboProductionManagers.BeforeDropDown
        uCboProductionManagers.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True
        uCboProductionManagers.DisplayLayout.Bands(0).ColumnFilters("inactive").FilterConditions.Add(FilterComparisionOperator.Equals, "False")
    End Sub
End Class