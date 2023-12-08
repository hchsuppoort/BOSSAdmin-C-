using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class EstimateView : Form
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
            var Appearance1 = new Infragistics.Win.Appearance();
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetJobDetails", -1);
            var UltraGridColumn37 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("id");
            var UltraGridColumn38 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("JobID");
            var UltraGridColumn39 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceID");
            var UltraGridColumn40 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceName");
            var UltraGridColumn41 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActivityCode");
            var UltraGridColumn43 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResUsage");
            var UltraGridColumn44 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UM");
            var UltraGridColumn45 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetQty");
            var UltraGridColumn46 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetCostID");
            var UltraGridColumn47 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetCost");
            var UltraGridColumn48 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExtdCost", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn49 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VendorID");
            var UltraGridColumn50 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PONumber");
            var UltraGridColumn51 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PurchQty");
            var UltraGridColumn52 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PurchCostID");
            var UltraGridColumn53 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PurchCost");
            var UltraGridColumn54 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("COId");
            var UltraGridColumn55 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ReviewLevel");
            var UltraGridColumn56 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ReviewedDate");
            var UltraGridColumn57 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ReviewedBy");
            var UltraGridColumn58 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Approved");
            var UltraGridColumn59 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CancelledDate");
            var UltraGridColumn60 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedDate");
            var UltraGridColumn61 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy");
            var UltraGridColumn62 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedDate");
            var UltraGridColumn63 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedBy");
            var UltraGridColumn64 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetExtdCost");
            var UltraGridColumn65 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetTax");
            var UltraGridColumn66 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PurchExtdCost");
            var UltraGridColumn67 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PurchTax");
            var UltraGridColumn68 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activity");
            var UltraGridColumn69 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Source");
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
            var UltraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("JobID");
            var UltraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("JobName");
            var UltraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ID");
            var UltraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlanID");
            var UltraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ReleaseToCad");
            var Appearance13 = new Infragistics.Win.Appearance();
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAllJobs", -1);
            var UltraGridColumn70 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("JobID");
            var UltraGridColumn71 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("JobName");
            var UltraGridColumn72 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn73 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanID");
            var UltraGridColumn74 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ReleaseToCad");
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
            var Appearance26 = new Infragistics.Win.Appearance();
            UltraGrid1=new Infragistics.Win.UltraWinGrid.UltraGrid();
            SpGetJobDetailsBindingSource=new BindingSource(components);
            HCHDataQAJobDetails=new HCHDataQAJobDetails();
            HCHDataQADataSet1=new HCHDataQADataSet1();
            SpGetAllJobsBindingSource=new BindingSource(components);
            SpGetAllJobsTableAdapter=new HCHDataQADataSet1TableAdapters.spGetAllJobsTableAdapter();
            UltraDataSource1=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            SpGetJobDetailsTableAdapter=new HCHDataQAJobDetailsTableAdapters.spGetJobDetailsTableAdapter();
            ucJobs=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ucJobs.RowSelected+=new Infragistics.Win.UltraWinGrid.RowSelectedEventHandler(ucJobs_RowSelected);
            ulPlanID=new Infragistics.Win.Misc.UltraLabel();
            Label1=new Label();
            btnApplyCosts=new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetJobDetailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQAJobDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQADataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAllJobsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucJobs).BeginInit();
            SuspendLayout();
            // 
            // UltraGrid1
            // 
            UltraGrid1.DataSource=SpGetJobDetailsBindingSource;
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            UltraGrid1.DisplayLayout.Appearance=Appearance1;
            UltraGridColumn37.Header.VisiblePosition=0;
            UltraGridColumn37.Hidden=true;
            UltraGridColumn38.Header.VisiblePosition=1;
            UltraGridColumn38.Hidden=true;
            UltraGridColumn39.Header.VisiblePosition=4;
            UltraGridColumn39.Width=118;
            UltraGridColumn40.Header.Caption="Resource Name";
            UltraGridColumn40.Header.VisiblePosition=5;
            UltraGridColumn40.Width=189;
            UltraGridColumn41.Header.Caption="Activity Code";
            UltraGridColumn41.Header.VisiblePosition=2;
            UltraGridColumn41.Width=84;
            UltraGridColumn43.Header.Caption="Use Code";
            UltraGridColumn43.Header.VisiblePosition=6;
            UltraGridColumn43.Width=67;
            UltraGridColumn44.Header.VisiblePosition=7;
            UltraGridColumn44.Width=67;
            UltraGridColumn45.Header.Caption="Budget Qty";
            UltraGridColumn45.Header.VisiblePosition=8;
            UltraGridColumn45.Width=57;
            UltraGridColumn46.Header.VisiblePosition=9;
            UltraGridColumn46.Hidden=true;
            UltraGridColumn47.Header.Caption="Budget Cost";
            UltraGridColumn47.Header.VisiblePosition=10;
            UltraGridColumn47.Width=62;
            UltraGridColumn48.Header.Caption="Extd Cost";
            UltraGridColumn48.Header.VisiblePosition=13;
            UltraGridColumn48.Hidden=true;
            UltraGridColumn49.Header.VisiblePosition=16;
            UltraGridColumn49.Hidden=true;
            UltraGridColumn50.Header.VisiblePosition=15;
            UltraGridColumn50.Hidden=true;
            UltraGridColumn51.Header.VisiblePosition=17;
            UltraGridColumn51.Hidden=true;
            UltraGridColumn52.Header.VisiblePosition=18;
            UltraGridColumn52.Hidden=true;
            UltraGridColumn53.Header.VisiblePosition=19;
            UltraGridColumn53.Hidden=true;
            UltraGridColumn54.Header.VisiblePosition=20;
            UltraGridColumn54.Hidden=true;
            UltraGridColumn55.Header.VisiblePosition=21;
            UltraGridColumn55.Hidden=true;
            UltraGridColumn56.Header.VisiblePosition=22;
            UltraGridColumn56.Hidden=true;
            UltraGridColumn57.Header.VisiblePosition=23;
            UltraGridColumn57.Hidden=true;
            UltraGridColumn58.Header.VisiblePosition=24;
            UltraGridColumn58.Hidden=true;
            UltraGridColumn59.Header.Caption="Cancelled Date";
            UltraGridColumn59.Header.VisiblePosition=25;
            UltraGridColumn59.Width=71;
            UltraGridColumn60.Header.Caption="Created Date";
            UltraGridColumn60.Header.VisiblePosition=26;
            UltraGridColumn60.Width=77;
            UltraGridColumn61.Header.Caption="Created By";
            UltraGridColumn61.Header.VisiblePosition=27;
            UltraGridColumn61.Width=68;
            UltraGridColumn62.Header.Caption="Updated Date";
            UltraGridColumn62.Header.VisiblePosition=28;
            UltraGridColumn62.Width=80;
            UltraGridColumn63.Header.Caption="Updated By";
            UltraGridColumn63.Header.VisiblePosition=29;
            UltraGridColumn63.Width=71;
            UltraGridColumn64.Header.Caption="Budget Extd Cost";
            UltraGridColumn64.Header.VisiblePosition=11;
            UltraGridColumn64.Width=71;
            UltraGridColumn65.Header.Caption="Budget Tax";
            UltraGridColumn65.Header.VisiblePosition=12;
            UltraGridColumn65.Width=55;
            UltraGridColumn66.Header.VisiblePosition=30;
            UltraGridColumn66.Hidden=true;
            UltraGridColumn67.Header.VisiblePosition=31;
            UltraGridColumn67.Hidden=true;
            UltraGridColumn68.Header.VisiblePosition=3;
            UltraGridColumn68.Width=175;
            UltraGridColumn69.Header.VisiblePosition=14;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn37, UltraGridColumn38, UltraGridColumn39, UltraGridColumn40, UltraGridColumn41, UltraGridColumn43, UltraGridColumn44, UltraGridColumn45, UltraGridColumn46, UltraGridColumn47, UltraGridColumn48, UltraGridColumn49, UltraGridColumn50, UltraGridColumn51, UltraGridColumn52, UltraGridColumn53, UltraGridColumn54, UltraGridColumn55, UltraGridColumn56, UltraGridColumn57, UltraGridColumn58, UltraGridColumn59, UltraGridColumn60, UltraGridColumn61, UltraGridColumn62, UltraGridColumn63, UltraGridColumn64, UltraGridColumn65, UltraGridColumn66, UltraGridColumn67, UltraGridColumn68, UltraGridColumn69 });
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
            UltraGrid1.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            UltraGrid1.DisplayLayout.Override.AllowGroupBy=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            UltraGrid1.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            UltraGrid1.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            UltraGrid1.DisplayLayout.Override.CellAppearance=Appearance8;
            UltraGrid1.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            UltraGrid1.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            UltraGrid1.DisplayLayout.Override.HeaderAppearance=Appearance10;
            UltraGrid1.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            UltraGrid1.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            UltraGrid1.DisplayLayout.Override.RowAppearance=Appearance11;
            UltraGrid1.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance12.BackColor=SystemColors.ControlLight;
            UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            UltraGrid1.DisplayLayout.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            UltraGrid1.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            UltraGrid1.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            UltraGrid1.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraGrid1.Location=new Point(12, 102);
            UltraGrid1.Name="UltraGrid1";
            UltraGrid1.Size=new Size(1478, 662);
            UltraGrid1.TabIndex=0;
            UltraGrid1.Text="UltraGrid1";
            // 
            // SpGetJobDetailsBindingSource
            // 
            SpGetJobDetailsBindingSource.DataMember="spGetJobDetails";
            SpGetJobDetailsBindingSource.DataSource=HCHDataQAJobDetails;
            // 
            // HCHDataQAJobDetails
            // 
            HCHDataQAJobDetails.DataSetName="HCHDataQAJobDetails";
            HCHDataQAJobDetails.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // HCHDataQADataSet1
            // 
            HCHDataQADataSet1.DataSetName="HCHDataQADataSet1";
            HCHDataQADataSet1.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // SpGetAllJobsBindingSource
            // 
            SpGetAllJobsBindingSource.DataMember="spGetAllJobs";
            SpGetAllJobsBindingSource.DataSource=HCHDataQADataSet1;
            // 
            // SpGetAllJobsTableAdapter
            // 
            SpGetAllJobsTableAdapter.ClearBeforeFill=true;
            // 
            // UltraDataSource1
            // 
            UltraDataColumn3.DataType=typeof(int);
            UltraDataColumn5.DataType=typeof(DateTime);
            UltraDataSource1.Band.Columns.AddRange(new object[] { UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5 });
            UltraDataSource1.Band.Key="spGetAllJobs";
            // 
            // SpGetJobDetailsTableAdapter
            // 
            SpGetJobDetailsTableAdapter.ClearBeforeFill=true;
            // 
            // ucJobs
            // 
            ucJobs.DataSource=SpGetAllJobsBindingSource;
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            ucJobs.DisplayLayout.Appearance=Appearance13;
            UltraGridColumn70.Header.VisiblePosition=0;
            UltraGridColumn71.Header.VisiblePosition=1;
            UltraGridColumn72.Header.VisiblePosition=2;
            UltraGridColumn72.Hidden=true;
            UltraGridColumn73.Header.VisiblePosition=3;
            UltraGridColumn74.Header.VisiblePosition=4;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn70, UltraGridColumn71, UltraGridColumn72, UltraGridColumn73, UltraGridColumn74 });
            ucJobs.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            ucJobs.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucJobs.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            ucJobs.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            ucJobs.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            ucJobs.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            ucJobs.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            ucJobs.DisplayLayout.MaxColScrollRegions=1;
            ucJobs.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            ucJobs.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            ucJobs.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            ucJobs.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucJobs.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            ucJobs.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucJobs.DisplayLayout.Override.CellAppearance=Appearance20;
            ucJobs.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucJobs.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            ucJobs.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            ucJobs.DisplayLayout.Override.HeaderAppearance=Appearance22;
            ucJobs.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucJobs.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            ucJobs.DisplayLayout.Override.RowAppearance=Appearance23;
            ucJobs.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance24.BackColor=SystemColors.ControlLight;
            ucJobs.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            ucJobs.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucJobs.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucJobs.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucJobs.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucJobs.Location=new Point(12, 13);
            ucJobs.Name="ucJobs";
            ucJobs.Size=new Size(188, 25);
            ucJobs.TabIndex=1;
            // 
            // ulPlanID
            // 
            Appearance25.TextVAlignAsString="Middle";
            ulPlanID.Appearance=Appearance25;
            ulPlanID.Location=new Point(281, 17);
            ulPlanID.Name="ulPlanID";
            ulPlanID.Size=new Size(85, 23);
            ulPlanID.TabIndex=2;
            ulPlanID.Text="UltraLabel1";
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Location=new Point(222, 17);
            Label1.Name="Label1";
            Label1.Size=new Size(53, 17);
            Label1.TabIndex=3;
            Label1.Text="PlanID:";
            Label1.TextAlign=ContentAlignment.MiddleRight;
            // 
            // btnApplyCosts
            // 
            Appearance26.Image=My.Resources.Resources.Dollar;
            btnApplyCosts.Appearance=Appearance26;
            btnApplyCosts.ImageSize=new Size(32, 32);
            btnApplyCosts.ImageTransparentColor=Color.White;
            btnApplyCosts.Location=new Point(1257, 13);
            btnApplyCosts.Name="btnApplyCosts";
            btnApplyCosts.Size=new Size(121, 36);
            btnApplyCosts.TabIndex=5;
            btnApplyCosts.Text="Apply Cost";
            // 
            // EstimateView
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1422, 846);
            Controls.Add(btnApplyCosts);
            Controls.Add(Label1);
            Controls.Add(ulPlanID);
            Controls.Add(ucJobs);
            Controls.Add(UltraGrid1);
            Name="EstimateView";
            Text="EstimateView";
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetJobDetailsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQAJobDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataQADataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAllJobsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucJobs).EndInit();
            Load+=new EventHandler(EstimateView_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
        internal HCHDataQADataSet1 HCHDataQADataSet1;
        internal BindingSource SpGetAllJobsBindingSource;
        internal HCHDataQADataSet1TableAdapters.spGetAllJobsTableAdapter SpGetAllJobsTableAdapter;
        internal Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource1;
        internal BindingSource SpGetJobDetailsBindingSource;
        internal HCHDataQAJobDetails HCHDataQAJobDetails;
        internal HCHDataQAJobDetailsTableAdapters.spGetJobDetailsTableAdapter SpGetJobDetailsTableAdapter;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucJobs;
        internal Infragistics.Win.Misc.UltraLabel ulPlanID;
        internal Label Label1;
        internal Infragistics.Win.Misc.UltraButton btnApplyCosts;
    }
}