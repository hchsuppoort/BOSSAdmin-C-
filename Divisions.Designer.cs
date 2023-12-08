using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Divisions : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DivisionID", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Division");
            var UltraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DivisionManagerID");
            var UltraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProductionManagerID");
            var UltraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SalesManagerID");
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
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UserName");
            var UltraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SIID");
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
            var UltraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UserName");
            var UltraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SIID");
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
            var UltraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UserName");
            var UltraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SIID");
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Divisions));
            var Appearance49 = new Infragistics.Win.Appearance();
            var Appearance50 = new Infragistics.Win.Appearance();
            var Appearance51 = new Infragistics.Win.Appearance();
            var UltraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("NSM", -1);
            var UltraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SIID", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StartDate");
            var UltraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("EndDate");
            var UltraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Inactive");
            var UltraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("fName");
            var UltraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lName");
            var UltraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("nsmName");
            var UltraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DivisionNSMID", 0);
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
            var Appearance62 = new Infragistics.Win.Appearance();
            var Appearance63 = new Infragistics.Win.Appearance();
            var Appearance64 = new Infragistics.Win.Appearance();
            grdDivisions=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdDivisions.AfterSelectChange+=new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(grdDivisions_AfterSelectChange);
            uCboDivisionManagers=new Infragistics.Win.UltraWinGrid.UltraCombo();
            uCboDivisionManagers.AfterCloseUp+=new EventHandler(uCboDivisionManagers_AfterCloseUp);
            uCboDivisionManagers.BeforeDropDown+=new System.ComponentModel.CancelEventHandler(uCboDivisionManagers_BeforeDropDown);
            uCboProductionManagers=new Infragistics.Win.UltraWinGrid.UltraCombo();
            uCboProductionManagers.AfterCloseUp+=new EventHandler(uCboProductionManagers_AfterCloseUp);
            uCboProductionManagers.BeforeDropDown+=new System.ComponentModel.CancelEventHandler(uCboProductionManagers_BeforeDropDown);
            ucboSalesManagers=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ucboSalesManagers.AfterCloseUp+=new EventHandler(ucboSalesManagers_AfterCloseUp);
            ucboSalesManagers.BeforeDropDown+=new System.ComponentModel.CancelEventHandler(ucboSalesManagers_BeforeDropDown);
            Label1=new Label();
            Label2=new Label();
            Label3=new Label();
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnAdd.Click+=new EventHandler(tsBtnAdd_Click);
            tsBtnEdit=new ToolStripButton();
            tsBtnEdit.Click+=new EventHandler(tsBtnEdit_Click);
            tsBtnUndo=new ToolStripButton();
            tsBtnUndo.Click+=new EventHandler(tsBtnUndo_Click);
            tsBtnSave=new ToolStripButton();
            tsBtnSave.Click+=new EventHandler(tsBtnSave_Click);
            tsBtnPrint=new ToolStripButton();
            tsBtnTip=new ToolStripButton();
            grdNSM=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdNSM.BeforeCellActivate+=new Infragistics.Win.UltraWinGrid.CancelableCellEventHandler(grdNSM_BeforeCellActivate);
            grdNSM.BeforeRowInsert+=new Infragistics.Win.UltraWinGrid.BeforeRowInsertEventHandler(grdNSM_BeforeRowInsert);
            grdNSM.BeforeSelectChange+=new Infragistics.Win.UltraWinGrid.BeforeSelectChangeEventHandler(grdNSM_afterSelectChange);
            grdNSM.InitializeLayout+=new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(grdNSM_InitializeLayout);
            ((System.ComponentModel.ISupportInitialize)grdDivisions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uCboDivisionManagers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uCboProductionManagers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucboSalesManagers).BeginInit();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdNSM).BeginInit();
            SuspendLayout();
            // 
            // grdDivisions
            // 
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            grdDivisions.DisplayLayout.Appearance=Appearance1;
            UltraGridBand1.ColHeadersVisible=false;
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridColumn1.Hidden=true;
            UltraGridColumn2.Header.VisiblePosition=1;
            UltraGridColumn2.Width=250;
            UltraGridColumn7.Header.VisiblePosition=2;
            UltraGridColumn7.Hidden=true;
            UltraGridColumn10.Header.VisiblePosition=3;
            UltraGridColumn10.Hidden=true;
            UltraGridColumn11.Header.VisiblePosition=4;
            UltraGridColumn11.Hidden=true;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn1, UltraGridColumn2, UltraGridColumn7, UltraGridColumn10, UltraGridColumn11 });
            UltraGridBand1.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdDivisions.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            grdDivisions.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdDivisions.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            grdDivisions.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            grdDivisions.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            grdDivisions.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdDivisions.DisplayLayout.GroupByBox.Hidden=true;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            grdDivisions.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            grdDivisions.DisplayLayout.MaxColScrollRegions=1;
            grdDivisions.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            grdDivisions.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            grdDivisions.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            grdDivisions.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            grdDivisions.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdDivisions.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            grdDivisions.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdDivisions.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdDivisions.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdDivisions.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            grdDivisions.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdDivisions.DisplayLayout.Override.CellAppearance=Appearance8;
            grdDivisions.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdDivisions.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            grdDivisions.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            grdDivisions.DisplayLayout.Override.HeaderAppearance=Appearance10;
            grdDivisions.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdDivisions.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            grdDivisions.DisplayLayout.Override.RowAppearance=Appearance11;
            grdDivisions.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdDivisions.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance12.BackColor=SystemColors.ControlLight;
            grdDivisions.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            grdDivisions.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdDivisions.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdDivisions.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdDivisions.Location=new Point(16, 59);
            grdDivisions.Margin=new Padding(4);
            grdDivisions.MinimumSize=new Size(233, 0);
            grdDivisions.Name="grdDivisions";
            grdDivisions.Size=new Size(233, 268);
            grdDivisions.TabIndex=2;
            grdDivisions.Text="Divisions";
            // 
            // uCboDivisionManagers
            // 
            uCboDivisionManagers.AutoCompleteMode=Infragistics.Win.AutoCompleteMode.SuggestAppend;
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            uCboDivisionManagers.DisplayLayout.Appearance=Appearance13;
            UltraGridBand2.ColHeadersVisible=false;
            UltraGridColumn9.Header.VisiblePosition=0;
            UltraGridColumn4.Header.VisiblePosition=1;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn9, UltraGridColumn4 });
            uCboDivisionManagers.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            uCboDivisionManagers.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            uCboDivisionManagers.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            uCboDivisionManagers.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            uCboDivisionManagers.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            uCboDivisionManagers.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            uCboDivisionManagers.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            uCboDivisionManagers.DisplayLayout.MaxColScrollRegions=1;
            uCboDivisionManagers.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            uCboDivisionManagers.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            uCboDivisionManagers.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            uCboDivisionManagers.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            uCboDivisionManagers.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            uCboDivisionManagers.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            uCboDivisionManagers.DisplayLayout.Override.CellAppearance=Appearance20;
            uCboDivisionManagers.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            uCboDivisionManagers.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            uCboDivisionManagers.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            uCboDivisionManagers.DisplayLayout.Override.HeaderAppearance=Appearance22;
            uCboDivisionManagers.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            uCboDivisionManagers.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            uCboDivisionManagers.DisplayLayout.Override.RowAppearance=Appearance23;
            uCboDivisionManagers.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance24.BackColor=SystemColors.ControlLight;
            uCboDivisionManagers.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            uCboDivisionManagers.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            uCboDivisionManagers.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            uCboDivisionManagers.DisplayLayout.ViewStyle=Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            uCboDivisionManagers.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            uCboDivisionManagers.Location=new Point(472, 59);
            uCboDivisionManagers.Margin=new Padding(4);
            uCboDivisionManagers.Name="uCboDivisionManagers";
            uCboDivisionManagers.ReadOnly=true;
            uCboDivisionManagers.Size=new Size(269, 25);
            uCboDivisionManagers.TabIndex=9;
            // 
            // uCboProductionManagers
            // 
            uCboProductionManagers.AutoCompleteMode=Infragistics.Win.AutoCompleteMode.SuggestAppend;
            Appearance25.BackColor=SystemColors.Window;
            Appearance25.BorderColor=SystemColors.InactiveCaption;
            uCboProductionManagers.DisplayLayout.Appearance=Appearance25;
            UltraGridColumn3.Header.VisiblePosition=0;
            UltraGridColumn6.Header.VisiblePosition=1;
            UltraGridBand3.Columns.AddRange(new object[] { UltraGridColumn3, UltraGridColumn6 });
            uCboProductionManagers.DisplayLayout.BandsSerializer.Add(UltraGridBand3);
            uCboProductionManagers.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            uCboProductionManagers.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance26.BackColor=SystemColors.ActiveBorder;
            Appearance26.BackColor2=SystemColors.ControlDark;
            Appearance26.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance26.BorderColor=SystemColors.Window;
            uCboProductionManagers.DisplayLayout.GroupByBox.Appearance=Appearance26;
            Appearance27.ForeColor=SystemColors.GrayText;
            uCboProductionManagers.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance27;
            uCboProductionManagers.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance28.BackColor=SystemColors.ControlLightLight;
            Appearance28.BackColor2=SystemColors.Control;
            Appearance28.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance28.ForeColor=SystemColors.GrayText;
            uCboProductionManagers.DisplayLayout.GroupByBox.PromptAppearance=Appearance28;
            uCboProductionManagers.DisplayLayout.MaxColScrollRegions=1;
            uCboProductionManagers.DisplayLayout.MaxRowScrollRegions=1;
            Appearance29.BackColor=SystemColors.Window;
            Appearance29.ForeColor=SystemColors.ControlText;
            uCboProductionManagers.DisplayLayout.Override.ActiveCellAppearance=Appearance29;
            Appearance30.BackColor=SystemColors.Highlight;
            Appearance30.ForeColor=SystemColors.HighlightText;
            uCboProductionManagers.DisplayLayout.Override.ActiveRowAppearance=Appearance30;
            uCboProductionManagers.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            uCboProductionManagers.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance31.BackColor=SystemColors.Window;
            uCboProductionManagers.DisplayLayout.Override.CardAreaAppearance=Appearance31;
            Appearance32.BorderColor=Color.Silver;
            Appearance32.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            uCboProductionManagers.DisplayLayout.Override.CellAppearance=Appearance32;
            uCboProductionManagers.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            uCboProductionManagers.DisplayLayout.Override.CellPadding=0;
            Appearance33.BackColor=SystemColors.Control;
            Appearance33.BackColor2=SystemColors.ControlDark;
            Appearance33.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance33.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance33.BorderColor=SystemColors.Window;
            uCboProductionManagers.DisplayLayout.Override.GroupByRowAppearance=Appearance33;
            Appearance34.TextHAlignAsString="Left";
            uCboProductionManagers.DisplayLayout.Override.HeaderAppearance=Appearance34;
            uCboProductionManagers.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            uCboProductionManagers.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance35.BackColor=SystemColors.Window;
            Appearance35.BorderColor=Color.Silver;
            uCboProductionManagers.DisplayLayout.Override.RowAppearance=Appearance35;
            uCboProductionManagers.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance36.BackColor=SystemColors.ControlLight;
            uCboProductionManagers.DisplayLayout.Override.TemplateAddRowAppearance=Appearance36;
            uCboProductionManagers.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            uCboProductionManagers.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            uCboProductionManagers.DisplayLayout.ViewStyle=Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            uCboProductionManagers.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            uCboProductionManagers.Location=new Point(472, 103);
            uCboProductionManagers.Margin=new Padding(4);
            uCboProductionManagers.Name="uCboProductionManagers";
            uCboProductionManagers.ReadOnly=true;
            uCboProductionManagers.Size=new Size(269, 25);
            uCboProductionManagers.TabIndex=10;
            // 
            // ucboSalesManagers
            // 
            ucboSalesManagers.AutoCompleteMode=Infragistics.Win.AutoCompleteMode.SuggestAppend;
            Appearance37.BackColor=SystemColors.Window;
            Appearance37.BorderColor=SystemColors.InactiveCaption;
            ucboSalesManagers.DisplayLayout.Appearance=Appearance37;
            UltraGridColumn5.Header.VisiblePosition=0;
            UltraGridColumn8.Header.VisiblePosition=1;
            UltraGridBand4.Columns.AddRange(new object[] { UltraGridColumn5, UltraGridColumn8 });
            ucboSalesManagers.DisplayLayout.BandsSerializer.Add(UltraGridBand4);
            ucboSalesManagers.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucboSalesManagers.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance38.BackColor=SystemColors.ActiveBorder;
            Appearance38.BackColor2=SystemColors.ControlDark;
            Appearance38.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance38.BorderColor=SystemColors.Window;
            ucboSalesManagers.DisplayLayout.GroupByBox.Appearance=Appearance38;
            Appearance39.ForeColor=SystemColors.GrayText;
            ucboSalesManagers.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance39;
            ucboSalesManagers.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance40.BackColor=SystemColors.ControlLightLight;
            Appearance40.BackColor2=SystemColors.Control;
            Appearance40.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance40.ForeColor=SystemColors.GrayText;
            ucboSalesManagers.DisplayLayout.GroupByBox.PromptAppearance=Appearance40;
            ucboSalesManagers.DisplayLayout.MaxColScrollRegions=1;
            ucboSalesManagers.DisplayLayout.MaxRowScrollRegions=1;
            Appearance41.BackColor=SystemColors.Window;
            Appearance41.ForeColor=SystemColors.ControlText;
            ucboSalesManagers.DisplayLayout.Override.ActiveCellAppearance=Appearance41;
            Appearance42.BackColor=SystemColors.Highlight;
            Appearance42.ForeColor=SystemColors.HighlightText;
            ucboSalesManagers.DisplayLayout.Override.ActiveRowAppearance=Appearance42;
            ucboSalesManagers.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucboSalesManagers.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance43.BackColor=SystemColors.Window;
            ucboSalesManagers.DisplayLayout.Override.CardAreaAppearance=Appearance43;
            Appearance44.BorderColor=Color.Silver;
            Appearance44.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucboSalesManagers.DisplayLayout.Override.CellAppearance=Appearance44;
            ucboSalesManagers.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucboSalesManagers.DisplayLayout.Override.CellPadding=0;
            Appearance45.BackColor=SystemColors.Control;
            Appearance45.BackColor2=SystemColors.ControlDark;
            Appearance45.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance45.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance45.BorderColor=SystemColors.Window;
            ucboSalesManagers.DisplayLayout.Override.GroupByRowAppearance=Appearance45;
            Appearance46.TextHAlignAsString="Left";
            ucboSalesManagers.DisplayLayout.Override.HeaderAppearance=Appearance46;
            ucboSalesManagers.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucboSalesManagers.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance47.BackColor=SystemColors.Window;
            Appearance47.BorderColor=Color.Silver;
            ucboSalesManagers.DisplayLayout.Override.RowAppearance=Appearance47;
            ucboSalesManagers.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance48.BackColor=SystemColors.ControlLight;
            ucboSalesManagers.DisplayLayout.Override.TemplateAddRowAppearance=Appearance48;
            ucboSalesManagers.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucboSalesManagers.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucboSalesManagers.DisplayLayout.ViewStyle=Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            ucboSalesManagers.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucboSalesManagers.Location=new Point(472, 149);
            ucboSalesManagers.Margin=new Padding(4);
            ucboSalesManagers.Name="ucboSalesManagers";
            ucboSalesManagers.ReadOnly=true;
            ucboSalesManagers.Size=new Size(269, 25);
            ucboSalesManagers.TabIndex=11;
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Location=new Point(335, 65);
            Label1.Margin=new Padding(4, 0, 4, 0);
            Label1.Name="Label1";
            Label1.Size=new Size(121, 17);
            Label1.TabIndex=12;
            Label1.Text="Division Manager:";
            Label1.TextAlign=ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Location=new Point(316, 110);
            Label2.Margin=new Padding(4, 0, 4, 0);
            Label2.Name="Label2";
            Label2.Size=new Size(140, 17);
            Label2.TabIndex=13;
            Label2.Text="Production Manager:";
            Label2.TextAlign=ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.AutoSize=true;
            Label3.Location=new Point(349, 155);
            Label3.Margin=new Padding(4, 0, 4, 0);
            Label3.Name="Label3";
            Label3.Size=new Size(107, 17);
            Label3.TabIndex=14;
            Label3.Text="Sales Manager:";
            Label3.TextAlign=ContentAlignment.MiddleRight;
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnSave, tsBtnPrint, tsBtnTip });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(985, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=15;
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
            tsBtnTip.Size=new Size(358, 28);
            tsBtnTip.Text="Click on Grid Header to Sort Columns or Apply Filter";
            // 
            // grdNSM
            // 
            Appearance49.BackColor=SystemColors.Control;
            Appearance49.ForeColor=SystemColors.MenuText;
            Appearance49.ForeColorDisabled=SystemColors.MenuHighlight;
            grdNSM.DisplayLayout.AddNewBox.Appearance=Appearance49;
            Appearance50.BackColor=SystemColors.Window;
            Appearance50.ForeColor=SystemColors.MenuText;
            Appearance50.ForeColorDisabled=SystemColors.MenuHighlight;
            Appearance50.ForegroundAlpha=Infragistics.Win.Alpha.Opaque;
            grdNSM.DisplayLayout.AddNewBox.ButtonAppearance=Appearance50;
            grdNSM.DisplayLayout.AddNewBox.Prompt="Add New ...";
            Appearance51.BackColor=SystemColors.Window;
            Appearance51.BorderColor=SystemColors.InactiveCaption;
            Appearance51.ForeColorDisabled=SystemColors.ControlText;
            grdNSM.DisplayLayout.Appearance=Appearance51;
            UltraGridBand5.AddButtonCaption="Add New NSM";
            UltraGridColumn12.Header.VisiblePosition=0;
            UltraGridColumn13.Header.VisiblePosition=1;
            UltraGridColumn14.Header.VisiblePosition=2;
            UltraGridColumn15.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn15.Header.VisiblePosition=3;
            UltraGridColumn16.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn16.Header.VisiblePosition=4;
            UltraGridColumn17.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn17.Header.VisiblePosition=5;
            UltraGridColumn18.Header.VisiblePosition=6;
            UltraGridColumn19.Header.VisiblePosition=7;
            UltraGridColumn19.Hidden=true;
            UltraGridBand5.Columns.AddRange(new object[] { UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19 });
            Appearance52.ForeColor=SystemColors.HighlightText;
            UltraGridBand5.Override.ActiveRowAppearance=Appearance52;
            grdNSM.DisplayLayout.BandsSerializer.Add(UltraGridBand5);
            grdNSM.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNSM.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance53.BackColor=SystemColors.ActiveBorder;
            Appearance53.BackColor2=SystemColors.ControlDark;
            Appearance53.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance53.BorderColor=SystemColors.Window;
            grdNSM.DisplayLayout.GroupByBox.Appearance=Appearance53;
            Appearance54.ForeColor=SystemColors.GrayText;
            grdNSM.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance54;
            grdNSM.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNSM.DisplayLayout.GroupByBox.Hidden=true;
            Appearance55.BackColor=SystemColors.ControlLightLight;
            Appearance55.BackColor2=SystemColors.Control;
            Appearance55.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance55.ForeColor=SystemColors.GrayText;
            grdNSM.DisplayLayout.GroupByBox.PromptAppearance=Appearance55;
            grdNSM.DisplayLayout.MaxColScrollRegions=1;
            grdNSM.DisplayLayout.MaxRowScrollRegions=1;
            Appearance56.BackColor=SystemColors.Window;
            Appearance56.ForeColor=SystemColors.HighlightText;
            grdNSM.DisplayLayout.Override.ActiveCellAppearance=Appearance56;
            Appearance57.BackColor=SystemColors.Highlight;
            Appearance57.ForeColor=SystemColors.HighlightText;
            grdNSM.DisplayLayout.Override.ActiveRowAppearance=Appearance57;
            grdNSM.DisplayLayout.Override.AddRowEditNotificationInterface=Infragistics.Win.UltraWinGrid.AddRowEditNotificationInterface.ICancelAddNewAndIEditableObject;
            grdNSM.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.FixedAddRowOnTop;
            grdNSM.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdNSM.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            grdNSM.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdNSM.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdNSM.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.True;
            grdNSM.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdNSM.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance58.BackColor=SystemColors.Window;
            grdNSM.DisplayLayout.Override.CardAreaAppearance=Appearance58;
            Appearance59.BorderColor=Color.Silver;
            Appearance59.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdNSM.DisplayLayout.Override.CellAppearance=Appearance59;
            grdNSM.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            grdNSM.DisplayLayout.Override.CellPadding=0;
            Appearance60.BackColor=SystemColors.Control;
            Appearance60.BackColor2=SystemColors.ControlDark;
            Appearance60.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance60.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance60.BorderColor=SystemColors.Window;
            grdNSM.DisplayLayout.Override.GroupByRowAppearance=Appearance60;
            Appearance61.TextHAlignAsString="Left";
            grdNSM.DisplayLayout.Override.HeaderAppearance=Appearance61;
            grdNSM.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdNSM.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            grdNSM.DisplayLayout.Override.Key="DivisionNSMId";
            Appearance62.BackColor=SystemColors.Window;
            Appearance62.BorderColor=Color.Silver;
            grdNSM.DisplayLayout.Override.RowAppearance=Appearance62;
            grdNSM.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance63.ForeColor=SystemColors.HighlightText;
            Appearance63.ForeColorDisabled=SystemColors.InactiveCaptionText;
            grdNSM.DisplayLayout.Override.SelectedRowAppearance=Appearance63;
            grdNSM.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance64.BackColor=SystemColors.ControlLight;
            grdNSM.DisplayLayout.Override.TemplateAddRowAppearance=Appearance64;
            grdNSM.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdNSM.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdNSM.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdNSM.Location=new Point(442, 210);
            grdNSM.Margin=new Padding(4);
            grdNSM.Name="grdNSM";
            grdNSM.Size=new Size(520, 370);
            grdNSM.TabIndex=16;
            grdNSM.Text="NSM's";
            // 
            // Divisions
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(985, 607);
            Controls.Add(grdNSM);
            Controls.Add(tsToolStrip);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(ucboSalesManagers);
            Controls.Add(uCboProductionManagers);
            Controls.Add(grdDivisions);
            Controls.Add(uCboDivisionManagers);
            Margin=new Padding(4);
            Name="Divisions";
            Text="Division Maintenance";
            ((System.ComponentModel.ISupportInitialize)grdDivisions).EndInit();
            ((System.ComponentModel.ISupportInitialize)uCboDivisionManagers).EndInit();
            ((System.ComponentModel.ISupportInitialize)uCboProductionManagers).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucboSalesManagers).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdNSM).EndInit();
            Load+=new EventHandler(Divisions_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdDivisions;
        internal Infragistics.Win.UltraWinGrid.UltraCombo uCboDivisionManagers;
        internal Infragistics.Win.UltraWinGrid.UltraCombo uCboProductionManagers;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucboSalesManagers;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnTip;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdNSM;
    }
}