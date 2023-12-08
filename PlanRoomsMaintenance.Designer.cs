using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PlanRoomsMaintenance : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spPlanRoomsGet", -1);
            var UltraGridColumn16 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanRoomID");
            var UltraGridColumn17 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanID");
            var UltraGridColumn18 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Room");
            var UltraGridColumn19 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedDate");
            var UltraGridColumn20 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("CreatedBy");
            var UltraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UpdatedDate");
            var UltraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Updatedby");
            var UltraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Optional");
            var UltraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SqFt");
            var UltraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("FlooringDefault");
            var UltraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OtherRoom");
            var UltraGridColumn27 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lftrim");
            var UltraGridColumn28 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lfcrown");
            var UltraGridColumn29 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TrimResource");
            var UltraGridColumn30 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("OtherResource");
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
            UltraGrid1=new Infragistics.Win.UltraWinGrid.UltraGrid();
            UltraGrid1.AfterRowUpdate+=new Infragistics.Win.UltraWinGrid.RowEventHandler(UltraGrid1_AfterRowUpdate);
            SpPlanRoomsGetBindingSource=new BindingSource(components);
            ubtnAddNewPlan=new Infragistics.Win.Misc.UltraButton();
            ubtnAddNewPlan.Click+=new EventHandler(ubtnAddNewPlan_Click);
            HCHDataPlanRoomsDataBindingSource=new BindingSource(components);
            HCHDataPlanRoomsData=new HCHDataPlanRoomsData();
            SpPlanRoomsGetTableAdapter=new HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpPlanRoomsGetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanRoomsDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanRoomsData).BeginInit();
            SuspendLayout();
            // 
            // UltraGrid1
            // 
            UltraGrid1.DataSource=HCHDataPlanRoomsDataBindingSource;
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            UltraGrid1.DisplayLayout.Appearance=Appearance1;
            UltraGridColumn16.Header.VisiblePosition=0;
            UltraGridColumn16.Hidden=true;
            UltraGridColumn17.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn17.Header.VisiblePosition=1;
            UltraGridColumn18.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn18.Header.VisiblePosition=2;
            UltraGridColumn19.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn19.Header.Caption="Created Date";
            UltraGridColumn19.Header.VisiblePosition=11;
            UltraGridColumn20.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn20.Header.Caption="Created By";
            UltraGridColumn20.Header.VisiblePosition=12;
            UltraGridColumn21.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn21.Header.Caption="Updated Date";
            UltraGridColumn21.Header.VisiblePosition=13;
            UltraGridColumn22.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn22.Header.Caption="Updated by";
            UltraGridColumn22.Header.VisiblePosition=14;
            UltraGridColumn23.Header.VisiblePosition=3;
            UltraGridColumn23.Width=113;
            UltraGridColumn24.Header.VisiblePosition=6;
            UltraGridColumn25.Header.Caption="Flooring Default";
            UltraGridColumn25.Header.VisiblePosition=5;
            UltraGridColumn26.Header.Caption="Other Room";
            UltraGridColumn26.Header.VisiblePosition=4;
            UltraGridColumn27.Header.Caption="LF Trim";
            UltraGridColumn27.Header.VisiblePosition=7;
            UltraGridColumn28.Header.Caption="LF Crown";
            UltraGridColumn28.Header.VisiblePosition=9;
            UltraGridColumn29.Header.Caption="Trim Resource";
            UltraGridColumn29.Header.VisiblePosition=8;
            UltraGridColumn30.CellActivation=Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            UltraGridColumn30.Header.Caption="Other Resource";
            UltraGridColumn30.Header.VisiblePosition=10;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn16, UltraGridColumn17, UltraGridColumn18, UltraGridColumn19, UltraGridColumn20, UltraGridColumn21, UltraGridColumn22, UltraGridColumn23, UltraGridColumn24, UltraGridColumn25, UltraGridColumn26, UltraGridColumn27, UltraGridColumn28, UltraGridColumn29, UltraGridColumn30 });
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
            UltraGrid1.DisplayLayout.Key="PlanRoomID";
            UltraGrid1.DisplayLayout.MaxColScrollRegions=1;
            UltraGrid1.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            UltraGrid1.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            UltraGrid1.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            UltraGrid1.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            UltraGrid1.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            UltraGrid1.DisplayLayout.Override.AllowMultiCellOperations=Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.CopyWithHeaders|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Paste|Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Undo;

            UltraGrid1.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.True;
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
            UltraGrid1.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.SelectTypeCell=Infragistics.Win.UltraWinGrid.SelectType.Single;
            UltraGrid1.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Extended;
            Appearance12.BackColor=SystemColors.ControlLight;
            UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            UltraGrid1.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            UltraGrid1.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            UltraGrid1.DisplayLayout.UseFixedHeaders=true;
            UltraGrid1.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            UltraGrid1.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraGrid1.Location=new Point(12, 37);
            UltraGrid1.Name="UltraGrid1";
            UltraGrid1.Size=new Size(1744, 656);
            UltraGrid1.TabIndex=0;
            UltraGrid1.Text="UltraGrid1";
            // 
            // SpPlanRoomsGetBindingSource
            // 
            SpPlanRoomsGetBindingSource.DataMember="spPlanRoomsGet";
            SpPlanRoomsGetBindingSource.DataSource=HCHDataPlanRoomsDataBindingSource;
            // 
            // ubtnAddNewPlan
            // 
            ubtnAddNewPlan.Location=new Point(12, 8);
            ubtnAddNewPlan.Name="ubtnAddNewPlan";
            ubtnAddNewPlan.Size=new Size(129, 23);
            ubtnAddNewPlan.TabIndex=1;
            ubtnAddNewPlan.Text="Add New Plan";
            // 
            // HCHDataPlanRoomsDataBindingSource
            // 
            HCHDataPlanRoomsDataBindingSource.DataSource=HCHDataPlanRoomsData;
            HCHDataPlanRoomsDataBindingSource.Position=0;
            // 
            // HCHDataPlanRoomsData
            // 
            HCHDataPlanRoomsData.DataSetName="HCHDataPlanRoomsData";
            HCHDataPlanRoomsData.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // SpPlanRoomsGetTableAdapter
            // 
            SpPlanRoomsGetTableAdapter.ClearBeforeFill=true;
            // 
            // PlanRoomsMaintenance
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1768, 726);
            Controls.Add(ubtnAddNewPlan);
            Controls.Add(UltraGrid1);
            Name="PlanRoomsMaintenance";
            Text="Take Off Table";
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpPlanRoomsGetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanRoomsDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataPlanRoomsData).EndInit();
            Load+=new EventHandler(PlanRoomsMaintenance_Load);
            ResumeLayout(false);

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
        // Friend WithEvents HCHDataOptionsDataSet1BindingSource As System.Windows.Forms.BindingSource
        internal BindingSource SpPlanRoomsGetBindingSource;
        internal HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter SpPlanRoomsGetTableAdapter;
        internal BindingSource HCHDataPlanRoomsDataBindingSource;
        internal HCHDataPlanRoomsData HCHDataPlanRoomsData;
        internal Infragistics.Win.Misc.UltraButton ubtnAddNewPlan;
    }
}