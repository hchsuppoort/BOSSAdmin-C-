using System;
using System.Windows.Forms;
using BossAdmin.dsDetailTableAdapters;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{


    public partial class PlanEstimateAddRows
    {
        public bool isAddNewPlan;
        public int iExteriorID;
        public string sElevation;
        public string sPlanGroup;

        private bool isOK;
        private MouseButtons _theButton = MouseButtons.None;
        internal spPlanEstimatesGetTableAdapter PostPlanItems;

        public PlanEstimateAddRows()
        {
            InitializeComponent();
        }
        private void PlanEstimateAddRows_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Me.UltraGrid1.PerformAction(UltraGridAction.DeleteRows)
            // Dim icount As Integer = UltraGrid1.Rows.Count
            UltraGrid1.DataSource=null; // 10/20/14
            HCHDataOptionsDataPlanEstimateAdd.Clear(); // 10/20/14
                                                       // Me.DialogResult = Windows.Forms.DialogResult.OK
        }
        private void PlanEstimateAddRows_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HCHDataDataSet2.ProjectExterior' table. You can move, or remove it, as needed.
            ProjectExteriorTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
            ProjectExteriorTableAdapter.Fill(HCHDataDataSet2.ProjectExterior);
            // TODO: This line of code loads data into the 'HCHDataDataSet1.PlanElevations() ' table. You can move, or remove it, as needed.
            PlanElevationsTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
            PlanElevationsTableAdapter.Fill(HCHDataDataSet1.PlanElevations);
            // TODO: This line of code loads data into the 'HCHDataDataSet.vwPlanGroups' table. You can move, or remove it, as needed.
            VwPlanGroupsTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
            VwPlanGroupsTableAdapter.Fill(HCHDataDataSet.vwPlanGroups);
            // TODO: This line of code loads data into the 'HCHDataOptionsDataPlanEstimateAdd.PlanEstimate' table. You can move, or remove it, as needed.
            if (isAddNewPlan==false) // called by add rows
            {
                lblConnection.Text=modGlobals.gsConnectionString; // 5/28/15 mrb for testing
                PlanEstimateTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                PlanEstimateTableAdapter.Fill(HCHDataOptionsDataPlanEstimateAdd.PlanEstimate);
                pnlNewPlan.Visible=false;
                ulAddNewPlan.Visible=false;
                pnlAddNewRows.Visible=true;
            }
            else // called by add new plan
            {
                uceElevation.SelectedText="";
                uceExterior.SelectedText="";
                ucePlanGroup.SelectedText="";
                lblConnection.Text=modGlobals.gsConnectionString; // 5/28/15 mrb for testing
                PlanEstimateTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                PlanEstimateTableAdapter.Fill(HCHDataOptionsDataPlanEstimateAdd.PlanEstimate);
                pnlNewPlan.Visible=true;
                ulAddNewPlan.Visible=true;
                pnlAddNewRows.Visible=false;
            }
            UltraGrid1.DataSource=HCHDataOptionsDataPlanEstimateAdd; // 10/20/14
            UltraGrid1.DataBind(); // 10/20/14

        }

        private void UltraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            try
            {
                switch (e.Tool.Key??"")
                {
                    case "Undo":
                        {
                            UltraGrid1.PerformAction(UltraGridAction.Undo);
                            break;
                        }
                    case "Redo":
                        {
                            UltraGrid1.PerformAction(UltraGridAction.Redo);
                            break;
                        }
                    case "Copy":
                        {
                            UltraGrid1.PerformAction(UltraGridAction.Copy);
                            break;
                        }
                    case "Paste":
                        {
                            UltraGrid1.PerformAction(UltraGridAction.Paste);
                            break;
                        }
                    case "Cut":
                        {
                            UltraGrid1.PerformAction(UltraGridAction.Cut);
                            break;
                        }
                    case "Delete":
                        {
                            UltraGrid1.PerformAction(UltraGridAction.DeleteCells);
                            break;
                        }
                    case "Select All":
                        {
                            foreach (UltraGridRow row in UltraGrid1.Rows.GetRowEnumerator(GridRowType.DataRow, null, null))
                                row.Selected=true;
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Plan Estimate - Add Rows.  Error: "+ex.Message, MsgBoxStyle.Critical, "UltraToobarsManager1_ToolClick"); // 10/20/14
            }

        }

        // Private Sub UltraGrid1_MouseDown(sender As Object, e As MouseEventArgs)
        // '_theButton = e.Button
        // End Sub

        // Private Sub UltraGrid1_Click(sender As Object, e As EventArgs) Handles UltraGrid1.Click
        // 'If we Right Click, show the Context Menu 
        // 'If _theButton = MouseButtons.Right Then
        // '    Me.UltraToolbarsManager1.ShowPopup("Edit")
        // 'End If
        // End Sub

        // Private Sub UltraGrid1_PressAndHoldGesture(sender As Object, e As Infragistics.Win.Touch.PressAndHoldGestureEventArgs) Handles UltraGrid1.PressAndHoldGesture
        // 'context menu
        // 'Me.UltraToolbarsManager1.ShowPopup("Edit")
        // End Sub

        private void btnSave_Click(object sender, EventArgs e)
        {
            var PostPlanItems = new spPlanEstimatesGetTableAdapter();
            if (isAddNewPlan)
            {
                sPlanGroup=ucePlanGroup.Text;
                sElevation=uceElevation.Text.ToLower();
                iExteriorID=(int)(uceExterior.Value); // .GetItemText("ExteriorID")
            }
            else
            {
                sPlanGroup=uLblPlan.Text;
                sElevation=Strings.Trim(uLblElevation.Text);
            } // 5/28/15 mrb was causing issue with a space in it
            if (string.IsNullOrEmpty(sPlanGroup)) // not ready to save 10/17/14
            {
                Interaction.MsgBox("Please select a Plan Group", MsgBoxStyle.Exclamation, "Save Rows");
            }
            else if (!string.IsNullOrEmpty(sElevation)&iExteriorID==0|string.IsNullOrEmpty(sElevation)&iExteriorID!=0) // both must be selected or neither selected              
            {
                Interaction.MsgBox("If you select an Elevation, you must also select an Exterior.  Otherwise both must be blank", MsgBoxStyle.Exclamation, "Save Rows");
            }
            else
            {
                PostPlanItems.Connection.ConnectionString=modGlobals.gsConnectionString;
                PlanEstimateTableAdapter.Update(HCHDataOptionsDataPlanEstimateAdd);
                PostPlanItems.spPlanEstimateInsert(sPlanGroup, sElevation, iExteriorID, modGlobals.gsUserID);
                DialogResult=DialogResult.OK;
                Close();
            }

        }



    }
}