using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VPOReasons : Form
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
            var Appearance4 = new Infragistics.Win.Appearance();
            var Appearance5 = new Infragistics.Win.Appearance();
            var Appearance6 = new Infragistics.Win.Appearance();
            var Appearance7 = new Infragistics.Win.Appearance();
            var Appearance8 = new Infragistics.Win.Appearance();
            var Appearance9 = new Infragistics.Win.Appearance();
            var Appearance10 = new Infragistics.Win.Appearance();
            var Appearance11 = new Infragistics.Win.Appearance();
            var Appearance12 = new Infragistics.Win.Appearance();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(VPOReasons));
            grdReasons=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdReasons.CellChange+=new Infragistics.Win.UltraWinGrid.CellEventHandler(grdReasons_CellChange);
            grdReasons.InitializeLayout+=new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(grdReasons_InitializeLayout);
            grdReasons.MouseEnterElement+=new Infragistics.Win.UIElementEventHandler(grdReasons_MouseEnterElement);
            tsBtnAdd=new ToolStripButton();
            tsBtnEdit=new ToolStripButton();
            tsBtnUndo=new ToolStripButton();
            tsBtnSave=new ToolStripButton();
            tsBtnPrint=new ToolStripButton();
            tsBtnTip=new ToolStripButton();
            tsToolStrip=new ToolStrip();
            tsToolStrip.ItemClicked+=new ToolStripItemClickedEventHandler(tsToolStrip_ItemClicked);
            ((System.ComponentModel.ISupportInitialize)grdReasons).BeginInit();
            tsToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // grdReasons
            // 
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            grdReasons.DisplayLayout.Appearance=Appearance1;
            grdReasons.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            grdReasons.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdReasons.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            grdReasons.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            grdReasons.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            grdReasons.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdReasons.DisplayLayout.GroupByBox.Hidden=true;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            grdReasons.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            grdReasons.DisplayLayout.MaxColScrollRegions=1;
            grdReasons.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            grdReasons.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            grdReasons.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            grdReasons.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdReasons.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdReasons.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdReasons.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            grdReasons.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdReasons.DisplayLayout.Override.CellAppearance=Appearance8;
            grdReasons.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdReasons.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            grdReasons.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            grdReasons.DisplayLayout.Override.HeaderAppearance=Appearance10;
            grdReasons.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdReasons.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            grdReasons.DisplayLayout.Override.RowAppearance=Appearance11;
            grdReasons.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdReasons.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance12.BackColor=SystemColors.ControlLight;
            grdReasons.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            grdReasons.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdReasons.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdReasons.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdReasons.Dock=DockStyle.Fill;
            grdReasons.Location=new Point(0, 31);
            grdReasons.Name="grdReasons";
            grdReasons.Size=new Size(906, 535);
            grdReasons.TabIndex=0;
            grdReasons.Text="UltraGrid1";
            // 
            // tsBtnAdd
            // 
            tsBtnAdd.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnAdd.Enabled=false;
            tsBtnAdd.Image=My.Resources.Resources.NewCard;
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
            tsBtnEdit.Image=My.Resources.Resources.EditBrightContrast;
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
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnSave, tsBtnPrint, tsBtnTip });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(906, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=1;
            tsToolStrip.Text="ToolStrip1";
            // 
            // VPOReasons
            // 
            AutoScaleDimensions=new SizeF(6.0f, 13.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(906, 566);
            Controls.Add(grdReasons);
            Controls.Add(tsToolStrip);
            Name="VPOReasons";
            Text="VPOReasons";
            ((System.ComponentModel.ISupportInitialize)grdReasons).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            Load+=new EventHandler(VPOReasons_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdReasons;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnTip;
        internal ToolStrip tsToolStrip;
    }
}