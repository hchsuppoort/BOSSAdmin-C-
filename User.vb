Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid

Public Class UserSelect
    'Public oGrid As New UltraGrid
    Public oGridDS As New DataSet
    Public oGridLayout As New Infragistics.Win.UltraWinGrid.UltraGridLayout
    Public sCaption As String = ""
    Private Sub UserSelect_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadToGrid()
        LoadFromGrid()

    End Sub
    Private Function LoadToGrid() As Boolean
        'Dim ds As New DataSet
        'Dim ds2 As New DataSet
        'Dim dbCalls As New DBCalls
        Try
            Me.Text = sCaption
            grdTo.DataSource = oGridDS
            grdTo.DataBind()
            grdTo.Height = 200
            grdTo.Width = 375
            grdTo.DisplayLayout.ActiveRow.Activation = Activation.AllowEdit
            grdTo.DisplayLayout.Load("userlayout")
            LoadToGrid = True
        Catch
            ShowError("Error loading Selected Users: " & Err.Description, False, "BOSSAdmin", "User: LoadToGrid ")
            LoadToGrid = False
        Finally
            '   dbCalls = Nothing
            '  ds.Dispose()
            ' ds2.Dispose()
            ' ds = Nothing
            'ds2 = Nothing
        End Try

    End Function
    Private Function ReloadToGrid() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim sNotifyCriteria As String = ""
        Try
            
            grdTo.DataSource = Nothing
            grdTo.ResetDisplayLayout()
            grdTo.Layouts.Clear()
            If sCaption <> "" Then
                If dbCalls.GetRecordsFromSP(ds, "spNotifyListGet", sCaption) Then
                    grdTo.DataSource = ds
                    grdTo.DataBind()
                    grdTo.Height = 200
                    grdTo.Width = 375
                    grdTo.DisplayLayout.ActiveRow.Activation = Activation.AllowEdit
                    grdTo.DisplayLayout.Load("userlayout")
                End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then                
            End If 'scaption <> ""
            ReloadToGrid = True
        Catch
            ReloadToGrid = False
            ShowError("Error in ReloadGrid: " & Err.Description, False, "BOSSAdmin", "User: ReloadToGrid ")
        Finally
            dbCalls = Nothing
        End Try

    End Function
    Private Function LoadFromGrid() As Boolean
        Dim ds2 As New DataSet
        Dim cDB As New DBCalls
        Try
            If cDB.GetRecordsFromSP(ds2, "spUsersNotNotifiedGet", sCaption) Then
                grdFrom.DataSource = ds2
                grdFrom.DataBind()
                grdFrom.Height = 200
                grdFrom.Width = 375

                Dim ugc As UltraGridColumn

                ugc = grdFrom.DisplayLayout.Bands(0).Columns("siid")
                ugc.Hidden = True
            End If
            LoadFromGrid = True
        Catch
            LoadFromGrid = False
            ShowError("Error in LoadFromGrid: " & Err.Description, False, "BOSSAdmin", "User: LoadFromGrid ")
        Finally
            cDB = Nothing
        End Try
    End Function
    Private Sub grdTo_AfterRowsDeleted(sender As Object, e As System.EventArgs) Handles grdTo.AfterRowsDeleted
        ''delete row from config table
        'Dim oDB As New DBCalls
        'Dim sItemID As String = grdTo.ActiveRow.Cells("ItemID").Text
        'Dim iRtn As Integer
        'Try
        '    Cursor = Cursors.WaitCursor
        '    iRtn = oDB.GetReturnValueFromSP("spNotifyDelete", sItemID)
        '    If iRtn = 0 Then
        '        MsgBox("User Notification deleted.", MsgBoxStyle.Information, "Delete Notification")
        '    Else
        '        MsgBox("Problem deleting notification.  Contact your system administrator.", MsgBoxStyle.Critical, "Delete Notification")
        '    End If
        'Catch
        '    MsgBox("Error deleting notification: " & Err.Description, MsgBoxStyle.Critical, "Delete Notification")
        'Finally
        '    Cursor = Cursors.Default
        'End Try
    End Sub

    Private Sub grdTo_BeforeRowsDeleted(sender As Object, e As Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventArgs) Handles grdTo.BeforeRowsDeleted
        'delete row from config table
        Dim oDB As New DBCalls
        Dim sItemID As String = grdTo.ActiveRow.Cells("ItemID").Text
        Dim iRtn As Integer
        Dim sUser As String = grdTo.ActiveRow.Cells("fname").Text
        e.DisplayPromptMsg = False

        Try
            If MsgBox("Do you want to delete the notification for " & Me.sCaption & " to: " & sUser & "?", vbYesNo, "Delete Notification") = MsgBoxResult.Yes Then

                Cursor = Cursors.WaitCursor
                iRtn = oDB.GetReturnValueFromSP("spNotifyDelete", sItemID)
                If iRtn = 0 Then
                    MsgBox("User Notification deleted.", MsgBoxStyle.Information, "Delete Notification")
                Else
                    MsgBox("Problem deleting notification.  Contact your system administrator.", MsgBoxStyle.Critical, "Delete Notification")
                End If
            Else
                e.Cancel = True
            End If
        Catch
            ShowError("Error deleting notification: " & Err.Description, False, "BOSSAdmin", "User: Delete Notification` ")
        Finally
            LoadFromGrid()
            Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub btnAddusers_Click(sender As System.Object, e As System.EventArgs) Handles btnAddusers.Click
        Dim cDB As New DBCalls
        Dim lSIID As Long = 0
        Dim lRtn As Long = 0
        'create procedure spNotifyInsert 
        ' @Item varchar(50), 
        ' @ItemValue varchar(50), 
        ' @ItemValue2 varchar(50)
        Try
            For Each row In grdFrom.Selected.Rows
                lSIID = row.Cells("SIID").Value
                lRtn = cDB.GetReturnValueFromSP("spNotifyInsert", "notification", sCaption, lSIID)
                ' row.Delete()
            Next
          

        Catch
            ShowError("Error saving new users for notification: " & Err.Description, False, "BOSSAdmin", "User: btnAddUsers_Click ")
        Finally
            cDB = Nothing
            ReloadToGrid()

            LoadFromGrid()

        End Try
    End Sub
End Class