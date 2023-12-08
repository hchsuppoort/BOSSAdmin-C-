Imports Infragistics.Shared
Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Public Class PlanRoomsMaintenance

    Private Sub PlanRoomsMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim bCanEdit As Boolean = HasEditSecurity("mnuTakeOffTable", "Menu")
        'TODO: This line of code loads data into the 'HCHDataOptionsDataSet2.spPlanRoomsGet' table. You can move, or remove it, as needed.
        Me.SpPlanRoomsGetTableAdapter.Connection.ConnectionString = gsConnectionString
        'Me.SpPlanRoomsGetTableAdapter.Connection.Open()
        Me.SpPlanRoomsGetTableAdapter.Fill(Me.HCHDataPlanRoomsData.spPlanRoomsGet)
        Me.ubtnAddNewPlan.Enabled = bCanEdit
        'add security 9/15/16
        If bCanEdit Then
            Me.UltraGrid1.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.Yes
            Me.UltraGrid1.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.True
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
        Else
            Me.UltraGrid1.DisplayLayout.Bands(0).Override.AllowAddNew = AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Bands(0).Override.AllowUpdate = DefaultableBoolean.False
            Me.UltraGrid1.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
            Me.UltraGrid1.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
        End If

    End Sub

    Private Sub ubtnAddNewPlan_Click(sender As Object, e As EventArgs) Handles ubtnAddNewPlan.Click
        If PlanRoomsAdd.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Me.SpPlanRoomsGetTableAdapter.Fill(Me.HCHDataPlanRoomsData.spPlanRoomsGet)
            UltraGrid1.DataBind()
        End If
    End Sub

    Private Sub UltraGrid1_AfterRowUpdate(sender As Object, e As Infragistics.Win.UltraWinGrid.RowEventArgs) Handles UltraGrid1.AfterRowUpdate
        SpPlanRoomsGetTableAdapter.Update(HCHDataPlanRoomsData.spPlanRoomsGet)
    End Sub
End Class