using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PlanRoomsAdd : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("vwPlanGroups", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PlanGroup");
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
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("vwRooms", -1);
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResUsage");
            var UltraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UsageDescription");
            var UltraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Room");
            var UltraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("sqft", 0);
            var UltraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("lftrim", 1);
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
            _VwPlanGroupsBindingSource=new BindingSource(components);
            _HCHDataDataSet=new HCHDataDataSet();
            VwPlanGroupsTableAdapter=new HCHDataDataSetTableAdapters.vwPlanGroupsTableAdapter();
            _SpPlanRoomsGetBindingSource=new BindingSource(components);
            _HCHDataPlanRoomsDataBindingSource=new BindingSource(components);
            _HCHDataPlanRoomsData=new HCHDataPlanRoomsData();
            _SpPlanRoomsGetTableAdapter=new HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter();
            _HCHDataRooms=new HCHDataRooms();
            _HCHDataRoomsBindingSource=new BindingSource(components);
            VwRoomsBindingSource=new BindingSource(components);
            _VwRoomsTableAdapter=new HCHDataRoomsTableAdapters.vwRoomsTableAdapter();
            HCHDataDataSetBindingSource=new BindingSource(components);
            VwPlanGroupsBindingSource1=new BindingSource(components);
            _HCHDataDataSetBindingSource2=new BindingSource(components);
            ucPlanGroups=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ubtnSaveNewPlanRooms=new Infragistics.Win.Misc.UltraButton();
            ubtnSaveNewPlanRooms.Click+=new EventHandler(ubtnSaveNewPlanRooms_Click);
            UltraGrid1=new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)_VwPlanGroupsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_SpPlanRoomsGetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataPlanRoomsDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataPlanRoomsData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataRoomsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VwRoomsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSetBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VwPlanGroupsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataDataSetBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucPlanGroups).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).BeginInit();
            SuspendLayout();
            // 
            // VwPlanGroupsBindingSource
            // 
            _VwPlanGroupsBindingSource.DataMember="vwPlanGroups";
            _VwPlanGroupsBindingSource.DataSource=_HCHDataDataSet;
            // 
            // HCHDataDataSet
            // 
            _HCHDataDataSet.DataSetName="HCHDataDataSet";
            _HCHDataDataSet.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // VwPlanGroupsTableAdapter
            // 
            VwPlanGroupsTableAdapter.ClearBeforeFill=true;
            // 
            // SpPlanRoomsGetBindingSource
            // 
            _SpPlanRoomsGetBindingSource.DataMember="spPlanRoomsGet";
            _SpPlanRoomsGetBindingSource.DataSource=_HCHDataPlanRoomsDataBindingSource;
            // 
            // HCHDataPlanRoomsDataBindingSource
            // 
            _HCHDataPlanRoomsDataBindingSource.DataSource=_HCHDataPlanRoomsData;
            _HCHDataPlanRoomsDataBindingSource.Position=0;
            // 
            // HCHDataPlanRoomsData
            // 
            _HCHDataPlanRoomsData.DataSetName="HCHDataPlanRoomsData";
            _HCHDataPlanRoomsData.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // SpPlanRoomsGetTableAdapter
            // 
            _SpPlanRoomsGetTableAdapter.ClearBeforeFill=true;
            // 
            // HCHDataRooms
            // 
            _HCHDataRooms.DataSetName="HCHDataRooms";
            _HCHDataRooms.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // HCHDataRoomsBindingSource
            // 
            _HCHDataRoomsBindingSource.DataSource=_HCHDataRooms;
            _HCHDataRoomsBindingSource.Position=0;
            // 
            // VwRoomsBindingSource
            // 
            VwRoomsBindingSource.DataMember="vwRooms";
            VwRoomsBindingSource.DataSource=_HCHDataRoomsBindingSource;
            // 
            // VwRoomsTableAdapter
            // 
            _VwRoomsTableAdapter.ClearBeforeFill=true;
            // 
            // HCHDataDataSetBindingSource
            // 
            HCHDataDataSetBindingSource.DataSource=_HCHDataDataSet;
            HCHDataDataSetBindingSource.Position=0;
            // 
            // VwPlanGroupsBindingSource1
            // 
            VwPlanGroupsBindingSource1.DataMember="vwPlanGroups";
            VwPlanGroupsBindingSource1.DataSource=HCHDataDataSetBindingSource;
            // 
            // HCHDataDataSetBindingSource2
            // 
            _HCHDataDataSetBindingSource2.DataSource=_HCHDataDataSet;
            _HCHDataDataSetBindingSource2.Position=0;
            // 
            // ucPlanGroups
            // 
            ucPlanGroups.DataSource=VwPlanGroupsBindingSource1;
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            ucPlanGroups.DisplayLayout.Appearance=Appearance1;
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn1 });
            ucPlanGroups.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            ucPlanGroups.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucPlanGroups.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            ucPlanGroups.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            ucPlanGroups.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            ucPlanGroups.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            ucPlanGroups.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            ucPlanGroups.DisplayLayout.MaxColScrollRegions=1;
            ucPlanGroups.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            ucPlanGroups.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            ucPlanGroups.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            ucPlanGroups.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            ucPlanGroups.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            ucPlanGroups.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            ucPlanGroups.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucPlanGroups.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            ucPlanGroups.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucPlanGroups.DisplayLayout.Override.CellAppearance=Appearance8;
            ucPlanGroups.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            ucPlanGroups.DisplayLayout.Override.CellPadding=0;
            ucPlanGroups.DisplayLayout.Override.ColumnAutoSizeMode=Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            ucPlanGroups.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            ucPlanGroups.DisplayLayout.Override.HeaderAppearance=Appearance10;
            ucPlanGroups.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucPlanGroups.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            ucPlanGroups.DisplayLayout.Override.RowAppearance=Appearance11;
            ucPlanGroups.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            ucPlanGroups.DisplayLayout.Override.SelectTypeCell=Infragistics.Win.UltraWinGrid.SelectType.None;
            ucPlanGroups.DisplayLayout.Override.SelectTypeCol=Infragistics.Win.UltraWinGrid.SelectType.None;
            Appearance12.BackColor=SystemColors.ControlLight;
            ucPlanGroups.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            ucPlanGroups.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucPlanGroups.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucPlanGroups.DisplayLayout.TabNavigation=Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            ucPlanGroups.DisplayLayout.ViewStyle=Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            ucPlanGroups.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucPlanGroups.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucPlanGroups.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ucPlanGroups.Location=new Point(12, 24);
            ucPlanGroups.Name="ucPlanGroups";
            ucPlanGroups.NullText="Select Plan Group";
            ucPlanGroups.Size=new Size(173, 25);
            ucPlanGroups.TabIndex=3;
            // 
            // ubtnSaveNewPlanRooms
            // 
            ubtnSaveNewPlanRooms.Location=new Point(695, 713);
            ubtnSaveNewPlanRooms.Name="ubtnSaveNewPlanRooms";
            ubtnSaveNewPlanRooms.Size=new Size(160, 23);
            ubtnSaveNewPlanRooms.TabIndex=5;
            ubtnSaveNewPlanRooms.Text="Save New Plan Rooms";
            // 
            // UltraGrid1
            // 
            UltraGrid1.DataSource=VwRoomsBindingSource;
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            UltraGrid1.DisplayLayout.Appearance=Appearance13;
            UltraGridColumn2.Header.VisiblePosition=0;
            UltraGridColumn3.Header.VisiblePosition=1;
            UltraGridColumn4.Header.VisiblePosition=2;
            UltraGridColumn4.Hidden=true;
            UltraGridColumn6.DataType=typeof(short);
            UltraGridColumn6.Header.Caption="SqFt";
            UltraGridColumn6.Header.VisiblePosition=3;
            UltraGridColumn7.DataType=typeof(short);
            UltraGridColumn7.Header.Caption="LF Trim";
            UltraGridColumn7.Header.VisiblePosition=4;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn6, UltraGridColumn7 });
            UltraGrid1.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            UltraGrid1.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            UltraGrid1.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            UltraGrid1.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            UltraGrid1.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            UltraGrid1.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            UltraGrid1.DisplayLayout.MaxColScrollRegions=1;
            UltraGrid1.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            UltraGrid1.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            UltraGrid1.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            UltraGrid1.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            UltraGrid1.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            UltraGrid1.DisplayLayout.Override.CellAppearance=Appearance20;
            UltraGrid1.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            UltraGrid1.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            UltraGrid1.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            UltraGrid1.DisplayLayout.Override.HeaderAppearance=Appearance22;
            UltraGrid1.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            UltraGrid1.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            UltraGrid1.DisplayLayout.Override.RowAppearance=Appearance23;
            UltraGrid1.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance24.BackColor=SystemColors.ControlLight;
            UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            UltraGrid1.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            UltraGrid1.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            UltraGrid1.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            UltraGrid1.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraGrid1.Location=new Point(233, 24);
            UltraGrid1.Name="UltraGrid1";
            UltraGrid1.Size=new Size(622, 683);
            UltraGrid1.TabIndex=6;
            UltraGrid1.Text="UltraGrid1";
            // 
            // PlanRoomsAdd
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(867, 748);
            Controls.Add(UltraGrid1);
            Controls.Add(ubtnSaveNewPlanRooms);
            Controls.Add(ucPlanGroups);
            Name="PlanRoomsAdd";
            Text="Add Plan Rooms";
            ((System.ComponentModel.ISupportInitialize)_VwPlanGroupsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)_SpPlanRoomsGetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataPlanRoomsDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataPlanRoomsData).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataRoomsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)VwRoomsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDataSetBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)VwPlanGroupsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_HCHDataDataSetBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucPlanGroups).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).EndInit();
            Load+=new EventHandler(PlanRoomsAdd_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal HCHDataDataSetTableAdapters.vwPlanGroupsTableAdapter VwPlanGroupsTableAdapter;
        internal BindingSource VwRoomsBindingSource;
        internal BindingSource HCHDataDataSetBindingSource;
        internal BindingSource VwPlanGroupsBindingSource1;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucPlanGroups;
        internal Infragistics.Win.Misc.UltraButton ubtnSaveNewPlanRooms;
        internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
        private HCHDataPlanRoomsData _HCHDataPlanRoomsData;

        public virtual HCHDataPlanRoomsData HCHDataPlanRoomsData
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HCHDataPlanRoomsData;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HCHDataPlanRoomsData=value;
            }
        }
        private BindingSource _HCHDataPlanRoomsDataBindingSource;

        public virtual BindingSource HCHDataPlanRoomsDataBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HCHDataPlanRoomsDataBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HCHDataPlanRoomsDataBindingSource=value;
            }
        }
        private BindingSource _HCHDataRoomsBindingSource;

        public virtual BindingSource HCHDataRoomsBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HCHDataRoomsBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HCHDataRoomsBindingSource=value;
            }
        }
        private HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter _SpPlanRoomsGetTableAdapter;

        public virtual HCHDataPlanRoomsDataTableAdapters.spPlanRoomsGetTableAdapter SpPlanRoomsGetTableAdapter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SpPlanRoomsGetTableAdapter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _SpPlanRoomsGetTableAdapter=value;
            }
        }
        private HCHDataRoomsTableAdapters.vwRoomsTableAdapter _VwRoomsTableAdapter;

        public virtual HCHDataRoomsTableAdapters.vwRoomsTableAdapter VwRoomsTableAdapter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _VwRoomsTableAdapter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _VwRoomsTableAdapter=value;
            }
        }
        private HCHDataDataSet _HCHDataDataSet;

        public virtual HCHDataDataSet HCHDataDataSet
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HCHDataDataSet;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HCHDataDataSet=value;
            }
        }
        private BindingSource _VwPlanGroupsBindingSource;

        public virtual BindingSource VwPlanGroupsBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _VwPlanGroupsBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _VwPlanGroupsBindingSource=value;
            }
        }
        private BindingSource _SpPlanRoomsGetBindingSource;

        public virtual BindingSource SpPlanRoomsGetBindingSource
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SpPlanRoomsGetBindingSource;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _SpPlanRoomsGetBindingSource=value;
            }
        }
        private HCHDataRooms _HCHDataRooms;

        public virtual HCHDataRooms HCHDataRooms
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HCHDataRooms;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HCHDataRooms=value;
            }
        }
        private BindingSource _HCHDataDataSetBindingSource2;

        public virtual BindingSource HCHDataDataSetBindingSource2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HCHDataDataSetBindingSource2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HCHDataDataSetBindingSource2=value;
            }
        }
    }
}