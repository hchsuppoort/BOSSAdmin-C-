using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class CostAnalysisPlanChooser
    {
        public string msPlanProjectID;
        private Infragistics.Win.UltraWinEditors.UltraOptionSet msOptions = new Infragistics.Win.UltraWinEditors.UltraOptionSet();

        public CostAnalysisPlanChooser()
        {
            InitializeComponent();
        }
        // Dim mdsData As New DataSet()
        // Dim msPathCost As String
        private DataSet GenerateEmptyPlanDataSet()
        {
            var dsData = new DataSet();
            var dtData = new DataTable();

            dtData.Columns.Add(new DataColumn("PlanID", typeof(string)));
            dtData.Columns.Add(new DataColumn("FileName", typeof(string)));
            dtData.Columns.Add(new DataColumn("PlanEstimate", typeof(bool)));
            dtData.Columns.Add(new DataColumn("Source"));
            dtData.Columns.Add(new DataColumn("Use"));
            dsData.Tables.Add(dtData);

            dtData=null;

            return dsData;

        }
        private bool IsInEstimateTable(string sPlanID)
        {
            bool IsInEstimateTableRet = default;
            var rs = new DataSet();
            var dbCalls = new DBCalls();
            try
            {
                IsInEstimateTableRet=dbCalls.GetDataFromSP(ref rs, "spPlanInEstimateTable", sPlanID);
                if (rs.Tables.Count>0)
                {
                    if (rs.Tables[0].Rows.Count>0)
                    {
                        IsInEstimateTableRet=Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(rs.Tables[0].Rows[0][0], 1, false));
                    }
                    else
                    {
                        Interaction.MsgBox("No Records in Plan Estimate table for this plan", MsgBoxStyle.Information, "IsInEstimateTable");
                        IsInEstimateTableRet=false;
                    }
                }
                else
                {
                    IsInEstimateTableRet=false;
                    Interaction.MsgBox(modGlobals.gCN.ConnectionString, MsgBoxStyle.Critical, "IsInEstimateTable");
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error checking for estimate "+ex.Message, MsgBoxStyle.Critical, "IsInEstimateTable");
                IsInEstimateTableRet=false;
            }
            finally
            {
                rs=null;
                dbCalls=null;
            }

            return IsInEstimateTableRet;
        }
        private void CostAnalysisPlanChooser_FormClosing(object sender, FormClosingEventArgs e)
        {
            UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Add("PlanID", false);
        }

        private void CostAnalysisPlanChooser_Load(object sender, EventArgs e)
        {
            if (modGlobals.gsCostAnalysisData is null)
            {
                modGlobals.gsCostAnalysisData=new DataSet();
                modGlobals.gsCostAnalysisData=GenerateEmptyPlanDataSet();
            }
            UltraGrid1.DataSource=modGlobals.gsCostAnalysisData;
            UltraGrid1.DataBind();
            UltraGrid1.DisplayLayout.Bands[0].Columns["FileName"].Width=300;
            UltraGrid1.DisplayLayout.Bands[0].Columns["Planid"].Width=60;
            {
                var withBlock = UltraGrid1.DisplayLayout.Bands[0];
                withBlock.Columns["PlanEstimate"].Width=60;
                withBlock.Columns["PlanEstimate"].Header.Caption="Plan Estimate";
                withBlock.Columns["FileName"].Header.Caption="File Name";
                withBlock.Columns["PlanID"].Header.Caption="Plan";
                withBlock.Columns["Use"].Width=150;
                withBlock.Columns["Source"].Width=100;
                withBlock.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.True;
            }
            var valueListItem1 = new Infragistics.Win.ValueListItem();
            var valueListItem2 = new Infragistics.Win.ValueListItem();
            var valueListItem3 = new Infragistics.Win.ValueListItem();

            // Assign a data value for each option
            valueListItem1.DataValue="Plan Estimate";
            valueListItem2.DataValue="File";
            valueListItem3.DataValue="Do Not Use";

            // Assign the text which will be displayed within the UltraGrid for each option
            valueListItem1.DisplayText="Plan Estimate";
            valueListItem2.DisplayText="File";
            valueListItem3.DisplayText="Do Not Use";

            // Add each ValueListItem object to the items collection of the ultraOptionSet
            msOptions.Items.AddRange(new Infragistics.Win.ValueListItem[] { valueListItem1, valueListItem2, valueListItem3 });

            // Set the UltraOptionSet instance as the EditorComponent for the first column of the UltraGrid
            UltraGrid1.DisplayLayout.Bands[0].Columns["Use"].EditorComponent=msOptions;
            modCommon.GetCostPlanPath();

        }

        private void btnProjectPlans_Click(object sender, EventArgs e)
        {
            var dsData = new DataSet();
            // Dim vInPlanEstimate As VariantType
            var dbCalls = new DBCalls();
            string sPlanId;
            string sPath;
            bool bInEstimate;
            bool bInFolder = false;
            try
            {
                Enabled=false;
                My.MyProject.Forms.mdiMain.UseWaitCursor=true;
                if (dbCalls.GetDataFromSP(ref dsData, "spGetPlansForProject", msPlanProjectID, 1))
                {
                    // populate grid
                    foreach (DataRow dRow in dsData.Tables[0].Rows)
                    {
                        // check for files and plan estimate rows
                        sPlanId=(string)(dRow["PlanId"]);
                        // If sPlanId = "2554ab" Then
                        // sPlanId = "2554ab"
                        // End If
                        // If vInPlanEstimate = Nothing Then
                        // bInEstimate = False
                        // Else
                        // bInEstimate = True
                        // End If
                        // 12/2/14 mrb
                        bInEstimate=IsInEstimateTable(sPlanId);
                        sPath=modGlobals.gsPathCost+@"\"+sPlanId+".xlsx";
                        if (modCommon.FileExists(sPath))
                        {
                            bInFolder=true;
                        }
                        else
                        {
                            bInFolder=false;
                            sPath="";
                        }
                        {
                            var withBlock = UltraGrid1;
                            if (bInEstimate==false)
                            {
                                if (bInFolder)
                                {
                                    modGlobals.gsCostAnalysisData.Tables[0].Rows.Add(new object[] { sPlanId, sPath, bInEstimate, "Project Plans", "File" });
                                }
                                else
                                {
                                    modGlobals.gsCostAnalysisData.Tables[0].Rows.Add(new object[] { sPlanId, sPath, bInEstimate, "Project Plans" });
                                }
                            }
                            else
                            {
                                modGlobals.gsCostAnalysisData.Tables[0].Rows.Add(new object[] { sPlanId, sPath, CheckState.Checked, "Project Plans", "Plan Estimate" });
                            }

                        }
                    }
                    UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Add("PlanID", false);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Loading Project Plans: "+ex.Message, MsgBoxStyle.Critical, "btnProjectPlans_Click");
            }
            finally
            {
                Enabled=true;
                My.MyProject.Forms.mdiMain.UseWaitCursor=true;
            }
        }

        private void btnPlansFromFolder_Click(object sender, EventArgs e)
        {
            // Dim vInPlanEstimate As VariantType
            bool bInEstimate;
            string sPlanID;
            string sPath;
            var dbCalls = new DBCalls();
            try
            {
                // GetCostPlanPath()
                Enabled=false;
                My.MyProject.Forms.mdiMain.UseWaitCursor=true;
                var diSource = new DirectoryInfo(modGlobals.gsPathCost);
                if (Directory.Exists(modGlobals.gsPathCost)==true)
                {
                    // Copy each file into it's new directory. 
                    foreach (FileInfo fi in diSource.GetFiles())
                    {
                        if (fi.Extension==".xlsx")
                        {
                            sPlanID=fi.Name.Replace(".xlsx", "");
                            // vInPlanEstimate = dbCalls.GetReturnValueFromSP("spPlanInEstimateTable", sPlanID)
                            bInEstimate=IsInEstimateTable(sPlanID); // 12/2/14

                            sPath=fi.FullName;
                            // If vInPlanEstimate = Nothing Then
                            // bInEstimate = False
                            // Else
                            // bInEstimate = True
                            // End If
                            {
                                var withBlock = UltraGrid1;
                                if (bInEstimate==false)
                                {
                                    modGlobals.gsCostAnalysisData.Tables[0].Rows.Add(new object[] { sPlanID, sPath, bInEstimate, "CostPlan Folder", "File" });
                                }
                                else
                                {
                                    modGlobals.gsCostAnalysisData.Tables[0].Rows.Add(new object[] { sPlanID, sPath, CheckState.Checked, "CostPlan Folder", "Plan Estimate" });
                                }
                            }
                        }
                    }
                    UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Add("PlanID", false);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error listing plan files in folder: "+ex.Message, MsgBoxStyle.Critical, "btnPlansFromFolder_Click");
            }
            finally
            {
                Enabled=true;
                My.MyProject.Forms.mdiMain.UseWaitCursor=false;
            }
        }

        private void UltraGrid1_AfterCellUpdate(object sender, CellEventArgs e)
        {
            if (e.Cell.Column.Key=="PlanID"&!string.IsNullOrEmpty(e.Cell.Text))
            {
                if (IsInEstimateTable(e.Cell.Text))
                {
                    UltraGrid1.DisplayLayout.ActiveRow.Cells["PlanEstimate"].Value=CheckState.Checked;
                    UltraGrid1.DisplayLayout.ActiveRow.Cells["Use"].Value="Plan Estimate";
                }
                else
                {
                    UltraGrid1.DisplayLayout.ActiveRow.Cells["PlanEstimate"].Value=CheckState.Unchecked;
                }
            }
        }

        private void UltraGrid1_AfterRowInsert(object sender, RowEventArgs e)
        {
            UltraGrid1.DisplayLayout.ActiveRow.Cells["Source"].Value="User Added";

        }


        private void btnSavePlans_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClearAllPlans_Click(object sender, EventArgs e)
        {
            modGlobals.gsCostAnalysisData=null;
            modGlobals.gsCostAnalysisData=GenerateEmptyPlanDataSet();
            UltraGrid1.DataSource=modGlobals.gsCostAnalysisData;
            UltraGrid1.DataBind();

        }
    }
}