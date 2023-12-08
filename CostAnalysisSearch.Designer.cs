using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CostAnalysisSearch : Form
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
            var UltraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("VersionName");
            var UltraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NewMargin");
            var UltraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostProjectID");
            var UltraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnalysisDate");
            var UltraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostProjectID1");
            var UltraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostProjectName");
            var UltraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnalysisID");
            var UltraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("TaxPermitID");
            var UltraDataColumn9 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("TaxPermitDistrict");
            var UltraDataColumn10 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectID");
            var UltraDataColumn11 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectMargin");
            var UltraDataColumn12 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CopyProjectID");
            var UltraDataColumn13 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("OptionProjectID");
            var UltraDataColumn14 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostIncreaseAlpha");
            var UltraDataColumn15 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostIncreasePercent");
            var UltraDataColumn16 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlanProjectID");
            var UltraDataColumn17 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Notes");
            var UltraDataColumn18 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectName");
            var UltraDataColumn19 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("SoftCosts");
            var UltraDataColumn20 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Period");
            var UltraDataColumn21 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectPremium");
            var UltraDataColumn22 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CreatedBy");
            var UltraDataColumn23 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("DoNotUse");
            var UltraDataColumn24 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("VersionName");
            var UltraDataColumn25 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("NewMargin");
            var UltraDataColumn26 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostProjectID");
            var UltraDataColumn27 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnalysisDate");
            var UltraDataColumn28 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostProjectID1");
            var UltraDataColumn29 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostProjectName");
            var UltraDataColumn30 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("AnalysisID");
            var UltraDataColumn31 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("TaxPermitID");
            var UltraDataColumn32 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("TaxPermitDistrict");
            var UltraDataColumn33 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectID");
            var UltraDataColumn34 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectMargin");
            var UltraDataColumn35 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CopyProjectID");
            var UltraDataColumn36 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("OptionProjectID");
            var UltraDataColumn37 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostIncreaseAlpha");
            var UltraDataColumn38 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CostIncreasePercent");
            var UltraDataColumn39 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlanProjectID");
            var UltraDataColumn40 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Notes");
            var UltraDataColumn41 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectName");
            var UltraDataColumn42 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("SoftCosts");
            var UltraDataColumn43 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Period");
            var UltraDataColumn44 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ProjectPremium");
            var UltraDataColumn45 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("CreatedBy");
            var UltraDataColumn46 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("DoNotUse");
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CostAnalysisSearch));
            var Appearance1 = new Infragistics.Win.Appearance();
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAnalysesSummary", -1);
            var UltraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VersionName");
            var UltraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NewMargin");
            var UltraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProjectID");
            var UltraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisDate", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProjectID1");
            var UltraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostProjectName");
            var UltraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AnalysisID");
            var UltraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict");
            var UltraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectMargin");
            var UltraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CopyProjectID");
            var UltraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OptionProjectID");
            var UltraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostIncreaseAlpha");
            var UltraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CostIncreasePercent");
            var UltraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanProjectID");
            var UltraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Notes");
            var UltraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SoftCosts");
            var UltraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Period");
            var UltraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectPremium");
            var UltraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy");
            var UltraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DoNotUse");
            var UltraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCode");
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
            var Appearance13 = new Infragistics.Win.Appearance();
            var Appearance14 = new Infragistics.Win.Appearance();
            UltraDataSource2=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            UltraDataSource1=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            Button1=new Button();
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnAdd.Click+=new EventHandler(tsBtnAdd_Click);
            tsBtnEdit=new ToolStripButton();
            tsBtnUndo=new ToolStripButton();
            tsBtnDelete=new ToolStripButton();
            tsBtnDelete.Click+=new EventHandler(tsBtnDelete_Click);
            tsBtnSave=new ToolStripButton();
            tsBtnPrint=new ToolStripButton();
            tsBtnPrint.Click+=new EventHandler(tsBtnPrint_Click);
            btnPrintRpt2=new ToolStripButton();
            btnPrintRpt2.Click+=new EventHandler(btnPrintRpt2_Click);
            tsBtnHelp=new ToolStripButton();
            tsBtnHelp.Click+=new EventHandler(HelpToolStripButton_Click);
            ToolStripSeparator1=new ToolStripSeparator();
            tsBtnReloadData=new ToolStripButton();
            tsBtnReloadData.Click+=new EventHandler(tsBtnReloadData_Click);
            ToolStripSeparator2=new ToolStripSeparator();
            tsLblLastReloadDate=new ToolStripLabel();
            tsBtnRefreshGrid=new ToolStripButton();
            tsBtnRefreshGrid.Click+=new EventHandler(tsBtnRefreshGrid_Click);
            ToolStripTextBox1=new ToolStripTextBox();
            AppStylistRuntime1=new Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(components);
            UltraGrid1=new Infragistics.Win.UltraWinGrid.UltraGrid();
            UltraGrid1.Click+=new EventHandler(UltraGrid1_Click);
            UltraGrid1.DoubleClick+=new EventHandler(UltraGrid1_DoubleClick);
            HCHDataCostAnalysis=new HCHDataCostAnalysis();
            SpGetAnalysesSummaryBindingSource=new BindingSource(components);
            SpGetAnalysesSummaryTableAdapter=new HCHDataCostAnalysisTableAdapters.spGetAnalysesSummaryTableAdapter();
            HCHDataCostAnalysisBindingSource=new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)UltraDataSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).BeginInit();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataCostAnalysis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAnalysesSummaryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataCostAnalysisBindingSource).BeginInit();
            SuspendLayout();
            // 
            // UltraDataSource2
            // 
            UltraDataColumn2.DataType=typeof(decimal);
            UltraDataColumn3.DataType=typeof(int);
            UltraDataColumn4.DataType=typeof(DateTime);
            UltraDataColumn7.DataType=typeof(int);
            UltraDataColumn8.DataType=typeof(int);
            UltraDataColumn11.DataType=typeof(decimal);
            UltraDataColumn14.DataType=typeof(int);
            UltraDataColumn15.DataType=typeof(decimal);
            UltraDataColumn19.DataType=typeof(int);
            UltraDataColumn21.DataType=typeof(int);
            UltraDataColumn23.DataType=typeof(bool);
            UltraDataSource2.Band.Columns.AddRange(new object[] { UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7, UltraDataColumn8, UltraDataColumn9, UltraDataColumn10, UltraDataColumn11, UltraDataColumn12, UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23 });
            UltraDataSource2.Band.Key="spGetAnalysesSummary";
            // 
            // UltraDataSource1
            // 
            UltraDataColumn25.DataType=typeof(decimal);
            UltraDataColumn26.DataType=typeof(int);
            UltraDataColumn27.DataType=typeof(DateTime);
            UltraDataColumn30.DataType=typeof(int);
            UltraDataColumn31.DataType=typeof(int);
            UltraDataColumn34.DataType=typeof(decimal);
            UltraDataColumn37.DataType=typeof(int);
            UltraDataColumn38.DataType=typeof(decimal);
            UltraDataColumn42.DataType=typeof(int);
            UltraDataColumn44.DataType=typeof(int);
            UltraDataColumn46.DataType=typeof(bool);
            UltraDataSource1.Band.Columns.AddRange(new object[] { UltraDataColumn24, UltraDataColumn25, UltraDataColumn26, UltraDataColumn27, UltraDataColumn28, UltraDataColumn29, UltraDataColumn30, UltraDataColumn31, UltraDataColumn32, UltraDataColumn33, UltraDataColumn34, UltraDataColumn35, UltraDataColumn36, UltraDataColumn37, UltraDataColumn38, UltraDataColumn39, UltraDataColumn40, UltraDataColumn41, UltraDataColumn42, UltraDataColumn43, UltraDataColumn44, UltraDataColumn45, UltraDataColumn46 });
            UltraDataSource1.Band.Key="spGetAnalysesSummary";
            // 
            // Button1
            // 
            Button1.Location=new Point(789, -3);
            Button1.Name="Button1";
            Button1.Size=new Size(75, 23);
            Button1.TabIndex=1;
            Button1.Text="Button1";
            Button1.UseVisualStyleBackColor=true;
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnDelete, tsBtnSave, tsBtnPrint, btnPrintRpt2, tsBtnHelp, ToolStripSeparator1, tsBtnReloadData, ToolStripSeparator2, tsLblLastReloadDate, tsBtnRefreshGrid, ToolStripTextBox1 });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(1778, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=3;
            tsToolStrip.Text="ToolStrip1";
            // 
            // tsBtnAdd
            // 
            tsBtnAdd.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnAdd.Image=(Image)resources.GetObject("tsBtnAdd.Image");
            tsBtnAdd.ImageTransparentColor=Color.Magenta;
            tsBtnAdd.Name="tsBtnAdd";
            tsBtnAdd.Size=new Size(28, 28);
            tsBtnAdd.Text="Add New";
            tsBtnAdd.ToolTipText="Click to Add New Record";
            // 
            // tsBtnEdit
            // 
            tsBtnEdit.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnEdit.Enabled=false;
            tsBtnEdit.Image=(Image)resources.GetObject("tsBtnEdit.Image");
            tsBtnEdit.ImageTransparentColor=Color.Magenta;
            tsBtnEdit.Name="tsBtnEdit";
            tsBtnEdit.Size=new Size(28, 28);
            tsBtnEdit.Text="Edit";
            tsBtnEdit.ToolTipText="Click to Edit Records";
            // 
            // tsBtnUndo
            // 
            tsBtnUndo.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnUndo.Enabled=false;
            tsBtnUndo.Image=My.Resources.Resources.Edit_Undo;
            tsBtnUndo.ImageTransparentColor=Color.Magenta;
            tsBtnUndo.Name="tsBtnUndo";
            tsBtnUndo.Size=new Size(28, 28);
            tsBtnUndo.Text="Cancel Changes";
            tsBtnUndo.ToolTipText="Click to Cancel Changes";
            // 
            // tsBtnDelete
            // 
            tsBtnDelete.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnDelete.Image=(Image)resources.GetObject("tsBtnDelete.Image");
            tsBtnDelete.ImageTransparentColor=Color.Magenta;
            tsBtnDelete.Name="tsBtnDelete";
            tsBtnDelete.Size=new Size(28, 28);
            tsBtnDelete.Text="Delete";
            // 
            // tsBtnSave
            // 
            tsBtnSave.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnSave.Enabled=false;
            tsBtnSave.Image=My.Resources.Resources.Save;
            tsBtnSave.ImageTransparentColor=Color.Magenta;
            tsBtnSave.Name="tsBtnSave";
            tsBtnSave.Size=new Size(28, 28);
            tsBtnSave.Text="Save";
            tsBtnSave.ToolTipText="Click to Save Changes";
            // 
            // tsBtnPrint
            // 
            tsBtnPrint.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnPrint.Enabled=false;
            tsBtnPrint.Image=My.Resources.Resources.Print;
            tsBtnPrint.ImageTransparentColor=Color.Magenta;
            tsBtnPrint.Name="tsBtnPrint";
            tsBtnPrint.Size=new Size(28, 28);
            tsBtnPrint.Text="Print";
            tsBtnPrint.ToolTipText="Click to Print Report";
            // 
            // btnPrintRpt2
            // 
            btnPrintRpt2.DisplayStyle=ToolStripItemDisplayStyle.Image;
            btnPrintRpt2.Enabled=false;
            btnPrintRpt2.Image=My.Resources.Resources.Print;
            btnPrintRpt2.ImageTransparentColor=Color.Magenta;
            btnPrintRpt2.Name="btnPrintRpt2";
            btnPrintRpt2.Size=new Size(28, 28);
            btnPrintRpt2.Text="Print Report 2";
            // 
            // tsBtnHelp
            // 
            tsBtnHelp.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnHelp.Image=(Image)resources.GetObject("tsBtnHelp.Image");
            tsBtnHelp.ImageTransparentColor=Color.Magenta;
            tsBtnHelp.Name="tsBtnHelp";
            tsBtnHelp.Size=new Size(28, 28);
            tsBtnHelp.Text="He&lp";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name="ToolStripSeparator1";
            ToolStripSeparator1.Size=new Size(6, 31);
            // 
            // tsBtnReloadData
            // 
            tsBtnReloadData.DisplayStyle=ToolStripItemDisplayStyle.Text;
            tsBtnReloadData.Font=new Font("Segoe UI", 9.0f, FontStyle.Bold);
            tsBtnReloadData.ForeColor=SystemColors.Highlight;
            tsBtnReloadData.Image=(Image)resources.GetObject("tsBtnReloadData.Image");
            tsBtnReloadData.ImageTransparentColor=Color.Magenta;
            tsBtnReloadData.Name="tsBtnReloadData";
            tsBtnReloadData.Size=new Size(118, 28);
            tsBtnReloadData.Text="RELOAD DATA";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name="ToolStripSeparator2";
            ToolStripSeparator2.Size=new Size(6, 31);
            // 
            // tsLblLastReloadDate
            // 
            tsLblLastReloadDate.Name="tsLblLastReloadDate";
            tsLblLastReloadDate.Size=new Size(142, 28);
            tsLblLastReloadDate.Text="Data Last Reloaded:";
            // 
            // tsBtnRefreshGrid
            // 
            tsBtnRefreshGrid.Image=(Image)resources.GetObject("tsBtnRefreshGrid.Image");
            tsBtnRefreshGrid.ImageTransparentColor=Color.Magenta;
            tsBtnRefreshGrid.Name="tsBtnRefreshGrid";
            tsBtnRefreshGrid.Size=new Size(118, 28);
            tsBtnRefreshGrid.Text="Refresh Grid";
            // 
            // ToolStripTextBox1
            // 
            ToolStripTextBox1.Name="ToolStripTextBox1";
            ToolStripTextBox1.Size=new Size(770, 31);
            ToolStripTextBox1.Text="Single click on grid rows to select rows (you can select multiple rows) or Double"+" Click to go to Detail screen)";
            // 
            // UltraGrid1
            // 
            UltraGrid1.DataMember="spGetAnalysesSummary";
            UltraGrid1.DataSource=HCHDataCostAnalysis;
            Appearance1.BackColor=Color.Gainsboro;
            Appearance1.BackColor2=Color.DarkGray;
            Appearance1.BackGradientStyle=Infragistics.Win.GradientStyle.ForwardDiagonal;
            UltraGrid1.DisplayLayout.Appearance=Appearance1;
            UltraGridColumn25.Header.Caption="Version Name";
            UltraGridColumn25.Header.VisiblePosition=5;
            UltraGridColumn25.Width=114;
            UltraGridColumn26.Header.Caption="New Margin";
            UltraGridColumn26.Header.VisiblePosition=4;
            UltraGridColumn26.Width=96;
            UltraGridColumn27.Header.VisiblePosition=7;
            UltraGridColumn27.Hidden=true;
            UltraGridColumn28.Header.Caption="Date Created";
            UltraGridColumn28.Header.VisiblePosition=1;
            UltraGridColumn28.Width=122;
            UltraGridColumn29.Header.Caption="Cost Project ID";
            UltraGridColumn29.Header.VisiblePosition=14;
            UltraGridColumn29.Width=94;
            UltraGridColumn30.Header.VisiblePosition=8;
            UltraGridColumn30.Hidden=true;
            UltraGridColumn31.Header.VisiblePosition=19;
            UltraGridColumn31.Hidden=true;
            UltraGridColumn32.Header.VisiblePosition=9;
            UltraGridColumn32.Hidden=true;
            UltraGridColumn33.Header.Caption="Tax Permit District";
            UltraGridColumn33.Header.VisiblePosition=10;
            UltraGridColumn34.Header.Caption="Project ID";
            UltraGridColumn34.Header.VisiblePosition=2;
            UltraGridColumn34.Width=103;
            UltraGridColumn35.Header.Caption="Copy Project Margin";
            UltraGridColumn35.Header.VisiblePosition=12;
            UltraGridColumn35.Width=114;
            UltraGridColumn36.Header.Caption="Copy Project ID";
            UltraGridColumn36.Header.VisiblePosition=11;
            UltraGridColumn36.Width=96;
            UltraGridColumn37.Header.Caption="Option Project ID";
            UltraGridColumn37.Header.VisiblePosition=13;
            UltraGridColumn37.Width=99;
            UltraGridColumn38.Header.Caption="Cost Increase Alpha";
            UltraGridColumn38.Header.VisiblePosition=22;
            UltraGridColumn38.Width=108;
            UltraGridColumn39.Header.Caption="Cost Increase %";
            UltraGridColumn39.Header.VisiblePosition=23;
            UltraGridColumn39.Width=108;
            UltraGridColumn40.Header.Caption="Plan Project ID";
            UltraGridColumn40.Header.VisiblePosition=15;
            UltraGridColumn40.Width=95;
            UltraGridColumn41.Header.VisiblePosition=16;
            UltraGridColumn41.Width=292;
            UltraGridColumn42.Header.Caption="Project Name";
            UltraGridColumn42.Header.VisiblePosition=3;
            UltraGridColumn42.Width=244;
            UltraGridColumn43.Header.Caption="Soft Costs";
            UltraGridColumn43.Header.VisiblePosition=18;
            UltraGridColumn43.Width=98;
            UltraGridColumn44.Header.VisiblePosition=6;
            UltraGridColumn44.Width=156;
            UltraGridColumn45.Header.Caption="Project Premium";
            UltraGridColumn45.Header.VisiblePosition=21;
            UltraGridColumn45.Width=109;
            UltraGridColumn46.Header.Caption="Created By";
            UltraGridColumn46.Header.VisiblePosition=17;
            UltraGridColumn46.Width=121;
            UltraGridColumn47.Header.Caption="Do Not Use";
            UltraGridColumn47.Header.VisiblePosition=0;
            UltraGridColumn47.Width=82;
            UltraGridColumn48.Header.Caption="Alpha Code";
            UltraGridColumn48.Header.VisiblePosition=20;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn42, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48 });
            UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            UltraGrid1.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            UltraGrid1.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            UltraGrid1.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            UltraGrid1.DisplayLayout.InterBandSpacing=10;
            UltraGrid1.DisplayLayout.MaxColScrollRegions=1;
            UltraGrid1.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            UltraGrid1.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            UltraGrid1.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            UltraGrid1.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            UltraGrid1.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.WithinBand;
            UltraGrid1.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            UltraGrid1.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.WithinBand;
            UltraGrid1.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            UltraGrid1.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            UltraGrid1.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            UltraGrid1.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.InsetSoft;
            Appearance7.BackColor=Color.Transparent;
            UltraGrid1.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BackColor=Color.LightSteelBlue;
            Appearance8.ForeColor=Color.Navy;
            UltraGrid1.DisplayLayout.Override.CellAppearance=Appearance8;
            UltraGrid1.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            UltraGrid1.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.BackColor=Color.DarkGray;
            Appearance10.BackColor2=Color.Gainsboro;
            Appearance10.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance10.FontData.Name="Tahoma";
            Appearance10.FontData.SizeInPoints=9.0f;
            Appearance10.ForeColor=Color.Navy;
            Appearance10.TextHAlignAsString="Left";
            Appearance10.ThemedElementAlpha=Infragistics.Win.Alpha.Transparent;
            UltraGrid1.DisplayLayout.Override.HeaderAppearance=Appearance10;
            UltraGrid1.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            UltraGrid1.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            UltraGrid1.DisplayLayout.Override.RowAppearance=Appearance11;
            UltraGrid1.DisplayLayout.Override.RowFilterAction=Infragistics.Win.UltraWinGrid.RowFilterAction.HideFilteredOutRows;
            Appearance12.BackColor=Color.DarkGray;
            Appearance12.BackColor2=Color.Gainsboro;
            Appearance12.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance12.ForeColor=Color.Navy;
            UltraGrid1.DisplayLayout.Override.RowSelectorAppearance=Appearance12;
            UltraGrid1.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.RowSelectorWidth=20;
            UltraGrid1.DisplayLayout.Override.RowSpacingAfter=1;
            UltraGrid1.DisplayLayout.Override.RowSpacingBefore=3;
            Appearance13.BackColor=Color.Navy;
            Appearance13.ForeColor=Color.FromArgb(224, 224, 224);
            UltraGrid1.DisplayLayout.Override.SelectedRowAppearance=Appearance13;
            UltraGrid1.DisplayLayout.Override.SelectTypeCell=Infragistics.Win.UltraWinGrid.SelectType.None;
            UltraGrid1.DisplayLayout.Override.SelectTypeCol=Infragistics.Win.UltraWinGrid.SelectType.None;
            UltraGrid1.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Extended;
            Appearance14.BackColor=SystemColors.ControlLight;
            UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=Appearance14;
            UltraGrid1.DisplayLayout.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.RowConnectorColor=Color.Gray;
            UltraGrid1.DisplayLayout.RowConnectorStyle=Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dashed;
            UltraGrid1.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            UltraGrid1.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            UltraGrid1.DisplayLayout.UseFixedHeaders=true;
            UltraGrid1.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            UltraGrid1.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraGrid1.Location=new Point(24, 62);
            UltraGrid1.Name="UltraGrid1";
            UltraGrid1.Size=new Size(1733, 782);
            UltraGrid1.TabIndex=0;
            UltraGrid1.Text="UltraGrid1";
            // 
            // HCHDataCostAnalysis
            // 
            HCHDataCostAnalysis.DataSetName="HCHDataCostAnalysis";
            HCHDataCostAnalysis.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // SpGetAnalysesSummaryBindingSource
            // 
            SpGetAnalysesSummaryBindingSource.DataMember="spGetAnalysesSummary";
            SpGetAnalysesSummaryBindingSource.DataSource=HCHDataCostAnalysis;
            // 
            // SpGetAnalysesSummaryTableAdapter
            // 
            SpGetAnalysesSummaryTableAdapter.ClearBeforeFill=true;
            // 
            // HCHDataCostAnalysisBindingSource
            // 
            HCHDataCostAnalysisBindingSource.DataSource=HCHDataCostAnalysis;
            HCHDataCostAnalysisBindingSource.Position=0;
            // 
            // CostAnalysisSearch
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            AutoSizeMode=AutoSizeMode.GrowAndShrink;
            ClientSize=new Size(1778, 875);
            Controls.Add(tsToolStrip);
            Controls.Add(Button1);
            Controls.Add(UltraGrid1);
            Name="CostAnalysisSearch";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Cost Analysis Search";
            ((System.ComponentModel.ISupportInitialize)UltraDataSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataCostAnalysis).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAnalysesSummaryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataCostAnalysisBindingSource).EndInit();
            Load+=new EventHandler(CostAnalysisSearch_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal HCHDataCostAnalysis HCHDataCostAnalysis;
        internal BindingSource SpGetAnalysesSummaryBindingSource;
        internal HCHDataCostAnalysisTableAdapters.spGetAnalysesSummaryTableAdapter SpGetAnalysesSummaryTableAdapter;
        internal Button Button1;
        internal BindingSource HCHDataCostAnalysisBindingSource;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnDelete;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnHelp;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripButton btnPrintRpt2;
        internal ToolStripButton tsBtnReloadData;
        internal ToolStripLabel tsLblLastReloadDate;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripButton tsBtnRefreshGrid;
        internal ToolStripTextBox ToolStripTextBox1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource1;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource2;
        private Infragistics.Win.AppStyling.Runtime.AppStylistRuntime AppStylistRuntime1;
        internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
    }
}