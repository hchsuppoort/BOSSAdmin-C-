using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win;

using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class PlanEstimateTablesMaintenance
    {
        private string msPlanGroup;
        private string msElevation;
        private int miExteriorID;

        public PlanEstimateTablesMaintenance()
        {
            InitializeComponent();
        }

        // Private Property HCHDataPlanEstimateSetBindingSource As BindingSource
        // Private Property HCHDataPlanEstimateBindingSource As BindingSource

        private void PlanEstimateTablesMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HCHDataPlanEstimate.vwPlanEstimatePlanExteriors' table. You can move, or remove it, as needed.
            bool bCanEdit = modCommon.HasEditSecurity("mnuPlanEstimateTable", "Menu");
            // TODO: This line of code loads data into the 'HCHDataOptionsDataSet2.spPlanRoomsGet' table. You can move, or remove it, as needed.

            // add security 9/15/16
            if (bCanEdit)
            {
                ugPlanGroups.DisplayLayout.Bands[0].Override.AllowAddNew=AllowAddNew.Yes;
                ugPlanGroups.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.True;
                ugPlanGroups.DisplayLayout.Override.AllowAddNew=AllowAddNew.Yes;
                ugPlanGroups.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                ugPlanEstimateDetail.DisplayLayout.Bands[0].Override.AllowAddNew=AllowAddNew.Yes;
                ugPlanEstimateDetail.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.True;
                ugPlanEstimateDetail.DisplayLayout.Override.AllowAddNew=AllowAddNew.Yes;
                ugPlanEstimateDetail.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
            }
            else
            {
                ugPlanGroups.DisplayLayout.Bands[0].Override.AllowAddNew=AllowAddNew.No;
                ugPlanGroups.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.False;
                ugPlanGroups.DisplayLayout.Override.AllowAddNew=AllowAddNew.No;
                ugPlanGroups.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                ugPlanEstimateDetail.DisplayLayout.Bands[0].Override.AllowAddNew=AllowAddNew.No;
                ugPlanEstimateDetail.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.False;
                ugPlanEstimateDetail.DisplayLayout.Override.AllowAddNew=AllowAddNew.No;
                ugPlanEstimateDetail.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
            }
            btnAddRows.Enabled=bCanEdit;
            btnAddPlan.Enabled=bCanEdit;
            VwPlanEstimatePlanExteriorsTableAdapter1.Connection.ConnectionString=modGlobals.gsConnectionString;
            VwPlanEstimatePlanExteriorsTableAdapter1.Fill(HCHDataPlanEstimate.vwPlanEstimatePlanExteriors);

            bool bGoOn;
            try
            {
                bGoOn=LoadPlanExteriors();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical);

            }
        }
        private bool LoadPlanExteriors()
        {
            bool LoadPlanExteriorsRet = default;
            // Me.VwPlanEstimatePlanExteriorsTableAdapter.Fill(Me.HCHDataPlanEstimate.vwPlanEstimatePlanExteriors)

            // Me.VwPlanEstimatePlanExteriorsTableAdapter.Fill(Me.HCHDataPlanEstimateSet.vwPlanEstimatePlanExteriors)
            // 'HCHDataOptionsDataSetBindingSource.Sort = "PlanGroup, Elevation, ExteriorShortName"
            ugPlanGroups.DataBind();
            LoadPlanExteriorsRet=true;
            ugPlanGroups.DisplayLayout.Bands[0].SortedColumns.Add("PlanGroup", false, true);
            ugPlanGroups.DisplayLayout.Bands[0].SortedColumns.Add("Elevation", false, false);
            ugPlanGroups.DisplayLayout.Bands[0].SortedColumns.Add("ExteriorShortName", false, false);
            return LoadPlanExteriorsRet;
        }

        // Private Sub HCHDataOptionsDataSetBindingSource_CurrentChanged(sender As Object, e As EventArgs)

        // End Sub

        private void ugPlanGroups_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            ugPlanEstimateDetail.Visible=false;
        }

        private void ugPlanGroups_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }
        private void PopulateDetailGrid()
        {
            string sFilter = "";
            string sPlanGroup;
            string sElevation;
            string sExteriorID;
            try
            {
                if (ugPlanGroups.Selected.Rows.Count>0)
                {
                    foreach (UltraGridRow oRow in ugPlanGroups.Selected.Rows)
                    {
                        sPlanGroup=oRow.Cells["PlanGroup"].Text;
                        sElevation=oRow.Cells["Elevation"].Text;

                        sExteriorID=oRow.Cells["ExteriorID"].Text;
                        if (sFilter.Length>0)
                        {
                            sFilter+=" OR ";
                        }
                        sFilter+=" (p.PlanGroup=**"+sPlanGroup+"** and isnull(p.Elevation,****)=**"+sElevation+"**";
                        if (!string.IsNullOrEmpty(sExteriorID))
                        {
                            sFilter+=" and p.ExteriorID=**"+sExteriorID+"**";
                        }
                        sFilter+=")";
                    }
                }
                if (sFilter.Length>0)
                {
                    SpPlanEstimatesGetTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                    SpPlanEstimatesGetTableAdapter.Fill(DsDetail.spPlanEstimatesGet, sFilter);
                    ugPlanEstimateDetail.DataBind();
                }
                ugPlanEstimateDetail.Visible=true;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "PopulateDetailGrid");
            }
        }

        private void ugPlanEstimateDetail_AfterRowsDeleted(object sender, EventArgs e) // UltraGridRow
        {

            int iPlanEstimateID;
            try
            {
                foreach (DataRow row in DsDetail.Tables[0].Rows) // ugPlanEstimateDetail.Rows
                {
                    if (row.RowState==DataRowState.Deleted)
                    {
                        iPlanEstimateID=(int)(row["PlanEstimateID", DataRowVersion.Original]);
                        SpPlanEstimatesGetTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString; // 5/28/15
                        SpPlanEstimatesGetTableAdapter.spPlanEstimateDelete(iPlanEstimateID);   // row.Cells("PlanEstimateID").Value)
                    }
                }
                DsDetail.AcceptChanges();
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Error Deleting rows: "+ex.Message, MsgBoxStyle.Critical, "ugPlanEstimateDetail.AfterRowsDeleted");
            }


        }


        private void ugPlanEstimateDetail_AfterRowUpdate(object sender, RowEventArgs e)
        {
            try
            {
                string sResourceID = e.Row.Cells["ResourceID"].Text;
                int iPlanEstimateID = (int)(e.Row.Cells["PlanEstimateID"].Value);
                int iActivityCode = (int)(e.Row.Cells["ActivityCode"].Value);
                string sResUsage = e.Row.Cells["ResUsage"].Text;
                decimal cBudgetQty = Conversions.ToDecimal(e.Row.Cells["BudgetQty"].Value);
                string sNotes = e.Row.Cells["Notes"].Text;

                // Me.SpPlanEstimatesGetTableAdapter.spPlanEstimateUpdate(iPlanEstimateID, sResourceID, iActivityCode, sResUsage, cBudgetQty, gsUserID, sNotes)
                // Me.ugPlanEstimateDetail.UpdateData()
                // e.Row.Cells("UpdatedBy").Value = gsUserID
                // Me.ugPlanEstimateDetail.UpdateData()
                // Dim gCN2 As New System.Data.SqlClient.SqlConnection(BossAdmin.My.MySettings.HCHDataConnectionString)
                // spPlanEstimateUpdate (@PlanEstimateID, @ResourceID, @ActivityCode, @ResUsage, @BudgetQty, @UpdatedBy, @Notes)
                var cmd = new System.Data.SqlClient.SqlCommand();
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.CommandText="spPlanEstimateUpdate";
                cmd.Parameters.AddWithValue("@PlanEstimateID", iPlanEstimateID);
                cmd.Parameters.AddWithValue("@ResourceID", sResourceID);
                cmd.Parameters.AddWithValue("@ActivityCode", iActivityCode);
                cmd.Parameters.AddWithValue("@ResUsage", sResUsage);
                cmd.Parameters.AddWithValue("@BudgetQty", cBudgetQty);
                cmd.Parameters.AddWithValue("@Notes", sNotes);
                cmd.Parameters.AddWithValue("@Updatedby", modGlobals.gsUserID);
                cmd.Connection=modGlobals.gCN;
                // gCN.Open()
                cmd.ExecuteNonQuery();
            }
            // gCN.Close()

            // Me.DsDetail
            // DsDetail.AcceptChanges()
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Plan Estimate Maintenance: "+ex.Message, MsgBoxStyle.Critical, "ugPlanEstimateDetail_AfterRowUpdate");
            }
        }


        private void btnAddPlan_Click(object sender, EventArgs e)
        {


            try
            {
                My.MyProject.Forms.PlanEstimateAddRows.isAddNewPlan=true;
                miExteriorID=0;
                msPlanGroup="";
                msElevation="";

                if (My.MyProject.Forms.PlanEstimateAddRows.ShowDialog(this)==DialogResult.OK)
                {
                    msPlanGroup=My.MyProject.Forms.PlanEstimateAddRows.sPlanGroup;
                    msElevation=My.MyProject.Forms.PlanEstimateAddRows.sElevation;
                    miExteriorID=My.MyProject.Forms.PlanEstimateAddRows.iExteriorID;
                    LoadPlanExteriors();
                    My.MyProject.Forms.PlanEstimateAddRows.sPlanGroup="";
                    My.MyProject.Forms.PlanEstimateAddRows.sElevation="";
                    My.MyProject.Forms.PlanEstimateAddRows.iExteriorID=0;
                    // miExteriorID = 0
                    // msPlanGroup = ""
                    // msElevation = ""
                    // save records
                    // SpPlanEstimatesGetTableAdapter.spPlanEstimateInsert(iPlanGroup.ToString, sElevation, iExteriorID, gsUserID)
                    // PopulateDetailGrid()
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in BossAdmn "+ex.Message, MsgBoxStyle.Critical, "btnAddRows_Click");
            }

        }

        private void btnAddRows_Click1(object sender, EventArgs e)
        {
            // Dim iPlanGroup As Integer
            // Dim sElevation As String
            // Dim iExteriorID As Integer
            try
            {
                if (ugPlanGroups.Selected.Rows.Count>0&!(ugPlanGroups.Selected.Rows[0].Cells is null==true))
                {
                    msPlanGroup=ugPlanGroups.Selected.Rows[0].Cells["PlanGroup"].Text;
                    msElevation=ugPlanGroups.Selected.Rows[0].Cells["Elevation"].Text;
                    if (!string.IsNullOrEmpty(ugPlanGroups.Selected.Rows[0].Cells["ExteriorID"].Text))
                    {
                        //test this???
                        miExteriorID=(int)(ugPlanGroups.Selected.Rows[0].Cells["ExteriorID"].Value);
                    }
                    else
                    {
                        miExteriorID=0;
                    }

                    switch (ugPlanGroups.Selected.Rows.Count)
                    {
                        // Case 0
                        // MsgBox("Please select one Plan row in the Plan Selection grid to Add New Rows.", MsgBoxStyle.Information, "Add New Rows")
                        case var case1 when case1>1:
                            {
                                Interaction.MsgBox("Please select only ONE row in the Plan Selection grid to add new records.", MsgBoxStyle.Information, "Add New Rows");
                                break;
                            }

                        default:
                            {
                                {
                                    var withBlock = My.MyProject.Forms.PlanEstimateAddRows;
                                    withBlock.uLblPlan.Text=msPlanGroup;
                                    withBlock.uLblElevation.Text=msElevation;
                                    withBlock.uLblExterior.Text=ugPlanGroups.Selected.Rows[0].Cells["ExteriorName"].Text;
                                    withBlock.iExteriorID=miExteriorID;
                                    withBlock.isAddNewPlan=false;
                                }
                                if (My.MyProject.Forms.PlanEstimateAddRows.ShowDialog(this)==DialogResult.OK)
                                {
                                    // save records
                                    // SpPlanEstimatesGetTableAdapter.spPlanEstimateInsert(iPlanGroup.ToString, sElevation, iExteriorID, gsUserID)
                                    PopulateDetailGrid();
                                    miExteriorID=0;
                                    msPlanGroup="";
                                    msElevation="";
                                }

                                break;
                            }
                    }
                }
                else
                {
                    Interaction.MsgBox("Please select one Plan Detail row in the Plan Selection grid to Add New Rows.", MsgBoxStyle.Information, "Add New Rows");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in BossAdmn "+ex.Message, MsgBoxStyle.Critical, "btnAddRows_Click");
            }

        }

        private void btnPopulateDetail_Click1(object sender, EventArgs e)
        {
            if (ugPlanGroups.Selected.Rows.Count>0) // added 5/10/15
            {
                if (!(ugPlanGroups.Selected.Rows[0].Cells is null==true)) // 10/21/14
                {
                    PopulateDetailGrid();
                }
            }
            else
            {
                Interaction.MsgBox("Please select a row in the Plan Group grid to Populate the Plan Estimate Detail grid.");
            }
        }


    }
}