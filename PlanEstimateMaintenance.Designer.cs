using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PlanEstimateTablesMaintenance : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("vwPlanEstimatePlanExteriors", -1);
            var UltraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanGroup");
            var UltraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Elevation", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorID");
            var UltraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorName");
            var UltraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorShortName");
            var GridBagConstraint3 = new Infragistics.Win.Layout.GridBagConstraint();
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spPlanEstimatesGet", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanEstimateID");
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanGroup");
            var UltraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Elevation");
            var UltraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Exterior");
            var UltraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ExteriorID");
            var UltraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceID");
            var UltraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceName");
            var UltraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActivityCode");
            var UltraGridColumn9 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Activity");
            var UltraGridColumn10 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResUsage", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn11 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetQty");
            var Appearance1 = new Infragistics.Win.Appearance();
            var UltraGridColumn12 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedDate");
            var UltraGridColumn13 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy");
            var UltraGridColumn14 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedDate");
            var UltraGridColumn15 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Notes");
            var UltraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedBy");
            var RowLayout1 = new Infragistics.Win.UltraWinGrid.RowLayout("test");
            var RowLayoutColumnInfo1 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PlanEstimateID", -1, Infragistics.Win.DefaultableBoolean.True);
            var RowLayoutColumnInfo2 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "PlanGroup", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo3 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Elevation", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo4 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Exterior", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo5 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ExteriorID", -1, Infragistics.Win.DefaultableBoolean.True);
            var RowLayoutColumnInfo6 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ResourceID", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo7 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ResourceName", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo8 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ActivityCode", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo9 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Activity", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo10 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "ResUsage", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo11 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "BudgetQty", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo12 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CreatedDate", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo13 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "CreatedBy", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo14 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UpdatedDate", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo15 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "Notes", -1, Infragistics.Win.DefaultableBoolean.False);
            var RowLayoutColumnInfo16 = new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo(Infragistics.Win.UltraWinGrid.RowLayoutColumnInfoContext.Column, "UpdatedBy", -1, Infragistics.Win.DefaultableBoolean.False);
            var GridBagConstraint2 = new Infragistics.Win.Layout.GridBagConstraint();
            var ButtonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Edit");
            var ButtonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Undo");
            var ButtonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Edit");
            var ButtonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Undo");
            var GridBagConstraint4 = new Infragistics.Win.Layout.GridBagConstraint();
            var GridBagConstraint1 = new Infragistics.Win.Layout.GridBagConstraint();
            ugPlanGroups=new Infragistics.Win.UltraWinGrid.UltraGrid();
            ugPlanGroups.AfterSelectChange+=new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(ugPlanGroups_AfterSelectChange);
            ugPlanGroups.InitializeLayout+=new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(ugPlanGroups_InitializeLayout);
            HCHDataPlanEstimateBindingSource=new BindingSource(components);
            HCHDataPlanEstimate=new HCHDataPlanEstimate();
            ugPlanEstimateDetail=new Infragistics.Win.UltraWinGrid.UltraGrid();
            ugPlanEstimateDetail.AfterRowsDeleted+=new EventHandler(ugPlanEstimateDetail_AfterRowsDeleted);
            ugPlanEstimateDetail.AfterRowUpdate+=new Infragistics.Win.UltraWinGrid.RowEventHandler(ugPlanEstimateDetail_AfterRowUpdate);
            SpPlanEstimatesGetBindingSource=new BindingSource(components);
            DsDetail=new dsDetail();
            UltraToolbarsManager1=new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(components);
            PlanEstimateTablesMaintenance_Fill_Panel=new Infragistics.Win.Misc.UltraPanel();
            btnPopulateDetail=new Button();
            btnPopulateDetail.Click+=new EventHandler(btnPopulateDetail_Click1);
            UltraPanel3=new Infragistics.Win.Misc.UltraPanel();
            Label2=new Label();
            Label1=new Label();
            UltraPanel1=new Infragistics.Win.Misc.UltraPanel();
            btnAddRows=new Button();
            btnAddRows.Click+=new EventHandler(btnAddRows_Click1);
            btnAddPlan=new Button();
            btnAddPlan.Click+=new EventHandler(btnAddPlan_Click);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            UltraGridBagLayoutManager1=new Infragistics.Win.Misc.UltraGridBagLayoutManager(components);
            SpPlanEstimatesGetTableAdapter=new dsDetailTableAdapters.spPlanEstimatesGetTableAdapter();
            VwPlanEstimatePlanExteriorsTableAdapter1=new HCHDataPlanEstimateTableAdapters.vwPlanEstimatePlanExteriorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)ugPlanGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanEstimateBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanEstimate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugPlanEstimateDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpPlanEstimatesGetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DsDetail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraToolbarsManager1).BeginInit();
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.SuspendLayout();
            PlanEstimateTablesMaintenance_Fill_Panel.SuspendLayout();
            UltraPanel3.ClientArea.SuspendLayout();
            UltraPanel3.SuspendLayout();
            UltraPanel1.ClientArea.SuspendLayout();
            UltraPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UltraGridBagLayoutManager1).BeginInit();
            SuspendLayout();
            // 
            // ugPlanGroups
            // 
            ugPlanGroups.DataSource=HCHDataPlanEstimateBindingSource;
            UltraGridColumn17.Header.Caption="Plan";
            UltraGridColumn17.Header.VisiblePosition=0;
            UltraGridColumn17.Width=62;
            UltraGridColumn18.Header.VisiblePosition=2;
            UltraGridColumn18.Width=85;
            UltraGridColumn19.Header.VisiblePosition=1;
            UltraGridColumn19.Hidden=true;
            UltraGridColumn20.Header.Caption="Exterior";
            UltraGridColumn20.Header.VisiblePosition=4;
            UltraGridColumn20.Width=145;
            UltraGridColumn21.Header.Caption="Exterior Code";
            UltraGridColumn21.Header.VisiblePosition=3;
            UltraGridColumn21.Width=66;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21 });
            UltraGridBand1.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.True;
            ugPlanGroups.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            ugPlanGroups.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            ugPlanGroups.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ugPlanGroups.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            ugPlanGroups.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ugPlanGroups.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GridBagConstraint3.Anchor=Infragistics.Win.Layout.AnchorType.TopLeft;
            GridBagConstraint3.Fill=Infragistics.Win.Layout.FillType.Both;
            GridBagConstraint3.Insets.Right=5;
            GridBagConstraint3.OriginX=0;
            GridBagConstraint3.OriginY=1;
            UltraGridBagLayoutManager1.SetGridBagConstraint(ugPlanGroups, GridBagConstraint3);
            ugPlanGroups.Location=new Point(5, 57);
            ugPlanGroups.MaximumSize=new Size(395, 653);
            ugPlanGroups.Name="ugPlanGroups";
            UltraGridBagLayoutManager1.SetPreferredSize(ugPlanGroups, new Size(395, 653));
            ugPlanGroups.Size=new Size(395, 653);
            ugPlanGroups.TabIndex=0;
            ugPlanGroups.Text="Plan Groups";
            // 
            // HCHDataPlanEstimateBindingSource
            // 
            HCHDataPlanEstimateBindingSource.DataMember="vwPlanEstimatePlanExteriors";
            HCHDataPlanEstimateBindingSource.DataSource=HCHDataPlanEstimate;
            // 
            // HCHDataPlanEstimate
            // 
            HCHDataPlanEstimate.DataSetName="HCHDataPlanEstimate";
            HCHDataPlanEstimate.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // ugPlanEstimateDetail
            // 
            ugPlanEstimateDetail.DataSource=SpPlanEstimatesGetBindingSource;
            UltraGridBand2.AddButtonCaption="Add Plan Estimate Detail";
            UltraGridBand2.ColHeaderLines=2;
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridColumn1.Hidden=true;
            UltraGridColumn1.RowLayoutColumnInfo.OriginX=0;
            UltraGridColumn1.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn1.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn1.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn2.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn2.Header.Caption="Plan";
            UltraGridColumn2.Header.VisiblePosition=1;
            UltraGridColumn2.RowLayoutColumnInfo.OriginX=0;
            UltraGridColumn2.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn2.RowLayoutColumnInfo.PreferredCellSize=new Size(50, 0);
            UltraGridColumn2.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn2.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn2.Width=62;
            UltraGridColumn3.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn3.Header.Caption="Elev";
            UltraGridColumn3.Header.VisiblePosition=2;
            UltraGridColumn3.RowLayoutColumnInfo.OriginX=2;
            UltraGridColumn3.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn3.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn3.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn3.Width=37;
            UltraGridColumn4.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn4.Header.Caption="Ext";
            UltraGridColumn4.Header.VisiblePosition=3;
            UltraGridColumn4.RowLayoutColumnInfo.OriginX=4;
            UltraGridColumn4.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn4.RowLayoutColumnInfo.PreferredCellSize=new Size(58, 0);
            UltraGridColumn4.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn4.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn4.Width=49;
            UltraGridColumn5.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn5.Header.VisiblePosition=6;
            UltraGridColumn5.Hidden=true;
            UltraGridColumn5.RowLayoutColumnInfo.OriginX=9;
            UltraGridColumn5.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn5.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn5.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn6.Header.Caption="Resource";
            UltraGridColumn6.Header.VisiblePosition=7;
            UltraGridColumn6.RowLayoutColumnInfo.OriginX=9;
            UltraGridColumn6.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn6.RowLayoutColumnInfo.PreferredCellSize=new Size(134, 0);
            UltraGridColumn6.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn6.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn6.Width=135;
            UltraGridColumn7.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn7.Header.Caption="Resource Name";
            UltraGridColumn7.Header.VisiblePosition=8;
            UltraGridColumn7.RowLayoutColumnInfo.OriginX=11;
            UltraGridColumn7.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn7.RowLayoutColumnInfo.PreferredCellSize=new Size(175, 0);
            UltraGridColumn7.RowLayoutColumnInfo.SpanX=3;
            UltraGridColumn7.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn7.Width=221;
            UltraGridColumn8.Header.Caption="Activity Code";
            UltraGridColumn8.Header.VisiblePosition=4;
            UltraGridColumn8.RowLayoutColumnInfo.OriginX=6;
            UltraGridColumn8.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn8.RowLayoutColumnInfo.PreferredCellSize=new Size(58, 0);
            UltraGridColumn8.RowLayoutColumnInfo.SpanX=1;
            UltraGridColumn8.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn8.Width=66;
            UltraGridColumn9.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn9.Header.VisiblePosition=5;
            UltraGridColumn9.RowLayoutColumnInfo.OriginX=7;
            UltraGridColumn9.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn9.RowLayoutColumnInfo.PreferredCellSize=new Size(236, 0);
            UltraGridColumn9.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn9.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn9.Width=275;
            UltraGridColumn10.Header.Caption="Use Code";
            UltraGridColumn10.Header.VisiblePosition=9;
            UltraGridColumn10.RowLayoutColumnInfo.OriginX=14;
            UltraGridColumn10.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn10.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn10.RowLayoutColumnInfo.SpanY=2;
            Appearance1.TextHAlignAsString="Right";
            UltraGridColumn11.CellAppearance=Appearance1;
            UltraGridColumn11.Header.Caption="Qty";
            UltraGridColumn11.Header.VisiblePosition=10;
            UltraGridColumn11.RowLayoutColumnInfo.OriginX=16;
            UltraGridColumn11.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn11.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn11.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn11.Width=59;
            UltraGridColumn12.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn12.Format="MM/dd/yy";
            UltraGridColumn12.Header.Caption="Created";
            UltraGridColumn12.Header.VisiblePosition=12;
            UltraGridColumn12.RowLayoutColumnInfo.OriginX=18;
            UltraGridColumn12.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn12.RowLayoutColumnInfo.PreferredCellSize=new Size(76, 0);
            UltraGridColumn12.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn12.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn12.Width=64;
            UltraGridColumn13.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn13.Header.Caption="Created By";
            UltraGridColumn13.Header.VisiblePosition=13;
            UltraGridColumn13.RowLayoutColumnInfo.OriginX=20;
            UltraGridColumn13.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn13.RowLayoutColumnInfo.PreferredCellSize=new Size(82, 0);
            UltraGridColumn13.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn13.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn13.Width=79;
            UltraGridColumn14.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn14.Format="MM/dd/yy";
            UltraGridColumn14.Header.Caption="Updated";
            UltraGridColumn14.Header.VisiblePosition=14;
            UltraGridColumn14.RowLayoutColumnInfo.OriginX=22;
            UltraGridColumn14.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn14.RowLayoutColumnInfo.PreferredCellSize=new Size(72, 0);
            UltraGridColumn14.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn14.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn14.Width=62;
            UltraGridColumn15.Header.VisiblePosition=11;
            UltraGridColumn15.RowLayoutColumnInfo.OriginX=26;
            UltraGridColumn15.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn15.RowLayoutColumnInfo.PreferredCellSize=new Size(357, 0);
            UltraGridColumn15.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn15.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn15.Width=308;
            UltraGridColumn16.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn16.Header.Caption="Updated By";
            UltraGridColumn16.Header.VisiblePosition=15;
            UltraGridColumn16.RowLayoutColumnInfo.OriginX=24;
            UltraGridColumn16.RowLayoutColumnInfo.OriginY=0;
            UltraGridColumn16.RowLayoutColumnInfo.PreferredCellSize=new Size(80, 0);
            UltraGridColumn16.RowLayoutColumnInfo.SpanX=2;
            UltraGridColumn16.RowLayoutColumnInfo.SpanY=2;
            UltraGridColumn16.Width=66;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7, UltraGridColumn8, UltraGridColumn9, UltraGridColumn10, UltraGridColumn11, UltraGridColumn12, UltraGridColumn13, UltraGridColumn14, UltraGridColumn15, UltraGridColumn16 });
            UltraGridBand2.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            UltraGridBand2.Override.AllowGroupBy=Infragistics.Win.DefaultableBoolean.True;
            UltraGridBand2.Override.AllowGroupSwapping=Infragistics.Win.UltraWinGrid.AllowGroupSwapping.NotAllowed;
            UltraGridBand2.Override.AllowMultiCellOperations=Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste;
            UltraGridBand2.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.True;
            UltraGridBand2.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.False;
            RowLayoutColumnInfo1.OriginX=0;
            RowLayoutColumnInfo1.OriginY=0;
            RowLayoutColumnInfo1.SpanX=2;
            RowLayoutColumnInfo1.SpanY=2;
            RowLayoutColumnInfo2.OriginX=0;
            RowLayoutColumnInfo2.OriginY=0;
            RowLayoutColumnInfo2.PreferredCellSize=new Size(50, 0);
            RowLayoutColumnInfo2.SpanX=2;
            RowLayoutColumnInfo2.SpanY=2;
            RowLayoutColumnInfo3.OriginX=2;
            RowLayoutColumnInfo3.OriginY=0;
            RowLayoutColumnInfo3.SpanX=2;
            RowLayoutColumnInfo3.SpanY=2;
            RowLayoutColumnInfo4.OriginX=4;
            RowLayoutColumnInfo4.OriginY=0;
            RowLayoutColumnInfo4.PreferredCellSize=new Size(58, 0);
            RowLayoutColumnInfo4.SpanX=2;
            RowLayoutColumnInfo4.SpanY=2;
            RowLayoutColumnInfo5.OriginX=9;
            RowLayoutColumnInfo5.OriginY=0;
            RowLayoutColumnInfo5.SpanX=2;
            RowLayoutColumnInfo5.SpanY=2;
            RowLayoutColumnInfo6.OriginX=9;
            RowLayoutColumnInfo6.OriginY=0;
            RowLayoutColumnInfo6.PreferredCellSize=new Size(134, 0);
            RowLayoutColumnInfo6.SpanX=2;
            RowLayoutColumnInfo6.SpanY=2;
            RowLayoutColumnInfo7.OriginX=11;
            RowLayoutColumnInfo7.OriginY=0;
            RowLayoutColumnInfo7.PreferredCellSize=new Size(175, 0);
            RowLayoutColumnInfo7.SpanX=3;
            RowLayoutColumnInfo7.SpanY=2;
            RowLayoutColumnInfo8.OriginX=6;
            RowLayoutColumnInfo8.OriginY=0;
            RowLayoutColumnInfo8.PreferredCellSize=new Size(58, 0);
            RowLayoutColumnInfo8.SpanX=1;
            RowLayoutColumnInfo8.SpanY=2;
            RowLayoutColumnInfo9.OriginX=7;
            RowLayoutColumnInfo9.OriginY=0;
            RowLayoutColumnInfo9.PreferredCellSize=new Size(236, 0);
            RowLayoutColumnInfo9.SpanX=2;
            RowLayoutColumnInfo9.SpanY=2;
            RowLayoutColumnInfo10.OriginX=14;
            RowLayoutColumnInfo10.OriginY=0;
            RowLayoutColumnInfo10.SpanX=2;
            RowLayoutColumnInfo10.SpanY=2;
            RowLayoutColumnInfo11.OriginX=16;
            RowLayoutColumnInfo11.OriginY=0;
            RowLayoutColumnInfo11.SpanX=2;
            RowLayoutColumnInfo11.SpanY=2;
            RowLayoutColumnInfo12.OriginX=18;
            RowLayoutColumnInfo12.OriginY=0;
            RowLayoutColumnInfo12.PreferredCellSize=new Size(76, 0);
            RowLayoutColumnInfo12.SpanX=2;
            RowLayoutColumnInfo12.SpanY=2;
            RowLayoutColumnInfo13.OriginX=20;
            RowLayoutColumnInfo13.OriginY=0;
            RowLayoutColumnInfo13.PreferredCellSize=new Size(82, 0);
            RowLayoutColumnInfo13.SpanX=2;
            RowLayoutColumnInfo13.SpanY=2;
            RowLayoutColumnInfo14.OriginX=22;
            RowLayoutColumnInfo14.OriginY=0;
            RowLayoutColumnInfo14.PreferredCellSize=new Size(72, 0);
            RowLayoutColumnInfo14.SpanX=2;
            RowLayoutColumnInfo14.SpanY=2;
            RowLayoutColumnInfo15.OriginX=26;
            RowLayoutColumnInfo15.OriginY=0;
            RowLayoutColumnInfo15.PreferredCellSize=new Size(357, 0);
            RowLayoutColumnInfo15.SpanX=2;
            RowLayoutColumnInfo15.SpanY=2;
            RowLayoutColumnInfo16.OriginX=24;
            RowLayoutColumnInfo16.OriginY=0;
            RowLayoutColumnInfo16.PreferredCellSize=new Size(80, 0);
            RowLayoutColumnInfo16.SpanX=2;
            RowLayoutColumnInfo16.SpanY=2;
            RowLayout1.ColumnInfos.AddRange(new Infragistics.Win.UltraWinGrid.RowLayoutColumnInfo[] { RowLayoutColumnInfo1, RowLayoutColumnInfo2, RowLayoutColumnInfo3, RowLayoutColumnInfo4, RowLayoutColumnInfo5, RowLayoutColumnInfo6, RowLayoutColumnInfo7, RowLayoutColumnInfo8, RowLayoutColumnInfo9, RowLayoutColumnInfo10, RowLayoutColumnInfo11, RowLayoutColumnInfo12, RowLayoutColumnInfo13, RowLayoutColumnInfo14, RowLayoutColumnInfo15, RowLayoutColumnInfo16 });
            RowLayout1.RowLayoutStyle=Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            UltraGridBand2.RowLayouts.AddRange(new Infragistics.Win.UltraWinGrid.RowLayout[] { RowLayout1 });
            ugPlanEstimateDetail.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            ugPlanEstimateDetail.DisplayLayout.Override.ActiveAppearancesEnabled=Infragistics.Win.DefaultableBoolean.True;
            ugPlanEstimateDetail.DisplayLayout.Override.AddRowEditNotificationInterface=Infragistics.Win.UltraWinGrid.AddRowEditNotificationInterface.ICancelAddNewAndIEditableObject;
            ugPlanEstimateDetail.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ugPlanEstimateDetail.DisplayLayout.Override.AllowGroupBy=Infragistics.Win.DefaultableBoolean.True;
            ugPlanEstimateDetail.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            ugPlanEstimateDetail.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.True;
            ugPlanEstimateDetail.DisplayLayout.Override.Key="PlanEstimateID";
            ugPlanEstimateDetail.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            ugPlanEstimateDetail.DisplayLayout.Override.WrapHeaderText=Infragistics.Win.DefaultableBoolean.True;
            ugPlanEstimateDetail.DisplayLayout.UseFixedHeaders=true;
            ugPlanEstimateDetail.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            GridBagConstraint2.Anchor=Infragistics.Win.Layout.AnchorType.TopLeft;
            GridBagConstraint2.Fill=Infragistics.Win.Layout.FillType.Both;
            GridBagConstraint2.Insets.Left=5;
            GridBagConstraint2.Insets.Top=5;
            GridBagConstraint2.OriginX=1;
            GridBagConstraint2.OriginY=1;
            UltraGridBagLayoutManager1.SetGridBagConstraint(ugPlanEstimateDetail, GridBagConstraint2);
            ugPlanEstimateDetail.Location=new Point(412, 62);
            ugPlanEstimateDetail.Name="ugPlanEstimateDetail";
            UltraGridBagLayoutManager1.SetPreferredSize(ugPlanEstimateDetail, new Size(1369, 653));
            ugPlanEstimateDetail.Size=new Size(1377, 658);
            ugPlanEstimateDetail.TabIndex=1;
            ugPlanEstimateDetail.Text="Plan Estimate Detail";
            // 
            // SpPlanEstimatesGetBindingSource
            // 
            SpPlanEstimatesGetBindingSource.DataMember="spPlanEstimatesGet";
            SpPlanEstimatesGetBindingSource.DataSource=DsDetail;
            // 
            // DsDetail
            // 
            DsDetail.DataSetName="dsDetail";
            DsDetail.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // UltraToolbarsManager1
            // 
            UltraToolbarsManager1.DesignerFlags=1;
            UltraToolbarsManager1.DockWithinContainer=this;
            UltraToolbarsManager1.DockWithinContainerBaseType=typeof(Form);
            UltraToolbarsManager1.MiniToolbar.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { ButtonTool1, ButtonTool2 });
            ButtonTool3.SharedPropsInternal.Caption="Edit";
            ButtonTool4.SharedPropsInternal.Caption="Undo";
            UltraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { ButtonTool3, ButtonTool4 });
            // 
            // PlanEstimateTablesMaintenance_Fill_Panel
            // 
            // 
            // PlanEstimateTablesMaintenance_Fill_Panel.ClientArea
            // 
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(btnPopulateDetail);
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(UltraPanel3);
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(UltraPanel1);
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(ugPlanEstimateDetail);
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.Controls.Add(ugPlanGroups);
            PlanEstimateTablesMaintenance_Fill_Panel.Cursor=Cursors.Default;
            PlanEstimateTablesMaintenance_Fill_Panel.Dock=DockStyle.Fill;
            PlanEstimateTablesMaintenance_Fill_Panel.Location=new Point(0, 0);
            PlanEstimateTablesMaintenance_Fill_Panel.Name="PlanEstimateTablesMaintenance_Fill_Panel";
            PlanEstimateTablesMaintenance_Fill_Panel.Size=new Size(1794, 725);
            PlanEstimateTablesMaintenance_Fill_Panel.TabIndex=0;
            // 
            // btnPopulateDetail
            // 
            btnPopulateDetail.Location=new Point(119, 12);
            btnPopulateDetail.Name="btnPopulateDetail";
            btnPopulateDetail.Size=new Size(174, 37);
            btnPopulateDetail.TabIndex=8;
            btnPopulateDetail.Text="Populate Detail Grid";
            btnPopulateDetail.UseVisualStyleBackColor=true;
            // 
            // UltraPanel3
            // 
            // 
            // UltraPanel3.ClientArea
            // 
            UltraPanel3.ClientArea.Controls.Add(Label2);
            UltraPanel3.ClientArea.Controls.Add(Label1);
            GridBagConstraint4.Anchor=Infragistics.Win.Layout.AnchorType.TopLeft;
            GridBagConstraint4.OriginX=1;
            GridBagConstraint4.OriginY=0;
            UltraGridBagLayoutManager1.SetGridBagConstraint(UltraPanel3, GridBagConstraint4);
            UltraPanel3.Location=new Point(407, 5);
            UltraPanel3.Name="UltraPanel3";
            UltraPanel3.Size=new Size(867, 52);
            UltraPanel3.TabIndex=7;
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Location=new Point(5, 26);
            Label2.Name="Label2";
            Label2.Size=new Size(688, 17);
            Label2.TabIndex=1;
            Label2.Text="To Group a grid, drag the headers for that column into the Group Box.  To Ungroup"+", drag Header out of box";
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Location=new Point(5, 5);
            Label1.Name="Label1";
            Label1.Size=new Size(824, 17);
            Label1.TabIndex=0;
            Label1.Text="To Populate Grid, expand the Plan Group for the Plan or Plans you want to view.  "+"Select the rows, then press Populate Detail Grid";
            // 
            // UltraPanel1
            // 
            // 
            // UltraPanel1.ClientArea
            // 
            UltraPanel1.ClientArea.Controls.Add(btnAddRows);
            UltraPanel1.ClientArea.Controls.Add(btnAddPlan);
            GridBagConstraint1.Anchor=Infragistics.Win.Layout.AnchorType.TopRight;
            GridBagConstraint1.OriginX=1;
            GridBagConstraint1.OriginY=0;
            UltraGridBagLayoutManager1.SetGridBagConstraint(UltraPanel1, GridBagConstraint1);
            UltraPanel1.Location=new Point(1439, 5);
            UltraPanel1.Name="UltraPanel1";
            UltraGridBagLayoutManager1.SetPreferredSize(UltraPanel1, new Size(350, 47));
            UltraPanel1.Size=new Size(350, 47);
            UltraPanel1.TabIndex=5;
            // 
            // btnAddRows
            // 
            btnAddRows.Location=new Point(39, 4);
            btnAddRows.Name="btnAddRows";
            btnAddRows.Size=new Size(149, 37);
            btnAddRows.TabIndex=6;
            btnAddRows.Text="Add Rows";
            btnAddRows.UseVisualStyleBackColor=true;
            // 
            // btnAddPlan
            // 
            btnAddPlan.Location=new Point(194, 3);
            btnAddPlan.Name="btnAddPlan";
            btnAddPlan.Size=new Size(149, 37);
            btnAddPlan.TabIndex=5;
            btnAddPlan.Text="Add New Plan";
            btnAddPlan.UseVisualStyleBackColor=true;
            // 
            // _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left
            // 
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.BackColor=SystemColors.Control;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.ForeColor=SystemColors.ControlText;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.Location=new Point(0, 0);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.Name="_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left";
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.Size=new Size(0, 725);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right
            // 
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.BackColor=SystemColors.Control;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.ForeColor=SystemColors.ControlText;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.Location=new Point(1794, 0);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.Name="_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right";
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.Size=new Size(0, 725);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top
            // 
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.BackColor=SystemColors.Control;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.ForeColor=SystemColors.ControlText;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.Location=new Point(0, 0);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.Name="_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top";
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.Size=new Size(1794, 0);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom
            // 
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.BackColor=SystemColors.Control;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.ForeColor=SystemColors.ControlText;
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.Location=new Point(0, 725);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.Name="_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom";
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.Size=new Size(1794, 0);
            _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom.ToolbarsManager=UltraToolbarsManager1;
            // 
            // UltraGridBagLayoutManager1
            // 
            UltraGridBagLayoutManager1.ContainerControl=PlanEstimateTablesMaintenance_Fill_Panel.ClientArea;
            UltraGridBagLayoutManager1.ExpandToFitHeight=true;
            UltraGridBagLayoutManager1.ExpandToFitWidth=true;
            UltraGridBagLayoutManager1.Margins.Bottom=5;
            UltraGridBagLayoutManager1.Margins.Left=5;
            UltraGridBagLayoutManager1.Margins.Right=5;
            UltraGridBagLayoutManager1.Margins.Top=5;
            // 
            // SpPlanEstimatesGetTableAdapter
            // 
            SpPlanEstimatesGetTableAdapter.ClearBeforeFill=true;
            // 
            // VwPlanEstimatePlanExteriorsTableAdapter1
            // 
            VwPlanEstimatePlanExteriorsTableAdapter1.ClearBeforeFill=true;
            // 
            // PlanEstimateTablesMaintenance
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1794, 725);
            Controls.Add(PlanEstimateTablesMaintenance_Fill_Panel);
            Controls.Add(_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left);
            Controls.Add(_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right);
            Controls.Add(_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom);
            Controls.Add(_PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top);
            Name="PlanEstimateTablesMaintenance";
            StartPosition=FormStartPosition.CenterParent;
            Text="Plan Estimate Tables";
            ((System.ComponentModel.ISupportInitialize)ugPlanGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanEstimateBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanEstimate).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugPlanEstimateDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpPlanEstimatesGetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DsDetail).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraToolbarsManager1).EndInit();
            PlanEstimateTablesMaintenance_Fill_Panel.ClientArea.ResumeLayout(false);
            PlanEstimateTablesMaintenance_Fill_Panel.ResumeLayout(false);
            UltraPanel3.ClientArea.ResumeLayout(false);
            UltraPanel3.ClientArea.PerformLayout();
            UltraPanel3.ResumeLayout(false);
            UltraPanel1.ClientArea.ResumeLayout(false);
            UltraPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UltraGridBagLayoutManager1).EndInit();
            Load+=new EventHandler(PlanEstimateTablesMaintenance_Load);
            ResumeLayout(false);

        }
        // Friend WithEvents HCHDataPlanEstimateSetBindingSource As System.Windows.Forms.BindingSource
        internal HCHDataPlanEstimate HCHDataPlanEstimateSet;
        internal HCHDataPlanEstimateTableAdapters.vwPlanEstimatePlanExteriorsTableAdapter VwPlanEstimatePlanExteriorsTableAdapter;
        internal Infragistics.Win.UltraWinGrid.UltraGrid ugPlanGroups;
        internal Infragistics.Win.UltraWinGrid.UltraGrid ugPlanEstimateDetail;
        internal BindingSource SpPlanEstimatesGetBindingSource;
        internal dsDetailTableAdapters.spPlanEstimatesGetTableAdapter SpPlanEstimatesGetTableAdapter;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsManager UltraToolbarsManager1;
        internal Infragistics.Win.Misc.UltraPanel PlanEstimateTablesMaintenance_Fill_Panel;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Left;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Right;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Bottom;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateTablesMaintenance_Toolbars_Dock_Area_Top;
        internal Infragistics.Win.Misc.UltraGridBagLayoutManager UltraGridBagLayoutManager1;
        internal Button btnPopulateDetail;
        internal Infragistics.Win.Misc.UltraPanel UltraPanel3;
        internal Label Label2;
        internal Label Label1;
        internal Infragistics.Win.Misc.UltraPanel UltraPanel1;
        internal Button btnAddRows;
        internal Button btnAddPlan;
        internal dsDetail DsDetail;
        internal BindingSource HCHDataPlanEstimateBindingSource;
        internal HCHDataPlanEstimate HCHDataPlanEstimate;
        internal HCHDataPlanEstimateTableAdapters.vwPlanEstimatePlanExteriorsTableAdapter VwPlanEstimatePlanExteriorsTableAdapter1;
    }
}