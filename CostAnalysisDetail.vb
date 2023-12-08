Imports System.Data.SqlClient
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports System.Data
Imports System
Imports Infragistics.Shared
Imports System.IO
Imports Infragistics.Win.UltraWinToolbars
Public Class CostAnalysisDetail
    Friend msDataSet As New DataSet
    Public miAnalysisID As Int64
    Friend mbAddNew As Boolean
    Friend mlPID As Long
    Private mParent As CostAnalysisSearch
    Private msProcessLog As String = ""
    Private Sub CostAnalysisDetail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        gsCostAnalysisData = Nothing
    End Sub
    Public Sub New(frm1 As CostAnalysisSearch)
        InitializeComponent()
        mParent = frm1
    End Sub


    Private Sub CostAnalysisDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GetDataDate()
            'TODO: This line of code loads data into the 'HCHDataQAAlphaCodes.spGetAlphaCodes' table. You can move, or remove it, as needed.
            If HCHDataQAAlphaCodes.Tables(0).Rows.Count = 0 Then
                Me.SpGetAlphaCodesTableAdapter.Connection.ConnectionString = gsConnectionString
                Me.SpGetAlphaCodesTableAdapter.Fill(Me.HCHDataQAAlphaCodes.spGetAlphaCodes)
            End If
            'TODO: This line of code loads data into the 'HCHDataQADistricts.spGetTaxDistrictList' table. You can move, or remove it, as needed.
            If HCHDataQADistricts.Tables(0).Rows.Count = 0 Then
                Me.SpGetTaxDistrictListTableAdapter.Connection.ConnectionString = gsConnectionString
                Me.SpGetTaxDistrictListTableAdapter.Fill(Me.HCHDataQADistricts.spGetTaxDistrictList)
            End If
            'TODO: This line of code loads data into the 'HCHDataQAProjectList.spGetOpenProjects' table. You can move, or remove it, as needed.
            If HCHDataQAProjectList.Tables(0).Rows.Count = 0 Then
                Me.SpGetOpenProjectsTableAdapter.Connection.ConnectionString = gsConnectionString
                Me.SpGetOpenProjectsTableAdapter.Fill(Me.HCHDataQAProjectList.spGetOpenProjects)
            Else
            End If

            'LoadDetailGrid() moved into if not mbaddnew mrb 12/21/14
            'SpGetAnalysesHeaderTableAdapter.Fill(HCHDataQADataSet.Tables(0), miAnalysisID) move down 12/21/14
            mbAddNew = miAnalysisID = 0 Or miAnalysisID = Nothing

            If Not mbAddNew Then
                LoadDetailGrid()
                SpGetAnalysesHeaderTableAdapter.Connection.ConnectionString = gsConnectionString
                SpGetAnalysesHeaderTableAdapter.Fill(HCHDataQADataSet.Tables(0), miAnalysisID)

                With HCHDataQADataSet.Tables(0).Rows(0)

                    If (ucProjectStandard.Text = ucProjectOptions.Text) And (ucProjectOptions.Text = ucProjectsPlans.Text) And (ucProjectsPlans.Text = ucProjectsCosts.Text) Then
                        chkUseInfoFromStandardProject.CheckState = CheckState.Checked
                    Else
                        chkUseInfoFromStandardProject.CheckState = CheckState.Unchecked
                    End If
                End With

                EnableDisable(False, mbAddNew)
                EnableDisableProjects(False)
            Else
                ucProjectStandard.Text = ""
                ucProjectStandard.Value = vbNull
                ucProjectOptions.Text = ""
                ucProjectOptions.Value = vbNull
                ucProjectsCosts.Text = ""
                ucProjectsCosts.Value = vbNull
                ucProjectsPlans.Text = ""
                ucProjectsPlans.Value = vbNull
                ucAlphaCodes.Text = ""
                ucAlphaCodes.Value = vbNull
                ucAlphaCodes.SelectedRow = Nothing
                'ucDistricts.Text = ""
                ucDistricts.Value = vbNull
                ucDistricts.SelectedRow = Nothing
                ckPlansSelected.CheckState = CheckState.Unchecked
                EnableDisable(True, mbAddNew)
                EnableDisableProjects(True)
            End If
            GetCostPlanPath()
            'The following lines of code create and set up the Popup menu. 

            ugDetails.ContextMenuStrip = ContextMenuStrip1
        Catch ex As Exception
            MsgBox("Error in Cost Analysis Detail Load: " & ex.Message, MsgBoxStyle.Critical, "CostAnalysisDetail_Load")
        End Try
    End Sub
    Private Sub LoadDetailGrid()
        Try
            SpGetAnalysisTableAdapter.Connection.ConnectionString = gsConnectionString
            SpGetAnalysisTableAdapter.Fill(HCHDataAnalysisDetail.Tables(0), miAnalysisID)
            ugDetails.DataBind()
            ugDetails.ActiveRow = Nothing
            ugDetails.Selected.Rows.Clear()
        Catch ex As Exception
            MsgBox("Error in LoadDetailGrid: " & ex.Message, MsgBoxStyle.Critical, "LoadDetailGrid")
        End Try
    End Sub
    Private Sub EnableDisable(ByVal bEdit As Boolean, ByVal bAddNew As Boolean)
        Try
            pnlFields.Enabled = bEdit

            'tool strip
            tsBtnEdit.Enabled = (bEdit = False And bAddNew = False)
            tsBtnPrint.Enabled = bEdit = False
            tsBtnSave.Enabled = bEdit And Not bAddNew
            tsBtnPrintRpt2.Enabled = bEdit = False
            tsBtnUndo.Enabled = bEdit
            tsBtnRecalculateGrid.Enabled = bEdit
            'project select
            chkDoNotUse.Enabled = bEdit
            ckPlansSelected.Enabled = False
            ucAlphaCodes.Enabled = bEdit And bAddNew
            ucDistricts.Enabled = bEdit And bAddNew
            btnSelectPlans.Enabled = bEdit And bAddNew
            gpBoxStandardAnalysis.Enabled = bEdit And bAddNew
            gpCustomAnalysis.Enabled = bEdit And bAddNew
            uteAnalysisName.ReadOnly = bEdit = False
            uteNewMargin.ReadOnly = bEdit = False
            uteNotes.ReadOnly = bEdit = False
            utePeriod.ReadOnly = bEdit = False
            uteProjectID.ReadOnly = bEdit = False And bAddNew
            uteProjectName.ReadOnly = bEdit = False
            uteSoftCosts.ReadOnly = bEdit = False
            tsBtnRecalculateGrid.Enabled = bEdit
            With ugDetails.DisplayLayout.Bands(0)
                If bEdit Then
                    .Override.AllowUpdate = DefaultableBoolean.True
                    .Columns("AnalysisPrice").CellActivation = Activation.AllowEdit
                Else
                    .Override.AllowUpdate = DefaultableBoolean.False
                    .Columns("AnalysisPrice").CellActivation = Activation.NoEdit
                End If
            End With
            btnSelectPlans.Enabled = bEdit And bAddNew And ucProjectsPlans.Text <> ""
        Catch ex As Exception
            MsgBox("Error in Enable/Disable: " & ex.Message, MsgBoxStyle.Critical, "EnableDisable")

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        CostAnalysisPlanChooser.msPlanProjectID = ucProjectsPlans.Text
        CostAnalysisPlanChooser.ShowDialog()
        ckPlansSelected.Checked = Not gsCostAnalysisData Is Nothing
    End Sub

    Private Sub ucProjectStandard_RowSelected(sender As Object, e As Infragistics.Win.UltraWinGrid.RowSelectedEventArgs) Handles ucProjectStandard.RowSelected
        Try
            If Not Nothing Is e.Row Then
                ChangeProjectDropdowns()
            End If
        Catch ex As Exception
            MsgBox("Error in Row Selected: " & ex.Message, MsgBoxStyle.Critical, "ucProjectStandard_RowSelected")
        End Try
    End Sub
    Private Sub EnableDisableProjects(ByVal bEnable As Boolean)
        ucProjectOptions.ReadOnly = Not bEnable
        ucProjectsPlans.ReadOnly = Not bEnable
        ucProjectsCosts.ReadOnly = Not bEnable

    End Sub
    Private Sub tsBtnEdit_Click(sender As Object, e As EventArgs) Handles tsBtnEdit.Click
        EnableDisable(True, mbAddNew)
    End Sub
    Private Sub ChangeProjectDropdowns()
        If mbAddNew Then
            If chkUseInfoFromStandardProject.CheckState = CheckState.Checked Then
                ucProjectOptions.Value = ucProjectStandard.Value
                ucProjectsPlans.Value = ucProjectStandard.Value
                ucProjectsCosts.Value = ucProjectStandard.Value
                ucDistricts.Value = ucProjectStandard.SelectedRow.Cells("TaxPermitID").Value
                EnableDisableProjects(False)
            Else
                EnableDisableProjects(True)
            End If

        End If
    End Sub

    Private Sub tsBtnSave_Click(sender As Object, e As EventArgs) Handles tsBtnSave.Click
        Me.Enabled = False
        mdiMain.UseWaitCursor = True
        If (ucProjectStandard.Text <> "" And mbAddNew) Or Not mbAddNew Then
            If ValidData() Then
                If SaveRecord() Then
                    mbAddNew = False
                    EnableDisable(False, mbAddNew)
                End If
            End If
        Else
            MsgBox("You must select a Copy Project to complete the analysis.", vbInformation, "ButtonClick_Save")
        End If
        mdiMain.UseWaitCursor = False
        Me.Enabled = True
    End Sub
    Private Function ValidData() As Boolean
        Dim sMsg As String = ""

        Try

            ValidData = True
            Select Case Len(uteProjectID.Text)
                Case 0
                    ValidData = False
                    sMsg = "Project ID is required"
                Case Is < 5
                    ValidData = False
                    sMsg = "Project ID must be 5 characters"
            End Select

            If Len(uteNewMargin.Text) = 0 Then
                ValidData = False
                sMsg = sMsg & vbCrLf & "Margin is required"
            End If
            If Len(uteProjectName.Text) = 0 Then
                ValidData = False
                sMsg = sMsg & vbCrLf & "Project Name is required"
            End If
            If Len(uteAnalysisName.Text) = 0 Then
                ValidData = False
                sMsg = sMsg & vbCrLf & "Analysis Name is required"
            End If

            If Len(sMsg) > 0 Then
                MsgBox(sMsg, vbInformation, "ValidData")
                ValidData = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "ValidData")
            ValidData = False
        End Try

    End Function
    Function SaveRecord() As Boolean
        Dim oCMD As SqlCommand
        Dim bGoOn As Boolean
        Dim lRtn As Long = 0
        Try

            mdiMain.UseWaitCursor = True
            Me.Enabled = False

            If mbAddNew Then
                UltraStatusBar1.Panels("CurrentProcess").Text = "Copying Project to Cost Analysis Project"
                bGoOn = CopyProject()
                msProcessLog = "Copy Project: " & uteProjectID.Text & " to Cost Analysis Project: " & ucProjectStandard.Text
                If bGoOn Then
                    If CreateJobs(True) Then
                        bGoOn = True
                    End If
                End If
            Else
                UltraStatusBar1.Panels("CurrentProcess").Text = "Beginning Save Jobs Process"

                bGoOn = SaveJobs()

                If Not bGoOn Then
                    MsgBox("Analysis Changes Saved with some Problems", vbInformation, "SaveRecord")
                    'bGoOn = False we want to reload data even if some jobs didn't save right
                Else
                    'MsgBox("Analysis Changes Saved", vbInformation, "SaveRecord")
                    'bGoOn = True
                End If


            End If
            If bGoOn Then
                UltraStatusBar1.Panels("CurrentProcess").Text = "Creating new Analysis record" & uteProjectID.Text
                msProcessLog = msProcessLog & "Creating New Analysis record for: " & uteProjectID.Text '1/14/15
                bGoOn = UpdateAnalysis()
            End If
            If bGoOn Then
                  LoadDetailGrid()
                mParent.LoadSearchGrid()
                If mbAddNew Then
                    ScrollGrid(mParent.UltraGrid1, 0)
                End If
            End If

            SaveRecord = bGoOn
        Catch ex As Exception
            MsgBox("Error Saving Record: " & ex.Message, MsgBoxStyle.Critical, "SaveRecord")
            SaveRecord = False
        Finally
            If mbAddNew Then
                Dim oErrorLog As New ErrorLog
                oErrorLog.Text = "Progress creating Cost Analysis"
                oErrorLog.uteLog.Text = msProcessLog
                oErrorLog.ShowDialog()
            End If

            oCMD = Nothing
            mdiMain.UseWaitCursor = False
            Me.Enabled = True
        End Try
    End Function
    Private Function CopyProject() As Boolean
        Dim cDB As DBCalls
        Dim sProjectID As String
        Dim sProjectIDNew As String
        Dim sProjectName As String
        Dim sOptionProject As String
        Dim sPlanProject As String
        Dim sCostProject As String
        Dim iDoNotCopyPlans As Integer
        Dim iDoNotCopyOptions As Integer
        Dim iDoNotCopyPrices As Integer
        Dim sMsg As String = ""
        Dim iTaxPermitID As Integer
        Dim bGoOn As Boolean = True

        Try

            ' @ProjectID varchar(5),         '
            ' @ProjectIDNew varchar(5),      '
            ' @ProjectName varchar(50),      '
            ' @CreatedBy char(10),           '
            ' @StandardPlan tinyint,         '
            ' @CreateProject tinyint = 1,    '
            ' @DoNotCopyOptions tinyint = 0, '
            ' @DoNotCopyPlans tinyint = 0,   '
            ' @TaxPermitIDNew int = 0        '
            ' @DoNotCopyPrices int = 0       '

            cDB = New DBCalls
            sProjectID = ucProjectStandard.Text
            sProjectIDNew = uteProjectID.Text
            sProjectName = uteProjectName.Text

            sPlanProject = ucProjectsPlans.Text
            If sPlanProject <> sProjectID Then
                iDoNotCopyPlans = 1
            End If
            sOptionProject = ucProjectOptions.Text
            If sOptionProject <> sProjectID Then
                iDoNotCopyOptions = 1
            End If
            sCostProject = ucProjectsCosts.Text
            If sCostProject <> sProjectID Then
                iDoNotCopyPrices = 1
            End If
            iTaxPermitID = ucDistricts.Value

            ' if all things are copied then use this one            '
            If Not MakeProject(sProjectID, sProjectIDNew, sProjectName, iDoNotCopyOptions, iDoNotCopyPlans, iTaxPermitID, 1, iDoNotCopyPrices) Then
                sMsg = "Error Posting new project." + Err.Description
                bGoOn = False
            End If
            ' the project is copied, now copy the options '
            If bGoOn Then
                If iDoNotCopyPlans = 1 And sPlanProject <> sProjectID Then
                    If Not MakeProject(sPlanProject, sProjectIDNew, sProjectName, 1, 0, iTaxPermitID, 0, 1) Then
                        sMsg = "Error Posting Plans to project."
                        bGoOn = False
                    End If
                End If
            End If
            If bGoOn Then
                ' the project and plans are copied, now copy the options '
                If iDoNotCopyOptions = 1 And sOptionProject <> sProjectID Then
                    If Not MakeProject(sOptionProject, sProjectIDNew, sProjectName, 0, 1, iTaxPermitID, 0, 1) Then
                        sMsg = "Error Posting options to project."
                        bGoOn = False
                    End If
                End If
            End If
            ' now copy prices '
            If bGoOn Then
                If iDoNotCopyPrices = 1 And sCostProject <> sProjectID Then
                    If Not MakeProject(sCostProject, sProjectIDNew, sProjectName, 1, 1, iTaxPermitID, 0, 0) Then
                        sMsg = "Error Posting prices for project."
                        bGoOn = False
                    End If
                End If
            End If
            CopyProject = bGoOn

        Catch ex As Exception
            MsgBox(sMsg & " " & ex.Message, vbCritical, "CopyProject")
            CopyProject = False
        End Try
    End Function
    Private Function MakeProject(ByVal sProjectID As String, _
        ByVal sProjectIDNew As String, ByVal sProjectName As String, _
        ByVal iDoNotCopyOptions As Integer, ByVal iDoNotCopyPlans As Integer, _
        ByVal iTaxPermitID As Integer, ByVal iCreateProject As Integer, _
        ByVal iDoNotCopyPrices As Integer) As Boolean
        Dim oCMD As SqlCommand
        Dim sMsg As String = ""
        Dim bGoOn As Boolean = True
        Dim lRtn As Long = 0
        ' Dim lPID As Long = 0
        Try
            oCMD = New SqlCommand
            ' @ProjectID varchar(5),         '
            ' @ProjectIDNew varchar(5),      '
            ' @ProjectName varchar(50),      '
            ' @CreatedBy char(10),           '
            ' @StandardPlan tinyint,         '
            ' @CreateProject tinyint = 1,    '
            ' @DoNotCopyOptions tinyint = 0, '
            ' @DoNotCopyPlans tinyint = 0,   '
            ' @TaxPermitIDNew int = 0,       '
            ' @PID INT OUTPUT                '

            With oCMD
                .Connection = gCN
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 300
                .CommandText = "spCopyProject"
                ' Add the input parameter and set its properties. 
                Dim parameter As New SqlParameter()
                parameter.ParameterName = "@PID"
                parameter.SqlDbType = SqlDbType.Int
                parameter.Direction = ParameterDirection.Output
                .Parameters.Add(parameter)
                .Parameters.AddWithValue("@ProjectID", sProjectID)
                .Parameters.AddWithValue("@ProjectIDNew", sProjectIDNew)
                .Parameters.AddWithValue("@ProjectName", sProjectName)
                .Parameters.AddWithValue("@DoNotCopyOptions", iDoNotCopyOptions)
                .Parameters.AddWithValue("@DoNotCopyPlans", iDoNotCopyPlans)
                .Parameters.AddWithValue("@TaxPermitIDNew", iTaxPermitID)
                .Parameters.AddWithValue("@CreatedBy", gsUserID)
                .Parameters.AddWithValue("@CreateProject", iCreateProject)
                .Parameters.AddWithValue("@StandardPlan", 1)
                .Parameters.AddWithValue("@DoNotCopyPrices", iDoNotCopyPrices)
                parameter = New SqlParameter
                parameter.SqlDbType = SqlDbType.Int
                parameter.ParameterName = "@RC"
                parameter.Direction = ParameterDirection.ReturnValue
                oCMD.Parameters.Add(parameter)

                lRtn = oCMD.ExecuteNonQuery() 'change to executescalar
                lRtn = oCMD.Parameters("@RC").Value
                If lRtn = 0 Then
                    If iCreateProject = 1 Then
                        mlPID = .Parameters("@PID").Value
                    End If
                    bGoOn = True
                Else
                    If lRtn = 11 Then
                        sMsg = "Project ID: " & sProjectIDNew & " already exists."
                    End If
                    MsgBox(sMsg, MsgBoxStyle.Critical, "MakeProject")
                    bGoOn = False
                End If
            End With    '}-> With oCMD
            MakeProject = bGoOn
        Catch ex As Exception
            MsgBox("Unable to copy project." & " " & sMsg & ex.Message, vbCritical, "MakeProject")
            MakeProject = False
        Finally
            oCMD = Nothing
        End Try
    End Function
    Private Sub ScrollGrid(ByRef thisGrid As UltraGrid, ByVal iRow As Integer)

        ' Get the row to scroll into view.
        Dim row As UltraGridRow = thisGrid.Rows(iRow)

        ' Set the back color of the row so we can identify it on the screen.
        row.Appearance.BackColor = Color.LightSkyBlue

        ' Call ScrollRowIntoView on the active row-scroll-region to scroll the row into 
        ' view vertically.
        thisGrid.ActiveRowScrollRegion.ScrollRowIntoView(row)

        ' Call the ScrollRowIntoView on the active col-scroll-region to scroll the row into view 
        ' vertically.
        thisGrid.ActiveColScrollRegion.ScrollRowIntoView(row, thisGrid.ActiveRowScrollRegion)

    End Sub
    Private Function SaveJobs() As Boolean
        Dim oCMD As New SqlCommand
        Dim sJobID As String
        Dim lPlanPrice As Long
        Dim bTrans As Boolean
        'Dim lRtn As Long
        Dim transaction As SqlTransaction = Nothing
        Dim sNote As String
        Try
            ' Start a local transaction
            transaction = gCN.BeginTransaction("SaveJobs")
            'With oCMD
            '    .Connection = gCN
            '    .Transaction = transaction
            '    .CommandType = CommandType.StoredProcedure
            '    .CommandTimeout = 300
            '    .CommandText = "spUpdateJobForCostAnalysis"
            'End With
            bTrans = True
            Dim oRow As UltraGridRow 'DataRow
            SaveJobs = True
            For Each oRow In ugDetails.Rows 'HCHDataAnalysisDetail.Tables(0).Rows
                'If SaveJobs = False Then
                '    Exit For
                'End If
                With oRow
                    sJobID = .Cells("JobID").Text '.Item("JobID").Text
                    If IsDBNull(.Cells("UpdatedPrice").Value) Then
                        lPlanPrice = 0
                    Else
                        lPlanPrice = CLng(.Cells("UpdatedPrice").Value)
                    End If
                    sNote = .Cells("Note").Text
                End With
                UltraStatusBar1.Panels("JobBeingProcessed").Text = "Job Being Processed: " & sJobID
                UltraStatusBar1.Panels("CurrentProcess").Text = "Saving Job: " & sJobID
                If Not SaveJob(sJobID, lPlanPrice, sNote, transaction) Then
                    SaveJobs = False
                    Exit For
                End If
            Next

            If SaveJobs Then
                transaction.Commit()
                bTrans = False
            Else
                transaction.Rollback()
                bTrans = False
            End If
        Catch ex As Exception
            MsgBox("Error posting changes to job record." & ex.Message, vbCritical, "SaveJob")
            If bTrans Then
                transaction.Rollback()
            End If
            SaveJobs = False
        Finally
            'oCMD = Nothing
        End Try
    End Function
    Private Function CreateJobs(bCreateJob As Boolean) As Boolean
        Dim cDB As DBCalls
        Dim rs As DataSet
        Dim sFile As String
        Dim oCMD As SqlCommand
        Dim sProject As String
        Dim sPlan As String = ""
        Dim iJob As Integer
        Dim oCMD2 As SqlCommand
        Dim sJobID As String = ""
        Dim sBlock As String
        Dim sLot As String
        Dim lErr As Long
        Dim dFileDate As Date
        Dim sMsg As String = ""
        Dim bTrans As Boolean
        Dim sPlanProject As String
        Dim sCopyProject As String
        Dim lCostProjectID As Long
        Dim lAlphaCode As Long
        Dim iTaxPermitDistrict As Integer
        Dim bGoOn As Boolean
        Dim oRow As DataRow
        Dim sPlanType As String = ""
        Dim sMsg2 As String = ""
        Dim bDontCost As Boolean
        Try
            msProcessLog = msProcessLog & vbCrLf & "Creating Jobs"
            If ucProjectsCosts.Text <> ucProjectStandard.Text Then
                lCostProjectID = IIf(ucProjectsCosts.Text <> "", ucProjectsCosts.Value, 0)
            End If
            lAlphaCode = IIf(ucAlphaCodes.Text <> "", ucAlphaCodes.Value, 0)
            iTaxPermitDistrict = IIf(ucDistricts.Text <> "", ucDistricts.Value, 0)
            sPlanProject = ucProjectsPlans.Text
            sCopyProject = ucProjectStandard.Text
            sProject = uteProjectID.Text
            cDB = New DBCalls
            oCMD = New SqlCommand
            oCMD2 = New SqlCommand
            bGoOn = True
            With oCMD
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 600
                .Connection = gCN
            End With
            With oCMD2
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 600
                .Connection = gCN
            End With
            sBlock = "000"
            iJob = 0
            For Each oRow In gsCostAnalysisData.Tables(0).Rows
                sPlanType = oRow.Item("Use")
                If sPlanType <> "Do Not Use" And sPlanType <> "" Then
                    iJob = iJob + 1
                    sLot = Strings.Right("00" & Trim(iJob.ToString), 3)
                    sJobID = sProject & sLot & sBlock
                    sPlan = oRow.Item("PlanID")
                    If bCreateJob Then
                        msProcessLog = msProcessLog & vbCrLf & "Creating New Job:  " & sJobID
                        UltraStatusBar1.Panels("CurrentProcess").Text = "Create Job: " & sJobID & " PlanID: " & sPlan
                        With oCMD2
                            .CommandText = "spCreateNewJob"
                            .CommandType = CommandType.StoredProcedure
                            .Parameters.Clear()
                            ' .Parameters.Refresh()
                            .Parameters.AddWithValue("@JobID", sJobID)
                            .Parameters.AddWithValue("@ProjectID", sProject)
                            .Parameters.AddWithValue("@PlanID", sPlan)
                            .Parameters.AddWithValue("@JobName", sJobID & " " & sPlan)
                            .Parameters.AddWithValue("@Block", sBlock)
                            .Parameters.AddWithValue("@Lot", sLot)
                            .Parameters.AddWithValue("@CreatedBy", gsUserID)
                            .Parameters.AddWithValue("@Address", "")
                            .Parameters.AddWithValue("@City", "")
                            .Parameters.AddWithValue("@ST", "")
                            .Parameters.AddWithValue("@Zip", "")
                            .Parameters.AddWithValue("@LotCostAdjustment", 0)
                            .Parameters.AddWithValue("@BuilderID", 0)
                            .Parameters.AddWithValue("@Spec", 0)
                            .Parameters.AddWithValue("@Garage", 0)
                            .Parameters.AddWithValue("@Status", 9)   ' standard plan '
                            Dim parameter As New SqlParameter
                            parameter.Direction = ParameterDirection.Output
                            parameter.Size = 2000
                            parameter.SqlDbType = SqlDbType.NVarChar
                            parameter.ParameterName = "@ErrMsg"
                            oCMD2.Parameters.Add(parameter)

                            parameter = New SqlParameter
                            parameter.Direction = ParameterDirection.Output
                            parameter.SqlDbType = SqlDbType.Int
                            parameter.ParameterName = "@CID"
                            oCMD2.Parameters.Add(parameter)

                            parameter = New SqlParameter
                            parameter.Direction = ParameterDirection.Output
                            parameter.SqlDbType = SqlDbType.Int
                            parameter.ParameterName = "@JobIDInt"
                            oCMD2.Parameters.Add(parameter)

                            parameter = New SqlParameter
                            parameter.SqlDbType = SqlDbType.Int
                            parameter.ParameterName = "@RC"
                            parameter.Direction = ParameterDirection.ReturnValue

                            oCMD2.Parameters.Add(parameter)

                            lErr = oCMD2.ExecuteNonQuery
                            lErr = .Parameters("@RC").Value
                            Application.DoEvents()

                        End With

                        If lErr > 1 Then
                            sMsg = sMsg & "Problem posting Job records for Job: " & sJobID & vbCrLf & oCMD2.Parameters("@ErrMsg").Value
                            msProcessLog = msProcessLog & vbCrLf & "Problem posting Job records for Job: " & sJobID & vbCrLf & oCMD2.Parameters("@ErrMsg").Value
                            'add bDontCost so jobs with permitting cost issues will still import mrb 10/27/15
                            If lErr = 1 Then
                                sMsg = sMsg & " You must select a permitting option for this job." & vbCrLf
                                msProcessLog = msProcessLog & vbCrLf & " You must select a permitting option for this job."
                                bGoOn = False
                                bDontCost = False
                            ElseIf lErr = 4 Then
                                bGoOn = True
                                bDontCost = True
                            Else
                                bGoOn = False
                                bDontCost = False
                            End If
                        Else
                            bGoOn = True
                            bDontCost = False
                        End If
                    End If    '}-> If bCreateJob Then
                    ' import CAD                                                                      '
                    ' EXEC @RC = spImportCAD @JobID, @FileName, @CreatedBy, @FileDate, @ErrMsg OUTPUT '
                    If bGoOn Then
                        dFileDate = Today 'f.DateLastModified
                        If IsDBNull(oRow("FileName")) Then
                            sFile = ""
                        Else
                            sFile = oRow("FileName")
                        End If
                        UltraStatusBar1.Panels("CurrentProcess").Text = "Import CAD for Job: " & sJobID & " PlanID: " & sPlan
                        With oCMD2
                            .CommandText = "spImportCAD"
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@JobID", sJobID)
                            .Parameters.AddWithValue("@FileName", sFile)
                            .Parameters.AddWithValue("@CreatedBy", gsUserID)
                            .Parameters.AddWithValue("@FileDate", dFileDate)

                            Dim parameter As New SqlParameter
                            parameter.Direction = ParameterDirection.Output
                            parameter.Size = 2000
                            parameter.SqlDbType = SqlDbType.NVarChar
                            parameter.ParameterName = "@ErrMsg"
                            .Parameters.Add(parameter)

                            parameter = New SqlParameter
                            parameter.SqlDbType = SqlDbType.Int
                            parameter.ParameterName = "@RC"
                            parameter.Direction = ParameterDirection.ReturnValue
                            .Parameters.Add(parameter)

                            lErr = oCMD2.ExecuteNonQuery
                            lErr = .Parameters("@RC").Value
                            Application.DoEvents()
                        End With
                        If lErr <> 0 Or Not IsDBNull(oCMD2.Parameters("@ErrMsg").Value) Then
                            ' If lErr <> 0 Then '
                            sMsg2 = "Problem Importing CAD for Job: " & sJobID & " Plan: " & sPlan & sFile & vbCrLf & oCMD2.Parameters("@ErrMsg").Value
                            sMsg = sMsg & vbCrLf & sMsg2 & vbCrLf
                            msProcessLog = msProcessLog & vbCrLf & sMsg2 & vbCrLf
                            bGoOn = False
                            ' ugDetails.ActiveRow = ugDetails.Rows(ugDetails.Rows.Count - 1)
                            SaveJob(sJobID, 0, sMsg2)
                        Else
                            msProcessLog = msProcessLog & vbCrLf & "CAD Imported for plan: " & sJobID & sFile
                        End If
                        'LoadDetailGrid() 'ugDetails.DataBind()
                    End If
                    If bGoOn And bDontCost = False Then ' mrb 10/27/15

                        UltraStatusBar1.Panels("CurrentProcess").Text = "Apply Cost for Job" & sJobID & " PlanID: " & sPlan
                        msProcessLog = msProcessLog & vbCrLf & "Applying Cost for Job" & sJobID & " PlanID: " & sPlan
                        With oCMD2

                            .CommandText = "spApplyCostToJob"
                            .Parameters.Clear()
                            .Parameters.AddWithValue("@JobID", sJobID)
                            .Parameters.AddWithValue("@CreatedBy", gsUserID)
                            If iTaxPermitDistrict <> 0 Then
                                .Parameters.AddWithValue("@TaxPermitID", iTaxPermitDistrict)
                            End If
                            If lCostProjectID <> 0 Then
                                .Parameters.AddWithValue("@ProjectID", lCostProjectID)
                            End If
                            Dim parameter As SqlParameter
                            parameter = New SqlParameter
                            parameter.SqlDbType = SqlDbType.Int
                            parameter.ParameterName = "@RC"
                            parameter.Direction = ParameterDirection.ReturnValue
                            oCMD2.Parameters.Add(parameter)
                            parameter = New SqlParameter
                            parameter.SqlDbType = SqlDbType.NVarChar
                            parameter.ParameterName = "@ErrMsg"
                            parameter.Direction = ParameterDirection.ReturnValue
                            oCMD2.Parameters.Add(parameter)
                            lErr = oCMD2.ExecuteNonQuery
                            lErr = .Parameters("@RC").Value
                            Application.DoEvents()
                            sMsg2 = .Parameters("@ErrMsg").Value  '10/29/15 mrb
                        End With
                        If lErr <> 0 Or Not sMsg2 = Nothing Then '10/29/15 mrb
                            sMsg = sMsg & "Problem Applying Costs to Job: " & sJobID & sPlan & vbCrLf & sMsg2
                            msProcessLog = msProcessLog & vbCrLf & "Problem Applying Costs to Job: " & sJobID & sPlan
                            ' bGoOn = False
                            SaveJob(sJobID, 0, sMsg)
                        Else
                            sMsg2 = "Costs applied to Job: " & sJobID & " Plan: " & sPlan
                            msProcessLog = msProcessLog & vbCrLf & sMsg2
                            SaveJob(sJobID, 0, sMsg2)
                        End If
                    Else 'if bgoon and bDontCost = false mrb 10/27/15
                        sMsg = sMsg & "Costs NOT applied to this job due to early permitting or site work cost issue: " & sJobID & " Plan: " & sPlan
                    End If
                    bTrans = False
                    LoadDetailGrid()
                    Application.DoEvents()
                End If
            Next     'row in dataset created in choose plans
            If Len(sMsg) > 0 Then
                CreateJobs = False
            Else
                CreateJobs = True
            End If

            cDB = Nothing
            rs = Nothing

        Catch ex As Exception
            'MsgBox(sMsg & " " & ex.Message, vbCritical, "CreateJobs")
            msProcessLog = msProcessLog & vbCrLf & sMsg & " Error in Create Jobs: " & ex.Message & " PlanID: " & sPlan & " JobID: " & sJobID
            CreateJobs = False
        Finally
            cDB = Nothing
            rs = Nothing
        End Try
    End Function

    Private Sub btnSelectPlans_Click(sender As Object, e As EventArgs) Handles btnSelectPlans.Click
        CostAnalysisPlanChooser.msPlanProjectID = ucProjectsPlans.Text
        CostAnalysisPlanChooser.ShowDialog()
        ckPlansSelected.Checked = Not gsCostAnalysisData Is Nothing
        If ckPlansSelected.CheckState = CheckState.Checked Then
            tsBtnSave.Enabled = True
        End If
    End Sub

    Private Sub ucProjectsPlans_RowSelected(sender As Object, e As RowSelectedEventArgs) Handles ucProjectsPlans.RowSelected
        If Not Nothing Is e.Row Then
            btnSelectPlans.Enabled = mbAddNew And ucProjectsPlans.Text <> ""
        End If
    End Sub
    Private Sub GetDataDate()
        Dim cDB As DBCalls
        Try
            cDB = New DBCalls
            Dim ds As New DataSet
            Dim row As DataRow
            Dim sDate As DateTime
            If cDB.GetRecordsFromSP(ds, "spCostAnalysisDateGet") Then
                For Each row In ds.Tables(0).Rows
                    sDate = row.Item("UpdateEnded").ToString
                    tsLblLastReloadDate.Text = "Last Reload Date: " & sDate
                Next
            End If
            ds = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "GetDataDate")
        Finally
            cDB = Nothing
        End Try
    End Sub
    Private Sub tsBtnReloadData_Click(sender As Object, e As EventArgs) Handles tsBtnReloadData.Click
        Me.Enabled = False
        ReloadCostAnalysisData()
        Me.Enabled = True
        GetDataDate()
    End Sub
    Private Function UpdateAnalysis() As Boolean
        Dim lCostProjectID As Long
        Dim lPlanProjectid As Long
        Dim lCopyProjectID As Long
        Dim lOptionProjectID As Long
        Dim lAlphaCode As Long
        Dim iTaxPermitDistrict As Integer
        Dim iSoftCosts As Integer
        Dim cCostIncrease As Decimal
        Dim cNewMargin As Decimal
        Dim iPremium As Integer
        Dim oCmd As SqlCommand
        Dim lRtn As Long
        Dim bGoOn As Boolean
        Dim sMsg As String = ""

        Try
            lCostProjectID = ucProjectsCosts.Value
            lPlanProjectid = ucProjectsPlans.Value
            lOptionProjectID = ucProjectsPlans.Value
            lCopyProjectID = ucProjectStandard.Value
            lAlphaCode = ucAlphaCodes.Value
            iTaxPermitDistrict = ucDistricts.Value
            iSoftCosts = uteSoftCosts.Value
            cCostIncrease = uteCostIncreasePercent.Value
            cNewMargin = uteNewMargin.Value
            iPremium = uteProjectPremium.Value

            oCmd = New SqlCommand
            With oCmd
                .Connection = gCN
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 300
                .CommandText = "spUpdateCostAnalysisNew"
                Dim parameter = New SqlParameter
                parameter.SqlDbType = SqlDbType.Int
                parameter.ParameterName = "@AnalysisID"
                parameter.Direction = ParameterDirection.InputOutput
                parameter.Value = miAnalysisID
                oCmd.Parameters.Add(parameter)
                .Parameters.AddWithValue("@VersionName", uteAnalysisName.Text)
                .Parameters.AddWithValue("@CostProjectID", lCostProjectID)
                .Parameters.AddWithValue("@CostedDate", Today)
                .Parameters.AddWithValue("@CreatedBy", gsUserID)
                .Parameters.AddWithValue("@ProjectMargin", cNewMargin)
                .Parameters.AddWithValue("@Notes", uteNotes.Text)
                .Parameters.AddWithValue("@OptionProjectID", lOptionProjectID)
                .Parameters.AddWithValue("@PlanProjectID", lPlanProjectid)
                .Parameters.AddWithValue("@CostIncreaseAlpha", lAlphaCode)
                .Parameters.AddWithValue("@CostIncreasePercent", cCostIncrease)
                .Parameters.AddWithValue("@TaxPermitID", iTaxPermitDistrict)
                .Parameters.AddWithValue("@CopyProjectID", lCopyProjectID)
                .Parameters.AddWithValue("@SoftCosts", iSoftCosts)
                .Parameters.AddWithValue("@ProjectName", uteProjectName.Text)
                .Parameters.AddWithValue("@ProjectID", uteProjectID.Text)
                .Parameters.AddWithValue("@Period", utePeriod.Text)
                .Parameters.AddWithValue("@ProjectPremium", iPremium)
                .Parameters.AddWithValue("@DoNotUse", chkDoNotUse.CheckState)
                parameter = New SqlParameter
                parameter.SqlDbType = SqlDbType.Int
                parameter.ParameterName = "@RC"
                parameter.Direction = ParameterDirection.ReturnValue
                oCmd.Parameters.Add(parameter)
                lRtn = oCmd.ExecuteNonQuery
                lRtn = oCmd.Parameters("@RC").Value
                If lRtn <> 0 Then
                    sMsg = "Unable to save changes for Analysis: " & uteProjectName.Text
                    MsgBox(sMsg, MsgBoxStyle.Critical, "UpdateAnalysis")
                    bGoOn = False
                Else
                    miAnalysisID = oCmd.Parameters("@AnalysisID").Value
                    bGoOn = True
                    MsgBox("Changes Saved")
                End If
            End With    ')-> With oCMD
            UpdateAnalysis = bGoOn
        Catch ex As Exception
            UpdateAnalysis = False
            MsgBox("Error Updating or Creating Analysis record: " & ex.Message, MsgBoxStyle.Critical, "UpdateAnalysis")
        Finally
            oCmd = Nothing

        End Try
    End Function


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles tsBtnRecalculateGrid.Click
        Dim cCost As Decimal
        Dim cMargin As Decimal
        Dim lPrice As Long
        Dim sVersion As String
        Dim lCurrentPrice As Long
        Dim oRow As UltraGridRow

        Try
            cMargin = Math.Round(CDec(uteNewMargin.Value), 2, MidpointRounding.AwayFromZero)
            sVersion = uteAnalysisName.Text
            'ugDetails.DisplayLayout.Bands(0).Columns("NewMargin").CellActivation = Activation.AllowEdit
            ugDetails.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
            For Each oRow In ugDetails.Rows
                With oRow 'ssdbgPlans
                    cCost = .Cells("BudgetCost").Value
                    lPrice = CalculatePrice(cMargin, cCost)
                    .Cells("AnalysisPrice").Value = lPrice
                    .Cells("UpdatedPrice").Value = lPrice
                    .Cells("NewMargin").Activation = Activation.AllowEdit
                    .Cells("NewMargin").Value = cMargin

                    lCurrentPrice = CLng(IIf(.Cells("PlanPrice").Text = "", 0, .Cells("PlanPrice").Text))
                    .Cells("Increase").Value = lPrice - lCurrentPrice
                End With
            Next
            'ugDetails.DisplayLayout.Bands(0).Columns("NewMargin").CellActivation = Activation.NoEdit

            uteAnalysisName.Focus()
        Catch ex As Exception
            MsgBox("Error in Recalculate Grid: " & ex.Message, MsgBoxStyle.Critical, "tsBtnRecalculateGrid_click")
        End Try

    End Sub

    Public Function CalculatePrice(ByVal cMargin As Decimal, ByVal cCost As Decimal, Optional ByVal cLotCost As Decimal = 0) As Long
        Dim cTemp As Decimal
        Dim cRound

        On Error GoTo ErrHandler
        ' Round to either xxx400 or xxx900 mb 3/23/04 '

        If cCost <> 0 Then
            ' cTemp = (cMargin + 1) * cCost '
            cTemp = cCost / (1 - cMargin) + cLotCost
            cRound = Math.Round(cTemp / 1000, 0) * 1000
            If cTemp > cRound Then
                cTemp = cRound + 400
            Else
                cTemp = cRound - 100
            End If
            ' If cTemp < 100000 Then                          '
            ' cTemp = (Round(cTemp / 1000, 0) * 1000) - 100   '
            ' Else                                            '
            ' cTemp = (Round(cTemp / 10000, 0) * 10000) - 100 '
            ' End If                                          '
            ' cTemp = cTemp - 100                             '
            CalculatePrice = cTemp
        Else
            CalculatePrice = 0
        End If    '}-> If cCost <> 0 Then
        Exit Function
ErrHandler:
        MsgBox(Err.Description, vbCritical, "CalculatePrice")
    End Function

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles tsButtonHelp.Click
        ShowPDFHelp(Application.StartupPath & "\BOSS Cost Analysis.pdf")
    End Sub



    Private Sub chkUseInfoFromStandardProject_CheckedChanged(sender As Object, e As EventArgs) Handles chkUseInfoFromStandardProject.CheckedChanged
        If Not Nothing Is ucProjectStandard.SelectedRow Then
            ChangeProjectDropdowns()
        End If
    End Sub
    Private Function SaveJob(ByVal sJobID As String, ByVal lUpdatedPrice As Long, ByVal sNote As String, Optional ByRef localTransaction As SqlTransaction = Nothing) As Boolean
        Dim oCMD As New SqlCommand
        'Dim lPlanPrice As Long
        Dim lRtn As Long
        Try
            With oCMD
                .Connection = gCN

                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 300
                .CommandText = "spUpdateJobForCostAnalysis"
                .Transaction = localTransaction
            End With
            msProcessLog = msProcessLog & "Begin Update Job for Cost Analysis for Job: " & sJobID
            SaveJob = True


            UltraStatusBar1.Panels("CurrentProcess").Text = "Saving Job: " & sJobID
            With oCMD
                .Parameters.AddWithValue("@UpdatedBy", gsUserID)
                .Parameters.AddWithValue("@AnalysisPrice", lUpdatedPrice)
                .Parameters.AddWithValue("@JobID", sJobID)
                .Parameters.AddWithValue("@Note", sNote)
                Dim parameter = New SqlParameter
                parameter.SqlDbType = SqlDbType.Int
                parameter.ParameterName = "@RC"
                parameter.Direction = ParameterDirection.ReturnValue
                oCMD.Parameters.Add(parameter)

                lRtn = oCMD.ExecuteNonQuery
                lRtn = oCMD.Parameters("@RC").Value
                If lRtn <> 0 Then
                    SaveJob = False
                Else
                    SaveJob = True
                End If
            End With

        Catch ex As Exception
            MsgBox("Error in Save Job: " & ex.Message, MsgBoxStyle.Critical, "SaveJob")
            msProcessLog = msProcessLog & " Error in Save Job: " & ex.Message & " Job: " & sJobID
            SaveJob = False
        Finally
            oCMD = Nothing
        End Try

    End Function

    Private Sub tsBtnPrint_Click(sender As Object, e As EventArgs) Handles tsBtnPrint.Click
        Dim rptViewer As New ReportViewer
        With rptViewer
            .sReportToRun = "Cost Analysis - Review"
            .sReportTitle = "Cost Analysis - Review for: " & uteProjectID.Text
            .sCriteria = miAnalysisID.ToString
            .Show()
        End With
    End Sub

    Private Sub tsBtnPrintRpt2_Click(sender As Object, e As EventArgs) Handles tsBtnPrintRpt2.Click
        Dim rptViewer As New ReportViewer
        With rptViewer
            .sReportToRun = "Cost Analysis - Sales"
            .sReportTitle = "Cost Analysis - Sales: " & uteProjectID.Text
            .sCriteria = miAnalysisID.ToString
            .Show()

        End With
    End Sub

    

    Private Sub ugDetails_MouseDown(sender As Object, e As MouseEventArgs) Handles ugDetails.MouseDown
        If e.Button = MouseButtons.Right And ugDetails.Selected.Rows.Count > 0 Then
            ugDetails.ContextMenuStrip.Hide()
            Dim point As Point = New System.Drawing.Point(e.X, e.Y)
            Dim uiElement As UIElement = DirectCast(sender, UltraGridBase).DisplayLayout.UIElement.ElementFromPoint(point)
            Dim cell As UltraGridCell = DirectCast(uiElement.GetContext(GetType(UltraGridCell)), UltraGridCell)

            If cell IsNot Nothing Then ' AndAlso UseThisContextMenu(cell) Then
                ugDetails.ContextMenuStrip.Show()
            End If
        End If

    End Sub

    Private Function UseThisContextMenu(oRow As UltraGridRow) As Boolean
        Dim sJobID As String
        Dim oForm As New EstimateView
        Try
            sJobID = oRow.Cells("JobID").Text
            oForm.msJobID = sJobID
            oForm.mbLockJobs = True
            oForm.ShowDialog()
            UseThisContextMenu = True
        Catch ex As Exception
            UseThisContextMenu = False
            MsgBox("Error in View Estimate" & ex.Message, MsgBoxStyle.Critical, "UseThisContextMenu")
        End Try
    End Function

    Private Sub tsViewEstimate_Click(sender As Object, e As EventArgs) Handles tsViewEstimate.Click
        If ugDetails.Selected.Rows.Count > 0 Then
            UseThisContextMenu(ugDetails.Selected.Rows(0))
        End If
    End Sub

    Private Sub tsEstimateCostedRpt_Click(sender As Object, e As EventArgs) Handles tsEstimateCostedRpt.Click
        Dim rptViewer As New ReportViewer
        Dim sJobID As String
        If ugDetails.Selected.Rows.Count > 0 Then
            sJobID = ugDetails.Selected.Rows(0).Cells("JobID").Text
            With rptViewer
                .sReportToRun = "Job Estimate - Costed"
                .sReportTitle = "Job Estimate Cossted: " & sJobID
                .sJobID = sJobID
                .Show()
            End With
        End If
    End Sub

    Private Sub tsSummaryBudgetRpt_Click(sender As Object, e As EventArgs) Handles tsSummaryBudgetRpt.Click

        Dim rptViewer As New ReportViewer
        Dim sJobID As String
        If ugDetails.Selected.Rows.Count > 0 Then
            sJobID = ugDetails.Selected.Rows(0).Cells("JobID").Text
            With rptViewer
                .sReportToRun = "Summary Budget Report"
                .sReportTitle = "Summary Budget Report: " & sJobID
                .sJobID = sJobID
                .Show()
            End With
        End If
    End Sub
End Class