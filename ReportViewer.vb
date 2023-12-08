Option Explicit On
Imports System.Data.SqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows
Imports CrystalDecisions.CrystalReports.Engine
Public Class ReportViewer
    Dim msMsg As String
    Dim miResponse As Integer
    Dim sSelFormula As String
    Dim miIndex As Integer
    Dim mvTmp As Object
    'Dim oCR As clsCR
    Dim mbLoading As Boolean
    Public sReportToRun As String
    Public sMode As String
    Public sJobID As String
    Public sReportTitle As String
    Public sCriteria As String
    Public sReportTitle1 As String
    Public sReportTitle2 As String
    Public iBuilderID As Integer
    Public sProjectID As String
    Public lMasterSchedID As Long
    Public iMonth As Integer
    Public iYear As Integer
    Public iMonth1 As Integer
    Public iYear1 As Integer
    Public sAlphaCode As String, sAlphaCodeDesc As String
    Dim ThisReport As ReportDocument
    Public sPONumber As String
    Dim msServer As String
    '    Private Sub CRViewer1_PrintButtonClicked(useDefault As Boolean)
    '        On Error GoTo HandleErrors
    '        useDefault = False
    '        ThisReport.PrintOptions()
    '        ThisReport.ThisReport.PrintOut()
    '        Exit Sub
    'HandleErrors:
    '        MsgBox(Err.Description & " " & Err.Number, vbCritical, "crviewer1_PrintButtonClicked")
    '    End Sub

    Private Sub ReportViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadReport()

    End Sub
    Private Sub LoadReport()
        Me.Text = sReportTitle
        Select Case sReportToRun
            Case "Job Estimate - Costed"
                DisplayJobEstimateCosted()
            Case "Cost Analysis - Sales"
                DisplayCostAnalysisSales()
            Case "Cost Analysis - Review"
                DisplayCostAnalysis()
            Case "Summary Budget Report"
                DisplaySummaryBudget()
        End Select
    End Sub
    Private Sub DisplayCostAnalysis()
        Dim Report As rptProfitAnalysis
        Dim cDB As DBCalls
        Dim rs As DataSet
        Dim sID As String
        
        Try
            sID = CStr(sCriteria)
            msServer = Global.BossAdmin.My.MySettings.Default.DBServer
            Report = New rptProfitAnalysis
            ' Report.SetDatabaseLogon("boss", "bosssa", sServer, gsDatabase)
            rs = New DataSet
            cDB = New DBCalls
            'If cDB.GetDataFromSP(rs, "spGetAnalysis", sID) Then
            Report.DataSourceConnections(0).SetConnection(msServer, gsDatabase, "boss", "bosssa")
            ' Report.SetDataSource(rs)
            'Report.
            Report.SetParameterValue("@AnalysisID", sID)
            'Report.Refresh()
            '' Report.Refreichelesh()
            ViewReport(Report, 100)
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "DisplayCostAnalysis")
        Finally
            Report = Nothing
            cDB = Nothing
            rs = Nothing
        End Try
    End Sub
    Private Sub DisplayCostAnalysisSales()
        Dim Report As rptProfitAnalysisSales
        Dim cDB As DBCalls
        Dim rs As DataSet
        Dim sID As String

        Try
            sID = CStr(sCriteria)
            Report = New rptProfitAnalysisSales
            cDB = New DBCalls
            'If cDB.GetDataFromSP(rs, "spGetAnalysis", sID) Then
            'Report.SetDataSource(rs)

            Report.DataSourceConnections(0).SetConnection(msServer, gsDatabase, "boss", "bosssa")
            ' Report.SetDataSource(rs)
            'Report.
            Report.SetParameterValue("@AnalysisID", sID)
            ViewReport(Report, 100)
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "DisplayCostAnalysis")
        Finally
            Report = Nothing
            cDB = Nothing
            rs = Nothing
        End Try
    End Sub
    Private Sub ViewReport(ByVal pReport As ReportDocument, iZoom As Integer)
        Dim sec As Section
        ' Dim i As Integer
        'Dim crxApplication As New CrystalDecisions
        ''                     '
        '' Me.MDIChild = False '
        'crxApplication.SetLicenseKeycode("B6W60-01CS200-00GGW30-0QA0")

        Try
            ThisReport = pReport
            Select Case gsDatabase
                Case "HCHDataTest"
                    ThisReport.SummaryInfo.ReportComments = "TEST DATA"
                Case "HCHData"
                    If UCase(ThisReport.SummaryInfo.ReportTitle) <> UCase("rptRequestForBids") And UCase(ThisReport.SummaryInfo.ReportTitle) <> UCase("rptPO") Then
                        ThisReport.SummaryInfo.ReportComments = "LIVE DATA"
                    End If
                Case "HCHDataQA"
                    ThisReport.SummaryInfo.ReportComments = "COST ANALYSIS DATA"
            End Select
            'AddReportComments (ThisReport)
            Me.WindowState = FormWindowState.Maximized
            crViewer.ReportSource = ThisReport
            ' pReport.PrinterSetup 0 '
            crViewer.EnableDrillDown = False
            ' crViewer1.Zoom 100   '
            ' crViewer1.Zoom (100) '

     
            crViewer.Show()

            'added this delay to give it time to finish before resizing otherwise won't work
            'mrb 5/2/08
            Application.DoEvents()

            If ThisReport.PrintOptions.PaperOrientation = PaperOrientation.Landscape And ThisReport.PrintOptions.PaperSize = PaperSize.PaperLegal Then
                crViewer.Zoom(100)
            Else
                crViewer.Zoom(1)
            End If

            ' End If            '
            Me.TopLevel = True
            sReportToRun = ""
            sMode = ""
            sJobID = ""
            sReportTitle = ""
            sCriteria = ""
            sReportTitle1 = ""
            sReportTitle2 = ""
            iBuilderID = 0

            sAlphaCode = ""
            sAlphaCodeDesc = ""

            sPONumber = ""
            sec = Nothing
        Catch ex As Exception
            sec = Nothing
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    'Private Sub AddReportComments(ByVal ThisReport As ReportDocument)
    '    Dim i As Integer
    '    Dim iAreas As Integer
    '    Dim j As Integer
    '    Dim jItems As Integer
    '    Dim bFound As Boolean
    '    Dim iLeft As Integer
    '    Dim iLMargin As Integer
    '    Dim iRMargin As Integer
    '    Dim iWidth As Integer
    '    Dim iTop As Integer
    '    Dim iHeight As Integer

    '    'iAreas = ThisReport.ReportDefinition.Areas.Count
    '    'For i = 1 To iAreas
    '    '    With ThisReport.ReportDefinition.Areas(i)
    '    '        If .Kind = AreaSectionKind.PageFooter Then
    '    '            iLMargin = ThisReport.PrintOptions.PageMargins.leftMargin
    '    '            iRMargin = ThisReport.PrintOptions.PageMargins.rightMargin
    '    '            'iWidth =  .Sections(1
    '    '            iHeight = .Sections(1).Height
    '    '            'iLeft = iWidth / 2 - 4200 - iLMargin

    '    '            iTop = (iHeight - 228) / 2

    '    '            .Sections(1).ReportObjects.Item.AddSpecialVarFieldObject(crSVTReportComments, iLeft, iTop)
    '    '        End If
    '    '    End With
    '    'Next i

    'End Sub
    Private Sub DisplayJobEstimateCosted()
        Dim Report As rptEstimateCosted
        Dim cDB As DBCalls
        Dim rs As DataSet
        Try
            msServer = Global.BossAdmin.My.MySettings.Default.DBServer
            Report = New rptEstimateCosted
            rs = New DataSet
            cDB = New DBCalls
            Report.DataSourceConnections(0).SetConnection(msServer, gsDatabase, "boss", "bosssa")
            Report.SetParameterValue("@JobID", sJobID)
            ViewReport(Report, 100)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "DisplayJobEstimateCosted")
        Finally
            Report = Nothing
            cDB = Nothing
            rs = Nothing
        End Try
    End Sub
    Private Sub DisplaySummaryBudget()
        Dim Report As rptSummaryBudgetRegion
        ' Dim cDB As New DBCalls
        ' Dim rs As New DataSet
        Try
            msServer = Global.BossAdmin.My.MySettings.Default.DBServer 'mrb 12/3/14
            Report = New rptSummaryBudgetRegion
            Report.DataSourceConnections(0).SetConnection(msServer, gsDatabase, "boss", "bosssa")
            Report.SetParameterValue("@Value", sJobID)
            Report.SetParameterValue("@Type", 5)
            Report.SetParameterValue("@Value2", vbNull)
            ViewReport(Report, 100)
        Catch ex As Exception
            MsgBox("Error in Summary Budget Report: " & ex.Message, MsgBoxStyle.Critical, "DisplaySummaryBudget")
        Finally
            Report = Nothing
        End Try
    End Sub
End Class