Option Explicit On
Option Strict Off
Imports System.Windows.Forms
Imports BossAdmin

Public Class Login

    Dim msMsg As String
    Dim mvRole As Object
    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click

        Dim ds As Object
        Dim cDB As DBCalls
        Dim bNoEnvironment As Boolean
        Try


            Cursor = Cursors.WaitCursor
            SetGlobals()
            If GetBossAdminUpdate() = True Then

                'gsUserID = Trim(txtUserID.Text)
                Select Case cmbEnvironment.Text
                Case "Cost Analysis"
                    gsDatabase = "HCHDataQA"
                Case "Test"
                    gsDatabase = "HCHDataTest"
                Case "Live"
                    gsDatabase = "HCHData"
            End Select    '}-> Select Case ssdbcEnvironment.Columns(1).Value
            gsUserID = Trim(txtUserID.Text)

            If ConnectDB() Then
                gCN = gCNBoss 'why are we doing this? mrb 12/3/14 we set it back at the end of this procedure
                cDB = New DBCalls
                ds = New DataSet
                If cDB.GetRecordsFromSP(ds, "spGetUserInfo", gsUserID, txtPassword.Text) Then
                    Dim oRow As DataRow
                    oRow = ds.Tables(0).Rows(0)
                    With oRow
                        giRank = ds.Tables(0).Rows(0)("Rank")
                        gsUserID = Trim(txtUserID.Text)
                        If IsDBNull(ds.Tables(0).Rows(0)("eMail")) Then
                            gsUserEmail = ""
                        Else
                            gsUserEmail = ds.Tables(0).Rows(0)("eMail")
                        End If
                        'gsUserEmail = IIf(IsDBNull(ds!EMail), "", ds!EMail)
                        giSecurityID = ds.Tables(0).Rows(0)("SIId")
                        giPositionID = ds.Tables(0).Rows(0)("PositionID")
                        gsUserName = RTrim(ds.Tables(0).Rows(0)("FName")) & " " & ds.Tables(0).Rows(0)("LName")
                        gbValidUser = True
                        Select Case cmbEnvironment.Text
                            Case "Cost Analysis"
                                If ds.Tables(0).Rows(0)("qa") = 1 Then
                                    gsDatabase = "HCHDataQA"
                                    ' gsConnectionString = Global.BossAdmin.My.MySettings.Default.HCHDataQAConnectionString
                                End If
                            Case "Test"
                                If ds.Tables(0).Rows(0)("test") = 1 Then
                                    gsDatabase = "HCHDataTest"
                                    'gsConnectionString = Global.BossAdmin.My.MySettings.Default.HCHDataTestConnectionString
                                End If
                            Case "Live"
                                If ds.Tables(0).Rows(0)("live") = 1 Then
                                    gsDatabase = "HCHData"
                                    'gsConnectionString = Global.BossAdmin.My.MySettings.Default.HCHDataConnectionString
                                End If
                        End Select    '}-> Select Case ssdbcEnvironment.Columns(1).Value
                        '[ApplicationNamespace].Properties.Settings.Default["ConnectionString"] = newconstr
                        'Global.BossAdmin.My.MySettings.Default("HCHDataConnectionString") = gsConnectionString
                        bNoEnvironment = gsDatabase = vbNullString

                    End With
                Else
                    gbValidUser = False
                End If    '}-> If Not rs.EOF Or rs.BOF Then

                If bNoEnvironment = True Or gbValidUser = False Then
                    If bNoEnvironment = True Then
                        msMsg = "You do not have permission for this environment!"
                        gbValidUser = False
                    ElseIf gbValidUser = False Then
                        msMsg = "Invalid User Name or Password."
                    Else
                        gbValidUser = True
                    End If    '}-> If bNoEnvironment = True Then
                    MsgBox(msMsg, vbCritical, "Permission Denied")
                    cmbEnvironment.Focus()
                    Cursor = Cursors.WaitCursor
                Else
                    ds = New DataSet
                    If gsUserEmail = vbNullString Then
                        ds = cDB.GetRecordsFromSP(ds, "spGetConfig", "DEFAULTEMAIL")
                        gsUserEmail = ds!ItemValue
                    End If
                    ds = New DataSet
                    If cDB.GetRecordsFromSP(ds, "spGetSecurityByPositionID", giPositionID) Then
                        ' SELECT m.EditRank, m.ViewRank, m.ObjectName, m.ObjectType '
                        Dim oMatrix As SecurityMatrix
                        Dim i As Integer = 0
                        Dim iRows As Integer = ds.tables(0).rows.count
                        For i = 0 To iRows - 1
                            oMatrix = New SecurityMatrix
                            With oMatrix
                                .EditRank = ds.tables(0).rows(i)("editrank")
                                .ViewRank = ds.tables(0).rows(i)("viewrank")
                                .ObjectName = ds.tables(0).rows(i)("objectname")
                                .ObjectType = ds.tables(0).rows(i)("objecttype")
                            End With
                            gSecurityList.Add(oMatrix)
                        Next
                        ConnectDB()
                        Cursor = Cursors.Default

                    End If ' If cDB.GetRecordsFromSP(ds, "spGetSecurityByPositionID", giPositionID) Then
                End If '                If bNoEnvironment = True Or bValidUser = False Then
                'mdiMain.Show()
            Else
                MsgBox("Unable to connect to the database", MsgBoxStyle.Critical, "Login cmdOk_click")
            End If
            End If

        Catch
            Select Case Err.Number
                Case -2147467238, 462, 13
                    msMsg = "Cannot connect to the Estimator Database.  Contact you System Administrator."
                    MsgBox(msMsg, vbCritical, "Data Connect Error")
                Case 3021
                    msMsg = "Invalid login attempt.  Please re-enter your User ID and Password."
                    MsgBox(msMsg, vbExclamation, "Invalid Login")
                    txtUserID.Text = vbNullString
                    txtPassword.Text = vbNullString
                    txtUserID.Focus()
                Case 70
                    msMsg = "Cannot establish a database connection.  Please contact your IT Manager for assistance."
                    MsgBox(msMsg, vbCritical, "Database Connection Error")
                Case Else
                    MsgBox("The following error occurred in Form UserLogin, cmdOK_Click: " & Err.Description & " " & Err.Number)
            End Select    '}-> Select Case Err.Number
            gbValidUser = False
        Finally

            ds = Nothing

            cDB = Nothing
            Cursor = Cursors.Default
            If gbValidUser = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
    Private Function GetBossAdminUpdate() As Boolean
        Dim strLocalEXE As String
        Dim strMasterEXE As String
        Dim strLocalCfg As String
        Dim strMasterCfg As String
        Dim strMasterExeDate As String
        Dim strLocalExeDate As String
        Dim strLocalCfgDate As String
        Dim strMasterCfgDate As String

        '        'added 9/8/23 
        GetBossAdminUpdate = False
        Try
            If gsUpdateFolder <> "" Then
                strMasterEXE = gsUpdateFolder & "\BOSSAdminUpdate.exe"
                strLocalEXE = My.Application.Info.DirectoryPath & "\BOSSAdminUpdate.exe"
                strMasterExeDate = FileDateTime(strMasterEXE) 'Format(FileDateTime(strMasterEXE), "YYYYMMDDHHMMSS")
                strLocalExeDate = FileDateTime(strLocalEXE) 'Format(FileDateTime(My.Application.Info.DirectoryPath & "\BOSSAdminUpdate.exe"), "YYYYMMDDHHMMSS")

                strMasterCfgDate = Format(FileDateTime(gsUpdateFolder & "\BOSSAdminUpdate.exe.config"), "YYYYMMDDHHMMSS")
                strLocalCfgDate = Format(FileDateTime(My.Application.Info.DirectoryPath & "\BOSSAdminUpdate.exe.config"), "YYYYMMDDHHMMSS")
                If strMasterCfgDate > strLocalCfgDate Then
                    FileCopy(gsUpdateFolder & "\BOSSAdminUpdate.exe.config", My.Application.Info.DirectoryPath & "\BOSSAdminUpdate.exe.config")
                End If
                If strMasterExeDate > strLocalExeDate Then
                    FileCopy(gsUpdateFolder & "\BOSSAdminUpdate.exe", My.Application.Info.DirectoryPath & "\BOSSAdminUpdate.exe")
                End If
                'Else
                '    If Err.Description <> "" Then
                '        MsgBox("The following error occurred in Form UserLogin, GetBOSSAdminUpdate: " & Err.Description & " " & Err.Number)
                '    Else
                '        MsgBox("The following error occurred in Form UserLogin, GetBOSSAdminUpdate: " & "Unable to Get BOSSAdminUpdateFolder")
                '    End If
                GetBossAdminUpdate = True
            End If
        Catch ex As Exception
            MsgBox("The following error occurred in Form UserLogin, GetBOSSAdminUpdate: " & ex.Message)
            GetBossAdminUpdate = False
        End Try
    End Function
End Class