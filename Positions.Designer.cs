using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Positions : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Positions));
            var Appearance13 = new Infragistics.Win.Appearance();
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
            grdPositions=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdPositions.AfterSelectChange+=new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(grdpositions_AfterSelectChange);
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnEdit=new ToolStripButton();
            tsBtnUndo=new ToolStripButton();
            tsBtnSave=new ToolStripButton();
            tsBtnPrint=new ToolStripButton();
            tsBtnTip=new ToolStripButton();
            grdUsers=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdSecurity=new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)grdPositions).BeginInit();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdSecurity).BeginInit();
            SuspendLayout();
            // 
            // grdPositions
            // 
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            grdPositions.DisplayLayout.Appearance=Appearance1;
            grdPositions.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand1.ColHeaderLines=3;
            UltraGridBand1.GroupHeaderLines=3;
            UltraGridBand1.Header.TextOrientation=new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            grdPositions.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            grdPositions.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdPositions.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            grdPositions.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            grdPositions.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            grdPositions.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdPositions.DisplayLayout.GroupByBox.Hidden=true;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            grdPositions.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            grdPositions.DisplayLayout.MaxColScrollRegions=1;
            grdPositions.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            grdPositions.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            grdPositions.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            grdPositions.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdPositions.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdPositions.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdPositions.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdPositions.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdPositions.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            grdPositions.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdPositions.DisplayLayout.Override.CellAppearance=Appearance8;
            grdPositions.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdPositions.DisplayLayout.Override.CellPadding=0;
            grdPositions.DisplayLayout.Override.ColumnHeaderTextOrientation=new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            grdPositions.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            grdPositions.DisplayLayout.Override.HeaderAppearance=Appearance10;
            grdPositions.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdPositions.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            grdPositions.DisplayLayout.Override.RowAppearance=Appearance11;
            grdPositions.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdPositions.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance12.BackColor=SystemColors.ControlLight;
            grdPositions.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            grdPositions.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdPositions.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdPositions.DisplayLayout.UseFixedHeaders=true;
            grdPositions.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdPositions.Location=new Point(0, 38);
            grdPositions.Margin=new Padding(4, 4, 4, 4);
            grdPositions.Name="grdPositions";
            grdPositions.Size=new Size(1333, 369);
            grdPositions.TabIndex=2;
            grdPositions.Tag="Positions";
            grdPositions.Text="Positions";
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnSave, tsBtnPrint, tsBtnTip });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(1117, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=3;
            tsToolStrip.Text="ToolStrip1";
            // 
            // tsBtnAdd
            // 
            tsBtnAdd.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnAdd.Enabled=false;
            tsBtnAdd.ImageTransparentColor=Color.Magenta;
            tsBtnAdd.Name="tsBtnAdd";
            tsBtnAdd.Size=new Size(23, 28);
            tsBtnAdd.Text="Add New";
            tsBtnAdd.ToolTipText="Click to Add New Record";
            // 
            // tsBtnEdit
            // 
            tsBtnEdit.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnEdit.Enabled=false;
            tsBtnEdit.Image=My.Resources.Resources.edit;
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
            // grdUsers
            // 
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            grdUsers.DisplayLayout.Appearance=Appearance13;
            grdUsers.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdUsers.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            grdUsers.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            grdUsers.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            grdUsers.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdUsers.DisplayLayout.GroupByBox.Hidden=true;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            grdUsers.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            grdUsers.DisplayLayout.MaxColScrollRegions=1;
            grdUsers.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            grdUsers.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            grdUsers.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            grdUsers.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdUsers.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdUsers.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdUsers.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdUsers.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            grdUsers.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdUsers.DisplayLayout.Override.CellAppearance=Appearance20;
            grdUsers.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdUsers.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            grdUsers.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            grdUsers.DisplayLayout.Override.HeaderAppearance=Appearance22;
            grdUsers.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdUsers.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            grdUsers.DisplayLayout.Override.RowAppearance=Appearance23;
            grdUsers.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            grdUsers.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance24.BackColor=SystemColors.ControlLight;
            grdUsers.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            grdUsers.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdUsers.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdUsers.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdUsers.Location=new Point(0, 432);
            grdUsers.Margin=new Padding(4, 4, 4, 4);
            grdUsers.Name="grdUsers";
            grdUsers.Size=new Size(485, 220);
            grdUsers.TabIndex=4;
            grdUsers.Text="Users for this Position";
            // 
            // grdSecurity
            // 
            Appearance25.BackColor=SystemColors.Window;
            Appearance25.BorderColor=SystemColors.InactiveCaption;
            grdSecurity.DisplayLayout.Appearance=Appearance25;
            grdSecurity.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdSecurity.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance26.BackColor=SystemColors.ActiveBorder;
            Appearance26.BackColor2=SystemColors.ControlDark;
            Appearance26.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance26.BorderColor=SystemColors.Window;
            grdSecurity.DisplayLayout.GroupByBox.Appearance=Appearance26;
            Appearance27.ForeColor=SystemColors.GrayText;
            grdSecurity.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance27;
            grdSecurity.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdSecurity.DisplayLayout.GroupByBox.Hidden=true;
            Appearance28.BackColor=SystemColors.ControlLightLight;
            Appearance28.BackColor2=SystemColors.Control;
            Appearance28.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance28.ForeColor=SystemColors.GrayText;
            grdSecurity.DisplayLayout.GroupByBox.PromptAppearance=Appearance28;
            grdSecurity.DisplayLayout.MaxColScrollRegions=1;
            grdSecurity.DisplayLayout.MaxRowScrollRegions=1;
            Appearance29.BackColor=SystemColors.Window;
            Appearance29.ForeColor=SystemColors.ControlText;
            grdSecurity.DisplayLayout.Override.ActiveCellAppearance=Appearance29;
            Appearance30.BackColor=SystemColors.Highlight;
            Appearance30.ForeColor=SystemColors.HighlightText;
            grdSecurity.DisplayLayout.Override.ActiveRowAppearance=Appearance30;
            grdSecurity.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdSecurity.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdSecurity.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdSecurity.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdSecurity.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance31.BackColor=SystemColors.Window;
            grdSecurity.DisplayLayout.Override.CardAreaAppearance=Appearance31;
            Appearance32.BorderColor=Color.Silver;
            Appearance32.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdSecurity.DisplayLayout.Override.CellAppearance=Appearance32;
            grdSecurity.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdSecurity.DisplayLayout.Override.CellPadding=0;
            Appearance33.BackColor=SystemColors.Control;
            Appearance33.BackColor2=SystemColors.ControlDark;
            Appearance33.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance33.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance33.BorderColor=SystemColors.Window;
            grdSecurity.DisplayLayout.Override.GroupByRowAppearance=Appearance33;
            Appearance34.TextHAlignAsString="Left";
            grdSecurity.DisplayLayout.Override.HeaderAppearance=Appearance34;
            grdSecurity.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdSecurity.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance35.BackColor=SystemColors.Window;
            Appearance35.BorderColor=Color.Silver;
            grdSecurity.DisplayLayout.Override.RowAppearance=Appearance35;
            grdSecurity.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            grdSecurity.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance36.BackColor=SystemColors.ControlLight;
            grdSecurity.DisplayLayout.Override.TemplateAddRowAppearance=Appearance36;
            grdSecurity.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdSecurity.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdSecurity.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdSecurity.Location=new Point(532, 432);
            grdSecurity.Margin=new Padding(4, 4, 4, 4);
            grdSecurity.Name="grdSecurity";
            grdSecurity.Size=new Size(569, 220);
            grdSecurity.TabIndex=5;
            grdSecurity.Text="Security for this Position";
            // 
            // Positions
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1117, 667);
            Controls.Add(grdSecurity);
            Controls.Add(grdUsers);
            Controls.Add(tsToolStrip);
            Controls.Add(grdPositions);
            Margin=new Padding(4, 4, 4, 4);
            Name="Positions";
            Text="Positions";
            ((System.ComponentModel.ISupportInitialize)grdPositions).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdSecurity).EndInit();
            Load+=new EventHandler(Positions_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdPositions;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnTip;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdUsers;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdSecurity;
    }
}