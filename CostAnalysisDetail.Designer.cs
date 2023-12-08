using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CostAnalysisDetail : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing&&components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            var Appearance13 = new Infragistics.Win.Appearance();
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAlphaCodes", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCode");
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            var UltraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("alphaid");
            var UltraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxable");
            var UltraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("GroupCode");
            var UltraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("POMessage");
            var UltraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WCPerc");
            var UltraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaGroupID");
            var UltraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PAVendorOnly");
            var Appearance14 = new Infragistics.Win.Appearance();
            var Appearance15 = new Infragistics.Win.Appearance();
            var Appearance16 = new Infragistics.Win.Appearance();
            var Appearance17 = new Infragistics.Win.Appearance();
            var Appearance18 = new Infragistics.Win.Appearance();
            var Appearance19 = new Infragistics.Win.Appearance();
            var Appearance20 = new Infragistics.Win.Appearance();
            var Appearance21 = new Infragistics.Win.Appearance();
            var Appearance22 = new Infragistics.Win.Appearance();
            var Appearance23 = new Infragistics.Win.Appearance();
            var Appearance24 = new Infragistics.Win.Appearance();
            var Appearance25 = new Infragistics.Win.Appearance();
            var UltraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetTaxDistrictList", -1);
            var UltraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict");
            var Appearance26 = new Infragistics.Win.Appearance();
            var Appearance27 = new Infragistics.Win.Appearance();
            var Appearance28 = new Infragistics.Win.Appearance();
            var Appearance29 = new Infragistics.Win.Appearance();
            var Appearance30 = new Infragistics.Win.Appearance();
            var Appearance31 = new Infragistics.Win.Appearance();
            var Appearance32 = new Infragistics.Win.Appearance();
            var Appearance33 = new Infragistics.Win.Appearance();
            var Appearance34 = new Infragistics.Win.Appearance();
            var Appearance35 = new Infragistics.Win.Appearance();
            var Appearance36 = new Infragistics.Win.Appearance();
            var Appearance37 = new Infragistics.Win.Appearance();
            var UltraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1);
            var UltraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
            var Appearance38 = new Infragistics.Win.Appearance();
            var Appearance39 = new Infragistics.Win.Appearance();
            var Appearance40 = new Infragistics.Win.Appearance();
            var Appearance41 = new Infragistics.Win.Appearance();
            var Appearance42 = new Infragistics.Win.Appearance();
            var Appearance43 = new Infragistics.Win.Appearance();
            var Appearance44 = new Infragistics.Win.Appearance();
            var Appearance45 = new Infragistics.Win.Appearance();
            var Appearance46 = new Infragistics.Win.Appearance();
            var Appearance47 = new Infragistics.Win.Appearance();
            var Appearance48 = new Infragistics.Win.Appearance();
            var Appearance49 = new Infragistics.Win.Appearance();
            var UltraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1);
            var UltraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
            var Appearance50 = new Infragistics.Win.Appearance();
            var Appearance51 = new Infragistics.Win.Appearance();
            var Appearance52 = new Infragistics.Win.Appearance();
            var Appearance53 = new Infragistics.Win.Appearance();
            var Appearance54 = new Infragistics.Win.Appearance();
            var Appearance55 = new Infragistics.Win.Appearance();
            var Appearance56 = new Infragistics.Win.Appearance();
            var Appearance57 = new Infragistics.Win.Appearance();
            var Appearance58 = new Infragistics.Win.Appearance();
            var Appearance59 = new Infragistics.Win.Appearance();
            var Appearance60 = new Infragistics.Win.Appearance();
            var Appearance61 = new Infragistics.Win.Appearance();
            var UltraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1);
            var UltraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
            var Appearance62 = new Infragistics.Win.Appearance();
            var Appearance63 = new Infragistics.Win.Appearance();
            var Appearance64 = new Infragistics.Win.Appearance();
            var Appearance65 = new Infragistics.Win.Appearance();
            var Appearance66 = new Infragistics.Win.Appearance();
            var Appearance67 = new Infragistics.Win.Appearance();
            var Appearance68 = new Infragistics.Win.Appearance();
            var Appearance69 = new Infragistics.Win.Appearance();
            var Appearance70 = new Infragistics.Win.Appearance();
            var Appearance71 = new Infragistics.Win.Appearance();
            var Appearance72 = new Infragistics.Win.Appearance();
            var Appearance73 = new Infragistics.Win.Appearance();
            var UltraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1);
            var UltraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
            var Appearance74 = new Infragistics.Win.Appearance();
            var Appearance75 = new Infragistics.Win.Appearance();
            var Appearance76 = new Infragistics.Win.Appearance();
            var Appearance77 = new Infragistics.Win.Appearance();
            var Appearance78 = new Infragistics.Win.Appearance();
            var Appearance79 = new Infragistics.Win.Appearance();
            var Appearance80 = new Infragistics.Win.Appearance();
            var Appearance81 = new Infragistics.Win.Appearance();
            var Appearance82 = new Infragistics.Win.Appearance();
            var Appearance83 = new Infragistics.Win.Appearance();
            var Appearance84 = new Infragistics.Win.Appearance();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CostAnalysisDetail));
            var UltraStatusPanel1 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            var UltraStatusPanel2 = new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel();
            var UltraDesktopAlertButton1 = new Infragistics.Win.Misc.UltraDesktopAlertButton();
            var Appearance85 = new Infragistics.Win.Appearance();
            var Appearance1 = new Infragistics.Win.Appearance();
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAnalysis", -1);
            var UltraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VersionName");
            var UltraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("JobID");
            var UltraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NewMargin");
            var UltraGridColumn75 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProjectID");
            var UltraGridColumn76 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisDate");
            var UltraGridColumn77 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostedDate");
            var UltraGridColumn78 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanID");
            var UltraGridColumn79 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn80 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProject");
            var UltraGridColumn81 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetCost");
            var UltraGridColumn82 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanPrice", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn83 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LotCosts");
            var UltraGridColumn84 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PriceWithoutLot");
            var UltraGridColumn85 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SquareFeet");
            var UltraGridColumn86 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PricePerFoot");
            var UltraGridColumn87 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SoftCosts");
            var UltraGridColumn88 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedPrice");
            var UltraGridColumn89 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisID");
            var UltraGridColumn90 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostPerFoot");
            var UltraGridColumn91 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn92 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict");
            var UltraGridColumn93 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxRate");
            var UltraGridColumn94 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanProj");
            var UltraGridColumn95 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OptProj");
            var UltraGridColumn96 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CpyProject");
            var UltraGridColumn97 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActualCst");
            var UltraGridColumn98 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("GrsMargin");
            var UltraGridColumn99 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NewSalesPrc");
            var UltraGridColumn100 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NewSalesPrcWithLot");
            var UltraGridColumn101 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisPrice");
            var UltraGridColumn102 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Period");
            var UltraGridColumn103 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectPremium");
            var UltraGridColumn104 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy");
            var UltraGridColumn105 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Notes");
            var UltraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Note");
            var UltraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Increase", 0);
            var Appearance2 = new Infragistics.Win.Appearance();
            var Appearance3 = new Infragistics.Win.Appearance();
            var Appearance4 = new Infragistics.Win.Appearance();
            var Appearance5 = new Infragistics.Win.Appearance();
            var Appearance6 = new Infragistics.Win.Appearance();
            var Appearance7 = new Infragistics.Win.Appearance();
            var Appearance8 = new Infragistics.Win.Appearance();
            var Appearance9 = new Infragistics.Win.Appearance();
            var Appearance10 = new Infragistics.Win.Appearance();
            var Appearance11 = new Infragistics.Win.Appearance();
            var Appearance12 = new Infragistics.Win.Appearance();
            pnlFields=new Panel();
            uteProjectPremium=new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            spGetAnalysesHeaderBindingSource=new BindingSource(components);
            HCHDataQADataSet=new HCHDataQADataSet();
            uteSoftCosts=new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            uteNewMargin=new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            gpCustomAnalysis=new GroupBox();
            Label16=new Label();
            ucAlphaCodes=new Infragistics.Win.UltraWinGrid.UltraCombo();
            UltraCalcManager1=new Infragistics.Win.UltraWinCalcManager.UltraCalcManager(components);
            SpGetAlphaCodesBindingSource=new BindingSource(components);
            HCHDataQAAlphaCodes=new HCHDataQAAlphaCodes();
            uteCostIncreasePercent=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            Label15=new Label();
            Label14=new Label();
            ucDistricts=new Infragistics.Win.UltraWinGrid.UltraCombo();
            SpGetTaxDistrictListBindingSource=new BindingSource(components);
            HCHDataQADistricts=new HCHDataQADistricts();
            Label13=new Label();
            ucProjectsPlans=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ucProjectsPlans.RowSelected+=new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(ucProjectsPlans_RowSelected);
            bndSourcePlanProjects=new BindingSource(components);
            HCHDataQAProjectList=new HCHDataQAProjectList();
            Label12=new Label();
            Label11=new Label();
            ucProjectOptions=new Infragistics.Win.UltraWinGrid.UltraCombo();
            bndSourceOptionsProject=new BindingSource(components);
            ucProjectsCosts=new Infragistics.Win.UltraWinGrid.UltraCombo();
            bndSourceCostProject=new BindingSource(components);
            gpBoxStandardAnalysis=new GroupBox();
            ucProjectStandard=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ucProjectStandard.RowSelected+=new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(ucProjectStandard_RowSelected);
            SpGetOpenProjectsBindingSource=new BindingSource(components);
            chkUseInfoFromStandardProject=new CheckBox();
            chkUseInfoFromStandardProject.CheckedChanged+=new EventHandler(chkUseInfoFromStandardProject_CheckedChanged);
            Label6=new Label();
            chkDoNotUse=new CheckBox();
            Label10=new Label();
            Label9=new Label();
            Label7=new Label();
            lblCreatedBy=new Label();
            Label8=new Label();
            lblCreatedDate=new Label();
            uteNotes=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            Label5=new Label();
            Label4=new Label();
            uteProjectName=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            uteProjectID=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            Label3=new Label();
            ckPlansSelected=new CheckBox();
            btnSelectPlans=new Button();
            btnSelectPlans.Click+=new EventHandler(btnSelectPlans_Click);
            utePeriod=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            Label2=new Label();
            Label1=new Label();
            uteAnalysisName=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnEdit=new ToolStripButton();
            tsBtnEdit.Click+=new EventHandler(tsBtnEdit_Click);
            tsBtnUndo=new ToolStripButton();
            tsBtnDelete=new ToolStripButton();
            tsBtnSave=new ToolStripButton();
            tsBtnSave.Click+=new EventHandler(tsBtnSave_Click);
            tsBtnPrint=new ToolStripButton();
            tsBtnPrint.Click+=new EventHandler(tsBtnPrint_Click);
            tsBtnPrintRpt2=new ToolStripButton();
            tsBtnPrintRpt2.Click+=new EventHandler(tsBtnPrintRpt2_Click);
            tsButtonHelp=new ToolStripButton();
            tsButtonHelp.Click+=new EventHandler(HelpToolStripButton_Click);
            ToolStripSeparator1=new ToolStripSeparator();
            tsBtnReloadData=new ToolStripButton();
            tsBtnReloadData.Click+=new EventHandler(tsBtnReloadData_Click);
            ToolStripSeparator2=new ToolStripSeparator();
            tsLblLastReloadDate=new ToolStripLabel();
            tsBtnRecalculateGrid=new ToolStripButton();
            tsBtnRecalculateGrid.Click+=new EventHandler(ToolStripButton1_Click);
            udAlert=new Infragistics.Win.Misc.UltraDesktopAlert(components);
            UltraPopupControlContainer1=new Infragistics.Win.Misc.UltraPopupControlContainer(components);
            UltraStatusBar1=new Infragistics.Win.UltraWinStatusBar.UltraStatusBar();
            UltraGridExcelExporter1=new Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter(components);
            UltraDesktopAlert1=new Infragistics.Win.Misc.UltraDesktopAlert(components);
            ugDetails=new Infragistics.Win.UltraWinGrid.UltraGrid();
            ugDetails.MouseDown+=new MouseEventHandler(ugDetails_MouseDown);
            HCHDataAnalysisDetail=new HCHDataAnalysisDetail();
            SpGetTaxDistrictListTableAdapter=new HCHDataQADistrictsTableAdapters.spGetTaxDistrictListTableAdapter();
            SpGetAlphaCodesTableAdapter=new HCHDataQAAlphaCodesTableAdapters.spGetAlphaCodesTableAdapter();
            SpGetOpenProjectsTableAdapter=new HCHDataQAProjectListTableAdapters.spGetOpenProjectsTableAdapter();
            SpGetAnalysesHeaderTableAdapter=new HCHDataQADataSetTableAdapters.spGetAnalysesHeaderTableAdapter();
            SpGetAnalysisBindingSource=new BindingSource(components);
            SpGetAnalysisTableAdapter=new HCHDataAnalysisDetailTableAdapters.spGetAnalysisTableAdapter();
            UltraToolbarsManager1=new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(components);
            _CostAnalysisDetail_Toolbars_Dock_Area_Left=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _CostAnalysisDetail_Toolbars_Dock_Area_Right=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _CostAnalysisDetail_Toolbars_Dock_Area_Top=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            ContextMenuStrip1=new ContextMenuStrip(components);
            tsViewEstimate=new ToolStripMenuItem();
            tsViewEstimate.Click+=new EventHandler(tsViewEstimate_Click);
            tsEstimateCostedRpt=new ToolStripMenuItem();
            tsEstimateCostedRpt.Click+=new EventHandler(tsEstimateCostedRpt_Click);
            tsSummaryBudgetRpt=new ToolStripMenuItem();
            tsSummaryBudgetRpt.Click+=new EventHandler(tsSummaryBudgetRpt_Click);
            pnlFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uteProjectPremium).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spGetAnalysesHeaderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQADataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteSoftCosts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteNewMargin).BeginInit();
            gpCustomAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucAlphaCodes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraCalcManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAlphaCodesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQAAlphaCodes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteCostIncreasePercent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucDistricts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetTaxDistrictListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQADistricts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectsPlans).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndSourcePlanProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQAProjectList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectOptions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndSourceOptionsProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectsCosts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bndSourceCostProject).BeginInit();
            gpBoxStandardAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucProjectStandard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetOpenProjectsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteProjectName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteProjectID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utePeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteAnalysisName).BeginInit();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udAlert).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraStatusBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraDesktopAlert1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataAnalysisDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAnalysisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraToolbarsManager1).BeginInit();
            ContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlFields
            // 
            pnlFields.Controls.Add(uteProjectPremium);
            pnlFields.Controls.Add(uteSoftCosts);
            pnlFields.Controls.Add(uteNewMargin);
            pnlFields.Controls.Add(gpCustomAnalysis);
            pnlFields.Controls.Add(gpBoxStandardAnalysis);
            pnlFields.Controls.Add(Label6);
            pnlFields.Controls.Add(chkDoNotUse);
            pnlFields.Controls.Add(Label10);
            pnlFields.Controls.Add(Label9);
            pnlFields.Controls.Add(Label7);
            pnlFields.Controls.Add(lblCreatedBy);
            pnlFields.Controls.Add(Label8);
            pnlFields.Controls.Add(lblCreatedDate);
            pnlFields.Controls.Add(uteNotes);
            pnlFields.Controls.Add(Label5);
            pnlFields.Controls.Add(Label4);
            pnlFields.Controls.Add(uteProjectName);
            pnlFields.Controls.Add(uteProjectID);
            pnlFields.Controls.Add(Label3);
            pnlFields.Controls.Add(ckPlansSelected);
            pnlFields.Controls.Add(btnSelectPlans);
            pnlFields.Controls.Add(utePeriod);
            pnlFields.Controls.Add(Label2);
            pnlFields.Controls.Add(Label1);
            pnlFields.Controls.Add(uteAnalysisName);
            pnlFields.Location=new Point(24, 98);
            pnlFields.Margin=new Padding(5, 7, 5, 7);
            pnlFields.Name="pnlFields";
            pnlFields.Size=new Size(2901, 539);
            pnlFields.TabIndex=8;
            // 
            // uteProjectPremium
            // 
            uteProjectPremium.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "ProjectPremium", true));
            uteProjectPremium.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "ProjectPremium", true));
            uteProjectPremium.Location=new Point(1005, 186);
            uteProjectPremium.Margin=new Padding(5, 7, 5, 7);
            uteProjectPremium.MaskInput="nnnnnnnnn";
            uteProjectPremium.Name="uteProjectPremium";
            uteProjectPremium.NullText="0";
            uteProjectPremium.Size=new Size(157, 41);
            uteProjectPremium.TabIndex=7;
            // 
            // spGetAnalysesHeaderBindingSource
            // 
            spGetAnalysesHeaderBindingSource.DataMember="spGetAnalysesHeader";
            spGetAnalysesHeaderBindingSource.DataSource=HCHDataQADataSet;
            // 
            // HCHDataQADataSet
            // 
            HCHDataQADataSet.DataSetName="HCHDataQADataSet";
            HCHDataQADataSet.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // uteSoftCosts
            // 
            uteSoftCosts.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "SoftCosts", true));
            uteSoftCosts.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "SoftCosts", true));
            uteSoftCosts.Location=new Point(565, 184);
            uteSoftCosts.Margin=new Padding(5, 7, 5, 7);
            uteSoftCosts.MaskInput="nnnnnnnnn";
            uteSoftCosts.MinValue=0;
            uteSoftCosts.Name="uteSoftCosts";
            uteSoftCosts.NullText="0";
            uteSoftCosts.Size=new Size(149, 41);
            uteSoftCosts.TabIndex=6;
            // 
            // uteNewMargin
            // 
            uteNewMargin.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "NewMargin", true));
            uteNewMargin.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "NewMargin", true));
            uteNewMargin.Location=new Point(288, 186);
            uteNewMargin.Margin=new Padding(5, 7, 5, 7);
            uteNewMargin.MaskClipMode=Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw;
            uteNewMargin.MaskDisplayMode=Infragistics.Win.UltraWinMaskedEdit.MaskMode.Raw;
            uteNewMargin.MaskInput=".nnn";
            uteNewMargin.MaxValue=1;
            uteNewMargin.MinValue=0;
            uteNewMargin.Name="uteNewMargin";
            uteNewMargin.NumericType=Infragistics.Win.UltraWinEditors.NumericType.Decimal;
            uteNewMargin.Size=new Size(72, 41);
            uteNewMargin.TabIndex=5;
            // 
            // gpCustomAnalysis
            // 
            gpCustomAnalysis.Controls.Add(Label16);
            gpCustomAnalysis.Controls.Add(ucAlphaCodes);
            gpCustomAnalysis.Controls.Add(uteCostIncreasePercent);
            gpCustomAnalysis.Controls.Add(Label15);
            gpCustomAnalysis.Controls.Add(Label14);
            gpCustomAnalysis.Controls.Add(ucDistricts);
            gpCustomAnalysis.Controls.Add(Label13);
            gpCustomAnalysis.Controls.Add(ucProjectsPlans);
            gpCustomAnalysis.Controls.Add(Label12);
            gpCustomAnalysis.Controls.Add(Label11);
            gpCustomAnalysis.Controls.Add(ucProjectOptions);
            gpCustomAnalysis.Controls.Add(ucProjectsCosts);
            gpCustomAnalysis.Location=new Point(1344, 193);
            gpCustomAnalysis.Margin=new Padding(5, 7, 5, 7);
            gpCustomAnalysis.Name="gpCustomAnalysis";
            gpCustomAnalysis.Padding=new Padding(5, 7, 5, 7);
            gpCustomAnalysis.Size=new Size(1261, 341);
            gpCustomAnalysis.TabIndex=33;
            gpCustomAnalysis.TabStop=false;
            gpCustomAnalysis.Text="Custom Analysis";
            // 
            // Label16
            // 
            Label16.AutoSize=true;
            Label16.Location=new Point(784, 272);
            Label16.Margin=new Padding(5, 0, 5, 0);
            Label16.Name="Label16";
            Label16.Size=new Size(220, 32);
            Label16.TabIndex=47;
            Label16.Text="For Alpha Code:";
            Label16.TextAlign=ContentAlignment.TopRight;
            // 
            // ucAlphaCodes
            // 
            ucAlphaCodes.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucAlphaCodes.CalcManager=UltraCalcManager1;
            ucAlphaCodes.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "CostIncreaseAlpha", true));
            ucAlphaCodes.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "AlphaCode", true));
            ucAlphaCodes.DataSource=SpGetAlphaCodesBindingSource;
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            ucAlphaCodes.DisplayLayout.Appearance=Appearance13;
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridColumn2.Header.VisiblePosition=1;
            UltraGridColumn3.Header.VisiblePosition=2;
            UltraGridColumn3.Hidden=true;
            UltraGridColumn4.Header.VisiblePosition=3;
            UltraGridColumn4.Hidden=true;
            UltraGridColumn5.Header.VisiblePosition=4;
            UltraGridColumn5.Hidden=true;
            UltraGridColumn6.Header.VisiblePosition=5;
            UltraGridColumn6.Hidden=true;
            UltraGridColumn7.Header.VisiblePosition=6;
            UltraGridColumn7.Hidden=true;
            UltraGridColumn8.Header.VisiblePosition=7;
            UltraGridColumn8.Hidden=true;
            UltraGridColumn9.Header.VisiblePosition=8;
            UltraGridColumn9.Hidden=true;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9 });
            ucAlphaCodes.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            ucAlphaCodes.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucAlphaCodes.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            ucAlphaCodes.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            ucAlphaCodes.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            ucAlphaCodes.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            ucAlphaCodes.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            ucAlphaCodes.DisplayLayout.MaxColScrollRegions=1;
            ucAlphaCodes.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            ucAlphaCodes.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            ucAlphaCodes.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            ucAlphaCodes.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucAlphaCodes.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            ucAlphaCodes.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucAlphaCodes.DisplayLayout.Override.CellAppearance=Appearance20;
            ucAlphaCodes.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucAlphaCodes.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            ucAlphaCodes.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            ucAlphaCodes.DisplayLayout.Override.HeaderAppearance=Appearance22;
            ucAlphaCodes.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucAlphaCodes.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            ucAlphaCodes.DisplayLayout.Override.RowAppearance=Appearance23;
            ucAlphaCodes.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance24.BackColor=SystemColors.ControlLight;
            ucAlphaCodes.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            ucAlphaCodes.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucAlphaCodes.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucAlphaCodes.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucAlphaCodes.DisplayMember="AlphaCode";
            ucAlphaCodes.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucAlphaCodes.Location=new Point(1019, 265);
            ucAlphaCodes.Margin=new Padding(5, 7, 5, 7);
            ucAlphaCodes.Name="ucAlphaCodes";
            ucAlphaCodes.NullText="(Choose)";
            ucAlphaCodes.Size=new Size(224, 42);
            ucAlphaCodes.TabIndex=15;
            ucAlphaCodes.ValueMember="alphaid";
            // 
            // UltraCalcManager1
            // 
            UltraCalcManager1.ContainingControl=this;
            // 
            // SpGetAlphaCodesBindingSource
            // 
            SpGetAlphaCodesBindingSource.DataMember="spGetAlphaCodes";
            SpGetAlphaCodesBindingSource.DataSource=HCHDataQAAlphaCodes;
            // 
            // HCHDataQAAlphaCodes
            // 
            HCHDataQAAlphaCodes.DataSetName="HCHDataQAAlphaCodes";
            HCHDataQAAlphaCodes.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // uteCostIncreasePercent
            // 
            uteCostIncreasePercent.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "CostIncreasePercent", true));
            uteCostIncreasePercent.Location=new Point(699, 265);
            uteCostIncreasePercent.Margin=new Padding(5, 7, 5, 7);
            uteCostIncreasePercent.MaxLength=5;
            uteCostIncreasePercent.Name="uteCostIncreasePercent";
            uteCostIncreasePercent.Size=new Size(75, 41);
            uteCostIncreasePercent.TabIndex=14;
            // 
            // Label15
            // 
            Label15.AutoSize=true;
            Label15.Location=new Point(472, 272);
            Label15.Margin=new Padding(5, 0, 5, 0);
            Label15.Name="Label15";
            Label15.Size=new Size(219, 32);
            Label15.TabIndex=44;
            Label15.Text="% Cost Increase";
            Label15.TextAlign=ContentAlignment.TopRight;
            // 
            // Label14
            // 
            Label14.AutoSize=true;
            Label14.Location=new Point(635, 215);
            Label14.Margin=new Padding(5, 0, 5, 0);
            Label14.Name="Label14";
            Label14.Size=new Size(109, 32);
            Label14.TabIndex=43;
            Label14.Text="District:";
            Label14.TextAlign=ContentAlignment.TopRight;
            // 
            // ucDistricts
            // 
            ucDistricts.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucDistricts.CalcManager=UltraCalcManager1;
            ucDistricts.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "TaxPermitDistrict", true));
            ucDistricts.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "TaxPermitID", true));
            ucDistricts.DataSource=SpGetTaxDistrictListBindingSource;
            Appearance25.BackColor=SystemColors.Window;
            Appearance25.BorderColor=SystemColors.InactiveCaption;
            ucDistricts.DisplayLayout.Appearance=Appearance25;
            UltraGridColumn10.Header.VisiblePosition=1;
            UltraGridColumn10.Hidden=true;
            UltraGridColumn11.Header.VisiblePosition=0;
            UltraGridBand3.Columns.AddRange(new object[] { UltraGridColumn10, UltraGridColumn11 });
            ucDistricts.DisplayLayout.BandsSerializer.Add(UltraGridBand3);
            ucDistricts.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucDistricts.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance26.BackColor=SystemColors.ActiveBorder;
            Appearance26.BackColor2=SystemColors.ControlDark;
            Appearance26.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance26.BorderColor=SystemColors.Window;
            ucDistricts.DisplayLayout.GroupByBox.Appearance=Appearance26;
            Appearance27.ForeColor=SystemColors.GrayText;
            ucDistricts.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance27;
            ucDistricts.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance28.BackColor=SystemColors.ControlLightLight;
            Appearance28.BackColor2=SystemColors.Control;
            Appearance28.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance28.ForeColor=SystemColors.GrayText;
            ucDistricts.DisplayLayout.GroupByBox.PromptAppearance=Appearance28;
            ucDistricts.DisplayLayout.MaxColScrollRegions=1;
            ucDistricts.DisplayLayout.MaxRowScrollRegions=1;
            Appearance29.BackColor=SystemColors.Window;
            Appearance29.ForeColor=SystemColors.ControlText;
            ucDistricts.DisplayLayout.Override.ActiveCellAppearance=Appearance29;
            Appearance30.BackColor=SystemColors.Highlight;
            Appearance30.ForeColor=SystemColors.HighlightText;
            ucDistricts.DisplayLayout.Override.ActiveRowAppearance=Appearance30;
            ucDistricts.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucDistricts.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance31.BackColor=SystemColors.Window;
            ucDistricts.DisplayLayout.Override.CardAreaAppearance=Appearance31;
            Appearance32.BorderColor=Color.Silver;
            Appearance32.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucDistricts.DisplayLayout.Override.CellAppearance=Appearance32;
            ucDistricts.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucDistricts.DisplayLayout.Override.CellPadding=0;
            Appearance33.BackColor=SystemColors.Control;
            Appearance33.BackColor2=SystemColors.ControlDark;
            Appearance33.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance33.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance33.BorderColor=SystemColors.Window;
            ucDistricts.DisplayLayout.Override.GroupByRowAppearance=Appearance33;
            Appearance34.TextHAlignAsString="Left";
            ucDistricts.DisplayLayout.Override.HeaderAppearance=Appearance34;
            ucDistricts.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucDistricts.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance35.BackColor=SystemColors.Window;
            Appearance35.BorderColor=Color.Silver;
            ucDistricts.DisplayLayout.Override.RowAppearance=Appearance35;
            ucDistricts.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance36.BackColor=SystemColors.ControlLight;
            ucDistricts.DisplayLayout.Override.TemplateAddRowAppearance=Appearance36;
            ucDistricts.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucDistricts.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucDistricts.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucDistricts.DisplayMember="TaxPermitDistrict";
            ucDistricts.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucDistricts.Location=new Point(773, 207);
            ucDistricts.Margin=new Padding(5, 7, 5, 7);
            ucDistricts.Name="ucDistricts";
            ucDistricts.NullText="(Choose)";
            ucDistricts.Size=new Size(443, 42);
            ucDistricts.TabIndex=13;
            ucDistricts.ValueMember="TaxPermitID";
            // 
            // SpGetTaxDistrictListBindingSource
            // 
            SpGetTaxDistrictListBindingSource.DataMember="spGetTaxDistrictList";
            SpGetTaxDistrictListBindingSource.DataSource=HCHDataQADistricts;
            // 
            // HCHDataQADistricts
            // 
            HCHDataQADistricts.DataSetName="HCHDataQADistricts";
            HCHDataQADistricts.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // Label13
            // 
            Label13.AutoSize=true;
            Label13.Location=new Point(520, 155);
            Label13.Margin=new Padding(5, 0, 5, 0);
            Label13.Name="Label13";
            Label13.Size=new Size(223, 32);
            Label13.TabIndex=41;
            Label13.Text="Use Plans From:";
            Label13.TextAlign=ContentAlignment.TopRight;
            // 
            // ucProjectsPlans
            // 
            ucProjectsPlans.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucProjectsPlans.CalcManager=UltraCalcManager1;
            ucProjectsPlans.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "PlanProject", true));
            ucProjectsPlans.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "PlanProjectID", true));
            ucProjectsPlans.DataSource=bndSourcePlanProjects;
            Appearance37.BackColor=SystemColors.Window;
            Appearance37.BorderColor=SystemColors.InactiveCaption;
            ucProjectsPlans.DisplayLayout.Appearance=Appearance37;
            UltraGridColumn12.Header.VisiblePosition=0;
            UltraGridColumn13.Header.VisiblePosition=1;
            UltraGridColumn14.Header.VisiblePosition=2;
            UltraGridColumn14.Hidden=true;
            UltraGridColumn15.Header.VisiblePosition=3;
            UltraGridColumn15.Hidden=true;
            UltraGridColumn16.Header.VisiblePosition=4;
            UltraGridColumn16.Hidden=true;
            UltraGridColumn17.Header.VisiblePosition=5;
            UltraGridBand4.Columns.AddRange(new object[] { UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17 });
            ucProjectsPlans.DisplayLayout.BandsSerializer.Add(UltraGridBand4);
            ucProjectsPlans.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucProjectsPlans.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance38.BackColor=SystemColors.ActiveBorder;
            Appearance38.BackColor2=SystemColors.ControlDark;
            Appearance38.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance38.BorderColor=SystemColors.Window;
            ucProjectsPlans.DisplayLayout.GroupByBox.Appearance=Appearance38;
            Appearance39.ForeColor=SystemColors.GrayText;
            ucProjectsPlans.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance39;
            ucProjectsPlans.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance40.BackColor=SystemColors.ControlLightLight;
            Appearance40.BackColor2=SystemColors.Control;
            Appearance40.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance40.ForeColor=SystemColors.GrayText;
            ucProjectsPlans.DisplayLayout.GroupByBox.PromptAppearance=Appearance40;
            ucProjectsPlans.DisplayLayout.MaxColScrollRegions=1;
            ucProjectsPlans.DisplayLayout.MaxRowScrollRegions=1;
            Appearance41.BackColor=SystemColors.Window;
            Appearance41.ForeColor=SystemColors.ControlText;
            ucProjectsPlans.DisplayLayout.Override.ActiveCellAppearance=Appearance41;
            Appearance42.BackColor=SystemColors.Highlight;
            Appearance42.ForeColor=SystemColors.HighlightText;
            ucProjectsPlans.DisplayLayout.Override.ActiveRowAppearance=Appearance42;
            ucProjectsPlans.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucProjectsPlans.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance43.BackColor=SystemColors.Window;
            ucProjectsPlans.DisplayLayout.Override.CardAreaAppearance=Appearance43;
            Appearance44.BorderColor=Color.Silver;
            Appearance44.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucProjectsPlans.DisplayLayout.Override.CellAppearance=Appearance44;
            ucProjectsPlans.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucProjectsPlans.DisplayLayout.Override.CellPadding=0;
            Appearance45.BackColor=SystemColors.Control;
            Appearance45.BackColor2=SystemColors.ControlDark;
            Appearance45.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance45.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance45.BorderColor=SystemColors.Window;
            ucProjectsPlans.DisplayLayout.Override.GroupByRowAppearance=Appearance45;
            Appearance46.TextHAlignAsString="Left";
            ucProjectsPlans.DisplayLayout.Override.HeaderAppearance=Appearance46;
            ucProjectsPlans.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucProjectsPlans.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance47.BackColor=SystemColors.Window;
            Appearance47.BorderColor=Color.Silver;
            ucProjectsPlans.DisplayLayout.Override.RowAppearance=Appearance47;
            ucProjectsPlans.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance48.BackColor=SystemColors.ControlLight;
            ucProjectsPlans.DisplayLayout.Override.TemplateAddRowAppearance=Appearance48;
            ucProjectsPlans.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucProjectsPlans.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucProjectsPlans.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucProjectsPlans.DisplayMember="ProjectID";
            ucProjectsPlans.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucProjectsPlans.Location=new Point(773, 148);
            ucProjectsPlans.Margin=new Padding(5, 7, 5, 7);
            ucProjectsPlans.Name="ucProjectsPlans";
            ucProjectsPlans.NullText="(Choose)";
            ucProjectsPlans.Size=new Size(240, 42);
            ucProjectsPlans.TabIndex=12;
            ucProjectsPlans.ValueMember="ID";
            // 
            // bndSourcePlanProjects
            // 
            bndSourcePlanProjects.AllowNew=false;
            bndSourcePlanProjects.DataMember="spGetOpenProjects";
            bndSourcePlanProjects.DataSource=HCHDataQAProjectList;
            // 
            // HCHDataQAProjectList
            // 
            HCHDataQAProjectList.DataSetName="HCHDataQAProjectList";
            HCHDataQAProjectList.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // Label12
            // 
            Label12.AutoSize=true;
            Label12.Location=new Point(245, 95);
            Label12.Margin=new Padding(5, 0, 5, 0);
            Label12.Name="Label12";
            Label12.Size=new Size(496, 32);
            Label12.TabIndex=39;
            Label12.Text="Use Project Options and Details From:";
            Label12.TextAlign=ContentAlignment.TopRight;
            // 
            // Label11
            // 
            Label11.AutoSize=true;
            Label11.Location=new Point(520, 36);
            Label11.Margin=new Padding(5, 0, 5, 0);
            Label11.Name="Label11";
            Label11.Size=new Size(223, 32);
            Label11.TabIndex=38;
            Label11.Text="Use Costs From:";
            Label11.TextAlign=ContentAlignment.TopRight;
            // 
            // ucProjectOptions
            // 
            ucProjectOptions.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucProjectOptions.CalcManager=UltraCalcManager1;
            ucProjectOptions.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "OptionProjectID", true));
            ucProjectOptions.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "OptionProject", true));
            ucProjectOptions.DataSource=bndSourceOptionsProject;
            Appearance49.BackColor=SystemColors.Window;
            Appearance49.BorderColor=SystemColors.InactiveCaption;
            ucProjectOptions.DisplayLayout.Appearance=Appearance49;
            UltraGridColumn18.Header.VisiblePosition=0;
            UltraGridColumn19.Header.VisiblePosition=1;
            UltraGridColumn20.Header.VisiblePosition=2;
            UltraGridColumn20.Hidden=true;
            UltraGridColumn21.Header.VisiblePosition=3;
            UltraGridColumn21.Hidden=true;
            UltraGridColumn22.Header.VisiblePosition=4;
            UltraGridColumn22.Hidden=true;
            UltraGridColumn23.Header.VisiblePosition=5;
            UltraGridBand5.Columns.AddRange(new object[] { UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23 });
            ucProjectOptions.DisplayLayout.BandsSerializer.Add(UltraGridBand5);
            ucProjectOptions.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucProjectOptions.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance50.BackColor=SystemColors.ActiveBorder;
            Appearance50.BackColor2=SystemColors.ControlDark;
            Appearance50.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance50.BorderColor=SystemColors.Window;
            ucProjectOptions.DisplayLayout.GroupByBox.Appearance=Appearance50;
            Appearance51.ForeColor=SystemColors.GrayText;
            ucProjectOptions.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance51;
            ucProjectOptions.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance52.BackColor=SystemColors.ControlLightLight;
            Appearance52.BackColor2=SystemColors.Control;
            Appearance52.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance52.ForeColor=SystemColors.GrayText;
            ucProjectOptions.DisplayLayout.GroupByBox.PromptAppearance=Appearance52;
            ucProjectOptions.DisplayLayout.MaxColScrollRegions=1;
            ucProjectOptions.DisplayLayout.MaxRowScrollRegions=1;
            Appearance53.BackColor=SystemColors.Window;
            Appearance53.ForeColor=SystemColors.ControlText;
            ucProjectOptions.DisplayLayout.Override.ActiveCellAppearance=Appearance53;
            Appearance54.BackColor=SystemColors.Highlight;
            Appearance54.ForeColor=SystemColors.HighlightText;
            ucProjectOptions.DisplayLayout.Override.ActiveRowAppearance=Appearance54;
            ucProjectOptions.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucProjectOptions.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance55.BackColor=SystemColors.Window;
            ucProjectOptions.DisplayLayout.Override.CardAreaAppearance=Appearance55;
            Appearance56.BorderColor=Color.Silver;
            Appearance56.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucProjectOptions.DisplayLayout.Override.CellAppearance=Appearance56;
            ucProjectOptions.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucProjectOptions.DisplayLayout.Override.CellPadding=0;
            Appearance57.BackColor=SystemColors.Control;
            Appearance57.BackColor2=SystemColors.ControlDark;
            Appearance57.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance57.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance57.BorderColor=SystemColors.Window;
            ucProjectOptions.DisplayLayout.Override.GroupByRowAppearance=Appearance57;
            Appearance58.TextHAlignAsString="Left";
            ucProjectOptions.DisplayLayout.Override.HeaderAppearance=Appearance58;
            ucProjectOptions.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucProjectOptions.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance59.BackColor=SystemColors.Window;
            Appearance59.BorderColor=Color.Silver;
            ucProjectOptions.DisplayLayout.Override.RowAppearance=Appearance59;
            ucProjectOptions.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance60.BackColor=SystemColors.ControlLight;
            ucProjectOptions.DisplayLayout.Override.TemplateAddRowAppearance=Appearance60;
            ucProjectOptions.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucProjectOptions.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucProjectOptions.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucProjectOptions.DisplayMember="ProjectID";
            ucProjectOptions.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucProjectOptions.Location=new Point(773, 86);
            ucProjectOptions.Margin=new Padding(5, 7, 5, 7);
            ucProjectOptions.Name="ucProjectOptions";
            ucProjectOptions.NullText="(Choose)";
            ucProjectOptions.Size=new Size(240, 42);
            ucProjectOptions.TabIndex=11;
            ucProjectOptions.ValueMember="ID";
            // 
            // bndSourceOptionsProject
            // 
            bndSourceOptionsProject.AllowNew=false;
            bndSourceOptionsProject.DataMember="spGetOpenProjects";
            bndSourceOptionsProject.DataSource=HCHDataQAProjectList;
            // 
            // ucProjectsCosts
            // 
            ucProjectsCosts.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucProjectsCosts.CalcManager=UltraCalcManager1;
            ucProjectsCosts.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "CostProject", true));
            ucProjectsCosts.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "CostProjectID", true));
            ucProjectsCosts.DataSource=bndSourceCostProject;
            Appearance61.BackColor=SystemColors.Window;
            Appearance61.BorderColor=SystemColors.InactiveCaption;
            ucProjectsCosts.DisplayLayout.Appearance=Appearance61;
            UltraGridColumn24.Header.VisiblePosition=0;
            UltraGridColumn25.Header.VisiblePosition=1;
            UltraGridColumn26.Header.VisiblePosition=2;
            UltraGridColumn26.Hidden=true;
            UltraGridColumn27.Header.VisiblePosition=3;
            UltraGridColumn27.Hidden=true;
            UltraGridColumn28.Header.VisiblePosition=4;
            UltraGridColumn28.Hidden=true;
            UltraGridColumn29.Header.VisiblePosition=5;
            UltraGridBand6.Columns.AddRange(new object[] { UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29 });
            ucProjectsCosts.DisplayLayout.BandsSerializer.Add(UltraGridBand6);
            ucProjectsCosts.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucProjectsCosts.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance62.BackColor=SystemColors.ActiveBorder;
            Appearance62.BackColor2=SystemColors.ControlDark;
            Appearance62.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance62.BorderColor=SystemColors.Window;
            ucProjectsCosts.DisplayLayout.GroupByBox.Appearance=Appearance62;
            Appearance63.ForeColor=SystemColors.GrayText;
            ucProjectsCosts.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance63;
            ucProjectsCosts.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance64.BackColor=SystemColors.ControlLightLight;
            Appearance64.BackColor2=SystemColors.Control;
            Appearance64.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance64.ForeColor=SystemColors.GrayText;
            ucProjectsCosts.DisplayLayout.GroupByBox.PromptAppearance=Appearance64;
            ucProjectsCosts.DisplayLayout.MaxColScrollRegions=1;
            ucProjectsCosts.DisplayLayout.MaxRowScrollRegions=1;
            Appearance65.BackColor=SystemColors.Window;
            Appearance65.ForeColor=SystemColors.ControlText;
            ucProjectsCosts.DisplayLayout.Override.ActiveCellAppearance=Appearance65;
            Appearance66.BackColor=SystemColors.Highlight;
            Appearance66.ForeColor=SystemColors.HighlightText;
            ucProjectsCosts.DisplayLayout.Override.ActiveRowAppearance=Appearance66;
            ucProjectsCosts.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucProjectsCosts.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance67.BackColor=SystemColors.Window;
            ucProjectsCosts.DisplayLayout.Override.CardAreaAppearance=Appearance67;
            Appearance68.BorderColor=Color.Silver;
            Appearance68.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucProjectsCosts.DisplayLayout.Override.CellAppearance=Appearance68;
            ucProjectsCosts.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucProjectsCosts.DisplayLayout.Override.CellPadding=0;
            Appearance69.BackColor=SystemColors.Control;
            Appearance69.BackColor2=SystemColors.ControlDark;
            Appearance69.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance69.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance69.BorderColor=SystemColors.Window;
            ucProjectsCosts.DisplayLayout.Override.GroupByRowAppearance=Appearance69;
            Appearance70.TextHAlignAsString="Left";
            ucProjectsCosts.DisplayLayout.Override.HeaderAppearance=Appearance70;
            ucProjectsCosts.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucProjectsCosts.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance71.BackColor=SystemColors.Window;
            Appearance71.BorderColor=Color.Silver;
            ucProjectsCosts.DisplayLayout.Override.RowAppearance=Appearance71;
            ucProjectsCosts.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance72.BackColor=SystemColors.ControlLight;
            ucProjectsCosts.DisplayLayout.Override.TemplateAddRowAppearance=Appearance72;
            ucProjectsCosts.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucProjectsCosts.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucProjectsCosts.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucProjectsCosts.DisplayMember="ProjectID";
            ucProjectsCosts.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucProjectsCosts.Location=new Point(773, 26);
            ucProjectsCosts.Margin=new Padding(5, 7, 5, 7);
            ucProjectsCosts.Name="ucProjectsCosts";
            ucProjectsCosts.NullText="(Choose)";
            ucProjectsCosts.Size=new Size(240, 42);
            ucProjectsCosts.TabIndex=10;
            ucProjectsCosts.ValueMember="ID";
            // 
            // bndSourceCostProject
            // 
            bndSourceCostProject.AllowNew=false;
            bndSourceCostProject.DataMember="spGetOpenProjects";
            bndSourceCostProject.DataSource=HCHDataQAProjectList;
            // 
            // gpBoxStandardAnalysis
            // 
            gpBoxStandardAnalysis.Controls.Add(ucProjectStandard);
            gpBoxStandardAnalysis.Controls.Add(chkUseInfoFromStandardProject);
            gpBoxStandardAnalysis.Location=new Point(1344, 69);
            gpBoxStandardAnalysis.Margin=new Padding(5, 7, 5, 7);
            gpBoxStandardAnalysis.Name="gpBoxStandardAnalysis";
            gpBoxStandardAnalysis.Padding=new Padding(5, 7, 5, 7);
            gpBoxStandardAnalysis.Size=new Size(1053, 105);
            gpBoxStandardAnalysis.TabIndex=32;
            gpBoxStandardAnalysis.TabStop=false;
            gpBoxStandardAnalysis.Text="Standard Analysis";
            // 
            // ucProjectStandard
            // 
            ucProjectStandard.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucProjectStandard.CalcManager=UltraCalcManager1;
            ucProjectStandard.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "CopyProjectID", true));
            ucProjectStandard.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "CopyProject", true));
            ucProjectStandard.DataSource=SpGetOpenProjectsBindingSource;
            Appearance73.BackColor=SystemColors.Window;
            Appearance73.BorderColor=SystemColors.InactiveCaption;
            ucProjectStandard.DisplayLayout.Appearance=Appearance73;
            UltraGridColumn30.Header.VisiblePosition=0;
            UltraGridColumn31.Header.VisiblePosition=1;
            UltraGridColumn32.Header.VisiblePosition=2;
            UltraGridColumn32.Hidden=true;
            UltraGridColumn33.Header.VisiblePosition=3;
            UltraGridColumn33.Hidden=true;
            UltraGridColumn34.Header.VisiblePosition=4;
            UltraGridColumn34.Hidden=true;
            UltraGridColumn35.Header.VisiblePosition=5;
            UltraGridBand7.Columns.AddRange(new object[] { UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35 });
            ucProjectStandard.DisplayLayout.BandsSerializer.Add(UltraGridBand7);
            ucProjectStandard.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucProjectStandard.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance74.BackColor=SystemColors.ActiveBorder;
            Appearance74.BackColor2=SystemColors.ControlDark;
            Appearance74.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance74.BorderColor=SystemColors.Window;
            ucProjectStandard.DisplayLayout.GroupByBox.Appearance=Appearance74;
            Appearance75.ForeColor=SystemColors.GrayText;
            ucProjectStandard.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance75;
            ucProjectStandard.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance76.BackColor=SystemColors.ControlLightLight;
            Appearance76.BackColor2=SystemColors.Control;
            Appearance76.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance76.ForeColor=SystemColors.GrayText;
            ucProjectStandard.DisplayLayout.GroupByBox.PromptAppearance=Appearance76;
            ucProjectStandard.DisplayLayout.MaxColScrollRegions=1;
            ucProjectStandard.DisplayLayout.MaxRowScrollRegions=1;
            Appearance77.BackColor=SystemColors.Window;
            Appearance77.ForeColor=SystemColors.ControlText;
            ucProjectStandard.DisplayLayout.Override.ActiveCellAppearance=Appearance77;
            Appearance78.BackColor=SystemColors.Highlight;
            Appearance78.ForeColor=SystemColors.HighlightText;
            ucProjectStandard.DisplayLayout.Override.ActiveRowAppearance=Appearance78;
            ucProjectStandard.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucProjectStandard.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance79.BackColor=SystemColors.Window;
            ucProjectStandard.DisplayLayout.Override.CardAreaAppearance=Appearance79;
            Appearance80.BorderColor=Color.Silver;
            Appearance80.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucProjectStandard.DisplayLayout.Override.CellAppearance=Appearance80;
            ucProjectStandard.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucProjectStandard.DisplayLayout.Override.CellPadding=0;
            Appearance81.BackColor=SystemColors.Control;
            Appearance81.BackColor2=SystemColors.ControlDark;
            Appearance81.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance81.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance81.BorderColor=SystemColors.Window;
            ucProjectStandard.DisplayLayout.Override.GroupByRowAppearance=Appearance81;
            Appearance82.TextHAlignAsString="Left";
            ucProjectStandard.DisplayLayout.Override.HeaderAppearance=Appearance82;
            ucProjectStandard.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucProjectStandard.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance83.BackColor=SystemColors.Window;
            Appearance83.BorderColor=Color.Silver;
            ucProjectStandard.DisplayLayout.Override.RowAppearance=Appearance83;
            ucProjectStandard.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance84.BackColor=SystemColors.ControlLight;
            ucProjectStandard.DisplayLayout.Override.TemplateAddRowAppearance=Appearance84;
            ucProjectStandard.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucProjectStandard.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucProjectStandard.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucProjectStandard.DisplayMember="ProjectID";
            ucProjectStandard.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucProjectStandard.Location=new Point(773, 45);
            ucProjectStandard.Margin=new Padding(5, 7, 5, 7);
            ucProjectStandard.Name="ucProjectStandard";
            ucProjectStandard.NullText="(Choose)";
            ucProjectStandard.Size=new Size(240, 42);
            ucProjectStandard.TabIndex=9;
            ucProjectStandard.ValueMember="ID";
            // 
            // SpGetOpenProjectsBindingSource
            // 
            SpGetOpenProjectsBindingSource.AllowNew=false;
            SpGetOpenProjectsBindingSource.DataMember="spGetOpenProjects";
            SpGetOpenProjectsBindingSource.DataSource=HCHDataQAProjectList;
            // 
            // chkUseInfoFromStandardProject
            // 
            chkUseInfoFromStandardProject.AutoSize=true;
            chkUseInfoFromStandardProject.Checked=true;
            chkUseInfoFromStandardProject.CheckState=CheckState.Checked;
            chkUseInfoFromStandardProject.DataBindings.Add(new Binding("CheckState", spGetAnalysesHeaderBindingSource, "DoNotUse", true));
            chkUseInfoFromStandardProject.Location=new Point(176, 55);
            chkUseInfoFromStandardProject.Margin=new Padding(5, 7, 5, 7);
            chkUseInfoFromStandardProject.Name="chkUseInfoFromStandardProject";
            chkUseInfoFromStandardProject.Size=new Size(566, 36);
            chkUseInfoFromStandardProject.TabIndex=8;
            chkUseInfoFromStandardProject.Text="Use All Information from Existing Project:";
            chkUseInfoFromStandardProject.UseVisualStyleBackColor=true;
            // 
            // Label6
            // 
            Label6.AutoSize=true;
            Label6.ForeColor=SystemColors.HotTrack;
            Label6.Location=new Point(1339, 21);
            Label6.Margin=new Padding(5, 0, 5, 0);
            Label6.Name="Label6";
            Label6.Size=new Size(190, 32);
            Label6.TabIndex=20;
            Label6.Text="Created Date:";
            Label6.TextAlign=ContentAlignment.TopRight;
            // 
            // chkDoNotUse
            // 
            chkDoNotUse.AutoSize=true;
            chkDoNotUse.DataBindings.Add(new Binding("CheckState", spGetAnalysesHeaderBindingSource, "DoNotUse", true));
            chkDoNotUse.Location=new Point(925, 19);
            chkDoNotUse.Margin=new Padding(5, 7, 5, 7);
            chkDoNotUse.Name="chkDoNotUse";
            chkDoNotUse.Size=new Size(328, 36);
            chkDoNotUse.TabIndex=31;
            chkDoNotUse.Text="Trial - Can be Deleted";
            chkDoNotUse.UseVisualStyleBackColor=true;
            // 
            // Label10
            // 
            Label10.AutoSize=true;
            Label10.Location=new Point(763, 193);
            Label10.Margin=new Padding(5, 0, 5, 0);
            Label10.Name="Label10";
            Label10.Size=new Size(231, 32);
            Label10.TabIndex=28;
            Label10.Text="Project Premium:";
            Label10.TextAlign=ContentAlignment.TopRight;
            // 
            // Label9
            // 
            Label9.AutoSize=true;
            Label9.Location=new Point(403, 193);
            Label9.Margin=new Padding(5, 0, 5, 0);
            Label9.Name="Label9";
            Label9.Size=new Size(152, 32);
            Label9.TabIndex=26;
            Label9.Text="Soft Costs:";
            Label9.TextAlign=ContentAlignment.TopRight;
            // 
            // Label7
            // 
            Label7.AutoSize=true;
            Label7.Location=new Point(152, 193);
            Label7.Margin=new Padding(5, 0, 5, 0);
            Label7.Name="Label7";
            Label7.Size=new Size(109, 32);
            Label7.TabIndex=24;
            Label7.Text="Margin:";
            Label7.TextAlign=ContentAlignment.TopRight;
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize=true;
            lblCreatedBy.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "CreatedBy", true, DataSourceUpdateMode.OnValidation, null, "g"));
            lblCreatedBy.ForeColor=SystemColors.HotTrack;
            lblCreatedBy.Location=new Point(1907, 21);
            lblCreatedBy.Margin=new Padding(5, 0, 5, 0);
            lblCreatedBy.Name="lblCreatedBy";
            lblCreatedBy.Size=new Size(148, 32);
            lblCreatedBy.TabIndex=23;
            lblCreatedBy.Text="CreatedBy";
            // 
            // Label8
            // 
            Label8.AutoSize=true;
            Label8.ForeColor=SystemColors.HotTrack;
            Label8.Location=new Point(1736, 21);
            Label8.Margin=new Padding(5, 0, 5, 0);
            Label8.Name="Label8";
            Label8.Size=new Size(163, 32);
            Label8.TabIndex=22;
            Label8.Text="Created By:";
            Label8.TextAlign=ContentAlignment.TopRight;
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize=true;
            lblCreatedDate.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "AnalysisDate", true));
            lblCreatedDate.ForeColor=SystemColors.HotTrack;
            lblCreatedDate.Location=new Point(1536, 21);
            lblCreatedDate.Margin=new Padding(5, 0, 5, 0);
            lblCreatedDate.Name="lblCreatedDate";
            lblCreatedDate.Size=new Size(175, 32);
            lblCreatedDate.TabIndex=21;
            lblCreatedDate.Text="CreatedDate";
            // 
            // uteNotes
            // 
            uteNotes.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "Period", true));
            uteNotes.DataBindings.Add(new Binding("Text", spGetAnalysesHeaderBindingSource, "Notes", true));
            uteNotes.Location=new Point(288, 250);
            uteNotes.Margin=new Padding(5, 7, 5, 7);
            uteNotes.MaxLength=500;
            uteNotes.Multiline=true;
            uteNotes.Name="uteNotes";
            uteNotes.Scrollbars=ScrollBars.Vertical;
            uteNotes.Size=new Size(963, 93);
            uteNotes.TabIndex=8;
            // 
            // Label5
            // 
            Label5.AutoSize=true;
            Label5.Location=new Point(165, 258);
            Label5.Margin=new Padding(5, 0, 5, 0);
            Label5.Name="Label5";
            Label5.Size=new Size(96, 32);
            Label5.TabIndex=18;
            Label5.Text="Notes:";
            Label5.TextAlign=ContentAlignment.TopRight;
            // 
            // Label4
            // 
            Label4.AutoSize=true;
            Label4.Location=new Point(421, 134);
            Label4.Margin=new Padding(5, 0, 5, 0);
            Label4.Name="Label4";
            Label4.Size=new Size(193, 32);
            Label4.TabIndex=17;
            Label4.Text="Project Name:";
            Label4.TextAlign=ContentAlignment.TopRight;
            // 
            // uteProjectName
            // 
            uteProjectName.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "ProjectName", true));
            uteProjectName.Location=new Point(629, 126);
            uteProjectName.Margin=new Padding(5, 7, 5, 7);
            uteProjectName.MaxLength=50;
            uteProjectName.Name="uteProjectName";
            uteProjectName.Size=new Size(624, 41);
            uteProjectName.TabIndex=4;
            // 
            // uteProjectID
            // 
            uteProjectID.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "ProjectID", true));
            uteProjectID.Location=new Point(288, 126);
            uteProjectID.Margin=new Padding(5, 7, 5, 7);
            uteProjectID.MaxLength=5;
            uteProjectID.Name="uteProjectID";
            uteProjectID.Size=new Size(120, 41);
            uteProjectID.TabIndex=3;
            // 
            // Label3
            // 
            Label3.AutoSize=true;
            Label3.Location=new Point(8, 134);
            Label3.Margin=new Padding(5, 0, 5, 0);
            Label3.Name="Label3";
            Label3.Size=new Size(259, 32);
            Label3.TabIndex=14;
            Label3.Text="Analysis Project ID:";
            Label3.TextAlign=ContentAlignment.TopRight;
            // 
            // ckPlansSelected
            // 
            ckPlansSelected.AutoSize=true;
            ckPlansSelected.Enabled=false;
            ckPlansSelected.Location=new Point(2411, 38);
            ckPlansSelected.Margin=new Padding(5, 7, 5, 7);
            ckPlansSelected.Name="ckPlansSelected";
            ckPlansSelected.Size=new Size(243, 36);
            ckPlansSelected.TabIndex=13;
            ckPlansSelected.Text="Plans Selected";
            ckPlansSelected.UseVisualStyleBackColor=true;
            // 
            // btnSelectPlans
            // 
            btnSelectPlans.Location=new Point(2411, 112);
            btnSelectPlans.Margin=new Padding(5, 7, 5, 7);
            btnSelectPlans.Name="btnSelectPlans";
            btnSelectPlans.Size=new Size(371, 50);
            btnSelectPlans.TabIndex=7;
            btnSelectPlans.Text="Select Plans";
            btnSelectPlans.UseVisualStyleBackColor=true;
            // 
            // utePeriod
            // 
            utePeriod.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "Period", true));
            utePeriod.Location=new Point(288, 69);
            utePeriod.Margin=new Padding(5, 7, 5, 7);
            utePeriod.MaxLength=50;
            utePeriod.Name="utePeriod";
            utePeriod.Size=new Size(624, 41);
            utePeriod.TabIndex=2;
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Location=new Point(160, 76);
            Label2.Margin=new Padding(5, 0, 5, 0);
            Label2.Name="Label2";
            Label2.Size=new Size(105, 32);
            Label2.TabIndex=10;
            Label2.Text="Period:";
            Label2.TextAlign=ContentAlignment.TopRight;
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Location=new Point(56, 12);
            Label1.Margin=new Padding(5, 0, 5, 0);
            Label1.Name="Label1";
            Label1.Size=new Size(211, 32);
            Label1.TabIndex=9;
            Label1.Text="Analysis Name:";
            Label1.TextAlign=ContentAlignment.TopRight;
            // 
            // uteAnalysisName
            // 
            uteAnalysisName.DataBindings.Add(new Binding("Value", spGetAnalysesHeaderBindingSource, "VersionName", true));
            uteAnalysisName.Location=new Point(288, 12);
            uteAnalysisName.Margin=new Padding(5, 7, 5, 7);
            uteAnalysisName.MaxLength=50;
            uteAnalysisName.Name="uteAnalysisName";
            uteAnalysisName.Size=new Size(624, 41);
            uteAnalysisName.TabIndex=1;
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnDelete, tsBtnSave, tsBtnPrint, tsBtnPrintRpt2, tsButtonHelp, ToolStripSeparator1, tsBtnReloadData, ToolStripSeparator2, tsLblLastReloadDate, tsBtnRecalculateGrid });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Padding=new Padding(0, 0, 5, 0);
            tsToolStrip.Size=new Size(2872, 52);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=9;
            tsToolStrip.Text="ToolStrip1";
            // 
            // tsBtnAdd
            // 
            tsBtnAdd.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnAdd.Enabled=false;
            tsBtnAdd.Image=(Image)resources.GetObject("tsBtnAdd.Image");
            tsBtnAdd.ImageTransparentColor=Color.Magenta;
            tsBtnAdd.Name="tsBtnAdd";
            tsBtnAdd.Size=new Size(58, 45);
            tsBtnAdd.Text="Add New";
            tsBtnAdd.ToolTipText="Click to Add New Record";
            // 
            // tsBtnEdit
            // 
            tsBtnEdit.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnEdit.Image=(Image)resources.GetObject("tsBtnEdit.Image");
            tsBtnEdit.ImageTransparentColor=Color.Magenta;
            tsBtnEdit.Name="tsBtnEdit";
            tsBtnEdit.Size=new Size(58, 45);
            tsBtnEdit.Text="Edit";
            tsBtnEdit.ToolTipText="Click to Edit Records";
            // 
            // tsBtnUndo
            // 
            tsBtnUndo.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnUndo.Enabled=false;
            tsBtnUndo.Image=(Image)resources.GetObject("tsBtnUndo.Image");
            tsBtnUndo.ImageTransparentColor=Color.Magenta;
            tsBtnUndo.Name="tsBtnUndo";
            tsBtnUndo.Size=new Size(58, 45);
            tsBtnUndo.Text="Cancel Changes";
            tsBtnUndo.ToolTipText="Click to Cancel Changes";
            // 
            // tsBtnDelete
            // 
            tsBtnDelete.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnDelete.Enabled=false;
            tsBtnDelete.Image=(Image)resources.GetObject("tsBtnDelete.Image");
            tsBtnDelete.ImageTransparentColor=Color.Magenta;
            tsBtnDelete.Name="tsBtnDelete";
            tsBtnDelete.Size=new Size(58, 45);
            tsBtnDelete.Text="Delete";
            // 
            // tsBtnSave
            // 
            tsBtnSave.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnSave.Enabled=false;
            tsBtnSave.Image=(Image)resources.GetObject("tsBtnSave.Image");
            tsBtnSave.ImageTransparentColor=Color.Magenta;
            tsBtnSave.Name="tsBtnSave";
            tsBtnSave.Size=new Size(58, 45);
            tsBtnSave.Text="Save";
            tsBtnSave.ToolTipText="Click to Save Changes";
            // 
            // tsBtnPrint
            // 
            tsBtnPrint.Image=(Image)resources.GetObject("tsBtnPrint.Image");
            tsBtnPrint.ImageTransparentColor=Color.Magenta;
            tsBtnPrint.Name="tsBtnPrint";
            tsBtnPrint.Size=new Size(349, 45);
            tsBtnPrint.Text="Print Report for Review";
            tsBtnPrint.ToolTipText="Click to Print Report";
            // 
            // tsBtnPrintRpt2
            // 
            tsBtnPrintRpt2.Image=(Image)resources.GetObject("tsBtnPrintRpt2.Image");
            tsBtnPrintRpt2.ImageTransparentColor=Color.Magenta;
            tsBtnPrintRpt2.Name="tsBtnPrintRpt2";
            tsBtnPrintRpt2.Size=new Size(324, 45);
            tsBtnPrintRpt2.Text="Print Report for Sales";
            // 
            // tsButtonHelp
            // 
            tsButtonHelp.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsButtonHelp.Image=(Image)resources.GetObject("tsButtonHelp.Image");
            tsButtonHelp.ImageTransparentColor=Color.Magenta;
            tsButtonHelp.Name="tsButtonHelp";
            tsButtonHelp.Size=new Size(58, 45);
            tsButtonHelp.Text="He&lp";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name="ToolStripSeparator1";
            ToolStripSeparator1.Size=new Size(6, 52);
            // 
            // tsBtnReloadData
            // 
            tsBtnReloadData.DisplayStyle=ToolStripItemDisplayStyle.Text;
            tsBtnReloadData.Font=new Font("Segoe UI", 9.0f, FontStyle.Bold);
            tsBtnReloadData.ForeColor=SystemColors.Highlight;
            tsBtnReloadData.Image=(Image)resources.GetObject("tsBtnReloadData.Image");
            tsBtnReloadData.ImageTransparentColor=Color.Magenta;
            tsBtnReloadData.Name="tsBtnReloadData";
            tsBtnReloadData.Size=new Size(224, 45);
            tsBtnReloadData.Text="RELOAD DATA";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name="ToolStripSeparator2";
            ToolStripSeparator2.Size=new Size(6, 52);
            // 
            // tsLblLastReloadDate
            // 
            tsLblLastReloadDate.Name="tsLblLastReloadDate";
            tsLblLastReloadDate.Size=new Size(279, 45);
            tsLblLastReloadDate.Text="Data Last Reloaded:";
            // 
            // tsBtnRecalculateGrid
            // 
            tsBtnRecalculateGrid.Image=(Image)resources.GetObject("tsBtnRecalculateGrid.Image");
            tsBtnRecalculateGrid.ImageTransparentColor=Color.Magenta;
            tsBtnRecalculateGrid.Name="tsBtnRecalculateGrid";
            tsBtnRecalculateGrid.Size=new Size(258, 45);
            tsBtnRecalculateGrid.Text="Recalculate Grid";
            // 
            // UltraStatusBar1
            // 
            UltraStatusBar1.Location=new Point(0, 799);
            UltraStatusBar1.Margin=new Padding(5, 7, 5, 7);
            UltraStatusBar1.Name="UltraStatusBar1";
            UltraStatusPanel1.Key="JobBeingProcessed";
            UltraStatusPanel1.Text="Job Being Processed";
            UltraStatusPanel1.Width=300;
            UltraStatusPanel2.Key="CurrentProcess";
            UltraStatusPanel2.Width=500;
            UltraStatusBar1.Panels.AddRange(new Infragistics.Win.UltraWinStatusBar.UltraStatusPanel[] { UltraStatusPanel1, UltraStatusPanel2 });
            UltraStatusBar1.Size=new Size(2872, 45);
            UltraStatusBar1.TabIndex=10;
            UltraStatusBar1.Text="UltraStatusBar1";
            UltraStatusBar1.WrapText=false;
            // 
            // UltraDesktopAlert1
            // 
            Appearance85.Image=resources.GetObject("Appearance85.Image");
            UltraDesktopAlertButton1.Appearance=Appearance85;
            UltraDesktopAlertButton1.Key="Print";
            UltraDesktopAlertButton1.ToolTipText="Print Progress Log";
            UltraDesktopAlert1.AlertButtons.AddRange(new Infragistics.Win.Misc.UltraDesktopAlertButton[] { UltraDesktopAlertButton1 });
            UltraDesktopAlert1.TreatTextAsLink=Infragistics.Win.DefaultableBoolean.False;
            // 
            // ugDetails
            // 
            ugDetails.CalcManager=UltraCalcManager1;
            ugDetails.DataMember="spGetAnalysis";
            ugDetails.DataSource=HCHDataAnalysisDetail;
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            ugDetails.DisplayLayout.Appearance=Appearance1;
            UltraGridColumn72.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn72.Header.VisiblePosition=0;
            UltraGridColumn72.Hidden=true;
            UltraGridColumn73.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn73.Header.VisiblePosition=31;
            UltraGridColumn74.Format="0.00";
            UltraGridColumn74.Header.Caption="New Margin";
            UltraGridColumn74.Header.VisiblePosition=16;
            UltraGridColumn74.Width=65;
            UltraGridColumn75.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn75.Header.VisiblePosition=1;
            UltraGridColumn75.Hidden=true;
            UltraGridColumn76.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn76.Header.VisiblePosition=2;
            UltraGridColumn76.Hidden=true;
            UltraGridColumn77.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn77.Format="MM/dd/yy";
            UltraGridColumn77.Header.Caption="Costed Date";
            UltraGridColumn77.Header.VisiblePosition=30;
            UltraGridColumn77.Width=67;
            UltraGridColumn78.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn78.Header.VisiblePosition=3;
            UltraGridColumn78.Width=61;
            UltraGridColumn79.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn79.Header.VisiblePosition=11;
            UltraGridColumn79.Hidden=true;
            UltraGridColumn80.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn80.Header.VisiblePosition=6;
            UltraGridColumn80.Hidden=true;
            UltraGridColumn81.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn81.Format="0.000";
            UltraGridColumn81.Header.Caption="Hard Cost";
            UltraGridColumn81.Header.VisiblePosition=7;
            UltraGridColumn81.Hidden=true;
            UltraGridColumn81.Width=71;
            UltraGridColumn82.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn82.Format="0";
            UltraGridColumn82.Header.Caption="Current Price";
            UltraGridColumn82.Header.VisiblePosition=10;
            UltraGridColumn82.Width=70;
            UltraGridColumn83.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn83.Format="0";
            UltraGridColumn83.Header.Caption="Lot Costs";
            UltraGridColumn83.Header.VisiblePosition=14;
            UltraGridColumn83.Hidden=true;
            UltraGridColumn84.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn84.Format="0";
            UltraGridColumn84.Header.Caption="Price Without Lot";
            UltraGridColumn84.Header.VisiblePosition=12;
            UltraGridColumn84.Width=78;
            UltraGridColumn85.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn85.Header.Caption="Sq Ft";
            UltraGridColumn85.Header.VisiblePosition=4;
            UltraGridColumn86.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn86.Header.Caption="Price / Sq Ft";
            UltraGridColumn86.Header.VisiblePosition=15;
            UltraGridColumn86.Width=60;
            UltraGridColumn87.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn87.Format="0";
            UltraGridColumn87.Header.Caption="Soft Costs";
            UltraGridColumn87.Header.VisiblePosition=5;
            UltraGridColumn87.Width=63;
            UltraGridColumn88.Header.Caption="Updated Price";
            UltraGridColumn88.Header.VisiblePosition=20;
            UltraGridColumn88.Width=91;
            UltraGridColumn89.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn89.Header.VisiblePosition=21;
            UltraGridColumn89.Hidden=true;
            UltraGridColumn90.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn90.Header.Caption="Hard Cost /SqFt";
            UltraGridColumn90.Header.VisiblePosition=9;
            UltraGridColumn90.Width=51;
            UltraGridColumn91.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn91.Header.VisiblePosition=22;
            UltraGridColumn91.Hidden=true;
            UltraGridColumn92.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn92.Header.VisiblePosition=23;
            UltraGridColumn92.Hidden=true;
            UltraGridColumn93.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn93.Header.VisiblePosition=24;
            UltraGridColumn93.Hidden=true;
            UltraGridColumn94.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn94.Header.VisiblePosition=25;
            UltraGridColumn94.Hidden=true;
            UltraGridColumn95.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn95.Header.VisiblePosition=26;
            UltraGridColumn95.Hidden=true;
            UltraGridColumn96.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn96.Header.VisiblePosition=27;
            UltraGridColumn96.Hidden=true;
            UltraGridColumn97.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn97.Format="0";
            UltraGridColumn97.Header.Caption="Hard Cost";
            UltraGridColumn97.Header.VisiblePosition=8;
            UltraGridColumn98.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn98.Format="0.00";
            UltraGridColumn98.Header.Caption="Current Margin";
            UltraGridColumn98.Header.VisiblePosition=13;
            UltraGridColumn98.Width=67;
            UltraGridColumn99.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn99.Format="0";
            UltraGridColumn99.Header.Caption="New Sales Price";
            UltraGridColumn99.Header.VisiblePosition=18;
            UltraGridColumn99.Width=97;
            UltraGridColumn100.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn100.Format="0";
            UltraGridColumn100.Header.Caption="New Sales Price With Lot";
            UltraGridColumn100.Header.VisiblePosition=17;
            UltraGridColumn100.Width=101;
            UltraGridColumn101.Format="0";
            UltraGridColumn101.Header.Caption="Analysis Price";
            UltraGridColumn101.Header.VisiblePosition=28;
            UltraGridColumn101.Hidden=true;
            UltraGridColumn101.Width=68;
            UltraGridColumn102.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn102.Header.VisiblePosition=29;
            UltraGridColumn102.Hidden=true;
            UltraGridColumn103.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn103.Header.VisiblePosition=32;
            UltraGridColumn103.Hidden=true;
            UltraGridColumn104.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn104.Header.VisiblePosition=33;
            UltraGridColumn104.Hidden=true;
            UltraGridColumn105.Header.VisiblePosition=34;
            UltraGridColumn105.Hidden=true;
            UltraGridColumn105.Width=345;
            UltraGridColumn141.Header.VisiblePosition=35;
            UltraGridColumn141.Width=343;
            UltraGridColumn142.Formula="[NewSalesPrc] - [PlanPrice]";
            UltraGridColumn142.Header.VisiblePosition=19;
            UltraGridColumn142.Width=78;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn72, UltraGridColumn73, UltraGridColumn74, UltraGridColumn75, UltraGridColumn76, UltraGridColumn77, UltraGridColumn78, UltraGridColumn79, UltraGridColumn80, UltraGridColumn81, UltraGridColumn82, UltraGridColumn83, UltraGridColumn84, UltraGridColumn85, UltraGridColumn86, UltraGridColumn87, UltraGridColumn88, UltraGridColumn89, UltraGridColumn90, UltraGridColumn91, UltraGridColumn92, UltraGridColumn93, UltraGridColumn94, UltraGridColumn95, UltraGridColumn96, UltraGridColumn97, UltraGridColumn98, UltraGridColumn99, UltraGridColumn100, UltraGridColumn101, UltraGridColumn102, UltraGridColumn103, UltraGridColumn104, UltraGridColumn105, UltraGridColumn141, UltraGridColumn142 });
            UltraGridBand1.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            ugDetails.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            ugDetails.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ugDetails.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            ugDetails.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            ugDetails.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            ugDetails.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            ugDetails.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            ugDetails.DisplayLayout.MaxColScrollRegions=1;
            ugDetails.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            ugDetails.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            ugDetails.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            ugDetails.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ugDetails.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            ugDetails.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            ugDetails.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ugDetails.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            ugDetails.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ugDetails.DisplayLayout.Override.CellAppearance=Appearance8;
            ugDetails.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ugDetails.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            ugDetails.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            ugDetails.DisplayLayout.Override.HeaderAppearance=Appearance10;
            ugDetails.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ugDetails.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            ugDetails.DisplayLayout.Override.RowAppearance=Appearance11;
            ugDetails.DisplayLayout.Override.RowSelectorHeaderStyle=Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle.ColumnChooserButton;
            ugDetails.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance12.BackColor=SystemColors.ControlLight;
            ugDetails.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            ugDetails.DisplayLayout.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.True;
            ugDetails.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ugDetails.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ugDetails.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ugDetails.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ugDetails.Location=new Point(24, 646);
            ugDetails.Margin=new Padding(5, 7, 5, 7);
            ugDetails.Name="ugDetails";
            ugDetails.Size=new Size(3139, 1219);
            ugDetails.TabIndex=3;
            ugDetails.Text="UltraGrid1";
            // 
            // HCHDataAnalysisDetail
            // 
            HCHDataAnalysisDetail.DataSetName="HCHDataAnalysisDetail";
            HCHDataAnalysisDetail.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // SpGetTaxDistrictListTableAdapter
            // 
            SpGetTaxDistrictListTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetAlphaCodesTableAdapter
            // 
            SpGetAlphaCodesTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetOpenProjectsTableAdapter
            // 
            SpGetOpenProjectsTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetAnalysesHeaderTableAdapter
            // 
            SpGetAnalysesHeaderTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetAnalysisBindingSource
            // 
            SpGetAnalysisBindingSource.AllowNew=false;
            SpGetAnalysisBindingSource.DataMember="spGetAnalysis";
            SpGetAnalysisBindingSource.DataSource=HCHDataAnalysisDetail;
            // 
            // SpGetAnalysisTableAdapter
            // 
            SpGetAnalysisTableAdapter.ClearBeforeFill=true;
            // 
            // UltraToolbarsManager1
            // 
            UltraToolbarsManager1.DesignerFlags=1;
            UltraToolbarsManager1.DockWithinContainer=this;
            UltraToolbarsManager1.DockWithinContainerBaseType=typeof(Form);
            // 
            // _CostAnalysisDetail_Toolbars_Dock_Area_Left
            // 
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.AccessibleRole=AccessibleRole.Grouping;
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.BackColor=SystemColors.Control;
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.ForeColor=SystemColors.ControlText;
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.Location=new Point(0, 52);
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.Margin=new Padding(5, 7, 5, 7);
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.Name="_CostAnalysisDetail_Toolbars_Dock_Area_Left";
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.Size=new Size(0, 747);
            _CostAnalysisDetail_Toolbars_Dock_Area_Left.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _CostAnalysisDetail_Toolbars_Dock_Area_Right
            // 
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.AccessibleRole=AccessibleRole.Grouping;
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.BackColor=SystemColors.Control;
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.ForeColor=SystemColors.ControlText;
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.Location=new Point(2872, 52);
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.Margin=new Padding(5, 7, 5, 7);
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.Name="_CostAnalysisDetail_Toolbars_Dock_Area_Right";
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.Size=new Size(0, 747);
            _CostAnalysisDetail_Toolbars_Dock_Area_Right.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _CostAnalysisDetail_Toolbars_Dock_Area_Top
            // 
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.AccessibleRole=AccessibleRole.Grouping;
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.BackColor=SystemColors.Control;
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.ForeColor=SystemColors.ControlText;
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.Location=new Point(0, 0);
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.Margin=new Padding(5, 7, 5, 7);
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.Name="_CostAnalysisDetail_Toolbars_Dock_Area_Top";
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.Size=new Size(2872, 0);
            _CostAnalysisDetail_Toolbars_Dock_Area_Top.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _CostAnalysisDetail_Toolbars_Dock_Area_Bottom
            // 
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.AccessibleRole=AccessibleRole.Grouping;
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.BackColor=SystemColors.Control;
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.ForeColor=SystemColors.ControlText;
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Location=new Point(0, 799);
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Margin=new Padding(5, 7, 5, 7);
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Name="_CostAnalysisDetail_Toolbars_Dock_Area_Bottom";
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.Size=new Size(2872, 0);
            _CostAnalysisDetail_Toolbars_Dock_Area_Bottom.ToolbarsManager=UltraToolbarsManager1;
            // 
            // ContextMenuStrip1
            // 
            ContextMenuStrip1.ImageScalingSize=new Size(20, 20);
            ContextMenuStrip1.Items.AddRange(new ToolStripItem[] { tsViewEstimate, tsEstimateCostedRpt, tsSummaryBudgetRpt });
            ContextMenuStrip1.Name="ContextMenuStrip1";
            ContextMenuStrip1.Size=new Size(423, 148);
            // 
            // tsViewEstimate
            // 
            tsViewEstimate.Name="tsViewEstimate";
            tsViewEstimate.Size=new Size(422, 48);
            tsViewEstimate.Text="View Estimate";
            // 
            // tsEstimateCostedRpt
            // 
            tsEstimateCostedRpt.Name="tsEstimateCostedRpt";
            tsEstimateCostedRpt.Size=new Size(422, 48);
            tsEstimateCostedRpt.Text="Estimate Costed Report";
            // 
            // tsSummaryBudgetRpt
            // 
            tsSummaryBudgetRpt.Name="tsSummaryBudgetRpt";
            tsSummaryBudgetRpt.Size=new Size(422, 48);
            tsSummaryBudgetRpt.Text="Summary Budget Report";
            // 
            // CostAnalysisDetail
            // 
            AutoScaleDimensions=new SizeF(16.0f, 31.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(2872, 844);
            Controls.Add(pnlFields);
            Controls.Add(ugDetails);
            Controls.Add(_CostAnalysisDetail_Toolbars_Dock_Area_Left);
            Controls.Add(_CostAnalysisDetail_Toolbars_Dock_Area_Right);
            Controls.Add(tsToolStrip);
            Controls.Add(_CostAnalysisDetail_Toolbars_Dock_Area_Bottom);
            Controls.Add(UltraStatusBar1);
            Controls.Add(_CostAnalysisDetail_Toolbars_Dock_Area_Top);
            Margin=new Padding(5, 7, 5, 7);
            Name="CostAnalysisDetail";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cost Analysis Detail";
            pnlFields.ResumeLayout(false);
            pnlFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uteProjectPremium).EndInit();
            ((System.ComponentModel.ISupportInitialize)spGetAnalysesHeaderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQADataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteSoftCosts).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteNewMargin).EndInit();
            gpCustomAnalysis.ResumeLayout(false);
            gpCustomAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ucAlphaCodes).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraCalcManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAlphaCodesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQAAlphaCodes).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteCostIncreasePercent).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucDistricts).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetTaxDistrictListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQADistricts).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectsPlans).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndSourcePlanProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQAProjectList).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectOptions).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndSourceOptionsProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectsCosts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bndSourceCostProject).EndInit();
            gpBoxStandardAnalysis.ResumeLayout(false);
            gpBoxStandardAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ucProjectStandard).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetOpenProjectsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteProjectName).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteProjectID).EndInit();
            ((System.ComponentModel.ISupportInitialize)utePeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteAnalysisName).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)udAlert).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraStatusBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraDesktopAlert1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataAnalysisDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAnalysisBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraToolbarsManager1).EndInit();
            ContextMenuStrip1.ResumeLayout(false);
            FormClosed+=new FormClosedEventHandler(CostAnalysisDetail_FormClosed);
            Load+=new EventHandler(CostAnalysisDetail_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid ugDetails;
        internal BindingSource SpGetAnalysisBindingSource;
        internal HCHDataAnalysisDetail HCHDataAnalysisDetail;
        internal HCHDataAnalysisDetailTableAdapters.spGetAnalysisTableAdapter SpGetAnalysisTableAdapter;
        internal BindingSource spGetAnalysesHeaderBindingSource;
        internal HCHDataQADataSet HCHDataQADataSet;
        internal HCHDataQADataSetTableAdapters.spGetAnalysesHeaderTableAdapter SpGetAnalysesHeaderTableAdapter;
        internal Panel pnlFields;
        internal CheckBox ckPlansSelected;
        internal Button btnSelectPlans;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor utePeriod;
        internal Label Label2;
        internal Label Label1;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteAnalysisName;
        internal Label Label4;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteProjectName;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteProjectID;
        internal Label Label3;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteNotes;
        internal Label Label5;
        internal Label lblCreatedBy;
        internal Label Label8;
        internal Label lblCreatedDate;
        internal Label Label6;
        internal Label Label9;
        internal Label Label7;
        internal Label Label10;
        internal CheckBox chkDoNotUse;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnDelete;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnPrintRpt2;
        internal ToolStripButton tsButtonHelp;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripButton tsBtnReloadData;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripLabel tsLblLastReloadDate;
        internal GroupBox gpBoxStandardAnalysis;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucProjectStandard;
        internal CheckBox chkUseInfoFromStandardProject;
        internal HCHDataQAProjectList HCHDataQAProjectList;
        internal BindingSource SpGetOpenProjectsBindingSource;
        internal HCHDataQAProjectListTableAdapters.spGetOpenProjectsTableAdapter SpGetOpenProjectsTableAdapter;
        internal GroupBox gpCustomAnalysis;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucProjectOptions;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucProjectsCosts;
        internal Label Label13;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucProjectsPlans;
        internal Label Label12;
        internal Label Label11;
        internal Label Label16;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucAlphaCodes;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteCostIncreasePercent;
        internal Label Label15;
        internal Label Label14;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucDistricts;
        internal BindingSource bndSourceCostProject;
        internal HCHDataQADistricts HCHDataQADistricts;
        internal BindingSource SpGetTaxDistrictListBindingSource;
        internal HCHDataQADistrictsTableAdapters.spGetTaxDistrictListTableAdapter SpGetTaxDistrictListTableAdapter;
        internal HCHDataQAAlphaCodes HCHDataQAAlphaCodes;
        internal BindingSource SpGetAlphaCodesBindingSource;
        internal HCHDataQAAlphaCodesTableAdapters.spGetAlphaCodesTableAdapter SpGetAlphaCodesTableAdapter;
        internal BindingSource bndSourceOptionsProject;
        internal BindingSource bndSourcePlanProjects;
        internal Infragistics.Win.Misc.UltraDesktopAlert udAlert;
        internal Infragistics.Win.Misc.UltraPopupControlContainer UltraPopupControlContainer1;
        internal Infragistics.Win.UltraWinStatusBar.UltraStatusBar UltraStatusBar1;
        internal ToolStripButton tsBtnRecalculateGrid;
        internal Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter UltraGridExcelExporter1;
        internal Infragistics.Win.Misc.UltraDesktopAlert UltraDesktopAlert1;
        internal Infragistics.Win.UltraWinCalcManager.UltraCalcManager UltraCalcManager1;
        internal Infragistics.Win.UltraWinEditors.UltraNumericEditor uteNewMargin;
        internal Infragistics.Win.UltraWinEditors.UltraNumericEditor uteProjectPremium;
        internal Infragistics.Win.UltraWinEditors.UltraNumericEditor uteSoftCosts;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _CostAnalysisDetail_Toolbars_Dock_Area_Left;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsManager UltraToolbarsManager1;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _CostAnalysisDetail_Toolbars_Dock_Area_Right;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _CostAnalysisDetail_Toolbars_Dock_Area_Bottom;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _CostAnalysisDetail_Toolbars_Dock_Area_Top;
        internal ContextMenuStrip ContextMenuStrip1;
        internal ToolStripMenuItem tsViewEstimate;
        internal ToolStripMenuItem tsEstimateCostedRpt;
        internal ToolStripMenuItem tsSummaryBudgetRpt;
    }
}