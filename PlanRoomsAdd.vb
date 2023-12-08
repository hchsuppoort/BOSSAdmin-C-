Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class PlanRoomsAdd
    Private PlanGroups As HCHDataDataSet
    Private Sub PlanRoomsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HCHDataRooms.vwRooms' table. You can move, or remove it, as needed.
        VwRoomsTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.VwRoomsTableAdapter.Fill(Me.HCHDataRooms.vwRooms)
        'If ulvRooms.Items.Count = 0 Then
        '    PopulateItemsCollection(Me.HCHDataRooms.vwRooms)
        'Else
        '    SelectAllRooms(True)
        'End If
        'Me.SpPlanRoomsGetTableAdapter.Fill(Me.HCHDataPlanRoomsData.spPlanRoomsGet)
        VwPlanGroupsTableAdapter.Connection.ConnectionString = gsConnectionString
        Me.VwPlanGroupsTableAdapter.Fill(Me.HCHDataDataSet.vwPlanGroups)
        'uddPlanGroup.DataBind()
        'uddPlanGroup.Visible = True
        'TODO: This line of code loads data into the 'HCHDataPlanRoomsData.spPlanRoomsGet' table. You can move, or remove it, as needed.
        'uddRooms.DataBind()
        'TODO: This line of code loads data into the 'HCHDataDataSet.vwPlanGroups' table. You can move, or remove it, as needed.
        'Me.VwPlanGroupsTableAdapter.Fill(Me.HCHDataDataSet.vwPlanGroups)
        'uddRooms.Visible = True
    End Sub
    'Private Sub SelectAllRooms(ByRef bSelect As Boolean)
    '    Dim IsChecked As CheckState
    '    If bSelect Then
    '        IsChecked = CheckState.Checked
    '    Else
    '        IsChecked = CheckState.Unchecked
    '    End If
    '    Dim roomItem As UltraListViewItem
    '    For Each roomItem In ulvRooms.Items
    '        roomItem.CheckState = IsChecked
    '    Next
    'End Sub
    'Private Sub PopulateItemsCollection(ByVal roomsTable As DataTable)

    '    Dim dataRow As DataRow
    '    '  Dim dataColumn As DataColumn


    '    '	Populate the Items collection from the Rows collection of the 'Orders' table.
    '    For Each dataRow In roomsTable.Rows

    '        '	Add an UltraListViewItem for this order, using the value of the
    '        '	'OrderID' field for the item's Value

    '        Dim roomitem As UltraListViewItem = ulvRooms.Items.Add(dataRow("ResUsage"), dataRow("ResUsage"))
    '        roomitem.CheckState = CheckState.Checked

    '        '	Set the values for the UltraListViewItem's SubItems. Note that we
    '        '	can use an UltraListViewSubItemColumn instance to index into the
    '        '	SubItemColumns collection, and use the stored reference to the underlying
    '        '	DataColumn to index into the DataRow's columns.
    '        'Dim subItemColumn As UltraListViewSubItemColumn
    '        'For Each subItemColumn In ulvRooms.SubItemColumns

    '        '    dataColumn = CType(subItemColumn.Tag, DataColumn)
    '        '    Dim subItem As UltraListViewSubItem = orderItem.SubItems(subItemColumn)
    '        '    subItem.Value = dataRow(dataColumn)

    '        '    '	Assign the Appearance we created for this shipper to the
    '        '    '	UltraListViewSubItem's Appearance.
    '        '    'If subItem.Key = "ShipVia" Then subItem.Appearance = ulvRooms.Appearances(subItem.Text)
    '        'Next

    '        '	Assign the UltraListViewGroup which represents this order's customer
    '        '	to the item's Group property.
    '        'Dim customerID As String = CType(dataRow("CustomerID"), String)
    '        'orderItem.Group = ulvRooms.Groups(customerID)
    '    Next

    'End Sub

   

   
  

    'Private Sub ucSelectAll_CheckStateChanged(sender As Object, e As EventArgs)
    '    Dim bChecked As Boolean = ucSelectAll.CheckState = CheckState.Checked
    '    SelectAllRooms(bChecked)
    'End Sub

    Private Sub ubtnSaveNewPlanRooms_Click(sender As Object, e As EventArgs) Handles ubtnSaveNewPlanRooms.Click
        'save each row of grid with quantities
        Try
            Dim oRow As UltraGridRow
            '
            SpPlanRoomsGetTableAdapter.Connection.ConnectionString = gsConnectionString
            Dim iSqFt As Int16
            Dim ilftrim As Int16
            Dim sResUsage As String
            Dim sPlanId As String

            For Each oRow In UltraGrid1.Rows
                If oRow.Cells("sqft").Text <> "" Then
                    ' save this one
                    iSqFt = oRow.Cells("sqft").Value
                    ilftrim = oRow.Cells("lftrim").Value
                    sResUsage = oRow.Cells("ResUsage").Text
                    sPlanId = ucPlanGroups.Text
                    SpPlanRoomsGetTableAdapter.spPlanRoomsInsert(sPlanId, sResUsage, gsUserID, iSqFt, ilftrim, 0)
                End If
            Next
            MsgBox("New Plan Rooms saved.")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox("Error saving new Plan Rooms: " & ex.Message, MsgBoxStyle.Critical, "ubtnSaveNewPlanRooms_Click")
        End Try

    End Sub
End Class