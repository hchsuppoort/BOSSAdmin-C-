Imports System.Data.Entity.Migrations
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinEditors
Imports Infragistics.Win.UltraWinGrid

Public Class VendorCosts
    Dim bLoading As Boolean
    Dim sMode As String
    Dim sCalledBy As String

    Private Sub VendorCosts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetTaxDistrictList' table. You can move, or remove it, as needed.
        Me.SpGetTaxDistrictListTableAdapter.Fill(Me.HCHDataDSVendorCost.spGetTaxDistrictList)
        ''TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetOpenProjects' table. You can move, or remove it, as needed.
        Me.SpGetOpenProjectsTableAdapter.Fill(Me.HCHDataDSVendorCost.spGetOpenProjects)
        'TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetAlphaCodes' table. You can move, or remove it, as needed.
        Me.SpGetAlphaCodesTableAdapter.Fill(Me.HCHDataDSVendorCost.spGetAlphaCodes)
        'TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetVendorsInUse' table. You can move, or remove it, as needed.
        Me.SpGetVendorsInUseTableAdapter.Fill(Me.HCHDataDSVendorCost.spGetVendorsInUse)



    End Sub
    Private Sub EnableDisable(bEnable As Boolean)
        ucAlphaCodes.Enabled = bEnable
        ucDistricts.Enabled = bEnable
        ucProjects.Enabled = bEnable
        ucVendors.Enabled = bEnable

    End Sub

    Private Sub uceFilterByAlphaCode_CheckedChanged(sender As Object, e As EventArgs) Handles uceFilterByAlphaCode.CheckedChanged
        ucAlphaCodes.ActiveRow = Nothing
        ucAlphaCodes.Text = ""
        If uceFilterByAlphaCode.Checked = True Then
            ucAlphaCodes.Enabled = True
        Else
            ucAlphaCodes.Enabled = False
        End If

    End Sub

    Private Sub uceFilterByVendor_CheckedChanged(sender As Object, e As EventArgs) Handles uceFilterByVendor.CheckedChanged
        ucVendors.ActiveRow = Nothing
        ucVendors.Text = ""
        If uceFilterByVendor.Checked = True Then
            ucVendors.Enabled = True
        Else
            ucVendors.Enabled = False
        End If

    End Sub

    Private Sub UltraRadioButtonGroupManager3_SelectionChanged(sender As Object, e As RadioButtonGroupManagerSelectionChangedEventArgs) Handles UltraRadioButtonGroupManager3.SelectionChanged
        With ucDistricts
            .ActiveRow = Nothing
            .Text = ""
            .Enabled = False
        End With
        With ucProjects
            .ActiveRow = Nothing
            .Text = ""
            .Enabled = False
        End With
        Select Case e.NewSelectedRadioButton.Name
            Case "urbFilterByDistrict"
                ucDistricts.Enabled = True
            Case "urbFilterByProject"
                ucProjects.Enabled = True
            Case "urbFilterByGlobal"
                'do nothing
            Case Else
                'do nothing
        End Select


    End Sub

    Private Sub UltraRadioButtonGroupManager1_SelectionChanged(sender As Object, e As RadioButtonGroupManagerSelectionChangedEventArgs) Handles UltraRadioButtonGroupManager1.SelectionChanged
        With ucDistrictToCopy
            .ActiveRow = Nothing
            .Text = ""
            .Enabled = False
        End With
        With ucProjectToCopy
            .ActiveRow = Nothing
            .Text = ""
            .Enabled = False
        End With
        Select Case e.NewSelectedRadioButton.Name
            Case "urbFilterByDistrict"
                ucDistrictToCopy.Enabled = True
            Case "urbFilterByProject"
                ucProjectToCopy.Enabled = True
            Case "urbFilterByGlobal"
                'do nothing
            Case Else
                'do nothing
        End Select
    End Sub

    Private Sub utmAssignedVendors_ToolClick(sender As Object, e As Infragistics.Win.UltraWinToolbars.ToolClickEventArgs) Handles utmAssignedVendors.ToolClick
        Select Case e.Tool.Key
            Case "AddAlpha"
                AddAlpha()
            Case "ChangeCriteriaForVendor"    ' LabelTool
                changecriteriaforvendor

            Case "ChangeDates"    ' LabelTool
        ' Place code here

            Case "ChangeVendor"    ' LabelTool
        ' Place code here

            Case "CopyCriteria"    ' LabelTool
        ' Place code here

            Case "MarkAlternate"    ' LabelTool
        ' Place code here

            Case "UnmarkAlternate"    ' LabelTool
        ' Place code here

            Case "MarkPending"    ' LabelTool
        ' Place code here

            Case "NotPending"    ' LabelTool
        ' Place code here

            Case "PopupAssoignedVendors"    ' PopupMenuTool
                ' Place code here

        End Select

    End Sub

    Private Sub AddAlpha()
        Dim sStart As String
        Dim sEnd As String

        sMode = "AddAlpha"
        ucAddAlpha.Visible = True
        EnableDisableGrids(False, "AddAlpha")
        If sCalledBy = "AssignVendors" Then
            ucResources.Visible = True
        Else
            ucResources.Visible = False
        End If
        With Me.upAddAlpha
            .Visible = True
            ulUpdateCosts.Text = "Add Alpha Code to Selected Vendor"
        End With
        ' End If '
        sStart = "1/1/" & Today.Year.ToString & ""
        sEnd = "12/31/" & Today.Year.ToString & ""
        udtFromAddAlpha.Value = sStart '#1/1/2003#
        udtToAddAlpha.Value = sEnd ' #12/31/2003#
        upAddAlpha.Visible = True
        If ucAddAlpha.Rows.Count = 0 Then
            'fill table adapter
        End If
        ulCriteriaAddAlpha.Visible = False
        ulCriteria.Visible = False
        Exit Sub

    End Sub
    Private Sub EnableDisableGrids(bEnable As Boolean, pCalledBy As String)
        upFilters.Enabled = bEnable
        ugAssignedVendors.Enabled = bEnable
        Select Case pCalledBy
            Case "UpdateCost", "AddAlpha", "NewResources"
                ugCosts.Enabled = True And sCalledBy = "AssignVendors"
            Case "AssignNewVendor"
                ugCosts.Enabled = True And sCalledBy = "AssignVendors"
            Case "CopyCriteria"
                ugCosts.Enabled = True And sCalledBy = "AssignVendors"
            Case "MarkToDelete" '9/15/15
                ugCosts.Enabled = True
                ugCosts.DisplayLayout.Override.AllowUpdate = bEnable
            Case Else
                ugCosts.Enabled = bEnable
                ugCosts.DisplayLayout.Override.AllowUpdate = bEnable
        End Select
        tsToolStrip.Enabled = bEnable
    End Sub
    Private Sub ChangeCriteriaForVendor()
        Dim sAlphaCode As String
        Dim iAlphaID As Integer
        '    Dim sCriteria As String '5/11/17 mrb
        sMode = "ChangeCriteria"
        ulCopyToAnotherCriteria.Text = "Change Criteria for Selected Vendor"
        upCopyToAnotherCriteria.Visible = True
        upDates.Visible = False
        '    LoadTaxPermitDistricts ssdbCopyDistrict
        'LoadProjects ssdbCopyProject
        EnableDisableGrids(False, "ChangeCriteria")
        EnableDisableMenus(False)

        With ugAssignedVendors.ActiveRow
            sAlphaCode = .Cells("Alpha Code").Text & " - " & .Cells("Description").Text
            iAlphaID = .Cells("Alpha ID").Value
            ulAlphaCodeSelected.Text = sAlphaCode
            ulVendorSelected.Text = .Cells("Vendor").Text
            ' ulCriteriaSelected.Text = GetCriteria(ugAssignedVendors.ActiveRow) add this back
        End With

    End Sub
    Private Sub EnableDisableMenus(Enable As Boolean)

    End Sub
    Private Function GetCriteria() As String
        Dim sCriteria As String = ""

        With ugAssignedVendors.ActiveRow
            If .Cells("Project").Text <> "" Then
                sCriteria = .Cells("Project").Text
                urbProjects.Select()
            ElseIf .Cells("District").Text <> "" Then
                sCriteria = .Cells("District").Text
                urbDistricts.Select()
            ElseIf .Cells("Global").Value = vbNullString Then
                sCriteria = "Global"
                urbGlobal.Select()
            End If

        End With
        '  UltraRadioButtonGroupManager1_SelectionChanged() 'fix this
        GetCriteria = sCriteria

    End Function

    Private Sub upCopyToAnotherCriteria_PaintClient(sender As Object, e As PaintEventArgs) Handles upCopyToAnotherCriteria.PaintClient

    End Sub
End Class