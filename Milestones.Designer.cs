using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Milestones : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Milestones));
            var Appearance13 = new Infragistics.Win.Appearance();
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
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
            var Appearance44 = new Infragistics.Win.Appearance();
            var Appearance45 = new Infragistics.Win.Appearance();
            var GridBagConstraint8 = new Infragistics.Win.Layout.GridBagConstraint();
            var GridBagConstraint9 = new Infragistics.Win.Layout.GridBagConstraint();
            var Appearance46 = new Infragistics.Win.Appearance();
            var GridBagConstraint10 = new Infragistics.Win.Layout.GridBagConstraint();
            var Appearance47 = new Infragistics.Win.Appearance();
            var GridBagConstraint11 = new Infragistics.Win.Layout.GridBagConstraint();
            var Appearance48 = new Infragistics.Win.Appearance();
            var GridBagConstraint12 = new Infragistics.Win.Layout.GridBagConstraint();
            var Appearance49 = new Infragistics.Win.Appearance();
            var GridBagConstraint13 = new Infragistics.Win.Layout.GridBagConstraint();
            var Appearance50 = new Infragistics.Win.Appearance();
            var GridBagConstraint14 = new Infragistics.Win.Layout.GridBagConstraint();
            var Appearance32 = new Infragistics.Win.Appearance();
            var UltraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            var UltraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Position");
            var UltraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Rank");
            var UltraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PositionToNotifyID");
            var UltraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PositionID");
            var Appearance33 = new Infragistics.Win.Appearance();
            var Appearance34 = new Infragistics.Win.Appearance();
            var Appearance35 = new Infragistics.Win.Appearance();
            var Appearance36 = new Infragistics.Win.Appearance();
            var Appearance37 = new Infragistics.Win.Appearance();
            var Appearance38 = new Infragistics.Win.Appearance();
            var Appearance39 = new Infragistics.Win.Appearance();
            var Appearance40 = new Infragistics.Win.Appearance();
            var Appearance41 = new Infragistics.Win.Appearance();
            var Appearance42 = new Infragistics.Win.Appearance();
            var Appearance43 = new Infragistics.Win.Appearance();
            grdMilestones=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdMilestones.AfterSelectChange+=new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(grdMilestones_AfterSelectChange);
            grdMilestones.InitializeLayout+=new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(grdMilestones_InitializeLayout);
            grdMilestones.RowEditTemplateRequested+=new Infragistics.Win.UltraWinGrid.RowEditTemplateRequestedEventHandler(grdMilestones_RowEditTemplateRequested);
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
            grdNotifyList=new Infragistics.Win.UltraWinGrid.UltraGrid();
            lblRelatedMilestone=new Label();
            lblActivityPaid=new Label();
            lblAction=new Label();
            btnChangeUsers=new Button();
            btnChangeUsers.Click+=new EventHandler(btnChangeUsers_Click);
            lblActionDescription=new Label();
            lblNote=new Label();
            retMilestones=new Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate();
            ulblNotifyCriteria=new Infragistics.Win.Misc.UltraLabel();
            accept=new Infragistics.Win.Misc.UltraButton();
            ulblDescription=new Infragistics.Win.Misc.UltraLabel();
            ulblUserAdded=new Infragistics.Win.Misc.UltraLabel();
            ulblBuilderCanCancel=new Infragistics.Win.Misc.UltraLabel();
            uLblMessage=new Infragistics.Win.Misc.UltraLabel();
            ulblNotify=new Infragistics.Win.Misc.UltraLabel();
            ugbLayoutMgr=new Infragistics.Win.Misc.UltraGridBagLayoutManager(components);
            grdPositionsToNotify=new Infragistics.Win.UltraWinGrid.UltraGrid();
            Button1=new Button();
            ((System.ComponentModel.ISupportInitialize)grdMilestones).BeginInit();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdNotifyList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)retMilestones).BeginInit();
            retMilestones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ugbLayoutMgr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdPositionsToNotify).BeginInit();
            SuspendLayout();
            // 
            // grdMilestones
            // 
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            grdMilestones.DisplayLayout.Appearance=Appearance1;
            grdMilestones.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand1.ColHeaderLines=3;
            UltraGridBand1.GroupHeaderLines=3;
            UltraGridBand1.Header.TextOrientation=new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            grdMilestones.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            grdMilestones.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdMilestones.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            grdMilestones.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            grdMilestones.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            grdMilestones.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdMilestones.DisplayLayout.GroupByBox.Hidden=true;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            grdMilestones.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            grdMilestones.DisplayLayout.MaxColScrollRegions=1;
            grdMilestones.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            grdMilestones.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            grdMilestones.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            grdMilestones.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdMilestones.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdMilestones.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdMilestones.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdMilestones.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            grdMilestones.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdMilestones.DisplayLayout.Override.CellAppearance=Appearance8;
            grdMilestones.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdMilestones.DisplayLayout.Override.CellPadding=0;
            grdMilestones.DisplayLayout.Override.ColumnHeaderTextOrientation=new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            grdMilestones.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            grdMilestones.DisplayLayout.Override.HeaderAppearance=Appearance10;
            grdMilestones.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdMilestones.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            grdMilestones.DisplayLayout.Override.RowAppearance=Appearance11;
            grdMilestones.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdMilestones.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance12.BackColor=SystemColors.ControlLight;
            grdMilestones.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            grdMilestones.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdMilestones.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdMilestones.DisplayLayout.UseFixedHeaders=true;
            grdMilestones.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdMilestones.Location=new Point(0, 42);
            grdMilestones.Margin=new Padding(4);
            grdMilestones.Name="grdMilestones";
            grdMilestones.Size=new Size(1522, 369);
            grdMilestones.TabIndex=1;
            grdMilestones.Text="Milestones";
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnSave, tsBtnPrint, tsBtnTip });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(1535, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=2;
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
            // grdNotifyList
            // 
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            grdNotifyList.DisplayLayout.Appearance=Appearance13;
            grdNotifyList.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand2.ColHeaderLines=2;
            grdNotifyList.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            grdNotifyList.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNotifyList.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            grdNotifyList.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            grdNotifyList.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            grdNotifyList.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNotifyList.DisplayLayout.GroupByBox.Hidden=true;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            grdNotifyList.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            grdNotifyList.DisplayLayout.MaxColScrollRegions=1;
            grdNotifyList.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            grdNotifyList.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            grdNotifyList.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            grdNotifyList.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdNotifyList.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdNotifyList.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdNotifyList.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdNotifyList.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            grdNotifyList.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdNotifyList.DisplayLayout.Override.CellAppearance=Appearance20;
            grdNotifyList.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdNotifyList.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            grdNotifyList.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            grdNotifyList.DisplayLayout.Override.HeaderAppearance=Appearance22;
            grdNotifyList.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdNotifyList.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            grdNotifyList.DisplayLayout.Override.RowAppearance=Appearance23;
            grdNotifyList.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdNotifyList.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance24.BackColor=SystemColors.ControlLight;
            grdNotifyList.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            grdNotifyList.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdNotifyList.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdNotifyList.DisplayLayout.UseFixedHeaders=true;
            grdNotifyList.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdNotifyList.Location=new Point(0, 457);
            grdNotifyList.Margin=new Padding(4);
            grdNotifyList.Name="grdNotifyList";
            grdNotifyList.Size=new Size(525, 325);
            grdNotifyList.TabIndex=3;
            grdNotifyList.Text="Users to Notify";
            // 
            // lblRelatedMilestone
            // 
            lblRelatedMilestone.AutoSize=true;
            lblRelatedMilestone.BackColor=SystemColors.InactiveCaption;
            lblRelatedMilestone.BorderStyle=BorderStyle.Fixed3D;
            lblRelatedMilestone.Font=new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRelatedMilestone.ForeColor=SystemColors.HotTrack;
            lblRelatedMilestone.Location=new Point(547, 472);
            lblRelatedMilestone.Margin=new Padding(4, 0, 4, 0);
            lblRelatedMilestone.Name="lblRelatedMilestone";
            lblRelatedMilestone.Size=new Size(143, 22);
            lblRelatedMilestone.TabIndex=4;
            lblRelatedMilestone.Text="Related Milestone:";
            // 
            // lblActivityPaid
            // 
            lblActivityPaid.AutoSize=true;
            lblActivityPaid.BackColor=SystemColors.InactiveCaption;
            lblActivityPaid.BorderStyle=BorderStyle.Fixed3D;
            lblActivityPaid.Font=new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActivityPaid.ForeColor=SystemColors.HotTrack;
            lblActivityPaid.Location=new Point(547, 506);
            lblActivityPaid.Margin=new Padding(4, 0, 4, 0);
            lblActivityPaid.Name="lblActivityPaid";
            lblActivityPaid.Size=new Size(202, 22);
            lblActivityPaid.TabIndex=5;
            lblActivityPaid.Text="Created when Activity Paid:";
            // 
            // lblAction
            // 
            lblAction.AutoSize=true;
            lblAction.BackColor=SystemColors.InactiveCaption;
            lblAction.BorderStyle=BorderStyle.Fixed3D;
            lblAction.Font=new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAction.ForeColor=SystemColors.HotTrack;
            lblAction.Location=new Point(547, 541);
            lblAction.Margin=new Padding(4, 0, 4, 0);
            lblAction.Name="lblAction";
            lblAction.Size=new Size(267, 22);
            lblAction.TabIndex=6;
            lblAction.Text="Action performed when Activity Paid:";
            // 
            // btnChangeUsers
            // 
            btnChangeUsers.Location=new Point(166, 798);
            btnChangeUsers.Margin=new Padding(4);
            btnChangeUsers.Name="btnChangeUsers";
            btnChangeUsers.Size=new Size(135, 28);
            btnChangeUsers.TabIndex=7;
            btnChangeUsers.Text="Change Users";
            btnChangeUsers.UseVisualStyleBackColor=true;
            // 
            // lblActionDescription
            // 
            lblActionDescription.AutoSize=true;
            lblActionDescription.BackColor=SystemColors.InactiveCaption;
            lblActionDescription.BorderStyle=BorderStyle.Fixed3D;
            lblActionDescription.Font=new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblActionDescription.ForeColor=SystemColors.HotTrack;
            lblActionDescription.Location=new Point(613, 578);
            lblActionDescription.Margin=new Padding(4, 0, 4, 0);
            lblActionDescription.Name="lblActionDescription";
            lblActionDescription.Size=new Size(144, 22);
            lblActionDescription.TabIndex=8;
            lblActionDescription.Text="Action Description:";
            // 
            // lblNote
            // 
            lblNote.AutoSize=true;
            lblNote.BackColor=SystemColors.InactiveCaption;
            lblNote.BorderStyle=BorderStyle.Fixed3D;
            lblNote.Font=new Font("Microsoft Sans Serif", 9.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNote.ForeColor=SystemColors.HotTrack;
            lblNote.Location=new Point(547, 622);
            lblNote.Margin=new Padding(4, 0, 4, 0);
            lblNote.Name="lblNote";
            lblNote.Size=new Size(94, 22);
            lblNote.TabIndex=9;
            lblNote.Text="Created By:";
            // 
            // retMilestones
            // 
            Appearance44.TextHAlignAsString="Left";
            retMilestones.Appearance=Appearance44;
            retMilestones.AutoScroll=true;
            retMilestones.Controls.Add(ulblNotifyCriteria);
            retMilestones.Controls.Add(accept);
            retMilestones.Controls.Add(ulblDescription);
            retMilestones.Controls.Add(ulblUserAdded);
            retMilestones.Controls.Add(ulblBuilderCanCancel);
            retMilestones.Controls.Add(uLblMessage);
            retMilestones.Controls.Add(ulblNotify);
            retMilestones.DialogSettings.Caption="Edit Milestone";
            retMilestones.Location=new Point(120, 100);
            retMilestones.Margin=new Padding(4);
            retMilestones.Name="retMilestones";
            retMilestones.Size=new Size(892, 443);
            retMilestones.TabIndex=10;
            retMilestones.Visible=false;
            // 
            // ulblNotifyCriteria
            // 
            Appearance45.TextHAlignAsString="Right";
            ulblNotifyCriteria.Appearance=Appearance45;
            GridBagConstraint8.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            GridBagConstraint8.Fill=Infragistics.Win.Layout.FillType.Horizontal;
            ugbLayoutMgr.SetGridBagConstraint(ulblNotifyCriteria, GridBagConstraint8);
            ulblNotifyCriteria.Location=new Point(0, 210);
            ulblNotifyCriteria.Margin=new Padding(4);
            ulblNotifyCriteria.Name="ulblNotifyCriteria";
            ugbLayoutMgr.SetPreferredSize(ulblNotifyCriteria, new Size(144, 23));
            ulblNotifyCriteria.Size=new Size(134, 23);
            ulblNotifyCriteria.TabIndex=6;
            ulblNotifyCriteria.Text="Notify Criteria:";
            // 
            // accept
            // 
            GridBagConstraint9.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            ugbLayoutMgr.SetGridBagConstraint(accept, GridBagConstraint9);
            accept.Location=new Point(126, 207);
            accept.Margin=new Padding(4);
            accept.Name="accept";
            accept.Size=new Size(100, 28);
            accept.TabIndex=5;
            accept.Text="UltraButton1";
            // 
            // ulblDescription
            // 
            Appearance46.TextHAlignAsString="Right";
            ulblDescription.Appearance=Appearance46;
            GridBagConstraint10.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            GridBagConstraint10.Fill=Infragistics.Win.Layout.FillType.Horizontal;
            ugbLayoutMgr.SetGridBagConstraint(ulblDescription, GridBagConstraint10);
            ulblDescription.Location=new Point(226, 210);
            ulblDescription.Margin=new Padding(4);
            ulblDescription.Name="ulblDescription";
            ugbLayoutMgr.SetPreferredSize(ulblDescription, new Size(144, 23));
            ulblDescription.Size=new Size(134, 23);
            ulblDescription.TabIndex=4;
            ulblDescription.Text="Description:";
            // 
            // ulblUserAdded
            // 
            Appearance47.TextHAlignAsString="Right";
            ulblUserAdded.Appearance=Appearance47;
            GridBagConstraint11.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            GridBagConstraint11.Fill=Infragistics.Win.Layout.FillType.Horizontal;
            ugbLayoutMgr.SetGridBagConstraint(ulblUserAdded, GridBagConstraint11);
            ulblUserAdded.Location=new Point(360, 210);
            ulblUserAdded.Margin=new Padding(4);
            ulblUserAdded.Name="ulblUserAdded";
            ugbLayoutMgr.SetPreferredSize(ulblUserAdded, new Size(144, 23));
            ulblUserAdded.Size=new Size(133, 23);
            ulblUserAdded.TabIndex=3;
            ulblUserAdded.Text="User Added:";
            // 
            // ulblBuilderCanCancel
            // 
            Appearance48.TextHAlignAsString="Right";
            ulblBuilderCanCancel.Appearance=Appearance48;
            GridBagConstraint12.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            GridBagConstraint12.Fill=Infragistics.Win.Layout.FillType.Horizontal;
            ugbLayoutMgr.SetGridBagConstraint(ulblBuilderCanCancel, GridBagConstraint12);
            ulblBuilderCanCancel.Location=new Point(493, 210);
            ulblBuilderCanCancel.Margin=new Padding(4);
            ulblBuilderCanCancel.Name="ulblBuilderCanCancel";
            ugbLayoutMgr.SetPreferredSize(ulblBuilderCanCancel, new Size(144, 23));
            ulblBuilderCanCancel.Size=new Size(133, 23);
            ulblBuilderCanCancel.TabIndex=2;
            ulblBuilderCanCancel.Text="Builder Can Cancel:";
            // 
            // uLblMessage
            // 
            Appearance49.TextHAlignAsString="Right";
            uLblMessage.Appearance=Appearance49;
            GridBagConstraint13.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            GridBagConstraint13.Fill=Infragistics.Win.Layout.FillType.Horizontal;
            ugbLayoutMgr.SetGridBagConstraint(uLblMessage, GridBagConstraint13);
            uLblMessage.Location=new Point(626, 210);
            uLblMessage.Margin=new Padding(4);
            uLblMessage.Name="uLblMessage";
            ugbLayoutMgr.SetPreferredSize(uLblMessage, new Size(144, 23));
            uLblMessage.Size=new Size(133, 23);
            uLblMessage.TabIndex=1;
            uLblMessage.Text="eMail Message:";
            // 
            // ulblNotify
            // 
            Appearance50.TextHAlignAsString="Right";
            ulblNotify.Appearance=Appearance50;
            GridBagConstraint14.Anchor=Infragistics.Win.Layout.AnchorType.Right;
            GridBagConstraint14.Fill=Infragistics.Win.Layout.FillType.Horizontal;
            ugbLayoutMgr.SetGridBagConstraint(ulblNotify, GridBagConstraint14);
            ulblNotify.Location=new Point(759, 210);
            ulblNotify.Margin=new Padding(4);
            ulblNotify.Name="ulblNotify";
            ugbLayoutMgr.SetPreferredSize(ulblNotify, new Size(144, 23));
            ulblNotify.Size=new Size(133, 23);
            ulblNotify.TabIndex=0;
            ulblNotify.Text="Notify:";
            // 
            // ugbLayoutMgr
            // 
            ugbLayoutMgr.ContainerControl=retMilestones;
            ugbLayoutMgr.ExpandToFitHeight=true;
            ugbLayoutMgr.ExpandToFitWidth=true;
            // 
            // grdPositionsToNotify
            // 
            Appearance32.BackColor=SystemColors.Window;
            Appearance32.BorderColor=SystemColors.InactiveCaption;
            grdPositionsToNotify.DisplayLayout.Appearance=Appearance32;
            grdPositionsToNotify.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand3.ColHeaderLines=2;
            UltraGridColumn1.Header.VisiblePosition=0;
            UltraGridColumn1.Width=368;
            UltraGridColumn2.Header.VisiblePosition=1;
            UltraGridColumn2.Width=71;
            UltraGridColumn3.Header.VisiblePosition=2;
            UltraGridColumn3.Hidden=true;
            UltraGridColumn3.Width=62;
            UltraGridColumn4.Header.VisiblePosition=3;
            UltraGridColumn4.Hidden=true;
            UltraGridColumn4.Width=70;
            UltraGridBand3.Columns.AddRange(new object[] { UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4 });
            grdPositionsToNotify.DisplayLayout.BandsSerializer.Add(UltraGridBand3);
            grdPositionsToNotify.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdPositionsToNotify.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance33.BackColor=SystemColors.ActiveBorder;
            Appearance33.BackColor2=SystemColors.ControlDark;
            Appearance33.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance33.BorderColor=SystemColors.Window;
            grdPositionsToNotify.DisplayLayout.GroupByBox.Appearance=Appearance33;
            Appearance34.ForeColor=SystemColors.GrayText;
            grdPositionsToNotify.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance34;
            grdPositionsToNotify.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdPositionsToNotify.DisplayLayout.GroupByBox.Hidden=true;
            Appearance35.BackColor=SystemColors.ControlLightLight;
            Appearance35.BackColor2=SystemColors.Control;
            Appearance35.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance35.ForeColor=SystemColors.GrayText;
            grdPositionsToNotify.DisplayLayout.GroupByBox.PromptAppearance=Appearance35;
            grdPositionsToNotify.DisplayLayout.MaxColScrollRegions=1;
            grdPositionsToNotify.DisplayLayout.MaxRowScrollRegions=1;
            Appearance36.BackColor=SystemColors.Window;
            Appearance36.ForeColor=SystemColors.ControlText;
            grdPositionsToNotify.DisplayLayout.Override.ActiveCellAppearance=Appearance36;
            Appearance37.BackColor=SystemColors.Highlight;
            Appearance37.ForeColor=SystemColors.HighlightText;
            grdPositionsToNotify.DisplayLayout.Override.ActiveRowAppearance=Appearance37;
            grdPositionsToNotify.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdPositionsToNotify.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdPositionsToNotify.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdPositionsToNotify.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdPositionsToNotify.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance38.BackColor=SystemColors.Window;
            grdPositionsToNotify.DisplayLayout.Override.CardAreaAppearance=Appearance38;
            Appearance39.BorderColor=Color.Silver;
            Appearance39.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdPositionsToNotify.DisplayLayout.Override.CellAppearance=Appearance39;
            grdPositionsToNotify.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdPositionsToNotify.DisplayLayout.Override.CellPadding=0;
            Appearance40.BackColor=SystemColors.Control;
            Appearance40.BackColor2=SystemColors.ControlDark;
            Appearance40.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance40.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance40.BorderColor=SystemColors.Window;
            grdPositionsToNotify.DisplayLayout.Override.GroupByRowAppearance=Appearance40;
            Appearance41.TextHAlignAsString="Left";
            grdPositionsToNotify.DisplayLayout.Override.HeaderAppearance=Appearance41;
            grdPositionsToNotify.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdPositionsToNotify.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance42.BackColor=SystemColors.Window;
            Appearance42.BorderColor=Color.Silver;
            grdPositionsToNotify.DisplayLayout.Override.RowAppearance=Appearance42;
            grdPositionsToNotify.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdPositionsToNotify.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance43.BackColor=SystemColors.ControlLight;
            grdPositionsToNotify.DisplayLayout.Override.TemplateAddRowAppearance=Appearance43;
            grdPositionsToNotify.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdPositionsToNotify.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdPositionsToNotify.DisplayLayout.UseFixedHeaders=true;
            grdPositionsToNotify.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdPositionsToNotify.Location=new Point(1041, 457);
            grdPositionsToNotify.Margin=new Padding(4);
            grdPositionsToNotify.Name="grdPositionsToNotify";
            grdPositionsToNotify.Size=new Size(481, 263);
            grdPositionsToNotify.TabIndex=11;
            grdPositionsToNotify.Text="Positions to Notify";
            // 
            // Button1
            // 
            Button1.Location=new Point(1202, 798);
            Button1.Margin=new Padding(4);
            Button1.Name="Button1";
            Button1.Size=new Size(135, 28);
            Button1.TabIndex=12;
            Button1.Text="Change Positions";
            Button1.UseVisualStyleBackColor=true;
            Button1.Visible=false;
            // 
            // Milestones
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1535, 889);
            Controls.Add(Button1);
            Controls.Add(grdPositionsToNotify);
            Controls.Add(lblNote);
            Controls.Add(lblActionDescription);
            Controls.Add(btnChangeUsers);
            Controls.Add(lblAction);
            Controls.Add(lblActivityPaid);
            Controls.Add(lblRelatedMilestone);
            Controls.Add(grdNotifyList);
            Controls.Add(tsToolStrip);
            Controls.Add(grdMilestones);
            Controls.Add(retMilestones);
            Margin=new Padding(4);
            Name="Milestones";
            Text="Milestones";
            ((System.ComponentModel.ISupportInitialize)grdMilestones).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdNotifyList).EndInit();
            ((System.ComponentModel.ISupportInitialize)retMilestones).EndInit();
            retMilestones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ugbLayoutMgr).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdPositionsToNotify).EndInit();
            Enter+=new EventHandler(Milestones_Enter);
            Load+=new EventHandler(Milestones_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdMilestones;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnTip;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdNotifyList;
        internal Label lblRelatedMilestone;
        internal Label lblActivityPaid;
        internal Label lblAction;
        internal Button btnChangeUsers;
        internal Label lblActionDescription;
        internal Label lblNote;
        internal Infragistics.Win.UltraWinGrid.UltraGridRowEditTemplate retMilestones;
        internal Infragistics.Win.Misc.UltraGridBagLayoutManager ugbLayoutMgr;
        internal Infragistics.Win.Misc.UltraLabel ulblDescription;
        internal Infragistics.Win.Misc.UltraLabel ulblUserAdded;
        internal Infragistics.Win.Misc.UltraLabel ulblBuilderCanCancel;
        internal Infragistics.Win.Misc.UltraLabel uLblMessage;
        internal Infragistics.Win.Misc.UltraLabel ulblNotify;
        internal Infragistics.Win.Misc.UltraButton accept;
        internal Infragistics.Win.Misc.UltraLabel ulblNotifyCriteria;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdPositionsToNotify;
        internal Button Button1;
    }
}