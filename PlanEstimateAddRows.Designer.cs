using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PlanEstimateAddRows : Form
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
            var UltraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("PlanGroup");
            var UltraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Elevation");
            var UltraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ExteriorID");
            var UltraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ResourceID");
            var UltraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ActivityCode");
            var UltraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("ResUsage");
            var UltraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("BudgetQty");
            var Appearance1 = new Infragistics.Win.Appearance();
            var Appearance2 = new Infragistics.Win.Appearance();
            var Appearance3 = new Infragistics.Win.Appearance();
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("PlanEstimate", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceID");
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ActivityCode");
            var UltraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResUsage");
            var UltraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BudgetQty");
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
            var UltraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("Edit");
            var PopupMenuTool3 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Edit");
            var PopupMenuTool4 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("Edit");
            var ButtonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Undo");
            var ButtonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Redo");
            var ButtonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Copy");
            var ButtonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Paste");
            var ButtonTool5 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Cut");
            var ButtonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Delete");
            var ButtonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Select All");
            var ButtonTool15 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Undo");
            var ButtonTool16 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Redo");
            var ButtonTool17 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Copy");
            var ButtonTool18 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Paste");
            var ButtonTool19 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Cut");
            var ButtonTool20 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Delete");
            var ButtonTool21 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Select All");
            UltraDataSource1=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            UltraLabel1=new Infragistics.Win.Misc.UltraLabel();
            btnSave=new Button();
            btnSave.Click+=new EventHandler(btnSave_Click);
            PlanEstimateAddRows_Fill_Panel=new Panel();
            pnlAddNewRows=new Infragistics.Win.Misc.UltraPanel();
            uLblPlan=new Infragistics.Win.Misc.UltraLabel();
            uLblElevation=new Infragistics.Win.Misc.UltraLabel();
            uLblExterior=new Infragistics.Win.Misc.UltraLabel();
            ulAddNewPlan=new Infragistics.Win.Misc.UltraLabel();
            pnlNewPlan=new Panel();
            uceExterior=new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            ProjectExteriorBindingSource=new BindingSource(components);
            HCHDataDataSet2=new HCHDataDataSet2();
            uceElevation=new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            PlanElevationsBindingSource=new BindingSource(components);
            HCHDataDataSet1=new HCHDataDataSet1();
            ucePlanGroup=new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            VwPlanGroupsBindingSource=new BindingSource(components);
            HCHDataDataSet=new HCHDataDataSet();
            UltraGrid1=new Infragistics.Win.UltraWinGrid.UltraGrid();
            HCHDataOptionsDataPlanEstimateAdd=new HCHDataOptionsDataPlanEstimateAdd();
            UltraToolbarsManager1=new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(components);
            UltraToolbarsManager1.ToolClick+=new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(UltraToolbarsManager1_ToolClick);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            PlanEstimateBindingSource=new BindingSource(components);
            PlanEstimateTableAdapter=new HCHDataOptionsDataPlanEstimateAddTableAdapters.PlanEstimateTableAdapter();
            VwPlanGroupsTableAdapter=new HCHDataDataSetTableAdapters.vwPlanGroupsTableAdapter();
            PlanElevationsTableAdapter=new HCHDataDataSet1TableAdapters.PlanElevationsTableAdapter();
            ProjectExteriorTableAdapter=new HCHDataDataSet2TableAdapters.ProjectExteriorTableAdapter();
            lblConnection=new Label();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).BeginInit();
            PlanEstimateAddRows_Fill_Panel.SuspendLayout();
            pnlAddNewRows.ClientArea.SuspendLayout();
            pnlAddNewRows.SuspendLayout();
            pnlNewPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uceExterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProjectExteriorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceElevation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlanElevationsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucePlanGroup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VwPlanGroupsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataOptionsDataPlanEstimateAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraToolbarsManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlanEstimateBindingSource).BeginInit();
            SuspendLayout();
            // 
            // UltraDataSource1
            // 
            UltraDataSource1.Band.AllowAdd=Infragistics.Win.DefaultableBoolean.True;
            UltraDataColumn3.DataType=typeof(int);
            UltraDataColumn5.DataType=typeof(int);
            UltraDataColumn7.DataType=typeof(decimal);
            UltraDataSource1.Band.Columns.AddRange(new object[] { UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7 });
            UltraDataSource1.Band.Key="PlanEstimate";
            // 
            // UltraLabel1
            // 
            Appearance1.ForeColor=Color.Blue;
            UltraLabel1.Appearance=Appearance1;
            UltraLabel1.Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraLabel1.Location=new Point(68, 6);
            UltraLabel1.Name="UltraLabel1";
            UltraLabel1.Size=new Size(390, 45);
            UltraLabel1.TabIndex=5;
            UltraLabel1.Text="Paste rows from Excel onto the top row of the grid.  Click Save to insert into Pl"+"an Estimate table.";
            // 
            // btnSave
            // 
            btnSave.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location=new Point(464, 49);
            btnSave.Name="btnSave";
            btnSave.Size=new Size(102, 32);
            btnSave.TabIndex=6;
            btnSave.Text="Save";
            btnSave.UseVisualStyleBackColor=true;
            // 
            // PlanEstimateAddRows_Fill_Panel
            // 
            PlanEstimateAddRows_Fill_Panel.Controls.Add(lblConnection);
            PlanEstimateAddRows_Fill_Panel.Controls.Add(pnlAddNewRows);
            PlanEstimateAddRows_Fill_Panel.Controls.Add(ulAddNewPlan);
            PlanEstimateAddRows_Fill_Panel.Controls.Add(btnSave);
            PlanEstimateAddRows_Fill_Panel.Controls.Add(pnlNewPlan);
            PlanEstimateAddRows_Fill_Panel.Controls.Add(UltraLabel1);
            PlanEstimateAddRows_Fill_Panel.Controls.Add(UltraGrid1);
            PlanEstimateAddRows_Fill_Panel.Cursor=Cursors.Default;
            PlanEstimateAddRows_Fill_Panel.Dock=DockStyle.Fill;
            PlanEstimateAddRows_Fill_Panel.Location=new Point(0, 25);
            PlanEstimateAddRows_Fill_Panel.Name="PlanEstimateAddRows_Fill_Panel";
            PlanEstimateAddRows_Fill_Panel.Size=new Size(587, 700);
            PlanEstimateAddRows_Fill_Panel.TabIndex=0;
            // 
            // pnlAddNewRows
            // 
            // 
            // pnlAddNewRows.ClientArea
            // 
            pnlAddNewRows.ClientArea.Controls.Add(uLblPlan);
            pnlAddNewRows.ClientArea.Controls.Add(uLblElevation);
            pnlAddNewRows.ClientArea.Controls.Add(uLblExterior);
            pnlAddNewRows.Location=new Point(68, 103);
            pnlAddNewRows.Name="pnlAddNewRows";
            pnlAddNewRows.Size=new Size(456, 49);
            pnlAddNewRows.TabIndex=10;
            // 
            // uLblPlan
            // 
            uLblPlan.Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            uLblPlan.Location=new Point(3, 13);
            uLblPlan.Name="uLblPlan";
            uLblPlan.Size=new Size(49, 26);
            uLblPlan.TabIndex=9;
            uLblPlan.Text="Plan";
            // 
            // uLblElevation
            // 
            uLblElevation.Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            uLblElevation.Location=new Point(58, 13);
            uLblElevation.Name="uLblElevation";
            uLblElevation.Size=new Size(38, 26);
            uLblElevation.TabIndex=8;
            uLblElevation.Text="Elevation";
            // 
            // uLblExterior
            // 
            uLblExterior.Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            uLblExterior.Location=new Point(102, 13);
            uLblExterior.Name="uLblExterior";
            uLblExterior.Size=new Size(367, 26);
            uLblExterior.TabIndex=7;
            uLblExterior.Text="Exterior";
            // 
            // ulAddNewPlan
            // 
            Appearance2.ForeColor=Color.Teal;
            ulAddNewPlan.Appearance=Appearance2;
            ulAddNewPlan.Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ulAddNewPlan.Location=new Point(68, 49);
            ulAddNewPlan.Name="ulAddNewPlan";
            ulAddNewPlan.Size=new Size(390, 45);
            ulAddNewPlan.TabIndex=8;
            ulAddNewPlan.Text="To Create new Plan, select Plan, Elevation and Exterior.  Add Plan Details, then "+"press Save";
            // 
            // pnlNewPlan
            // 
            pnlNewPlan.Controls.Add(uceExterior);
            pnlNewPlan.Controls.Add(uceElevation);
            pnlNewPlan.Controls.Add(ucePlanGroup);
            pnlNewPlan.Location=new Point(68, 95);
            pnlNewPlan.Name="pnlNewPlan";
            pnlNewPlan.Size=new Size(486, 54);
            pnlNewPlan.TabIndex=7;
            pnlNewPlan.Visible=false;
            // 
            // uceExterior
            // 
            uceExterior.DataSource=ProjectExteriorBindingSource;
            uceExterior.DisplayMember="ExteriorName";
            uceExterior.Location=new Point(187, 6);
            uceExterior.Name="uceExterior";
            uceExterior.Size=new Size(282, 26);
            uceExterior.TabIndex=10;
            uceExterior.ValueMember="ExteriorID";
            // 
            // ProjectExteriorBindingSource
            // 
            ProjectExteriorBindingSource.DataMember="ProjectExterior";
            ProjectExteriorBindingSource.DataSource=HCHDataDataSet2;
            // 
            // HCHDataDataSet2
            // 
            HCHDataDataSet2.DataSetName="HCHDataDataSet2";
            HCHDataDataSet2.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // uceElevation
            // 
            uceElevation.DataSource=PlanElevationsBindingSource;
            uceElevation.DisplayMember="Elevation";
            uceElevation.Location=new Point(122, 6);
            uceElevation.Name="uceElevation";
            uceElevation.Size=new Size(52, 26);
            uceElevation.TabIndex=9;
            // 
            // PlanElevationsBindingSource
            // 
            PlanElevationsBindingSource.DataMember="PlanElevations";
            PlanElevationsBindingSource.DataSource=HCHDataDataSet1;
            // 
            // HCHDataDataSet1
            // 
            HCHDataDataSet1.DataSetName="HCHDataDataSet1";
            HCHDataDataSet1.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // ucePlanGroup
            // 
            ucePlanGroup.DataSource=VwPlanGroupsBindingSource;
            ucePlanGroup.DisplayMember="PlanGroup";
            ucePlanGroup.Location=new Point(6, 6);
            ucePlanGroup.Name="ucePlanGroup";
            ucePlanGroup.Size=new Size(102, 26);
            ucePlanGroup.TabIndex=8;
            // 
            // VwPlanGroupsBindingSource
            // 
            VwPlanGroupsBindingSource.DataMember="vwPlanGroups";
            VwPlanGroupsBindingSource.DataSource=HCHDataDataSet;
            // 
            // HCHDataDataSet
            // 
            HCHDataDataSet.DataSetName="HCHDataDataSet";
            HCHDataDataSet.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // UltraGrid1
            // 
            UltraToolbarsManager1.SetContextMenuUltra(UltraGrid1, "Edit");
            UltraGrid1.DataMember="PlanEstimate";
            UltraGrid1.DataSource=HCHDataOptionsDataPlanEstimateAdd;
            Appearance3.BackColor=SystemColors.Window;
            Appearance3.BorderColor=SystemColors.InactiveCaption;
            UltraGrid1.DisplayLayout.Appearance=Appearance3;
            UltraGridColumn1.Header.Caption="Resource";
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridColumn2.Header.Caption="Activity Code";
            UltraGridColumn2.Header.VisiblePosition=1;
            UltraGridColumn3.Header.Caption="Use Code";
            UltraGridColumn3.Header.VisiblePosition=2;
            UltraGridColumn8.Header.Caption="Quantity";
            UltraGridColumn8.Header.VisiblePosition=3;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn8 });
            UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            UltraGrid1.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            UltraGrid1.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance4.BackColor=SystemColors.ActiveBorder;
            Appearance4.BackColor2=SystemColors.ControlDark;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance4.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.GroupByBox.Appearance=Appearance4;
            Appearance5.ForeColor=SystemColors.GrayText;
            UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance5;
            UltraGrid1.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            UltraGrid1.DisplayLayout.GroupByBox.Hidden=true;
            Appearance6.BackColor=SystemColors.ControlLightLight;
            Appearance6.BackColor2=SystemColors.Control;
            Appearance6.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance6.ForeColor=SystemColors.GrayText;
            UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance=Appearance6;
            UltraGrid1.DisplayLayout.MaxColScrollRegions=1;
            UltraGrid1.DisplayLayout.MaxRowScrollRegions=1;
            Appearance7.BackColor=SystemColors.Window;
            Appearance7.ForeColor=SystemColors.ControlText;
            UltraGrid1.DisplayLayout.Override.ActiveCellAppearance=Appearance7;
            Appearance8.BackColor=SystemColors.Highlight;
            Appearance8.ForeColor=SystemColors.HighlightText;
            UltraGrid1.DisplayLayout.Override.ActiveRowAppearance=Appearance8;
            UltraGrid1.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.FixedAddRowOnTop;
            UltraGrid1.DisplayLayout.Override.AllowMultiCellOperations=Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Cut|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Delete|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Undo;


            UltraGrid1.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            UltraGrid1.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance9.BackColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.CardAreaAppearance=Appearance9;
            Appearance10.BorderColor=Color.Silver;
            Appearance10.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            UltraGrid1.DisplayLayout.Override.CellAppearance=Appearance10;
            UltraGrid1.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            UltraGrid1.DisplayLayout.Override.CellPadding=0;
            Appearance11.BackColor=SystemColors.Control;
            Appearance11.BackColor2=SystemColors.ControlDark;
            Appearance11.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance11.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance11.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.GroupByRowAppearance=Appearance11;
            Appearance12.TextHAlignAsString="Left";
            UltraGrid1.DisplayLayout.Override.HeaderAppearance=Appearance12;
            UltraGrid1.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            UltraGrid1.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=Color.Silver;
            UltraGrid1.DisplayLayout.Override.RowAppearance=Appearance13;
            UltraGrid1.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance14.BackColor=SystemColors.ControlLight;
            UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=Appearance14;
            UltraGrid1.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            UltraGrid1.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            UltraGrid1.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            UltraGrid1.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraGrid1.Location=new Point(68, 158);
            UltraGrid1.Name="UltraGrid1";
            UltraGrid1.Size=new Size(451, 497);
            UltraGrid1.TabIndex=0;
            UltraGrid1.Text="UltraGrid1";
            // 
            // HCHDataOptionsDataPlanEstimateAdd
            // 
            HCHDataOptionsDataPlanEstimateAdd.DataSetName="HCHDataOptionsDataPlanEstimateAdd";
            HCHDataOptionsDataPlanEstimateAdd.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // UltraToolbarsManager1
            // 
            UltraToolbarsManager1.DesignerFlags=1;
            UltraToolbarsManager1.DockWithinContainer=this;
            UltraToolbarsManager1.DockWithinContainerBaseType=typeof(Form);
            UltraToolbar1.DockedColumn=0;
            UltraToolbar1.DockedRow=0;
            UltraToolbar1.IsMainMenuBar=true;
            UltraToolbar1.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { PopupMenuTool3 });
            UltraToolbar1.Text="Edit";
            UltraToolbarsManager1.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] { UltraToolbar1 });
            PopupMenuTool4.SharedPropsInternal.Caption="Edit";
            PopupMenuTool4.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { ButtonTool1, ButtonTool2, ButtonTool3, ButtonTool4, ButtonTool5, ButtonTool6, ButtonTool7 });
            ButtonTool15.SharedPropsInternal.Caption="Undo";
            ButtonTool16.SharedPropsInternal.Caption="Redo";
            ButtonTool17.SharedPropsInternal.Caption="Copy";
            ButtonTool18.SharedPropsInternal.Caption="Paste";
            ButtonTool19.SharedPropsInternal.Caption="Cut";
            ButtonTool20.SharedPropsInternal.Caption="Delete";
            ButtonTool21.SharedPropsInternal.Caption="Select All";
            UltraToolbarsManager1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { PopupMenuTool4, ButtonTool15, ButtonTool16, ButtonTool17, ButtonTool18, ButtonTool19, ButtonTool20, ButtonTool21 });
            // 
            // _PlanEstimateAddRows_Toolbars_Dock_Area_Left
            // 
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.BackColor=SystemColors.Control;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.ForeColor=SystemColors.ControlText;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.Location=new Point(0, 25);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.Name="_PlanEstimateAddRows_Toolbars_Dock_Area_Left";
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.Size=new Size(0, 700);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Left.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _PlanEstimateAddRows_Toolbars_Dock_Area_Right
            // 
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.BackColor=SystemColors.Control;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.ForeColor=SystemColors.ControlText;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.Location=new Point(587, 25);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.Name="_PlanEstimateAddRows_Toolbars_Dock_Area_Right";
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.Size=new Size(0, 700);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Right.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _PlanEstimateAddRows_Toolbars_Dock_Area_Top
            // 
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.BackColor=SystemColors.Control;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.ForeColor=SystemColors.ControlText;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.Location=new Point(0, 0);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.Name="_PlanEstimateAddRows_Toolbars_Dock_Area_Top";
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.Size=new Size(587, 25);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Top.ToolbarsManager=UltraToolbarsManager1;
            // 
            // _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom
            // 
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.AccessibleRole=AccessibleRole.Grouping;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.BackColor=SystemColors.Control;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.ForeColor=SystemColors.ControlText;
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.Location=new Point(0, 725);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.Name="_PlanEstimateAddRows_Toolbars_Dock_Area_Bottom";
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.Size=new Size(587, 0);
            _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom.ToolbarsManager=UltraToolbarsManager1;
            // 
            // PlanEstimateBindingSource
            // 
            PlanEstimateBindingSource.DataMember="PlanEstimate";
            PlanEstimateBindingSource.DataSource=HCHDataOptionsDataPlanEstimateAdd;
            // 
            // PlanEstimateTableAdapter
            // 
            PlanEstimateTableAdapter.ClearBeforeFill=true;
            // 
            // VwPlanGroupsTableAdapter
            // 
            VwPlanGroupsTableAdapter.ClearBeforeFill=true;
            // 
            // PlanElevationsTableAdapter
            // 
            PlanElevationsTableAdapter.ClearBeforeFill=true;
            // 
            // ProjectExteriorTableAdapter
            // 
            ProjectExteriorTableAdapter.ClearBeforeFill=true;
            // 
            // lblConnection
            // 
            lblConnection.AutoSize=true;
            lblConnection.Location=new Point(74, 671);
            lblConnection.Name="lblConnection";
            lblConnection.Size=new Size(57, 18);
            lblConnection.TabIndex=11;
            lblConnection.Text="Label1";
            // 
            // PlanEstimateAddRows
            // 
            AutoScaleDimensions=new SizeF(10.0f, 18.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(587, 725);
            Controls.Add(PlanEstimateAddRows_Fill_Panel);
            Controls.Add(_PlanEstimateAddRows_Toolbars_Dock_Area_Left);
            Controls.Add(_PlanEstimateAddRows_Toolbars_Dock_Area_Right);
            Controls.Add(_PlanEstimateAddRows_Toolbars_Dock_Area_Bottom);
            Controls.Add(_PlanEstimateAddRows_Toolbars_Dock_Area_Top);
            Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name="PlanEstimateAddRows";
            Text="Plan Estimate - Add Rows";
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).EndInit();
            PlanEstimateAddRows_Fill_Panel.ResumeLayout(false);
            PlanEstimateAddRows_Fill_Panel.PerformLayout();
            pnlAddNewRows.ClientArea.ResumeLayout(false);
            pnlAddNewRows.ResumeLayout(false);
            pnlNewPlan.ResumeLayout(false);
            pnlNewPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uceExterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProjectExteriorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceElevation).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlanElevationsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucePlanGroup).EndInit();
            ((System.ComponentModel.ISupportInitialize)VwPlanGroupsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataOptionsDataPlanEstimateAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraToolbarsManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlanEstimateBindingSource).EndInit();
            FormClosed+=new FormClosedEventHandler(PlanEstimateAddRows_FormClosed);
            Load+=new EventHandler(PlanEstimateAddRows_Load);
            ResumeLayout(false);

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
        internal HCHDataOptionsDataPlanEstimateAdd HCHDataOptionsDataPlanEstimateAdd;
        internal BindingSource PlanEstimateBindingSource;
        internal HCHDataOptionsDataPlanEstimateAddTableAdapters.PlanEstimateTableAdapter PlanEstimateTableAdapter;
        internal Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource1;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel1;
        internal Button btnSave;
        internal Panel PlanEstimateAddRows_Fill_Panel;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsManager UltraToolbarsManager1;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateAddRows_Toolbars_Dock_Area_Left;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateAddRows_Toolbars_Dock_Area_Right;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateAddRows_Toolbars_Dock_Area_Bottom;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _PlanEstimateAddRows_Toolbars_Dock_Area_Top;
        internal Panel pnlNewPlan;
        internal Infragistics.Win.Misc.UltraLabel ulAddNewPlan;
        internal Infragistics.Win.UltraWinEditors.UltraComboEditor uceExterior;
        internal Infragistics.Win.UltraWinEditors.UltraComboEditor uceElevation;
        internal Infragistics.Win.UltraWinEditors.UltraComboEditor ucePlanGroup;
        internal HCHDataDataSet HCHDataDataSet;
        internal BindingSource VwPlanGroupsBindingSource;
        internal HCHDataDataSetTableAdapters.vwPlanGroupsTableAdapter VwPlanGroupsTableAdapter;
        internal HCHDataDataSet1 HCHDataDataSet1;
        internal BindingSource PlanElevationsBindingSource;
        internal HCHDataDataSet1TableAdapters.PlanElevationsTableAdapter PlanElevationsTableAdapter;
        internal HCHDataDataSet2 HCHDataDataSet2;
        internal BindingSource ProjectExteriorBindingSource;
        internal HCHDataDataSet2TableAdapters.ProjectExteriorTableAdapter ProjectExteriorTableAdapter;
        internal Infragistics.Win.Misc.UltraPanel pnlAddNewRows;
        internal Infragistics.Win.Misc.UltraLabel uLblPlan;
        internal Infragistics.Win.Misc.UltraLabel uLblElevation;
        internal Infragistics.Win.Misc.UltraLabel uLblExterior;
        internal Label lblConnection;
    }
}