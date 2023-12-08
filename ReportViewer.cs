using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.VisualBasic;

namespace BossAdmin
{
    public partial class ReportViewer
    {
        private string msMsg;
        private int miResponse;
        private string sSelFormula;
        private int miIndex;
        private object mvTmp;
        // Dim oCR As clsCR
        private bool mbLoading;
        public string sReportToRun;
        public string sMode;
        public string sJobID;
        public string sReportTitle;
        public string sCriteria;
        public string sReportTitle1;
        public string sReportTitle2;
        public int iBuilderID;
        public string sProjectID;
        public long lMasterSchedID;
        public int iMonth;
        public int iYear;
        public int iMonth1;
        public int iYear1;
        public string sAlphaCode;
        public string sAlphaCodeDesc;
        private ReportDocument ThisReport;
        public string sPONumber;
        private string msServer;

        public ReportViewer()
        {
            InitializeComponent();
        }
        // Private Sub CRViewer1_PrintButtonClicked(useDefault As Boolean)
        // On Error GoTo HandleErrors
        // useDefault = False
        // ThisReport.PrintOptions()
        // ThisReport.ThisReport.PrintOut()
        // Exit Sub
        // HandleErrors:
        // MsgBox(Err.Description & " " & Err.Number, vbCritical, "crviewer1_PrintButtonClicked")
        // End Sub

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            LoadReport();

        }
        private void LoadReport()
        {
            Text=sReportTitle;
            switch (sReportToRun??"")
            {
                case "Job Estimate - Costed":
                    {
                        DisplayJobEstimateCosted();
                        break;
                    }
                case "Cost Analysis - Sales":
                    {
                        DisplayCostAnalysisSales();
                        break;
                    }
                case "Cost Analysis - Review":
                    {
                        DisplayCostAnalysis();
                        break;
                    }
                case "Summary Budget Report":
                    {
                        DisplaySummaryBudget();
                        break;
                    }
            }
        }
        private void DisplayCostAnalysis()
        {
            rptProfitAnalysis Report;
            DBCalls cDB;
            DataSet rs;
            string sID;

            try
            {
                sID=sCriteria;
                msServer=My.MySettings.Default.DBServer;
                Report=new rptProfitAnalysis();
                // Report.SetDatabaseLogon("boss", "bosssa", sServer, gsDatabase)
                rs=new DataSet();
                cDB=new DBCalls();
                // If cDB.GetDataFromSP(rs, "spGetAnalysis", sID) Then
                Report.DataSourceConnections[0].SetConnection(msServer, modGlobals.gsDatabase, "boss", "bosssa");
                // Report.SetDataSource(rs)
                // Report.
                Report.SetParameterValue("@AnalysisID", sID);
                // Report.Refresh()
                // ' Report.Refreichelesh()
                ViewReport(Report, 100);
            }
            // End If

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbCritical, "DisplayCostAnalysis");
            }
            finally
            {
                Report=null;
                cDB=null;
                rs=null;
            }
        }
        private void DisplayCostAnalysisSales()
        {
            rptProfitAnalysisSales Report;
            DBCalls cDB;
            DataSet rs;
            string sID;

            try
            {
                sID=sCriteria;
                Report=new rptProfitAnalysisSales();
                cDB=new DBCalls();
                // If cDB.GetDataFromSP(rs, "spGetAnalysis", sID) Then
                // Report.SetDataSource(rs)

                Report.DataSourceConnections[0].SetConnection(msServer, modGlobals.gsDatabase, "boss", "bosssa");
                // Report.SetDataSource(rs)
                // Report.
                Report.SetParameterValue("@AnalysisID", sID);
                ViewReport(Report, 100);
            }
            // End If

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbCritical, "DisplayCostAnalysis");
            }
            finally
            {
                Report=null;
                cDB=null;
                rs=null;
            }
        }
        private void ViewReport(ReportDocument pReport, int iZoom)
        {
            Section sec;
            // Dim i As Integer
            // Dim crxApplication As New CrystalDecisions
            // '                     '
            // ' Me.MDIChild = False '
            // crxApplication.SetLicenseKeycode("B6W60-01CS200-00GGW30-0QA0")

            try
            {
                ThisReport=pReport;
                switch (modGlobals.gsDatabase??"")
                {
                    case "HCHDataTest":
                        {
                            ThisReport.SummaryInfo.ReportComments="TEST DATA";
                            break;
                        }
                    case "HCHData":
                        {
                            if ((Strings.UCase(ThisReport.SummaryInfo.ReportTitle)??"")!=(Strings.UCase("rptRequestForBids")??"")&(Strings.UCase(ThisReport.SummaryInfo.ReportTitle)??"")!=(Strings.UCase("rptPO")??""))
                            {
                                ThisReport.SummaryInfo.ReportComments="LIVE DATA";
                            }

                            break;
                        }
                    case "HCHDataQA":
                        {
                            ThisReport.SummaryInfo.ReportComments="COST ANALYSIS DATA";
                            break;
                        }
                }
                // AddReportComments (ThisReport)
                WindowState=FormWindowState.Maximized;
                crViewer.ReportSource=ThisReport;
                // pReport.PrinterSetup 0 '
                crViewer.EnableDrillDown=false;
                // crViewer1.Zoom 100   '
                // crViewer1.Zoom (100) '


                crViewer.Show();

                // added this delay to give it time to finish before resizing otherwise won't work
                // mrb 5/2/08
                Application.DoEvents();

                if (ThisReport.PrintOptions.PaperOrientation==PaperOrientation.Landscape&ThisReport.PrintOptions.PaperSize==PaperSize.PaperLegal)
                {
                    crViewer.Zoom(100);
                }
                else
                {
                    crViewer.Zoom(1);
                }

                // End If            '
                TopLevel=true;
                sReportToRun="";
                sMode="";
                sJobID="";
                sReportTitle="";
                sCriteria="";
                sReportTitle1="";
                sReportTitle2="";
                iBuilderID=0;

                sAlphaCode="";
                sAlphaCodeDesc="";

                sPONumber="";
                sec=null;
            }
            catch (Exception ex)
            {
                sec=null;
                Interaction.MsgBox(ex.Message);
            }
            finally
            {
            }
        }
        // Private Sub AddReportComments(ByVal ThisReport As ReportDocument)
        // Dim i As Integer
        // Dim iAreas As Integer
        // Dim j As Integer
        // Dim jItems As Integer
        // Dim bFound As Boolean
        // Dim iLeft As Integer
        // Dim iLMargin As Integer
        // Dim iRMargin As Integer
        // Dim iWidth As Integer
        // Dim iTop As Integer
        // Dim iHeight As Integer

        // 'iAreas = ThisReport.ReportDefinition.Areas.Count
        // 'For i = 1 To iAreas
        // '    With ThisReport.ReportDefinition.Areas(i)
        // '        If .Kind = AreaSectionKind.PageFooter Then
        // '            iLMargin = ThisReport.PrintOptions.PageMargins.leftMargin
        // '            iRMargin = ThisReport.PrintOptions.PageMargins.rightMargin
        // '            'iWidth =  .Sections(1
        // '            iHeight = .Sections(1).Height
        // '            'iLeft = iWidth / 2 - 4200 - iLMargin

        // '            iTop = (iHeight - 228) / 2

        // '            .Sections(1).ReportObjects.Item.AddSpecialVarFieldObject(crSVTReportComments, iLeft, iTop)
        // '        End If
        // '    End With
        // 'Next i

        // End Sub
        private void DisplayJobEstimateCosted()
        {
            rptEstimateCosted Report;
            DBCalls cDB;
            DataSet rs;
            try
            {
                msServer=My.MySettings.Default.DBServer;
                Report=new rptEstimateCosted();
                rs=new DataSet();
                cDB=new DBCalls();
                Report.DataSourceConnections[0].SetConnection(msServer, modGlobals.gsDatabase, "boss", "bosssa");
                Report.SetParameterValue("@JobID", sJobID);
                ViewReport(Report, 100);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbCritical, "DisplayJobEstimateCosted");
            }
            finally
            {
                Report=null;
                cDB=null;
                rs=null;
            }
        }
        private void DisplaySummaryBudget()
        {
            rptSummaryBudgetRegion Report;
            // Dim cDB As New DBCalls
            // Dim rs As New DataSet
            try
            {
                msServer=My.MySettings.Default.DBServer; // mrb 12/3/14
                Report=new rptSummaryBudgetRegion();
                Report.DataSourceConnections[0].SetConnection(msServer, modGlobals.gsDatabase, "boss", "bosssa");
                Report.SetParameterValue("@Value", sJobID);
                Report.SetParameterValue("@Type", 5);
                Report.SetParameterValue("@Value2", Constants.vbNull);
                ViewReport(Report, 100);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Summary Budget Report: "+ex.Message, MsgBoxStyle.Critical, "DisplaySummaryBudget");
            }
            finally
            {
                Report=null;
            }
        }
    }
}