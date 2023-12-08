using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public partial class CostAnalysisSearch
    {
        private long miAnalysisID;
        private string msProjectID;

        public CostAnalysisSearch()
        {
            InitializeComponent();
        }
        private void CostAnalysisSearch_Load(object sender, EventArgs e)
        {
            GetDataDate();
            LoadSearchGrid();
            // Me.SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.Tables(0))
            // UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Clear()
            // UltraGrid1.DisplayLayout.Bands(0).SortedColumns.Add("AnalysisDate", True)
            // UltraGrid1.DataBind()

        }



        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            // CostAnalysisDetail.miAnalysisID = 0
            var mDetailForm = new CostAnalysisDetail(this);

            // CostAnalysisDetail.ShowDialog()
            mDetailForm.miAnalysisID=0L;
            mDetailForm.ShowDialog();
        }
        private void GetDataDate()
        {
            DBCalls cDB;
            var ds = new DataSet();

            try
            {
                cDB=new DBCalls();
                DateTime sDate;
                if (cDB.GetRecordsFromSP(ref ds, "spCostAnalysisDateGet"))
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        sDate=Conversions.ToDate(row["UpdateEnded"].ToString());
                        tsLblLastReloadDate.Text="Last Reload Date: "+Conversions.ToString(sDate);
                    }
                }
            }

            // ds = Nothing
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbCritical, "GetDataDate");
            }
            finally
            {
                cDB=null;
                ds=null;
            }
        }

        private void tsBtnReloadData_Click(object sender, EventArgs e)
        {
            Enabled=false;
            modCommon.ReloadCostAnalysisData();
            Enabled=true;
            GetDataDate();
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            modCommon.ShowPDFHelp(Application.StartupPath+@"\BOSS Cost Analysis.pdf");
        }

        private void tsBtnRefreshGrid_Click(object sender, EventArgs e)
        {
            LoadSearchGrid();

        }
        internal void LoadSearchGrid()
        {
            SpGetAnalysesSummaryTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
            SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.spGetAnalysesSummary);
            UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Clear();
            UltraGrid1.DisplayLayout.Bands[0].SortedColumns.Add("AnalysisDate", true);
            UltraGrid1.DataBind();

        }
        private void UltraGrid1_Click(object sender, EventArgs e)
        {
            if (UltraGrid1.Selected.Rows.Count>0)
            {
                miAnalysisID=Conversions.ToLong(UltraGrid1.Selected.Rows[0].Cells["AnalysisID"].Value);
                msProjectID=Conversions.ToString(UltraGrid1.Selected.Rows[0].Cells["ProjectID"].Value);
                tsBtnPrint.Enabled=true;
                btnPrintRpt2.Enabled=true;
            }
            else
            {
                tsBtnPrint.Enabled=false;
                btnPrintRpt2.Enabled=false;

            }
        }

        private void tsBtnDelete_Click(object sender, EventArgs e)
        {
            var dbCalls = new DBCalls();
            long lRtn;
            long iAnalysisID;

            try
            {
                if (UltraGrid1.Selected.Rows.Count<1)
                {
                    // If MsgBox("Are you sure you want to delete the selected rows?", MsgBoxStyle.YesNo, "Delete Rows from Cost Analysis") = MsgBoxResult.Yes Then
                    // For Each oRow In UltraGrid1.Selected.Rows
                    // iAnalysisID = oRow.Cells("AnalysisID").Value
                    // lRtn = dbCalls.GetReturnValueFromSP("spCostAnalysisDelete", iAnalysisID)
                    // Next
                    // SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.Tables(0))
                    // UltraGrid1.DataBind()
                    // UltraGrid1.ActiveRow = Nothing
                    // UltraGrid1.Selected.Rows.Clear()

                    // End If
                    Interaction.MsgBox("You must select rows to delete Cost Analysis records", MsgBoxStyle.OkOnly, "tsBtnDelete_Click");
                }
                else if (Interaction.MsgBox("Are you sure you want to delete the selected rows?", MsgBoxStyle.YesNo, "Delete Rows from Cost Analysis")==MsgBoxResult.Yes) // apparently lost my mind 10/27/15 mrb move down into proper end of if statement
                {
                    foreach (UltraGridRow oRow in UltraGrid1.Selected.Rows)
                    {
                        iAnalysisID=Conversions.ToLong(oRow.Cells["AnalysisID"].Value);
                        lRtn=(long)dbCalls.GetReturnValueFromSP("spCostAnalysisDelete", iAnalysisID);
                    }
                    SpGetAnalysesSummaryTableAdapter.Fill(HCHDataCostAnalysis.spGetAnalysesSummary);
                    UltraGrid1.DataBind();
                    UltraGrid1.ActiveRow=null;
                    UltraGrid1.Selected.Rows.Clear();

                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error Deleting Analysis records: "+ex.Message, MsgBoxStyle.Critical, "tsBtnDelete_Click");
            }
            finally
            {
                dbCalls=null;
            }
        }

        private void UltraGrid1_DoubleClick(object sender, EventArgs e)
        {
            long iAnalysisID;
            var mDetailForm = new CostAnalysisDetail(this);

            try
            {
                if (UltraGrid1.Selected.Rows.Count>0)
                {

                    Enabled=false;
                    if (UltraGrid1.Selected.Rows.Count>0)
                    {
                        // Dim DetailForm As New CostAnalysisDetail(Me)
                        iAnalysisID=Conversions.ToLong(UltraGrid1.Selected.Rows[0].Cells["AnalysisID"].Value);
                        mDetailForm.miAnalysisID=iAnalysisID;

                        mDetailForm.ShowDialog(this);
                        // CostAnalysisDetail.miAnalysisID = iAnalysisID
                        // CostAnalysisDetail.ShowDialog(Me)
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error selecting row in grid: "+ex.Message, MsgBoxStyle.Critical, "UltraGrid1_AfterSelectChange");
            }
            finally
            {
                Enabled=true;
            }
        }
        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            var rptViewer = new ReportViewer();
            rptViewer.sReportToRun="Cost Analysis - Review";
            rptViewer.sReportTitle="Cost Analysis - Review for: "+msProjectID;
            rptViewer.sCriteria=miAnalysisID.ToString();
            rptViewer.Show();
        }



        private void btnPrintRpt2_Click(object sender, EventArgs e)
        {
            var rptViewer = new ReportViewer();
            rptViewer.sReportToRun="Cost Analysis - Sales";
            rptViewer.sReportTitle="Cost Analysis - Sales: "+msProjectID;
            rptViewer.sCriteria=miAnalysisID.ToString();

            rptViewer.Show();
        }
    }
}