Imports Infragistics.Win
Imports System.Data.SqlClient
Imports System.Data
Imports Infragistics
Imports Infragistics.Shared
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.UltraWinEditors
Imports System.Windows.Forms
Imports Infragistics.Win.Misc
Imports System.Text.RegularExpressions

Public Class UserMaintenance

    Private m_emailRegEx As Regex
    Private ReadOnly Property EmailRegEx() As Regex
        Get
            If Me.m_emailRegEx Is Nothing Then
                Me.m_emailRegEx = New Regex("\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase)
            End If

            Return Me.m_emailRegEx
        End Get
    End Property
    Private Function LoadGrid() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Try
            grdUsers.DataSource = Nothing
            'SELECT distinct s.SIId, s.PositionID, p.Position, s.FName, s.LName, 
            's.Inactive,
            's.[Address], s.City, s.ST, s.Zip, s.HPhone, s.Cell, s.Radio, s.Fax, s.EMail,
            's.UserID, s.[password], s.SupervisorID, Live, QA, Test

            If dbCalls.GetRecordsFromSP(ds, "spUserListGet") Then
                grdUsers.DataSource = ds
                grdUsers.DataBind()
                Dim layout As UltraGridLayout = grdUsers.DisplayLayout
                Dim bands As BandsCollection = layout.Bands
                ' Get the first band, which is the  top-most band in case you had multple bands.
                Dim band As UltraGridBand = bands(0)
                ' Columns property off UltraGridBand returns the collection of columns associated with the band.
                Dim oColumns As ColumnsCollection = band.Columns

                'create column to track changes
                Dim ugc As UltraGridColumn

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Address")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("City")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("St")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Zip")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("HPhone")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Cell")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Radio")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Fax")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("UserID")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Password")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("SupervisorID")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("PositionID")
                ugc.Hidden = True

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Live")
                ugc.Header.Caption = "Access to BOSS"

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Test")
                ugc.Header.Caption = "Access to Test"

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("QA")
                ugc.Header.Caption = "Access to Cost Analysis"

                ugc = grdUsers.DisplayLayout.Bands(0).Columns("Live")
                ugc.Header.Caption = "Access to BOSS"


                grdUsers.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                If grdUsers.Rows.Count > 0 Then
                    If Not grdUsers.ActiveRow Is Nothing Then '9/16/16 mrb
                        grdUsers.ActiveRow.Selected = True
                    End If
                End If 'If grdUsers.Rows.Count > 0 Then
                'grdUsers.DisplayLayout.Bands(0).RowEditTemplate = retMilestones
                LoadGrid = True
            Else
                LoadGrid = False '9/16/16 mrb
            End If 'If dbCalls.GetRecordsFromSP(ds, "spUserListGet") Then
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: LoadGrid ")
            LoadGrid = False
        Finally
            'add this 9/16/16 mrb
            If Not ds Is Nothing Then
                ds = Nothing
            End If
            If Not dbCalls Is Nothing Then
                dbCalls = Nothing
            End If
        End Try
    End Function

    Private Sub UserMaintenance_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LoadGrid()
        LoadPositions()
        LoadSupervisors()
        LoadStates()
        'mrb 1/31/13
        EnableDisableToolStrip(False, "UserMaintenance")
        hidefields()

    End Sub
    Private Sub hidefields()
        Dim bCanEdit As Boolean
        bCanEdit = HasEditSecurity("mnuSecurity", "Menu")
        utePassword.Visible = bCanEdit
    End Sub
    Private Function LoadNotifyList() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet
        Dim iSIID As Integer = 0
        Try
            iSIID = grdUsers.ActiveRow.Cells("siid").Text

            grdNotifyList.DataSource = Nothing
            grdNotifyList.ResetDisplayLayout()
            grdNotifyList.Layouts.Clear()


            If iSIID <> 0 Then
                If dbCalls.GetRecordsFromSP(ds, "spNotifyListGetByUser", iSIID) Then
                    grdNotifyList.DataSource = ds
                    grdNotifyList.DataBind()
                    Dim layout As UltraGridLayout = grdNotifyList.DisplayLayout
                    Dim bands As BandsCollection = layout.Bands
                    ' Get the first band, which is the  top-most band in case you had multple bands.
                    Dim band As UltraGridBand = bands(0)
                    ' Columns property off UltraGridBand returns the collection of columns associated with the band.

                    Dim ugc As UltraGridColumn

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("ItemValue")
                    ugc.Width = 200

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("ItemValue2")
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Position")
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("fname")
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("lname")
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Rank")
                    ugc.Hidden = True

                    ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("ItemID")
                    ugc.Hidden = True

                End If ' If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                grdNotifyList.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                EnableDisableToolStrip(True, "LoadNotifyList")
            Else
                grdNotifyList.Text = "Notify"
                EnableDisableToolStrip(False, "LoadNotifyList")
            End If 'If snotifycritera <> "" Then
            'grdNotifyList.Width = 375
            'grdNotifyList.Height = 200
            LoadNotifyList = True
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: LoadNotifyList ")
            LoadNotifyList = False
        End Try
    End Function

    Private Sub grdUsers_AfterSelectChange(sender As Object, e As Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs) Handles grdUsers.AfterSelectChange
        Try
            LoadDetails()
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: grdUsers_AfterSelectChange ")
        End Try
    End Sub
    Private Function LoadPositions() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet

        Try
            If dbCalls.GetRecordsFromSP(ds, "spPositionsListGet") Then
                uComboPositions.DataSource = ds
                uComboPositions.DataBind()
            End If

            Dim ugc As UltraGridColumn

            ugc = uComboPositions.DisplayLayout.Bands(0).Columns("PositionID")
            ugc.Hidden = True

            LoadPositions = True
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: LoadPostions ")
            LoadPositions = False
        End Try
    End Function
    Private Function LoadSupervisors() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet

        Try
            If dbCalls.GetRecordsFromSP(ds, "spSupervisorListGet") Then
                uComboSupervisor.DataSource = ds
                uComboSupervisor.DataBind()
                ' uComboSupervisor.DisplayMember = "Supervisor"
                ' uComboSupervisor.ValueMember = "SupervisorID"
            End If
            'note order of list is important for search.  if you want to set value and find first column
            'first column must be what yuo want to show in text field.  can't have a hidden column first
            Dim ugc As UltraGridColumn

            ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("siID")
            ugc.Hidden = True
            ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("PositionID")
            ugc.Hidden = True
            'ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("ItemValue")
            'ugc.Hidden = True

            LoadSupervisors = True
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: LoadSupervisors ")
            LoadSupervisors = False
        End Try
    End Function
    Private Function LoadStates() As Boolean
        Dim ds As New DataSet
        Dim dbCalls As New DBCalls
        Dim dsPositions As New DataSet

        Try
            If dbCalls.GetRecordsFromSP(ds, "spGetStates") Then
                uComboState.DataSource = ds
                uComboState.DataBind()
            End If

            'Dim ugc As UltraGridColumn

            'ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("siID")
            'ugc.Hidden = True

            'ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("ItemValue")
            'ugc.Hidden = True

            LoadStates = True
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: LoadStates ")
            LoadStates = False
        End Try
    End Function
    Private Sub EnableDisableToolStrip(bEdit As Boolean, sCalledBy As String)
        Dim bCanEdit As Boolean
        Try
            bCanEdit = HasEditSecurity("mnuSecurity", "Menu") And Not bEdit 'mrb 9/16/16
            tsToolStrip.Items("tsBtnAdd").Enabled = bCanEdit
            tsToolStrip.Items("tsBtnEdit").Enabled = bCanEdit
            tsToolStrip.Items("tsBtnUndo").Enabled = bEdit
            tsToolStrip.Items("tsBtnSave").Enabled = bEdit
            tsToolStrip.Items("tsBtnPrint").Enabled = Not bEdit

            If Not bCanEdit Then
            End If

        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: EnableDisableToolStrip ")
        End Try
    End Sub
    Private Sub EnableDisableForm(bEdit As Boolean)
        grdUsers.Enabled = Not bEdit
        uteLName.ReadOnly = Not bEdit
        uteFName.ReadOnly = Not bEdit
        uteUserID.ReadOnly = Not bEdit
        utePassword.ReadOnly = Not bEdit
        uteAddress.ReadOnly = Not bEdit
        uteCell.ReadOnly = Not bEdit
        uteCity.ReadOnly = Not bEdit
        uteeMail.ReadOnly = Not bEdit
        uteFax.ReadOnly = Not bEdit
        utePhone.ReadOnly = Not bEdit
        uteRadio.ReadOnly = Not bEdit
        uTeZip.ReadOnly = Not bEdit

        uComboSupervisor.ReadOnly = Not bEdit
        uComboPositions.ReadOnly = Not bEdit
        uComboState.ReadOnly = Not bEdit

        uCheckBoss.Enabled = bEdit
        uCheckCA.Enabled = bEdit
        uCheckTest.Enabled = bEdit
        uCheckInactive.Enabled = bEdit
        uCheckBossman.Enabled = bEdit

    End Sub

    Private Sub tsBtnAdd_Click(sender As Object, e As System.EventArgs) Handles tsBtnAdd.Click
        Try
            '9/20/16 added field cleanout
            grdUsers.Selected.Rows.Clear() '9/20/16 mrb
            LoadNotifyList() '9/20/16 mrb this load is based on siid

            EnableDisableToolStrip(True, "tsBtnAdd_Click")
            EnableDisableForm(True)
            uteLName.Text = ""
            uteFName.Text = ""
            uteUserID.Text = ""
            utePassword.Text = ""
            uteAddress.Text = ""
            uteCell.Text = ""
            uteCity.Text = ""
            uteeMail.Text = ""
            uteFax.Text = ""
            utePhone.Text = ""
            uteRadio.Text = ""
            uTeZip.Text = ""

            uComboSupervisor.Value = ""
            uComboPositions.Value = ""
            uComboState.Value = ""

            uCheckBoss.Checked = vbFalse
            uCheckCA.Checked = vbFalse
            uCheckTest.Checked = vbFalse
            uCheckInactive.Checked = vbFalse
            uCheckBossman.Checked = vbTrue
        Catch ex As Exception
            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: tsBtnAdd_Click ")
        End Try

    End Sub

    Private Sub tsBtnEdit_Click(sender As Object, e As System.EventArgs) Handles tsBtnEdit.Click
        EnableDisableToolStrip(True, "tsBtnEdit_Click")
        EnableDisableForm(True)
    End Sub

    Private Sub tsBtnSave_Click(sender As Object, e As System.EventArgs) Handles tsBtnSave.Click
        'validate data - require entries userid, password, email, supervisor, first name, last name, position
        Dim oValidateT As Validation

        Try
            oValidateT = uv1.Validate("vgText")

            If oValidateT.IsValid Then
                'save record

                EnableDisableToolStrip(False, "tsBtnSave_Click")
                EnableDisableForm(False)
            Else
                MsgBox("You have incomplete fields.  Please complete and try again", MsgBoxStyle.Critical, "Validate User")
            End If
        Catch ex As Exception
            ShowError(ex.Message, False, "", "")
        End Try

    End Sub

    Private Sub tsBtnUndo_Click(sender As Object, e As System.EventArgs) Handles tsBtnUndo.Click
        EnableDisableToolStrip(False, "tsBtnUndo_Click")
        LoadDetails()

    End Sub
    Private Sub LoadDetails()
        Try
            LoadNotifyList()

            'If grdUsers.ActiveRow.Cells("Lname").Text <> "" Then
            uteLName.Text = grdUsers.ActiveRow.Cells("Lname").Text
            'End If
            'If grdUsers.ActiveRow.Cells("fname").Text <> "" Then
            uteFName.Text = grdUsers.ActiveRow.Cells("fname").Text
            'End If
            'If grdUsers.ActiveRow.Cells("userid").Text <> "" Then
            uteUserID.Text = grdUsers.ActiveRow.Cells("userid").Text
            'End If
            'If grdUsers.ActiveRow.Cells("password").Text <> "" Then
            utePassword.Text = grdUsers.ActiveRow.Cells("password").Text
            'End If
            uteAddress.Text = grdUsers.ActiveRow.Cells("address").Text
            uteCell.Text = grdUsers.ActiveRow.Cells("cell").Text
            uteCity.Text = grdUsers.ActiveRow.Cells("city").Text
            uteeMail.Text = grdUsers.ActiveRow.Cells("email").Text
            uteFax.Text = grdUsers.ActiveRow.Cells("fax").Text
            utePhone.Text = grdUsers.ActiveRow.Cells("hphone").Text
            uteRadio.Text = grdUsers.ActiveRow.Cells("radio").Text
            uTeZip.Text = grdUsers.ActiveRow.Cells("zip").Text

            uComboSupervisor.Value = grdUsers.ActiveRow.Cells("Supervisor").Text

            uComboPositions.Value = grdUsers.ActiveRow.Cells("Position").Text
            uComboState.Value = grdUsers.ActiveRow.Cells("st").Text

            uCheckBoss.Checked = grdUsers.ActiveRow.Cells("live").Value
            uCheckCA.Checked = grdUsers.ActiveRow.Cells("qa").Value
            uCheckTest.Checked = grdUsers.ActiveRow.Cells("test").Value
            uCheckInactive.Checked = grdUsers.ActiveRow.Cells("inactive").Value
        Catch ex As Exception

            ShowError(ex.Message, False, "BOSSAdmin", "UserMaintenance: LoadDetails")
        End Try

    End Sub
    Private Sub tsBtnPrint_Click(sender As Object, e As System.EventArgs) Handles tsBtnPrint.Click
        'print report
    End Sub


    Private Sub tsBtnAdd_Click1(sender As Object, e As EventArgs) Handles tsBtnAdd.Click

    End Sub

    Private Sub uv1_Validating(sender As Object, e As ValidatingEventArgs) Handles uv1.Validating
        If e.Control.Name = "uteeMail" Then
            If uteeMail.Text <> "" Then
                If Not Me.EmailRegEx.IsMatch(uteeMail.Text) Then
                    e.IsValid = False
                    e.ValidationSettings.NotificationSettings.Text = "Please reenter the email in a Valid Format."
                End If
            Else
                e.ValidationSettings.NotificationSettings.Text = "EMail is a required field."
            End If
        End If
    End Sub

    Private Sub uv1_ValidationError(sender As Object, e As Misc.ValidationErrorEventArgs) Handles uv1.ValidationError

    End Sub
End Class