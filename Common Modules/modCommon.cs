using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    static class modCommon
    {

        private static string mObjectName = ""; // used by haseditsecurity and vieweditsecurity mrb 6/20/12
        private static string mObjectType = "";
        public enum DocumentType
        {
            dtVPO = 1,
            dtOptions = 2,
            dtColorSelections = 3,
            dtMaterialsList = 4,
            dtSiteSheet = 5,
            dtPlotPlan = 6
        }

        public enum ADOCommandTypes
        {
            adSmallInt = 2,
            adInteger = 3,
            adSingle = 4,
            adDouble = 5,
            adCurrency = 6,
            adDate = 7,
            adIDispatch = 9,
            adBoolean = 11,
            adVariant = 12,
            adDecimal = 14,
            adUnsignedTinyInt = 17,
            adBigInt = 20,
            adGUID = 72,
            adBinary = 128,
            adChar = 129,
            adWChar = 130,
            adNumeric = 131,
            adDBTimeStamp = 135,
            adVarChar = 200,
            adLongVarChar = 201,
            adVarWChar = 202,
            adLongVarWChar = 203,
            adVarBinary = 204,
            adLongVarBinary = 205
        }
        public class SecurityMatrix
        {
            public string ObjectName = "";
            public string ObjectType = "";
            public int EditRank = 0;
            public int ViewRank = 0;
            public int PositionID = 0;
        }


        // ==========================
        // 4/10/2004  Michele Brown  add new fields to jobinfotype
        // ==========================
        // CustomerJobID, CID, JobID, StartDate, EndDate, CreatedDate,
        // CreatedBy, UpdatedDate, UpdatedBy, BasePlanPrice, LotCostAdj,
        // Concession, CJStatus, Lenderid, LenderContact, CJLoanType,
        // LoanApprovalDate, BrokerID, Agent,
        // AgentPhone, AgentFax, LenderPhone, LenderFax,
        // CoBrokerCommission, CoBrokerbonus, ContractNotes
        // ==========================
        // Michele Brown  8/11/2011
        // 8/11/11 add new fields
        // ==========================
        // Public type JobInfoType        ' type used for collecting datad for changes
        // CID As Long
        // CustJobID As Long
        // JobID As String
        // StartDate As String
        // EndDate As String
        // CreateBy As String
        // ID As Integer
        // BasePlanPrice As Double
        // Concession As Double
        // LotCostAdj As Double
        // ProjectID As String
        // PlanID As String
        // AddFallThru As Boolean      ' is a fallthrough record needed
        // UpdateRcd As Boolean        ' is an customer job record needed to be updated
        // CJStatus As Integer
        // Lender As Long
        // LenderContact As String
        // LoanType As Long
        // LoanAppDate As String
        // Broker As Long
        // Agent As String
        // AgentPhone As String
        // AgentFax As String
        // LenderPhone As String
        // LenderFax As String
        // CoBrokerCommission As String
        // CoBrokerBonus As String
        // ContractNotes As String
        // AgentEmail As String
        // LenderEmail As String
        // OptionTotal As Long
        // '8/13/11 mrb for customer contract screen
        // ListingAgentID As Long
        // ListingAgentNotes As String
        // ListingAgentPhone As String
        // '==========================
        // '    Michele Brown  9/1/2011
        // '
        // '==========================
        // ' ListingAgentFax As String
        // ListingAgentCommission As String
        // ListingAgentBonus As String
        // ' ListingAgentEmail As String
        // TitleInsCompanyID As Long
        // BuyerTitleInsCompanyID As Long
        // '8/24/11 mrb
        // UnderwriterApprovalDate As Date
        // 'TwoSidedContractRcvd As Date
        // OfferDate As Date
        // '9/11/11 mrb
        // FallThruReasonID As Integer
        // '==========================
        // '    Michele Brown  9/15/2011
        // '
        // '==========================
        // OfferEndDate As Date
        // OfferEndReasonID As Integer
        // End Structure

        // Public gsDatabase As String

        // Private Declare Function GetModuleFileName Lib "kernel32" Alias "GetModuleFileNameA" (ByVal hModule As Long, ByVal lpFileName As String, ByVal nSize As Long) As Long
        // Public Type ExcludeActivity
        // ActivityCode As Long
        // End Type
        // Public Type Organization
        // ProjectID As Integer
        // Project As String * 5
        // ProjectName As String
        // TaxPermitID As Integer
        // TaxPermitDistrict As String * 50
        // DivisionID As Integer
        // Division As String
        // ProductionManagerID As Integer
        // DivisionManagerID As Integer
        // RegionID As Integer
        // Region As String
        // ProductionManager As String
        // DivisionManager As String
        // TaxRate As Double
        // LotCost As Currency
        // Markup As Double
        // SalesID As Integer
        // Sales As String
        // HCHOwned As Integer
        // DrivingDirections As String
        // DateComplete As Date
        // StandardPlan As Integer
        // SewerOrSeptic As String
        // Water As String
        // Power As String
        // BuildAmerica As Integer
        // ReadyForReleases As Integer
        // End Type
        // Public Type Resource
        // ID As Long
        // ResourceID As String * 20
        // ResourceName As String * 50
        // AlphaCode As String * 6
        // UM As String * 10
        // Multiples As Integer
        // ResourceType As String * 1
        // UseMPO As Integer
        // Taxable As Integer
        // SelCategory As Long
        // NeedsSelection As Integer
        // VarianceOnly As Integer
        // InActive As Integer
        // ApprovedDate As Date
        // ApprovedBy As String * 50
        // CreatedDate As Date
        // CreatedBy As String * 10
        // UpdatedDate As Date
        // UpdatedBy As String * 10
        // Vendor As String * 50
        // Criteria As String * 20
        // ActivityCode As Long
        // Activity As String * 50
        // 'mrb 7/25/11 add fields
        // RequiresDraws As String * 1
        // HasDraw As String * 1
        // End Type
        // Public Type UserRecord
        // SIId As Integer
        // PositionID As Integer
        // Position As String
        // FName As String
        // LName As String
        // TypeID As Integer
        // Type As String
        // InActive As Integer
        // Address As String
        // City As String
        // State As String
        // Zip As String
        // HPhone As String
        // Radio As String
        // Cell As String
        // Fax As String
        // EMail As String
        // UserID As String
        // Password As String
        // SupervisorID As Integer
        // End Type
        // Public Type AssignedVendor
        // VendorAssignedID As Long
        // alphaID As Integer
        // AlphaCode As String
        // Description As String
        // VendorID As Long
        // vdrName As String
        // GlobalTrue As Integer
        // TaxPermitID As Integer
        // ProjectID As Integer
        // StartDate As Date
        // EndDate As Date
        // Pending As Integer
        // Project As String
        // TaxPermitDistrict As String
        // History As Integer
        // Alternate As Integer
        // PAVendorOnly As Integer
        // AlphaGroupID As Long
        // PriceAgreement As Integer
        // StandardPlan As Integer
        // End Type
        // 'Public Type ChangeRequestRecord
        // '    COId As Long
        // '    CRNum As Integer
        // '    CONum As Integer
        // '    coAmount As Currency
        // '    coDate As Date
        // '    coChgCust As String
        // '    coStatus As Integer
        // '    Status As String
        // '    coCancelledDate As Date
        // '    coORComment As String
        // '    coORRequestBy As String
        // '    coRequesterEMail As String
        // '    coORDecisionBy As Integer
        // '    coDecisionDate As Date
        // '    coFee As Currency
        // '    JobID As String
        // '    coComplete As Date
        // '    coAcceptedDate As Date
        // '    Total As Currency
        // '    Concession As Currency
        // '    Notes As String
        // 'End Type
        // Public Type Selection
        // ActivityCode As Long
        // Selection As String
        // SelCategory As Integer
        // SelectionId As Long
        // SelGroupID As Integer
        // ResourceName As String
        // UseCode As String
        // UsageDescription As String
        // Category As String
        // POReleased As Integer
        // SelMadeId As Long
        // OneLine As Integer
        // Room As Integer
        // Door As Integer
        // End Type

        // Public gAssignedVendors() As AssignedVendor
        // Public gUncostedResources() As Resource
        // Public gTooManyVendorsForActivity() As Resource
        // Public gOrganization() As Organization
        public static List<UserRecord>[] gUserList;
        public static SecurityMatrix[] gSecurity;
        public static string gCADFileText;
        public static string gCADPathStd;
        public static string gsUserName;
        // Public giAns As Integer
        public const string JCPOHelpIndex = "JCPOHelp.chm";
        public const string JCPOHelpFolder = "JCPOHelp"+@"\";
        public const string EstimatorHelpIndex = "EstimatorHelp.chm";
        public const string EstimatorHelpFolder = "EstimatorHelp"+@"\";
        public static string gsJobExportPath;
        public static string gsExportServer;
        // Dim rs As New ADODB.Recordset
        // Dim oDB As New DBCalls

        // Public Type OptionPackage
        // JobProjectID As Long
        // UpgradePkgID As String
        // PackageID As Integer
        // PkgDescription As String
        // JobID As String * 20
        // ApprovedDate As String * 10
        // ApprovedBy As String * 10
        // COId As Long
        // CancelledDate As String * 10
        // CancelledBy As String * 10
        // CancelledByCOId As Integer
        // CreatedBy As String * 10
        // CreatedDate As String * 10
        // CONum As Integer
        // POReleased As Boolean
        // POComplete As Boolean
        // COStatus As Integer
        // Status As String * 20
        // Approved As Integer
        // Price As Long
        // ValidForCo As Integer
        // RowIndex As Integer
        // CRNum As Integer
        // Concession As Currency
        // Type As Integer
        // Category As Integer
        // OptionID As Long
        // OptionType As String
        // Quantity As Integer
        // Activity As Long
        // RequiresRedraw As Integer
        // InActive As Integer
        // HasStandard As Integer
        // End Type

        // Public Type Managers
        // UserID As String * 10
        // FullName As String * 10
        // End Type

        // Public Type JobPOs
        // Activity As Long
        // PONumber As Long
        // POReleased As Integer
        // POComplete As Integer
        // End Type
        // Public Type ProjectBuilder
        // BuilderID As Integer
        // Builder As String
        // ProjectIDInt As Long
        // ProjectID As String
        // StandardPlan As Integer
        // End Type
        // Public Type SiteSheetHeader
        // ActivityCode As Long
        // ColumnName As String
        // Description As String
        // FieldType As String
        // OrderBy As Integer
        // End Type
        // Public vManagers() As Managers
        // Public vOptions() As OptionPackage

        // grid columns for changerequest '
        private const int iPackage = 0;
        private const int iDescription = 1;
        private const int iCONumber = 2;
        private const int iReviewedDate = 3;
        private const int iReviewedBy = 4;
        private const int iJobOptId = 5;
        private const int iCancelled = 6;
        private const int iReleased = 7;
        private const int iComplete = 8;
        private const int iStatus = 9;
        private const int iStatusDesc = 10;
        private const int iApproved = 11;


        // Public Function AddPlotPlanToDocumentsToSee(ByVal lJobID As Long) As Boolean

        // Dim sJobID As String
        // Dim oCMD As New ADODB.Command
        // Dim sErr As String
        // Dim sPath As String
        // Dim sFileName As String

        // On Error GoTo ERR_HANDLER

        // With oCMD
        // .ActiveConnection = gCN
        // .CommandType = adCmdStoredProc
        // .CommandText = "spGetJobID"
        // .Parameters.Refresh()
        // .Parameters(1).Value = lJobID
        // .Execute()
        // If IsNull(.Parameters(2).Value) Then
        // sErr = "Unable To Get Job ID"
        // GoTo ERR_HANDLER
        // Else
        // sJobID = .Parameters(2).Value
        // End If
        // End With
        // oCMD = Nothing

        // sPath = gsJobExportPath & sJobID & "\CAD"
        // sFileName = gsGetLastModifiedFile(sPath, "PlotPlan*.jpg")
        // If sFileName = vbNullString Then
        // sErr = "Unable To Find PlotPlan*.jpg In " & sPath
        // GoTo ERR_HANDLER
        // End If

        // CreateDocumentsToSee(sFileName, "jobs\" & sJobID & "\CAD\", lJobID, dtPlotPlan, gsUserID)

        // AddPlotPlanToDocumentsToSee = True

        // Exit Function

        // ERR_HANDLER:
        // oCMD = Nothing
        // MsgBox(IIf(sErr <> vbNullString, sErr, Err.Number & ": " & Err.Description), vbExclamation, "AddPlotPlanToDocumentsToSee")
        // End Function
        // Public Sub CreateDocumentsToSee(ByVal sName As String, ByVal sPath As String, _
        // ByVal lJobID As Long, ByVal iDocType As DocumentType, _
        // ByVal sUserID As String)

        // Dim oCMD As ADODB.Command

        // On Error GoTo ErrHandler

        // ' create procedure spBCCreateDocumentsToSee '
        // ' @DocumentType tinyint,                    '
        // ' @DocumentName varchar(100),               '
        // ' @CreatedBy char(10),                      '
        // ' @PathName varchar(250),                   '
        // ' @JobID int                                '

        // oCMD = New ADODB.Command
        // With oCMD
        // .ActiveConnection = gCN
        // .CommandType = adCmdStoredProc
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300

        // .CommandText = "spBCCreateDocumentsToSee"
        // .Parameters.Refresh()
        // .Parameters("@DocumentType").Value = iDocType
        // .Parameters("@DocumentName").Value = sName
        // .Parameters("@CreatedBy").Value = sUserID
        // .Parameters("@PathName").Value = sPath
        // .Parameters("@JobID").Value = lJobID
        // .Execute()
        // End With
        // oCMD = Nothing

        // Exit Sub

        // ErrHandler:
        // oCMD = Nothing
        // If Err.Number <> 0 Then
        // MsgBox(Err.Number & ": " & Err.Description, vbExclamation, "CreateDocumentsToSee")
        // End If
        // End Sub
        // Public Sub CriticalErr(ByVal sRoutine As String, ByVal ErrNum As Long, ByVal ErrDesc As String)
        // On Error Resume Next
        // Dim oCR As clsCR
        // oCR = New clsCR
        // oCR.CriticalErr(sRoutine, ErrNum, ErrDesc)
        // oCR = Nothing
        // End Sub

        // Public Function FindUser(iSIId As Integer) As UserRecord
        // 'Dim i As Integer
        // 'Dim iRows As Integer
        // 'iRows = UBound(gUserList)
        // 'For i = 0 To iRows
        // '    If gUserList(i).SIId = iSIId Then
        // '        FindUser = gUserList(i)
        // '        Exit For
        // '    End If
        // 'Next i

        // End Function
        // Public Sub LoadResourceArray(prs As ADODB.Recordset, pResources() As Resource)
        // Dim lRows As Long
        // Do While Not prs.EOF
        // ReDim Preserve pResources(lRows)
        // With pResources(lRows)
        // .AlphaCode = prs!AlphaCode
        // If Not IsNull(prs!ApprovedBy) Then
        // .ApprovedBy = prs!ApprovedBy
        // End If
        // If Not IsNull(prs!ApprovedDate) Then
        // .ApprovedDate = prs!ApprovedDate
        // End If
        // If Not IsNull(prs!CreatedBy) Then
        // .CreatedBy = prs!CreatedBy
        // End If
        // If Not IsNull(prs!CreatedDate) Then
        // .CreatedDate = prs!CreatedDate
        // End If
        // .ID = prs!ID
        // If Not IsNull(prs!InActive) Then
        // .InActive = prs!InActive
        // End If
        // If Not IsNull(prs!Multiples) Then
        // .Multiples = prs!Multiples
        // End If
        // If Not IsNull(prs!NeedsSelection) Then
        // .NeedsSelection = prs!NeedsSelection
        // End If
        // .ResourceID = prs!ResourceID
        // .ResourceName = prs!ResourceName
        // .ResourceType = prs!ResourceType
        // If Not IsNull(prs!SelCategory) Then
        // .SelCategory = prs!SelCategory
        // End If
        // If Not IsNull(prs!Taxable) Then
        // .Taxable = prs!Taxable
        // End If
        // .UM = prs!UM
        // If Not IsNull(prs!UpdatedBy) Then
        // .UpdatedBy = prs!UpdatedBy
        // End If
        // If Not IsNull(prs!UpdatedDate) Then
        // .UpdatedDate = prs!UpdatedDate
        // End If
        // If Not IsNull(prs!UseMPO) Then
        // .UseMPO = prs!UseMPO
        // End If
        // If Not IsNull(prs!VarianceOnly) Then
        // .VarianceOnly = prs!VarianceOnly
        // End If
        // If Not IsNull(prs!Vendor) Then
        // .Vendor = prs!Vendor
        // End If
        // If Not IsNull(prs!Criteria) Then
        // .Criteria = prs!Criteria
        // End If
        // If Not IsNull(prs!ActivityCode) Then
        // .ActivityCode = prs!ActivityCode
        // End If
        // If Not IsNull(prs!Activity) Then
        // .Activity = prs!Activity
        // End If
        // '7/25/11 mrb add fields
        // If Not IsNull(prs!RequiresDraws) Then
        // .RequiresDraws = prs!RequiresDraws
        // End If
        // If Not IsNull(prs!HasDraw) Then
        // .HasDraw = prs!HasDraw
        // End If

        // End With
        // ' vCheck = .GetRows '
        // lRows = lRows + 1
        // prs.MoveNext()
        // Loop

        // End Sub
        // The following code will determine if a DLL or EXE is being run from the IDE. The code will work even if placed inside a compiled DLL which is called from an EXE running in the IDE. '

        // Purpose : Determines if a project or a DLL is being run within the IDE                     '
        // Inputs : N/A                                                                               '
        // Outputs : Returns True if the project or DLL is being run from the IDE, else returns false '
        // Author : Andrew Baker (copyright www.vbusers.com)                                          '
        // Date : 31/Jan/2002                                                                         '
        // Notes : Will return True if code is placed inside a compiled DLL which is referenced by    '
        // a project runing in VB's IDE.                                                              '
        // Works on all version of VB.                                                                '
        // Revisions :                                                                                '

        public static bool IDERunning()
        {
            bool IDERunningRet = default;
            IDERunningRet=ProcessRunning("devenv")>0L;
            return IDERunningRet;

        ErrHandler:
            ;

            Debug.Print("Error in IDERunning: "+Information.Err().Description);
            Debug.Assert(false);
        }

        // Public Sub HiLite()
        // SendKeys("{home}+{end}")
        // End Sub
        // Public Function gsGetLastModifiedFile(ByVal sPath As String, ByVal sFilePattern As String) As String
        // '
        // ' This procedure will get the name of the most recently modified file in
        // ' the group of files specified by sPath and sFilePattern
        // '
        // Dim oFS As New FileSystemObject
        // Dim fol As Folder
        // Dim fil As File
        // Dim dtLast As Date

        // On Error GoTo ERR_HANDLER

        // With oFS
        // fol = .GetFolder(sPath)
        // dtLast = Empty
        // For Each fil In fol.Files
        // If fil.Name Like sFilePattern Then
        // If fil.DateLastModified >= dtLast Then
        // gsGetLastModifiedFile = fil.Name
        // dtLast = fil.DateLastModified
        // End If
        // End If
        // Next
        // End With
        // fil = Nothing
        // fol = Nothing
        // oFS = Nothing

        // Exit Function

        // ERR_HANDLER:
        // fil = Nothing
        // fol = Nothing
        // oFS = Nothing
        // With Err()
        // If .Number <> 0 Then MsgBox .Number & ": " & .Description, vbExclamation, "gsGetLastModifiedFile"
        // End With
        // End Function

        // Public Sub ShowBusy()
        // Screen.MousePointer = vbHourglass
        // End Sub

        // Public Sub ShowIdle()
        // Screen.MousePointer = vbDefault
        // End Sub

        // Public Sub DisplayHelp(ByVal HelpFile As String, Optional ByVal Mode As Integer = 0)
        // 'Mode = 0 - Contents, 1 - Index, 2 - Keyword

        // Dim hHelp As New HTMLHelp
        // Dim oFS As FileSystemObject

        // On Error Resume Next
        // With hHelp
        // '        .CHMFile = .HHSetHelpFile(1)
        // .CHMFile = App.Path & "\" & JCPOHelpFolder & JCPOHelpIndex
        // '        If .EnsureFileExists(.CHMFile) = False Then
        // '            .CHMFile = App.Path & "\" & EstimatorHelpIndex
        // '        End If
        // .HHWindow = "Main"
        // .HHTopicURL = HelpFile
        // oFS = New FileSystemObject
        // If oFS.FileExists(App.Path & "\" & JCPOHelpFolder & HelpFile) = False Then
        // .CHMFile = App.Path & "\" & EstimatorHelpFolder & EstimatorHelpIndex
        // End If
        // Select Case Mode
        // Case 0
        // .HHDisplayContents()
        // Case 1
        // .HHDisplayIndex()
        // Case 2
        // .HHDisplaySearch()
        // End Select
        // .HHDisplayTopicURL()
        // End With
        // hHelp = Nothing
        // oFS = Nothing
        // End Sub
        // Public Sub OnOnHelp(hWndControl As Long)
        // 
        // ' This procedure allows for the displaying of the         '
        // ' Contents tab if the F1 key is pressed, or a popup       '
        // ' topic if the What's This button or menu item is clicked '
        // 
        // On Error GoTo ErrHandler
        // 
        // Dim frmCurrent As Form
        // Dim ctlControl As Control
        // Dim errNumber As Integer
        // Dim intF1Key As Integer
        // Dim intNumLockKey As Integer
        // Dim intCapLockKey As Integer
        // Dim intScrollLockKey As Integer
        // Dim lngScan As Long
        // Dim strCustom As String
        // 
        // ' Get the latest state of the F1 key '
        // intF1Key = GetKeyState(VK_F1)
        // 
        // ' If F1 has been pressed, call the Help topic '
        // If (intF1Key = -127) Or (intF1Key = -128) Then
        // 
        // ' Call the Help topic '
        // DisplayHelp "Selections.htm"
        // 
        // GoTo ExitRoutine
        // 
        // End If
        // 
        // ExitRoutine:
        // 
        // ' Clear any previous F1 keypress, '
        // ' but leave the Lock keys alone   '
        // intNumLockKey = GetKeyState(VK_NUMLOCK)
        // intCapLockKey = GetKeyState(VK_CAPITAL)
        // intScrollLockKey = GetKeyState(VK_SCROLL)
        // With kbArray
        // .kbByte(VK_F1) = 0
        // .kbByte(VK_NUMLOCK) = intNumLockKey
        // .kbByte(VK_CAPITAL) = intCapLockKey
        // .kbByte(VK_SCROLL) = intScrollLockKey
        // End With
        // SetKeyboardState kbArray
        // 
        // Exit Sub
        // 
        // ErrHandler:
        // 
        // Select Case Err.Number
        // Case 438
        // ' The control being checked doesn't have a        '
        // ' Tag property, so set the variable to Err.Number '
        // ' before it gets cleared                          '
        // errNumber = Err.Number
        // Resume Next
        // 
        // Case Else
        // ' Nothing else to really be concerned with '
        // Resume Next
        // 
        // End Select
        // 
        // End Sub
        // 
        // Public Sub SetGridHighlight(ByRef ssdbgGrid As SSDBGrid)
        // ' select the current row '
        // With ssdbgGrid
        // With .SelBookmarks
        // If .Count > 0 Then
        // .Remove.Count(-1)
        // End If
        // End With

        // If .Rows > 0 Then
        // On Error Resume Next
        // .SelBookmarks.Add.Bookmark()
        // End If
        // .SetFocus()
        // .Refresh()
        // End With
        // End Sub

        // Public Sub BrowseGridSetup(ByRef ssdbgGridName As SSDBGrid)
        // On Error GoTo GenErrorTrap     ' Generated Errortrap '

        // With ssdbgGridName
        // '.DividerType = ssDividerTypeNone
        // .BackColorEven = &HFFFFFF
        // .BackColorOdd = &HFFFFFF
        // .ForeColorEven = &H0&
        // .ForeColorOdd = &H0&
        // .DataMode = ssDataModeAddItem
        // .AllowAddNew = False
        // .AllowColumnSwapping = ssRelocateNotAllowed   ' ssRelocateWithinGroup '
        // .AllowColumnMoving = ssRelocateNotAllowed     ' ssRelocateWithinGroup '
        // .AllowColumnShrinking = False
        // .AllowColumnSizing = True
        // .AllowDelete = False
        // .AllowDragDrop = False
        // .AllowUpdate = False
        // .AllowRowSizing = False
        // ' .HeadFont3D = ssFont3DInsetLight '
        // .MaxSelectedRows = 1
        // .SelectTypeRow = ssSelectionTypeSingleSelect
        // .ScrollBars = ssScrollBarsAutomatic
        // .SelectByCell = True
        // End With

        // Exit Sub
        // GenErrorTrap:
        // MsgBox("Error in BrowseGridSetup of Module= modCommon.bas")
        // End Sub
        // Public Sub LoadToolbar(ToolBarCtrl As Toolbar, ImageListCtrl As ImageList, Optional pgbBar As ProgressBar, Optional bHelp As Boolean, Optional bEdit As Boolean)
        // ' Create object variable for the ImageList. '
        // Dim imgX As ListImage
        // '==========================
        // '    5/5/2004  Michele Brown  take out reference to house ico and replace with add button where needed.
        // '==========================

        // ' Load pictures into the ImageList control. '
        // imgX = ImageListCtrl.ListImages. _
        // Add(, "New", LoadPicture(App.Path & "\Graphics\New.bmp"))
        // If bEdit Then
        // imgX = ImageListCtrl.ListImages. _
        // Add(, "Edit", LoadPicture(App.Path & "\Graphics\Edit.ico"))
        // End If
        // imgX = ImageListCtrl.ListImages. _
        // Add(, "Save", LoadPicture(App.Path & "\Graphics\Save.bmp"))
        // imgX = ImageListCtrl.ListImages. _
        // Add(, "Delete", LoadPicture(App.Path & "\Graphics\Delete.bmp"))
        // imgX = ImageListCtrl.ListImages. _
        // Add(, "Cancel", LoadPicture(App.Path & "\Graphics\Cancel.bmp"))
        // If bHelp Then
        // imgX = ImageListCtrl.ListImages. _
        // Add(, "Help", LoadPicture(App.Path & "\Graphics\Help.ico"))
        // End If
        // ' Set imgX = ImageListCtrl.ListImages. _
        // Add(, "House", LoadPicture(App.Path & "\Graphics\House.ico"))

        // ToolBarCtrl.ImageList = ImageListCtrl

        // ' Create object variable for the Toolbar. '
        // Dim btnX As Button
        // ' Add button objects to Buttons collection using     '
        // ' the                                                                   '
        // ' Add method. After creating each button, set both '
        // ' Description and ToolTipText properties.               '
        // ToolBarCtrl.Buttons.Add, , , tbrSeparator
        // btnX = ToolBarCtrl.Buttons.Add(, "New", , tbrDefault, "New")
        // btnX.ToolTipText = "New"
        // btnX.Description = btnX.ToolTipText
        // If bEdit Then
        // btnX = ToolBarCtrl.Buttons.Add(, "Edit", , tbrDefault, "Edit")
        // btnX.ToolTipText = "Edit"
        // btnX.Description = btnX.ToolTipText
        // End If
        // btnX = ToolBarCtrl.Buttons.Add(, "Save", , tbrDefault, "Save")
        // btnX.ToolTipText = "Save"
        // btnX.Description = btnX.ToolTipText
        // btnX = ToolBarCtrl.Buttons.Add(, "Delete", , tbrDefault, "Delete")
        // btnX.ToolTipText = "Delete"
        // btnX.Description = btnX.ToolTipText
        // btnX = ToolBarCtrl.Buttons.Add(, "Cancel", , tbrDefault, "Cancel")
        // btnX.ToolTipText = "Cancel"
        // btnX.Description = btnX.ToolTipText
        // '3/19/2004 greg added house for add job
        // '    Set btnX = ToolBarCtrl.Buttons.Add(, "House", , tbrDefault, "House")
        // '    btnX.ToolTipText = "Add Job to Customer"
        // '    btnX.Description = btnX.ToolTipText
        // If bHelp Then
        // btnX = ToolBarCtrl.Buttons.Add(, "Help", , tbrDefault, "Help")
        // btnX.ToolTipText = "Help"
        // btnX.Description = btnX.ToolTipText
        // End If
        // btnX = ToolBarCtrl.Buttons.Add(, , , tbrSeparator)

        // btnX = ToolBarCtrl.Buttons.Add(, "ProgressBar", , tbrPlaceholder)
        // If Not pgbBar Is Nothing Then
        // With pgbBar
        // .Top = ToolBarCtrl.Buttons("ProgressBar").Top
        // .Left = ToolBarCtrl.Buttons("ProgressBar").Left
        // .Visible = False
        // End With
        // End If

        // 'disable new buttons from the start
        // '    ToolBarCtrl.Buttons("House").Enabled = False

        // End Sub

        // Private Sub Main()

        // Login.ShowDialog()


        // End Sub

        public static object ConnectDB()
        {
            object ConnectDBRet = default;
            string sConnection = "'";
            string sConnectionTest = "";
            string sConnectionQA = "";
            string sConnectionBOSS = "";
            try
            {
                // If IDERunning() Then
                // 'msDBServer = "192.168.1.101" 'bigmama
                // 'msDBServer = "192.168.1.106"
                // msdbServer = "192.168.1.106" 'bigserver
                // Else
                // '6/5/11 mrb can't use ip address.  use server name instead
                // msdbServer = Global.BossAdmin.My.MySettings.Default.DBServer 'mrb 11/28/14
                // 'msdbServer = "hch-sql"
                // End If
                var settings = ConfigurationManager.ConnectionStrings;

                if (settings is not null)
                {
                    foreach (ConnectionStringSettings cs in settings)
                    {
                        switch (cs.Name??"")
                        {
                            case var case1 when CultureInfo.CurrentCulture.CompareInfo.Compare(case1, "HCHDataConnectionString", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                                {
                                    sConnection=cs.ConnectionString;
                                    break;
                                }
                            case var case2 when CultureInfo.CurrentCulture.CompareInfo.Compare(case2, "HCHDataQAConnectionString", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                                {
                                    sConnectionQA=cs.ConnectionString;
                                    break;
                                }
                            case var case3 when CultureInfo.CurrentCulture.CompareInfo.Compare(case3, "HCHDataTestConnectionString", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                                {
                                    sConnectionTest=cs.ConnectionString;
                                    break;
                                }
                            case var case4 when CultureInfo.CurrentCulture.CompareInfo.Compare(case4, "HCHDataBOSSConnectionString", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                                {
                                    sConnectionBOSS=cs.ConnectionString;
                                    break;
                                }

                        }
                        // Console.WriteLine(cs.Name)
                        // Console.WriteLine(cs.ProviderName)
                        // Console.WriteLine(cs.ConnectionString)
                    }
                }

                switch (modGlobals.gsDatabase??"")
                {
                    case var case5 when CultureInfo.CurrentCulture.CompareInfo.Compare(case5, "HCHDataQA", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                        {
                            modGlobals.msConnection=sConnectionQA; // Global.BossAdmin.My.MySettings.Default.HCHDataQAConnectionString
                            break;
                        }
                    case var case6 when CultureInfo.CurrentCulture.CompareInfo.Compare(case6, "HCHDataTest", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                        {
                            modGlobals.msConnection=sConnectionTest; // Global.BossAdmin.My.MySettings.Default.HCHDataConnectionString
                            break;
                        }
                    case var case7 when CultureInfo.CurrentCulture.CompareInfo.Compare(case7, "HCHData", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                        {
                            modGlobals.msConnection=sConnection; // My.Settings.HCHDataConnectionString '5/13/15"Data Source=" & msdbServer & "; Initial Catalog = " & gsDatabase & ";User ID=boss; password=bosssa"
                            break;
                        }
                }
                modGlobals.gsConnectionString=modGlobals.msConnection;
                // msConnection = My.Settings.HCHDataConnectionString '5/13/15"Data Source=" & msdbServer & "; Initial Catalog = " & gsDatabase & ";User ID=boss; password=bosssa"

                modGlobals.msConnectionBoss=sConnectionBOSS; // Global.BossAdmin.My.MySettings.Default.HCHDataBossConnectionString ' 5/13/15"Data Source=" & msdbServer & "; Initial Catalog = BOSS;User ID=boss; password=bosssa"

                modGlobals.gCN=new SqlConnection();
                {
                    ref var withBlock = ref modGlobals.gCN;
                    // .Provider = "SQLOLEDB"
                    withBlock.ConnectionString=modGlobals.msConnection;
                    // .CommandTimeout = 600
                    withBlock.Open();
                }
                modGlobals.mCNLogs=new SqlConnection();
                {
                    ref var withBlock1 = ref modGlobals.mCNLogs;
                    // .Provider = "SQLOLEDB"
                    withBlock1.ConnectionString=modGlobals.msConnection;
                    // .CommandTimeout = 600
                    withBlock1.Open();
                }
                // mrb 4/21/11 changing databases is causing problems
                modGlobals.gCNBoss=new SqlConnection();
                {
                    ref var withBlock2 = ref modGlobals.gCNBoss;
                    // .Provider = "SQLOLEDB"
                    withBlock2.ConnectionString=modGlobals.msConnectionBoss;
                    // .CommandTimeout = 600
                    withBlock2.Open();
                }

                ConnectDBRet=true;
            }
            catch
            {
                ConnectDBRet=false;
                Interaction.MsgBox("Database connection failed with error: "+Information.Err().Description,MsgBoxStyle.Information, "");
            }
            finally
            {
            }

            return ConnectDBRet;
        }
        // Public Sub DBConnectAdapta()
        // ' Purpose: To establish a connection to the database for the methods in '
        // ' this DLL                                                              '
        // Set gCNAdapta = New ADODB.Connection
        // With gCNAdapta
        // .Provider = "SQLOLEDB"
        // .ConnectionString = "Data Source=192.168.0.104; Initial Catalog=HCHData;User ID=sa"
        // .CommandTimeout = 120
        // .Open
        // End With
        // End Sub
        public static void CleanUpDS(DataSet pds, SqlCommand pcMD = null, SqlDataAdapter pad = null)
        {
            // Purpose: To clean up existing object variables '
            // 6/20/12
            if (pds is not null)
            {
                pds=null;
                pds.Dispose();
            }
            if (pad is not null)
            {
                pds=null;
                pad.Dispose();
            }

            if (!(pcMD==null))
            {
                if (pcMD is not null)
                    pcMD=null;
                pcMD.Dispose();
            }
        }
        // Public Function LoadOrganization()
        // Dim cDB As DBCalls
        // 'Dim vOrganization As Variant
        // Dim i As Integer
        // Dim iRows As Integer
        // Dim rs As ADODB.Recordset

        // On Error GoTo ErrHandler

        // ReDim gOrganization(0)

        // 'Set cGD = New GetData

        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetOrganization")
        // 'vOrganization = cGD.GetAList(ltOrganization)
        // 'If IsArray(vOrganization) Then
        // If Not rs.EOF Then
        // iRows = rs.RecordCount - 1
        // For i = 0 To iRows
        // ReDim Preserve gOrganization(i)
        // With gOrganization(i)
        // .ProjectID = rs!ProjectID
        // .Project = rs!Project
        // .ProjectName = rs!ProjectName
        // .TaxPermitID = rs!TaxPermitID
        // .TaxPermitDistrict = rs!TaxPermitDistrict
        // .DivisionID = rs!DivisionID
        // .Division = rs!Division
        // .ProductionManagerID = rs!ProductionManagerID
        // .DivisionManagerID = rs!DivisionManagerID
        // .RegionID = rs!RegionID
        // .ProductionManager = rs!ProductionManager
        // .DivisionManager = rs!DivisionManager
        // .Region = rs!Region
        // .TaxRate = rs!TaxRate
        // .LotCost = rs!LotCosts
        // .Markup = rs!Markup
        // .HCHOwned = rs!HCHOwned
        // .SalesID = IIf(Not IsNull(rs!SalesID), rs!SalesID, 0)
        // .Sales = IIf(Not IsNull(rs!Sales), rs!Sales, "")
        // .DrivingDirections = IIf(IsNull(rs!DrivingDirections), "", rs!DrivingDirections)
        // .StandardPlan = IIf(IsNull(rs!StandardPlan), 0, rs!StandardPlan)
        // .BuildAmerica = IIf(IsNull(rs!BuildAmerica), 0, rs!BuildAmerica)
        // .ReadyForReleases = IIf(IsNull(rs!ReadyForReleases), 0, rs!ReadyForReleases)
        // .SewerOrSeptic = IIf(IsNull(rs!SewerOrSeptic), "", rs!SewerOrSeptic)
        // .Water = IIf(IsNull(rs!Water), "", rs!Water)
        // .Power = IIf(IsNull(rs!Power), "", rs!Power)
        // rs.MoveNext()
        // End With
        // Next i
        // End If
        // cDB = Nothing
        // rs = Nothing
        // Exit Function

        // ErrHandler:
        // If Err.Number = 94 Then  'invalid use of null
        // Err.Clear()
        // Resume Next
        // Else
        // MsgBox(Err.Description)
        // End If
        // cDB = Nothing
        // rs = Nothing
        // End Function
        // Public Sub LoadTaxPermitDistricts(ssdbComboList As SSDBCombo)
        // Dim vTmp As Object
        // Dim cEDR As GetData
        // Dim i As Integer

        // ' On Error Resume Next '
        // On Error GoTo ErrHandler

        // cEDR = New GetData

        // vTmp = cEDR.GetAList(ltTaxPermitDistrict)

        // ssdbComboList.RemoveAll()
        // ssdbComboList.AddItem("(Choose)" & vbTab & "")
        // If IsArray(vTmp) Then
        // For i = 0 To UBound(vTmp, 2)
        // ssdbComboList.AddItem(vTmp(1, i) & vbTab & vTmp(0, i))
        // Next i
        // ssdbComboList.MoveFirst()
        // End If

        // cEDR = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadTaxPermitDistricts")
        // cEDR = Nothing
        // End Sub
        // Public Sub LoadProjects(pCtl As Control, Optional sType As String = "All")
        // Dim cEDR As GetData
        // Dim vTmp As Object
        // Dim i As Integer
        // Dim sStr As String
        // Dim iCols As Integer
        // Dim bAdd As Boolean

        // ' On Error Resume Next '
        // On Error GoTo ErrHandler

        // cEDR = New GetData
        // vTmp = ""
        // vTmp = cEDR.GetAList(ltOpenProjects)
        // 'Clear the control of existing items.
        // If TypeOf pCtl Is SSDBCombo Or TypeOf pCtl Is SSDBDropDown Then
        // pCtl.RemoveAll()
        // pCtl.AddItem("(Choose)" & vbTab & " ")
        // iCols = pCtl.Columns.Count
        // ElseIf TypeOf pCtl Is ComboBox Then
        // pCtl.Clear()
        // pCtl.AddItem("(Choose)")
        // End If
        // '==========================
        // '    11/22/2004  Michele Brown  add filters based on standard plan
        // '==========================
        // If IsArray(vTmp) Then
        // For i = 0 To UBound(vTmp, 2)
        // bAdd = sType = "All"
        // If Not bAdd Then
        // bAdd = sType = "StandardPlan" And vTmp(4, i) = 1
        // End If
        // If Not bAdd Then
        // bAdd = sType = "NoStandardPlan" And vTmp(4, i) = 0
        // End If
        // If bAdd Then
        // If TypeOf pCtl Is SSDBCombo Then
        // sStr = vTmp(0, i) & vbTab & vTmp(1, i)
        // If iCols >= 3 Then
        // sStr = sStr & vbTab & vTmp(2, i)   ' project int id '
        // End If
        // If iCols = 4 Then
        // sStr = sStr & vbTab & vTmp(3, i)   ' tax permit id '
        // End If
        // pCtl.AddItem(sStr)
        // ElseIf TypeOf pCtl Is ComboBox Then
        // pCtl.AddItem(vTmp(0, i))
        // '05/15/2007 - kdc - Changed this to use NewIndex rather than Index + 1
        // pCtl.ItemData(pCtl.NewIndex) = vTmp(2, i)   ' projects.id - integer '
        // End If
        // End If
        // Next i    '}-> For i = 0 To UBound(vtmp, 2)
        // If TypeOf pCtl Is SSDBCombo Then
        // ' pCtl.MoveFirst
        // 'pCtl.Text = pCtl.Columns(0).Text
        // ComboFirstRow(pCtl)
        // ElseIf TypeOf pCtl Is ComboBox Then
        // pCtl.ListIndex = 0
        // End If
        // End If    '}-> If IsArray(vtmp) Then
        // cEDR = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadProjects")
        // cEDR = Nothing
        // End Sub
        // Public Sub LoadSales(pCtl As Control)
        // Dim cEDR As GetData
        // Dim vTmp As Object
        // Dim i As Integer

        // 'On Error Resume Next

        // cEDR = New GetData
        // vTmp = ""
        // vTmp = cEDR.GetAList(ltGetSales)

        // If TypeOf pCtl Is SSDBCombo Then
        // pCtl.RemoveAll()
        // pCtl.AddItem("(Choose)" & vbTab & " ")
        // ElseIf TypeOf pCtl Is ComboBox Then
        // pCtl.Clear()
        // pCtl.AddItem("(Choose)")
        // End If

        // For i = 0 To UBound(vTmp, 2)
        // If TypeOf pCtl Is SSDBCombo Then
        // pCtl.AddItem(vTmp(0, i) & vbTab & vTmp(1, i))
        // ElseIf TypeOf pCtl Is ComboBox Then
        // pCtl.AddItem(vTmp(0, i))
        // pCtl.ItemData(i + 1) = vTmp(1, i)   ' projects.id - integer '
        // End If
        // Next i

        // If TypeOf pCtl Is SSDBCombo Then
        // pCtl.MoveFirst()
        // pCtl.Text = "(Choose)"
        // ElseIf TypeOf pCtl Is ComboBox Then
        // pCtl.ListIndex = 0
        // End If

        // cEDR = Nothing

        // End Sub
        // Public Sub LoadCategories(ThisCombo As ComboBox)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls

        // On Error GoTo ErrHandler

        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetOptionPackageCategories")
        // ThisCombo.AddItem("(Choose)")
        // Do While Not rs.EOF
        // With ThisCombo
        // .AddItem(rs!UpgradeCategory)
        // .ItemData(.NewIndex) = rs!UpgCatID
        // End With
        // rs.MoveNext()
        // Loop
        // cDB = Nothing
        // Exit Sub
        // ErrHandler:
        // cDB = Nothing
        // MsgBox(Err.descroption, vbCritical, "Error in LoadCategories")
        // End Sub

        // Public Sub LoadUpgradeNames(ThisCombo As ComboBox, iCategory As Integer)
        // Dim cEDR As GetData
        // Dim vTmp As Object
        // Dim iINDEX As Integer

        // On Error GoTo ErrHandler
        // cEDR = New GetData
        // vTmp = ""
        // vTmp = cEDR.GetAList(ltUpgradesActive)
        // With ThisCombo
        // .Clear()
        // .AddItem("(Choose)")
        // End With
        // If IsArray(vTmp) Then
        // For iINDEX = 0 To UBound(vTmp, 2)
        // With ThisCombo
        // If CInt(vTmp(2, iINDEX)) = iCategory Then
        // ThisCombo.AddItem(vTmp(0, iINDEX) & " " & vTmp(1, iINDEX)) ' vTmp(0, iINDEX) & " - " & vTmp(1, iINDEX)
        // ThisCombo.ItemData(ThisCombo.NewIndex) = vTmp(3, iINDEX)
        // End If
        // End With
        // Next iINDEX
        // ThisCombo.ListIndex = 0
        // End If
        // cEDR = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "Error in LoadUpgradeNames")
        // cEDR = Nothing
        // End Sub
        // Public Sub LoadAlphaCodes(ThisCombo As Control)
        // Dim iResponse
        // Dim sMsg

        // Dim vTmp As Object
        // Dim cEDR As GetData
        // Dim i As Integer
        // Dim iCols As Integer
        // Dim sStr As String

        // On Error GoTo HandleErrors


        // cEDR = New GetData
        // vTmp = cEDR.GetAList(ltAlphaCodes)
        // cEDR = Nothing
        // If TypeOf ThisCombo Is SSDBCombo Then
        // ThisCombo.RemoveAll()
        // ThisCombo.AddItem("(Choose)" & vbTab & " ")
        // iCols = ThisCombo.Columns.Count
        // ElseIf TypeOf ThisCombo Is ComboBox Then
        // ThisCombo.Clear()
        // ThisCombo.AddItem("(Choose)")
        // End If
        // For i = 0 To UBound(vTmp, 2)
        // If TypeOf ThisCombo Is SSDBCombo Then
        // sStr = vTmp(0, i) & " - " & vTmp(1, i) & vbTab & vTmp(0, i)
        // If iCols = 3 Then
        // sStr = sStr & vbTab & vTmp(2, i)
        // End If
        // ThisCombo.AddItem(sStr)
        // ElseIf TypeOf ThisCombo Is ComboBox Then
        // ThisCombo.AddItem(vTmp(0, i) & " - " & vTmp(1, i))
        // ThisCombo.ItemData(ThisCombo.NewIndex) = vTmp(2, i)
        // End If
        // Next i
        // If TypeOf ThisCombo Is ComboBox Then
        // ThisCombo.ListIndex = 0
        // Else
        // ComboFirstRow(ThisCombo)
        // End If
        // Exit Sub
        // HandleErrors:
        // Select Case Err()
        // Case 3021                    ' EOF/BOF '
        // sMsg = "There are no Alpha Codes for this Vendor."
        // MsgBox(sMsg, vbCritical, "Missing Alpha Codes")
        // ' Unload Me '
        // Case Else
        // MsgBox(Err.Description & " " & Err.Number)
        // End Select

        // End Sub

        // Public Sub LoadBuilders(ThisCombo As ComboBox)
        // Dim iINDEX As Integer
        // Dim vTmp As Object
        // Dim cEDR As GetData

        // On Error GoTo ErrHandler

        // vTmp = ""
        // cEDR = New GetData 'CreateObject("EstimatorDataRetrieval.GetData")
        // vTmp = cEDR.GetAList(ltBuilders)
        // cEDR = Nothing

        // ThisCombo.Clear()

        // For iINDEX = 0 To UBound(vTmp, 2)
        // ThisCombo.AddItem(vTmp(1, iINDEX))
        // ThisCombo.ItemData(ThisCombo.NewIndex) = vTmp(0, iINDEX)
        // Next iINDEX

        // ThisCombo.ListIndex = 0

        // CleanUp:
        // cEDR = Nothing

        // Exit Sub
        // ErrHandler:
        // CriticalErr("LoadJobs", Err.Number, Err.Description)
        // Resume CleanUp
        // End Sub
        // Public Sub FindInCombo(ThisCombo As SSDBCombo, sFind As String)
        // Dim iRows As Integer
        // Dim i As Integer
        // Dim bFound As Boolean

        // iRows = ThisCombo.Rows - 1
        // ThisCombo.MoveFirst()
        // For i = 0 To iRows
        // With ThisCombo
        // If Trim(.Columns(0).Text) = Trim(sFind) Then
        // .Text = .Columns(0).Text
        // bFound = True
        // Exit For
        // Else
        // .MoveNext()
        // End If
        // End With
        // Next i
        // If Not bFound Then
        // ComboFirstRow(ThisCombo)
        // End If
        // End Sub
        // Public Sub FindInCBO(ThisCombo As ComboBox, sFind As String)
        // Dim iRows As Integer
        // Dim i As Integer
        // Dim bFound As Boolean

        // iRows = ThisCombo.ListCount - 1

        // ThisCombo.ListIndex = 1
        // For i = 1 To iRows
        // With ThisCombo
        // If Trim(.Text) = Trim(sFind) Then
        // bFound = True
        // Exit For
        // Else
        // .ListIndex = i
        // End If
        // End With
        // Next i
        // If Not bFound Then
        // ThisCombo.ListIndex = 0
        // End If

        // End Sub
        // Public Sub ComboFirstRow(ByRef ssdbcCombo As SSDBCombo, _
        // Optional ByVal sFirstRowText As String = "(Choose)")
        // With ssdbcCombo
        // .MoveFirst()
        // .Text = sFirstRowText
        // End With
        // End Sub
        // Public Sub ComboFirstRowNoChoose(ByRef ssdbcCombo As SSDBCombo)

        // With ssdbcCombo
        // .MoveFirst()
        // .Text = ssdbcCombo.Columns(0).Text
        // End With
        // End Sub
        // Public Function IsComboChosen(ThisCombo As SSDBCombo)
        // ' mrb 7/19/11 add test for '(Choose)' it quit working for some reason
        // IsComboChosen = ThisCombo.AddItemRowIndex(ThisCombo.Bookmark) <> 0 And ThisCombo.Text <> "(Choose)"
        // End Function
        public static bool HasEditSecurity(string sObjectName, string sObjectType)
        {
            bool HasEditSecurityRet = default;
            // 6/21/12 mrb
            HasEditSecurityRet=false;
            foreach (var SecurityMatrix in modGlobals.gSecurityList)
            {
                if (CultureInfo.CurrentCulture.CompareInfo.Compare(SecurityMatrix.ObjectName??"", sObjectName??"", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0&CultureInfo.CurrentCulture.CompareInfo.Compare(SecurityMatrix.ObjectType??"", sObjectType??"", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0&SecurityMatrix.EditRank<=modGlobals.giRank)
                {
                    HasEditSecurityRet=true;
                    break;
                }
            }

            return HasEditSecurityRet;
        }

        public static bool HasViewSecurity(string sObjectName, string sObjectType)
        {
            bool HasViewSecurityRet = default;
            // 6/21/12 mrb
            HasViewSecurityRet=false;
            foreach (var SecurityMatrix in modGlobals.gSecurityList)
            {
                if (CultureInfo.CurrentCulture.CompareInfo.Compare(SecurityMatrix.ObjectName??"", sObjectName??"", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0&CultureInfo.CurrentCulture.CompareInfo.Compare(SecurityMatrix.ObjectType??"", sObjectType??"", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0)
                {
                    HasViewSecurityRet=true;
                    break;
                }
            }

            return HasViewSecurityRet;
        }
        // *** mrb 6/8/12
        // Public Sub PrintPO(sPONumber As String, bShow As Boolean)
        // On Error GoTo ErrPreview
        // 
        // With ReportViewer
        // .sReportToRun = "PurchaseOrder"
        // .sPONumber = sPONumber
        // If bShow Then
        // .Show
        // Else
        // ReportViewer.DisplayPurchaseOrders bShow
        // End If
        // End With
        // 
        // Exit Sub
        // ErrPreview:
        // MsgBox "Error Previewing this Purchase Order." & vbNewLine & "Error Description:" & Err.Description, vbCritical
        // End Sub

        // Public Function IsSelected(ThisBookMark As Variant, ThisGrid As ssdbGrid) As Boolean
        // Dim i As Integer
        // Dim iRows As Integer
        // iRows = ThisGrid.SelBookmarks.Count - 1
        // For i = 0 To iRows
        // If CStr(ThisGrid.SelBookmarks(i)) = CStr(ThisBookMark) Then
        // IsSelected = True
        // Exit For
        // End If
        // Next i
        // End Function

        // Public Function FindSelectedGridRow(ThisBookMark As Object, ThisGrid As SSDBGrid)
        // Dim i As Integer
        // Dim iRows As Integer
        // iRows = ThisGrid.SelBookmarks.Count - 1
        // ThisGrid.MoveFirst()
        // For i = 0 To iRows
        // If CStr(ThisGrid.SelBookmarks(i)) = CStr(ThisBookMark) Then
        // Exit For
        // End If
        // ThisGrid.MoveNext()
        // Next i
        // End Function
        // *** mrb 6/8/12
        // Public Sub ShowReport(sReportToRun As String, sScreenCaption As String, Optional sJobID As String, _
        // Optional sCriteria As String, Optional sMode As String)
        // Dim oRptViewer As ReportViewer
        // Set oRptViewer = New ReportViewer
        // 
        // With oRptViewer
        // .sReportToRun = sReportToRun
        // .Caption = "Report: " & sScreenCaption
        // .sJobID = sJobID
        // .sCriteria = sCriteria
        // .sMode = sMode
        // .Show
        // 
        // 
        // End With
        // End Sub
        // Public Sub LoadMilestones(ThisGrid As SSDBGrid, iGroup As Integer, sJobID As String, lCID As Long)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sStr As String


        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // If iGroup = 0 Then
        // 'Set rs = cDB.GetRecordsFromSP("spJobHistory", sJobID)
        // '==========================
        // '    5/25/2005  Michele Brown  to add ability to cancel and delete
        // '==========================
        // rs = cDB.GetRecordsFromSP("spJobHistory2", sJobID)
        // Else
        // rs = cDB.GetRecordsFromSP("spGetJobMilestones", sJobID)
        // End If
        // If ThisGrid.Rows > 0 Then
        // ThisGrid.RemoveAll()
        // End If

        // Do While Not rs.EOF
        // If rs!GroupID = iGroup Or iGroup = 0 Then
        // If rs!CID = lCID Or lCID = 0 Then
        // sStr = rs!ActionDate & vbTab
        // sStr = sStr & rs!ActionDescription & vbTab
        // sStr = sStr & rs!ActionBy & vbTab
        // sStr = sStr & rs!Note & vbTab
        // sStr = sStr & IIf(IsNull(rs!CanDelete), "", rs!CanDelete) & vbTab
        // sStr = sStr & IIf(IsNull(rs!CanCancel), "", rs!CanCancel) & vbTab
        // sStr = sStr & IIf(IsNull(rs!CancelledDate), "", rs!CancelledDate) & vbTab
        // sStr = sStr & IIf(IsNull(rs!CancelledBy), "", rs!CancelledBy)
        // If iGroup = 0 Then
        // sStr = sStr & vbTab & rs!MilestoneJobID
        // End If
        // sStr = sStr & vbTab & rs!CreatedDate
        // ThisGrid.AddItem(sStr)
        // End If
        // End If
        // rs.MoveNext()
        // Loop
        // rs = Nothing
        // cDB = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbInformation, "LoadMilestones")
        // rs = Nothing
        // cDB = Nothing
        // End Sub
        // Public Sub LoadMilestoneCombo(ThisCombo As SSDBCombo, iGroup As Integer)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sStr As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetMilestones", iGroup)

        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ThisCombo.AddItem("(Choose)")
        // Do While Not rs.EOF
        // sStr = rs!Description & vbTab
        // sStr = sStr & rs!MilestoneID
        // ThisCombo.AddItem(sStr)
        // rs.MoveNext()
        // Loop
        // ComboFirstRow(ThisCombo)
        // rs = Nothing
        // cDB = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbInformation, "LoadMilestones")
        // rs = Nothing
        // cDB = Nothing
        // End Sub
        // Public Function SaveMilestone(lMilestoneID As Long, dAction As Date, sNote As String, lJobID As Long, lCID As Long) As Boolean
        // Dim cDB As DBCalls
        // Dim sReturn As String
        // Dim sMsg As String
        // '==========================
        // '    2/11/2005  Michele Brown  add check for error numbers
        // '==========================
        // On Error GoTo ErrHandler

        // cDB = New DBCalls

        // '==========================
        // '    5/19/2005  Michele Brown  added errors 17 and 18
        // '==========================
        // 'spInsertJobMilestone @JobID, @MilestoneID, @ActionDate, @Note, @CreatedBy
        // 'cDB.InsertDataBySP "spInsertJobMilestone", lJobID, lMilestoneID, dAction, sNote, gsUserID, lCID
        // sReturn = cDB.GetOutputParamFromSP("spInsertJobMilestone", "@Return_Value", lJobID, lMilestoneID, dAction, sNote, gsUserID, lCID)
        // Select Case sReturn
        // Case "13", "14"
        // sMsg = "Unable to create purchase order required."
        // Case "15"
        // sMsg = "Unable to create purchase order required. Uncosted resource or zero total po."
        // Case "16"
        // sMsg = "You can only schedule the schedule job start or scheduled construction start once."
        // Case "17"
        // sMsg = "You cannot enter a Scheduled Construction Start without a Scheduled Job Start."
        // Case "18"
        // sMsg = "You cannot enter a Scheduled Job Start without the Permit being received."
        // Case "-1"
        // sMsg = "Unable to find Master Schedule for Job Schedule"
        // Case "19"
        // sMsg = "The Scheduled Construction Start Date must be on or before the date the Set Forms PO (activity 40300) was completed."
        // Case "-2"
        // sMsg = "The Scheduled Job Start Milestone could not be created."
        // Case "-3"
        // sMsg = "Could not reapply Cost to Job"
        // Case Else
        // sMsg = "Error posting Job Milestone"
        // End Select

        // cDB = Nothing
        // If sReturn = "" Or sReturn = "0" Then
        // '11/01/2004 LEB Added logic to create documents to see for plot plan when site sheet sent milestone is saved
        // If lMilestoneID = 50 Then AddPlotPlanToDocumentsToSee(lJobID)

        // SaveMilestone = True
        // Else
        // MsgBox(sMsg, vbCritical, "SaveMilestone")
        // End If
        // Exit Function
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "SaveMilestone")
        // cDB = Nothing
        // End Function

        // Public Sub SortClick(ThisGrid As SSDBGrid, sOrder As String, sColName As String, Optional ThisPrgBar As ProgressBar)
        // Dim bBar As Boolean

        // On Error GoTo ErrAsc
        // If ThisPrgBar Is Nothing Then
        // bBar = False
        // Else
        // bBar = True
        // End If

        // mdiMain.MousePointer = vbHourglass
        // If bBar Then
        // With ThisPrgBar
        // .Visible = True
        // .ZOrder(0)
        // .Value = .Min
        // End With
        // End If
        // ThisGrid.Columns(sColName).TagVariant = sOrder
        // If bBar Then
        // ThisPrgBar.Value = ThisPrgBar.Value + 10
        // End If
        // Call GridSortHeadClick(ThisGrid, ThisGrid.Columns(sColName).Position, 0)
        // If bBar Then
        // With ThisPrgBar
        // .Value = .Value + 10      '
        // .ZOrder(1)                 '
        // .Visible = False          '
        // End With
        // End If
        // mdiMain.MousePointer = vbDefault
        // Exit Sub
        // ErrAsc:
        // mdiMain.MousePointer = vbDefault
        // MsgBox("Error Sort Ascending" & vbNewLine & "Error Description:" & Err.Description, vbCritical)
        // End Sub


        // 
        // 
        // 
        // Public Sub LoadAnalyses(ByRef Cntrl As SSDBCombo)
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim sProjectID As String
        // Dim sStr As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spGetAnalyses")


        // 'changed proc to accept different controls changed ssdbAnalyses to Cntrl
        // If Cntrl.Rows > 0 Then
        // Cntrl.RemoveAll()
        // End If
        // Cntrl.AddItem("(Choose)")
        // ' SELECT AnalysisID, VersionName, JobID, NewMargin, CostProjectID, AnalysisDate '
        // Do While Not rs.EOF
        // sStr = rs!VersionName & vbTab
        // sStr = sStr & rs!CostProjectID & vbTab
        // sStr = sStr & rs!AnalysisID & vbTab
        // sStr = sStr & rs!AnalysisDate
        // Cntrl.AddItem(sStr)
        // rs.MoveNext()
        // Loop
        // ComboFirstRow(Cntrl)
        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // ErrHandler:
        // cDB = Nothing
        // rs = Nothing
        // MsgBox(Err.Description, vbCritical, "LoadAnalyses")

        // End Sub

        // Emptys a sheridan combo and puts the value passed in mAddItem in first selection
        // and in text
        // Public Sub EmptyCombo(ByRef mCmboCntrl As SSDBCombo, mAddItem As String)
        // If mCmboCntrl.Rows > 0 Then
        // mCmboCntrl.RemoveAll()
        // End If
        // mCmboCntrl.Text = mAddItem
        // mCmboCntrl.AddItem(mAddItem)
        // End Sub
        // Public Sub SendNotification(ByVal sMessage As String, ByVal sItemValue As String, ByVal sSubject As String)
        // Dim oCMD As ADODB.Command

        // On Error GoTo ErrHandler
        // oCMD = New ADODB.Command
        // With oCMD
        // .ActiveConnection = gCNBoss
        // .CommandType = adCmdStoredProc
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300


        // ' ==========================                                   '
        // ' 10/13/2004  Michele Brown  chg from sp_ to sp - optimization '
        // ' ==========================                                   '
        // .CommandText = "spMailMessage"
        // .Parameters.Refresh()
        // ' @RETURN_VALUE, @Item, @ItemValue, @EMailMsg, @SubjectLine, @CreatedBy, @DataBase '
        // .Parameters("@Item").Value = "Notification"
        // .Parameters("@ItemValue").Value = sItemValue
        // .Parameters("@EmailMsg").Value = sMessage
        // .Parameters("@CreatedBy").Value = gsUserID
        // .Parameters("@Database").Value = gCN.DefaultDatabase
        // .Parameters("@SubjectLine").Value = sSubject
        // .Execute()
        // End With
        // oCMD = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "SendNotification")
        // oCMD = Nothing
        // End Sub
        // Public Sub SearchGrid(ThisGrid As SSDBGrid, sColumn As String, sValue As String)
        // Dim i As Integer, intStep As Integer
        // Dim iRows As Integer
        // Dim lngNewRow As Long, lngRow As Long
        // Dim bFound As Boolean

        // On Error GoTo ErrSearchValue

        // lngNewRow = -1
        // ' To facilitate for the weirdness of SSDBGrid '
        // lngRow = CLng(CStr(ThisGrid.AddItemRowIndex(ThisGrid.Bookmark)))
        // ThisGrid.SelBookmarks.RemoveAll()
        // ThisGrid.MoveFirst()
        // iRows = ThisGrid.Rows - 1
        // For i = 0 To iRows
        // With ThisGrid
        // If .Columns(sColumn).Text = sValue Then
        // lngNewRow = i '.Row '.AddItemBookmark(.Row)

        // Exit For
        // End If
        // .MoveNext()
        // End With
        // Next i
        // If lngNewRow <> -1 Then
        // With ThisGrid
        // '         .SelBookmarks.RemoveAll
        // .Bookmark = lngNewRow
        // .SelBookmarks.Add(lngNewRow)   ' .Bookmark '
        // End With
        // End If
        // 'ThisGrid.Refresh


        // Exit Sub
        // ErrSearchValue:
        // MsgBox("Error Searching for Value." & vbNewLine & "Error Description:" & Err.Description, vbCritical)
        // End Sub
        // mrb 6/8/12 ***
        // Public Sub ExportSalesAgreement(sJobID As String, ByVal lJobID As Long)
        // Dim Report As rptConsolidatedSalesAgreement
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim rsDetail As ADODB.Recordset
        // Dim rsFee As ADODB.Recordset
        // Dim ExportOptions As CRAXDRT.ExportOptions   ' Declare the ExportOptions object '
        // ' Dim sName As String '
        // Dim sName As String
        // 
        // On Error GoTo ErrHandler
        // 
        // Set Report = New rptConsolidatedSalesAgreement
        // Set ExportOptions = Report.ExportOptions   ' Set the ExportOptions variable '
        // 
        // 
        // Set cDB = New DBCalls
        // 
        // 
        // Set rs = cDB.GetRecordsFromSP("spRptConsSalesAgrmntHeader ", sJobID)
        // Set rsDetail = cDB.GetRecordsFromSP("spRptConsSalesAgrmntDetails")
        // Set rsFee = cDB.GetRecordsFromSP("spRptConsSalesAgrmntFee")
        // ' (data, [dataTag], [tableNumber]) '
        // Report.Database.SetDataSource rs, 3, 2         ' header data '
        // Report.Database.SetDataSource rsDetail, 3, 1   ' detail data '
        // Report.Database.SetDataSource rsFee, 3, 3      ' fee         '
        // 
        // ExportOptions.DestinationType = crEDTDiskFile   ' Set the destination type to Disk File '
        // If gsDatabase = "HCHData" Then
        // sName = gsJobExportPath & sJobID & "\DOCS\Options.pdf"
        // ExportOptions.DiskFileName = sName                  ' gsFaxDocPath & CStr(lPONum) & ".pdf"      ' Set the path and disk filename '
        // ExportOptions.FormatType = crEFTPortableDocFormat   ' Set the Format type to PDF                                                 '
        // Report.Export False                                 ' Export the report and set the export prompting parameter to false          '
        // CreateDocumentsToSee "Options.pdf", "jobs\" & sJobID & "\DOCS\", lJobID, dtOptions, gsUserID
        // End If
        // 
        // Set ExportOptions = Nothing
        // Set Report = Nothing
        // Set cDB = Nothing
        // Set rs = Nothing
        // Set rsDetail = Nothing
        // Set rsFee = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox Err.Description, vbCritical, "ExportSalesAgreement"
        // Set cDB = Nothing
        // Set rs = Nothing
        // Set ExportOptions = Nothing
        // Set rsFee = Nothing
        // 
        // Set rsDetail = Nothing
        // Set Report = Nothing
        // End Sub
        // *** mrb 6/8/12
        // Public Sub ExportSelections(ByVal sJobID As String, ByVal lJobID As Long)
        // Dim Report As rptSelectionsMade
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim ExportOptions As CRAXDRT.ExportOptions   ' Declare the ExportOptions object '
        // ' Dim sName As String '
        // Dim sName As String
        // 
        // On Error GoTo ErrHandler
        // Set Report = New rptSelectionsMade
        // Set ExportOptions = Report.ExportOptions   ' Set the ExportOptions variable '
        // 
        // 
        // Set cDB = New DBCalls
        // 
        // ' Set rs = cDB.GetRecordsFromSP("spRptConsolidatedSalesAgreement", sJobID) '
        // ' Set rs = cDB.GetRecordsFromSP("spRptSelectionsMade", sJobID)             '
        // Set rs = cDB.GetRecordsFromSP("spRptSelectionsMade_Customer", sJobID)
        // Report.SectionActivityCode.Suppress = True
        // Report.fldResourceID.Suppress = True
        // Report.txtTitle.SetText "Colors Selected"
        // ' (data, [dataTag], [tableNumber]) '
        // Report.Database.SetDataSource rs
        // ' ViewReport Report, 100 '
        // ExportOptions.DestinationType = crEDTDiskFile   ' Set the destination type to Disk File '
        // If gsDatabase = "HCHData" Then
        // sName = gsJobExportPath & sJobID & "\DOCS\Colors.pdf"
        // ExportOptions.DiskFileName = sName                  ' gsFaxDocPath & CStr(lPONum) & ".pdf"      ' Set the path and disk filename '
        // ExportOptions.FormatType = crEFTPortableDocFormat   ' Set the Format type to PDF                                                 '
        // Report.Export False                                 ' Export the report and set the export prompting parameter to false          '
        // 'CreateDocumentsToSee "Colors.pdf", "jobs\" & sJobID & "\DOCS\", lJobID, dtColorSelections, gsUserID
        // '==========================
        // '    10/31/2005 mrb don't make documents anymore just the pdf
        // '==========================
        // End If
        // Set ExportOptions = Nothing
        // Set Report = Nothing
        // Set cDB = Nothing
        // Set rs = Nothing
        // 
        // Exit Sub
        // ErrHandler:
        // MsgBox Err.Description, vbCritical, "ExportSelections"
        // Set cDB = Nothing
        // Set rs = Nothing
        // Set ExportOptions = Nothing
        // 
        // 
        // End Sub
        // 6/8/12 mrb ***
        // Public Function CreateJobFolders(sJobID As String) As Boolean
        // Dim sPath As String
        // Dim oFS As FileSystemObject
        // Dim bGoOn As Boolean
        // '==========================
        // '    Michele Brown  9/15/2011
        // ' add active directory information
        // '==========================
        // Dim usr As IADsUser
        // 
        // On Error GoTo ErrHandler
        // ' ==========================      '
        // ' Michele Brown  5/18/2011        '
        // ' so we don't overwrite live data '
        // ' ==========================      '
        // If gsDatabase = "HCHData" Then
        // Set oFS = New FileSystemObject
        // ' ==========================                                     '
        // ' 7/7/2005  Michele Brown  revised to report missing main folder '
        // ' ==========================                                     '
        // ' ==========================                                     '
        // ' Michele Brown  12/13/2010                                      '
        // ' change to gsjobexportpath - new file server                    '
        // ' ==========================                                     '
        // ' sPath = gsExportServer & "Jobs\"                               '
        // sPath = gsJobExportPath
        // '==========================
        // '    Michele Brown  9/15/2011
        // '  add active directory info to set security
        // '==========================
        // 'Set usr = GetObject("LDAP://CN=Bossfiles,CN=users,DC=henry-homes,DC=com")
        // 
        // If oFS.FolderExists(sPath) Then
        // sPath = sPath & sJobID
        // If Not oFS.FolderExists(sPath) Then
        // bGoOn = True
        // oFS.CreateFolder (sPath)
        // End If
        // ' If bGoOn Then '
        // If Not oFS.FolderExists(sPath & "\docs") Then
        // oFS.CreateFolder sPath & "\DOCS"
        // End If
        // If Not oFS.FolderExists(sPath & "\cad") Then
        // oFS.CreateFolder sPath & "\CAD"
        // End If
        // ' ==========================      '
        // ' Michele Brown  11/18/2008       '
        // ' added folder for walk documents '
        // ' ==========================      '
        // If Not oFS.FolderExists(sPath & "\walks") Then
        // oFS.CreateFolder sPath & "\walks"
        // End If
        // ' End If '
        // '==========================
        // '    Michele Brown  8/11/2011
        // '  add folders for contracts and closings
        // '==========================
        // If Not oFS.FolderExists(sPath & "\Contract") Then
        // oFS.CreateFolder sPath & "\Contract"
        // End If
        // If Not oFS.FolderExists(sPath & "\Layouts") Then
        // oFS.CreateFolder sPath & "\Layouts"
        // End If
        // If Not oFS.FolderExists(sPath & "\Commissions") Then
        // oFS.CreateFolder sPath & "\Commissions"
        // End If
        // If Not oFS.FolderExists(sPath & "\Disclosures") Then
        // oFS.CreateFolder sPath & "\Disclosures"
        // End If
        // If Not oFS.FolderExists(sPath & "\Lender") Then
        // oFS.CreateFolder sPath & "\Lender"
        // End If
        // '12/0/11 mrb take out til 2010
        // 'If SetSecurityContractFolders(sPath) Then
        // 'End If
        // CreateJobFolders = True
        // End If    '}-> If oFS.FolderExists(sPath) Then
        // Else
        // CreateJobFolders = True
        // End If    '}-> If gsDatabase = "HCHData" Then
        // Exit Function
        // ErrHandler:
        // MsgBox Err.Description, vbInformation, "CreateJobFolders"
        // If Err.Description = "Automation Error. A referral was returned from the server." Then
        // Resume
        // End If
        // 
        // 
        // End Function
        // Public Sub LoadProjectBuilders(ThisLstView As ListView, iProjectID As Integer)
        // Dim itmX As ListItem
        // Dim cEDR As GetData
        // Dim vTmp As Object
        // Dim iINDEX As Integer
        // Dim iRows As Integer
        // Const colLastName = 0
        // Const colFirstName = 1
        // Const colSIId = 2
        // Const colProjectID = 3
        // Const colProjBldrID = 4

        // ' Dim iProjectID As Integer '

        // ' On Error Resume Next '
        // On Error GoTo ErrHandler
        // cEDR = New GetData
        // vTmp = ""
        // vTmp = cEDR.GetAList(ltProjectBuilders)

        // ' SELECT SIId, fName,lname, ProjectID, ProjBldrID           '
        // ' FROM SecurityInfo s                                       '
        // ' LEFT OUTER JOIN ProjectBuilders p ON p.BuilderID = s.SIID '

        // ' Where PositionID = 1 - -builders '
        // ' cboBuilders.Clear                '
        // ' cboBuilders.AddItem "(Choose)"   '
        // ThisLstView.ListItems.Clear()
        // ThisLstView.CheckBoxes = False


        // If IsArray(vTmp) Then
        // iRows = UBound(vTmp, 2)
        // For iINDEX = 0 To iRows
        // ' cboBuilders.AddItem vtmp(1, iindex)                          '
        // ' cboBuilders.ItemData(cboBuilders.NewIndex) = vtmp(0, iindex) '
        // If vTmp(3, iINDEX) = iProjectID Then
        // itmX = ThisLstView.ListItems.Add(, , vTmp(2, iINDEX) + ", " + vTmp(1, iINDEX))   ' last name + first name  '
        // itmX.SubItems(colFirstName) = vTmp(1, iINDEX)                                        ' First name              '
        // itmX.SubItems(colSIId) = Str(vTmp(0, iINDEX))                                        ' SecurityInfo.SIId       '
        // itmX.SubItems(colProjectID) = Str(vTmp(3, iINDEX))                                   ' ProjectID (projects.id) '
        // itmX.SubItems(colProjBldrID) = Str(vTmp(4, iINDEX))                                  ' ProjBldrID              '
        // End If
        // Next iINDEX
        // ' cboBuilders.ListIndex = 0 '
        // End If
        // cEDR = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadProjectBuilders")
        // cEDR = Nothing
        // End Sub
        // Public Sub LoadAllBuildersLstView(ThisLstView As ListView, iProjectID As Integer)
        // Dim itmX As ListItem

        // Dim i As Integer
        // Dim lngSIID() As Long
        // Dim lngCount As Long
        // Dim blnGo As Boolean
        // Dim cEDR As GetData
        // Dim vTmp As Object
        // Dim iINDEX As Integer
        // Dim iRows As Integer

        // ' On Error Resume Next '
        // On Error GoTo ErrHandler

        // cEDR = New GetData
        // vTmp = ""
        // vTmp = cEDR.GetAList(ltBuilders)

        // '-----------------------Recode on 3/2 8/03
        // 'compare the SIID
        // With ThisLstView
        // lngCount = .ListItems.Count
        // ReDim lngSIID(lngCount)
        // For i = 1 To lngCount
        // lngSIID(i) = CLng(.ListItems(i).SubItems(2))
        // 'Mark as checked for those that are already on the list
        // .ListItems(i).Checked = True
        // Next i
        // End With

        // If IsArray(vTmp) Then
        // iRows = UBound(vTmp, 2)
        // End If
        // 'Loop through all the builders and add it to the list for those that aren't there yet
        // For iINDEX = 0 To iRows
        // blnGo = True 'Initialized to true
        // With ThisLstView
        // For i = 1 To lngCount
        // If lngSIID(i) = vTmp(0, iINDEX) Then
        // blnGo = False
        // Exit For
        // End If
        // Next i

        // If blnGo Then
        // itmX = .ListItems.Add(, , vTmp(1, iINDEX))    ' last name + first name '
        // itmX.SubItems(1) = "" 'FirstName
        // itmX.SubItems(2) = vTmp(0, iINDEX) ' securityinfo.siid
        // itmX.SubItems(3) = 0 ' ProjectID, 0 is the default for not exist
        // itmX.SubItems(4) = 0 ' ProjBldrID, 0 is the default for not exist
        // End If
        // End With
        // Next iINDEX

        // cEDR = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadAllBuildersLstView")
        // cEDR = Nothing
        // End Sub

        // Public Sub LoadBuilderCombo(ThisCombo As SSDBCombo, _
        // Optional ByVal sFirstRowText As String = "(Choose)")
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset

        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spGetBuilderList")

        // If ThisCombo.Rows > 0 Then ThisCombo.RemoveAll()

        // ThisCombo.AddItem(sFirstRowText & vbTab & "0")

        // With rs
        // Do While Not .EOF
        // ThisCombo.AddItem!Builder(+vbTab & vbTab & !SIId)
        // .MoveNext()
        // Loop
        // End With

        // ComboFirstRow(ThisCombo, sFirstRowText)

        // Exit Sub

        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadBuilderCombo")
        // End Sub
        // Public Function LoadJobIDs(ByRef ThisCombo As SSDBCombo, _
        // Optional ByVal lBuilderID As Long = 0, _
        // Optional ByVal sFirstRowText As String = "(Choose)", _
        // Optional ByVal sCalledBy As String = "") As Boolean

        // Dim oDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim str As String

        // On Error GoTo ErrHandler

        // oDB = New DBCalls
        // If lBuilderID = 0 Then
        // rs = oDB.GetRecordsFromSP("spGetAllJobs")
        // Else
        // rs = oDB.GetRecordsFromSP("spGetAllJobsForBuilder", lBuilderID)
        // End If

        // If ThisCombo.Rows > 0 Then ThisCombo.RemoveAll()

        // ThisCombo.AddItem(sFirstRowText & vbTab & vbNullString & vbTab & "0")
        // With rs
        // Do While Not .EOF
        // str = !JobID & vbTab & _
        // !JobName & vbTab & _
        // !ID
        // If sCalledBy = "VendorComparison" Then
        // str = str & vbTab & IIf(IsNull(!PlanID), "", !PlanID)
        // str = str & vbTab & IIf(IsNull(!ReleaseToCAD), "", !ReleaseToCAD)
        // End If
        // ThisCombo.AddItem(str)
        // .MoveNext()
        // Loop
        // End With
        // ComboFirstRow(ThisCombo, sFirstRowText)

        // oDB = Nothing
        // rs = Nothing

        // LoadJobIDs = True

        // Exit Function

        // ErrHandler:
        // oDB = Nothing
        // rs = Nothing
        // MsgBox(Err.Description, vbCritical, "LoadJobIDs")
        // End Function
        // Public Sub LoadVendors(ThisCombo As SSDBCombo, sCalledBy As String, Optional sVendor As String = "")
        // Dim i As Integer
        // Dim iRows As Integer
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim sStr As String
        // Dim bGoOn As Boolean
        // On Error GoTo HandleErrors

        // ' Set cEDR = New GetData          '
        // ' vTmp = cEDR.GetAList(ltVendors) '
        // ' Set cEDR = Nothing              '

        // cDB = New DBCalls
        // If sCalledBy = "AssignVendors" Or sCalledBy = "LoadCombo" Or sCalledBy = "DrawMaintenance" Then
        // rs = cDB.GetRecordsFromSP("spGetVendorsInUse")   ' all vendors '
        // ElseIf sCalledBy = "VendorComparison" Then
        // rs = cDB.GetRecordsFromSP("spGetVendorsByAlpha", sVendor)
        // Else
        // rs = cDB.GetRecordsFromSP("spGetVendorsNotGeneric")
        // End If
        // ThisCombo.RemoveAll()
        // ThisCombo.AddItem("(Choose)" & vbTab & " ")

        // Do While Not rs.EOF
        // If ThisCombo.Name = "ssdbNewVendor" Then
        // If rs!vdrName <> sVendor Then
        // sStr = rs!vdrName & vbTab
        // sStr = sStr & rs!VendorID
        // ThisCombo.AddItem(sStr)
        // End If
        // Else
        // If (sCalledBy = "DrawMaintenance") Then
        // bGoOn = rs!DrawsExist = 1
        // ElseIf sCalledBy <> "DrawMaintenance" Then
        // bGoOn = True
        // End If
        // If bGoOn Then
        // sStr = rs!vdrName & vbTab
        // sStr = sStr & rs!VendorID
        // ThisCombo.AddItem(sStr)
        // End If
        // End If    '}-> If ThisCombo.Name = "ssdbNewVendor" Then
        // ' ThisCombo.AddItem sStr '
        // rs.MoveNext()
        // Loop    '}-> Do While Not rs.EOF

        // If ThisCombo.Rows > 0 Then
        // ComboFirstRow(ThisCombo)
        // End If
        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // HandleErrors:
        // MsgBox("The following error has occurred in LoadVendors: " & Err.Number & " " & Err.Description)
        // cDB = Nothing
        // rs = Nothing
        // End Sub
        // Public Sub LoadResources(ThisCombo As SSDBCombo, sCalledBy As String, Optional sAlpha As String)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sString As String
        // Dim bAdd As Boolean
        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // ' Select ResourceID, ResourceName, AlphaCode,[ID] '

        // rs = cDB.GetRecordsFromSP("spGetResources")
        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ThisCombo.AddItem("(Choose)" & vbTab & "" & vbTab)
        // Do While Not rs.EOF
        // If (sCalledBy = "DrawMaintenance" And rs!RequiresDraws = True) _
        // Or sCalledBy = "LoadAll" Then
        // bAdd = True
        // ElseIf sCalledBy = "ByAlpha" Then
        // bAdd = sAlpha = rs!AlphaCode
        // End If
        // If bAdd Then
        // sString = rs!ResourceID
        // sString = sString & vbTab & rs!ResourceName
        // sString = sString & vbTab & rs!ID
        // ThisCombo.AddItem(sString)
        // End If
        // rs.MoveNext()
        // Loop
        // 'ThisCombo.MoveFirst
        // ComboFirstRow(ThisCombo)

        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadResources")
        // cDB = Nothing
        // rs = Nothing
        // End Sub
        // Public Sub LoadDivisionMgrCombo(ThisCombo As SSDBCombo)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sString As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spGetUserListByPosition", 3)
        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ThisCombo.AddItem("(Choose)" & vbTab & "")
        // Do While Not rs.EOF
        // sString = rs!FName
        // sString = sString & " " & rs!LName
        // sString = sString & vbTab & CStr(rs!SIId)
        // ThisCombo.AddItem(sString)
        // rs.MoveNext()
        // Loop
        // ComboFirstRow(ThisCombo)
        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description)
        // cDB = Nothing
        // rs = Nothing

        // End Sub
        // Public Sub LoadProdMgrCombo(ThisCombo As SSDBCombo)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sString As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spGetUserListByPosition", 2)
        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ThisCombo.AddItem("(Choose)" & vbTab & "")
        // Do While Not rs.EOF
        // sString = rs!FName
        // sString = sString & " " & rs!LName
        // sString = sString & vbTab & CStr(rs!SIId)
        // ThisCombo.AddItem(sString)
        // rs.MoveNext()
        // Loop
        // ComboFirstRow(ThisCombo)
        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description)
        // cDB = Nothing
        // rs = Nothing

        // End Sub
        // mrb 6/8/12 ***
        // Public Sub UncostedResourcesCheck(sJobID As String, sCalledBy As String)
        // Dim sMsg As String
        // 
        // On Error GoTo HandleErrors
        // 
        // UncostedResources.sCalledBy = sCalledBy
        // UncostedResources.sJobID = sJobID
        // If UncostedResources.ProblemsExist = True Then   ' uncosted items '
        // ' MsgBox "Uncosted Resources or Multiple Vendors for one Acitivity included in Job!" '
        // Else
        // MsgBox "No Problems found with this Job!"
        // End If
        // 
        // Exit Sub
        // HandleErrors:
        // Screen.MousePointer = vbDefault
        // MsgBox Err.Description, vbCritical, "UncostedResourcesCheck"
        // End Sub
        // mrb 6/8/12 ***
        // Public Sub LoadResourcesForActivity(ThisCombo As SSDBCombo, lActivity As Long)
        // ' On Error Resume Next '
        // Dim sString As String
        // Dim vTmp As Variant
        // Dim cEP As ProcessMethods
        // Dim i As Integer
        // 
        // On Error GoTo ErrHandler
        // 
        // vTmp = ""
        // Set cEP = New ProcessMethods
        // vTmp = cEP.GetAssociatedResources(lActivity)
        // Set cEP = Nothing
        // With ThisCombo
        // If .Rows > 0 Then
        // .RemoveAll
        // End If
        // .AddItem "(Choose)"
        // End With
        // 
        // If IsArray(vTmp) Then
        // For i = 0 To UBound(vTmp, 2)
        // sString = Trim(vTmp(0, i)) & " - " & Trim(vTmp(1, i)) & vbTab & vTmp(0, i)
        // ThisCombo.AddItem sString
        // Next i
        // End If
        // ComboFirstRow ThisCombo
        // Exit Sub
        // ErrHandler:
        // MsgBox Err.Description, vbCritical, "LoadResourcesForActivity"
        // Set cEP = Nothing
        // 
        // End Sub
        // Public Sub LoadPlanIDs(ctl As Control)
        // ' On Error Resume Next '
        // Dim cGD As GetData
        // Dim vTmp As Object
        // Dim iINDEX As Integer

        // On Error GoTo ErrHandler
        // cGD = New GetData
        // vTmp = ""
        // vTmp = cGD.GetAList(ltPlans)
        // If TypeOf ctl Is ComboBox Then
        // ctl.Clear()
        // Else
        // If ctl.Rows > 0 Then
        // ctl.RemoveAll()
        // End If
        // End If
        // ctl.AddItem("(Choose)")
        // If IsArray(vTmp) Then
        // For iINDEX = 0 To UBound(vTmp, 2)
        // ctl.AddItem(vTmp(0, iINDEX))
        // Next iINDEX
        // If TypeOf ctl Is ComboBox Then
        // ctl.ListIndex = 0
        // Else
        // ComboFirstRow(ctl)
        // End If
        // End If
        // cGD = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadPlanIDs")
        // cGD = Nothing
        // End Sub
        // ***mrb 6/8/12
        // Public Sub LoadActivities(ThisCombo As SSDBCombo, Optional bPOOnly As Boolean)
        // Dim sString As String
        // Dim cEM As MaintData
        // Dim vTmp As Variant
        // Dim lindex As Long
        // '==========================
        // '    Michele Brown  7/13/2011
        // '  we need to take out non-paid activities
        // '==========================
        // On Error GoTo ErrHandler
        // 
        // Set cEM = New MaintData
        // vTmp = ""
        // vTmp = cEM.GetActivities
        // Set cEM = Nothing
        // 
        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll
        // End If
        // 
        // ThisCombo.AddItem "(Choose) "
        // If IsArray(vTmp) Then
        // For lindex = 0 To UBound(vTmp, 2)
        // If (bPOOnly And LCase(vTmp(2, lindex)) <> 98) Or _
        // bPOOnly = False Then
        // 'mrb 7/13/11 check to see if this is an activity that will be paid in boss
        // sString = vTmp(0, lindex) & " - " & vTmp(1, lindex) & vbTab & vTmp(0, lindex)
        // 
        // ThisCombo.AddItem sString
        // End If
        // Next lindex
        // End If
        // Set cEM = Nothing
        // ComboFirstRow ThisCombo
        // 
        // Exit Sub
        // ErrHandler:
        // MsgBox Err.Description, vbCritical, "LoadActivities"
        // Set cEM = Nothing
        // 
        // End Sub
        // Public Function LstBxSelsString(oLst As ListBox) As String
        // Dim i As Integer
        // Dim j As Integer
        // Dim k As Integer

        // Dim sStr As String

        // On Error GoTo ErrHandler
        // j = 0
        // If oLst.ListCount > 0 Then
        // k = oLst.ListCount - 1
        // For i = 0 To k
        // oLst.ListIndex = i
        // If oLst.Selected(i) = True Then
        // If Len(sStr) > 0 Then
        // sStr = sStr & "',"
        // 'ElseIf i = k Then
        // '  sStr = sStr & "')"
        // ElseIf Len(sStr) = 0 Then
        // sStr = "("
        // End If
        // sStr = sStr & "'" & Trim(Left(Trim(oLst.Text), InStr(1, oLst.Text, "-") - 1))
        // j = j + 1 '
        // End If
        // 'j = j + 1
        // Next i
        // End If    '}-> If oLst.ListCount > 0 Then

        // If j > 0 Then
        // LstBxSelsString = sStr & "')"
        // End If

        // Exit Function

        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LstBxSelsString")
        // End Function
        // Public Sub LoadDivisionCombo(ThisCombo As SSDBCombo)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sString As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spGetDivisionNames")
        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ThisCombo.AddItem("(Choose)" & vbTab & "" & vbTab & "")
        // Do While Not rs.EOF
        // sString = rs!Division
        // sString = sString & vbTab & CStr(rs!DivisionID)
        // ThisCombo.AddItem(sString)
        // rs.MoveNext()
        // Loop
        // ComboFirstRow(ThisCombo)
        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description)
        // cDB = Nothing
        // rs = Nothing

        // End Sub
        // Public Sub LoadSelectionCategories(ThisCombo As SSDBCombo)
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim sStr As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetSelectionCategories")
        // With ThisCombo
        // If .Rows > 0 Then .RemoveAll()
        // .AddItem("(Choose)")
        // ' mrb 4/28/11 add two new fields '
        // Do While Not rs.EOF
        // sStr = rs!Category & vbTab & rs!CatID & vbTab
        // If rs!InActive = True Then
        // sStr = sStr & vbTrue
        // Else
        // sStr = sStr & vbFalse
        // End If
        // sStr = sStr & vbTab
        // If rs!forOptions = True Then
        // sStr = sStr & vbTrue
        // Else
        // sStr = sStr & vbFalse
        // End If
        // sStr = sStr & vbTab
        // If rs!SumForOptions = True Then
        // sStr = sStr & vbTrue
        // Else
        // sStr = sStr & vbFalse
        // End If

        // .AddItem(sStr)          ' rs!Category & vbTab & rs!CatID & vbTab & rs!InActive & rs!ForOptions & rs!SumForOptions '
        // rs.MoveNext()
        // Loop    '}-> Do While Not rs.EOF
        // ' .MoveFirst               '
        // ' .Text = .Columns(0).Text '
        // ComboFirstRow(ThisCombo)
        // End With    '}-> With ThisCombo

        // cDB = Nothing
        // rs = Nothing

        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadCategories")
        // cDB = Nothing
        // rs = Nothing

        // End Sub

        // Public Sub LoadSelectionGroups(ThisCombo As SSDBCombo)
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset

        // On Error GoTo ErrHandler

        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetSelectionGroups")
        // With ThisCombo
        // If .Rows > 0 Then .RemoveAll()
        // .AddItem("(Choose)")

        // Do While Not rs.EOF
        // .AddItem(rs!GroupName & vbTab & rs!SelGroupID)
        // rs.MoveNext()
        // Loop
        // '.MoveFirst
        // '.Text = .Columns(0).Text
        // ComboFirstRow(ThisCombo)
        // End With

        // cDB = Nothing
        // rs = Nothing

        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadSelectionGroups")
        // cDB = Nothing
        // rs = Nothing

        // End Sub

        // Public Sub LoadOptionCategories(ThisCombo As SSDBCombo)
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset

        // On Error GoTo ErrHandler

        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetOptionPackageCategories")
        // With ThisCombo
        // If .Rows > 0 Then .RemoveAll()
        // .AddItem("(Choose)")

        // Do While Not rs.EOF
        // .AddItem(rs!UpgradeCategory & vbTab & rs!UpgCatID & vbTab & rs!InActive & vbTab & rs!ProductionOnly)
        // rs.MoveNext()
        // Loop
        // '.MoveFirst
        // '.Text = .Columns(0).Text
        // ComboFirstRow(ThisCombo)
        // End With

        // cDB = Nothing
        // rs = Nothing

        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "LoadOptionCategories")
        // cDB = Nothing
        // rs = Nothing
        // Resume Next

        // End Sub

        // Public Sub LoadUseCodes(ThisCombo As SSDBCombo)
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset

        // On Error GoTo ErrHandler
        // cDB = New DBCalls

        // rs = cDB.GetRecordsFromSP("spGetUsagesAll")
        // With ThisCombo
        // If ThisCombo.Rows > 0 Then
        // .RemoveAll()
        // End If
        // .AddItem("" & vbTab & "")
        // End With
        // Do While Not rs.EOF
        // With ThisCombo
        // .AddItem(rs!UsageDescription & vbTab & rs!ResUsage)
        // End With
        // rs.MoveNext()
        // Loop
        // cDB = Nothing
        // Exit Sub

        // ErrHandler:

        // MsgBox(Err.Description, vbCritical, , "LoadUseCodes")
        // cDB = Nothing
        // End Sub
        // Public Sub LoadPOPayStatus(ThisCombo As SSDBCombo)
        // Dim rs As ADODB.Recordset
        // Dim cDB As DBCalls
        // Dim sString As String

        // On Error GoTo ErrHandler

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spPOPayStatusGet")
        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ThisCombo.AddItem("(Choose)" & vbTab & "")
        // Do While Not rs.EOF
        // sString = rs!Status & vbTab
        // sString = sString & rs!StatusID
        // ThisCombo.AddItem(sString)
        // rs.MoveNext()
        // Loop
        // ComboFirstRow(ThisCombo)
        // cDB = Nothing
        // rs = Nothing
        // Exit Sub
        // ErrHandler:
        // MsgBox(Err.Description)
        // cDB = Nothing
        // rs = Nothing
        // End Sub
        // Public Function CalculatePrice(ByVal cMargin As Currency, ByVal cCost As Currency, Optional ByVal cLotCost As Currency = 0) As Long
        // Dim cTemp As Currency
        // Dim cRound

        // On Error GoTo ErrHandler
        // ' Round to either xxx400 or xxx900 mb 3/23/04 '

        // If cCost <> 0 Then
        // ' cTemp = (cMargin + 1) * cCost '
        // cTemp = cCost / (1 - cMargin) + cLotCost
        // cRound = Round(cTemp / 1000, 0) * 1000
        // If cTemp > cRound Then
        // cTemp = cRound + 400
        // Else
        // cTemp = cRound - 100
        // End If
        // ' If cTemp < 100000 Then                          '
        // ' cTemp = (Round(cTemp / 1000, 0) * 1000) - 100   '
        // ' Else                                            '
        // ' cTemp = (Round(cTemp / 10000, 0) * 10000) - 100 '
        // ' End If                                          '
        // ' cTemp = cTemp - 100                             '
        // CalculatePrice = cTemp
        // Else
        // CalculatePrice = 0
        // End If    '}-> If cCost <> 0 Then
        // Exit Function
        // ErrHandler:
        // MsgBox(Err.Description, vbCritical, "CalculatePrice")
        // End Function
        // Public Sub ShowPDFHelp(sFileName As String)
        // Dim sPath As String
        // Dim sAcrobatPath As String
        // Dim oFS As FileSystemObject
        // Dim bExists As Boolean
        // oFS = New FileSystemObject
        // sAcrobatPath = "c:\program files\adobe\acrobat 7.0\reader\acrord32.exe"
        // bExists = oFS.FileExists(sAcrobatPath)
        // If Not bExists Then
        // sAcrobatPath = "c:\program files\adobe\acrobat 6.0\reader\acrord32.exe"
        // bExists = oFS.FileExists(sAcrobatPath)
        // End If
        // If Not bExists Then
        // sAcrobatPath = "c:\program files\adobe\acrobat 5.0\reader\acrord32.exe"
        // bExists = oFS.FileExists(sAcrobatPath)
        // End If
        // If bExists Then
        // sAcrobatPath = "c:\program files\adobe\acrobat 7.0\reader\acrord32.exe"
        // sPath = App.Path & "\jcpohelp\" & sFileName
        // Shell(sAcrobatPath & " " & sPath, vbNormal)
        // Else
        // MsgBox("You need to have Acrobat Reader installed to see this help file")
        // End If

        // End Sub
        // 6/8/12 mrb ***
        // Public Sub ExportWalks(ByVal sJobID As String)
        // ' ========================== '
        // ' Michele Brown  11/18/2008  '
        // ' new reports for eboss      '
        // ' ========================== '
        // Dim Report As rptQualityWalk
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim ExportOptions As CRAXDRT.ExportOptions   ' Declare the ExportOptions object '
        // ' Dim sName As String '
        // Dim sName As String
        // 
        // On Error GoTo ErrHandler
        // 
        // Set Report = New rptQualityWalk
        // Set ExportOptions = Report.ExportOptions   ' Set the ExportOptions variable '
        // 
        // 
        // Set cDB = New DBCalls
        // 
        // ' Set rs = cDB.GetRecordsFromSP("spRptWalkThrough", 1) '
        // '==========================
        // '    Michele Brown  4/23/2009
        // ' this was exporting in different formats and the data wasn't changing
        // '  added report.discardsaveddata
        // '==========================
        // Report.txtJobID.SetText sJobID
        // ' (data, [dataTag], [tableNumber]) '
        // ' Report.Database.SetDataSource rs '
        // ' ViewReport Report, 100           '
        // ExportOptions.DestinationType = crEDTDiskFile   ' Set the destination type to Disk File                          '
        // ExportOptions.FormatType = crEFTExactRichText   ' crEFTEditableRichText    ' Set the Format type to Editable rtf '
        // If gsDatabase = "HCHData" Then
        // Report.DiscardSavedData
        // Set rs = cDB.GetRecordsFromSP("spRptWalkThrough", 1)
        // Report.Database.SetDataSource rs
        // sName = gsJobExportPath & sJobID & "\walks\qwalk1.doc"
        // ExportOptions.DiskFileName = sName
        // Report.Export False        ' Export the report and set the export prompting parameter to false '
        // 
        // Report.DiscardSavedData
        // Set rs = cDB.GetRecordsFromSP("spRptWalkThrough", 2)
        // Report.Database.SetDataSource rs
        // sName = gsJobExportPath & sJobID & "\walks\qwalk2.doc"
        // ' ExportOptions.FormatType = crEFTWordForWindows '
        // ExportOptions.DiskFileName = sName
        // Report.Export False
        // 
        // ' rs.Close '
        // Report.DiscardSavedData
        // Set rs = cDB.GetRecordsFromSP("spRptWalkThrough", 3)
        // Report.Database.SetDataSource rs
        // sName = gsJobExportPath & sJobID & "\walks\qwalk3.doc"
        // ExportOptions.DiskFileName = sName
        // Report.Export False
        // 
        // Report.DiscardSavedData
        // Set rs = cDB.GetRecordsFromSP("spRptWalkThrough", 4)
        // sName = gsJobExportPath & sJobID & "\walks\qwalk4.doc"
        // ExportOptions.DiskFileName = sName
        // Report.Database.SetDataSource rs
        // 
        // Report.Export False
        // End If    '}-> If gsDatabase = "HCHData" Then
        // Set ExportOptions = Nothing
        // Set Report = Nothing
        // Set cDB = Nothing
        // Set rs = Nothing
        // 
        // Exit Sub
        // ErrHandler:
        // MsgBox Err.Description, vbCritical, "ExportSelections"
        // Set cDB = Nothing
        // Set rs = Nothing
        // Set ExportOptions = Nothing
        // 
        // 
        // End Sub
        public static object SetMDICaption()
        {
            object SetMDICaptionRet = default;
            switch (modGlobals.gsDatabase??"")
            {
                case var case1 when CultureInfo.CurrentCulture.CompareInfo.Compare(case1, "HCHData", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                    {
                        modGlobals.gsVersion="**LIVE DATA**  ";
                        break;
                    }
                case var case2 when CultureInfo.CurrentCulture.CompareInfo.Compare(case2, "HCHDataTest", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                    {
                        modGlobals.gsVersion="**TEST DATA**  ";
                        break;
                    }
                case var case3 when CultureInfo.CurrentCulture.CompareInfo.Compare(case3, "HCHDataQA", CompareOptions.IgnoreCase|CompareOptions.IgnoreKanaType|CompareOptions.IgnoreWidth)==0:
                    {
                        // ==========================
                        // Michele Brown  7/29/2010
                        // change from qa to cost analysis
                        // ==========================
                        // gsVersion = "**QA DATA**  "
                        modGlobals.gsVersion="**COST ANALYSIS DATA**  ";
                        break;
                    }
            }    // }-> Select Case gsDatabase

            //modGlobals.gsVersion=Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(modGlobals.gsVersion+"Version: ", App().Major), "."), App().Minor), "."), App().Revision));
            modGlobals.gsVersion=Version();
            SetMDICaptionRet="B.O.S.S.Admin"+" "+modGlobals.gsVersion;
            return SetMDICaptionRet;
            // ??? mrb for testing only 5/18/11
            // mrb 6/4/11 live!
            // SetMDICaption = SetMDICaption & " for TESTING only"
        }
        // Public Sub LoadTitleInsCompanies(ByRef ThisCombo As SSDBCombo, ByVal iType As Integer)
        // Dim cDB As DBCalls
        // Dim rs As ADODB.Recordset
        // Dim sStr As String
        // ' ==========================           '
        // ' Michele Brown  8/13/2011             '
        // ' for customercontract, jobs, projects '
        // ' ==========================           '
        // On Error GoTo ErrHandler

        // If ThisCombo.Rows > 0 Then
        // ThisCombo.RemoveAll()
        // End If
        // ' itype = 0 then Buyer title Ins    '
        // ' itype = 1 then Original title ins '

        // ThisCombo.AddItem("(Choose)")

        // cDB = New DBCalls
        // rs = cDB.GetRecordsFromSP("spTitleInsuranceCompanyGet", iType)
        // Do While Not rs.EOF
        // sStr = rs!CompanyName & vbTab
        // sStr = sStr & rs!CompanyID
        // ThisCombo.AddItem(sStr)
        // rs.MoveNext()
        // Loop

        // rs = Nothing
        // cDB = Nothing
        // ' ========================== '
        // ' Michele Brown  8/24/2011   '
        // '                            '
        // ' ========================== '
        // ComboFirstRow(ThisCombo)
        // Exit Sub
        // ErrHandler:
        // rs = Nothing
        // cDB = Nothing
        // MsgBox(Err.Description, vbCritical, "LoadTitleInsCompanies")

        // End Sub
        // mrb 6/8/12 ***
        // Private Function SetSecurityContractFolders(ByVal sJobPath As String) As Boolean
        // ' 12/2/11 to set security on contract folders '
        // Dim usr As IADsUser
        // On Error GoTo ErrHandler
        // 'Dim oImpersonate As windowsapplication.impersonate
        // 
        // If IDERunning Then
        // Dim strBaseDN, strDNSDomain, oRootDSE
        // Set oRootDSE = GetObject("LDAP://rootDSE")
        // strBaseDN = "LDAP://" & oRootDSE.Get("defaultNamingContext")
        // strDNSDomain = oRootDSE.Get("defaultNamingContext")
        // ' * use this line " & strDNSDomain '
        // MsgBox "User DNS domain = " & oRootDSE.Get("defaultNamingContext")
        // ' * find domain name - Dotted - need LDAP domain as well for this part '
        // Dim arrDomain, intCountstrDotDomain, intCount, strDotDomain
        // arrDomain = Split(oRootDSE.Get("defaultNamingContext"), ",")
        // For intCount = 0 To UBound(arrDomain)
        // strDotDomain = strDotDomain & "." & Mid(arrDomain(intCount), 4)
        // Next
        // strDotDomain = Mid(strDotDomain, 2)
        // MsgBox "Dotted Domain = " & strDotDomain
        // ' * find domain name - NetBIOS '
        // Dim WshNetwork, strDomainName
        // ' Set WshNetwork = WScript.CreateObject("WScript.Network") '
        // Set WshNetwork = CreateObject("WScript.Network")
        // strDomainName = WshNetwork.UserDomain
        // MsgBox "User NetBIOS domain = " & WshNetwork.UserDomain
        // Set usr = GetObject("LDAP://CN=mbrown, CN=users, DC=micheleshouse, DC=com")
        // Else
        // Set usr = GetObject("LDAP://CN=Bossfiles, CN=users, DC=henry-homes, DC=com")
        // End If    '}-> If IDERunning Then
        // 
        // Exit Function
        // ErrHandler:
        // MsgBox Err.Description, vbCritical, "SetSecurityContractfolders"
        // End Function

        private static object App()
        {
            throw new NotImplementedException();
        }

        private static long ProcessRunning(string ProcessName)
        {
            long iReturn;
            try
            {
                iReturn=Convert.ToInt64(Process.GetProcessesByName(Strings.LCase(ProcessName)).GetUpperBound(0)+1);
            }
            catch
            {
                iReturn=0L;
            }
            return iReturn;
        }
        public static void EnableDisableToolStrip(bool bEdit, ToolStrip tsToolstrip, UltraGrid grdGrid, string sObjectName, string sObjectType)
        {
            // mrb 7/27/12
            bool bCanEdit;

            bCanEdit=HasEditSecurity(sObjectName, sObjectType)&!bEdit;
            tsToolstrip.Items["tsBtnAdd"].Enabled=bCanEdit;
            tsToolstrip.Items["tsBtnEdit"].Enabled=bCanEdit;
            tsToolstrip.Items["tsBtnUndo"].Enabled=bEdit;
            tsToolstrip.Items["tsBtnSave"].Enabled=bEdit;
            tsToolstrip.Items["tsBtnPrint"].Enabled=!bEdit;
            if (bEdit)  // can only be bEdit if they were able to click Add or Edit button
            {
                grdGrid.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
            }
            else
            {
                grdGrid.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
            }
        }

        public static void InsertError(string sStr, string sErrorType, string sCreatedBy)
        {
            // mrb 8/2/12 created to record big files, etc.
            var oCMD = new SqlCommand();

            try
            {
                // DECLARE @RC int
                // DECLARE @ErrorType nvarchar(50)
                // DECLARE @ErrorMessage nvarchar(200)
                // DECLARE @CreatedBy nvarchar(100)

                // -- TODO: Set parameter values here.

                // EXECUTE @RC = [HCHData].[dbo].[spErrorInsert] 
                // @ErrorType
                // ,@ErrorMessage
                // ,@CreatedBy            

                {
                    ref var withBlock = ref oCMD;
                    withBlock.Connection=modGlobals.gCN;
                    withBlock.CommandType=CommandType.StoredProcedure;
                    withBlock.CommandText="spErrorInsert";
                    withBlock.Parameters.AddWithValue("@ErrorType", sErrorType);
                    withBlock.Parameters.AddWithValue("@ErrorMessage", sStr);
                    withBlock.Parameters.AddWithValue("@CreatedBy", sCreatedBy);
                    withBlock.ExecuteNonQuery();
                }
            }
            catch
            {
                if (Information.Err().Number!=0)
                {
                    Interaction.MsgBox("Insert Error - UNHANDLED ERROR: "+Information.Err().Number+": "+Information.Err().Description, Constants.vbCritical, "Insert Error");
                }
            }
            finally
            {
                oCMD=null;
            }

        }

        public static void ShowError(string sError, bool bSaveToDB, string sErrorType, string sCalledby)
        {
            Interaction.MsgBox(sError, Constants.vbCritical, sCalledby);
            if (bSaveToDB)
            {
                InsertError(sError, sErrorType, sCalledby+" "+modGlobals.gsUserID);
            }
        }
        public static void UltraGroupBoxReadOnly(UltraGroupBox ogBox, bool bReadOnly)
        {
            foreach (Control oControl in ogBox.Controls)
            {
                switch (true)
                {
                    case object _ when oControl is TextBox:
                        {
                            ((TextBox)oControl).ReadOnly=bReadOnly;
                            break;
                        }
                    case object _ when oControl is UltraCombo:
                        {
                            ((UltraCombo)oControl).ReadOnly=bReadOnly;
                            break;
                        }
                    case object _ when oControl is UltraCheckEditor|oControl is CheckBox:
                        {
                            oControl.Enabled=!bReadOnly;
                            oControl.ForeColor=SystemColors.ControlText;
                            break;
                        }
                }
            }
        }
        public static bool FileExists(string sFileName)
        {
            bool bExists;
            try
            {
                bExists=File.Exists(sFileName);
            }
            catch (Exception ex)
            {
                bExists=false;
                Interaction.MsgBox("Error check for File:"+sFileName+" Error: "+ex.Message, MsgBoxStyle.Critical, "FileExists");
            }
            return bExists;
        }
        public static void GetCostPlanPath()
        {
            // 11/13/14
            var rs = new DataSet();
            var cDB = new DBCalls();
            string sServer = My.MySettings.Default.FileServer;

            if (cDB.GetRecordsFromSP(ref rs, "spGetConfig", "PathCADCostNew"))
            {
                if (rs.Tables[0].Rows.Count>0)
                {
                    modGlobals.gsPathCost=Conversions.ToString(Operators.ConcatenateObject(sServer, rs.Tables[0].Rows[0]["ItemValue"]));
                }
            }
            // MsgBox("Path: " & gsPathCost, MsgBoxStyle.Information, "GetCostPlanPath")
        }
        public static void ReloadCostAnalysisData()
        {
            DBCalls cDB;
            int i;

            try
            {
                cDB=new DBCalls();
                My.MyProject.Forms.mdiMain.UseWaitCursor=true;
                i=(int)cDB.GetReturnValueFromSP("spCostAnalysisLookupsUpdate");
                Interaction.MsgBox("Data has been refreshed.", Constants.vbInformation);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Reload Cost Analysis Data: "+ex.Message, MsgBoxStyle.Critical, "ReloadCostAnalysisData");
            }
            finally
            {
                My.MyProject.Forms.mdiMain.UseWaitCursor=true;
            }
        }
        public static void ShowPDFHelp(string sFileName)
        {
            bool bExists;
            bExists=FileExists(sFileName);
            if (bExists)
            {
                var oForm = new PDFViewer();
                oForm.AxAcroPDF1.src=sFileName;
                oForm.Show();
            }
            else
            {
                Interaction.MsgBox("The file you requested does not exist.  File: "+sFileName);
            }
        }
        public static bool SetGlobals()
        {
            try
            {
                modGlobals.gsUpdateFolder=My.MySettingsProperty.Settings.UpdateFolder;
            }
            catch (Exception ex)
            {

            }

            return default;




        }
        public static string Version()
        {
            Version version = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                version = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            else
            {
                version = typeof(MainMenu).Assembly.GetName().Version;
            }

            return version.ToString();
        }
    }
}