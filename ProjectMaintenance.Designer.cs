using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ProjectMaintenance : Form
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
            var Appearance1 = new Infragistics.Win.Appearance();
            var Appearance2 = new Infragistics.Win.Appearance();
            var Appearance3 = new Infragistics.Win.Appearance();
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("NSM", -1);
            var UltraGridColumn31 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SIID", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn32 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StartDate");
            var UltraGridColumn33 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EndDate");
            var UltraGridColumn34 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Inactive");
            var UltraGridColumn35 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fName");
            var UltraGridColumn36 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lName");
            var UltraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nsmName");
            var UltraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectNSMID", 0);
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
            var Appearance15 = new Infragistics.Win.Appearance();
            var Appearance16 = new Infragistics.Win.Appearance();
            var Appearance17 = new Infragistics.Win.Appearance();
            var Appearance18 = new Infragistics.Win.Appearance();
            var Appearance19 = new Infragistics.Win.Appearance();
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Plan", -1);
            var UltraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanID");
            var UltraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanName");
            var UltraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanPrice");
            var UltraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StartDate", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            var UltraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EndDate");
            var UltraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PricePlanID");
            var Appearance20 = new Infragistics.Win.Appearance();
            var Appearance21 = new Infragistics.Win.Appearance();
            var Appearance22 = new Infragistics.Win.Appearance();
            var Appearance23 = new Infragistics.Win.Appearance();
            var Appearance24 = new Infragistics.Win.Appearance();
            var Appearance25 = new Infragistics.Win.Appearance();
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
            var UltraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Builder", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SIID");
            var UltraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fName");
            var UltraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lName");
            var UltraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("username");
            var UltraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Inactive");
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjBlrdID");
            var Appearance36 = new Infragistics.Win.Appearance();
            var Appearance37 = new Infragistics.Win.Appearance();
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
            var UltraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Project ID");
            var UltraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HCHOwned");
            var UltraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("LotCosts");
            var UltraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
            var UltraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DrivingDirections");
            var UltraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BuildAmerica");
            var UltraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ReadyForReleases");
            var UltraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Inactive");
            var UltraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Power");
            var UltraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SewerOrSeptic");
            var UltraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Water");
            var UltraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cable", 0);
            var UltraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Telephone", 1);
            var UltraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ModelPhoneNumber", 2);
            var UltraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TitleInsCompanyID", 3);
            var UltraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Notes", 4);
            var UltraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SetbacksBuffers", 5);
            var UltraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("id", 6);
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMaintenance));
            var Appearance61 = new Infragistics.Win.Appearance();
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
            var UltraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn42 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict");
            var UltraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Division", 0);
            var Appearance72 = new Infragistics.Win.Appearance();
            var Appearance73 = new Infragistics.Win.Appearance();
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
            var Appearance85 = new Infragistics.Win.Appearance();
            var Appearance86 = new Infragistics.Win.Appearance();
            var Appearance87 = new Infragistics.Win.Appearance();
            var Appearance88 = new Infragistics.Win.Appearance();
            var Appearance89 = new Infragistics.Win.Appearance();
            var Appearance90 = new Infragistics.Win.Appearance();
            var Appearance91 = new Infragistics.Win.Appearance();
            var Appearance92 = new Infragistics.Win.Appearance();
            var Appearance93 = new Infragistics.Win.Appearance();
            var Appearance94 = new Infragistics.Win.Appearance();
            grdNSM=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdNSM.BeforeSelectChange+=new Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventHandler(grdNSM_afterSelectChange);
            grdNSM.BeforeSelectChange+=new Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventHandler(grdBuilders_afterSelectChange);
            grdPlanPrices=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdBuilders=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdBuilders.BeforeRowsDeleted+=new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(grdBuilders_BeforeRowsDeleted);
            ucboProject=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ucboProject.AfterCloseUp+=new EventHandler(ucboProject_AfterCloseUp);
            Label1=new Label();
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnEdit=new ToolStripButton();
            tsBtnEdit.Click+=new EventHandler(tsBtnEdit_Click);
            tsBtnUndo=new ToolStripButton();
            tsBtnUndo.Click+=new EventHandler(tsBtnUndo_Click);
            tsBtnSave=new ToolStripButton();
            tsBtnSave.Click+=new EventHandler(tsBtnSave_Click);
            tsBtnPrint=new ToolStripButton();
            tsBtnTip=new ToolStripButton();
            txtProjectID=new TextBox();
            ugbUtilities=new Infragistics.Win.Misc.UltraGroupBox();
            txtCable=new TextBox();
            Label10=new Label();
            txtTelephone=new TextBox();
            Label9=new Label();
            txtPower=new TextBox();
            txtSewerSeptic=new TextBox();
            txtWater=new TextBox();
            Label8=new Label();
            Label7=new Label();
            Label6=new Label();
            ugbBasicInfo=new Infragistics.Win.Misc.UltraGroupBox();
            uchkHCHOwned=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uchkCostPrice=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uchkComplete=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uchkReadyForReleases=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            txtProjectName=new TextBox();
            Label4=new Label();
            txtLotCosts=new TextBox();
            Label3=new Label();
            ucboTaxPermit=new Infragistics.Win.UltraWinGrid.UltraCombo();
            Label2=new Label();
            ugbMoreInfo=new Infragistics.Win.Misc.UltraGroupBox();
            txtModelPhone=new TextBox();
            Label14=new Label();
            txtDrivingDirections=new TextBox();
            Label13=new Label();
            txtSetbacksBuffers=new TextBox();
            Label12=new Label();
            Label11=new Label();
            ucboTitleIns=new Infragistics.Win.UltraWinGrid.UltraCombo();
            Label5=new Label();
            Label15=new Label();
            ((System.ComponentModel.ISupportInitialize)grdNSM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdPlanPrices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdBuilders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucboProject).BeginInit();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ugbUtilities).BeginInit();
            ugbUtilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ugbBasicInfo).BeginInit();
            ugbBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uchkHCHOwned).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uchkCostPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uchkComplete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uchkReadyForReleases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucboTaxPermit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugbMoreInfo).BeginInit();
            ugbMoreInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucboTitleIns).BeginInit();
            SuspendLayout();
            // 
            // grdNSM
            // 
            Appearance1.BackColor=SystemColors.Control;
            Appearance1.ForeColor=SystemColors.MenuText;
            Appearance1.ForeColorDisabled=SystemColors.MenuHighlight;
            grdNSM.DisplayLayout.AddNewBox.Appearance=Appearance1;
            Appearance2.BackColor=SystemColors.Window;
            Appearance2.ForeColor=SystemColors.MenuText;
            Appearance2.ForeColorDisabled=SystemColors.MenuHighlight;
            Appearance2.ForegroundAlpha=Infragistics.Win.Alpha.Opaque;
            grdNSM.DisplayLayout.AddNewBox.ButtonAppearance=Appearance2;
            grdNSM.DisplayLayout.AddNewBox.Hidden=false;
            grdNSM.DisplayLayout.AddNewBox.Prompt="Add New ...";
            grdNSM.DisplayLayout.AddNewBox.Style=Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            Appearance3.BackColor=SystemColors.Window;
            Appearance3.BorderColor=SystemColors.InactiveCaption;
            Appearance3.ForeColorDisabled=SystemColors.ControlText;
            grdNSM.DisplayLayout.Appearance=Appearance3;
            UltraGridBand1.AddButtonCaption="Add New NSM";
            UltraGridColumn31.Header.Caption="NSMs";
            UltraGridColumn31.Header.VisiblePosition=0;
            UltraGridColumn31.Width=200;
            UltraGridColumn32.ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            UltraGridColumn32.Header.Caption="Start Date";
            UltraGridColumn32.Header.VisiblePosition=1;
            UltraGridColumn33.ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            UltraGridColumn33.Header.Caption="End Date";
            UltraGridColumn33.Header.VisiblePosition=2;
            UltraGridColumn34.Header.VisiblePosition=3;
            UltraGridColumn35.Header.VisiblePosition=4;
            UltraGridColumn35.Hidden=true;
            UltraGridColumn36.Header.VisiblePosition=5;
            UltraGridColumn36.Hidden=true;
            UltraGridColumn37.Header.VisiblePosition=6;
            UltraGridColumn37.Hidden=true;
            UltraGridColumn38.Header.VisiblePosition=7;
            UltraGridColumn38.Hidden=true;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn31, UltraGridColumn32, UltraGridColumn33, UltraGridColumn34, UltraGridColumn35, UltraGridColumn36, UltraGridColumn37, UltraGridColumn38 });
            Appearance4.ForeColor=SystemColors.HighlightText;
            UltraGridBand1.Override.ActiveRowAppearance=Appearance4;
            grdNSM.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            grdNSM.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNSM.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance5.BackColor=SystemColors.ActiveBorder;
            Appearance5.BackColor2=SystemColors.ControlDark;
            Appearance5.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance5.BorderColor=SystemColors.Window;
            grdNSM.DisplayLayout.GroupByBox.Appearance=Appearance5;
            Appearance6.ForeColor=SystemColors.GrayText;
            grdNSM.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance6;
            grdNSM.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNSM.DisplayLayout.GroupByBox.Hidden=true;
            Appearance7.BackColor=SystemColors.ControlLightLight;
            Appearance7.BackColor2=SystemColors.Control;
            Appearance7.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance7.ForeColor=SystemColors.GrayText;
            grdNSM.DisplayLayout.GroupByBox.PromptAppearance=Appearance7;
            grdNSM.DisplayLayout.MaxColScrollRegions=1;
            grdNSM.DisplayLayout.MaxRowScrollRegions=1;
            Appearance8.BackColor=SystemColors.Window;
            Appearance8.ForeColor=SystemColors.HighlightText;
            grdNSM.DisplayLayout.Override.ActiveCellAppearance=Appearance8;
            Appearance9.BackColor=SystemColors.Highlight;
            Appearance9.ForeColor=SystemColors.HighlightText;
            grdNSM.DisplayLayout.Override.ActiveRowAppearance=Appearance9;
            grdNSM.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            grdNSM.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdNSM.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            grdNSM.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdNSM.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdNSM.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdNSM.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdNSM.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance10.BackColor=SystemColors.Window;
            grdNSM.DisplayLayout.Override.CardAreaAppearance=Appearance10;
            Appearance11.BorderColor=Color.Silver;
            Appearance11.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdNSM.DisplayLayout.Override.CellAppearance=Appearance11;
            grdNSM.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdNSM.DisplayLayout.Override.CellPadding=0;
            Appearance12.BackColor=SystemColors.Control;
            Appearance12.BackColor2=SystemColors.ControlDark;
            Appearance12.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance12.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance12.BorderColor=SystemColors.Window;
            grdNSM.DisplayLayout.Override.GroupByRowAppearance=Appearance12;
            Appearance13.TextHAlignAsString="Left";
            grdNSM.DisplayLayout.Override.HeaderAppearance=Appearance13;
            grdNSM.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdNSM.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance14.BackColor=SystemColors.Window;
            Appearance14.BorderColor=Color.Silver;
            grdNSM.DisplayLayout.Override.RowAppearance=Appearance14;
            grdNSM.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance15.ForeColor=SystemColors.HighlightText;
            Appearance15.ForeColorDisabled=SystemColors.InactiveCaptionText;
            grdNSM.DisplayLayout.Override.SelectedRowAppearance=Appearance15;
            grdNSM.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance16.BackColor=SystemColors.ControlLight;
            grdNSM.DisplayLayout.Override.TemplateAddRowAppearance=Appearance16;
            grdNSM.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdNSM.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdNSM.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdNSM.Location=new Point(437, 207);
            grdNSM.Name="grdNSM";
            grdNSM.Size=new Size(508, 151);
            grdNSM.TabIndex=17;
            grdNSM.Text="NSM's  - Unfilter to show history ";
            // 
            // grdPlanPrices
            // 
            Appearance17.BackColor=SystemColors.Control;
            Appearance17.ForeColor=SystemColors.MenuText;
            Appearance17.ForeColorDisabled=SystemColors.MenuHighlight;
            grdPlanPrices.DisplayLayout.AddNewBox.Appearance=Appearance17;
            Appearance18.BackColor=SystemColors.Window;
            Appearance18.ForeColor=SystemColors.MenuText;
            Appearance18.ForeColorDisabled=SystemColors.MenuHighlight;
            Appearance18.ForegroundAlpha=Infragistics.Win.Alpha.Opaque;
            grdPlanPrices.DisplayLayout.AddNewBox.ButtonAppearance=Appearance18;
            grdPlanPrices.DisplayLayout.AddNewBox.Hidden=false;
            grdPlanPrices.DisplayLayout.AddNewBox.Prompt="Add New ...";
            grdPlanPrices.DisplayLayout.AddNewBox.Style=Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            Appearance19.BackColor=SystemColors.Window;
            Appearance19.BorderColor=SystemColors.InactiveCaption;
            Appearance19.ForeColorDisabled=SystemColors.ControlText;
            grdPlanPrices.DisplayLayout.Appearance=Appearance19;
            UltraGridBand2.AddButtonCaption="Add New Plan";
            UltraGridColumn12.Header.VisiblePosition=0;
            UltraGridColumn12.Width=76;
            UltraGridColumn15.Header.Caption="Plan Name";
            UltraGridColumn15.Header.VisiblePosition=1;
            UltraGridColumn15.Width=186;
            UltraGridColumn16.Header.Caption="Price";
            UltraGridColumn16.Header.VisiblePosition=2;
            UltraGridColumn13.Header.VisiblePosition=3;
            UltraGridColumn14.Header.VisiblePosition=4;
            UltraGridColumn17.Header.VisiblePosition=5;
            UltraGridColumn17.Hidden=true;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn12, UltraGridColumn15, UltraGridColumn16, UltraGridColumn13, UltraGridColumn14, UltraGridColumn17 });
            Appearance20.ForeColor=SystemColors.HighlightText;
            UltraGridBand2.Override.ActiveRowAppearance=Appearance20;
            grdPlanPrices.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            grdPlanPrices.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdPlanPrices.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance21.BackColor=SystemColors.ActiveBorder;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance21.BorderColor=SystemColors.Window;
            grdPlanPrices.DisplayLayout.GroupByBox.Appearance=Appearance21;
            Appearance22.ForeColor=SystemColors.GrayText;
            grdPlanPrices.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance22;
            grdPlanPrices.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdPlanPrices.DisplayLayout.GroupByBox.Hidden=true;
            Appearance23.BackColor=SystemColors.ControlLightLight;
            Appearance23.BackColor2=SystemColors.Control;
            Appearance23.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance23.ForeColor=SystemColors.GrayText;
            grdPlanPrices.DisplayLayout.GroupByBox.PromptAppearance=Appearance23;
            grdPlanPrices.DisplayLayout.MaxColScrollRegions=1;
            grdPlanPrices.DisplayLayout.MaxRowScrollRegions=1;
            Appearance24.BackColor=SystemColors.Window;
            Appearance24.ForeColor=SystemColors.HighlightText;
            grdPlanPrices.DisplayLayout.Override.ActiveCellAppearance=Appearance24;
            Appearance25.BackColor=SystemColors.Highlight;
            Appearance25.ForeColor=SystemColors.HighlightText;
            grdPlanPrices.DisplayLayout.Override.ActiveRowAppearance=Appearance25;
            grdPlanPrices.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            grdPlanPrices.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdPlanPrices.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            grdPlanPrices.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdPlanPrices.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdPlanPrices.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdPlanPrices.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdPlanPrices.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance26.BackColor=SystemColors.Window;
            grdPlanPrices.DisplayLayout.Override.CardAreaAppearance=Appearance26;
            Appearance27.BorderColor=Color.Silver;
            Appearance27.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdPlanPrices.DisplayLayout.Override.CellAppearance=Appearance27;
            grdPlanPrices.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdPlanPrices.DisplayLayout.Override.CellPadding=0;
            Appearance28.BackColor=SystemColors.Control;
            Appearance28.BackColor2=SystemColors.ControlDark;
            Appearance28.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance28.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance28.BorderColor=SystemColors.Window;
            grdPlanPrices.DisplayLayout.Override.GroupByRowAppearance=Appearance28;
            Appearance29.TextHAlignAsString="Left";
            grdPlanPrices.DisplayLayout.Override.HeaderAppearance=Appearance29;
            grdPlanPrices.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdPlanPrices.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance30.BackColor=SystemColors.Window;
            Appearance30.BorderColor=Color.Silver;
            grdPlanPrices.DisplayLayout.Override.RowAppearance=Appearance30;
            grdPlanPrices.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance31.ForeColor=SystemColors.HighlightText;
            Appearance31.ForeColorDisabled=SystemColors.InactiveCaptionText;
            grdPlanPrices.DisplayLayout.Override.SelectedRowAppearance=Appearance31;
            grdPlanPrices.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance32.BackColor=SystemColors.ControlLight;
            grdPlanPrices.DisplayLayout.Override.TemplateAddRowAppearance=Appearance32;
            grdPlanPrices.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdPlanPrices.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdPlanPrices.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdPlanPrices.Location=new Point(437, 369);
            grdPlanPrices.Name="grdPlanPrices";
            grdPlanPrices.Size=new Size(533, 365);
            grdPlanPrices.TabIndex=18;
            grdPlanPrices.Text="Plan Prices  - Unfilter to show history ";
            // 
            // grdBuilders
            // 
            Appearance33.BackColor=SystemColors.Control;
            Appearance33.ForeColor=SystemColors.MenuText;
            Appearance33.ForeColorDisabled=SystemColors.MenuHighlight;
            grdBuilders.DisplayLayout.AddNewBox.Appearance=Appearance33;
            Appearance34.BackColor=SystemColors.Window;
            Appearance34.ForeColor=SystemColors.MenuText;
            Appearance34.ForeColorDisabled=SystemColors.MenuHighlight;
            Appearance34.ForegroundAlpha=Infragistics.Win.Alpha.Opaque;
            grdBuilders.DisplayLayout.AddNewBox.ButtonAppearance=Appearance34;
            grdBuilders.DisplayLayout.AddNewBox.Hidden=false;
            grdBuilders.DisplayLayout.AddNewBox.Prompt="Add New ...";
            grdBuilders.DisplayLayout.AddNewBox.Style=Infragistics.Win.UltraWinGrid.AddNewBoxStyle.Compact;
            Appearance35.BackColor=SystemColors.Window;
            Appearance35.BorderColor=SystemColors.InactiveCaption;
            Appearance35.ForeColorDisabled=SystemColors.ControlText;
            grdBuilders.DisplayLayout.Appearance=Appearance35;
            UltraGridBand3.AddButtonCaption="Add New Builder";
            UltraGridColumn1.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn1.Header.Caption="Builder";
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridColumn1.Width=175;
            UltraGridColumn5.Header.VisiblePosition=2;
            UltraGridColumn5.Hidden=true;
            UltraGridColumn6.Header.VisiblePosition=3;
            UltraGridColumn6.Hidden=true;
            UltraGridColumn7.Header.VisiblePosition=4;
            UltraGridColumn7.Hidden=true;
            UltraGridColumn4.Header.VisiblePosition=1;
            UltraGridColumn2.Header.VisiblePosition=5;
            UltraGridColumn2.Hidden=true;
            UltraGridBand3.Columns.AddRange(new object[] { UltraGridColumn1, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn4, UltraGridColumn2 });
            Appearance36.ForeColor=SystemColors.HighlightText;
            UltraGridBand3.Override.ActiveRowAppearance=Appearance36;
            grdBuilders.DisplayLayout.BandsSerializer.Add(UltraGridBand3);
            grdBuilders.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdBuilders.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance37.BackColor=SystemColors.ActiveBorder;
            Appearance37.BackColor2=SystemColors.ControlDark;
            Appearance37.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance37.BorderColor=SystemColors.Window;
            grdBuilders.DisplayLayout.GroupByBox.Appearance=Appearance37;
            Appearance38.ForeColor=SystemColors.GrayText;
            grdBuilders.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance38;
            grdBuilders.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdBuilders.DisplayLayout.GroupByBox.Hidden=true;
            Appearance39.BackColor=SystemColors.ControlLightLight;
            Appearance39.BackColor2=SystemColors.Control;
            Appearance39.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance39.ForeColor=SystemColors.GrayText;
            grdBuilders.DisplayLayout.GroupByBox.PromptAppearance=Appearance39;
            grdBuilders.DisplayLayout.MaxColScrollRegions=1;
            grdBuilders.DisplayLayout.MaxRowScrollRegions=1;
            Appearance40.BackColor=SystemColors.Window;
            Appearance40.ForeColor=SystemColors.HighlightText;
            grdBuilders.DisplayLayout.Override.ActiveCellAppearance=Appearance40;
            Appearance41.BackColor=SystemColors.Highlight;
            Appearance41.ForeColor=SystemColors.HighlightText;
            grdBuilders.DisplayLayout.Override.ActiveRowAppearance=Appearance41;
            grdBuilders.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            grdBuilders.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdBuilders.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            grdBuilders.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.True;
            grdBuilders.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdBuilders.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdBuilders.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdBuilders.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance42.BackColor=SystemColors.Window;
            grdBuilders.DisplayLayout.Override.CardAreaAppearance=Appearance42;
            Appearance43.BorderColor=Color.Silver;
            Appearance43.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdBuilders.DisplayLayout.Override.CellAppearance=Appearance43;
            grdBuilders.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdBuilders.DisplayLayout.Override.CellPadding=0;
            Appearance44.BackColor=SystemColors.Control;
            Appearance44.BackColor2=SystemColors.ControlDark;
            Appearance44.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance44.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance44.BorderColor=SystemColors.Window;
            grdBuilders.DisplayLayout.Override.GroupByRowAppearance=Appearance44;
            Appearance45.TextHAlignAsString="Left";
            grdBuilders.DisplayLayout.Override.HeaderAppearance=Appearance45;
            grdBuilders.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdBuilders.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance46.BackColor=SystemColors.Window;
            Appearance46.BorderColor=Color.Silver;
            grdBuilders.DisplayLayout.Override.RowAppearance=Appearance46;
            grdBuilders.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance47.ForeColor=SystemColors.HighlightText;
            Appearance47.ForeColorDisabled=SystemColors.InactiveCaptionText;
            grdBuilders.DisplayLayout.Override.SelectedRowAppearance=Appearance47;
            grdBuilders.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance48.BackColor=SystemColors.ControlLight;
            grdBuilders.DisplayLayout.Override.TemplateAddRowAppearance=Appearance48;
            grdBuilders.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdBuilders.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdBuilders.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdBuilders.Location=new Point(433, 44);
            grdBuilders.Name="grdBuilders";
            grdBuilders.Size=new Size(261, 153);
            grdBuilders.TabIndex=19;
            grdBuilders.Text="Builders";
            // 
            // ucboProject
            // 
            Appearance49.BackColor=SystemColors.Window;
            Appearance49.BorderColor=SystemColors.InactiveCaption;
            ucboProject.DisplayLayout.Appearance=Appearance49;
            UltraGridColumn9.Header.VisiblePosition=0;
            UltraGridColumn9.RowLayoutColumnInfo.OriginX=0;
            UltraGridColumn9.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn9.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn9.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn10.Header.Caption="Project Name";
            UltraGridColumn10.Header.VisiblePosition=1;
            UltraGridColumn10.RowLayoutColumnInfo.OriginX=2;
            UltraGridColumn10.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn10.RowLayoutColumnInfo.PreferredCellSize=new Size(270, 0);
            UltraGridColumn10.RowLayoutColumnInfo.SpanX=5;
            UltraGridColumn10.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn10.Width=150;
            UltraGridColumn11.Header.VisiblePosition=2;
            UltraGridColumn11.Hidden=true;
            UltraGridColumn20.Header.VisiblePosition=3;
            UltraGridColumn20.Hidden=true;
            UltraGridColumn21.Header.VisiblePosition=4;
            UltraGridColumn21.Hidden=true;
            UltraGridColumn22.Header.VisiblePosition=5;
            UltraGridColumn22.Hidden=true;
            UltraGridColumn23.Header.VisiblePosition=6;
            UltraGridColumn23.Hidden=true;
            UltraGridColumn24.Header.VisiblePosition=7;
            UltraGridColumn24.Hidden=true;
            UltraGridColumn25.Header.VisiblePosition=8;
            UltraGridColumn25.Hidden=true;
            UltraGridColumn26.Header.VisiblePosition=9;
            UltraGridColumn26.Hidden=true;
            UltraGridColumn27.Header.VisiblePosition=10;
            UltraGridColumn27.Hidden=true;
            UltraGridColumn28.Header.VisiblePosition=11;
            UltraGridColumn28.Hidden=true;
            UltraGridColumn29.Header.VisiblePosition=12;
            UltraGridColumn29.Hidden=true;
            UltraGridColumn30.Header.VisiblePosition=13;
            UltraGridColumn30.Hidden=true;
            UltraGridColumn19.Header.VisiblePosition=14;
            UltraGridColumn19.Hidden=true;
            UltraGridColumn41.Header.VisiblePosition=15;
            UltraGridColumn41.Hidden=true;
            UltraGridColumn45.Header.VisiblePosition=16;
            UltraGridColumn45.Hidden=true;
            UltraGridColumn46.Header.VisiblePosition=17;
            UltraGridColumn46.Hidden=true;
            UltraGridColumn47.Header.VisiblePosition=18;
            UltraGridColumn47.Hidden=true;
            UltraGridColumn48.Header.VisiblePosition=19;
            UltraGridColumn48.Hidden=true;
            UltraGridColumn18.Header.VisiblePosition=20;
            UltraGridColumn18.Hidden=true;
            UltraGridBand4.Columns.AddRange(new object[] { UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30, UltraGridColumn19, UltraGridColumn41, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn18 });
            UltraGridBand4.RowLayoutStyle=Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            ucboProject.DisplayLayout.BandsSerializer.Add(UltraGridBand4);
            ucboProject.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucboProject.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance50.BackColor=SystemColors.ActiveBorder;
            Appearance50.BackColor2=SystemColors.ControlDark;
            Appearance50.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance50.BorderColor=SystemColors.Window;
            ucboProject.DisplayLayout.GroupByBox.Appearance=Appearance50;
            Appearance51.ForeColor=SystemColors.GrayText;
            ucboProject.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance51;
            ucboProject.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance52.BackColor=SystemColors.ControlLightLight;
            Appearance52.BackColor2=SystemColors.Control;
            Appearance52.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance52.ForeColor=SystemColors.GrayText;
            ucboProject.DisplayLayout.GroupByBox.PromptAppearance=Appearance52;
            ucboProject.DisplayLayout.MaxColScrollRegions=1;
            ucboProject.DisplayLayout.MaxRowScrollRegions=1;
            Appearance53.BackColor=SystemColors.Window;
            Appearance53.ForeColor=SystemColors.ControlText;
            ucboProject.DisplayLayout.Override.ActiveCellAppearance=Appearance53;
            Appearance54.BackColor=SystemColors.Highlight;
            Appearance54.ForeColor=SystemColors.HighlightText;
            ucboProject.DisplayLayout.Override.ActiveRowAppearance=Appearance54;
            ucboProject.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucboProject.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance55.BackColor=SystemColors.Window;
            ucboProject.DisplayLayout.Override.CardAreaAppearance=Appearance55;
            Appearance56.BorderColor=Color.Silver;
            Appearance56.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucboProject.DisplayLayout.Override.CellAppearance=Appearance56;
            ucboProject.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucboProject.DisplayLayout.Override.CellPadding=0;
            Appearance57.BackColor=SystemColors.Control;
            Appearance57.BackColor2=SystemColors.ControlDark;
            Appearance57.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance57.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance57.BorderColor=SystemColors.Window;
            ucboProject.DisplayLayout.Override.GroupByRowAppearance=Appearance57;
            Appearance58.TextHAlignAsString="Left";
            ucboProject.DisplayLayout.Override.HeaderAppearance=Appearance58;
            ucboProject.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucboProject.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance59.BackColor=SystemColors.Window;
            Appearance59.BorderColor=Color.Silver;
            ucboProject.DisplayLayout.Override.RowAppearance=Appearance59;
            ucboProject.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance60.BackColor=SystemColors.ControlLight;
            ucboProject.DisplayLayout.Override.TemplateAddRowAppearance=Appearance60;
            ucboProject.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucboProject.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucboProject.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucboProject.Font=new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucboProject.Location=new Point(69, 44);
            ucboProject.Name="ucboProject";
            ucboProject.Size=new Size(152, 22);
            ucboProject.TabIndex=20;
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Location=new Point(16, 48);
            Label1.Name="Label1";
            Label1.Size=new Size(43, 13);
            Label1.TabIndex=22;
            Label1.Text="Project:";
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnSave, tsBtnPrint, tsBtnTip });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(999, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=30;
            tsToolStrip.Text="ToolStrip1";
            // 
            // tsBtnAdd
            // 
            tsBtnAdd.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnAdd.Enabled=false;
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
            tsBtnPrint.Image=My.Resources.Resources.Print;
            tsBtnPrint.ImageTransparentColor=Color.Magenta;
            tsBtnPrint.Name="tsBtnPrint";
            tsBtnPrint.Size=new Size(28, 28);
            tsBtnPrint.Text="Print";
            tsBtnPrint.ToolTipText="Click to Print Report";
            // 
            // tsBtnTip
            // 
            tsBtnTip.DisplayStyle=ToolStripItemDisplayStyle.Text;
            tsBtnTip.Image=(Image)resources.GetObject("tsBtnTip.Image");
            tsBtnTip.ImageTransparentColor=Color.Magenta;
            tsBtnTip.Name="tsBtnTip";
            tsBtnTip.Size=new Size(256, 28);
            tsBtnTip.Text="Click on Grid Header to Sort Columns or Apply Filter";
            // 
            // txtProjectID
            // 
            txtProjectID.Location=new Point(69, 44);
            txtProjectID.MaxLength=5;
            txtProjectID.Name="txtProjectID";
            txtProjectID.Size=new Size(100, 20);
            txtProjectID.TabIndex=53;
            txtProjectID.Visible=false;
            // 
            // ugbUtilities
            // 
            Appearance61.ForeColorDisabled=SystemColors.ControlText;
            ugbUtilities.Appearance=Appearance61;
            Appearance62.ForeColorDisabled=SystemColors.ControlText;
            ugbUtilities.ContentAreaAppearance=Appearance62;
            ugbUtilities.Controls.Add(txtCable);
            ugbUtilities.Controls.Add(Label10);
            ugbUtilities.Controls.Add(txtTelephone);
            ugbUtilities.Controls.Add(Label9);
            ugbUtilities.Controls.Add(txtPower);
            ugbUtilities.Controls.Add(txtSewerSeptic);
            ugbUtilities.Controls.Add(txtWater);
            ugbUtilities.Controls.Add(Label8);
            ugbUtilities.Controls.Add(Label7);
            ugbUtilities.Controls.Add(Label6);
            ugbUtilities.Location=new Point(7, 221);
            ugbUtilities.Name="ugbUtilities";
            ugbUtilities.Size=new Size(420, 166);
            ugbUtilities.TabIndex=54;
            ugbUtilities.Text="Utilities";
            // 
            // txtCable
            // 
            txtCable.Location=new Point(108, 127);
            txtCable.MaxLength=50;
            txtCable.Name="txtCable";
            txtCable.ReadOnly=true;
            txtCable.Size=new Size(301, 20);
            txtCable.TabIndex=61;
            // 
            // Label10
            // 
            Label10.AutoSize=true;
            Label10.Location=new Point(59, 130);
            Label10.Name="Label10";
            Label10.Size=new Size(37, 13);
            Label10.TabIndex=60;
            Label10.Text="Cable:";
            // 
            // txtTelephone
            // 
            txtTelephone.Location=new Point(108, 101);
            txtTelephone.MaxLength=50;
            txtTelephone.Name="txtTelephone";
            txtTelephone.ReadOnly=true;
            txtTelephone.Size=new Size(301, 20);
            txtTelephone.TabIndex=59;
            // 
            // Label9
            // 
            Label9.AutoSize=true;
            Label9.Location=new Point(35, 104);
            Label9.Name="Label9";
            Label9.Size=new Size(61, 13);
            Label9.TabIndex=58;
            Label9.Text="Telephone:";
            // 
            // txtPower
            // 
            txtPower.Location=new Point(108, 20);
            txtPower.MaxLength=50;
            txtPower.Name="txtPower";
            txtPower.ReadOnly=true;
            txtPower.Size=new Size(301, 20);
            txtPower.TabIndex=57;
            // 
            // txtSewerSeptic
            // 
            txtSewerSeptic.Location=new Point(108, 47);
            txtSewerSeptic.MaxLength=50;
            txtSewerSeptic.Name="txtSewerSeptic";
            txtSewerSeptic.ReadOnly=true;
            txtSewerSeptic.Size=new Size(301, 20);
            txtSewerSeptic.TabIndex=56;
            // 
            // txtWater
            // 
            txtWater.Location=new Point(108, 75);
            txtWater.MaxLength=50;
            txtWater.Name="txtWater";
            txtWater.ReadOnly=true;
            txtWater.Size=new Size(301, 20);
            txtWater.TabIndex=55;
            // 
            // Label8
            // 
            Label8.AutoSize=true;
            Label8.Location=new Point(56, 23);
            Label8.Name="Label8";
            Label8.Size=new Size(40, 13);
            Label8.TabIndex=54;
            Label8.Text="Power:";
            // 
            // Label7
            // 
            Label7.AutoSize=true;
            Label7.Location=new Point(11, 50);
            Label7.Name="Label7";
            Label7.Size=new Size(85, 13);
            Label7.TabIndex=53;
            Label7.Text="Sewer or Septic:";
            // 
            // Label6
            // 
            Label6.AutoSize=true;
            Label6.Location=new Point(57, 78);
            Label6.Name="Label6";
            Label6.Size=new Size(39, 13);
            Label6.TabIndex=52;
            Label6.Text="Water:";
            // 
            // ugbBasicInfo
            // 
            ugbBasicInfo.Controls.Add(uchkHCHOwned);
            ugbBasicInfo.Controls.Add(uchkCostPrice);
            ugbBasicInfo.Controls.Add(uchkComplete);
            ugbBasicInfo.Controls.Add(uchkReadyForReleases);
            ugbBasicInfo.Controls.Add(txtProjectName);
            ugbBasicInfo.Controls.Add(Label4);
            ugbBasicInfo.Controls.Add(txtLotCosts);
            ugbBasicInfo.Controls.Add(Label3);
            ugbBasicInfo.Controls.Add(ucboTaxPermit);
            ugbBasicInfo.Controls.Add(Label2);
            ugbBasicInfo.Location=new Point(7, 73);
            ugbBasicInfo.Name="ugbBasicInfo";
            ugbBasicInfo.Size=new Size(420, 142);
            ugbBasicInfo.TabIndex=55;
            // 
            // uchkHCHOwned
            // 
            Appearance63.BackColorDisabled=SystemColors.Control;
            Appearance63.BackColorDisabled2=SystemColors.Control;
            Appearance63.ForeColorDisabled=SystemColors.ControlText;
            Appearance63.ForegroundAlpha=Infragistics.Win.Alpha.UseAlphaLevel;
            uchkHCHOwned.Appearance=Appearance63;
            Appearance64.BackColorDisabled=SystemColors.Control;
            Appearance64.BackColorDisabled2=SystemColors.Control;
            uchkHCHOwned.CheckedAppearance=Appearance64;
            uchkHCHOwned.Enabled=false;
            uchkHCHOwned.Location=new Point(253, 67);
            uchkHCHOwned.Name="uchkHCHOwned";
            uchkHCHOwned.Size=new Size(99, 20);
            uchkHCHOwned.TabIndex=54;
            uchkHCHOwned.Text="HCHOwned";
            uchkHCHOwned.UseFlatMode=Infragistics.Win.DefaultableBoolean.False;
            // 
            // uchkCostPrice
            // 
            Appearance65.BackColorDisabled=SystemColors.Control;
            Appearance65.BackColorDisabled2=SystemColors.Control;
            Appearance65.ForeColorDisabled=SystemColors.ControlText;
            Appearance65.ForegroundAlpha=Infragistics.Win.Alpha.UseAlphaLevel;
            uchkCostPrice.Appearance=Appearance65;
            Appearance66.BackColorDisabled=SystemColors.Control;
            Appearance66.BackColorDisabled2=SystemColors.Control;
            uchkCostPrice.CheckedAppearance=Appearance66;
            uchkCostPrice.Enabled=false;
            uchkCostPrice.Location=new Point(253, 35);
            uchkCostPrice.Name="uchkCostPrice";
            uchkCostPrice.Size=new Size(131, 20);
            uchkCostPrice.TabIndex=53;
            uchkCostPrice.Text="Cost/Price Project";
            uchkCostPrice.UseFlatMode=Infragistics.Win.DefaultableBoolean.False;
            // 
            // uchkComplete
            // 
            Appearance67.BackColorDisabled=SystemColors.Control;
            Appearance67.BackColorDisabled2=SystemColors.Control;
            Appearance67.ForeColorDisabled=SystemColors.ControlText;
            Appearance67.ForegroundAlpha=Infragistics.Win.Alpha.UseAlphaLevel;
            uchkComplete.Appearance=Appearance67;
            Appearance68.BackColorDisabled=SystemColors.Control;
            Appearance68.BackColorDisabled2=SystemColors.Control;
            uchkComplete.CheckedAppearance=Appearance68;
            uchkComplete.Enabled=false;
            uchkComplete.Location=new Point(158, 36);
            uchkComplete.Name="uchkComplete";
            uchkComplete.Size=new Size(81, 20);
            uchkComplete.TabIndex=52;
            uchkComplete.Text="Complete";
            uchkComplete.UseFlatMode=Infragistics.Win.DefaultableBoolean.False;
            // 
            // uchkReadyForReleases
            // 
            Appearance69.BackColorDisabled=SystemColors.Control;
            Appearance69.BackColorDisabled2=SystemColors.Control;
            Appearance69.ForeColorDisabled=SystemColors.ControlText;
            Appearance69.ForegroundAlpha=Infragistics.Win.Alpha.UseAlphaLevel;
            uchkReadyForReleases.Appearance=Appearance69;
            Appearance70.BackColorDisabled=SystemColors.Control;
            Appearance70.BackColorDisabled2=SystemColors.Control;
            uchkReadyForReleases.CheckedAppearance=Appearance70;
            uchkReadyForReleases.Enabled=false;
            uchkReadyForReleases.Location=new Point(12, 35);
            uchkReadyForReleases.Name="uchkReadyForReleases";
            uchkReadyForReleases.Size=new Size(131, 20);
            uchkReadyForReleases.TabIndex=51;
            uchkReadyForReleases.Text="Ready For Releases";
            uchkReadyForReleases.UseFlatMode=Infragistics.Win.DefaultableBoolean.False;
            // 
            // txtProjectName
            // 
            txtProjectName.Location=new Point(88, 5);
            txtProjectName.MaxLength=50;
            txtProjectName.Name="txtProjectName";
            txtProjectName.ReadOnly=true;
            txtProjectName.Size=new Size(315, 20);
            txtProjectName.TabIndex=50;
            // 
            // Label4
            // 
            Label4.AutoSize=true;
            Label4.Location=new Point(37, 70);
            Label4.Name="Label4";
            Label4.Size=new Size(49, 13);
            Label4.TabIndex=46;
            Label4.Text="Lot Cost:";
            // 
            // txtLotCosts
            // 
            txtLotCosts.Location=new Point(92, 67);
            txtLotCosts.Name="txtLotCosts";
            txtLotCosts.ReadOnly=true;
            txtLotCosts.Size=new Size(81, 20);
            txtLotCosts.TabIndex=45;
            // 
            // Label3
            // 
            Label3.AutoSize=true;
            Label3.Location=new Point(23, 111);
            Label3.Name="Label3";
            Label3.Size=new Size(95, 13);
            Label3.TabIndex=43;
            Label3.Text="Tax Permit District:";
            // 
            // ucboTaxPermit
            // 
            Appearance71.BackColor=SystemColors.Window;
            Appearance71.BorderColor=SystemColors.InactiveCaption;
            ucboTaxPermit.DisplayLayout.Appearance=Appearance71;
            UltraGridColumn42.Header.Caption="Tax Permit District";
            UltraGridColumn42.Header.VisiblePosition=0;
            UltraGridColumn43.Header.VisiblePosition=1;
            UltraGridColumn43.Hidden=true;
            UltraGridColumn44.Header.VisiblePosition=2;
            UltraGridBand5.Columns.AddRange(new object[] { UltraGridColumn42, UltraGridColumn43, UltraGridColumn44 });
            ucboTaxPermit.DisplayLayout.BandsSerializer.Add(UltraGridBand5);
            ucboTaxPermit.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucboTaxPermit.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance72.BackColor=SystemColors.ActiveBorder;
            Appearance72.BackColor2=SystemColors.ControlDark;
            Appearance72.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance72.BorderColor=SystemColors.Window;
            ucboTaxPermit.DisplayLayout.GroupByBox.Appearance=Appearance72;
            Appearance73.ForeColor=SystemColors.GrayText;
            ucboTaxPermit.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance73;
            ucboTaxPermit.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance74.BackColor=SystemColors.ControlLightLight;
            Appearance74.BackColor2=SystemColors.Control;
            Appearance74.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance74.ForeColor=SystemColors.GrayText;
            ucboTaxPermit.DisplayLayout.GroupByBox.PromptAppearance=Appearance74;
            ucboTaxPermit.DisplayLayout.MaxColScrollRegions=1;
            ucboTaxPermit.DisplayLayout.MaxRowScrollRegions=1;
            Appearance75.BackColor=SystemColors.Window;
            Appearance75.ForeColor=SystemColors.ControlText;
            ucboTaxPermit.DisplayLayout.Override.ActiveCellAppearance=Appearance75;
            Appearance76.BackColor=SystemColors.Highlight;
            Appearance76.ForeColor=SystemColors.HighlightText;
            ucboTaxPermit.DisplayLayout.Override.ActiveRowAppearance=Appearance76;
            ucboTaxPermit.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucboTaxPermit.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance77.BackColor=SystemColors.Window;
            ucboTaxPermit.DisplayLayout.Override.CardAreaAppearance=Appearance77;
            Appearance78.BorderColor=Color.Silver;
            Appearance78.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucboTaxPermit.DisplayLayout.Override.CellAppearance=Appearance78;
            ucboTaxPermit.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucboTaxPermit.DisplayLayout.Override.CellPadding=0;
            Appearance79.BackColor=SystemColors.Control;
            Appearance79.BackColor2=SystemColors.ControlDark;
            Appearance79.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance79.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance79.BorderColor=SystemColors.Window;
            ucboTaxPermit.DisplayLayout.Override.GroupByRowAppearance=Appearance79;
            Appearance80.TextHAlignAsString="Left";
            ucboTaxPermit.DisplayLayout.Override.HeaderAppearance=Appearance80;
            ucboTaxPermit.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucboTaxPermit.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance81.BackColor=SystemColors.Window;
            Appearance81.BorderColor=Color.Silver;
            ucboTaxPermit.DisplayLayout.Override.RowAppearance=Appearance81;
            ucboTaxPermit.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance82.BackColor=SystemColors.ControlLight;
            ucboTaxPermit.DisplayLayout.Override.TemplateAddRowAppearance=Appearance82;
            ucboTaxPermit.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucboTaxPermit.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucboTaxPermit.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucboTaxPermit.DisplayMember="TaxPermitDistrict";
            ucboTaxPermit.Font=new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucboTaxPermit.Location=new Point(124, 106);
            ucboTaxPermit.Name="ucboTaxPermit";
            ucboTaxPermit.ReadOnly=true;
            ucboTaxPermit.Size=new Size(279, 22);
            ucboTaxPermit.TabIndex=41;
            ucboTaxPermit.ValueMember="TaxPermitID";
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Location=new Point(48, 6);
            Label2.Name="Label2";
            Label2.Size=new Size(38, 13);
            Label2.TabIndex=42;
            Label2.Text="Name:";
            // 
            // ugbMoreInfo
            // 
            ugbMoreInfo.Controls.Add(txtModelPhone);
            ugbMoreInfo.Controls.Add(Label14);
            ugbMoreInfo.Controls.Add(txtDrivingDirections);
            ugbMoreInfo.Controls.Add(Label13);
            ugbMoreInfo.Controls.Add(txtSetbacksBuffers);
            ugbMoreInfo.Controls.Add(Label12);
            ugbMoreInfo.Controls.Add(Label11);
            ugbMoreInfo.Controls.Add(ucboTitleIns);
            ugbMoreInfo.Location=new Point(8, 403);
            ugbMoreInfo.Name="ugbMoreInfo";
            ugbMoreInfo.Size=new Size(419, 172);
            ugbMoreInfo.TabIndex=56;
            ugbMoreInfo.Text="More Information";
            // 
            // txtModelPhone
            // 
            txtModelPhone.Location=new Point(109, 56);
            txtModelPhone.MaxLength=25;
            txtModelPhone.Name="txtModelPhone";
            txtModelPhone.ReadOnly=true;
            txtModelPhone.Size=new Size(159, 20);
            txtModelPhone.TabIndex=65;
            // 
            // Label14
            // 
            Label14.AutoSize=true;
            Label14.Location=new Point(23, 59);
            Label14.Name="Label14";
            Label14.Size=new Size(80, 13);
            Label14.TabIndex=64;
            Label14.Text="Model Phone#:";
            // 
            // txtDrivingDirections
            // 
            txtDrivingDirections.Location=new Point(109, 123);
            txtDrivingDirections.MaxLength=2000;
            txtDrivingDirections.Multiline=true;
            txtDrivingDirections.Name="txtDrivingDirections";
            txtDrivingDirections.ReadOnly=true;
            txtDrivingDirections.ScrollBars=ScrollBars.Vertical;
            txtDrivingDirections.Size=new Size(301, 35);
            txtDrivingDirections.TabIndex=63;
            // 
            // Label13
            // 
            Label13.AutoSize=true;
            Label13.Location=new Point(8, 126);
            Label13.Name="Label13";
            Label13.Size=new Size(90, 13);
            Label13.TabIndex=62;
            Label13.Text="Driving Directions";
            // 
            // txtSetbacksBuffers
            // 
            txtSetbacksBuffers.Location=new Point(109, 82);
            txtSetbacksBuffers.MaxLength=250;
            txtSetbacksBuffers.Multiline=true;
            txtSetbacksBuffers.Name="txtSetbacksBuffers";
            txtSetbacksBuffers.ReadOnly=true;
            txtSetbacksBuffers.Size=new Size(301, 35);
            txtSetbacksBuffers.TabIndex=61;
            // 
            // Label12
            // 
            Label12.AutoSize=true;
            Label12.Location=new Point(8, 85);
            Label12.Name="Label12";
            Label12.Size=new Size(93, 13);
            Label12.TabIndex=60;
            Label12.Text="Setbacks/Buffers:";
            // 
            // Label11
            // 
            Label11.AutoSize=true;
            Label11.Location=new Point(8, 28);
            Label11.Name="Label11";
            Label11.Size=new Size(96, 13);
            Label11.TabIndex=59;
            Label11.Text="Title Insurance Co:";
            // 
            // ucboTitleIns
            // 
            Appearance83.BackColor=SystemColors.Window;
            Appearance83.BorderColor=SystemColors.InactiveCaption;
            ucboTitleIns.DisplayLayout.Appearance=Appearance83;
            ucboTitleIns.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucboTitleIns.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance84.BackColor=SystemColors.ActiveBorder;
            Appearance84.BackColor2=SystemColors.ControlDark;
            Appearance84.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance84.BorderColor=SystemColors.Window;
            ucboTitleIns.DisplayLayout.GroupByBox.Appearance=Appearance84;
            Appearance85.ForeColor=SystemColors.GrayText;
            ucboTitleIns.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance85;
            ucboTitleIns.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance86.BackColor=SystemColors.ControlLightLight;
            Appearance86.BackColor2=SystemColors.Control;
            Appearance86.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance86.ForeColor=SystemColors.GrayText;
            ucboTitleIns.DisplayLayout.GroupByBox.PromptAppearance=Appearance86;
            ucboTitleIns.DisplayLayout.MaxColScrollRegions=1;
            ucboTitleIns.DisplayLayout.MaxRowScrollRegions=1;
            Appearance87.BackColor=SystemColors.Window;
            Appearance87.ForeColor=SystemColors.ControlText;
            ucboTitleIns.DisplayLayout.Override.ActiveCellAppearance=Appearance87;
            Appearance88.BackColor=SystemColors.Highlight;
            Appearance88.ForeColor=SystemColors.HighlightText;
            ucboTitleIns.DisplayLayout.Override.ActiveRowAppearance=Appearance88;
            ucboTitleIns.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucboTitleIns.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance89.BackColor=SystemColors.Window;
            ucboTitleIns.DisplayLayout.Override.CardAreaAppearance=Appearance89;
            Appearance90.BorderColor=Color.Silver;
            Appearance90.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucboTitleIns.DisplayLayout.Override.CellAppearance=Appearance90;
            ucboTitleIns.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucboTitleIns.DisplayLayout.Override.CellPadding=0;
            Appearance91.BackColor=SystemColors.Control;
            Appearance91.BackColor2=SystemColors.ControlDark;
            Appearance91.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance91.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance91.BorderColor=SystemColors.Window;
            ucboTitleIns.DisplayLayout.Override.GroupByRowAppearance=Appearance91;
            Appearance92.TextHAlignAsString="Left";
            ucboTitleIns.DisplayLayout.Override.HeaderAppearance=Appearance92;
            ucboTitleIns.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucboTitleIns.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance93.BackColor=SystemColors.Window;
            Appearance93.BorderColor=Color.Silver;
            ucboTitleIns.DisplayLayout.Override.RowAppearance=Appearance93;
            ucboTitleIns.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance94.BackColor=SystemColors.ControlLight;
            ucboTitleIns.DisplayLayout.Override.TemplateAddRowAppearance=Appearance94;
            ucboTitleIns.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucboTitleIns.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucboTitleIns.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucboTitleIns.DisplayMember="CompanyName";
            ucboTitleIns.Font=new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucboTitleIns.Location=new Point(109, 24);
            ucboTitleIns.Name="ucboTitleIns";
            ucboTitleIns.ReadOnly=true;
            ucboTitleIns.Size=new Size(279, 22);
            ucboTitleIns.TabIndex=58;
            ucboTitleIns.ValueMember="CompanyID";
            // 
            // Label5
            // 
            Label5.Location=new Point(709, 53);
            Label5.Name="Label5";
            Label5.Size=new Size(174, 39);
            Label5.TabIndex=57;
            Label5.Text="To remove a builder, select the row, and press the Delete key";
            // 
            // Label15
            // 
            Label15.Location=new Point(771, 158);
            Label15.Name="Label15";
            Label15.Size=new Size(174, 39);
            Label15.TabIndex=58;
            Label15.Text="To remove an NSM, Click Edit, select the row, and enter an End Date";
            // 
            // ProjectMaintenance
            // 
            AutoScaleDimensions=new SizeF(6.0f, 13.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(999, 746);
            Controls.Add(Label15);
            Controls.Add(Label5);
            Controls.Add(ugbMoreInfo);
            Controls.Add(ugbBasicInfo);
            Controls.Add(ugbUtilities);
            Controls.Add(tsToolStrip);
            Controls.Add(Label1);
            Controls.Add(ucboProject);
            Controls.Add(grdBuilders);
            Controls.Add(grdPlanPrices);
            Controls.Add(grdNSM);
            Controls.Add(txtProjectID);
            Name="ProjectMaintenance";
            Text="Project Maintenance";
            ((System.ComponentModel.ISupportInitialize)grdNSM).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdPlanPrices).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdBuilders).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucboProject).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ugbUtilities).EndInit();
            ugbUtilities.ResumeLayout(false);
            ugbUtilities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ugbBasicInfo).EndInit();
            ugbBasicInfo.ResumeLayout(false);
            ugbBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uchkHCHOwned).EndInit();
            ((System.ComponentModel.ISupportInitialize)uchkCostPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)uchkComplete).EndInit();
            ((System.ComponentModel.ISupportInitialize)uchkReadyForReleases).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucboTaxPermit).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugbMoreInfo).EndInit();
            ugbMoreInfo.ResumeLayout(false);
            ugbMoreInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ucboTitleIns).EndInit();
            Load+=new EventHandler(ProjectMaintenance_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdNSM;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdPlanPrices;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdBuilders;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucboProject;
        internal Label Label1;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnTip;
        internal TextBox txtProjectID;
        internal Infragistics.Win.Misc.UltraGroupBox ugbUtilities;
        internal TextBox txtCable;
        internal Label Label10;
        internal TextBox txtTelephone;
        internal Label Label9;
        internal TextBox txtPower;
        internal TextBox txtSewerSeptic;
        internal TextBox txtWater;
        internal Label Label8;
        internal Label Label7;
        internal Label Label6;
        internal Infragistics.Win.Misc.UltraGroupBox ugbBasicInfo;
        internal TextBox txtProjectName;
        internal Label Label4;
        internal TextBox txtLotCosts;
        internal Label Label3;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucboTaxPermit;
        internal Label Label2;
        internal Infragistics.Win.Misc.UltraGroupBox ugbMoreInfo;
        internal TextBox txtModelPhone;
        internal Label Label14;
        internal TextBox txtDrivingDirections;
        internal Label Label13;
        internal TextBox txtSetbacksBuffers;
        internal Label Label12;
        internal Label Label11;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucboTitleIns;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkReadyForReleases;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkHCHOwned;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkCostPrice;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uchkComplete;
        internal Label Label5;
        internal Label Label15;
    }
}