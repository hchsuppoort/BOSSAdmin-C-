using System;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace BossAdmin
{
    public partial class PlanRoomsMaintenance
    {
        public PlanRoomsMaintenance()
        {
            InitializeComponent();
        }

        private void PlanRoomsMaintenance_Load(object sender, EventArgs e)
        {
            bool bCanEdit = modCommon.HasEditSecurity("mnuTakeOffTable", "Menu");
            // TODO: This line of code loads data into the 'HCHDataOptionsDataSet2.spPlanRoomsGet' table. You can move, or remove it, as needed.
            SpPlanRoomsGetTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
            // Me.SpPlanRoomsGetTableAdapter.Connection.Open()
            SpPlanRoomsGetTableAdapter.Fill(HCHDataPlanRoomsData.spPlanRoomsGet);
            ubtnAddNewPlan.Enabled=bCanEdit;
            // add security 9/15/16
            if (bCanEdit)
            {
                UltraGrid1.DisplayLayout.Bands[0].Override.AllowAddNew=AllowAddNew.Yes;
                UltraGrid1.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.True;
                UltraGrid1.DisplayLayout.Override.AllowAddNew=AllowAddNew.Yes;
                UltraGrid1.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
            }
            else
            {
                UltraGrid1.DisplayLayout.Bands[0].Override.AllowAddNew=AllowAddNew.No;
                UltraGrid1.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.False;
                UltraGrid1.DisplayLayout.Override.AllowAddNew=AllowAddNew.No;
                UltraGrid1.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
            }

        }

        private void ubtnAddNewPlan_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.PlanRoomsAdd.ShowDialog(this)==DialogResult.OK)
            {
                SpPlanRoomsGetTableAdapter.Fill(HCHDataPlanRoomsData.spPlanRoomsGet);
                UltraGrid1.DataBind();
            }
        }

        private void UltraGrid1_AfterRowUpdate(object sender, RowEventArgs e)
        {
            SpPlanRoomsGetTableAdapter.Update(HCHDataPlanRoomsData.spPlanRoomsGet);
        }
    }
}