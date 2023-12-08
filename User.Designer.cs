using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserSelect : Form
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
            grdTo=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdTo.AfterRowsDeleted+=new EventHandler(grdTo_AfterRowsDeleted);
            grdTo.BeforeRowsDeleted+=new Infragistics.Win.UltraWinGrid.BeforeRowsDeletedEventHandler(grdTo_BeforeRowsDeleted);
            grdFrom=new Infragistics.Win.UltraWinGrid.UltraGrid();
            btnAddusers=new Button();
            btnAddusers.Click+=new EventHandler(btnAddusers_Click);
            Label1=new Label();
            Label2=new Label();
            ((System.ComponentModel.ISupportInitialize)grdTo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdFrom).BeginInit();
            SuspendLayout();
            // 
            // grdTo
            // 
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            grdTo.DisplayLayout.Appearance=Appearance1;
            grdTo.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdTo.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            grdTo.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            grdTo.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            grdTo.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdTo.DisplayLayout.GroupByBox.Hidden=true;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            grdTo.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            grdTo.DisplayLayout.MaxColScrollRegions=1;
            grdTo.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            grdTo.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            grdTo.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            grdTo.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            grdTo.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdTo.DisplayLayout.Override.AllowColSwapping=Infragistics.Win.UltraWinGrid.AllowColSwapping.NotAllowed;
            grdTo.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.True;
            grdTo.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdTo.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdTo.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            grdTo.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdTo.DisplayLayout.Override.CellAppearance=Appearance8;
            grdTo.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdTo.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            grdTo.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            grdTo.DisplayLayout.Override.HeaderAppearance=Appearance10;
            grdTo.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdTo.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            grdTo.DisplayLayout.Override.RowAppearance=Appearance11;
            grdTo.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdTo.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance12.BackColor=SystemColors.ControlLight;
            grdTo.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            grdTo.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdTo.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdTo.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdTo.Location=new Point(12, 48);
            grdTo.Name="grdTo";
            grdTo.Size=new Size(388, 80);
            grdTo.TabIndex=1;
            grdTo.Text="Current Users";
            // 
            // grdFrom
            // 
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            grdFrom.DisplayLayout.Appearance=Appearance13;
            grdFrom.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdFrom.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            grdFrom.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            grdFrom.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            grdFrom.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdFrom.DisplayLayout.GroupByBox.Hidden=true;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            grdFrom.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            grdFrom.DisplayLayout.MaxColScrollRegions=1;
            grdFrom.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            grdFrom.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            grdFrom.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            grdFrom.DisplayLayout.Override.AllowAddNew=Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            grdFrom.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdFrom.DisplayLayout.Override.AllowGroupBy=Infragistics.Win.DefaultableBoolean.False;
            grdFrom.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdFrom.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdFrom.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            grdFrom.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdFrom.DisplayLayout.Override.CellAppearance=Appearance20;
            grdFrom.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            grdFrom.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            grdFrom.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            grdFrom.DisplayLayout.Override.HeaderAppearance=Appearance22;
            grdFrom.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            grdFrom.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            grdFrom.DisplayLayout.Override.RowAppearance=Appearance23;
            grdFrom.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            Appearance24.BackColor=SystemColors.ControlLight;
            grdFrom.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            grdFrom.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdFrom.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdFrom.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdFrom.Location=new Point(434, 48);
            grdFrom.Name="grdFrom";
            grdFrom.Size=new Size(379, 80);
            grdFrom.TabIndex=2;
            grdFrom.Text="Select Users";
            // 
            // btnAddusers
            // 
            btnAddusers.Location=new Point(551, 268);
            btnAddusers.Name="btnAddusers";
            btnAddusers.Size=new Size(114, 23);
            btnAddusers.TabIndex=3;
            btnAddusers.Text="Save New Users";
            btnAddusers.UseVisualStyleBackColor=true;
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Font=new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor=SystemColors.HotTrack;
            Label1.Location=new Point(7, 12);
            Label1.Name="Label1";
            Label1.Size=new Size(421, 17);
            Label1.TabIndex=4;
            Label1.Text="Select row and press Delete key to remove user from notifications";
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Font=new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor=SystemColors.HotTrack;
            Label2.Location=new Point(431, 12);
            Label2.Name="Label2";
            Label2.Size=new Size(354, 17);
            Label2.TabIndex=5;
            Label2.Text="Select User and click Save New User to add notfication";
            // 
            // UserSelect
            // 
            AutoScaleDimensions=new SizeF(6.0f, 13.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(842, 303);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(btnAddusers);
            Controls.Add(grdFrom);
            Controls.Add(grdTo);
            Name="UserSelect";
            Text="Select Users";
            ((System.ComponentModel.ISupportInitialize)grdTo).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdFrom).EndInit();
            Load+=new EventHandler(UserSelect_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdTo;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdFrom;
        internal Button btnAddusers;
        internal Label Label1;
        internal Label Label2;
    }
}