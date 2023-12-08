<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CostAnalysisDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAlphaCodes", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCode")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Description")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("alphaid")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxable")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GroupCode")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("POMessage")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("WCPerc")
        Dim UltraGridColumn8 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaGroupID")
        Dim UltraGridColumn9 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PAVendorOnly")
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance15 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance16 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance17 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance18 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance19 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance20 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance21 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance25 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand3 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetTaxDistrictList", -1)
        Dim UltraGridColumn10 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID")
        Dim UltraGridColumn11 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict")
        Dim Appearance26 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance27 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance28 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance29 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance30 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance31 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance32 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance33 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance34 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance35 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance36 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance37 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand4 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1)
        Dim UltraGridColumn12 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn13 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn14 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn15 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID")
        Dim UltraGridColumn16 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan")
        Dim UltraGridColumn17 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup")
        Dim Appearance38 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance39 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance40 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance41 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance42 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance43 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance44 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance45 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance46 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance47 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance48 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance49 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand5 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1)
        Dim UltraGridColumn18 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn19 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn20 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn21 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID")
        Dim UltraGridColumn22 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan")
        Dim UltraGridColumn23 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup")
        Dim Appearance50 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance51 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance52 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance53 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance54 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance55 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance56 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance57 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance58 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance59 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance60 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance61 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand6 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1)
        Dim UltraGridColumn24 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn25 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn26 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn27 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID")
        Dim UltraGridColumn28 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan")
        Dim UltraGridColumn29 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup")
        Dim Appearance62 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance63 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance64 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance65 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance66 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance67 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance68 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance69 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance70 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance71 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance72 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance73 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand7 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1)
        Dim UltraGridColumn30 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn31 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn32 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ID")
        Dim UltraGridColumn33 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID")
        Dim UltraGridColumn34 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan")
        Dim UltraGridColumn35 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup")
        Dim Appearance74 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance75 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance76 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance77 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance78 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance79 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance80 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance81 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance82 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance83 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance84 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CostAnalysisDetail))
        Dim UltraStatusPanel1 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraStatusPanel2 As Infragistics.Win.UltraWinStatusBar.UltraStatusPanel = New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel()
        Dim UltraDesktopAlertButton1 As Infragistics.Win.Misc.UltraDesktopAlertButton = New Infragistics.Win.Misc.UltraDesktopAlertButton()
        Dim Appearance85 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAnalysis", -1)
        Dim UltraGridColumn72 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("VersionName")
        Dim UltraGridColumn73 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("JobID")
        Dim UltraGridColumn74 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NewMargin")
        Dim UltraGridColumn75 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProjectID")
        Dim UltraGridColumn76 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisDate")
        Dim UltraGridColumn77 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostedDate")
        Dim UltraGridColumn78 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanID")
        Dim UltraGridColumn79 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID")
        Dim UltraGridColumn80 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProject")
        Dim UltraGridColumn81 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetCost")
        Dim UltraGridColumn82 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanPrice", -1, Nothing, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, False)
        Dim UltraGridColumn83 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("LotCosts")
        Dim UltraGridColumn84 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PriceWithoutLot")
        Dim UltraGridColumn85 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SquareFeet")
        Dim UltraGridColumn86 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PricePerFoot")
        Dim UltraGridColumn87 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("SoftCosts")
        Dim UltraGridColumn88 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedPrice")
        Dim UltraGridColumn89 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisID")
        Dim UltraGridColumn90 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CostPerFoot")
        Dim UltraGridColumn91 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName")
        Dim UltraGridColumn92 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict")
        Dim UltraGridColumn93 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxRate")
        Dim UltraGridColumn94 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanProj")
        Dim UltraGridColumn95 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("OptProj")
        Dim UltraGridColumn96 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CpyProject")
        Dim UltraGridColumn97 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ActualCst")
        Dim UltraGridColumn98 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("GrsMargin")
        Dim UltraGridColumn99 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NewSalesPrc")
        Dim UltraGridColumn100 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("NewSalesPrcWithLot")
        Dim UltraGridColumn101 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisPrice")
        Dim UltraGridColumn102 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Period")
        Dim UltraGridColumn103 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectPremium")
        Dim UltraGridColumn104 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy")
        Dim UltraGridColumn105 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Notes")
        Dim UltraGridColumn141 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Note")
        Dim UltraGridColumn142 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Increase", 0)
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance()
        Me.pnlFields = New System.Windows.Forms.Panel()
        Me.uteProjectPremium = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.spGetAnalysesHeaderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataQADataSet = New BossAdmin.HCHDataQADataSet()
        Me.uteSoftCosts = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.uteNewMargin = New Infragistics.Win.UltraWinEditors.UltraNumericEditor()
        Me.gpCustomAnalysis = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ucAlphaCodes = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.UltraCalcManager1 = New Infragistics.Win.UltraWinCalcManager.UltraCalcManager(Me.components)
        Me.SpGetAlphaCodesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataQAAlphaCodes = New BossAdmin.HCHDataQAAlphaCodes()
        Me.uteCostIncreasePercent = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ucDistricts = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.SpGetTaxDistrictListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataQADistricts = New BossAdmin.HCHDataQADistricts()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ucProjectsPlans = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.bndSourcePlanProjects = New System.Windows.Forms.BindingSource(Me.components)
        Me.HCHDataQAProjectList = New BossAdmin.HCHDataQAProjectList()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ucProjectOptions = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.bndSourceOptionsProject = New System.Windows.Forms.BindingSource(Me.components)
        Me.ucProjectsCosts = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.bndSourceCostProject = New System.Windows.Forms.BindingSource(Me.components)
        Me.gpBoxStandardAnalysis = New System.Windows.Forms.GroupBox()
        Me.ucProjectStandard = New Infragistics.Win.UltraWinGrid.UltraCombo()
        Me.SpGetOpenProjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkUseInfoFromStandardProject = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkDoNotUse = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCreatedBy = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCreatedDate = New System.Windows.Forms.Label()
        Me.uteNotes = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.uteProjectName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.uteProjectID = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckPlansSelected = New System.Windows.Forms.CheckBox()
        Me.btnSelectPlans = New System.Windows.Forms.Button()
        Me.utePeriod = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uteAnalysisName = New Infragistics.Win.UltraWinEditors.UltraTextEditor()
        Me.tsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnUndo = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnSave = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnPrint = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnPrintRpt2 = New System.Windows.Forms.ToolStripButton()
        Me.tsButtonHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsBtnReloadData = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsLblLastReloadDate = New System.Windows.Forms.ToolStripLabel()
        Me.tsBtnRecalculateGrid = New System.Windows.Forms.ToolStripButton()
        Me.udAlert = New Infragistics.Win.Misc.UltraDesktopAlert(Me.components)
        Me.UltraPopupControlContainer1 = New Infragistics.Win.Misc.UltraPopupControlContainer(Me.components)
        Me.UltraStatusBar1 = New Infragistics.Win.UltraWinStatusBar.UltraStatusBar()
        Me.UltraGridExcelExporter1 = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(Me.components)
        Me.UltraDesktopAlert1 = New Infragistics.Win.Misc.UltraDesktopAlert(Me.components)
        Me.ugDetails = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.HCHDataAnalysisDetail = New BossAdmin.HCHDataAnalysisDetail()
        Me.SpGetTaxDistrictListTableAdapter = New BossAdmin.HCHDataQADistrictsTableAdapters.spGetTaxDistrictListTableAdapter()
        Me.SpGetAlphaCodesTableAdapter = New BossAdmin.HCHDataQAAlphaCodesTableAdapters.spGetAlphaCodesTableAdapter()
        Me.SpGetOpenProjectsTableAdapter = New BossAdmin.HCHDataQAProjectListTableAdapters.spGetOpenProjectsTableAdapter()
        Me.SpGetAnalysesHeaderTableAdapter = New BossAdmin.HCHDataQADataSetTableAdapters.spGetAnalysesHeaderTableAdapter()
        Me.SpGetAnalysisBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGetAnalysisTableAdapter = New BossAdmin.HCHDataAnalysisDetailTableAdapters.spGetAnalysisTableAdapter()
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsViewEstimate = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsEstimateCostedRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsSummaryBudgetRpt = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFields.SuspendLayout()
        CType(Me.uteProjectPremium, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spGetAnalysesHeaderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataQADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteSoftCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteNewMargin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCustomAnalysis.SuspendLayout()
        CType(Me.ucAlphaCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraCalcManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetAlphaCodesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataQAAlphaCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteCostIncreasePercent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucDistricts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetTaxDistrictListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataQADistricts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucProjectsPlans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSourcePlanProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataQAProjectList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucProjectOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSourceOptionsProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ucProjectsCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bndSourceCostProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpBoxStandardAnalysis.SuspendLayout()
        CType(Me.ucProjectStandard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetOpenProjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteProjectID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.utePeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uteAnalysisName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsToolStrip.SuspendLayout()
        CType(Me.udAlert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraDesktopAlert1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ugDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HCHDataAnalysisDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGetAnalysisBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFields
        '
        Me.pnlFields.Controls.Add(Me.uteProjectPremium)
        Me.pnlFields.Controls.Add(Me.uteSoftCosts)
        Me.pnlFields.Controls.Add(Me.uteNewMargin)
        Me.pnlFields.Controls.Add(Me.gpCustomAnalysis)
        Me.pnlFields.Controls.Add(Me.gpBoxStandardAnalysis)
        Me.pnlFields.Controls.Add(Me.Label6)
        Me.pnlFields.Controls.Add(Me.chkDoNotUse)
        Me.pnlFields.Controls.Add(Me.Label10)
        Me.pnlFields.Controls.Add(Me.Label9)
        Me.pnlFields.Controls.Add(Me.Label7)
        Me.pnlFields.Controls.Add(Me.lblCreatedBy)
        Me.pnlFields.Controls.Add(Me.Label8)
        Me.pnlFields.Controls.Add(Me.lblCreatedDate)
        Me.pnlFields.Controls.Add(Me.uteNotes)
        Me.pnlFields.Controls.Add(Me.Label5)
        Me.pnlFields.Controls.Add(Me.Label4)
        Me.pnlFields.Controls.Add(Me.uteProjectName)
        Me.pnlFields.Controls.Add(Me.uteProjectID)
        Me.pnlFields.Controls.Add(Me.Label3)
        Me.pnlFields.Controls.Add(Me.ckPlansSelected)
        Me.pnlFields.Controls.Add(Me.btnSelectPlans)
        Me.pnlFields.Controls.Add(Me.utePeriod)
        Me.pnlFields.Controls.Add(Me.Label2)
        Me.pnlFields.Controls.Add(Me.Label1)
        Me.pnlFields.Controls.Add(Me.uteAnalysisName)
        Me.pnlFields.Location = New System.Drawing.Point(24, 98)
        Me.pnlFields.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.pnlFields.Name = "pnlFields"
        Me.pnlFields.Size = New System.Drawing.Size(2901, 539)
        Me.pnlFields.TabIndex = 8
        '
        'uteProjectPremium
        '
        Me.uteProjectPremium.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "ProjectPremium", True))
        Me.uteProjectPremium.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "ProjectPremium", True))
        Me.uteProjectPremium.Location = New System.Drawing.Point(1005, 186)
        Me.uteProjectPremium.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteProjectPremium.MaskInput = "nnnnnnnnn"
        Me.uteProjectPremium.Name = "uteProjectPremium"
        Me.uteProjectPremium.NullText = "0"
        Me.uteProjectPremium.Size = New System.Drawing.Size(157, 41)
        Me.uteProjectPremium.TabIndex = 7
        '
        'spGetAnalysesHeaderBindingSource
        '
        Me.spGetAnalysesHeaderBindingSource.DataMember = "spGetAnalysesHeader"
        Me.spGetAnalysesHeaderBindingSource.DataSource = Me.HCHDataQADataSet
        '
        'HCHDataQADataSet
        '
        Me.HCHDataQADataSet.DataSetName = "HCHDataQADataSet"
        Me.HCHDataQADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uteSoftCosts
        '
        Me.uteSoftCosts.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "SoftCosts", True))
        Me.uteSoftCosts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "SoftCosts", True))
        Me.uteSoftCosts.Location = New System.Drawing.Point(565, 184)
        Me.uteSoftCosts.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteSoftCosts.MaskInput = "nnnnnnnnn"
        Me.uteSoftCosts.MinValue = 0
        Me.uteSoftCosts.Name = "uteSoftCosts"
        Me.uteSoftCosts.NullText = "0"
        Me.uteSoftCosts.Size = New System.Drawing.Size(149, 41)
        Me.uteSoftCosts.TabIndex = 6
        '
        'uteNewMargin
        '
        Me.uteNewMargin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "NewMargin", True))
        Me.uteNewMargin.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "NewMargin", True))
        Me.uteNewMargin.Location = New System.Drawing.Point(288, 186)
        Me.uteNewMargin.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteNewMargin.MaskClipMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.uteNewMargin.MaskDisplayMode = Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw
        Me.uteNewMargin.MaskInput = ".nnn"
        Me.uteNewMargin.MaxValue = 1
        Me.uteNewMargin.MinValue = 0
        Me.uteNewMargin.Name = "uteNewMargin"
        Me.uteNewMargin.NumericType = Infragistics.Win.UltraWinEditors.NumericType.[Decimal]
        Me.uteNewMargin.Size = New System.Drawing.Size(72, 41)
        Me.uteNewMargin.TabIndex = 5
        '
        'gpCustomAnalysis
        '
        Me.gpCustomAnalysis.Controls.Add(Me.Label16)
        Me.gpCustomAnalysis.Controls.Add(Me.ucAlphaCodes)
        Me.gpCustomAnalysis.Controls.Add(Me.uteCostIncreasePercent)
        Me.gpCustomAnalysis.Controls.Add(Me.Label15)
        Me.gpCustomAnalysis.Controls.Add(Me.Label14)
        Me.gpCustomAnalysis.Controls.Add(Me.ucDistricts)
        Me.gpCustomAnalysis.Controls.Add(Me.Label13)
        Me.gpCustomAnalysis.Controls.Add(Me.ucProjectsPlans)
        Me.gpCustomAnalysis.Controls.Add(Me.Label12)
        Me.gpCustomAnalysis.Controls.Add(Me.Label11)
        Me.gpCustomAnalysis.Controls.Add(Me.ucProjectOptions)
        Me.gpCustomAnalysis.Controls.Add(Me.ucProjectsCosts)
        Me.gpCustomAnalysis.Location = New System.Drawing.Point(1344, 193)
        Me.gpCustomAnalysis.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.gpCustomAnalysis.Name = "gpCustomAnalysis"
        Me.gpCustomAnalysis.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.gpCustomAnalysis.Size = New System.Drawing.Size(1261, 341)
        Me.gpCustomAnalysis.TabIndex = 33
        Me.gpCustomAnalysis.TabStop = False
        Me.gpCustomAnalysis.Text = "Custom Analysis"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(784, 272)
        Me.Label16.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(220, 32)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "For Alpha Code:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ucAlphaCodes
        '
        Me.ucAlphaCodes.AllowNull = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucAlphaCodes.CalcManager = Me.UltraCalcManager1
        Me.ucAlphaCodes.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "CostIncreaseAlpha", True))
        Me.ucAlphaCodes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "AlphaCode", True))
        Me.ucAlphaCodes.DataSource = Me.SpGetAlphaCodesBindingSource
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucAlphaCodes.DisplayLayout.Appearance = Appearance13
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Hidden = True
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Hidden = True
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Hidden = True
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Hidden = True
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Hidden = True
        UltraGridColumn8.Header.VisiblePosition = 7
        UltraGridColumn8.Hidden = True
        UltraGridColumn9.Header.VisiblePosition = 8
        UltraGridColumn9.Hidden = True
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9})
        Me.ucAlphaCodes.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.ucAlphaCodes.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucAlphaCodes.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance14.BorderColor = System.Drawing.SystemColors.Window
        Me.ucAlphaCodes.DisplayLayout.GroupByBox.Appearance = Appearance14
        Appearance15.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucAlphaCodes.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance15
        Me.ucAlphaCodes.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance16.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance16.BackColor2 = System.Drawing.SystemColors.Control
        Appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance16.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucAlphaCodes.DisplayLayout.GroupByBox.PromptAppearance = Appearance16
        Me.ucAlphaCodes.DisplayLayout.MaxColScrollRegions = 1
        Me.ucAlphaCodes.DisplayLayout.MaxRowScrollRegions = 1
        Appearance17.BackColor = System.Drawing.SystemColors.Window
        Appearance17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucAlphaCodes.DisplayLayout.Override.ActiveCellAppearance = Appearance17
        Appearance18.BackColor = System.Drawing.SystemColors.Highlight
        Appearance18.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucAlphaCodes.DisplayLayout.Override.ActiveRowAppearance = Appearance18
        Me.ucAlphaCodes.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucAlphaCodes.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance19.BackColor = System.Drawing.SystemColors.Window
        Me.ucAlphaCodes.DisplayLayout.Override.CardAreaAppearance = Appearance19
        Appearance20.BorderColor = System.Drawing.Color.Silver
        Appearance20.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucAlphaCodes.DisplayLayout.Override.CellAppearance = Appearance20
        Me.ucAlphaCodes.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucAlphaCodes.DisplayLayout.Override.CellPadding = 0
        Appearance21.BackColor = System.Drawing.SystemColors.Control
        Appearance21.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance21.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance21.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance21.BorderColor = System.Drawing.SystemColors.Window
        Me.ucAlphaCodes.DisplayLayout.Override.GroupByRowAppearance = Appearance21
        Appearance22.TextHAlignAsString = "Left"
        Me.ucAlphaCodes.DisplayLayout.Override.HeaderAppearance = Appearance22
        Me.ucAlphaCodes.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucAlphaCodes.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance23.BackColor = System.Drawing.SystemColors.Window
        Appearance23.BorderColor = System.Drawing.Color.Silver
        Me.ucAlphaCodes.DisplayLayout.Override.RowAppearance = Appearance23
        Me.ucAlphaCodes.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance24.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucAlphaCodes.DisplayLayout.Override.TemplateAddRowAppearance = Appearance24
        Me.ucAlphaCodes.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucAlphaCodes.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucAlphaCodes.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucAlphaCodes.DisplayMember = "AlphaCode"
        Me.ucAlphaCodes.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucAlphaCodes.Location = New System.Drawing.Point(1019, 265)
        Me.ucAlphaCodes.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ucAlphaCodes.Name = "ucAlphaCodes"
        Me.ucAlphaCodes.NullText = "(Choose)"
        Me.ucAlphaCodes.Size = New System.Drawing.Size(224, 42)
        Me.ucAlphaCodes.TabIndex = 15
        Me.ucAlphaCodes.ValueMember = "alphaid"
        '
        'UltraCalcManager1
        '
        Me.UltraCalcManager1.ContainingControl = Me
        '
        'SpGetAlphaCodesBindingSource
        '
        Me.SpGetAlphaCodesBindingSource.DataMember = "spGetAlphaCodes"
        Me.SpGetAlphaCodesBindingSource.DataSource = Me.HCHDataQAAlphaCodes
        '
        'HCHDataQAAlphaCodes
        '
        Me.HCHDataQAAlphaCodes.DataSetName = "HCHDataQAAlphaCodes"
        Me.HCHDataQAAlphaCodes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uteCostIncreasePercent
        '
        Me.uteCostIncreasePercent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "CostIncreasePercent", True))
        Me.uteCostIncreasePercent.Location = New System.Drawing.Point(699, 265)
        Me.uteCostIncreasePercent.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteCostIncreasePercent.MaxLength = 5
        Me.uteCostIncreasePercent.Name = "uteCostIncreasePercent"
        Me.uteCostIncreasePercent.Size = New System.Drawing.Size(75, 41)
        Me.uteCostIncreasePercent.TabIndex = 14
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(472, 272)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(219, 32)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "% Cost Increase"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(635, 215)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 32)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "District:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ucDistricts
        '
        Me.ucDistricts.AllowNull = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucDistricts.CalcManager = Me.UltraCalcManager1
        Me.ucDistricts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "TaxPermitDistrict", True))
        Me.ucDistricts.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "TaxPermitID", True))
        Me.ucDistricts.DataSource = Me.SpGetTaxDistrictListBindingSource
        Appearance25.BackColor = System.Drawing.SystemColors.Window
        Appearance25.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucDistricts.DisplayLayout.Appearance = Appearance25
        UltraGridColumn10.Header.VisiblePosition = 1
        UltraGridColumn10.Hidden = True
        UltraGridColumn11.Header.VisiblePosition = 0
        UltraGridBand3.Columns.AddRange(New Object() {UltraGridColumn10, UltraGridColumn11})
        Me.ucDistricts.DisplayLayout.BandsSerializer.Add(UltraGridBand3)
        Me.ucDistricts.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucDistricts.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance26.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance26.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance26.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance26.BorderColor = System.Drawing.SystemColors.Window
        Me.ucDistricts.DisplayLayout.GroupByBox.Appearance = Appearance26
        Appearance27.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucDistricts.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance27
        Me.ucDistricts.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance28.BackColor2 = System.Drawing.SystemColors.Control
        Appearance28.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance28.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucDistricts.DisplayLayout.GroupByBox.PromptAppearance = Appearance28
        Me.ucDistricts.DisplayLayout.MaxColScrollRegions = 1
        Me.ucDistricts.DisplayLayout.MaxRowScrollRegions = 1
        Appearance29.BackColor = System.Drawing.SystemColors.Window
        Appearance29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucDistricts.DisplayLayout.Override.ActiveCellAppearance = Appearance29
        Appearance30.BackColor = System.Drawing.SystemColors.Highlight
        Appearance30.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucDistricts.DisplayLayout.Override.ActiveRowAppearance = Appearance30
        Me.ucDistricts.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucDistricts.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance31.BackColor = System.Drawing.SystemColors.Window
        Me.ucDistricts.DisplayLayout.Override.CardAreaAppearance = Appearance31
        Appearance32.BorderColor = System.Drawing.Color.Silver
        Appearance32.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucDistricts.DisplayLayout.Override.CellAppearance = Appearance32
        Me.ucDistricts.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucDistricts.DisplayLayout.Override.CellPadding = 0
        Appearance33.BackColor = System.Drawing.SystemColors.Control
        Appearance33.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance33.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance33.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance33.BorderColor = System.Drawing.SystemColors.Window
        Me.ucDistricts.DisplayLayout.Override.GroupByRowAppearance = Appearance33
        Appearance34.TextHAlignAsString = "Left"
        Me.ucDistricts.DisplayLayout.Override.HeaderAppearance = Appearance34
        Me.ucDistricts.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucDistricts.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance35.BackColor = System.Drawing.SystemColors.Window
        Appearance35.BorderColor = System.Drawing.Color.Silver
        Me.ucDistricts.DisplayLayout.Override.RowAppearance = Appearance35
        Me.ucDistricts.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance36.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucDistricts.DisplayLayout.Override.TemplateAddRowAppearance = Appearance36
        Me.ucDistricts.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucDistricts.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucDistricts.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucDistricts.DisplayMember = "TaxPermitDistrict"
        Me.ucDistricts.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucDistricts.Location = New System.Drawing.Point(773, 207)
        Me.ucDistricts.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ucDistricts.Name = "ucDistricts"
        Me.ucDistricts.NullText = "(Choose)"
        Me.ucDistricts.Size = New System.Drawing.Size(443, 42)
        Me.ucDistricts.TabIndex = 13
        Me.ucDistricts.ValueMember = "TaxPermitID"
        '
        'SpGetTaxDistrictListBindingSource
        '
        Me.SpGetTaxDistrictListBindingSource.DataMember = "spGetTaxDistrictList"
        Me.SpGetTaxDistrictListBindingSource.DataSource = Me.HCHDataQADistricts
        '
        'HCHDataQADistricts
        '
        Me.HCHDataQADistricts.DataSetName = "HCHDataQADistricts"
        Me.HCHDataQADistricts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(520, 155)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(223, 32)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Use Plans From:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ucProjectsPlans
        '
        Me.ucProjectsPlans.AllowNull = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucProjectsPlans.CalcManager = Me.UltraCalcManager1
        Me.ucProjectsPlans.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "PlanProject", True))
        Me.ucProjectsPlans.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "PlanProjectID", True))
        Me.ucProjectsPlans.DataSource = Me.bndSourcePlanProjects
        Appearance37.BackColor = System.Drawing.SystemColors.Window
        Appearance37.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucProjectsPlans.DisplayLayout.Appearance = Appearance37
        UltraGridColumn12.Header.VisiblePosition = 0
        UltraGridColumn13.Header.VisiblePosition = 1
        UltraGridColumn14.Header.VisiblePosition = 2
        UltraGridColumn14.Hidden = True
        UltraGridColumn15.Header.VisiblePosition = 3
        UltraGridColumn15.Hidden = True
        UltraGridColumn16.Header.VisiblePosition = 4
        UltraGridColumn16.Hidden = True
        UltraGridColumn17.Header.VisiblePosition = 5
        UltraGridBand4.Columns.AddRange(New Object() {UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17})
        Me.ucProjectsPlans.DisplayLayout.BandsSerializer.Add(UltraGridBand4)
        Me.ucProjectsPlans.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucProjectsPlans.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance38.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance38.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance38.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance38.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectsPlans.DisplayLayout.GroupByBox.Appearance = Appearance38
        Appearance39.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectsPlans.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance39
        Me.ucProjectsPlans.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance40.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance40.BackColor2 = System.Drawing.SystemColors.Control
        Appearance40.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance40.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectsPlans.DisplayLayout.GroupByBox.PromptAppearance = Appearance40
        Me.ucProjectsPlans.DisplayLayout.MaxColScrollRegions = 1
        Me.ucProjectsPlans.DisplayLayout.MaxRowScrollRegions = 1
        Appearance41.BackColor = System.Drawing.SystemColors.Window
        Appearance41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucProjectsPlans.DisplayLayout.Override.ActiveCellAppearance = Appearance41
        Appearance42.BackColor = System.Drawing.SystemColors.Highlight
        Appearance42.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucProjectsPlans.DisplayLayout.Override.ActiveRowAppearance = Appearance42
        Me.ucProjectsPlans.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucProjectsPlans.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance43.BackColor = System.Drawing.SystemColors.Window
        Me.ucProjectsPlans.DisplayLayout.Override.CardAreaAppearance = Appearance43
        Appearance44.BorderColor = System.Drawing.Color.Silver
        Appearance44.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucProjectsPlans.DisplayLayout.Override.CellAppearance = Appearance44
        Me.ucProjectsPlans.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucProjectsPlans.DisplayLayout.Override.CellPadding = 0
        Appearance45.BackColor = System.Drawing.SystemColors.Control
        Appearance45.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance45.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance45.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance45.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectsPlans.DisplayLayout.Override.GroupByRowAppearance = Appearance45
        Appearance46.TextHAlignAsString = "Left"
        Me.ucProjectsPlans.DisplayLayout.Override.HeaderAppearance = Appearance46
        Me.ucProjectsPlans.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucProjectsPlans.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance47.BackColor = System.Drawing.SystemColors.Window
        Appearance47.BorderColor = System.Drawing.Color.Silver
        Me.ucProjectsPlans.DisplayLayout.Override.RowAppearance = Appearance47
        Me.ucProjectsPlans.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance48.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucProjectsPlans.DisplayLayout.Override.TemplateAddRowAppearance = Appearance48
        Me.ucProjectsPlans.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucProjectsPlans.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucProjectsPlans.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucProjectsPlans.DisplayMember = "ProjectID"
        Me.ucProjectsPlans.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucProjectsPlans.Location = New System.Drawing.Point(773, 148)
        Me.ucProjectsPlans.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ucProjectsPlans.Name = "ucProjectsPlans"
        Me.ucProjectsPlans.NullText = "(Choose)"
        Me.ucProjectsPlans.Size = New System.Drawing.Size(240, 42)
        Me.ucProjectsPlans.TabIndex = 12
        Me.ucProjectsPlans.ValueMember = "ID"
        '
        'bndSourcePlanProjects
        '
        Me.bndSourcePlanProjects.AllowNew = False
        Me.bndSourcePlanProjects.DataMember = "spGetOpenProjects"
        Me.bndSourcePlanProjects.DataSource = Me.HCHDataQAProjectList
        '
        'HCHDataQAProjectList
        '
        Me.HCHDataQAProjectList.DataSetName = "HCHDataQAProjectList"
        Me.HCHDataQAProjectList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(245, 95)
        Me.Label12.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(496, 32)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Use Project Options and Details From:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(520, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(223, 32)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Use Costs From:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ucProjectOptions
        '
        Me.ucProjectOptions.AllowNull = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucProjectOptions.CalcManager = Me.UltraCalcManager1
        Me.ucProjectOptions.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "OptionProjectID", True))
        Me.ucProjectOptions.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "OptionProject", True))
        Me.ucProjectOptions.DataSource = Me.bndSourceOptionsProject
        Appearance49.BackColor = System.Drawing.SystemColors.Window
        Appearance49.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucProjectOptions.DisplayLayout.Appearance = Appearance49
        UltraGridColumn18.Header.VisiblePosition = 0
        UltraGridColumn19.Header.VisiblePosition = 1
        UltraGridColumn20.Header.VisiblePosition = 2
        UltraGridColumn20.Hidden = True
        UltraGridColumn21.Header.VisiblePosition = 3
        UltraGridColumn21.Hidden = True
        UltraGridColumn22.Header.VisiblePosition = 4
        UltraGridColumn22.Hidden = True
        UltraGridColumn23.Header.VisiblePosition = 5
        UltraGridBand5.Columns.AddRange(New Object() {UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23})
        Me.ucProjectOptions.DisplayLayout.BandsSerializer.Add(UltraGridBand5)
        Me.ucProjectOptions.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucProjectOptions.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance50.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance50.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance50.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance50.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectOptions.DisplayLayout.GroupByBox.Appearance = Appearance50
        Appearance51.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectOptions.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance51
        Me.ucProjectOptions.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance52.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance52.BackColor2 = System.Drawing.SystemColors.Control
        Appearance52.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance52.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectOptions.DisplayLayout.GroupByBox.PromptAppearance = Appearance52
        Me.ucProjectOptions.DisplayLayout.MaxColScrollRegions = 1
        Me.ucProjectOptions.DisplayLayout.MaxRowScrollRegions = 1
        Appearance53.BackColor = System.Drawing.SystemColors.Window
        Appearance53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucProjectOptions.DisplayLayout.Override.ActiveCellAppearance = Appearance53
        Appearance54.BackColor = System.Drawing.SystemColors.Highlight
        Appearance54.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucProjectOptions.DisplayLayout.Override.ActiveRowAppearance = Appearance54
        Me.ucProjectOptions.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucProjectOptions.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance55.BackColor = System.Drawing.SystemColors.Window
        Me.ucProjectOptions.DisplayLayout.Override.CardAreaAppearance = Appearance55
        Appearance56.BorderColor = System.Drawing.Color.Silver
        Appearance56.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucProjectOptions.DisplayLayout.Override.CellAppearance = Appearance56
        Me.ucProjectOptions.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucProjectOptions.DisplayLayout.Override.CellPadding = 0
        Appearance57.BackColor = System.Drawing.SystemColors.Control
        Appearance57.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance57.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance57.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance57.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectOptions.DisplayLayout.Override.GroupByRowAppearance = Appearance57
        Appearance58.TextHAlignAsString = "Left"
        Me.ucProjectOptions.DisplayLayout.Override.HeaderAppearance = Appearance58
        Me.ucProjectOptions.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucProjectOptions.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance59.BackColor = System.Drawing.SystemColors.Window
        Appearance59.BorderColor = System.Drawing.Color.Silver
        Me.ucProjectOptions.DisplayLayout.Override.RowAppearance = Appearance59
        Me.ucProjectOptions.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance60.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucProjectOptions.DisplayLayout.Override.TemplateAddRowAppearance = Appearance60
        Me.ucProjectOptions.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucProjectOptions.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucProjectOptions.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucProjectOptions.DisplayMember = "ProjectID"
        Me.ucProjectOptions.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucProjectOptions.Location = New System.Drawing.Point(773, 86)
        Me.ucProjectOptions.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ucProjectOptions.Name = "ucProjectOptions"
        Me.ucProjectOptions.NullText = "(Choose)"
        Me.ucProjectOptions.Size = New System.Drawing.Size(240, 42)
        Me.ucProjectOptions.TabIndex = 11
        Me.ucProjectOptions.ValueMember = "ID"
        '
        'bndSourceOptionsProject
        '
        Me.bndSourceOptionsProject.AllowNew = False
        Me.bndSourceOptionsProject.DataMember = "spGetOpenProjects"
        Me.bndSourceOptionsProject.DataSource = Me.HCHDataQAProjectList
        '
        'ucProjectsCosts
        '
        Me.ucProjectsCosts.AllowNull = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucProjectsCosts.CalcManager = Me.UltraCalcManager1
        Me.ucProjectsCosts.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "CostProject", True))
        Me.ucProjectsCosts.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "CostProjectID", True))
        Me.ucProjectsCosts.DataSource = Me.bndSourceCostProject
        Appearance61.BackColor = System.Drawing.SystemColors.Window
        Appearance61.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucProjectsCosts.DisplayLayout.Appearance = Appearance61
        UltraGridColumn24.Header.VisiblePosition = 0
        UltraGridColumn25.Header.VisiblePosition = 1
        UltraGridColumn26.Header.VisiblePosition = 2
        UltraGridColumn26.Hidden = True
        UltraGridColumn27.Header.VisiblePosition = 3
        UltraGridColumn27.Hidden = True
        UltraGridColumn28.Header.VisiblePosition = 4
        UltraGridColumn28.Hidden = True
        UltraGridColumn29.Header.VisiblePosition = 5
        UltraGridBand6.Columns.AddRange(New Object() {UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29})
        Me.ucProjectsCosts.DisplayLayout.BandsSerializer.Add(UltraGridBand6)
        Me.ucProjectsCosts.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucProjectsCosts.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance62.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance62.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance62.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance62.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectsCosts.DisplayLayout.GroupByBox.Appearance = Appearance62
        Appearance63.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectsCosts.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance63
        Me.ucProjectsCosts.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance64.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance64.BackColor2 = System.Drawing.SystemColors.Control
        Appearance64.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance64.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectsCosts.DisplayLayout.GroupByBox.PromptAppearance = Appearance64
        Me.ucProjectsCosts.DisplayLayout.MaxColScrollRegions = 1
        Me.ucProjectsCosts.DisplayLayout.MaxRowScrollRegions = 1
        Appearance65.BackColor = System.Drawing.SystemColors.Window
        Appearance65.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucProjectsCosts.DisplayLayout.Override.ActiveCellAppearance = Appearance65
        Appearance66.BackColor = System.Drawing.SystemColors.Highlight
        Appearance66.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucProjectsCosts.DisplayLayout.Override.ActiveRowAppearance = Appearance66
        Me.ucProjectsCosts.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucProjectsCosts.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance67.BackColor = System.Drawing.SystemColors.Window
        Me.ucProjectsCosts.DisplayLayout.Override.CardAreaAppearance = Appearance67
        Appearance68.BorderColor = System.Drawing.Color.Silver
        Appearance68.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucProjectsCosts.DisplayLayout.Override.CellAppearance = Appearance68
        Me.ucProjectsCosts.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucProjectsCosts.DisplayLayout.Override.CellPadding = 0
        Appearance69.BackColor = System.Drawing.SystemColors.Control
        Appearance69.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance69.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance69.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance69.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectsCosts.DisplayLayout.Override.GroupByRowAppearance = Appearance69
        Appearance70.TextHAlignAsString = "Left"
        Me.ucProjectsCosts.DisplayLayout.Override.HeaderAppearance = Appearance70
        Me.ucProjectsCosts.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucProjectsCosts.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance71.BackColor = System.Drawing.SystemColors.Window
        Appearance71.BorderColor = System.Drawing.Color.Silver
        Me.ucProjectsCosts.DisplayLayout.Override.RowAppearance = Appearance71
        Me.ucProjectsCosts.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance72.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucProjectsCosts.DisplayLayout.Override.TemplateAddRowAppearance = Appearance72
        Me.ucProjectsCosts.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucProjectsCosts.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucProjectsCosts.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucProjectsCosts.DisplayMember = "ProjectID"
        Me.ucProjectsCosts.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucProjectsCosts.Location = New System.Drawing.Point(773, 26)
        Me.ucProjectsCosts.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ucProjectsCosts.Name = "ucProjectsCosts"
        Me.ucProjectsCosts.NullText = "(Choose)"
        Me.ucProjectsCosts.Size = New System.Drawing.Size(240, 42)
        Me.ucProjectsCosts.TabIndex = 10
        Me.ucProjectsCosts.ValueMember = "ID"
        '
        'bndSourceCostProject
        '
        Me.bndSourceCostProject.AllowNew = False
        Me.bndSourceCostProject.DataMember = "spGetOpenProjects"
        Me.bndSourceCostProject.DataSource = Me.HCHDataQAProjectList
        '
        'gpBoxStandardAnalysis
        '
        Me.gpBoxStandardAnalysis.Controls.Add(Me.ucProjectStandard)
        Me.gpBoxStandardAnalysis.Controls.Add(Me.chkUseInfoFromStandardProject)
        Me.gpBoxStandardAnalysis.Location = New System.Drawing.Point(1344, 69)
        Me.gpBoxStandardAnalysis.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.gpBoxStandardAnalysis.Name = "gpBoxStandardAnalysis"
        Me.gpBoxStandardAnalysis.Padding = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.gpBoxStandardAnalysis.Size = New System.Drawing.Size(1053, 105)
        Me.gpBoxStandardAnalysis.TabIndex = 32
        Me.gpBoxStandardAnalysis.TabStop = False
        Me.gpBoxStandardAnalysis.Text = "Standard Analysis"
        '
        'ucProjectStandard
        '
        Me.ucProjectStandard.AllowNull = Infragistics.Win.DefaultableBoolean.[True]
        Me.ucProjectStandard.CalcManager = Me.UltraCalcManager1
        Me.ucProjectStandard.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "CopyProjectID", True))
        Me.ucProjectStandard.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "CopyProject", True))
        Me.ucProjectStandard.DataSource = Me.SpGetOpenProjectsBindingSource
        Appearance73.BackColor = System.Drawing.SystemColors.Window
        Appearance73.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ucProjectStandard.DisplayLayout.Appearance = Appearance73
        UltraGridColumn30.Header.VisiblePosition = 0
        UltraGridColumn31.Header.VisiblePosition = 1
        UltraGridColumn32.Header.VisiblePosition = 2
        UltraGridColumn32.Hidden = True
        UltraGridColumn33.Header.VisiblePosition = 3
        UltraGridColumn33.Hidden = True
        UltraGridColumn34.Header.VisiblePosition = 4
        UltraGridColumn34.Hidden = True
        UltraGridColumn35.Header.VisiblePosition = 5
        UltraGridBand7.Columns.AddRange(New Object() {UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35})
        Me.ucProjectStandard.DisplayLayout.BandsSerializer.Add(UltraGridBand7)
        Me.ucProjectStandard.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ucProjectStandard.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance74.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance74.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance74.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance74.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectStandard.DisplayLayout.GroupByBox.Appearance = Appearance74
        Appearance75.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectStandard.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance75
        Me.ucProjectStandard.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance76.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance76.BackColor2 = System.Drawing.SystemColors.Control
        Appearance76.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance76.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ucProjectStandard.DisplayLayout.GroupByBox.PromptAppearance = Appearance76
        Me.ucProjectStandard.DisplayLayout.MaxColScrollRegions = 1
        Me.ucProjectStandard.DisplayLayout.MaxRowScrollRegions = 1
        Appearance77.BackColor = System.Drawing.SystemColors.Window
        Appearance77.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ucProjectStandard.DisplayLayout.Override.ActiveCellAppearance = Appearance77
        Appearance78.BackColor = System.Drawing.SystemColors.Highlight
        Appearance78.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ucProjectStandard.DisplayLayout.Override.ActiveRowAppearance = Appearance78
        Me.ucProjectStandard.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ucProjectStandard.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance79.BackColor = System.Drawing.SystemColors.Window
        Me.ucProjectStandard.DisplayLayout.Override.CardAreaAppearance = Appearance79
        Appearance80.BorderColor = System.Drawing.Color.Silver
        Appearance80.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ucProjectStandard.DisplayLayout.Override.CellAppearance = Appearance80
        Me.ucProjectStandard.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ucProjectStandard.DisplayLayout.Override.CellPadding = 0
        Appearance81.BackColor = System.Drawing.SystemColors.Control
        Appearance81.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance81.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance81.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance81.BorderColor = System.Drawing.SystemColors.Window
        Me.ucProjectStandard.DisplayLayout.Override.GroupByRowAppearance = Appearance81
        Appearance82.TextHAlignAsString = "Left"
        Me.ucProjectStandard.DisplayLayout.Override.HeaderAppearance = Appearance82
        Me.ucProjectStandard.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ucProjectStandard.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance83.BackColor = System.Drawing.SystemColors.Window
        Appearance83.BorderColor = System.Drawing.Color.Silver
        Me.ucProjectStandard.DisplayLayout.Override.RowAppearance = Appearance83
        Me.ucProjectStandard.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance84.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ucProjectStandard.DisplayLayout.Override.TemplateAddRowAppearance = Appearance84
        Me.ucProjectStandard.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ucProjectStandard.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ucProjectStandard.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ucProjectStandard.DisplayMember = "ProjectID"
        Me.ucProjectStandard.DropDownStyle = Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList
        Me.ucProjectStandard.Location = New System.Drawing.Point(773, 45)
        Me.ucProjectStandard.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ucProjectStandard.Name = "ucProjectStandard"
        Me.ucProjectStandard.NullText = "(Choose)"
        Me.ucProjectStandard.Size = New System.Drawing.Size(240, 42)
        Me.ucProjectStandard.TabIndex = 9
        Me.ucProjectStandard.ValueMember = "ID"
        '
        'SpGetOpenProjectsBindingSource
        '
        Me.SpGetOpenProjectsBindingSource.AllowNew = False
        Me.SpGetOpenProjectsBindingSource.DataMember = "spGetOpenProjects"
        Me.SpGetOpenProjectsBindingSource.DataSource = Me.HCHDataQAProjectList
        '
        'chkUseInfoFromStandardProject
        '
        Me.chkUseInfoFromStandardProject.AutoSize = True
        Me.chkUseInfoFromStandardProject.Checked = True
        Me.chkUseInfoFromStandardProject.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseInfoFromStandardProject.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.spGetAnalysesHeaderBindingSource, "DoNotUse", True))
        Me.chkUseInfoFromStandardProject.Location = New System.Drawing.Point(176, 55)
        Me.chkUseInfoFromStandardProject.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.chkUseInfoFromStandardProject.Name = "chkUseInfoFromStandardProject"
        Me.chkUseInfoFromStandardProject.Size = New System.Drawing.Size(566, 36)
        Me.chkUseInfoFromStandardProject.TabIndex = 8
        Me.chkUseInfoFromStandardProject.Text = "Use All Information from Existing Project:"
        Me.chkUseInfoFromStandardProject.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label6.Location = New System.Drawing.Point(1339, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 32)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Created Date:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'chkDoNotUse
        '
        Me.chkDoNotUse.AutoSize = True
        Me.chkDoNotUse.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.spGetAnalysesHeaderBindingSource, "DoNotUse", True))
        Me.chkDoNotUse.Location = New System.Drawing.Point(925, 19)
        Me.chkDoNotUse.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.chkDoNotUse.Name = "chkDoNotUse"
        Me.chkDoNotUse.Size = New System.Drawing.Size(328, 36)
        Me.chkDoNotUse.TabIndex = 31
        Me.chkDoNotUse.Text = "Trial - Can be Deleted"
        Me.chkDoNotUse.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(763, 193)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(231, 32)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Project Premium:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(403, 193)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(152, 32)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Soft Costs:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 32)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Margin:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCreatedBy
        '
        Me.lblCreatedBy.AutoSize = True
        Me.lblCreatedBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "CreatedBy", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "g"))
        Me.lblCreatedBy.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCreatedBy.Location = New System.Drawing.Point(1907, 21)
        Me.lblCreatedBy.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCreatedBy.Name = "lblCreatedBy"
        Me.lblCreatedBy.Size = New System.Drawing.Size(148, 32)
        Me.lblCreatedBy.TabIndex = 23
        Me.lblCreatedBy.Text = "CreatedBy"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label8.Location = New System.Drawing.Point(1736, 21)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 32)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Created By:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCreatedDate
        '
        Me.lblCreatedDate.AutoSize = True
        Me.lblCreatedDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "AnalysisDate", True))
        Me.lblCreatedDate.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblCreatedDate.Location = New System.Drawing.Point(1536, 21)
        Me.lblCreatedDate.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblCreatedDate.Name = "lblCreatedDate"
        Me.lblCreatedDate.Size = New System.Drawing.Size(175, 32)
        Me.lblCreatedDate.TabIndex = 21
        Me.lblCreatedDate.Text = "CreatedDate"
        '
        'uteNotes
        '
        Me.uteNotes.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "Period", True))
        Me.uteNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.spGetAnalysesHeaderBindingSource, "Notes", True))
        Me.uteNotes.Location = New System.Drawing.Point(288, 250)
        Me.uteNotes.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteNotes.MaxLength = 500
        Me.uteNotes.Multiline = True
        Me.uteNotes.Name = "uteNotes"
        Me.uteNotes.Scrollbars = System.Windows.Forms.ScrollBars.Vertical
        Me.uteNotes.Size = New System.Drawing.Size(963, 93)
        Me.uteNotes.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 258)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 32)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Notes:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(421, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 32)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Project Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'uteProjectName
        '
        Me.uteProjectName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "ProjectName", True))
        Me.uteProjectName.Location = New System.Drawing.Point(629, 126)
        Me.uteProjectName.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteProjectName.MaxLength = 50
        Me.uteProjectName.Name = "uteProjectName"
        Me.uteProjectName.Size = New System.Drawing.Size(624, 41)
        Me.uteProjectName.TabIndex = 4
        '
        'uteProjectID
        '
        Me.uteProjectID.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "ProjectID", True))
        Me.uteProjectID.Location = New System.Drawing.Point(288, 126)
        Me.uteProjectID.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteProjectID.MaxLength = 5
        Me.uteProjectID.Name = "uteProjectID"
        Me.uteProjectID.Size = New System.Drawing.Size(120, 41)
        Me.uteProjectID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 134)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 32)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Analysis Project ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ckPlansSelected
        '
        Me.ckPlansSelected.AutoSize = True
        Me.ckPlansSelected.Enabled = False
        Me.ckPlansSelected.Location = New System.Drawing.Point(2411, 38)
        Me.ckPlansSelected.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ckPlansSelected.Name = "ckPlansSelected"
        Me.ckPlansSelected.Size = New System.Drawing.Size(243, 36)
        Me.ckPlansSelected.TabIndex = 13
        Me.ckPlansSelected.Text = "Plans Selected"
        Me.ckPlansSelected.UseVisualStyleBackColor = True
        '
        'btnSelectPlans
        '
        Me.btnSelectPlans.Location = New System.Drawing.Point(2411, 112)
        Me.btnSelectPlans.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSelectPlans.Name = "btnSelectPlans"
        Me.btnSelectPlans.Size = New System.Drawing.Size(371, 50)
        Me.btnSelectPlans.TabIndex = 7
        Me.btnSelectPlans.Text = "Select Plans"
        Me.btnSelectPlans.UseVisualStyleBackColor = True
        '
        'utePeriod
        '
        Me.utePeriod.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "Period", True))
        Me.utePeriod.Location = New System.Drawing.Point(288, 69)
        Me.utePeriod.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.utePeriod.MaxLength = 50
        Me.utePeriod.Name = "utePeriod"
        Me.utePeriod.Size = New System.Drawing.Size(624, 41)
        Me.utePeriod.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(160, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Period:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Analysis Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'uteAnalysisName
        '
        Me.uteAnalysisName.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.spGetAnalysesHeaderBindingSource, "VersionName", True))
        Me.uteAnalysisName.Location = New System.Drawing.Point(288, 12)
        Me.uteAnalysisName.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.uteAnalysisName.MaxLength = 50
        Me.uteAnalysisName.Name = "uteAnalysisName"
        Me.uteAnalysisName.Size = New System.Drawing.Size(624, 41)
        Me.uteAnalysisName.TabIndex = 1
        '
        'tsToolStrip
        '
        Me.tsToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.tsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnAdd, Me.tsBtnEdit, Me.tsBtnUndo, Me.tsBtnDelete, Me.tsBtnSave, Me.tsBtnPrint, Me.tsBtnPrintRpt2, Me.tsButtonHelp, Me.ToolStripSeparator1, Me.tsBtnReloadData, Me.ToolStripSeparator2, Me.tsLblLastReloadDate, Me.tsBtnRecalculateGrid})
        Me.tsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.tsToolStrip.Name = "tsToolStrip"
        Me.tsToolStrip.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.tsToolStrip.Size = New System.Drawing.Size(2872, 52)
        Me.tsToolStrip.Stretch = True
        Me.tsToolStrip.TabIndex = 9
        Me.tsToolStrip.Text = "ToolStrip1"
        '
        'tsBtnAdd
        '
        Me.tsBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnAdd.Enabled = False
        Me.tsBtnAdd.Image = CType(resources.GetObject("tsBtnAdd.Image"), System.Drawing.Image)
        Me.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAdd.Name = "tsBtnAdd"
        Me.tsBtnAdd.Size = New System.Drawing.Size(58, 45)
        Me.tsBtnAdd.Text = "Add New"
        Me.tsBtnAdd.ToolTipText = "Click to Add New Record"
        '
        'tsBtnEdit
        '
        Me.tsBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnEdit.Image = CType(resources.GetObject("tsBtnEdit.Image"), System.Drawing.Image)
        Me.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnEdit.Name = "tsBtnEdit"
        Me.tsBtnEdit.Size = New System.Drawing.Size(58, 45)
        Me.tsBtnEdit.Text = "Edit"
        Me.tsBtnEdit.ToolTipText = "Click to Edit Records"
        '
        'tsBtnUndo
        '
        Me.tsBtnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnUndo.Enabled = False
        Me.tsBtnUndo.Image = CType(resources.GetObject("tsBtnUndo.Image"), System.Drawing.Image)
        Me.tsBtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnUndo.Name = "tsBtnUndo"
        Me.tsBtnUndo.Size = New System.Drawing.Size(58, 45)
        Me.tsBtnUndo.Text = "Cancel Changes"
        Me.tsBtnUndo.ToolTipText = "Click to Cancel Changes"
        '
        'tsBtnDelete
        '
        Me.tsBtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnDelete.Enabled = False
        Me.tsBtnDelete.Image = CType(resources.GetObject("tsBtnDelete.Image"), System.Drawing.Image)
        Me.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDelete.Name = "tsBtnDelete"
        Me.tsBtnDelete.Size = New System.Drawing.Size(58, 45)
        Me.tsBtnDelete.Text = "Delete"
        '
        'tsBtnSave
        '
        Me.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnSave.Enabled = False
        Me.tsBtnSave.Image = CType(resources.GetObject("tsBtnSave.Image"), System.Drawing.Image)
        Me.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnSave.Name = "tsBtnSave"
        Me.tsBtnSave.Size = New System.Drawing.Size(58, 45)
        Me.tsBtnSave.Text = "Save"
        Me.tsBtnSave.ToolTipText = "Click to Save Changes"
        '
        'tsBtnPrint
        '
        Me.tsBtnPrint.Image = CType(resources.GetObject("tsBtnPrint.Image"), System.Drawing.Image)
        Me.tsBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPrint.Name = "tsBtnPrint"
        Me.tsBtnPrint.Size = New System.Drawing.Size(349, 45)
        Me.tsBtnPrint.Text = "Print Report for Review"
        Me.tsBtnPrint.ToolTipText = "Click to Print Report"
        '
        'tsBtnPrintRpt2
        '
        Me.tsBtnPrintRpt2.Image = CType(resources.GetObject("tsBtnPrintRpt2.Image"), System.Drawing.Image)
        Me.tsBtnPrintRpt2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPrintRpt2.Name = "tsBtnPrintRpt2"
        Me.tsBtnPrintRpt2.Size = New System.Drawing.Size(324, 45)
        Me.tsBtnPrintRpt2.Text = "Print Report for Sales"
        '
        'tsButtonHelp
        '
        Me.tsButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsButtonHelp.Image = CType(resources.GetObject("tsButtonHelp.Image"), System.Drawing.Image)
        Me.tsButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsButtonHelp.Name = "tsButtonHelp"
        Me.tsButtonHelp.Size = New System.Drawing.Size(58, 45)
        Me.tsButtonHelp.Text = "He&lp"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'tsBtnReloadData
        '
        Me.tsBtnReloadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnReloadData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tsBtnReloadData.ForeColor = System.Drawing.SystemColors.Highlight
        Me.tsBtnReloadData.Image = CType(resources.GetObject("tsBtnReloadData.Image"), System.Drawing.Image)
        Me.tsBtnReloadData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnReloadData.Name = "tsBtnReloadData"
        Me.tsBtnReloadData.Size = New System.Drawing.Size(224, 45)
        Me.tsBtnReloadData.Text = "RELOAD DATA"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'tsLblLastReloadDate
        '
        Me.tsLblLastReloadDate.Name = "tsLblLastReloadDate"
        Me.tsLblLastReloadDate.Size = New System.Drawing.Size(279, 45)
        Me.tsLblLastReloadDate.Text = "Data Last Reloaded:"
        '
        'tsBtnRecalculateGrid
        '
        Me.tsBtnRecalculateGrid.Image = CType(resources.GetObject("tsBtnRecalculateGrid.Image"), System.Drawing.Image)
        Me.tsBtnRecalculateGrid.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnRecalculateGrid.Name = "tsBtnRecalculateGrid"
        Me.tsBtnRecalculateGrid.Size = New System.Drawing.Size(258, 45)
        Me.tsBtnRecalculateGrid.Text = "Recalculate Grid"
        '
        'UltraStatusBar1
        '
        Me.UltraStatusBar1.Location = New System.Drawing.Point(0, 799)
        Me.UltraStatusBar1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.UltraStatusBar1.Name = "UltraStatusBar1"
        UltraStatusPanel1.Key = "JobBeingProcessed"
        UltraStatusPanel1.Text = "Job Being Processed"
        UltraStatusPanel1.Width = 300
        UltraStatusPanel2.Key = "CurrentProcess"
        UltraStatusPanel2.Width = 500
        Me.UltraStatusBar1.Panels.AddRange(New Infragistics.Win.UltraWinStatusBar.UltraStatusPanel() {UltraStatusPanel1, UltraStatusPanel2})
        Me.UltraStatusBar1.Size = New System.Drawing.Size(2872, 45)
        Me.UltraStatusBar1.TabIndex = 10
        Me.UltraStatusBar1.Text = "UltraStatusBar1"
        Me.UltraStatusBar1.WrapText = False
        '
        'UltraDesktopAlert1
        '
        Appearance85.Image = CType(resources.GetObject("Appearance85.Image"), Object)
        UltraDesktopAlertButton1.Appearance = Appearance85
        UltraDesktopAlertButton1.Key = "Print"
        UltraDesktopAlertButton1.ToolTipText = "Print Progress Log"
        Me.UltraDesktopAlert1.AlertButtons.AddRange(New Infragistics.Win.Misc.UltraDesktopAlertButton() {UltraDesktopAlertButton1})
        Me.UltraDesktopAlert1.TreatTextAsLink = Infragistics.Win.DefaultableBoolean.[False]
        '
        'ugDetails
        '
        Me.ugDetails.CalcManager = Me.UltraCalcManager1
        Me.ugDetails.DataMember = "spGetAnalysis"
        Me.ugDetails.DataSource = Me.HCHDataAnalysisDetail
        Appearance1.BackColor = System.Drawing.SystemColors.Window
        Appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugDetails.DisplayLayout.Appearance = Appearance1
        UltraGridColumn72.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn72.Header.VisiblePosition = 0
        UltraGridColumn72.Hidden = True
        UltraGridColumn73.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn73.Header.VisiblePosition = 31
        UltraGridColumn74.Format = "0.00"
        UltraGridColumn74.Header.Caption = "New Margin"
        UltraGridColumn74.Header.VisiblePosition = 16
        UltraGridColumn74.Width = 65
        UltraGridColumn75.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn75.Header.VisiblePosition = 1
        UltraGridColumn75.Hidden = True
        UltraGridColumn76.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn76.Header.VisiblePosition = 2
        UltraGridColumn76.Hidden = True
        UltraGridColumn77.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn77.Format = "MM/dd/yy"
        UltraGridColumn77.Header.Caption = "Costed Date"
        UltraGridColumn77.Header.VisiblePosition = 30
        UltraGridColumn77.Width = 67
        UltraGridColumn78.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn78.Header.VisiblePosition = 3
        UltraGridColumn78.Width = 61
        UltraGridColumn79.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn79.Header.VisiblePosition = 11
        UltraGridColumn79.Hidden = True
        UltraGridColumn80.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn80.Header.VisiblePosition = 6
        UltraGridColumn80.Hidden = True
        UltraGridColumn81.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn81.Format = "0.000"
        UltraGridColumn81.Header.Caption = "Hard Cost"
        UltraGridColumn81.Header.VisiblePosition = 7
        UltraGridColumn81.Hidden = True
        UltraGridColumn81.Width = 71
        UltraGridColumn82.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn82.Format = "0"
        UltraGridColumn82.Header.Caption = "Current Price"
        UltraGridColumn82.Header.VisiblePosition = 10
        UltraGridColumn82.Width = 70
        UltraGridColumn83.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn83.Format = "0"
        UltraGridColumn83.Header.Caption = "Lot Costs"
        UltraGridColumn83.Header.VisiblePosition = 14
        UltraGridColumn83.Hidden = True
        UltraGridColumn84.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn84.Format = "0"
        UltraGridColumn84.Header.Caption = "Price Without Lot"
        UltraGridColumn84.Header.VisiblePosition = 12
        UltraGridColumn84.Width = 78
        UltraGridColumn85.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn85.Header.Caption = "Sq Ft"
        UltraGridColumn85.Header.VisiblePosition = 4
        UltraGridColumn86.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn86.Header.Caption = "Price / Sq Ft"
        UltraGridColumn86.Header.VisiblePosition = 15
        UltraGridColumn86.Width = 60
        UltraGridColumn87.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn87.Format = "0"
        UltraGridColumn87.Header.Caption = "Soft Costs"
        UltraGridColumn87.Header.VisiblePosition = 5
        UltraGridColumn87.Width = 63
        UltraGridColumn88.Header.Caption = "Updated Price"
        UltraGridColumn88.Header.VisiblePosition = 20
        UltraGridColumn88.Width = 91
        UltraGridColumn89.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn89.Header.VisiblePosition = 21
        UltraGridColumn89.Hidden = True
        UltraGridColumn90.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn90.Header.Caption = "Hard Cost /SqFt"
        UltraGridColumn90.Header.VisiblePosition = 9
        UltraGridColumn90.Width = 51
        UltraGridColumn91.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn91.Header.VisiblePosition = 22
        UltraGridColumn91.Hidden = True
        UltraGridColumn92.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn92.Header.VisiblePosition = 23
        UltraGridColumn92.Hidden = True
        UltraGridColumn93.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn93.Header.VisiblePosition = 24
        UltraGridColumn93.Hidden = True
        UltraGridColumn94.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn94.Header.VisiblePosition = 25
        UltraGridColumn94.Hidden = True
        UltraGridColumn95.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn95.Header.VisiblePosition = 26
        UltraGridColumn95.Hidden = True
        UltraGridColumn96.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn96.Header.VisiblePosition = 27
        UltraGridColumn96.Hidden = True
        UltraGridColumn97.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn97.Format = "0"
        UltraGridColumn97.Header.Caption = "Hard Cost"
        UltraGridColumn97.Header.VisiblePosition = 8
        UltraGridColumn98.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn98.Format = "0.00"
        UltraGridColumn98.Header.Caption = "Current Margin"
        UltraGridColumn98.Header.VisiblePosition = 13
        UltraGridColumn98.Width = 67
        UltraGridColumn99.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn99.Format = "0"
        UltraGridColumn99.Header.Caption = "New Sales Price"
        UltraGridColumn99.Header.VisiblePosition = 18
        UltraGridColumn99.Width = 97
        UltraGridColumn100.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn100.Format = "0"
        UltraGridColumn100.Header.Caption = "New Sales Price With Lot"
        UltraGridColumn100.Header.VisiblePosition = 17
        UltraGridColumn100.Width = 101
        UltraGridColumn101.Format = "0"
        UltraGridColumn101.Header.Caption = "Analysis Price"
        UltraGridColumn101.Header.VisiblePosition = 28
        UltraGridColumn101.Hidden = True
        UltraGridColumn101.Width = 68
        UltraGridColumn102.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn102.Header.VisiblePosition = 29
        UltraGridColumn102.Hidden = True
        UltraGridColumn103.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn103.Header.VisiblePosition = 32
        UltraGridColumn103.Hidden = True
        UltraGridColumn104.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        UltraGridColumn104.Header.VisiblePosition = 33
        UltraGridColumn104.Hidden = True
        UltraGridColumn105.Header.VisiblePosition = 34
        UltraGridColumn105.Hidden = True
        UltraGridColumn105.Width = 345
        UltraGridColumn141.Header.VisiblePosition = 35
        UltraGridColumn141.Width = 343
        UltraGridColumn142.Formula = "[NewSalesPrc] - [PlanPrice]"
        UltraGridColumn142.Header.VisiblePosition = 19
        UltraGridColumn142.Width = 78
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn141, UltraGridColumn142})
        UltraGridBand1.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugDetails.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugDetails.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugDetails.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance2.BorderColor = System.Drawing.SystemColors.Window
        Me.ugDetails.DisplayLayout.GroupByBox.Appearance = Appearance2
        Appearance3.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugDetails.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance3
        Me.ugDetails.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance4.BackColor2 = System.Drawing.SystemColors.Control
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugDetails.DisplayLayout.GroupByBox.PromptAppearance = Appearance4
        Me.ugDetails.DisplayLayout.MaxColScrollRegions = 1
        Me.ugDetails.DisplayLayout.MaxRowScrollRegions = 1
        Appearance5.BackColor = System.Drawing.SystemColors.Window
        Appearance5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugDetails.DisplayLayout.Override.ActiveCellAppearance = Appearance5
        Appearance6.BackColor = System.Drawing.SystemColors.Highlight
        Appearance6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugDetails.DisplayLayout.Override.ActiveRowAppearance = Appearance6
        Me.ugDetails.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugDetails.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugDetails.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugDetails.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugDetails.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Me.ugDetails.DisplayLayout.Override.CardAreaAppearance = Appearance7
        Appearance8.BorderColor = System.Drawing.Color.Silver
        Appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugDetails.DisplayLayout.Override.CellAppearance = Appearance8
        Me.ugDetails.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugDetails.DisplayLayout.Override.CellPadding = 0
        Appearance9.BackColor = System.Drawing.SystemColors.Control
        Appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance9.BorderColor = System.Drawing.SystemColors.Window
        Me.ugDetails.DisplayLayout.Override.GroupByRowAppearance = Appearance9
        Appearance10.TextHAlignAsString = "Left"
        Me.ugDetails.DisplayLayout.Override.HeaderAppearance = Appearance10
        Me.ugDetails.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugDetails.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance11.BackColor = System.Drawing.SystemColors.Window
        Appearance11.BorderColor = System.Drawing.Color.Silver
        Me.ugDetails.DisplayLayout.Override.RowAppearance = Appearance11
        Me.ugDetails.DisplayLayout.Override.RowSelectorHeaderStyle = Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton
        Me.ugDetails.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[True]
        Appearance12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugDetails.DisplayLayout.Override.TemplateAddRowAppearance = Appearance12
        Me.ugDetails.DisplayLayout.Override.WrapHeaderText = Infragistics.Win.DefaultableBoolean.[True]
        Me.ugDetails.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugDetails.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugDetails.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy
        Me.ugDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugDetails.Location = New System.Drawing.Point(24, 646)
        Me.ugDetails.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.ugDetails.Name = "ugDetails"
        Me.ugDetails.Size = New System.Drawing.Size(3139, 1219)
        Me.ugDetails.TabIndex = 3
        Me.ugDetails.Text = "UltraGrid1"
        '
        'HCHDataAnalysisDetail
        '
        Me.HCHDataAnalysisDetail.DataSetName = "HCHDataAnalysisDetail"
        Me.HCHDataAnalysisDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGetTaxDistrictListTableAdapter
        '
        Me.SpGetTaxDistrictListTableAdapter.ClearBeforeFill = True
        '
        'SpGetAlphaCodesTableAdapter
        '
        Me.SpGetAlphaCodesTableAdapter.ClearBeforeFill = True
        '
        'SpGetOpenProjectsTableAdapter
        '
        Me.SpGetOpenProjectsTableAdapter.ClearBeforeFill = True
        '
        'SpGetAnalysesHeaderTableAdapter
        '
        Me.SpGetAnalysesHeaderTableAdapter.ClearBeforeFill = True
        '
        'SpGetAnalysisBindingSource
        '
        Me.SpGetAnalysisBindingSource.AllowNew = False
        Me.SpGetAnalysisBindingSource.DataMember = "spGetAnalysis"
        Me.SpGetAnalysisBindingSource.DataSource = Me.HCHDataAnalysisDetail
        '
        'SpGetAnalysisTableAdapter
        '
        Me.SpGetAnalysisTableAdapter.ClearBeforeFill = True
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        '
        '_CostAnalysisDetail_Toolbars_Dock_Area_Left
        '
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.BackColor = System.Drawing.SystemColors.Control
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 52)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.Name = "_CostAnalysisDetail_Toolbars_Dock_Area_Left"
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(0, 747)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CostAnalysisDetail_Toolbars_Dock_Area_Right
        '
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.BackColor = System.Drawing.SystemColors.Control
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(2872, 52)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.Name = "_CostAnalysisDetail_Toolbars_Dock_Area_Right"
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(0, 747)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CostAnalysisDetail_Toolbars_Dock_Area_Top
        '
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.BackColor = System.Drawing.SystemColors.Control
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.Name = "_CostAnalysisDetail_Toolbars_Dock_Area_Top"
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(2872, 0)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_CostAnalysisDetail_Toolbars_Dock_Area_Bottom
        '
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.SystemColors.Control
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 799)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Name = "_CostAnalysisDetail_Toolbars_Dock_Area_Bottom"
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(2872, 0)
        Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsViewEstimate, Me.tsEstimateCostedRpt, Me.tsSummaryBudgetRpt})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(423, 148)
        '
        'tsViewEstimate
        '
        Me.tsViewEstimate.Name = "tsViewEstimate"
        Me.tsViewEstimate.Size = New System.Drawing.Size(422, 48)
        Me.tsViewEstimate.Text = "View Estimate"
        '
        'tsEstimateCostedRpt
        '
        Me.tsEstimateCostedRpt.Name = "tsEstimateCostedRpt"
        Me.tsEstimateCostedRpt.Size = New System.Drawing.Size(422, 48)
        Me.tsEstimateCostedRpt.Text = "Estimate Costed Report"
        '
        'tsSummaryBudgetRpt
        '
        Me.tsSummaryBudgetRpt.Name = "tsSummaryBudgetRpt"
        Me.tsSummaryBudgetRpt.Size = New System.Drawing.Size(422, 48)
        Me.tsSummaryBudgetRpt.Text = "Summary Budget Report"
        '
        'CostAnalysisDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2872, 844)
        Me.Controls.Add(Me.pnlFields)
        Me.Controls.Add(Me.ugDetails)
        Me.Controls.Add(Me._CostAnalysisDetail_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._CostAnalysisDetail_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me.tsToolStrip)
        Me.Controls.Add(Me._CostAnalysisDetail_Toolbars_Dock_Area_Bottom)
        Me.Controls.Add(Me.UltraStatusBar1)
        Me.Controls.Add(Me._CostAnalysisDetail_Toolbars_Dock_Area_Top)
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "CostAnalysisDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cost Analysis Detail"
        Me.pnlFields.ResumeLayout(False)
        Me.pnlFields.PerformLayout()
        CType(Me.uteProjectPremium, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spGetAnalysesHeaderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataQADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteSoftCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteNewMargin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCustomAnalysis.ResumeLayout(False)
        Me.gpCustomAnalysis.PerformLayout()
        CType(Me.ucAlphaCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraCalcManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetAlphaCodesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataQAAlphaCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteCostIncreasePercent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucDistricts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetTaxDistrictListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataQADistricts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucProjectsPlans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSourcePlanProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataQAProjectList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucProjectOptions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSourceOptionsProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ucProjectsCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bndSourceCostProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpBoxStandardAnalysis.ResumeLayout(False)
        Me.gpBoxStandardAnalysis.PerformLayout()
        CType(Me.ucProjectStandard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetOpenProjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteProjectName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteProjectID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.utePeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uteAnalysisName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsToolStrip.ResumeLayout(False)
        Me.tsToolStrip.PerformLayout()
        CType(Me.udAlert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraStatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraDesktopAlert1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ugDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HCHDataAnalysisDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGetAnalysisBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ugDetails As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents SpGetAnalysisBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataAnalysisDetail As BossAdmin.HCHDataAnalysisDetail
    Friend WithEvents SpGetAnalysisTableAdapter As BossAdmin.HCHDataAnalysisDetailTableAdapters.spGetAnalysisTableAdapter
    Friend WithEvents spGetAnalysesHeaderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataQADataSet As BossAdmin.HCHDataQADataSet
    Friend WithEvents SpGetAnalysesHeaderTableAdapter As BossAdmin.HCHDataQADataSetTableAdapters.spGetAnalysesHeaderTableAdapter
    Friend WithEvents pnlFields As System.Windows.Forms.Panel
    Friend WithEvents ckPlansSelected As System.Windows.Forms.CheckBox
    Friend WithEvents btnSelectPlans As System.Windows.Forms.Button
    Friend WithEvents utePeriod As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uteAnalysisName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents uteProjectName As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents uteProjectID As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents uteNotes As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCreatedBy As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCreatedDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents chkDoNotUse As System.Windows.Forms.CheckBox
    Friend WithEvents tsToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents tsBtnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnUndo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnPrintRpt2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsButtonHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsBtnReloadData As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsLblLastReloadDate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents gpBoxStandardAnalysis As System.Windows.Forms.GroupBox
    Friend WithEvents ucProjectStandard As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents chkUseInfoFromStandardProject As System.Windows.Forms.CheckBox
    Friend WithEvents HCHDataQAProjectList As BossAdmin.HCHDataQAProjectList
    Friend WithEvents SpGetOpenProjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetOpenProjectsTableAdapter As BossAdmin.HCHDataQAProjectListTableAdapters.spGetOpenProjectsTableAdapter
    Friend WithEvents gpCustomAnalysis As System.Windows.Forms.GroupBox
    Friend WithEvents ucProjectOptions As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents ucProjectsCosts As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ucProjectsPlans As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ucAlphaCodes As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents uteCostIncreasePercent As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ucDistricts As Infragistics.Win.UltraWinGrid.UltraCombo
    Friend WithEvents bndSourceCostProject As System.Windows.Forms.BindingSource
    Friend WithEvents HCHDataQADistricts As BossAdmin.HCHDataQADistricts
    Friend WithEvents SpGetTaxDistrictListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetTaxDistrictListTableAdapter As BossAdmin.HCHDataQADistrictsTableAdapters.spGetTaxDistrictListTableAdapter
    Friend WithEvents HCHDataQAAlphaCodes As BossAdmin.HCHDataQAAlphaCodes
    Friend WithEvents SpGetAlphaCodesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGetAlphaCodesTableAdapter As BossAdmin.HCHDataQAAlphaCodesTableAdapters.spGetAlphaCodesTableAdapter
    Friend WithEvents bndSourceOptionsProject As System.Windows.Forms.BindingSource
    Friend WithEvents bndSourcePlanProjects As System.Windows.Forms.BindingSource
    Friend WithEvents udAlert As Infragistics.Win.Misc.UltraDesktopAlert
    Friend WithEvents UltraPopupControlContainer1 As Infragistics.Win.Misc.UltraPopupControlContainer
    Friend WithEvents UltraStatusBar1 As Infragistics.Win.UltraWinStatusBar.UltraStatusBar
    Friend WithEvents tsBtnRecalculateGrid As System.Windows.Forms.ToolStripButton
    Friend WithEvents UltraGridExcelExporter1 As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
    Friend WithEvents UltraDesktopAlert1 As Infragistics.Win.Misc.UltraDesktopAlert
    Friend WithEvents UltraCalcManager1 As Infragistics.Win.UltraWinCalcManager.UltraCalcManager
    Friend WithEvents uteNewMargin As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uteProjectPremium As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents uteSoftCosts As Infragistics.Win.UltraWinEditors.UltraNumericEditor
    Friend WithEvents _CostAnalysisDetail_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _CostAnalysisDetail_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CostAnalysisDetail_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _CostAnalysisDetail_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsViewEstimate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEstimateCostedRpt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSummaryBudgetRpt As System.Windows.Forms.ToolStripMenuItem
End Class
