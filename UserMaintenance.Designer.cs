using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class UserMaintenance : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMaintenance));
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
            var Appearance37 = new Infragistics.Win.Appearance();
            var Appearance38 = new Infragistics.Win.Appearance();
            var Appearance39 = new Infragistics.Win.Appearance();
            var Appearance40 = new Infragistics.Win.Appearance();
            var Appearance41 = new Infragistics.Win.Appearance();
            var Appearance42 = new Infragistics.Win.Appearance();
            var Appearance43 = new Infragistics.Win.Appearance();
            var Appearance44 = new Infragistics.Win.Appearance();
            var Appearance45 = new Infragistics.Win.Appearance();
            var Appearance46 = new Infragistics.Win.Appearance();
            var Appearance47 = new Infragistics.Win.Appearance();
            var Appearance48 = new Infragistics.Win.Appearance();
            var Appearance49 = new Infragistics.Win.Appearance();
            var Appearance50 = new Infragistics.Win.Appearance();
            var Appearance51 = new Infragistics.Win.Appearance();
            var Appearance52 = new Infragistics.Win.Appearance();
            var Appearance53 = new Infragistics.Win.Appearance();
            var Appearance54 = new Infragistics.Win.Appearance();
            var Appearance55 = new Infragistics.Win.Appearance();
            var Appearance56 = new Infragistics.Win.Appearance();
            var Appearance57 = new Infragistics.Win.Appearance();
            var Appearance58 = new Infragistics.Win.Appearance();
            var Appearance59 = new Infragistics.Win.Appearance();
            var Appearance60 = new Infragistics.Win.Appearance();
            var Appearance61 = new Infragistics.Win.Appearance();
            var Appearance62 = new Infragistics.Win.Appearance();
            var Appearance63 = new Infragistics.Win.Appearance();
            var Appearance64 = new Infragistics.Win.Appearance();
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            var Appearance65 = new Infragistics.Win.Appearance();
            var Appearance66 = new Infragistics.Win.Appearance();
            var Appearance67 = new Infragistics.Win.Appearance();
            var Appearance68 = new Infragistics.Win.Appearance();
            var Appearance69 = new Infragistics.Win.Appearance();
            var Appearance70 = new Infragistics.Win.Appearance();
            var Appearance71 = new Infragistics.Win.Appearance();
            var Appearance72 = new Infragistics.Win.Appearance();
            var Appearance73 = new Infragistics.Win.Appearance();
            var Appearance74 = new Infragistics.Win.Appearance();
            var Appearance75 = new Infragistics.Win.Appearance();
            var ValidationGroup1 = new Infragistics.Win.Misc.ValidationGroup("vgText");
            var Appearance13 = new Infragistics.Win.Appearance();
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnAdd.Click+=new EventHandler(tsBtnAdd_Click);
            tsBtnAdd.Click+=new EventHandler(tsBtnAdd_Click1);
            tsBtnEdit=new ToolStripButton();
            tsBtnEdit.Click+=new EventHandler(tsBtnEdit_Click);
            tsBtnUndo=new ToolStripButton();
            tsBtnUndo.Click+=new EventHandler(tsBtnUndo_Click);
            tsBtnSave=new ToolStripButton();
            tsBtnSave.Click+=new EventHandler(tsBtnSave_Click);
            tsBtnPrint=new ToolStripButton();
            tsBtnPrint.Click+=new EventHandler(tsBtnPrint_Click);
            tsBtnTip=new ToolStripButton();
            grdUsers=new Infragistics.Win.UltraWinGrid.UltraGrid();
            grdUsers.AfterSelectChange+=new Infragistics.Win.UltraWinGrid.AfterSelectChangeEventHandler(grdUsers_AfterSelectChange);
            ugbSecurity=new GroupBox();
            Label7=new Label();
            Label6=new Label();
            Label5=new Label();
            Label4=new Label();
            Label3=new Label();
            Label2=new Label();
            Label1=new Label();
            uCheckBossman=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uCheckCA=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uCheckTest=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uCheckBoss=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uCheckInactive=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            UltraLabel6=new Infragistics.Win.Misc.UltraLabel();
            uComboSupervisor=new Infragistics.Win.UltraWinGrid.UltraCombo();
            UltraLabel5=new Infragistics.Win.Misc.UltraLabel();
            uComboPositions=new Infragistics.Win.UltraWinGrid.UltraCombo();
            utePassword=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            UltraLabel4=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel3=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel2=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel1=new Infragistics.Win.Misc.UltraLabel();
            uteFName=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            uteLName=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            uteUserID=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ugbContactInfo=new Infragistics.Win.Misc.UltraGroupBox();
            UltraLabel15=new Infragistics.Win.Misc.UltraLabel();
            uTeZip=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            UltraLabel12=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel13=new Infragistics.Win.Misc.UltraLabel();
            uteCell=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            uteRadio=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            UltraLabel10=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel11=new Infragistics.Win.Misc.UltraLabel();
            utePhone=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            uteFax=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            UltraLabel7=new Infragistics.Win.Misc.UltraLabel();
            uComboState=new Infragistics.Win.UltraWinGrid.UltraCombo();
            UltraLabel8=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel9=new Infragistics.Win.Misc.UltraLabel();
            uteAddress=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            uteCity=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            UltraLabel16=new Infragistics.Win.Misc.UltraLabel();
            grdNotifyList=new Infragistics.Win.UltraWinGrid.UltraGrid();
            uv1=new Infragistics.Win.Misc.UltraValidator(components);
            uv1.Validating+=new Infragistics.Win.Misc.ValidatingHandler(uv1_Validating);
            uv1.ValidationError+=new Infragistics.Win.Misc.ValidationErrorHandler(uv1_ValidationError);
            Label8=new Label();
            UltraLabel14=new Infragistics.Win.Misc.UltraLabel();
            uteeMail=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            tsToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).BeginInit();
            ugbSecurity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uCheckBossman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uCheckCA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uCheckTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uCheckBoss).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uCheckInactive).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uComboSupervisor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uComboPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteFName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteLName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteUserID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugbContactInfo).BeginInit();
            ugbContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uTeZip).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteCell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteRadio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utePhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteFax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uComboState).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteAddress).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteCity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdNotifyList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uv1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uteeMail).BeginInit();
            SuspendLayout();
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnSave, tsBtnPrint, tsBtnTip });
            tsToolStrip.Location=new Point(0, 0);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Size=new Size(1232, 31);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=4;
            tsToolStrip.Text="ToolStrip1";
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
            tsBtnTip.Size=new Size(358, 28);
            tsBtnTip.Text="Click on Grid Header to Sort Columns or Apply Filter";
            // 
            // grdUsers
            // 
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            grdUsers.DisplayLayout.Appearance=Appearance1;
            grdUsers.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand1.ColHeaderLines=3;
            UltraGridBand1.GroupHeaderLines=3;
            UltraGridBand1.Header.TextOrientation=new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            grdUsers.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            grdUsers.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdUsers.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            grdUsers.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            grdUsers.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            grdUsers.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdUsers.DisplayLayout.GroupByBox.Hidden=true;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            grdUsers.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            grdUsers.DisplayLayout.MaxColScrollRegions=1;
            grdUsers.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            grdUsers.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            grdUsers.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            grdUsers.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdUsers.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdUsers.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdUsers.DisplayLayout.Override.AllowRowFiltering=Infragistics.Win.DefaultableBoolean.True;
            grdUsers.DisplayLayout.Override.AllowUpdate=Infragistics.Win.DefaultableBoolean.False;
            grdUsers.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdUsers.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            grdUsers.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdUsers.DisplayLayout.Override.CellAppearance=Appearance8;
            grdUsers.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdUsers.DisplayLayout.Override.CellPadding=0;
            grdUsers.DisplayLayout.Override.ColumnHeaderTextOrientation=new Infragistics.Win.TextOrientationInfo(0, Infragistics.Win.TextFlowDirection.Horizontal);
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            grdUsers.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            grdUsers.DisplayLayout.Override.HeaderAppearance=Appearance10;
            grdUsers.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdUsers.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            grdUsers.DisplayLayout.Override.RowAppearance=Appearance11;
            grdUsers.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdUsers.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance12.BackColor=SystemColors.ControlLight;
            grdUsers.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            grdUsers.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdUsers.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdUsers.DisplayLayout.UseFixedHeaders=true;
            grdUsers.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdUsers.Location=new Point(0, 42);
            grdUsers.Margin=new Padding(4);
            grdUsers.Name="grdUsers";
            grdUsers.Size=new Size(1225, 210);
            grdUsers.TabIndex=3;
            grdUsers.Text="Users";
            // 
            // ugbSecurity
            // 
            ugbSecurity.Controls.Add(Label8);
            ugbSecurity.Controls.Add(UltraLabel14);
            ugbSecurity.Controls.Add(uteeMail);
            ugbSecurity.Controls.Add(Label7);
            ugbSecurity.Controls.Add(Label6);
            ugbSecurity.Controls.Add(Label5);
            ugbSecurity.Controls.Add(Label4);
            ugbSecurity.Controls.Add(Label3);
            ugbSecurity.Controls.Add(Label2);
            ugbSecurity.Controls.Add(Label1);
            ugbSecurity.Controls.Add(uCheckBossman);
            ugbSecurity.Controls.Add(uCheckCA);
            ugbSecurity.Controls.Add(uCheckTest);
            ugbSecurity.Controls.Add(uCheckBoss);
            ugbSecurity.Controls.Add(uCheckInactive);
            ugbSecurity.Controls.Add(UltraLabel6);
            ugbSecurity.Controls.Add(uComboSupervisor);
            ugbSecurity.Controls.Add(UltraLabel5);
            ugbSecurity.Controls.Add(uComboPositions);
            ugbSecurity.Controls.Add(utePassword);
            ugbSecurity.Controls.Add(UltraLabel4);
            ugbSecurity.Controls.Add(UltraLabel3);
            ugbSecurity.Controls.Add(UltraLabel2);
            ugbSecurity.Controls.Add(UltraLabel1);
            ugbSecurity.Controls.Add(uteFName);
            ugbSecurity.Controls.Add(uteLName);
            ugbSecurity.Controls.Add(uteUserID);
            ugbSecurity.ForeColor=SystemColors.WindowText;
            ugbSecurity.Location=new Point(0, 260);
            ugbSecurity.Margin=new Padding(4);
            ugbSecurity.Name="ugbSecurity";
            ugbSecurity.Padding=new Padding(4);
            ugbSecurity.Size=new Size(1216, 197);
            ugbSecurity.TabIndex=5;
            ugbSecurity.TabStop=false;
            ugbSecurity.Text="Security";
            // 
            // Label7
            // 
            Label7.AutoSize=true;
            Label7.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label7.ForeColor=Color.Red;
            Label7.Location=new Point(852, 28);
            Label7.Name="Label7";
            Label7.Size=new Size(16, 20);
            Label7.TabIndex=23;
            Label7.Text="*";
            // 
            // Label6
            // 
            Label6.AutoSize=true;
            Label6.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label6.ForeColor=Color.Red;
            Label6.Location=new Point(775, 76);
            Label6.Name="Label6";
            Label6.Size=new Size(16, 20);
            Label6.TabIndex=22;
            Label6.Text="*";
            // 
            // Label5
            // 
            Label5.AutoSize=true;
            Label5.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label5.ForeColor=Color.Red;
            Label5.Location=new Point(570, 75);
            Label5.Name="Label5";
            Label5.Size=new Size(16, 20);
            Label5.TabIndex=21;
            Label5.Text="*";
            // 
            // Label4
            // 
            Label4.AutoSize=true;
            Label4.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label4.ForeColor=Color.Red;
            Label4.Location=new Point(444, 27);
            Label4.Name="Label4";
            Label4.Size=new Size(16, 20);
            Label4.TabIndex=20;
            Label4.Text="*";
            // 
            // Label3
            // 
            Label3.AutoSize=true;
            Label3.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label3.ForeColor=Color.Red;
            Label3.Location=new Point(57, 74);
            Label3.Name="Label3";
            Label3.Size=new Size(16, 20);
            Label3.TabIndex=19;
            Label3.Text="*";
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label2.ForeColor=Color.Red;
            Label2.Location=new Point(57, 33);
            Label2.Name="Label2";
            Label2.Size=new Size(16, 20);
            Label2.TabIndex=18;
            Label2.Text="*";
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Font=new Font("Microsoft Sans Serif", 9.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label1.ForeColor=Color.Red;
            Label1.Location=new Point(98, 0);
            Label1.Name="Label1";
            Label1.Size=new Size(609, 18);
            Label1.TabIndex=17;
            Label1.Text="All fields with * are required.  Position and Supervisor are used for Notificatio"+"ns.";
            // 
            // uCheckBossman
            // 
            uCheckBossman.Checked=true;
            uCheckBossman.CheckState=CheckState.Checked;
            uCheckBossman.Enabled=false;
            uCheckBossman.Location=new Point(81, 146);
            uCheckBossman.Margin=new Padding(4);
            uCheckBossman.Name="uCheckBossman";
            uCheckBossman.Size=new Size(160, 25);
            uCheckBossman.TabIndex=16;
            uCheckBossman.Text="Access to Bossman";
            // 
            // uCheckCA
            // 
            uCheckCA.Enabled=false;
            uCheckCA.Location=new Point(627, 146);
            uCheckCA.Margin=new Padding(4);
            uCheckCA.Name="uCheckCA";
            uCheckCA.Size=new Size(203, 25);
            uCheckCA.TabIndex=15;
            uCheckCA.Text="Access to Cost Analysis";
            // 
            // uCheckTest
            // 
            uCheckTest.Enabled=false;
            uCheckTest.Location=new Point(432, 146);
            uCheckTest.Margin=new Padding(4);
            uCheckTest.Name="uCheckTest";
            uCheckTest.Size=new Size(217, 25);
            uCheckTest.TabIndex=14;
            uCheckTest.Text="Access to Test Data";
            // 
            // uCheckBoss
            // 
            uCheckBoss.Enabled=false;
            uCheckBoss.Location=new Point(264, 146);
            uCheckBoss.Margin=new Padding(4);
            uCheckBoss.Name="uCheckBoss";
            uCheckBoss.Size=new Size(160, 25);
            uCheckBoss.TabIndex=13;
            uCheckBoss.Text="Access to BOSS";
            // 
            // uCheckInactive
            // 
            uCheckInactive.Enabled=false;
            uCheckInactive.Location=new Point(1000, 74);
            uCheckInactive.Margin=new Padding(4);
            uCheckInactive.Name="uCheckInactive";
            uCheckInactive.Size=new Size(160, 25);
            uCheckInactive.TabIndex=12;
            uCheckInactive.Text="Inactive";
            // 
            // UltraLabel6
            // 
            Appearance14.TextHAlignAsString="Right";
            UltraLabel6.Appearance=Appearance14;
            UltraLabel6.Location=new Point(75, 76);
            UltraLabel6.Margin=new Padding(4);
            UltraLabel6.Name="UltraLabel6";
            UltraLabel6.Size=new Size(76, 21);
            UltraLabel6.TabIndex=11;
            UltraLabel6.Text="Supervisor:";
            // 
            // uComboSupervisor
            // 
            Appearance15.BackColor=SystemColors.Window;
            Appearance15.BorderColor=SystemColors.InactiveCaption;
            uComboSupervisor.DisplayLayout.Appearance=Appearance15;
            uComboSupervisor.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            uComboSupervisor.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance16.BackColor=SystemColors.ActiveBorder;
            Appearance16.BackColor2=SystemColors.ControlDark;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance16.BorderColor=SystemColors.Window;
            uComboSupervisor.DisplayLayout.GroupByBox.Appearance=Appearance16;
            Appearance17.ForeColor=SystemColors.GrayText;
            uComboSupervisor.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance17;
            uComboSupervisor.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance18.BackColor=SystemColors.ControlLightLight;
            Appearance18.BackColor2=SystemColors.Control;
            Appearance18.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance18.ForeColor=SystemColors.GrayText;
            uComboSupervisor.DisplayLayout.GroupByBox.PromptAppearance=Appearance18;
            uComboSupervisor.DisplayLayout.MaxColScrollRegions=1;
            uComboSupervisor.DisplayLayout.MaxRowScrollRegions=1;
            Appearance19.BackColor=SystemColors.Window;
            Appearance19.ForeColor=SystemColors.ControlText;
            uComboSupervisor.DisplayLayout.Override.ActiveCellAppearance=Appearance19;
            Appearance20.BackColor=SystemColors.Highlight;
            Appearance20.ForeColor=SystemColors.HighlightText;
            uComboSupervisor.DisplayLayout.Override.ActiveRowAppearance=Appearance20;
            uComboSupervisor.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            uComboSupervisor.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance21.BackColor=SystemColors.Window;
            uComboSupervisor.DisplayLayout.Override.CardAreaAppearance=Appearance21;
            Appearance22.BorderColor=Color.Silver;
            Appearance22.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            uComboSupervisor.DisplayLayout.Override.CellAppearance=Appearance22;
            uComboSupervisor.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            uComboSupervisor.DisplayLayout.Override.CellPadding=0;
            Appearance23.BackColor=SystemColors.Control;
            Appearance23.BackColor2=SystemColors.ControlDark;
            Appearance23.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance23.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance23.BorderColor=SystemColors.Window;
            uComboSupervisor.DisplayLayout.Override.GroupByRowAppearance=Appearance23;
            Appearance24.TextHAlignAsString="Left";
            uComboSupervisor.DisplayLayout.Override.HeaderAppearance=Appearance24;
            uComboSupervisor.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            uComboSupervisor.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance25.BackColor=SystemColors.Window;
            Appearance25.BorderColor=Color.Silver;
            uComboSupervisor.DisplayLayout.Override.RowAppearance=Appearance25;
            uComboSupervisor.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance26.BackColor=SystemColors.ControlLight;
            uComboSupervisor.DisplayLayout.Override.TemplateAddRowAppearance=Appearance26;
            uComboSupervisor.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            uComboSupervisor.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            uComboSupervisor.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            uComboSupervisor.Location=new Point(159, 72);
            uComboSupervisor.Margin=new Padding(4);
            uComboSupervisor.Name="uComboSupervisor";
            uComboSupervisor.ReadOnly=true;
            uComboSupervisor.Size=new Size(331, 25);
            uComboSupervisor.TabIndex=4;
            uv1.GetValidationSettings(uComboSupervisor).IsRequired=true;
            uv1.GetValidationSettings(uComboSupervisor).NotificationSettings.Text="Supervisor is a required field.";
            uv1.GetValidationSettings(uComboSupervisor).ValidationGroupKey="vgText";
            // 
            // UltraLabel5
            // 
            Appearance27.TextHAlignAsString="Right";
            UltraLabel5.Appearance=Appearance27;
            UltraLabel5.Location=new Point(866, 32);
            UltraLabel5.Margin=new Padding(4);
            UltraLabel5.Name="UltraLabel5";
            UltraLabel5.Size=new Size(62, 21);
            UltraLabel5.TabIndex=9;
            UltraLabel5.Text="Position:";
            // 
            // uComboPositions
            // 
            Appearance28.BackColor=SystemColors.Window;
            Appearance28.BorderColor=SystemColors.InactiveCaption;
            uComboPositions.DisplayLayout.Appearance=Appearance28;
            uComboPositions.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            uComboPositions.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance29.BackColor=SystemColors.ActiveBorder;
            Appearance29.BackColor2=SystemColors.ControlDark;
            Appearance29.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance29.BorderColor=SystemColors.Window;
            uComboPositions.DisplayLayout.GroupByBox.Appearance=Appearance29;
            Appearance30.ForeColor=SystemColors.GrayText;
            uComboPositions.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance30;
            uComboPositions.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance31.BackColor=SystemColors.ControlLightLight;
            Appearance31.BackColor2=SystemColors.Control;
            Appearance31.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance31.ForeColor=SystemColors.GrayText;
            uComboPositions.DisplayLayout.GroupByBox.PromptAppearance=Appearance31;
            uComboPositions.DisplayLayout.MaxColScrollRegions=1;
            uComboPositions.DisplayLayout.MaxRowScrollRegions=1;
            Appearance32.BackColor=SystemColors.Window;
            Appearance32.ForeColor=SystemColors.ControlText;
            uComboPositions.DisplayLayout.Override.ActiveCellAppearance=Appearance32;
            Appearance33.BackColor=SystemColors.Highlight;
            Appearance33.ForeColor=SystemColors.HighlightText;
            uComboPositions.DisplayLayout.Override.ActiveRowAppearance=Appearance33;
            uComboPositions.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            uComboPositions.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance34.BackColor=SystemColors.Window;
            uComboPositions.DisplayLayout.Override.CardAreaAppearance=Appearance34;
            Appearance35.BorderColor=Color.Silver;
            Appearance35.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            uComboPositions.DisplayLayout.Override.CellAppearance=Appearance35;
            uComboPositions.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            uComboPositions.DisplayLayout.Override.CellPadding=0;
            Appearance36.BackColor=SystemColors.Control;
            Appearance36.BackColor2=SystemColors.ControlDark;
            Appearance36.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance36.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance36.BorderColor=SystemColors.Window;
            uComboPositions.DisplayLayout.Override.GroupByRowAppearance=Appearance36;
            Appearance37.TextHAlignAsString="Left";
            uComboPositions.DisplayLayout.Override.HeaderAppearance=Appearance37;
            uComboPositions.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            uComboPositions.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance38.BackColor=SystemColors.Window;
            Appearance38.BorderColor=Color.Silver;
            uComboPositions.DisplayLayout.Override.RowAppearance=Appearance38;
            uComboPositions.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance39.BackColor=SystemColors.ControlLight;
            uComboPositions.DisplayLayout.Override.TemplateAddRowAppearance=Appearance39;
            uComboPositions.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            uComboPositions.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            uComboPositions.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            uComboPositions.Location=new Point(936, 27);
            uComboPositions.Margin=new Padding(4);
            uComboPositions.Name="uComboPositions";
            uComboPositions.ReadOnly=true;
            uComboPositions.Size=new Size(249, 25);
            uComboPositions.TabIndex=3;
            uv1.GetValidationSettings(uComboPositions).IsRequired=true;
            uv1.GetValidationSettings(uComboPositions).NotificationSettings.Text="Position is a required field.";
            uv1.GetValidationSettings(uComboPositions).ValidationGroupKey="vgText";
            // 
            // utePassword
            // 
            utePassword.Location=new Point(872, 74);
            utePassword.Margin=new Padding(4);
            utePassword.MaxLength=10;
            utePassword.Name="utePassword";
            utePassword.PasswordChar='*';
            utePassword.ReadOnly=true;
            utePassword.Size=new Size(83, 24);
            utePassword.TabIndex=6;
            utePassword.Text="Password";
            uv1.GetValidationSettings(utePassword).IsRequired=true;
            uv1.GetValidationSettings(utePassword).NotificationSettings.Text="Password is a required field.";
            uv1.GetValidationSettings(utePassword).ValidationGroupKey="vgText";
            // 
            // UltraLabel4
            // 
            Appearance40.TextHAlignAsString="Right";
            UltraLabel4.Appearance=Appearance40;
            UltraLabel4.Location=new Point(785, 76);
            UltraLabel4.Margin=new Padding(4);
            UltraLabel4.Name="UltraLabel4";
            UltraLabel4.Size=new Size(72, 21);
            UltraLabel4.TabIndex=6;
            UltraLabel4.Text="Password:";
            // 
            // UltraLabel3
            // 
            Appearance41.TextHAlignAsString="Right";
            UltraLabel3.Appearance=Appearance41;
            UltraLabel3.Location=new Point(583, 76);
            UltraLabel3.Margin=new Padding(4);
            UltraLabel3.Name="UltraLabel3";
            UltraLabel3.Size=new Size(61, 21);
            UltraLabel3.TabIndex=5;
            UltraLabel3.Text="User ID:";
            // 
            // UltraLabel2
            // 
            Appearance42.TextHAlignAsString="Right";
            UltraLabel2.Appearance=Appearance42;
            UltraLabel2.Location=new Point(75, 32);
            UltraLabel2.Margin=new Padding(4);
            UltraLabel2.Name="UltraLabel2";
            UltraLabel2.Size=new Size(76, 21);
            UltraLabel2.TabIndex=4;
            UltraLabel2.Text="First Name:";
            // 
            // UltraLabel1
            // 
            Appearance43.TextHAlignAsString="Right";
            UltraLabel1.Appearance=Appearance43;
            UltraLabel1.Location=new Point(460, 32);
            UltraLabel1.Margin=new Padding(4);
            UltraLabel1.Name="UltraLabel1";
            UltraLabel1.Size=new Size(74, 21);
            UltraLabel1.TabIndex=3;
            UltraLabel1.Text="Last Name:";
            // 
            // uteFName
            // 
            uteFName.Location=new Point(157, 29);
            uteFName.Margin=new Padding(4);
            uteFName.MaxLength=30;
            uteFName.Name="uteFName";
            uteFName.ReadOnly=true;
            uteFName.Size=new Size(267, 24);
            uteFName.TabIndex=1;
            uteFName.Text="First name";
            uv1.GetValidationSettings(uteFName).IsRequired=true;
            uv1.GetValidationSettings(uteFName).NotificationSettings.Text="First Name is a required field.";
            uv1.GetValidationSettings(uteFName).ValidationGroupKey="vgText";
            // 
            // uteLName
            // 
            uteLName.Location=new Point(541, 27);
            uteLName.Margin=new Padding(4);
            uteLName.MaxLength=30;
            uteLName.Name="uteLName";
            uteLName.ReadOnly=true;
            uteLName.Size=new Size(267, 24);
            uteLName.TabIndex=2;
            uteLName.Text="Last Name";
            uv1.GetValidationSettings(uteLName).IsRequired=true;
            uv1.GetValidationSettings(uteLName).NotificationSettings.Text="Last Name is a required field.";
            uv1.GetValidationSettings(uteLName).ValidationGroupKey="vgText";
            // 
            // uteUserID
            // 
            uteUserID.Location=new Point(651, 74);
            uteUserID.Margin=new Padding(4);
            uteUserID.MaxLength=10;
            uteUserID.Name="uteUserID";
            uteUserID.ReadOnly=true;
            uteUserID.Size=new Size(97, 24);
            uteUserID.TabIndex=5;
            uteUserID.Text="User ID";
            uv1.GetValidationSettings(uteUserID).IsRequired=true;
            uv1.GetValidationSettings(uteUserID).NotificationSettings.Text="UserID is a required field.";
            uv1.GetValidationSettings(uteUserID).ValidationGroupKey="vgText";
            // 
            // ugbContactInfo
            // 
            ugbContactInfo.Controls.Add(UltraLabel15);
            ugbContactInfo.Controls.Add(uTeZip);
            ugbContactInfo.Controls.Add(UltraLabel12);
            ugbContactInfo.Controls.Add(UltraLabel13);
            ugbContactInfo.Controls.Add(uteCell);
            ugbContactInfo.Controls.Add(uteRadio);
            ugbContactInfo.Controls.Add(UltraLabel10);
            ugbContactInfo.Controls.Add(UltraLabel11);
            ugbContactInfo.Controls.Add(utePhone);
            ugbContactInfo.Controls.Add(uteFax);
            ugbContactInfo.Controls.Add(UltraLabel7);
            ugbContactInfo.Controls.Add(uComboState);
            ugbContactInfo.Controls.Add(UltraLabel8);
            ugbContactInfo.Controls.Add(UltraLabel9);
            ugbContactInfo.Controls.Add(uteAddress);
            ugbContactInfo.Controls.Add(uteCity);
            ugbContactInfo.Location=new Point(3, 465);
            ugbContactInfo.Margin=new Padding(4);
            ugbContactInfo.Name="ugbContactInfo";
            ugbContactInfo.Size=new Size(1216, 172);
            ugbContactInfo.TabIndex=6;
            ugbContactInfo.Text="Contact Information";
            // 
            // UltraLabel15
            // 
            Appearance44.TextHAlignAsString="Right";
            UltraLabel15.Appearance=Appearance44;
            UltraLabel15.Location=new Point(329, 97);
            UltraLabel15.Margin=new Padding(4);
            UltraLabel15.Name="UltraLabel15";
            UltraLabel15.Size=new Size(36, 21);
            UltraLabel15.TabIndex=26;
            UltraLabel15.Text="Zip:";
            // 
            // uTeZip
            // 
            uTeZip.Location=new Point(373, 95);
            uTeZip.Margin=new Padding(4);
            uTeZip.MaxLength=15;
            uTeZip.Name="uTeZip";
            uTeZip.ReadOnly=true;
            uTeZip.Size=new Size(160, 24);
            uTeZip.TabIndex=24;
            uTeZip.Text="Zip";
            // 
            // UltraLabel12
            // 
            Appearance45.TextHAlignAsString="Right";
            UltraLabel12.Appearance=Appearance45;
            UltraLabel12.Location=new Point(659, 26);
            UltraLabel12.Margin=new Padding(4);
            UltraLabel12.Name="UltraLabel12";
            UltraLabel12.Size=new Size(40, 21);
            UltraLabel12.TabIndex=23;
            UltraLabel12.Text="Cell:";
            // 
            // UltraLabel13
            // 
            Appearance46.TextHAlignAsString="Right";
            UltraLabel13.Appearance=Appearance46;
            UltraLabel13.Location=new Point(1025, 26);
            UltraLabel13.Margin=new Padding(4);
            UltraLabel13.Name="UltraLabel13";
            UltraLabel13.Size=new Size(45, 21);
            UltraLabel13.TabIndex=22;
            UltraLabel13.Text="Radio:";
            // 
            // uteCell
            // 
            uteCell.Location=new Point(708, 23);
            uteCell.Margin=new Padding(4);
            uteCell.MaxLength=15;
            uteCell.MinimumSize=new Size(124, 0);
            uteCell.Name="uteCell";
            uteCell.ReadOnly=true;
            uteCell.Size=new Size(124, 24);
            uteCell.TabIndex=21;
            uteCell.Text="Cell";
            // 
            // uteRadio
            // 
            uteRadio.Location=new Point(1080, 23);
            uteRadio.Margin=new Padding(4);
            uteRadio.MaxLength=15;
            uteRadio.MinimumSize=new Size(124, 0);
            uteRadio.Name="uteRadio";
            uteRadio.ReadOnly=true;
            uteRadio.Size=new Size(124, 24);
            uteRadio.TabIndex=20;
            uteRadio.Text="radio";
            // 
            // UltraLabel10
            // 
            Appearance47.TextHAlignAsString="Right";
            UltraLabel10.Appearance=Appearance47;
            UltraLabel10.Location=new Point(448, 26);
            UltraLabel10.Margin=new Padding(4);
            UltraLabel10.Name="UltraLabel10";
            UltraLabel10.Size=new Size(65, 21);
            UltraLabel10.TabIndex=19;
            UltraLabel10.Text="Phone:";
            // 
            // UltraLabel11
            // 
            Appearance48.TextHAlignAsString="Right";
            UltraLabel11.Appearance=Appearance48;
            UltraLabel11.Location=new Point(843, 26);
            UltraLabel11.Margin=new Padding(4);
            UltraLabel11.Name="UltraLabel11";
            UltraLabel11.Size=new Size(37, 21);
            UltraLabel11.TabIndex=18;
            UltraLabel11.Text="Fax:";
            // 
            // utePhone
            // 
            utePhone.Location=new Point(524, 23);
            utePhone.Margin=new Padding(4);
            utePhone.MaxLength=15;
            utePhone.MinimumSize=new Size(124, 0);
            utePhone.Name="utePhone";
            utePhone.ReadOnly=true;
            utePhone.Size=new Size(124, 24);
            utePhone.TabIndex=17;
            utePhone.Text="1-850-555-1212";
            // 
            // uteFax
            // 
            uteFax.Location=new Point(891, 23);
            uteFax.Margin=new Padding(4);
            uteFax.MaxLength=15;
            uteFax.MinimumSize=new Size(124, 0);
            uteFax.Name="uteFax";
            uteFax.ReadOnly=true;
            uteFax.Size=new Size(124, 24);
            uteFax.TabIndex=16;
            uteFax.Text="fax";
            // 
            // UltraLabel7
            // 
            Appearance49.TextHAlignAsString="Right";
            UltraLabel7.Appearance=Appearance49;
            UltraLabel7.Location=new Point(52, 97);
            UltraLabel7.Margin=new Padding(4);
            UltraLabel7.Name="UltraLabel7";
            UltraLabel7.Size=new Size(99, 21);
            UltraLabel7.TabIndex=15;
            UltraLabel7.Text="State:";
            // 
            // uComboState
            // 
            Appearance50.BackColor=SystemColors.Window;
            Appearance50.BorderColor=SystemColors.InactiveCaption;
            uComboState.DisplayLayout.Appearance=Appearance50;
            uComboState.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            uComboState.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance51.BackColor=SystemColors.ActiveBorder;
            Appearance51.BackColor2=SystemColors.ControlDark;
            Appearance51.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance51.BorderColor=SystemColors.Window;
            uComboState.DisplayLayout.GroupByBox.Appearance=Appearance51;
            Appearance52.ForeColor=SystemColors.GrayText;
            uComboState.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance52;
            uComboState.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance53.BackColor=SystemColors.ControlLightLight;
            Appearance53.BackColor2=SystemColors.Control;
            Appearance53.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance53.ForeColor=SystemColors.GrayText;
            uComboState.DisplayLayout.GroupByBox.PromptAppearance=Appearance53;
            uComboState.DisplayLayout.MaxColScrollRegions=1;
            uComboState.DisplayLayout.MaxRowScrollRegions=1;
            Appearance54.BackColor=SystemColors.Window;
            Appearance54.ForeColor=SystemColors.ControlText;
            uComboState.DisplayLayout.Override.ActiveCellAppearance=Appearance54;
            Appearance55.BackColor=SystemColors.Highlight;
            Appearance55.ForeColor=SystemColors.HighlightText;
            uComboState.DisplayLayout.Override.ActiveRowAppearance=Appearance55;
            uComboState.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            uComboState.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance56.BackColor=SystemColors.Window;
            uComboState.DisplayLayout.Override.CardAreaAppearance=Appearance56;
            Appearance57.BorderColor=Color.Silver;
            Appearance57.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            uComboState.DisplayLayout.Override.CellAppearance=Appearance57;
            uComboState.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            uComboState.DisplayLayout.Override.CellPadding=0;
            Appearance58.BackColor=SystemColors.Control;
            Appearance58.BackColor2=SystemColors.ControlDark;
            Appearance58.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance58.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance58.BorderColor=SystemColors.Window;
            uComboState.DisplayLayout.Override.GroupByRowAppearance=Appearance58;
            Appearance59.TextHAlignAsString="Left";
            uComboState.DisplayLayout.Override.HeaderAppearance=Appearance59;
            uComboState.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            uComboState.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance60.BackColor=SystemColors.Window;
            Appearance60.BorderColor=Color.Silver;
            uComboState.DisplayLayout.Override.RowAppearance=Appearance60;
            uComboState.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance61.BackColor=SystemColors.ControlLight;
            uComboState.DisplayLayout.Override.TemplateAddRowAppearance=Appearance61;
            uComboState.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            uComboState.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            uComboState.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            uComboState.Location=new Point(159, 94);
            uComboState.Margin=new Padding(4);
            uComboState.Name="uComboState";
            uComboState.ReadOnly=true;
            uComboState.Size=new Size(156, 25);
            uComboState.TabIndex=14;
            uComboState.Text="States";
            // 
            // UltraLabel8
            // 
            Appearance62.TextHAlignAsString="Right";
            UltraLabel8.Appearance=Appearance62;
            UltraLabel8.Location=new Point(17, 26);
            UltraLabel8.Margin=new Padding(4);
            UltraLabel8.Name="UltraLabel8";
            UltraLabel8.Size=new Size(133, 21);
            UltraLabel8.TabIndex=13;
            UltraLabel8.Text="Address:";
            // 
            // UltraLabel9
            // 
            Appearance63.TextHAlignAsString="Right";
            UltraLabel9.Appearance=Appearance63;
            UltraLabel9.Location=new Point(52, 62);
            UltraLabel9.Margin=new Padding(4);
            UltraLabel9.Name="UltraLabel9";
            UltraLabel9.Size=new Size(99, 21);
            UltraLabel9.TabIndex=12;
            UltraLabel9.Text="City:";
            // 
            // uteAddress
            // 
            uteAddress.Location=new Point(157, 23);
            uteAddress.Margin=new Padding(4);
            uteAddress.MaxLength=50;
            uteAddress.Name="uteAddress";
            uteAddress.ReadOnly=true;
            uteAddress.Size=new Size(267, 24);
            uteAddress.TabIndex=11;
            uteAddress.Text="Address";
            // 
            // uteCity
            // 
            uteCity.Location=new Point(159, 59);
            uteCity.Margin=new Padding(4);
            uteCity.MaxLength=30;
            uteCity.Name="uteCity";
            uteCity.ReadOnly=true;
            uteCity.Size=new Size(161, 24);
            uteCity.TabIndex=10;
            uteCity.Text="city";
            // 
            // UltraLabel16
            // 
            UltraLabel16.Location=new Point(65, 665);
            UltraLabel16.Margin=new Padding(4);
            UltraLabel16.Name="UltraLabel16";
            UltraLabel16.Size=new Size(452, 28);
            UltraLabel16.TabIndex=7;
            UltraLabel16.Text="To see Security for this user, go to Position Maintenance Screen";
            // 
            // grdNotifyList
            // 
            Appearance64.BackColor=SystemColors.Window;
            Appearance64.BorderColor=SystemColors.InactiveCaption;
            grdNotifyList.DisplayLayout.Appearance=Appearance64;
            grdNotifyList.DisplayLayout.AutoFitStyle=Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            UltraGridBand2.ColHeaderLines=2;
            grdNotifyList.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            grdNotifyList.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNotifyList.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance65.BackColor=SystemColors.ActiveBorder;
            Appearance65.BackColor2=SystemColors.ControlDark;
            Appearance65.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance65.BorderColor=SystemColors.Window;
            grdNotifyList.DisplayLayout.GroupByBox.Appearance=Appearance65;
            Appearance66.ForeColor=SystemColors.GrayText;
            grdNotifyList.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance66;
            grdNotifyList.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            grdNotifyList.DisplayLayout.GroupByBox.Hidden=true;
            Appearance67.BackColor=SystemColors.ControlLightLight;
            Appearance67.BackColor2=SystemColors.Control;
            Appearance67.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance67.ForeColor=SystemColors.GrayText;
            grdNotifyList.DisplayLayout.GroupByBox.PromptAppearance=Appearance67;
            grdNotifyList.DisplayLayout.MaxColScrollRegions=1;
            grdNotifyList.DisplayLayout.MaxRowScrollRegions=1;
            Appearance68.BackColor=SystemColors.Window;
            Appearance68.ForeColor=SystemColors.ControlText;
            grdNotifyList.DisplayLayout.Override.ActiveCellAppearance=Appearance68;
            Appearance69.BackColor=SystemColors.Highlight;
            Appearance69.ForeColor=SystemColors.HighlightText;
            grdNotifyList.DisplayLayout.Override.ActiveRowAppearance=Appearance69;
            grdNotifyList.DisplayLayout.Override.AllowColMoving=Infragistics.Win.UltraWinGrid.AllowColMoving.NotAllowed;
            grdNotifyList.DisplayLayout.Override.AllowColSizing=Infragistics.Win.UltraWinGrid.AllowColSizing.Free;
            grdNotifyList.DisplayLayout.Override.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            grdNotifyList.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            grdNotifyList.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance70.BackColor=SystemColors.Window;
            grdNotifyList.DisplayLayout.Override.CardAreaAppearance=Appearance70;
            Appearance71.BorderColor=Color.Silver;
            Appearance71.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            grdNotifyList.DisplayLayout.Override.CellAppearance=Appearance71;
            grdNotifyList.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            grdNotifyList.DisplayLayout.Override.CellPadding=0;
            Appearance72.BackColor=SystemColors.Control;
            Appearance72.BackColor2=SystemColors.ControlDark;
            Appearance72.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance72.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance72.BorderColor=SystemColors.Window;
            grdNotifyList.DisplayLayout.Override.GroupByRowAppearance=Appearance72;
            Appearance73.TextHAlignAsString="Left";
            grdNotifyList.DisplayLayout.Override.HeaderAppearance=Appearance73;
            grdNotifyList.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortSingle;
            grdNotifyList.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance74.BackColor=SystemColors.Window;
            Appearance74.BorderColor=Color.Silver;
            grdNotifyList.DisplayLayout.Override.RowAppearance=Appearance74;
            grdNotifyList.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.True;
            grdNotifyList.DisplayLayout.Override.SelectTypeRow=Infragistics.Win.UltraWinGrid.SelectType.Single;
            Appearance75.BackColor=SystemColors.ControlLight;
            grdNotifyList.DisplayLayout.Override.TemplateAddRowAppearance=Appearance75;
            grdNotifyList.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            grdNotifyList.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            grdNotifyList.DisplayLayout.UseFixedHeaders=true;
            grdNotifyList.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            grdNotifyList.Location=new Point(552, 665);
            grdNotifyList.Margin=new Padding(4);
            grdNotifyList.Name="grdNotifyList";
            grdNotifyList.Size=new Size(280, 263);
            grdNotifyList.TabIndex=8;
            grdNotifyList.Text="Notify";
            // 
            // uv1
            // 
            ValidationGroup1.Key="vgText";
            uv1.ValidationGroups.Add(ValidationGroup1);
            // 
            // Label8
            // 
            Label8.AutoSize=true;
            Label8.Font=new Font("Microsoft Sans Serif", 9.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label8.ForeColor=Color.Red;
            Label8.Location=new Point(583, 105);
            Label8.Name="Label8";
            Label8.Size=new Size(16, 20);
            Label8.TabIndex=31;
            Label8.Text="*";
            // 
            // UltraLabel14
            // 
            Appearance13.TextHAlignAsString="Right";
            UltraLabel14.Appearance=Appearance13;
            UltraLabel14.Location=new Point(587, 108);
            UltraLabel14.Margin=new Padding(4);
            UltraLabel14.Name="UltraLabel14";
            UltraLabel14.Size=new Size(57, 21);
            UltraLabel14.TabIndex=30;
            UltraLabel14.Text="eMail:";
            // 
            // uteeMail
            // 
            uteeMail.Location=new Point(651, 105);
            uteeMail.Margin=new Padding(4);
            uteeMail.MaxLength=50;
            uteeMail.Name="uteeMail";
            uteeMail.ReadOnly=true;
            uteeMail.Size=new Size(267, 24);
            uteeMail.TabIndex=7;
            uteeMail.Text="eMail";
            uv1.GetValidationSettings(uteeMail).IsRequired=true;
            uv1.GetValidationSettings(uteeMail).NotificationSettings.Text="EMail is a required field.";
            uv1.GetValidationSettings(uteeMail).ValidationGroupKey="vgText";
            // 
            // UserMaintenance
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1232, 918);
            Controls.Add(grdNotifyList);
            Controls.Add(UltraLabel16);
            Controls.Add(ugbContactInfo);
            Controls.Add(ugbSecurity);
            Controls.Add(tsToolStrip);
            Controls.Add(grdUsers);
            Margin=new Padding(4);
            Name="UserMaintenance";
            Text="UserMaintenance";
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdUsers).EndInit();
            ugbSecurity.ResumeLayout(false);
            ugbSecurity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uCheckBossman).EndInit();
            ((System.ComponentModel.ISupportInitialize)uCheckCA).EndInit();
            ((System.ComponentModel.ISupportInitialize)uCheckTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)uCheckBoss).EndInit();
            ((System.ComponentModel.ISupportInitialize)uCheckInactive).EndInit();
            ((System.ComponentModel.ISupportInitialize)uComboSupervisor).EndInit();
            ((System.ComponentModel.ISupportInitialize)uComboPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)utePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteFName).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteLName).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteUserID).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugbContactInfo).EndInit();
            ugbContactInfo.ResumeLayout(false);
            ugbContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uTeZip).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteCell).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteRadio).EndInit();
            ((System.ComponentModel.ISupportInitialize)utePhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteFax).EndInit();
            ((System.ComponentModel.ISupportInitialize)uComboState).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteAddress).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteCity).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdNotifyList).EndInit();
            ((System.ComponentModel.ISupportInitialize)uv1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uteeMail).EndInit();
            Load+=new EventHandler(UserMaintenance_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnTip;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdUsers;
        internal GroupBox ugbSecurity;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor utePassword;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel4;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel3;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel2;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel1;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteFName;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteLName;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteUserID;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel5;
        internal Infragistics.Win.UltraWinGrid.UltraCombo uComboPositions;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uCheckBossman;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uCheckCA;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uCheckTest;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uCheckBoss;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uCheckInactive;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel6;
        internal Infragistics.Win.UltraWinGrid.UltraCombo uComboSupervisor;
        internal Infragistics.Win.Misc.UltraGroupBox ugbContactInfo;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel15;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uTeZip;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel12;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel13;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteCell;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteRadio;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel10;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel11;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor utePhone;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteFax;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel7;
        internal Infragistics.Win.UltraWinGrid.UltraCombo uComboState;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel8;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel9;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteAddress;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteCity;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel16;
        internal Infragistics.Win.UltraWinGrid.UltraGrid grdNotifyList;
        internal Label Label7;
        internal Label Label6;
        internal Label Label5;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Infragistics.Win.Misc.UltraValidator uv1;
        internal Label Label8;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel14;
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteeMail;
    }
}