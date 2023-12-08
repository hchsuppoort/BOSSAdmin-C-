Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.Misc
Imports System.Windows.Forms
Public Class ProjectMaintenance
    Dim ddNSMs As New UltraDropDown
    Dim ddBldr As New UltraDropDown
    Dim bAddNew As Boolean = False
    Private Function LoadNSMGrid() As Boolean
        Dim ds2 As New DataSet
        Dim cDB As New DBCalls
        Dim iProjectID As Integer
        Dim dsNSMs As New DataSet
        Try
            'select n.SIID, StartDate, EndDate, Inactive, FName, LName, rtrim(FName) + LName as NSMName
            iProjectID = ucboProject.ActiveRow.Cells("id").Value
            grdNSM.DataSource = Nothing
            If cDB.GetRecordsFromSP(ds2, "spUsersProjectNSMsGet", iProjectID) Then
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
                'If grdNSM.Rows.Count > 0 Then
                'End If

                grdNSM.DisplayLayout.Bands(0).Columns("siid").ValueList = ddNSMs
                grdNSM.DisplayLayout.Bands(0).Columns("siid").Style = UltraWinGrid.ColumnStyle.DropDown
                grdNSM.DisplayLayout.Bands(0).Columns("siid").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
                ddNSMs.DisplayLayout.Bands(0).Columns("SIID").Hidden = True
                ddNSMs.DisplayLayout.Bands(0).Columns("lname").Hidden = True
                ddNSMs.DisplayLayout.Bands(0).Columns("fname").Hidden = True

                Dim ugc As UltraGridColumn
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("projectnsmid")
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("siid")
                ' do not allow edit until in edit mode
                'ugc.CellActivation = Activation.Disabled

                'ugc.Hidden = True
                ugc.Width = 200
                ugc.Header.Caption = "NSM"
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("fname")
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("lname")
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("nsmname")
                ugc.Header.Caption = "NSM Name"
                ugc.Width = 150
                ugc.Hidden = True
                ugc = grdNSM.DisplayLayout.Bands(0).Columns("startdate")
                ugc.Header.Caption = "Start Date"
                ' do not allow edit until in edit mode
                'ugc.CellActivation = Activation.Disabled

                ugc = grdNSM.DisplayLayout.Bands(0).Columns("enddate")
                ugc.Header.Caption = "End Date"
                ' do not allow edit until in edit mode
                ugc.CellActivation = Activation.Disabled

                ugc = grdNSM.DisplayLayout.Bands(0).Columns("inactive")

                ' do not allow edit until in edit mode
                'ugc.CellActivation = Activation.Disabled
                LoadNSMGrid = True
                'this makes the add new button say nsm
                grdNSM.DisplayLayout.Bands(0).Header.Caption = "NSM"
                If grdNSM.Rows.Count > 0 Then
                    grdNSM.Rows(0).Activate()
                    grdNSM.ActiveRow.Selected = True
                End If
            Else
                LoadNSMGrid = False
                ShowError("Error in LoadNSMGrid: " & Err.Description, False, "BOSSAdmin", "Projects: LoadNSMGrid ")
            End If

        Catch
            LoadNSMGrid = False
            ShowError("Error in LoadNSMGrid: " & Err.Description, False, "BOSSAdmin", "Projects: LoadNSMGrid ")
        Finally
            cDB = Nothing
        End Try

    End Function
    Private Function LoadProjects() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim sNotifyCriteria As String = ""
        Try

            ucboProject.DataSource = Nothing
            ucboProject.DisplayLayout.NewColumnLoadStyle = NewColumnLoadStyle.Hide

            If dbCalls.GetRecordsFromSP(ds, "spProjectListGet") Then
                ucboProject.DataSource = ds
                ucboProject.DataBind()
            End If '
            ' Columns property off UltraGridBand returns the collection of columns associated with the band.
            Dim ugc As UltraGridColumn
            Dim oBand As UltraGridBand
            oBand = ucboProject.DisplayLayout.Bands(0)
            'set all columns hidden in designtime, set those you want to see here
            With oBand
                ugc = .Columns("ProjectName")
                ugc.Width = 200
                ugc.Hidden = False

                ugc = .Columns("ProjectID")
                ugc.Hidden = False
            End With

            ' select first row
            'ucboProject.Rows(0).Activate()
            'ucboProject.PerformAction(UltraComboAction.FirstRow)
            'ucboProject.ActiveRow.Selected = True
            'ucboProject.PerformAction(UltraComboAction.CloseDropdown)
            LoadProjects = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "ProjectMaintenance: loadprojects ")
            LoadProjects = False
        End Try
    End Function

    Private Sub EnableDisableToolStrip(bEdit As Boolean, sCalledBy As String)
        Dim bCanEdit As Boolean
        Try
            bCanEdit = HasEditSecurity("VPOReasons", "Menu") And Not bEdit
            tsToolStrip.Items("tsBtnAdd").Enabled = bCanEdit
            tsToolStrip.Items("tsBtnEdit").Enabled = bCanEdit
            tsToolStrip.Items("tsBtnUndo").Enabled = bEdit
            tsToolStrip.Items("tsBtnSave").Enabled = bEdit
            tsToolStrip.Items("tsBtnPrint").Enabled = Not bEdit
            ' grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
            If Not bCanEdit Then
                UltraGroupBoxReadOnly(ugbBasicInfo, False)
                UltraGroupBoxReadOnly(ugbUtilities, False)
                ucboProject.Enabled = False
                UltraGroupBoxReadOnly(ugbMoreInfo, False)
                If sCalledBy = "tsBtnAdd" Then
                    grdNSM.DisplayLayout.AddNewBox.Hidden = True
                    'grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                    grdBuilders.DisplayLayout.AddNewBox.Hidden = True
                    grdPlanPrices.DisplayLayout.AddNewBox.Hidden = True
                    ucboProject.Visible = False
                    txtProjectID.Visible = True
                Else
                    grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    grdNSM.DisplayLayout.AddNewBox.Hidden = False
                    grdNSM.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
                    grdBuilders.DisplayLayout.AddNewBox.Hidden = False
                    grdBuilders.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    grdBuilders.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
                    grdPlanPrices.DisplayLayout.AddNewBox.Hidden = False
                    grdPlanPrices.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    grdPlanPrices.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
                    ucboProject.Visible = True
                    txtProjectID.Visible = False
                End If
            Else
                grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                grdBuilders.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                grdPlanPrices.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                'grdDivisions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                'grdDivisions.DisplayLayout.AddNewBox.Hidden = True
                'grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                'grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                grdNSM.DisplayLayout.AddNewBox.Hidden = True
                'grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                grdBuilders.DisplayLayout.AddNewBox.Hidden = True
                grdPlanPrices.DisplayLayout.AddNewBox.Hidden = True
                UltraGroupBoxReadOnly(ugbBasicInfo, True)
                'ugbUtilities.Enabled = False
                UltraGroupBoxReadOnly(ugbUtilities, True)
                UltraGroupBoxReadOnly(ugbMoreInfo, True)
                ucboProject.Enabled = True
            End If
            'uCboDivisionManagers.ReadOnly = bCanEdit
            'uCboProductionManagers.ReadOnly = bCanEdit
            'ucboSalesManagers.ReadOnly = bCanEdit
            'grdNSM.DisplayLayout.AddNewBox.Hidden = bCanEdit

            'grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        Catch
            ShowError("Error in EnableDisableToolStrip" & Err.Description, False, "BOSSAdmin", "ProjectMaintenance: EnableDisableToolStrip ")
        End Try

    End Sub

    Private Sub ProjectMaintenance_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim bGoOn As Boolean = False
        Try
            bGoOn = LoadProjects()
            If bGoOn Then
                bGoOn = LoadTaxPermitDistricts()
            End If
            If bGoOn Then
                bGoOn = LoadTitleInsCompany()
            End If
            'EnableDisableToolStrip(False, "ProjectMaintenance_Load")
        Catch ex As Exception
            ShowError(Err.Description, False, "BOSSAdmin", "ProjectMaintenance: ProjectMaintenance_Load")
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End Try

    End Sub

    Private Sub ucboProject_AfterCloseUp(sender As Object, e As System.EventArgs) Handles ucboProject.AfterCloseUp
        LoadProjectData()
    End Sub
    Private Sub LoadProjectData()
        Try
            LoadNSMGrid()
            LoadBuilders()
            'find correct tax permit district
            ucboTaxPermit.Value = ucboProject.ActiveRow.Cells("TaxPermitID").Value
            'find correct title insurance company
            ucboTitleIns.Value = ucboProject.ActiveRow.Cells("TitleInsCompanyId").Value
            Dim oRow As Infragistics.Win.UltraWinGrid.UltraGridRow
            oRow = ucboProject.ActiveRow
            With oRow
                Me.txtCable.Text = .Cells("Cable").Text
                Me.txtDrivingDirections.Text = .Cells("DrivingDirections").Text
                Me.txtModelPhone.Text = .Cells("ModelPhoneNumber").Text
                Me.txtPower.Text = .Cells("Power").Text
                Me.txtProjectName.Text = .Cells("ProjectName").Text
                Me.txtSetbacksBuffers.Text = .Cells("SetbacksBuffers").Text
                Me.txtSewerSeptic.Text = .Cells("SewerOrSeptic").Text
                Me.uchkComplete.Checked = .Cells("Inactive").Value
                Me.uchkCostPrice.Checked = .Cells("StandardPlan").Value
                Me.uchkHCHOwned.Checked = .Cells("HCHOwned").Value
                Me.uchkReadyForReleases.Checked = .Cells("ReadyForReleases").Value
                txtLotCosts.Text = FormatCurrency(.Cells("LotCosts").Text)
                txtWater.Text = .Cells("Water").Text
                txtTelephone.Text = .Cells("Telephone").Text
            End With
            EnableDisableToolStrip(False, "LoadProjectData")
        Catch
            ShowError("Error in LoadProjectData" & Err.Description, False, "BOSSAdmin", "ProjectMaintenance: LoadProjectData ")
        Finally
        End Try

    End Sub
    Private Function LoadTaxPermitDistricts() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls

        Try

            ucboTaxPermit.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spGetTaxPermitDistrictNames") Then
                ucboTaxPermit.DataSource = ds
                ucboTaxPermit.DataBind()

                ' Columns property off UltraGridBand returns the collection of columns associated with the band.

                'Dim ugc As UltraGridColumn

                'ugc = ucboTaxPermit.DisplayLayout.Bands(0).Columns("DivisionID")
                'ugc.Hidden = True

            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            ' select first row
            'ucboTaxPermit.Rows(0).Activate()
            'ucboTaxPermit.ActiveRow.Selected = True

            LoadTaxPermitDistricts = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "ProjectMaintenance: loadTaxPermitDistricts ")
            LoadTaxPermitDistricts = False
        End Try
    End Function
    Private Function LoadTitleInsCompany() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls

        Try

            ucboTitleIns.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spTitleInsuranceCompanyGet", 1) Then
                ucboTitleIns.DataSource = ds
                ucboTitleIns.DataBind()

                ' Columns property off UltraGridBand returns the collection of columns associated with the band.

                'Dim ugc As UltraGridColumn

                'ugc = ucbotitleins.DisplayLayout.Bands(0).Columns("DivisionID")
                'ugc.Hidden = True

                'ugc = ucbotitleins.DisplayLayout.Bands(0).Columns("Division")
                'ugc.Width = 150


                'ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Position")
                'ugc.Width = 120

            End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
            ' select first row
            'ucboTitleIns.Rows(0).Activate()
            'ucboTitleIns.ActiveRow.Selected = True

            LoadTitleInsCompany = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "ProjectMaintenance: LoadTitleInsCompany ")
            LoadTitleInsCompany = False
        End Try
    End Function
    Private Function LoadBuilders() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsBldrs As New DataSet
        Dim iProjectID As String = ""

        Try
            iProjectID = ucboProject.ActiveRow.Cells("ID").Text
            grdBuilders.DataSource = Nothing

            If dbCalls.GetRecordsFromSP(ds, "spProjectBuildersGet", iProjectID) Then
                grdBuilders.DataSource = ds
                grdBuilders.DataBind()
                grdBuilders.DisplayLayout.Bands(0).Columns("username").Hidden = True
                grdBuilders.DisplayLayout.Bands(0).Columns("siid").Width = 150
                grdBuilders.DisplayLayout.Bands(0).Columns("siid").Header.Caption = "Builder"
                grdBuilders.DisplayLayout.Bands(0).Columns("lname").Hidden = True
                grdBuilders.DisplayLayout.Bands(0).Columns("fname").Hidden = True
                grdBuilders.DisplayLayout.Bands(0).Columns("ProjBldrID").Hidden = True
            End If
            If dbCalls.GetRecordsFromSP(dsBldrs, "spUsersByPositionGet", 1) Then
                'Dim layout As UltraGridLayout = grdBuilders.DisplayLayout
                'Dim bands As BandsCollection = layout.Bands
                '' Get the first band, which is the  top-most band in case you had multple bands.
                'Dim band As UltraGridBand = bands(0)
                '' Columns property off UltraGridBand returns the collection of columns associated with the band.
                'Dim oColumns As ColumnsCollection = band.Columns
                'Dim oColumnSIID As UltraGridColumn = oColumns("SIID")
                'create dropdown for Owner
                Me.ddBldr.SetDataBinding(dsBldrs, Nothing)
                Me.ddBldr.ValueMember = "SIID"
                Me.ddBldr.DisplayMember = "UserName"
                ddBldr.DisplayLayout.Bands(0).Columns("SIID").Hidden = True
                ddBldr.DisplayLayout.Bands(0).Columns("lname").Hidden = True
                ddBldr.DisplayLayout.Bands(0).Columns("fname").Hidden = True
                If grdBuilders.Rows.Count > 0 Then
                    grdBuilders.DisplayLayout.Bands(0).Columns("siid").ValueList = ddBldr
                End If
            End If
            LoadBuilders = True
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "ProjectMaintenance: LoadBuilders ")
            LoadBuilders = False
        End Try
    End Function

    Private Sub tsBtnSave_Click(sender As Object, e As System.EventArgs) Handles tsBtnSave.Click
        'when saved
        If SaveSalesManagers() Then
            LoadProjects()
        End If
    End Sub

    Private Sub tsBtnEdit_Click(sender As Object, e As System.EventArgs) Handles tsBtnEdit.Click
        EnableDisableToolStrip(True, "tsBtnEdit_Click")
    End Sub

    Private Sub tsBtnUndo_Click(sender As Object, e As System.EventArgs) Handles tsBtnUndo.Click
        LoadProjectData()
        ' EnableDisableToolStrip(False, "tsBtnUndo_Click") called in load project data
    End Sub

    Private Sub grdNSM_afterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles grdNSM.BeforeSelectChange
        If grdNSM.Rows.Count > 0 Then
            If grdNSM.ActiveRow.Cells("siid").Text = "" Then
                grdNSM.ActiveRow.Cells("siid").Activation = Activation.AllowEdit
                grdNSM.ActiveRow.Cells("startdate").Activation = Activation.AllowEdit
            Else
                grdNSM.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.True
                grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                grdNSM.ActiveRow.Cells("siid").Activation = Activation.Disabled
                grdNSM.ActiveRow.Cells("startdate").Activation = Activation.Disabled
                grdNSM.ActiveRow.Cells("enddate").Activation = Activation.AllowEdit
            End If
        End If
    End Sub
    Private Sub grdBuilders_afterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventArgs) Handles grdNSM.BeforeSelectChange
        If grdBuilders.Rows.Count > 0 Then
            If grdBuilders.ActiveRow.Cells("siid").Text = "" Then
                grdBuilders.ActiveRow.Cells("siid").Activation = Activation.AllowEdit
            Else
                grdBuilders.ActiveRow.Cells("siid").Activation = Activation.Disabled
            End If
        End If
    End Sub
    Private Function SaveSalesManagers() As Boolean
        Dim iSIID As Integer = 0
        Dim iProjectid As Integer = 0
        Dim cdb As New DBCalls
        Dim bSaved As Boolean = False
        Dim bOK As Boolean = False
        Dim lRtn As Long = 0
        Dim dStartDate As Date = Nothing
        Dim dEndDate As Date = Nothing
        Dim iProjectNSMID As Integer = 0
        Dim sNSM As String = ""
        SaveSalesManagers = False
        Try
            iProjectid = ucboProject.ActiveRow.Cells("ID").Value
            'create procedure spProjectNSMUpdate
            '@ProjectNSMID int,
            '@EndDate smalldatetime,
            '@UpdatedBy char(10)
            'create procedure spProjectNSMInsert
            ' @ProjectID int,
            ' @CreatedBy char(10),
            ' @SIID INT,
            ' @StartDate smalldatetime
            Cursor = Cursors.WaitCursor
            Dim oRow As UltraGridRow

            For Each oRow In grdNSM.Rows
                If grdNSM.Rows.Count > 1 Then
                    If Not IsDBNull(grdNSM.ActiveRow.Cells("ProjectNSMID").Value) Then
                        iProjectNSMID = grdNSM.ActiveRow.Cells("ProjectNSMID").Value
                    End If
                Else
                    iProjectNSMID = 0
                End If
                dStartDate = grdNSM.ActiveRow.Cells("StartDate").Text
                If grdNSM.ActiveRow.Cells("EndDate").Text <> "" Then
                    dEndDate = grdNSM.ActiveRow.Cells("EndDate").Text
                Else
                    dEndDate = Nothing
                End If
                sNSM = grdNSM.ActiveRow.Cells("siid").Text
                iSIID = grdNSM.ActiveRow.Cells("siid").Value
                If iProjectNSMID <> 0 And Not IsNothing(dEndDate) And IsDBNull(grdNSM.ActiveRow.Cells("EndDate").OriginalValue) Then
                    lRtn = cdb.GetReturnValueFromSP("spProjectNSMUpdate", iProjectNSMID, dEndDate, gsUserID)
                Else
                    'new nsm for this Project
                    lRtn = cdb.GetReturnValueFromSP("spProjectNSMInsert", iProjectid, gsUserID, iSIID, dStartDate)
                End If
                bOK = (lRtn = 0)
                If Not bOK Then
                    ShowError("Unknown Error in saveProjectNSM " & sNSM, True, "BOSSAdmin", "Projects: SaveNewProject ")
                Else
                    SaveSalesManagers = True
                End If
            Next
        Catch
            ShowError("Error in savenewProject: " & Err.Description, False, "BOSSAdmin", "Projects: SaveNewProject ")
            SaveSalesManagers = False
        Finally
            cdb = Nothing
            Cursor = Cursors.Default
        End Try
    End Function
    Private Function SaveBuilders() As Boolean
        Dim iSIID As Integer = 0
        Dim iProjectid As Integer = 0
        Dim cdb As New DBCalls
        Dim bSaved As Boolean = False
        Dim bOK As Boolean = False
        Dim lRtn As Long = 0
        Dim ProjBldrID As Integer = 0
        Dim sBuilder As String = ""
        SaveBuilders = False
        Try
            iProjectid = ucboProject.ActiveRow.Cells("ID").Value
            'create PROCEDURE [dbo].[spProjectBuilderAdd]
            '@ProjectID Integer,
            '@BuilderID integer,
            '@CreatedBy char(10)
            Cursor = Cursors.WaitCursor
            Dim oRow As UltraGridRow

            For Each oRow In grdNSM.Rows
                sBuilder = grdNSM.ActiveRow.Cells("siid").Text
                iSIID = grdNSM.ActiveRow.Cells("siid").Value

                lRtn = cdb.GetReturnValueFromSP("spProjectBuilderAdd", iProjectid, iSIID, gsUserID)
                bOK = (lRtn = 0)
                If Not bOK Then
                    ShowError("Unknown Error in saveBuilders " & sBuilder, True, "BOSSAdmin", "Projects: SaveBuilders ")
                Else
                    SaveBuilders = True
                End If
            Next
        Catch
            ShowError(Err.Description, False, "BOSSAdmin", "Projects: SaveBuilder ")
            SaveBuilders = False
        Finally
            cdb = Nothing
            Cursor = Cursors.Default
        End Try
    End Function

    Private Sub grdBuilders_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grdBuilders.BeforeRowsDeleted
        DeleteBuilder()
    End Sub
    Private Sub DeleteBuilder()
        Dim cDB As New DBCalls
        Dim iProjBldrID As Integer = 0
        Dim iRtn As Integer = 0

        Try
            iProjBldrID = grdBuilders.ActiveRow.Cells("ProjBldId").Text
            If iProjBldrID <> "" Then
                iRtn = cDB.GetReturnValueFromSP("spProjectBuilderDelete", iProjBldrID)
                If iRtn = 0 Then
                    MsgBox("Builder Deleted", vbInformation, "DeleteBuilder")
                Else
                    ShowError(Err.Description, False, "BossAdmin", "ProjectMaintenance.DeleteBuilder")
                End If
            End If
        Catch ex As Exception
            ShowError(Err.Description, False, "BOSSAdmin", "Projects: DeleteBuilder ")
        Finally
            cDB = Nothing
        End Try
    End Sub
End Class