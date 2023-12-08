using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class CostAnalysisPlanChooser : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(CostAnalysisPlanChooser));
            btnProjectPlans=new Button();
            btnProjectPlans.Click+=new EventHandler(btnProjectPlans_Click);
            UltraGrid1=new Infragistics.Win.UltraWinGrid.UltraGrid();
            UltraGrid1.AfterCellUpdate+=new Infragistics.Win.UltraWinGrid.CellEventHandler(UltraGrid1_AfterCellUpdate);
            UltraGrid1.AfterRowInsert+=new Infragistics.Win.UltraWinGrid.RowEventHandler(UltraGrid1_AfterRowInsert);
            UltraDataSource1=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            btnPlansFromFolder=new Button();
            btnPlansFromFolder.Click+=new EventHandler(btnPlansFromFolder_Click);
            btnSavePlans=new Button();
            btnSavePlans.Click+=new EventHandler(btnSavePlans_Click);
            btnClearAllPlans=new Button();
            btnClearAllPlans.Click+=new EventHandler(btnClearAllPlans_Click);
            TextBox1=new TextBox();
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).BeginInit();
            SuspendLayout();
            // 
            // btnProjectPlans
            // 
            btnProjectPlans.Location=new Point(12, 12);
            btnProjectPlans.Name="btnProjectPlans";
            btnProjectPlans.Size=new Size(260, 35);
            btnProjectPlans.TabIndex=0;
            btnProjectPlans.Text="Add Plans from Selected Project";
            btnProjectPlans.UseVisualStyleBackColor=true;
            // 
            // UltraGrid1
            // 
            UltraGrid1.DataSource=UltraDataSource1;
            Appearance1.BackColor=Color.Gainsboro;
            Appearance1.BackColor2=Color.DarkGray;
            Appearance1.BackGradientStyle=Infragistics.Win.GradientStyle.ForwardDiagonal;
            UltraGrid1.DisplayLayout.Appearance=Appearance1;
            UltraGrid1.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand1.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
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
            UltraGrid1.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTop;
            UltraGrid1.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.True;
            UltraGrid1.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            UltraGrid1.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.InsetSoft;
            Appearance7.BackColor=Color.Transparent;
            UltraGrid1.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BackColor=Color.LightSteelBlue;
            Appearance8.ForeColor=Color.Navy;
            UltraGrid1.DisplayLayout.Override.CellAppearance=Appearance8;
            UltraGrid1.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
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
            Appearance12.BackColor=Color.DarkGray;
            Appearance12.BackColor2=Color.Gainsboro;
            Appearance12.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance12.ForeColor=Color.Navy;
            UltraGrid1.DisplayLayout.Override.RowSelectorAppearance=Appearance12;
            UltraGrid1.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            UltraGrid1.DisplayLayout.Override.RowSelectorWidth=20;
            UltraGrid1.DisplayLayout.Override.RowSpacingAfter=1;
            UltraGrid1.DisplayLayout.Override.RowSpacingBefore=3;
            Appearance13.BackColor=Color.Navy;
            Appearance13.ForeColor=Color.FromArgb(224, 224, 224);
            UltraGrid1.DisplayLayout.Override.SelectedRowAppearance=Appearance13;
            Appearance14.BackColor=SystemColors.ControlLight;
            UltraGrid1.DisplayLayout.Override.TemplateAddRowAppearance=Appearance14;
            UltraGrid1.DisplayLayout.RowConnectorColor=Color.Gray;
            UltraGrid1.DisplayLayout.RowConnectorStyle=Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dashed;
            UltraGrid1.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            UltraGrid1.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            UltraGrid1.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            UltraGrid1.Font=new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            UltraGrid1.Location=new Point(12, 191);
            UltraGrid1.Name="UltraGrid1";
            UltraGrid1.Size=new Size(1179, 637);
            UltraGrid1.TabIndex=1;
            UltraGrid1.Text="Cost Analysis Plans";
            // 
            // UltraDataSource1
            // 
            UltraDataSource1.Band.AllowAdd=Infragistics.Win.DefaultableBoolean.True;
            UltraDataSource1.Band.AllowDelete=Infragistics.Win.DefaultableBoolean.True;
            // 
            // btnPlansFromFolder
            // 
            btnPlansFromFolder.Location=new Point(287, 12);
            btnPlansFromFolder.Name="btnPlansFromFolder";
            btnPlansFromFolder.Size=new Size(260, 35);
            btnPlansFromFolder.TabIndex=2;
            btnPlansFromFolder.Text="Add Plans from CostPlan Folder";
            btnPlansFromFolder.UseVisualStyleBackColor=true;
            // 
            // btnSavePlans
            // 
            btnSavePlans.Location=new Point(1060, 12);
            btnSavePlans.Name="btnSavePlans";
            btnSavePlans.Size=new Size(131, 35);
            btnSavePlans.TabIndex=3;
            btnSavePlans.Text="Save Plans";
            btnSavePlans.UseVisualStyleBackColor=true;
            // 
            // btnClearAllPlans
            // 
            btnClearAllPlans.Location=new Point(884, 12);
            btnClearAllPlans.Name="btnClearAllPlans";
            btnClearAllPlans.Size=new Size(160, 35);
            btnClearAllPlans.TabIndex=4;
            btnClearAllPlans.Text="Clear All Plans";
            btnClearAllPlans.UseVisualStyleBackColor=true;
            // 
            // TextBox1
            // 
            TextBox1.BackColor=SystemColors.Control;
            TextBox1.ForeColor=SystemColors.HotTrack;
            TextBox1.Location=new Point(15, 70);
            TextBox1.Multiline=true;
            TextBox1.Name="TextBox1";
            TextBox1.Size=new Size(1103, 115);
            TextBox1.TabIndex=6;
            TextBox1.Text=resources.GetString("TextBox1.Text");
            // 
            // CostAnalysisPlanChooser
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1214, 844);
            Controls.Add(TextBox1);
            Controls.Add(btnClearAllPlans);
            Controls.Add(btnSavePlans);
            Controls.Add(btnPlansFromFolder);
            Controls.Add(UltraGrid1);
            Controls.Add(btnProjectPlans);
            Name="CostAnalysisPlanChooser";
            StartPosition=FormStartPosition.CenterScreen;
            Text="CostAnalysisPlanChooser";
            ((System.ComponentModel.ISupportInitialize)UltraGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).EndInit();
            FormClosing+=new FormClosingEventHandler(CostAnalysisPlanChooser_FormClosing);
            Load+=new EventHandler(CostAnalysisPlanChooser_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button btnProjectPlans;
        internal Infragistics.Win.UltraWinGrid.UltraGrid UltraGrid1;
        internal Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource1;
        internal Button btnPlansFromFolder;
        internal Button btnSavePlans;
        internal Button btnClearAllPlans;
        internal TextBox TextBox1;
    }
}