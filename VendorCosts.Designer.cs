using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class VendorCosts : Form
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
            var UltraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetVendorsInUse", -1);
            var UltraGridColumn113 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vendorid");
            var UltraGridColumn114 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vdrName");
            var UltraGridColumn115 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vdrFax");
            var UltraGridColumn116 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DrawsExist");
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
            var UltraGridBand2 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetTaxDistrictList", -1);
            var UltraGridColumn117 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn118 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict");
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
            var UltraGridBand3 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1);
            var UltraGridColumn119 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn120 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn121 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn122 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn123 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn124 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
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
            var UltraGridBand4 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAlphaCodes", -1);
            var UltraGridColumn125 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCode");
            var UltraGridColumn126 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            var UltraGridColumn127 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("alphaid");
            var UltraGridColumn128 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxable");
            var UltraGridColumn129 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("GroupCode");
            var UltraGridColumn130 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("POMessage");
            var UltraGridColumn131 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WCPerc");
            var UltraGridColumn132 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaGroupID");
            var UltraGridColumn133 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PAVendorOnly");
            var UltraGridColumn134 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCodeDescription");
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorCosts));
            var Appearance49 = new Infragistics.Win.Appearance();
            var Appearance50 = new Infragistics.Win.Appearance();
            var Appearance51 = new Infragistics.Win.Appearance();
            var Appearance52 = new Infragistics.Win.Appearance();
            var Appearance53 = new Infragistics.Win.Appearance();
            var UltraGridBand5 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetAlphaCodes", -1);
            var UltraGridColumn135 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCode");
            var UltraGridColumn136 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Description");
            var UltraGridColumn137 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("alphaid");
            var UltraGridColumn138 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Taxable");
            var UltraGridColumn139 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("GroupCode");
            var UltraGridColumn140 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("POMessage");
            var UltraGridColumn141 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("WCPerc");
            var UltraGridColumn142 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaGroupID");
            var UltraGridColumn143 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PAVendorOnly");
            var UltraGridColumn144 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("AlphaCodeDescription");
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
            var Appearance65 = new Infragistics.Win.Appearance();
            var Appearance66 = new Infragistics.Win.Appearance();
            var Appearance67 = new Infragistics.Win.Appearance();
            var Appearance68 = new Infragistics.Win.Appearance();
            var Appearance69 = new Infragistics.Win.Appearance();
            var Appearance70 = new Infragistics.Win.Appearance();
            var UltraGridBand6 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetTaxDistrictList", -1);
            var UltraGridColumn145 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn146 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitDistrict");
            var Appearance71 = new Infragistics.Win.Appearance();
            var Appearance72 = new Infragistics.Win.Appearance();
            var Appearance73 = new Infragistics.Win.Appearance();
            var Appearance74 = new Infragistics.Win.Appearance();
            var Appearance75 = new Infragistics.Win.Appearance();
            var Appearance76 = new Infragistics.Win.Appearance();
            var Appearance77 = new Infragistics.Win.Appearance();
            var Appearance78 = new Infragistics.Win.Appearance();
            var Appearance79 = new Infragistics.Win.Appearance();
            var Appearance80 = new Infragistics.Win.Appearance();
            var Appearance81 = new Infragistics.Win.Appearance();
            var Appearance82 = new Infragistics.Win.Appearance();
            var Appearance83 = new Infragistics.Win.Appearance();
            var UltraGridBand7 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetOpenProjects", -1);
            var UltraGridColumn147 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectID");
            var UltraGridColumn148 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ProjectName");
            var UltraGridColumn149 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn150 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("TaxPermitID");
            var UltraGridColumn151 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("StandardPlan");
            var UltraGridColumn152 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Markup");
            var Appearance84 = new Infragistics.Win.Appearance();
            var Appearance85 = new Infragistics.Win.Appearance();
            var Appearance86 = new Infragistics.Win.Appearance();
            var Appearance87 = new Infragistics.Win.Appearance();
            var Appearance88 = new Infragistics.Win.Appearance();
            var Appearance89 = new Infragistics.Win.Appearance();
            var Appearance90 = new Infragistics.Win.Appearance();
            var Appearance91 = new Infragistics.Win.Appearance();
            var Appearance92 = new Infragistics.Win.Appearance();
            var Appearance93 = new Infragistics.Win.Appearance();
            var Appearance94 = new Infragistics.Win.Appearance();
            var Appearance95 = new Infragistics.Win.Appearance();
            var Appearance96 = new Infragistics.Win.Appearance();
            var Appearance97 = new Infragistics.Win.Appearance();
            var Appearance98 = new Infragistics.Win.Appearance();
            var Appearance99 = new Infragistics.Win.Appearance();
            var Appearance100 = new Infragistics.Win.Appearance();
            var Appearance101 = new Infragistics.Win.Appearance();
            var Appearance102 = new Infragistics.Win.Appearance();
            var UltraGridBand8 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            var UltraGridColumn153 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Selected", 0);
            var UltraGridColumn154 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Criteria", 1);
            var UltraGridColumn155 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Cost", 2);
            var UltraGridColumn156 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("NoChg", 3, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Ascending, false);
            var UltraGridColumn157 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Pending", 4);
            var UltraGridColumn158 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Alt", 5);
            var UltraGridColumn159 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("VendorAssignedID", 6);
            var Appearance103 = new Infragistics.Win.Appearance();
            var Appearance104 = new Infragistics.Win.Appearance();
            var Appearance105 = new Infragistics.Win.Appearance();
            var Appearance106 = new Infragistics.Win.Appearance();
            var Appearance107 = new Infragistics.Win.Appearance();
            var Appearance108 = new Infragistics.Win.Appearance();
            var Appearance109 = new Infragistics.Win.Appearance();
            var Appearance110 = new Infragistics.Win.Appearance();
            var Appearance111 = new Infragistics.Win.Appearance();
            var Appearance112 = new Infragistics.Win.Appearance();
            var Appearance113 = new Infragistics.Win.Appearance();
            var Appearance114 = new Infragistics.Win.Appearance();
            var Appearance115 = new Infragistics.Win.Appearance();
            var UltraGridBand9 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetResourcesByAlpha", -1);
            var UltraGridColumn160 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceID");
            var UltraGridColumn161 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ID");
            var UltraGridColumn162 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("ResourceName");
            var UltraGridColumn163 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("UM");
            var UltraGridColumn164 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("Inactive");
            var Appearance116 = new Infragistics.Win.Appearance();
            var Appearance117 = new Infragistics.Win.Appearance();
            var Appearance118 = new Infragistics.Win.Appearance();
            var Appearance119 = new Infragistics.Win.Appearance();
            var Appearance120 = new Infragistics.Win.Appearance();
            var Appearance121 = new Infragistics.Win.Appearance();
            var Appearance122 = new Infragistics.Win.Appearance();
            var Appearance123 = new Infragistics.Win.Appearance();
            var Appearance124 = new Infragistics.Win.Appearance();
            var Appearance125 = new Infragistics.Win.Appearance();
            var Appearance126 = new Infragistics.Win.Appearance();
            var Appearance127 = new Infragistics.Win.Appearance();
            var Appearance128 = new Infragistics.Win.Appearance();
            var Appearance129 = new Infragistics.Win.Appearance();
            var Appearance130 = new Infragistics.Win.Appearance();
            var Appearance131 = new Infragistics.Win.Appearance();
            var Appearance132 = new Infragistics.Win.Appearance();
            var Appearance133 = new Infragistics.Win.Appearance();
            var Appearance134 = new Infragistics.Win.Appearance();
            var Appearance135 = new Infragistics.Win.Appearance();
            var Appearance136 = new Infragistics.Win.Appearance();
            var Appearance137 = new Infragistics.Win.Appearance();
            var UltraGridBand10 = new Infragistics.Win.UltraWinGrid.UltraGridBand("spGetVendorsInUse", -1);
            var UltraGridColumn165 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vendorid");
            var UltraGridColumn166 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vdrName");
            var UltraGridColumn167 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("vdrFax");
            var UltraGridColumn168 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("DrawsExist");
            var Appearance138 = new Infragistics.Win.Appearance();
            var Appearance139 = new Infragistics.Win.Appearance();
            var Appearance140 = new Infragistics.Win.Appearance();
            var Appearance141 = new Infragistics.Win.Appearance();
            var Appearance142 = new Infragistics.Win.Appearance();
            var Appearance143 = new Infragistics.Win.Appearance();
            var Appearance144 = new Infragistics.Win.Appearance();
            var Appearance145 = new Infragistics.Win.Appearance();
            var Appearance146 = new Infragistics.Win.Appearance();
            var Appearance147 = new Infragistics.Win.Appearance();
            var Appearance148 = new Infragistics.Win.Appearance();
            var Appearance161 = new Infragistics.Win.Appearance();
            var Appearance162 = new Infragistics.Win.Appearance();
            var Appearance163 = new Infragistics.Win.Appearance();
            var Appearance164 = new Infragistics.Win.Appearance();
            var Appearance165 = new Infragistics.Win.Appearance();
            var Appearance166 = new Infragistics.Win.Appearance();
            var Appearance167 = new Infragistics.Win.Appearance();
            var Appearance168 = new Infragistics.Win.Appearance();
            var Appearance169 = new Infragistics.Win.Appearance();
            var Appearance170 = new Infragistics.Win.Appearance();
            var Appearance171 = new Infragistics.Win.Appearance();
            var Appearance172 = new Infragistics.Win.Appearance();
            var Appearance149 = new Infragistics.Win.Appearance();
            var Appearance150 = new Infragistics.Win.Appearance();
            var Appearance151 = new Infragistics.Win.Appearance();
            var Appearance152 = new Infragistics.Win.Appearance();
            var Appearance153 = new Infragistics.Win.Appearance();
            var Appearance154 = new Infragistics.Win.Appearance();
            var Appearance155 = new Infragistics.Win.Appearance();
            var Appearance156 = new Infragistics.Win.Appearance();
            var Appearance157 = new Infragistics.Win.Appearance();
            var Appearance158 = new Infragistics.Win.Appearance();
            var Appearance159 = new Infragistics.Win.Appearance();
            var Appearance160 = new Infragistics.Win.Appearance();
            var LabelTool1 = new Infragistics.Win.UltraWinToolbars.LabelTool("AddAlpha");
            var LabelTool2 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeCriteriaForVendor");
            var LabelTool3 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeDates");
            var LabelTool4 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeVendor");
            var LabelTool6 = new Infragistics.Win.UltraWinToolbars.LabelTool("CopyCriteria");
            var LabelTool7 = new Infragistics.Win.UltraWinToolbars.LabelTool("MarkAlternate");
            var LabelTool8 = new Infragistics.Win.UltraWinToolbars.LabelTool("UnmarkAlternate");
            var LabelTool9 = new Infragistics.Win.UltraWinToolbars.LabelTool("MarkPending");
            var LabelTool10 = new Infragistics.Win.UltraWinToolbars.LabelTool("NotPending");
            var UltraToolbar1 = new Infragistics.Win.UltraWinToolbars.UltraToolbar("utAssignedfVendors");
            var LabelTool11 = new Infragistics.Win.UltraWinToolbars.LabelTool("AddAlpha");
            var LabelTool12 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeCriteriaForVendor");
            var LabelTool13 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeDates");
            var LabelTool14 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeVendor");
            var LabelTool16 = new Infragistics.Win.UltraWinToolbars.LabelTool("CopyCriteria");
            var LabelTool17 = new Infragistics.Win.UltraWinToolbars.LabelTool("MarkAlternate");
            var LabelTool18 = new Infragistics.Win.UltraWinToolbars.LabelTool("UnmarkAlternate");
            var LabelTool19 = new Infragistics.Win.UltraWinToolbars.LabelTool("MarkPending");
            var LabelTool20 = new Infragistics.Win.UltraWinToolbars.LabelTool("NotPending");
            var PopupMenuTool1 = new Infragistics.Win.UltraWinToolbars.PopupMenuTool("PopupAssoignedVendors");
            var LabelTool21 = new Infragistics.Win.UltraWinToolbars.LabelTool("AddAlpha");
            var LabelTool22 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeCriteriaForVendor");
            var LabelTool23 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeDates");
            var LabelTool24 = new Infragistics.Win.UltraWinToolbars.LabelTool("ChangeVendor");
            var LabelTool25 = new Infragistics.Win.UltraWinToolbars.LabelTool("CopyCriteria");
            var LabelTool27 = new Infragistics.Win.UltraWinToolbars.LabelTool("MarkAlternate");
            var LabelTool28 = new Infragistics.Win.UltraWinToolbars.LabelTool("UnmarkAlternate");
            var LabelTool29 = new Infragistics.Win.UltraWinToolbars.LabelTool("NotPending");
            var LabelTool30 = new Infragistics.Win.UltraWinToolbars.LabelTool("MarkPending");
            upFilters=new Infragistics.Win.Misc.UltraPanel();
            uceIncludeCAPrices=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceIncludeHistory=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceIncludeGenericSubs=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceIncludePending=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceHideNotInUse=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceFutureOnly=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            ucVendors=new Infragistics.Win.UltraWinGrid.UltraCombo();
            SpGetVendorsInUseBindingSource=new BindingSource(components);
            HCHDataDSVendorCost=new HCHDataDSVendorCost();
            ucDistricts=new Infragistics.Win.UltraWinGrid.UltraCombo();
            SpGetTaxDistrictListBindingSource=new BindingSource(components);
            ucProjects=new Infragistics.Win.UltraWinGrid.UltraCombo();
            SpGetOpenProjectsBindingSource=new BindingSource(components);
            ucAlphaCodes=new Infragistics.Win.UltraWinGrid.UltraCombo();
            SpGetAlphaCodesBindingSource=new BindingSource(components);
            urbNoCriteriaFilter=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            UltraRadioButtonGroupManager3=new Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager(components);
            UltraRadioButtonGroupManager3.SelectionChanged+=new EventHandler<Infragistics.Win.UltraWinEditors.RadioButtonGroupManagerSelectionChangedEventArgs>(UltraRadioButtonGroupManager3_SelectionChanged);
            urbFilterByGlobal=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            urbFilterByDistrict=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            urbFilterByProject=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            uceFilterByAlphaCode=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceFilterByAlphaCode.CheckedChanged+=new EventHandler(uceFilterByAlphaCode_CheckedChanged);
            uceFilterByVendor=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            uceFilterByVendor.CheckedChanged+=new EventHandler(uceFilterByVendor_CheckedChanged);
            tsToolStrip=new ToolStrip();
            tsBtnAdd=new ToolStripButton();
            tsBtnEdit=new ToolStripButton();
            tsBtnUndo=new ToolStripButton();
            tsBtnDelete=new ToolStripButton();
            tsBtnSave=new ToolStripButton();
            tsButtonHelp=new ToolStripButton();
            ToolStripSeparator1=new ToolStripSeparator();
            ToolStripSeparator2=new ToolStripSeparator();
            tsBtnPrint=new ToolStripButton();
            tsBtnFind=new ToolStripButton();
            ulFilters=new Infragistics.Win.Misc.UltraLabel();
            upAddAlpha=new Infragistics.Win.Misc.UltraPanel();
            upAddAlphs=new Infragistics.Win.Misc.UltraPanel();
            ulCriteriaAddAlpha=new Infragistics.Win.Misc.UltraLabel();
            ulCriteria=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel2=new Infragistics.Win.Misc.UltraLabel();
            ucAddAlpha=new Infragistics.Win.UltraWinGrid.UltraCombo();
            uceSelectAllResources=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            ubCancelUpdatedCosts=new Infragistics.Win.Misc.UltraButton();
            ubSaveUpdatedCosts=new Infragistics.Win.Misc.UltraButton();
            UltraLabel4=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel3=new Infragistics.Win.Misc.UltraLabel();
            udtToAddAlpha=new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            udtFromAddAlpha=new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            ulUpdateCosts=new Infragistics.Win.Misc.UltraLabel();
            upCopyToAnotherCriteria=new Infragistics.Win.Misc.UltraPanel();
            upCopyToAnotherCriteria.PaintClient+=new PaintEventHandler(upCopyToAnotherCriteria_PaintClient);
            upDates=new Infragistics.Win.Misc.UltraPanel();
            UltraLabel7=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel8=new Infragistics.Win.Misc.UltraLabel();
            udteToCriteria=new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            udteFromCriteriaToCopy=new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            ucDistrictToCopy=new Infragistics.Win.UltraWinGrid.UltraCombo();
            ulCopyToAnotherCriteria=new Infragistics.Win.Misc.UltraLabel();
            ubCancelSaveAnotherCriteria=new Infragistics.Win.Misc.UltraButton();
            ubSaveAnotherCriteria=new Infragistics.Win.Misc.UltraButton();
            uceCopyAllResourcesForCriteria=new Infragistics.Win.UltraWinEditors.UltraCheckEditor();
            ucProjectToCopy=new Infragistics.Win.UltraWinGrid.UltraCombo();
            urbGlobal=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            UltraRadioButtonGroupManager1=new Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager(components);
            UltraRadioButtonGroupManager1.SelectionChanged+=new EventHandler<Infragistics.Win.UltraWinEditors.RadioButtonGroupManagerSelectionChangedEventArgs>(UltraRadioButtonGroupManager1_SelectionChanged);
            urbDistricts=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            urbProjects=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            ulAlphaCodeSelected=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel14=new Infragistics.Win.Misc.UltraLabel();
            ulVendorSelected=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel12=new Infragistics.Win.Misc.UltraLabel();
            ulCriteriaSelected=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel10=new Infragistics.Win.Misc.UltraLabel();
            upAddResources=new Infragistics.Win.Misc.UltraPanel();
            UltraLabel20=new Infragistics.Win.Misc.UltraLabel();
            ugResources=new Infragistics.Win.UltraWinGrid.UltraGrid();
            UltraLabel11=new Infragistics.Win.Misc.UltraLabel();
            ubCancelNewResources=new Infragistics.Win.Misc.UltraButton();
            ubSaveNewResources=new Infragistics.Win.Misc.UltraButton();
            ucResources=new Infragistics.Win.UltraWinGrid.UltraCombo();
            SpGetResourcesByAlphaBindingSource=new BindingSource(components);
            UltraLabel13=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel15=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel16=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel17=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel18=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel19=new Infragistics.Win.Misc.UltraLabel();
            upCopyToAnotherVendor=new Infragistics.Win.Misc.UltraPanel();
            UltraLabel26=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel25=new Infragistics.Win.Misc.UltraLabel();
            urbHistoryNewVendor=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            UltraRadioButtonGroupManager2=new Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager(components);
            ubCancelNewVendor=new Infragistics.Win.Misc.UltraButton();
            ubSaveNewVendor=new Infragistics.Win.Misc.UltraButton();
            UltraLabel23=new Infragistics.Win.Misc.UltraLabel();
            UltraLabel24=new Infragistics.Win.Misc.UltraLabel();
            udteToNewVendor=new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            udteFromNewVendor=new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            ucNewVendor=new Infragistics.Win.UltraWinGrid.UltraCombo();
            urbPendingNewVendor=new Infragistics.Win.UltraWinEditors.UltraRadioButton();
            ugAssignedVendors=new Infragistics.Win.UltraWinGrid.UltraGrid();
            ugCosts=new Infragistics.Win.UltraWinGrid.UltraGrid();
            _VendorCosts_Toolbars_Dock_Area_Left=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _VendorCosts_Toolbars_Dock_Area_Right=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _VendorCosts_Toolbars_Dock_Area_Top=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            _VendorCosts_Toolbars_Dock_Area_Bottom=new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            UltraPopupControlContainer1=new Infragistics.Win.Misc.UltraPopupControlContainer(components);
            SpGetVendorsInUseTableAdapter=new HCHDataDSVendorCostTableAdapters.spGetVendorsInUseTableAdapter();
            SpGetAlphaCodesTableAdapter=new HCHDataDSVendorCostTableAdapters.spGetAlphaCodesTableAdapter();
            SpGetOpenProjectsTableAdapter=new HCHDataDSVendorCostTableAdapters.spGetOpenProjectsTableAdapter();
            SpGetTaxDistrictListTableAdapter=new HCHDataDSVendorCostTableAdapters.spGetTaxDistrictListTableAdapter();
            SpGetResourcesByAlphaTableAdapter=new HCHDataDSVendorCostTableAdapters.spGetResourcesByAlphaTableAdapter();
            utmAssignedVendors=new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(components);
            utmAssignedVendors.ToolClick+=new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(utmAssignedVendors_ToolClick);
            upFilters.ClientArea.SuspendLayout();
            upFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uceIncludeCAPrices).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceIncludeHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceIncludeGenericSubs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceIncludePending).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceHideNotInUse).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceFutureOnly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucVendors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetVendorsInUseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDSVendorCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucDistricts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetTaxDistrictListBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetOpenProjectsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucAlphaCodes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAlphaCodesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbNoCriteriaFilter).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraRadioButtonGroupManager3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbFilterByGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbFilterByDistrict).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbFilterByProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceFilterByAlphaCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceFilterByVendor).BeginInit();
            tsToolStrip.SuspendLayout();
            upAddAlpha.ClientArea.SuspendLayout();
            upAddAlpha.SuspendLayout();
            upAddAlphs.ClientArea.SuspendLayout();
            upAddAlphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucAddAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceSelectAllResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udtToAddAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udtFromAddAlpha).BeginInit();
            upCopyToAnotherCriteria.ClientArea.SuspendLayout();
            upCopyToAnotherCriteria.SuspendLayout();
            upDates.ClientArea.SuspendLayout();
            upDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)udteToCriteria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udteFromCriteriaToCopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucDistrictToCopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uceCopyAllResourcesForCriteria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectToCopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbGlobal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraRadioButtonGroupManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbDistricts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbProjects).BeginInit();
            upAddResources.ClientArea.SuspendLayout();
            upAddResources.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ugResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucResources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpGetResourcesByAlphaBindingSource).BeginInit();
            upCopyToAnotherVendor.ClientArea.SuspendLayout();
            upCopyToAnotherVendor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)urbHistoryNewVendor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraRadioButtonGroupManager2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udteToNewVendor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)udteFromNewVendor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucNewVendor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)urbPendingNewVendor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugAssignedVendors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ugCosts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)utmAssignedVendors).BeginInit();
            SuspendLayout();
            // 
            // upFilters
            // 
            // 
            // upFilters.ClientArea
            // 
            upFilters.ClientArea.Controls.Add(uceIncludeCAPrices);
            upFilters.ClientArea.Controls.Add(uceIncludeHistory);
            upFilters.ClientArea.Controls.Add(uceIncludeGenericSubs);
            upFilters.ClientArea.Controls.Add(uceIncludePending);
            upFilters.ClientArea.Controls.Add(uceHideNotInUse);
            upFilters.ClientArea.Controls.Add(uceFutureOnly);
            upFilters.ClientArea.Controls.Add(ucVendors);
            upFilters.ClientArea.Controls.Add(ucDistricts);
            upFilters.ClientArea.Controls.Add(ucProjects);
            upFilters.ClientArea.Controls.Add(ucAlphaCodes);
            upFilters.ClientArea.Controls.Add(urbNoCriteriaFilter);
            upFilters.ClientArea.Controls.Add(urbFilterByGlobal);
            upFilters.ClientArea.Controls.Add(urbFilterByDistrict);
            upFilters.ClientArea.Controls.Add(urbFilterByProject);
            upFilters.ClientArea.Controls.Add(uceFilterByAlphaCode);
            upFilters.ClientArea.Controls.Add(uceFilterByVendor);
            upFilters.Location=new Point(32, 81);
            upFilters.Margin=new Padding(8, 7, 8, 7);
            upFilters.Name="upFilters";
            upFilters.Size=new Size(2885, 298);
            upFilters.TabIndex=0;
            // 
            // uceIncludeCAPrices
            // 
            uceIncludeCAPrices.Location=new Point(889, 215);
            uceIncludeCAPrices.Margin=new Padding(8, 7, 8, 7);
            uceIncludeCAPrices.Name="uceIncludeCAPrices";
            uceIncludeCAPrices.Size=new Size(443, 48);
            uceIncludeCAPrices.TabIndex=25;
            uceIncludeCAPrices.Text="Include Cost Analysis Prices";
            // 
            // uceIncludeHistory
            // 
            uceIncludeHistory.Location=new Point(0, 162);
            uceIncludeHistory.Margin=new Padding(8, 7, 8, 7);
            uceIncludeHistory.Name="uceIncludeHistory";
            uceIncludeHistory.Size=new Size(352, 48);
            uceIncludeHistory.TabIndex=24;
            uceIncludeHistory.Text="Include History";
            // 
            // uceIncludeGenericSubs
            // 
            uceIncludeGenericSubs.Location=new Point(0, 215);
            uceIncludeGenericSubs.Margin=new Padding(8, 7, 8, 7);
            uceIncludeGenericSubs.Name="uceIncludeGenericSubs";
            uceIncludeGenericSubs.Size=new Size(352, 48);
            uceIncludeGenericSubs.TabIndex=23;
            uceIncludeGenericSubs.Text="Include Generic Subs";
            // 
            // uceIncludePending
            // 
            uceIncludePending.Location=new Point(521, 164);
            uceIncludePending.Margin=new Padding(8, 7, 8, 7);
            uceIncludePending.Name="uceIncludePending";
            uceIncludePending.Size=new Size(352, 48);
            uceIncludePending.TabIndex=22;
            uceIncludePending.Text="Include Pending";
            // 
            // uceHideNotInUse
            // 
            uceHideNotInUse.Location=new Point(521, 215);
            uceHideNotInUse.Margin=new Padding(8, 7, 8, 7);
            uceHideNotInUse.Name="uceHideNotInUse";
            uceHideNotInUse.Size=new Size(352, 48);
            uceHideNotInUse.TabIndex=21;
            uceHideNotInUse.Text="Hide Not In Use";
            // 
            // uceFutureOnly
            // 
            uceFutureOnly.Location=new Point(889, 164);
            uceFutureOnly.Margin=new Padding(8, 7, 8, 7);
            uceFutureOnly.Name="uceFutureOnly";
            uceFutureOnly.Size=new Size(352, 48);
            uceFutureOnly.TabIndex=20;
            uceFutureOnly.Text="Future Only";
            // 
            // ucVendors
            // 
            ucVendors.DataSource=SpGetVendorsInUseBindingSource;
            Appearance1.BackColor=SystemColors.Window;
            Appearance1.BorderColor=SystemColors.InactiveCaption;
            ucVendors.DisplayLayout.Appearance=Appearance1;
            UltraGridColumn113.Header.VisiblePosition=0;
            UltraGridColumn114.Header.VisiblePosition=1;
            UltraGridColumn115.Header.VisiblePosition=2;
            UltraGridColumn116.Header.VisiblePosition=3;
            UltraGridBand1.Columns.AddRange(new object[] { UltraGridColumn113, UltraGridColumn114, UltraGridColumn115, UltraGridColumn116 });
            ucVendors.DisplayLayout.BandsSerializer.Add(UltraGridBand1);
            ucVendors.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucVendors.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance2.BackColor=SystemColors.ActiveBorder;
            Appearance2.BackColor2=SystemColors.ControlDark;
            Appearance2.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance2.BorderColor=SystemColors.Window;
            ucVendors.DisplayLayout.GroupByBox.Appearance=Appearance2;
            Appearance3.ForeColor=SystemColors.GrayText;
            ucVendors.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance3;
            ucVendors.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance4.BackColor=SystemColors.ControlLightLight;
            Appearance4.BackColor2=SystemColors.Control;
            Appearance4.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance4.ForeColor=SystemColors.GrayText;
            ucVendors.DisplayLayout.GroupByBox.PromptAppearance=Appearance4;
            ucVendors.DisplayLayout.MaxColScrollRegions=1;
            ucVendors.DisplayLayout.MaxRowScrollRegions=1;
            Appearance5.BackColor=SystemColors.Window;
            Appearance5.ForeColor=SystemColors.ControlText;
            ucVendors.DisplayLayout.Override.ActiveCellAppearance=Appearance5;
            Appearance6.BackColor=SystemColors.Highlight;
            Appearance6.ForeColor=SystemColors.HighlightText;
            ucVendors.DisplayLayout.Override.ActiveRowAppearance=Appearance6;
            ucVendors.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucVendors.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance7.BackColor=SystemColors.Window;
            ucVendors.DisplayLayout.Override.CardAreaAppearance=Appearance7;
            Appearance8.BorderColor=Color.Silver;
            Appearance8.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucVendors.DisplayLayout.Override.CellAppearance=Appearance8;
            ucVendors.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucVendors.DisplayLayout.Override.CellPadding=0;
            Appearance9.BackColor=SystemColors.Control;
            Appearance9.BackColor2=SystemColors.ControlDark;
            Appearance9.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance9.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance9.BorderColor=SystemColors.Window;
            ucVendors.DisplayLayout.Override.GroupByRowAppearance=Appearance9;
            Appearance10.TextHAlignAsString="Left";
            ucVendors.DisplayLayout.Override.HeaderAppearance=Appearance10;
            ucVendors.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucVendors.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance11.BackColor=SystemColors.Window;
            Appearance11.BorderColor=Color.Silver;
            ucVendors.DisplayLayout.Override.RowAppearance=Appearance11;
            ucVendors.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance12.BackColor=SystemColors.ControlLight;
            ucVendors.DisplayLayout.Override.TemplateAddRowAppearance=Appearance12;
            ucVendors.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucVendors.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucVendors.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucVendors.DisplayMember="vdrName";
            ucVendors.Location=new Point(373, 12);
            ucVendors.Name="ucVendors";
            ucVendors.Size=new Size(556, 42);
            ucVendors.TabIndex=19;
            ucVendors.ValueMember="vendorid";
            // 
            // SpGetVendorsInUseBindingSource
            // 
            SpGetVendorsInUseBindingSource.DataMember="spGetVendorsInUse";
            SpGetVendorsInUseBindingSource.DataSource=HCHDataDSVendorCost;
            // 
            // HCHDataDSVendorCost
            // 
            HCHDataDSVendorCost.DataSetName="HCHDataDSVendorCost";
            HCHDataDSVendorCost.SchemaSerializationMode=SchemaSerializationMode.IncludeSchema;
            // 
            // ucDistricts
            // 
            ucDistricts.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucDistricts.DataSource=SpGetTaxDistrictListBindingSource;
            Appearance13.BackColor=SystemColors.Window;
            Appearance13.BorderColor=SystemColors.InactiveCaption;
            ucDistricts.DisplayLayout.Appearance=Appearance13;
            UltraGridColumn117.Header.VisiblePosition=0;
            UltraGridColumn118.Header.VisiblePosition=1;
            UltraGridBand2.Columns.AddRange(new object[] { UltraGridColumn117, UltraGridColumn118 });
            ucDistricts.DisplayLayout.BandsSerializer.Add(UltraGridBand2);
            ucDistricts.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucDistricts.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance14.BackColor=SystemColors.ActiveBorder;
            Appearance14.BackColor2=SystemColors.ControlDark;
            Appearance14.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance14.BorderColor=SystemColors.Window;
            ucDistricts.DisplayLayout.GroupByBox.Appearance=Appearance14;
            Appearance15.ForeColor=SystemColors.GrayText;
            ucDistricts.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance15;
            ucDistricts.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance16.BackColor=SystemColors.ControlLightLight;
            Appearance16.BackColor2=SystemColors.Control;
            Appearance16.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance16.ForeColor=SystemColors.GrayText;
            ucDistricts.DisplayLayout.GroupByBox.PromptAppearance=Appearance16;
            ucDistricts.DisplayLayout.MaxColScrollRegions=1;
            ucDistricts.DisplayLayout.MaxRowScrollRegions=1;
            Appearance17.BackColor=SystemColors.Window;
            Appearance17.ForeColor=SystemColors.ControlText;
            ucDistricts.DisplayLayout.Override.ActiveCellAppearance=Appearance17;
            Appearance18.BackColor=SystemColors.Highlight;
            Appearance18.ForeColor=SystemColors.HighlightText;
            ucDistricts.DisplayLayout.Override.ActiveRowAppearance=Appearance18;
            ucDistricts.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucDistricts.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance19.BackColor=SystemColors.Window;
            ucDistricts.DisplayLayout.Override.CardAreaAppearance=Appearance19;
            Appearance20.BorderColor=Color.Silver;
            Appearance20.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucDistricts.DisplayLayout.Override.CellAppearance=Appearance20;
            ucDistricts.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucDistricts.DisplayLayout.Override.CellPadding=0;
            Appearance21.BackColor=SystemColors.Control;
            Appearance21.BackColor2=SystemColors.ControlDark;
            Appearance21.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance21.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance21.BorderColor=SystemColors.Window;
            ucDistricts.DisplayLayout.Override.GroupByRowAppearance=Appearance21;
            Appearance22.TextHAlignAsString="Left";
            ucDistricts.DisplayLayout.Override.HeaderAppearance=Appearance22;
            ucDistricts.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucDistricts.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance23.BackColor=SystemColors.Window;
            Appearance23.BorderColor=Color.Silver;
            ucDistricts.DisplayLayout.Override.RowAppearance=Appearance23;
            ucDistricts.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance24.BackColor=SystemColors.ControlLight;
            ucDistricts.DisplayLayout.Override.TemplateAddRowAppearance=Appearance24;
            ucDistricts.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucDistricts.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucDistricts.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucDistricts.DisplayMember="TaxPermitDistrict";
            ucDistricts.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucDistricts.Location=new Point(2143, 75);
            ucDistricts.Margin=new Padding(5, 7, 5, 7);
            ucDistricts.Name="ucDistricts";
            ucDistricts.Size=new Size(503, 42);
            ucDistricts.TabIndex=18;
            ucDistricts.ValueMember="TaxPermitID";
            // 
            // SpGetTaxDistrictListBindingSource
            // 
            SpGetTaxDistrictListBindingSource.DataMember="spGetTaxDistrictList";
            SpGetTaxDistrictListBindingSource.DataSource=HCHDataDSVendorCost;
            // 
            // ucProjects
            // 
            ucProjects.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucProjects.DataSource=SpGetOpenProjectsBindingSource;
            Appearance25.BackColor=SystemColors.Window;
            Appearance25.BorderColor=SystemColors.InactiveCaption;
            ucProjects.DisplayLayout.Appearance=Appearance25;
            UltraGridColumn119.Header.VisiblePosition=0;
            UltraGridColumn120.Header.VisiblePosition=1;
            UltraGridColumn121.Header.VisiblePosition=2;
            UltraGridColumn122.Header.VisiblePosition=3;
            UltraGridColumn123.Header.VisiblePosition=4;
            UltraGridColumn124.Header.VisiblePosition=5;
            UltraGridBand3.Columns.AddRange(new object[] { UltraGridColumn119, UltraGridColumn120, UltraGridColumn121, UltraGridColumn122, UltraGridColumn123, UltraGridColumn124 });
            ucProjects.DisplayLayout.BandsSerializer.Add(UltraGridBand3);
            ucProjects.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucProjects.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance26.BackColor=SystemColors.ActiveBorder;
            Appearance26.BackColor2=SystemColors.ControlDark;
            Appearance26.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance26.BorderColor=SystemColors.Window;
            ucProjects.DisplayLayout.GroupByBox.Appearance=Appearance26;
            Appearance27.ForeColor=SystemColors.GrayText;
            ucProjects.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance27;
            ucProjects.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance28.BackColor=SystemColors.ControlLightLight;
            Appearance28.BackColor2=SystemColors.Control;
            Appearance28.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance28.ForeColor=SystemColors.GrayText;
            ucProjects.DisplayLayout.GroupByBox.PromptAppearance=Appearance28;
            ucProjects.DisplayLayout.MaxColScrollRegions=1;
            ucProjects.DisplayLayout.MaxRowScrollRegions=1;
            Appearance29.BackColor=SystemColors.Window;
            Appearance29.ForeColor=SystemColors.ControlText;
            ucProjects.DisplayLayout.Override.ActiveCellAppearance=Appearance29;
            Appearance30.BackColor=SystemColors.Highlight;
            Appearance30.ForeColor=SystemColors.HighlightText;
            ucProjects.DisplayLayout.Override.ActiveRowAppearance=Appearance30;
            ucProjects.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucProjects.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance31.BackColor=SystemColors.Window;
            ucProjects.DisplayLayout.Override.CardAreaAppearance=Appearance31;
            Appearance32.BorderColor=Color.Silver;
            Appearance32.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucProjects.DisplayLayout.Override.CellAppearance=Appearance32;
            ucProjects.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucProjects.DisplayLayout.Override.CellPadding=0;
            Appearance33.BackColor=SystemColors.Control;
            Appearance33.BackColor2=SystemColors.ControlDark;
            Appearance33.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance33.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance33.BorderColor=SystemColors.Window;
            ucProjects.DisplayLayout.Override.GroupByRowAppearance=Appearance33;
            Appearance34.TextHAlignAsString="Left";
            ucProjects.DisplayLayout.Override.HeaderAppearance=Appearance34;
            ucProjects.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucProjects.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance35.BackColor=SystemColors.Window;
            Appearance35.BorderColor=Color.Silver;
            ucProjects.DisplayLayout.Override.RowAppearance=Appearance35;
            ucProjects.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance36.BackColor=SystemColors.ControlLight;
            ucProjects.DisplayLayout.Override.TemplateAddRowAppearance=Appearance36;
            ucProjects.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucProjects.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucProjects.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucProjects.DisplayMember="ProjectID";
            ucProjects.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucProjects.Location=new Point(2143, 19);
            ucProjects.Margin=new Padding(5, 7, 5, 7);
            ucProjects.Name="ucProjects";
            ucProjects.Size=new Size(503, 42);
            ucProjects.TabIndex=17;
            ucProjects.ValueMember="ID";
            // 
            // SpGetOpenProjectsBindingSource
            // 
            SpGetOpenProjectsBindingSource.DataMember="spGetOpenProjects";
            SpGetOpenProjectsBindingSource.DataSource=HCHDataDSVendorCost;
            // 
            // ucAlphaCodes
            // 
            ucAlphaCodes.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucAlphaCodes.DataSource=SpGetAlphaCodesBindingSource;
            Appearance37.BackColor=SystemColors.Window;
            Appearance37.BorderColor=SystemColors.InactiveCaption;
            ucAlphaCodes.DisplayLayout.Appearance=Appearance37;
            UltraGridColumn125.Header.VisiblePosition=0;
            UltraGridColumn126.Header.VisiblePosition=1;
            UltraGridColumn127.Header.VisiblePosition=2;
            UltraGridColumn128.Header.VisiblePosition=3;
            UltraGridColumn129.Header.VisiblePosition=4;
            UltraGridColumn130.Header.VisiblePosition=5;
            UltraGridColumn131.Header.VisiblePosition=6;
            UltraGridColumn132.Header.VisiblePosition=7;
            UltraGridColumn133.Header.VisiblePosition=8;
            UltraGridColumn134.Header.VisiblePosition=9;
            UltraGridBand4.Columns.AddRange(new object[] { UltraGridColumn125, UltraGridColumn126, UltraGridColumn127, UltraGridColumn128, UltraGridColumn129, UltraGridColumn130, UltraGridColumn131, UltraGridColumn132, UltraGridColumn133, UltraGridColumn134 });
            ucAlphaCodes.DisplayLayout.BandsSerializer.Add(UltraGridBand4);
            ucAlphaCodes.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucAlphaCodes.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance38.BackColor=SystemColors.ActiveBorder;
            Appearance38.BackColor2=SystemColors.ControlDark;
            Appearance38.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance38.BorderColor=SystemColors.Window;
            ucAlphaCodes.DisplayLayout.GroupByBox.Appearance=Appearance38;
            Appearance39.ForeColor=SystemColors.GrayText;
            ucAlphaCodes.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance39;
            ucAlphaCodes.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance40.BackColor=SystemColors.ControlLightLight;
            Appearance40.BackColor2=SystemColors.Control;
            Appearance40.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance40.ForeColor=SystemColors.GrayText;
            ucAlphaCodes.DisplayLayout.GroupByBox.PromptAppearance=Appearance40;
            ucAlphaCodes.DisplayLayout.MaxColScrollRegions=1;
            ucAlphaCodes.DisplayLayout.MaxRowScrollRegions=1;
            Appearance41.BackColor=SystemColors.Window;
            Appearance41.ForeColor=SystemColors.ControlText;
            ucAlphaCodes.DisplayLayout.Override.ActiveCellAppearance=Appearance41;
            Appearance42.BackColor=SystemColors.Highlight;
            Appearance42.ForeColor=SystemColors.HighlightText;
            ucAlphaCodes.DisplayLayout.Override.ActiveRowAppearance=Appearance42;
            ucAlphaCodes.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucAlphaCodes.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance43.BackColor=SystemColors.Window;
            ucAlphaCodes.DisplayLayout.Override.CardAreaAppearance=Appearance43;
            Appearance44.BorderColor=Color.Silver;
            Appearance44.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucAlphaCodes.DisplayLayout.Override.CellAppearance=Appearance44;
            ucAlphaCodes.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucAlphaCodes.DisplayLayout.Override.CellPadding=0;
            Appearance45.BackColor=SystemColors.Control;
            Appearance45.BackColor2=SystemColors.ControlDark;
            Appearance45.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance45.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance45.BorderColor=SystemColors.Window;
            ucAlphaCodes.DisplayLayout.Override.GroupByRowAppearance=Appearance45;
            Appearance46.TextHAlignAsString="Left";
            ucAlphaCodes.DisplayLayout.Override.HeaderAppearance=Appearance46;
            ucAlphaCodes.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucAlphaCodes.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance47.BackColor=SystemColors.Window;
            Appearance47.BorderColor=Color.Silver;
            ucAlphaCodes.DisplayLayout.Override.RowAppearance=Appearance47;
            ucAlphaCodes.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance48.BackColor=SystemColors.ControlLight;
            ucAlphaCodes.DisplayLayout.Override.TemplateAddRowAppearance=Appearance48;
            ucAlphaCodes.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucAlphaCodes.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucAlphaCodes.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucAlphaCodes.DisplayMember="AlphaCodeDescription";
            ucAlphaCodes.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucAlphaCodes.DropDownWidth=0;
            ucAlphaCodes.Location=new Point(373, 69);
            ucAlphaCodes.Margin=new Padding(5, 7, 5, 7);
            ucAlphaCodes.Name="ucAlphaCodes";
            ucAlphaCodes.Size=new Size(556, 42);
            ucAlphaCodes.TabIndex=16;
            ucAlphaCodes.ValueMember="alphaid";
            // 
            // SpGetAlphaCodesBindingSource
            // 
            SpGetAlphaCodesBindingSource.DataMember="spGetAlphaCodes";
            SpGetAlphaCodesBindingSource.DataSource=HCHDataDSVendorCost;
            // 
            // urbNoCriteriaFilter
            // 
            urbNoCriteriaFilter.GroupManager=UltraRadioButtonGroupManager3;
            urbNoCriteriaFilter.Location=new Point(1799, 184);
            urbNoCriteriaFilter.Margin=new Padding(8, 7, 8, 7);
            urbNoCriteriaFilter.Name="urbNoCriteriaFilter";
            urbNoCriteriaFilter.Size=new Size(320, 48);
            urbNoCriteriaFilter.TabIndex=5;
            urbNoCriteriaFilter.Text="No Criteria Filter";
            // 
            // UltraRadioButtonGroupManager3
            // 
            // 
            // urbFilterByGlobal
            // 
            urbFilterByGlobal.GroupManager=UltraRadioButtonGroupManager3;
            urbFilterByGlobal.Location=new Point(1799, 127);
            urbFilterByGlobal.Margin=new Padding(8, 7, 8, 7);
            urbFilterByGlobal.Name="urbFilterByGlobal";
            urbFilterByGlobal.Size=new Size(320, 48);
            urbFilterByGlobal.TabIndex=4;
            urbFilterByGlobal.Text="Filter by Global";
            // 
            // urbFilterByDistrict
            // 
            urbFilterByDistrict.GroupManager=UltraRadioButtonGroupManager3;
            urbFilterByDistrict.Location=new Point(1799, 70);
            urbFilterByDistrict.Margin=new Padding(8, 7, 8, 7);
            urbFilterByDistrict.Name="urbFilterByDistrict";
            urbFilterByDistrict.Size=new Size(320, 48);
            urbFilterByDistrict.TabIndex=3;
            urbFilterByDistrict.Text="Filter by District";
            // 
            // urbFilterByProject
            // 
            urbFilterByProject.GroupManager=UltraRadioButtonGroupManager3;
            urbFilterByProject.Location=new Point(1799, 13);
            urbFilterByProject.Margin=new Padding(8, 7, 8, 7);
            urbFilterByProject.Name="urbFilterByProject";
            urbFilterByProject.Size=new Size(320, 48);
            urbFilterByProject.TabIndex=2;
            urbFilterByProject.Text="Filter by Project";
            // 
            // uceFilterByAlphaCode
            // 
            uceFilterByAlphaCode.Location=new Point(8, 69);
            uceFilterByAlphaCode.Margin=new Padding(8, 7, 8, 7);
            uceFilterByAlphaCode.Name="uceFilterByAlphaCode";
            uceFilterByAlphaCode.Size=new Size(352, 48);
            uceFilterByAlphaCode.TabIndex=1;
            uceFilterByAlphaCode.Text="Filter by Alpha Code:";
            // 
            // uceFilterByVendor
            // 
            uceFilterByVendor.Location=new Point(8, 7);
            uceFilterByVendor.Margin=new Padding(8, 7, 8, 7);
            uceFilterByVendor.Name="uceFilterByVendor";
            uceFilterByVendor.Size=new Size(320, 48);
            uceFilterByVendor.TabIndex=0;
            uceFilterByVendor.Text="Filter by Vendor:";
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize=new Size(24, 24);
            tsToolStrip.Items.AddRange(new ToolStripItem[] { tsBtnAdd, tsBtnEdit, tsBtnUndo, tsBtnDelete, tsBtnSave, tsButtonHelp, ToolStripSeparator1, ToolStripSeparator2, tsBtnPrint, tsBtnFind });
            tsToolStrip.Location=new Point(0, 73);
            tsToolStrip.Name="tsToolStrip";
            tsToolStrip.Padding=new Padding(0, 0, 5, 0);
            tsToolStrip.Size=new Size(2949, 35);
            tsToolStrip.Stretch=true;
            tsToolStrip.TabIndex=10;
            tsToolStrip.Text="ToolStrip1";
            // 
            // tsBtnAdd
            // 
            tsBtnAdd.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnAdd.Enabled=false;
            tsBtnAdd.Image=(Image)resources.GetObject("tsBtnAdd.Image");
            tsBtnAdd.ImageTransparentColor=Color.Magenta;
            tsBtnAdd.Name="tsBtnAdd";
            tsBtnAdd.Size=new Size(58, 28);
            tsBtnAdd.Text="Add New";
            tsBtnAdd.ToolTipText="Click to Add New Record";
            // 
            // tsBtnEdit
            // 
            tsBtnEdit.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnEdit.Image=(Image)resources.GetObject("tsBtnEdit.Image");
            tsBtnEdit.ImageTransparentColor=Color.Magenta;
            tsBtnEdit.Name="tsBtnEdit";
            tsBtnEdit.Size=new Size(58, 28);
            tsBtnEdit.Text="Edit";
            tsBtnEdit.ToolTipText="Click to Edit Records";
            // 
            // tsBtnUndo
            // 
            tsBtnUndo.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnUndo.Enabled=false;
            tsBtnUndo.Image=(Image)resources.GetObject("tsBtnUndo.Image");
            tsBtnUndo.ImageTransparentColor=Color.Magenta;
            tsBtnUndo.Name="tsBtnUndo";
            tsBtnUndo.Size=new Size(58, 28);
            tsBtnUndo.Text="Cancel Changes";
            tsBtnUndo.ToolTipText="Click to Cancel Changes";
            // 
            // tsBtnDelete
            // 
            tsBtnDelete.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnDelete.Enabled=false;
            tsBtnDelete.Image=(Image)resources.GetObject("tsBtnDelete.Image");
            tsBtnDelete.ImageTransparentColor=Color.Magenta;
            tsBtnDelete.Name="tsBtnDelete";
            tsBtnDelete.Size=new Size(58, 28);
            tsBtnDelete.Text="Delete";
            // 
            // tsBtnSave
            // 
            tsBtnSave.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnSave.Enabled=false;
            tsBtnSave.Image=(Image)resources.GetObject("tsBtnSave.Image");
            tsBtnSave.ImageTransparentColor=Color.Magenta;
            tsBtnSave.Name="tsBtnSave";
            tsBtnSave.Size=new Size(58, 28);
            tsBtnSave.Text="Save";
            tsBtnSave.ToolTipText="Click to Save Changes";
            // 
            // tsButtonHelp
            // 
            tsButtonHelp.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsButtonHelp.Enabled=false;
            tsButtonHelp.Image=(Image)resources.GetObject("tsButtonHelp.Image");
            tsButtonHelp.ImageTransparentColor=Color.Magenta;
            tsButtonHelp.Name="tsButtonHelp";
            tsButtonHelp.Size=new Size(58, 28);
            tsButtonHelp.Text="He&lp";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name="ToolStripSeparator1";
            ToolStripSeparator1.Size=new Size(6, 35);
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name="ToolStripSeparator2";
            ToolStripSeparator2.Size=new Size(6, 35);
            // 
            // tsBtnPrint
            // 
            tsBtnPrint.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnPrint.Image=My.Resources.Resources.Print;
            tsBtnPrint.ImageTransparentColor=Color.Magenta;
            tsBtnPrint.Name="tsBtnPrint";
            tsBtnPrint.Size=new Size(58, 28);
            tsBtnPrint.Text="Print";
            // 
            // tsBtnFind
            // 
            tsBtnFind.DisplayStyle=ToolStripItemDisplayStyle.Image;
            tsBtnFind.Image=(Image)resources.GetObject("tsBtnFind.Image");
            tsBtnFind.ImageTransparentColor=Color.Magenta;
            tsBtnFind.Name="tsBtnFind";
            tsBtnFind.Size=new Size(58, 28);
            tsBtnFind.Text="Search";
            // 
            // ulFilters
            // 
            Appearance49.ForeColor=Color.Blue;
            Appearance49.TextHAlignAsString="Center";
            Appearance49.TextVAlignAsString="Middle";
            ulFilters.Appearance=Appearance49;
            ulFilters.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            ulFilters.Font=new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Point, 0);
            ulFilters.Location=new Point(32, 401);
            ulFilters.Name="ulFilters";
            ulFilters.Size=new Size(2882, 65);
            ulFilters.TabIndex=11;
            ulFilters.Text="No Filters";
            // 
            // upAddAlpha
            // 
            // 
            // upAddAlpha.ClientArea
            // 
            upAddAlpha.ClientArea.Controls.Add(upAddAlphs);
            upAddAlpha.ClientArea.Controls.Add(ubCancelUpdatedCosts);
            upAddAlpha.ClientArea.Controls.Add(ubSaveUpdatedCosts);
            upAddAlpha.ClientArea.Controls.Add(UltraLabel4);
            upAddAlpha.ClientArea.Controls.Add(UltraLabel3);
            upAddAlpha.ClientArea.Controls.Add(udtToAddAlpha);
            upAddAlpha.ClientArea.Controls.Add(udtFromAddAlpha);
            upAddAlpha.ClientArea.Controls.Add(ulUpdateCosts);
            upAddAlpha.Location=new Point(230, 46);
            upAddAlpha.Name="upAddAlpha";
            upAddAlpha.Size=new Size(862, 639);
            upAddAlpha.TabIndex=13;
            upAddAlpha.Visible=false;
            // 
            // upAddAlphs
            // 
            // 
            // upAddAlphs.ClientArea
            // 
            upAddAlphs.ClientArea.Controls.Add(ulCriteriaAddAlpha);
            upAddAlphs.ClientArea.Controls.Add(ulCriteria);
            upAddAlphs.ClientArea.Controls.Add(UltraLabel2);
            upAddAlphs.ClientArea.Controls.Add(ucAddAlpha);
            upAddAlphs.ClientArea.Controls.Add(uceSelectAllResources);
            upAddAlphs.Location=new Point(26, 77);
            upAddAlphs.Name="upAddAlphs";
            upAddAlphs.Size=new Size(814, 313);
            upAddAlphs.TabIndex=35;
            // 
            // ulCriteriaAddAlpha
            // 
            Appearance50.TextHAlignAsString="Left";
            ulCriteriaAddAlpha.Appearance=Appearance50;
            ulCriteriaAddAlpha.Location=new Point(258, 99);
            ulCriteriaAddAlpha.Name="ulCriteriaAddAlpha";
            ulCriteriaAddAlpha.Size=new Size(556, 40);
            ulCriteriaAddAlpha.TabIndex=36;
            // 
            // ulCriteria
            // 
            Appearance51.TextHAlignAsString="Right";
            ulCriteria.Appearance=Appearance51;
            ulCriteria.Location=new Point(0, 99);
            ulCriteria.Name="ulCriteria";
            ulCriteria.Size=new Size(229, 40);
            ulCriteria.TabIndex=35;
            ulCriteria.Text="Criteria Selected:";
            // 
            // UltraLabel2
            // 
            Appearance52.TextHAlignAsString="Right";
            UltraLabel2.Appearance=Appearance52;
            UltraLabel2.Location=new Point(0, 41);
            UltraLabel2.Name="UltraLabel2";
            UltraLabel2.Size=new Size(229, 40);
            UltraLabel2.TabIndex=34;
            UltraLabel2.Text="Alpha Codes:";
            // 
            // ucAddAlpha
            // 
            ucAddAlpha.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucAddAlpha.DataSource=SpGetAlphaCodesBindingSource;
            Appearance53.BackColor=SystemColors.Window;
            Appearance53.BorderColor=SystemColors.InactiveCaption;
            ucAddAlpha.DisplayLayout.Appearance=Appearance53;
            UltraGridColumn135.Header.VisiblePosition=0;
            UltraGridColumn136.Header.VisiblePosition=1;
            UltraGridColumn137.Header.VisiblePosition=2;
            UltraGridColumn138.Header.VisiblePosition=3;
            UltraGridColumn139.Header.VisiblePosition=4;
            UltraGridColumn140.Header.VisiblePosition=5;
            UltraGridColumn141.Header.VisiblePosition=6;
            UltraGridColumn142.Header.VisiblePosition=7;
            UltraGridColumn143.Header.VisiblePosition=8;
            UltraGridColumn144.Header.VisiblePosition=9;
            UltraGridBand5.Columns.AddRange(new object[] { UltraGridColumn135, UltraGridColumn136, UltraGridColumn137, UltraGridColumn138, UltraGridColumn139, UltraGridColumn140, UltraGridColumn141, UltraGridColumn142, UltraGridColumn143, UltraGridColumn144 });
            ucAddAlpha.DisplayLayout.BandsSerializer.Add(UltraGridBand5);
            ucAddAlpha.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucAddAlpha.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance54.BackColor=SystemColors.ActiveBorder;
            Appearance54.BackColor2=SystemColors.ControlDark;
            Appearance54.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance54.BorderColor=SystemColors.Window;
            ucAddAlpha.DisplayLayout.GroupByBox.Appearance=Appearance54;
            Appearance55.ForeColor=SystemColors.GrayText;
            ucAddAlpha.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance55;
            ucAddAlpha.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance56.BackColor=SystemColors.ControlLightLight;
            Appearance56.BackColor2=SystemColors.Control;
            Appearance56.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance56.ForeColor=SystemColors.GrayText;
            ucAddAlpha.DisplayLayout.GroupByBox.PromptAppearance=Appearance56;
            ucAddAlpha.DisplayLayout.MaxColScrollRegions=1;
            ucAddAlpha.DisplayLayout.MaxRowScrollRegions=1;
            Appearance57.BackColor=SystemColors.Window;
            Appearance57.ForeColor=SystemColors.ControlText;
            ucAddAlpha.DisplayLayout.Override.ActiveCellAppearance=Appearance57;
            Appearance58.BackColor=SystemColors.Highlight;
            Appearance58.ForeColor=SystemColors.HighlightText;
            ucAddAlpha.DisplayLayout.Override.ActiveRowAppearance=Appearance58;
            ucAddAlpha.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucAddAlpha.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance59.BackColor=SystemColors.Window;
            ucAddAlpha.DisplayLayout.Override.CardAreaAppearance=Appearance59;
            Appearance60.BorderColor=Color.Silver;
            Appearance60.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucAddAlpha.DisplayLayout.Override.CellAppearance=Appearance60;
            ucAddAlpha.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucAddAlpha.DisplayLayout.Override.CellPadding=0;
            Appearance61.BackColor=SystemColors.Control;
            Appearance61.BackColor2=SystemColors.ControlDark;
            Appearance61.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance61.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance61.BorderColor=SystemColors.Window;
            ucAddAlpha.DisplayLayout.Override.GroupByRowAppearance=Appearance61;
            Appearance62.TextHAlignAsString="Left";
            ucAddAlpha.DisplayLayout.Override.HeaderAppearance=Appearance62;
            ucAddAlpha.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucAddAlpha.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance63.BackColor=SystemColors.Window;
            Appearance63.BorderColor=Color.Silver;
            ucAddAlpha.DisplayLayout.Override.RowAppearance=Appearance63;
            ucAddAlpha.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance64.BackColor=SystemColors.ControlLight;
            ucAddAlpha.DisplayLayout.Override.TemplateAddRowAppearance=Appearance64;
            ucAddAlpha.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucAddAlpha.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucAddAlpha.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucAddAlpha.DisplayMember="AlphaCodeDescription";
            ucAddAlpha.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucAddAlpha.DropDownWidth=0;
            ucAddAlpha.Location=new Point(258, 39);
            ucAddAlpha.Margin=new Padding(5, 7, 5, 7);
            ucAddAlpha.Name="ucAddAlpha";
            ucAddAlpha.Size=new Size(556, 42);
            ucAddAlpha.TabIndex=33;
            ucAddAlpha.ValueMember="alphaid";
            // 
            // uceSelectAllResources
            // 
            uceSelectAllResources.Location=new Point(258, 196);
            uceSelectAllResources.Margin=new Padding(8, 7, 8, 7);
            uceSelectAllResources.Name="uceSelectAllResources";
            uceSelectAllResources.Size=new Size(443, 48);
            uceSelectAllResources.TabIndex=26;
            uceSelectAllResources.Text="Select All Resources";
            // 
            // ubCancelUpdatedCosts
            // 
            ubCancelUpdatedCosts.Location=new Point(475, 560);
            ubCancelUpdatedCosts.Name="ubCancelUpdatedCosts";
            ubCancelUpdatedCosts.Size=new Size(134, 46);
            ubCancelUpdatedCosts.TabIndex=34;
            ubCancelUpdatedCosts.Text="Cancel";
            // 
            // ubSaveUpdatedCosts
            // 
            ubSaveUpdatedCosts.Location=new Point(308, 560);
            ubSaveUpdatedCosts.Name="ubSaveUpdatedCosts";
            ubSaveUpdatedCosts.Size=new Size(134, 46);
            ubSaveUpdatedCosts.TabIndex=33;
            ubSaveUpdatedCosts.Text="Save";
            // 
            // UltraLabel4
            // 
            Appearance65.TextHAlignAsString="Right";
            UltraLabel4.Appearance=Appearance65;
            UltraLabel4.Location=new Point(99, 474);
            UltraLabel4.Name="UltraLabel4";
            UltraLabel4.Size=new Size(229, 40);
            UltraLabel4.TabIndex=30;
            UltraLabel4.Text="To:";
            // 
            // UltraLabel3
            // 
            Appearance66.TextHAlignAsString="Right";
            UltraLabel3.Appearance=Appearance66;
            UltraLabel3.Location=new Point(99, 416);
            UltraLabel3.Name="UltraLabel3";
            UltraLabel3.Size=new Size(229, 40);
            UltraLabel3.TabIndex=29;
            UltraLabel3.Text="From:";
            // 
            // udtToAddAlpha
            // 
            udtToAddAlpha.FormatString="";
            udtToAddAlpha.Location=new Point(355, 473);
            udtToAddAlpha.Name="udtToAddAlpha";
            udtToAddAlpha.Size=new Size(416, 41);
            udtToAddAlpha.TabIndex=28;
            // 
            // udtFromAddAlpha
            // 
            udtFromAddAlpha.BorderStyle=Infragistics.Win.UIElementBorderStyle.None;
            udtFromAddAlpha.FormatString="";
            udtFromAddAlpha.Location=new Point(355, 416);
            udtFromAddAlpha.Name="udtFromAddAlpha";
            udtFromAddAlpha.Size=new Size(416, 37);
            udtFromAddAlpha.TabIndex=27;
            // 
            // ulUpdateCosts
            // 
            Appearance67.TextHAlignAsString="Center";
            ulUpdateCosts.Appearance=Appearance67;
            ulUpdateCosts.Location=new Point(0, 14);
            ulUpdateCosts.Name="ulUpdateCosts";
            ulUpdateCosts.Size=new Size(855, 40);
            ulUpdateCosts.TabIndex=0;
            ulUpdateCosts.Text="Updated Costs";
            // 
            // upCopyToAnotherCriteria
            // 
            // 
            // upCopyToAnotherCriteria.ClientArea
            // 
            upCopyToAnotherCriteria.ClientArea.Controls.Add(upDates);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ucDistrictToCopy);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ulCopyToAnotherCriteria);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ubCancelSaveAnotherCriteria);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ubSaveAnotherCriteria);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(uceCopyAllResourcesForCriteria);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ucProjectToCopy);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(urbGlobal);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(urbDistricts);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(urbProjects);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ulAlphaCodeSelected);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(UltraLabel14);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ulVendorSelected);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(UltraLabel12);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(ulCriteriaSelected);
            upCopyToAnotherCriteria.ClientArea.Controls.Add(UltraLabel10);
            upCopyToAnotherCriteria.Location=new Point(732, 1216);
            upCopyToAnotherCriteria.Name="upCopyToAnotherCriteria";
            upCopyToAnotherCriteria.Size=new Size(1078, 694);
            upCopyToAnotherCriteria.TabIndex=14;
            // 
            // upDates
            // 
            // 
            // upDates.ClientArea
            // 
            upDates.ClientArea.Controls.Add(UltraLabel7);
            upDates.ClientArea.Controls.Add(UltraLabel8);
            upDates.ClientArea.Controls.Add(udteToCriteria);
            upDates.ClientArea.Controls.Add(udteFromCriteriaToCopy);
            upDates.Location=new Point(293, 382);
            upDates.Name="upDates";
            upDates.Size=new Size(606, 127);
            upDates.TabIndex=51;
            // 
            // UltraLabel7
            // 
            Appearance68.TextHAlignAsString="Right";
            UltraLabel7.Appearance=Appearance68;
            UltraLabel7.Location=new Point(80, 72);
            UltraLabel7.Name="UltraLabel7";
            UltraLabel7.Size=new Size(103, 40);
            UltraLabel7.TabIndex=38;
            UltraLabel7.Text="To:";
            // 
            // UltraLabel8
            // 
            Appearance69.TextHAlignAsString="Right";
            UltraLabel8.Appearance=Appearance69;
            UltraLabel8.Location=new Point(45, 14);
            UltraLabel8.Name="UltraLabel8";
            UltraLabel8.Size=new Size(138, 40);
            UltraLabel8.TabIndex=37;
            UltraLabel8.Text="From:";
            // 
            // udteToCriteria
            // 
            udteToCriteria.FormatString="";
            udteToCriteria.Location=new Point(237, 71);
            udteToCriteria.Name="udteToCriteria";
            udteToCriteria.Size=new Size(416, 41);
            udteToCriteria.TabIndex=36;
            // 
            // udteFromCriteriaToCopy
            // 
            udteFromCriteriaToCopy.BorderStyle=Infragistics.Win.UIElementBorderStyle.None;
            udteFromCriteriaToCopy.FormatString="";
            udteFromCriteriaToCopy.Location=new Point(237, 14);
            udteFromCriteriaToCopy.Name="udteFromCriteriaToCopy";
            udteFromCriteriaToCopy.Size=new Size(416, 37);
            udteFromCriteriaToCopy.TabIndex=35;
            // 
            // ucDistrictToCopy
            // 
            ucDistrictToCopy.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucDistrictToCopy.DataSource=SpGetTaxDistrictListBindingSource;
            Appearance70.BackColor=SystemColors.Window;
            Appearance70.BorderColor=SystemColors.InactiveCaption;
            ucDistrictToCopy.DisplayLayout.Appearance=Appearance70;
            UltraGridColumn145.Header.VisiblePosition=0;
            UltraGridColumn146.Header.VisiblePosition=1;
            UltraGridBand6.Columns.AddRange(new object[] { UltraGridColumn145, UltraGridColumn146 });
            ucDistrictToCopy.DisplayLayout.BandsSerializer.Add(UltraGridBand6);
            ucDistrictToCopy.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucDistrictToCopy.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance71.BackColor=SystemColors.ActiveBorder;
            Appearance71.BackColor2=SystemColors.ControlDark;
            Appearance71.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance71.BorderColor=SystemColors.Window;
            ucDistrictToCopy.DisplayLayout.GroupByBox.Appearance=Appearance71;
            Appearance72.ForeColor=SystemColors.GrayText;
            ucDistrictToCopy.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance72;
            ucDistrictToCopy.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance73.BackColor=SystemColors.ControlLightLight;
            Appearance73.BackColor2=SystemColors.Control;
            Appearance73.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance73.ForeColor=SystemColors.GrayText;
            ucDistrictToCopy.DisplayLayout.GroupByBox.PromptAppearance=Appearance73;
            ucDistrictToCopy.DisplayLayout.MaxColScrollRegions=1;
            ucDistrictToCopy.DisplayLayout.MaxRowScrollRegions=1;
            Appearance74.BackColor=SystemColors.Window;
            Appearance74.ForeColor=SystemColors.ControlText;
            ucDistrictToCopy.DisplayLayout.Override.ActiveCellAppearance=Appearance74;
            Appearance75.BackColor=SystemColors.Highlight;
            Appearance75.ForeColor=SystemColors.HighlightText;
            ucDistrictToCopy.DisplayLayout.Override.ActiveRowAppearance=Appearance75;
            ucDistrictToCopy.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucDistrictToCopy.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance76.BackColor=SystemColors.Window;
            ucDistrictToCopy.DisplayLayout.Override.CardAreaAppearance=Appearance76;
            Appearance77.BorderColor=Color.Silver;
            Appearance77.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucDistrictToCopy.DisplayLayout.Override.CellAppearance=Appearance77;
            ucDistrictToCopy.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucDistrictToCopy.DisplayLayout.Override.CellPadding=0;
            Appearance78.BackColor=SystemColors.Control;
            Appearance78.BackColor2=SystemColors.ControlDark;
            Appearance78.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance78.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance78.BorderColor=SystemColors.Window;
            ucDistrictToCopy.DisplayLayout.Override.GroupByRowAppearance=Appearance78;
            Appearance79.TextHAlignAsString="Left";
            ucDistrictToCopy.DisplayLayout.Override.HeaderAppearance=Appearance79;
            ucDistrictToCopy.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucDistrictToCopy.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance80.BackColor=SystemColors.Window;
            Appearance80.BorderColor=Color.Silver;
            ucDistrictToCopy.DisplayLayout.Override.RowAppearance=Appearance80;
            ucDistrictToCopy.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance81.BackColor=SystemColors.ControlLight;
            ucDistrictToCopy.DisplayLayout.Override.TemplateAddRowAppearance=Appearance81;
            ucDistrictToCopy.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucDistrictToCopy.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucDistrictToCopy.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucDistrictToCopy.DisplayMember="TaxPermitDistrict";
            ucDistrictToCopy.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucDistrictToCopy.Location=new Point(396, 300);
            ucDistrictToCopy.Margin=new Padding(5, 7, 5, 7);
            ucDistrictToCopy.Name="ucDistrictToCopy";
            ucDistrictToCopy.Size=new Size(503, 42);
            ucDistrictToCopy.TabIndex=50;
            ucDistrictToCopy.ValueMember="TaxPermitID";
            // 
            // ulCopyToAnotherCriteria
            // 
            Appearance82.TextHAlignAsString="Center";
            ulCopyToAnotherCriteria.Appearance=Appearance82;
            ulCopyToAnotherCriteria.Location=new Point(18, 3);
            ulCopyToAnotherCriteria.Name="ulCopyToAnotherCriteria";
            ulCopyToAnotherCriteria.Size=new Size(989, 40);
            ulCopyToAnotherCriteria.TabIndex=49;
            ulCopyToAnotherCriteria.Text="Copy To Another Criteria";
            // 
            // ubCancelSaveAnotherCriteria
            // 
            ubCancelSaveAnotherCriteria.Location=new Point(549, 628);
            ubCancelSaveAnotherCriteria.Name="ubCancelSaveAnotherCriteria";
            ubCancelSaveAnotherCriteria.Size=new Size(149, 46);
            ubCancelSaveAnotherCriteria.TabIndex=48;
            ubCancelSaveAnotherCriteria.Text="Cancel";
            // 
            // ubSaveAnotherCriteria
            // 
            ubSaveAnotherCriteria.Location=new Point(390, 628);
            ubSaveAnotherCriteria.Name="ubSaveAnotherCriteria";
            ubSaveAnotherCriteria.Size=new Size(149, 46);
            ubSaveAnotherCriteria.TabIndex=47;
            ubSaveAnotherCriteria.Text="Save";
            // 
            // uceCopyAllResourcesForCriteria
            // 
            uceCopyAllResourcesForCriteria.Location=new Point(72, 523);
            uceCopyAllResourcesForCriteria.Margin=new Padding(8, 7, 8, 7);
            uceCopyAllResourcesForCriteria.Name="uceCopyAllResourcesForCriteria";
            uceCopyAllResourcesForCriteria.Size=new Size(331, 48);
            uceCopyAllResourcesForCriteria.TabIndex=46;
            uceCopyAllResourcesForCriteria.Text="Copy All Resources";
            // 
            // ucProjectToCopy
            // 
            ucProjectToCopy.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucProjectToCopy.DataSource=SpGetOpenProjectsBindingSource;
            Appearance83.BackColor=SystemColors.Window;
            Appearance83.BorderColor=SystemColors.InactiveCaption;
            ucProjectToCopy.DisplayLayout.Appearance=Appearance83;
            UltraGridColumn147.Header.VisiblePosition=0;
            UltraGridColumn148.Header.VisiblePosition=1;
            UltraGridColumn149.Header.VisiblePosition=2;
            UltraGridColumn150.Header.VisiblePosition=3;
            UltraGridColumn151.Header.VisiblePosition=4;
            UltraGridColumn152.Header.VisiblePosition=5;
            UltraGridBand7.Columns.AddRange(new object[] { UltraGridColumn147, UltraGridColumn148, UltraGridColumn149, UltraGridColumn150, UltraGridColumn151, UltraGridColumn152 });
            ucProjectToCopy.DisplayLayout.BandsSerializer.Add(UltraGridBand7);
            ucProjectToCopy.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucProjectToCopy.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance84.BackColor=SystemColors.ActiveBorder;
            Appearance84.BackColor2=SystemColors.ControlDark;
            Appearance84.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance84.BorderColor=SystemColors.Window;
            ucProjectToCopy.DisplayLayout.GroupByBox.Appearance=Appearance84;
            Appearance85.ForeColor=SystemColors.GrayText;
            ucProjectToCopy.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance85;
            ucProjectToCopy.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance86.BackColor=SystemColors.ControlLightLight;
            Appearance86.BackColor2=SystemColors.Control;
            Appearance86.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance86.ForeColor=SystemColors.GrayText;
            ucProjectToCopy.DisplayLayout.GroupByBox.PromptAppearance=Appearance86;
            ucProjectToCopy.DisplayLayout.MaxColScrollRegions=1;
            ucProjectToCopy.DisplayLayout.MaxRowScrollRegions=1;
            Appearance87.BackColor=SystemColors.Window;
            Appearance87.ForeColor=SystemColors.ControlText;
            ucProjectToCopy.DisplayLayout.Override.ActiveCellAppearance=Appearance87;
            Appearance88.BackColor=SystemColors.Highlight;
            Appearance88.ForeColor=SystemColors.HighlightText;
            ucProjectToCopy.DisplayLayout.Override.ActiveRowAppearance=Appearance88;
            ucProjectToCopy.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucProjectToCopy.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance89.BackColor=SystemColors.Window;
            ucProjectToCopy.DisplayLayout.Override.CardAreaAppearance=Appearance89;
            Appearance90.BorderColor=Color.Silver;
            Appearance90.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucProjectToCopy.DisplayLayout.Override.CellAppearance=Appearance90;
            ucProjectToCopy.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucProjectToCopy.DisplayLayout.Override.CellPadding=0;
            Appearance91.BackColor=SystemColors.Control;
            Appearance91.BackColor2=SystemColors.ControlDark;
            Appearance91.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance91.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance91.BorderColor=SystemColors.Window;
            ucProjectToCopy.DisplayLayout.Override.GroupByRowAppearance=Appearance91;
            Appearance92.TextHAlignAsString="Left";
            ucProjectToCopy.DisplayLayout.Override.HeaderAppearance=Appearance92;
            ucProjectToCopy.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucProjectToCopy.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance93.BackColor=SystemColors.Window;
            Appearance93.BorderColor=Color.Silver;
            ucProjectToCopy.DisplayLayout.Override.RowAppearance=Appearance93;
            ucProjectToCopy.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance94.BackColor=SystemColors.ControlLight;
            ucProjectToCopy.DisplayLayout.Override.TemplateAddRowAppearance=Appearance94;
            ucProjectToCopy.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucProjectToCopy.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucProjectToCopy.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucProjectToCopy.DisplayMember="ProjectID";
            ucProjectToCopy.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucProjectToCopy.Location=new Point(396, 242);
            ucProjectToCopy.Margin=new Padding(5, 7, 5, 7);
            ucProjectToCopy.Name="ucProjectToCopy";
            ucProjectToCopy.Size=new Size(503, 42);
            ucProjectToCopy.TabIndex=44;
            ucProjectToCopy.ValueMember="ID";
            // 
            // urbGlobal
            // 
            urbGlobal.GroupManager=UltraRadioButtonGroupManager1;
            urbGlobal.Location=new Point(52, 350);
            urbGlobal.Margin=new Padding(8, 7, 8, 7);
            urbGlobal.Name="urbGlobal";
            urbGlobal.Size=new Size(320, 48);
            urbGlobal.TabIndex=43;
            urbGlobal.Text="Filter by Global";
            // 
            // UltraRadioButtonGroupManager1
            // 
            // 
            // urbDistricts
            // 
            urbDistricts.GroupManager=UltraRadioButtonGroupManager1;
            urbDistricts.Location=new Point(52, 293);
            urbDistricts.Margin=new Padding(8, 7, 8, 7);
            urbDistricts.Name="urbDistricts";
            urbDistricts.Size=new Size(320, 48);
            urbDistricts.TabIndex=42;
            urbDistricts.Text="Filter by District";
            // 
            // urbProjects
            // 
            urbProjects.GroupManager=UltraRadioButtonGroupManager1;
            urbProjects.Location=new Point(52, 236);
            urbProjects.Margin=new Padding(8, 7, 8, 7);
            urbProjects.Name="urbProjects";
            urbProjects.Size=new Size(320, 48);
            urbProjects.TabIndex=41;
            urbProjects.Text="Filter by Project";
            // 
            // ulAlphaCodeSelected
            // 
            Appearance95.TextHAlignAsString="Left";
            ulAlphaCodeSelected.Appearance=Appearance95;
            ulAlphaCodeSelected.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            ulAlphaCodeSelected.Location=new Point(396, 67);
            ulAlphaCodeSelected.Name="ulAlphaCodeSelected";
            ulAlphaCodeSelected.Size=new Size(556, 40);
            ulAlphaCodeSelected.TabIndex=40;
            // 
            // UltraLabel14
            // 
            Appearance96.TextHAlignAsString="Right";
            UltraLabel14.Appearance=Appearance96;
            UltraLabel14.Location=new Point(46, 67);
            UltraLabel14.Name="UltraLabel14";
            UltraLabel14.Size=new Size(300, 40);
            UltraLabel14.TabIndex=39;
            UltraLabel14.Text="Alpha Code Selected:";
            // 
            // ulVendorSelected
            // 
            Appearance97.TextHAlignAsString="Left";
            ulVendorSelected.Appearance=Appearance97;
            ulVendorSelected.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            ulVendorSelected.Location=new Point(396, 118);
            ulVendorSelected.Name="ulVendorSelected";
            ulVendorSelected.Size=new Size(556, 40);
            ulVendorSelected.TabIndex=38;
            // 
            // UltraLabel12
            // 
            Appearance98.TextHAlignAsString="Right";
            UltraLabel12.Appearance=Appearance98;
            UltraLabel12.Location=new Point(46, 118);
            UltraLabel12.Name="UltraLabel12";
            UltraLabel12.Size=new Size(300, 40);
            UltraLabel12.TabIndex=37;
            UltraLabel12.Text="Vendor Selected:";
            // 
            // ulCriteriaSelected
            // 
            Appearance99.TextHAlignAsString="Left";
            ulCriteriaSelected.Appearance=Appearance99;
            ulCriteriaSelected.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            ulCriteriaSelected.Location=new Point(396, 175);
            ulCriteriaSelected.Name="ulCriteriaSelected";
            ulCriteriaSelected.Size=new Size(556, 40);
            ulCriteriaSelected.TabIndex=36;
            // 
            // UltraLabel10
            // 
            Appearance100.TextHAlignAsString="Right";
            UltraLabel10.Appearance=Appearance100;
            UltraLabel10.Location=new Point(46, 175);
            UltraLabel10.Name="UltraLabel10";
            UltraLabel10.Size=new Size(300, 40);
            UltraLabel10.TabIndex=35;
            UltraLabel10.Text="Criteria Selected:";
            // 
            // upAddResources
            // 
            // 
            // upAddResources.ClientArea
            // 
            upAddResources.ClientArea.Controls.Add(UltraLabel20);
            upAddResources.ClientArea.Controls.Add(ugResources);
            upAddResources.ClientArea.Controls.Add(UltraLabel11);
            upAddResources.ClientArea.Controls.Add(ubCancelNewResources);
            upAddResources.ClientArea.Controls.Add(ubSaveNewResources);
            upAddResources.ClientArea.Controls.Add(ucResources);
            upAddResources.ClientArea.Controls.Add(UltraLabel13);
            upAddResources.ClientArea.Controls.Add(UltraLabel15);
            upAddResources.ClientArea.Controls.Add(UltraLabel16);
            upAddResources.ClientArea.Controls.Add(UltraLabel17);
            upAddResources.ClientArea.Controls.Add(UltraLabel18);
            upAddResources.ClientArea.Controls.Add(UltraLabel19);
            upAddResources.Location=new Point(1917, 1031);
            upAddResources.Name="upAddResources";
            upAddResources.Size=new Size(1010, 694);
            upAddResources.TabIndex=15;
            upAddResources.Visible=false;
            // 
            // UltraLabel20
            // 
            Appearance101.TextHAlignAsString="Right";
            UltraLabel20.Appearance=Appearance101;
            UltraLabel20.Location=new Point(46, 244);
            UltraLabel20.Name="UltraLabel20";
            UltraLabel20.Size=new Size(300, 40);
            UltraLabel20.TabIndex=51;
            UltraLabel20.Text="Resources:";
            // 
            // ugResources
            // 
            ugResources.DisplayLayout.AddNewBox.Hidden=false;
            Appearance102.BackColor=SystemColors.Window;
            Appearance102.BorderColor=SystemColors.InactiveCaption;
            ugResources.DisplayLayout.Appearance=Appearance102;
            UltraGridColumn153.DataType=typeof(bool);
            UltraGridColumn153.DefaultCellValue=resources.GetObject("UltraGridColumn153.DefaultCellValue");
            UltraGridColumn153.Header.VisiblePosition=0;
            UltraGridColumn154.Header.VisiblePosition=1;
            UltraGridColumn155.DataType=typeof(decimal);
            UltraGridColumn155.Header.VisiblePosition=2;
            UltraGridColumn156.DataType=typeof(bool);
            UltraGridColumn156.Header.VisiblePosition=3;
            UltraGridColumn157.DataType=typeof(bool);
            UltraGridColumn157.Header.VisiblePosition=4;
            UltraGridColumn158.DataType=typeof(bool);
            UltraGridColumn158.Header.VisiblePosition=5;
            UltraGridColumn159.DataType=typeof(long);
            UltraGridColumn159.Header.VisiblePosition=6;
            UltraGridBand8.Columns.AddRange(new object[] { UltraGridColumn153, UltraGridColumn154, UltraGridColumn155, UltraGridColumn156, UltraGridColumn157, UltraGridColumn158, UltraGridColumn159 });
            ugResources.DisplayLayout.BandsSerializer.Add(UltraGridBand8);
            ugResources.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ugResources.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            ugResources.DisplayLayout.EmptyRowSettings.ShowEmptyRows=true;
            Appearance103.BackColor=SystemColors.ActiveBorder;
            Appearance103.BackColor2=SystemColors.ControlDark;
            Appearance103.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance103.BorderColor=SystemColors.Window;
            ugResources.DisplayLayout.GroupByBox.Appearance=Appearance103;
            Appearance104.ForeColor=SystemColors.GrayText;
            ugResources.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance104;
            ugResources.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance105.BackColor=SystemColors.ControlLightLight;
            Appearance105.BackColor2=SystemColors.Control;
            Appearance105.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance105.ForeColor=SystemColors.GrayText;
            ugResources.DisplayLayout.GroupByBox.PromptAppearance=Appearance105;
            ugResources.DisplayLayout.MaxColScrollRegions=1;
            ugResources.DisplayLayout.MaxRowScrollRegions=1;
            Appearance106.BackColor=SystemColors.Window;
            Appearance106.ForeColor=SystemColors.ControlText;
            ugResources.DisplayLayout.Override.ActiveCellAppearance=Appearance106;
            Appearance107.BackColor=SystemColors.Highlight;
            Appearance107.ForeColor=SystemColors.HighlightText;
            ugResources.DisplayLayout.Override.ActiveRowAppearance=Appearance107;
            ugResources.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ugResources.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance108.BackColor=SystemColors.Window;
            ugResources.DisplayLayout.Override.CardAreaAppearance=Appearance108;
            Appearance109.BorderColor=Color.Silver;
            Appearance109.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ugResources.DisplayLayout.Override.CellAppearance=Appearance109;
            ugResources.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ugResources.DisplayLayout.Override.CellPadding=0;
            Appearance110.BackColor=SystemColors.Control;
            Appearance110.BackColor2=SystemColors.ControlDark;
            Appearance110.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance110.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance110.BorderColor=SystemColors.Window;
            ugResources.DisplayLayout.Override.GroupByRowAppearance=Appearance110;
            Appearance111.TextHAlignAsString="Left";
            ugResources.DisplayLayout.Override.HeaderAppearance=Appearance111;
            ugResources.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ugResources.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance112.BackColor=SystemColors.Window;
            Appearance112.BorderColor=Color.Silver;
            ugResources.DisplayLayout.Override.RowAppearance=Appearance112;
            ugResources.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance113.BackColor=SystemColors.ControlLight;
            ugResources.DisplayLayout.Override.TemplateAddRowAppearance=Appearance113;
            ugResources.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ugResources.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ugResources.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ugResources.Location=new Point(46, 337);
            ugResources.Name="ugResources";
            ugResources.Size=new Size(926, 262);
            ugResources.TabIndex=50;
            ugResources.Text="Add Resources";
            // 
            // UltraLabel11
            // 
            Appearance114.TextHAlignAsString="Center";
            UltraLabel11.Appearance=Appearance114;
            UltraLabel11.Location=new Point(3, 7);
            UltraLabel11.Name="UltraLabel11";
            UltraLabel11.Size=new Size(989, 40);
            UltraLabel11.TabIndex=49;
            UltraLabel11.Text="Add Resources";
            // 
            // ubCancelNewResources
            // 
            ubCancelNewResources.Location=new Point(549, 628);
            ubCancelNewResources.Name="ubCancelNewResources";
            ubCancelNewResources.Size=new Size(149, 46);
            ubCancelNewResources.TabIndex=48;
            ubCancelNewResources.Text="Cancel";
            // 
            // ubSaveNewResources
            // 
            ubSaveNewResources.Location=new Point(390, 628);
            ubSaveNewResources.Name="ubSaveNewResources";
            ubSaveNewResources.Size=new Size(149, 46);
            ubSaveNewResources.TabIndex=47;
            ubSaveNewResources.Text="Save";
            // 
            // ucResources
            // 
            ucResources.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucResources.DataSource=SpGetResourcesByAlphaBindingSource;
            Appearance115.BackColor=SystemColors.Window;
            Appearance115.BorderColor=SystemColors.InactiveCaption;
            ucResources.DisplayLayout.Appearance=Appearance115;
            UltraGridColumn160.Header.VisiblePosition=0;
            UltraGridColumn161.Header.VisiblePosition=1;
            UltraGridColumn162.Header.VisiblePosition=2;
            UltraGridColumn163.Header.VisiblePosition=3;
            UltraGridColumn164.Header.VisiblePosition=4;
            UltraGridBand9.Columns.AddRange(new object[] { UltraGridColumn160, UltraGridColumn161, UltraGridColumn162, UltraGridColumn163, UltraGridColumn164 });
            ucResources.DisplayLayout.BandsSerializer.Add(UltraGridBand9);
            ucResources.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucResources.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance116.BackColor=SystemColors.ActiveBorder;
            Appearance116.BackColor2=SystemColors.ControlDark;
            Appearance116.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance116.BorderColor=SystemColors.Window;
            ucResources.DisplayLayout.GroupByBox.Appearance=Appearance116;
            Appearance117.ForeColor=SystemColors.GrayText;
            ucResources.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance117;
            ucResources.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance118.BackColor=SystemColors.ControlLightLight;
            Appearance118.BackColor2=SystemColors.Control;
            Appearance118.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance118.ForeColor=SystemColors.GrayText;
            ucResources.DisplayLayout.GroupByBox.PromptAppearance=Appearance118;
            ucResources.DisplayLayout.MaxColScrollRegions=1;
            ucResources.DisplayLayout.MaxRowScrollRegions=1;
            Appearance119.BackColor=SystemColors.Window;
            Appearance119.ForeColor=SystemColors.ControlText;
            ucResources.DisplayLayout.Override.ActiveCellAppearance=Appearance119;
            Appearance120.BackColor=SystemColors.Highlight;
            Appearance120.ForeColor=SystemColors.HighlightText;
            ucResources.DisplayLayout.Override.ActiveRowAppearance=Appearance120;
            ucResources.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucResources.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance121.BackColor=SystemColors.Window;
            ucResources.DisplayLayout.Override.CardAreaAppearance=Appearance121;
            Appearance122.BorderColor=Color.Silver;
            Appearance122.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucResources.DisplayLayout.Override.CellAppearance=Appearance122;
            ucResources.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucResources.DisplayLayout.Override.CellPadding=0;
            Appearance123.BackColor=SystemColors.Control;
            Appearance123.BackColor2=SystemColors.ControlDark;
            Appearance123.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance123.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance123.BorderColor=SystemColors.Window;
            ucResources.DisplayLayout.Override.GroupByRowAppearance=Appearance123;
            Appearance124.TextHAlignAsString="Left";
            ucResources.DisplayLayout.Override.HeaderAppearance=Appearance124;
            ucResources.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucResources.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance125.BackColor=SystemColors.Window;
            Appearance125.BorderColor=Color.Silver;
            ucResources.DisplayLayout.Override.RowAppearance=Appearance125;
            ucResources.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance126.BackColor=SystemColors.ControlLight;
            ucResources.DisplayLayout.Override.TemplateAddRowAppearance=Appearance126;
            ucResources.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucResources.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucResources.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucResources.DisplayMember="ResourceName";
            ucResources.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucResources.Location=new Point(396, 242);
            ucResources.Margin=new Padding(5, 7, 5, 7);
            ucResources.Name="ucResources";
            ucResources.Size=new Size(503, 42);
            ucResources.TabIndex=44;
            ucResources.ValueMember="ID";
            // 
            // SpGetResourcesByAlphaBindingSource
            // 
            SpGetResourcesByAlphaBindingSource.DataMember="spGetResourcesByAlpha";
            SpGetResourcesByAlphaBindingSource.DataSource=HCHDataDSVendorCost;
            // 
            // UltraLabel13
            // 
            Appearance127.TextHAlignAsString="Left";
            UltraLabel13.Appearance=Appearance127;
            UltraLabel13.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            UltraLabel13.Location=new Point(396, 67);
            UltraLabel13.Name="UltraLabel13";
            UltraLabel13.Size=new Size(556, 40);
            UltraLabel13.TabIndex=40;
            // 
            // UltraLabel15
            // 
            Appearance128.TextHAlignAsString="Right";
            UltraLabel15.Appearance=Appearance128;
            UltraLabel15.Location=new Point(46, 67);
            UltraLabel15.Name="UltraLabel15";
            UltraLabel15.Size=new Size(300, 40);
            UltraLabel15.TabIndex=39;
            UltraLabel15.Text="Alpha Code Selected:";
            // 
            // UltraLabel16
            // 
            Appearance129.TextHAlignAsString="Left";
            UltraLabel16.Appearance=Appearance129;
            UltraLabel16.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            UltraLabel16.Location=new Point(396, 118);
            UltraLabel16.Name="UltraLabel16";
            UltraLabel16.Size=new Size(556, 40);
            UltraLabel16.TabIndex=38;
            // 
            // UltraLabel17
            // 
            Appearance130.TextHAlignAsString="Right";
            UltraLabel17.Appearance=Appearance130;
            UltraLabel17.Location=new Point(46, 118);
            UltraLabel17.Name="UltraLabel17";
            UltraLabel17.Size=new Size(300, 40);
            UltraLabel17.TabIndex=37;
            UltraLabel17.Text="Vendor Selected:";
            // 
            // UltraLabel18
            // 
            Appearance131.TextHAlignAsString="Left";
            UltraLabel18.Appearance=Appearance131;
            UltraLabel18.BorderStyleInner=Infragistics.Win.UIElementBorderStyle.Inset;
            UltraLabel18.Location=new Point(396, 175);
            UltraLabel18.Name="UltraLabel18";
            UltraLabel18.Size=new Size(556, 40);
            UltraLabel18.TabIndex=36;
            // 
            // UltraLabel19
            // 
            Appearance132.TextHAlignAsString="Right";
            UltraLabel19.Appearance=Appearance132;
            UltraLabel19.Location=new Point(46, 175);
            UltraLabel19.Name="UltraLabel19";
            UltraLabel19.Size=new Size(300, 40);
            UltraLabel19.TabIndex=35;
            UltraLabel19.Text="Criteria Selected:";
            // 
            // upCopyToAnotherVendor
            // 
            // 
            // upCopyToAnotherVendor.ClientArea
            // 
            upCopyToAnotherVendor.ClientArea.Controls.Add(UltraLabel26);
            upCopyToAnotherVendor.ClientArea.Controls.Add(UltraLabel25);
            upCopyToAnotherVendor.ClientArea.Controls.Add(urbHistoryNewVendor);
            upCopyToAnotherVendor.ClientArea.Controls.Add(ubCancelNewVendor);
            upCopyToAnotherVendor.ClientArea.Controls.Add(upAddAlpha);
            upCopyToAnotherVendor.ClientArea.Controls.Add(ubSaveNewVendor);
            upCopyToAnotherVendor.ClientArea.Controls.Add(UltraLabel23);
            upCopyToAnotherVendor.ClientArea.Controls.Add(UltraLabel24);
            upCopyToAnotherVendor.ClientArea.Controls.Add(udteToNewVendor);
            upCopyToAnotherVendor.ClientArea.Controls.Add(udteFromNewVendor);
            upCopyToAnotherVendor.ClientArea.Controls.Add(ucNewVendor);
            upCopyToAnotherVendor.ClientArea.Controls.Add(urbPendingNewVendor);
            upCopyToAnotherVendor.Location=new Point(1551, 1052);
            upCopyToAnotherVendor.Name="upCopyToAnotherVendor";
            upCopyToAnotherVendor.Size=new Size(862, 639);
            upCopyToAnotherVendor.TabIndex=16;
            upCopyToAnotherVendor.Visible=false;
            // 
            // UltraLabel26
            // 
            Appearance133.TextHAlignAsString="Center";
            UltraLabel26.Appearance=Appearance133;
            UltraLabel26.Location=new Point(7, 3);
            UltraLabel26.Name="UltraLabel26";
            UltraLabel26.Size=new Size(855, 40);
            UltraLabel26.TabIndex=39;
            UltraLabel26.Text="Vendor Assigned";
            // 
            // UltraLabel25
            // 
            Appearance134.TextHAlignAsString="Right";
            UltraLabel25.Appearance=Appearance134;
            UltraLabel25.Location=new Point(30, 86);
            UltraLabel25.Name="UltraLabel25";
            UltraLabel25.Size=new Size(229, 42);
            UltraLabel25.TabIndex=38;
            UltraLabel25.Text="New Vendor:";
            // 
            // urbHistoryNewVendor
            // 
            urbHistoryNewVendor.GroupManager=UltraRadioButtonGroupManager2;
            urbHistoryNewVendor.Location=new Point(598, 395);
            urbHistoryNewVendor.Name="urbHistoryNewVendor";
            urbHistoryNewVendor.Size=new Size(120, 32);
            urbHistoryNewVendor.TabIndex=36;
            urbHistoryNewVendor.Text="History";
            // 
            // ubCancelNewVendor
            // 
            ubCancelNewVendor.Location=new Point(475, 560);
            ubCancelNewVendor.Name="ubCancelNewVendor";
            ubCancelNewVendor.Size=new Size(134, 46);
            ubCancelNewVendor.TabIndex=34;
            ubCancelNewVendor.Text="Cancel";
            // 
            // ubSaveNewVendor
            // 
            ubSaveNewVendor.Location=new Point(308, 560);
            ubSaveNewVendor.Name="ubSaveNewVendor";
            ubSaveNewVendor.Size=new Size(134, 46);
            ubSaveNewVendor.TabIndex=33;
            ubSaveNewVendor.Text="Save";
            // 
            // UltraLabel23
            // 
            Appearance135.TextHAlignAsString="Right";
            UltraLabel23.Appearance=Appearance135;
            UltraLabel23.Location=new Point(30, 255);
            UltraLabel23.Name="UltraLabel23";
            UltraLabel23.Size=new Size(229, 40);
            UltraLabel23.TabIndex=30;
            UltraLabel23.Text="To:";
            // 
            // UltraLabel24
            // 
            Appearance136.TextHAlignAsString="Right";
            UltraLabel24.Appearance=Appearance136;
            UltraLabel24.Location=new Point(30, 197);
            UltraLabel24.Name="UltraLabel24";
            UltraLabel24.Size=new Size(229, 40);
            UltraLabel24.TabIndex=29;
            UltraLabel24.Text="From:";
            // 
            // udteToNewVendor
            // 
            udteToNewVendor.FormatString="";
            udteToNewVendor.Location=new Point(286, 254);
            udteToNewVendor.Name="udteToNewVendor";
            udteToNewVendor.Size=new Size(416, 41);
            udteToNewVendor.TabIndex=28;
            // 
            // udteFromNewVendor
            // 
            udteFromNewVendor.BorderStyle=Infragistics.Win.UIElementBorderStyle.None;
            udteFromNewVendor.FormatString="";
            udteFromNewVendor.Location=new Point(286, 197);
            udteFromNewVendor.Name="udteFromNewVendor";
            udteFromNewVendor.Size=new Size(416, 37);
            udteFromNewVendor.TabIndex=27;
            // 
            // ucNewVendor
            // 
            ucNewVendor.AllowNull=Infragistics.Win.DefaultableBoolean.True;
            ucNewVendor.DataSource=SpGetVendorsInUseBindingSource;
            Appearance137.BackColor=SystemColors.Window;
            Appearance137.BorderColor=SystemColors.InactiveCaption;
            ucNewVendor.DisplayLayout.Appearance=Appearance137;
            UltraGridColumn165.Header.VisiblePosition=0;
            UltraGridColumn166.Header.VisiblePosition=1;
            UltraGridColumn167.Header.VisiblePosition=2;
            UltraGridColumn168.Header.VisiblePosition=3;
            UltraGridBand10.Columns.AddRange(new object[] { UltraGridColumn165, UltraGridColumn166, UltraGridColumn167, UltraGridColumn168 });
            ucNewVendor.DisplayLayout.BandsSerializer.Add(UltraGridBand10);
            ucNewVendor.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ucNewVendor.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.False;
            Appearance138.BackColor=SystemColors.ActiveBorder;
            Appearance138.BackColor2=SystemColors.ControlDark;
            Appearance138.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance138.BorderColor=SystemColors.Window;
            ucNewVendor.DisplayLayout.GroupByBox.Appearance=Appearance138;
            Appearance139.ForeColor=SystemColors.GrayText;
            ucNewVendor.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance139;
            ucNewVendor.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance140.BackColor=SystemColors.ControlLightLight;
            Appearance140.BackColor2=SystemColors.Control;
            Appearance140.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance140.ForeColor=SystemColors.GrayText;
            ucNewVendor.DisplayLayout.GroupByBox.PromptAppearance=Appearance140;
            ucNewVendor.DisplayLayout.MaxColScrollRegions=1;
            ucNewVendor.DisplayLayout.MaxRowScrollRegions=1;
            Appearance141.BackColor=SystemColors.Window;
            Appearance141.ForeColor=SystemColors.ControlText;
            ucNewVendor.DisplayLayout.Override.ActiveCellAppearance=Appearance141;
            Appearance142.BackColor=SystemColors.Highlight;
            Appearance142.ForeColor=SystemColors.HighlightText;
            ucNewVendor.DisplayLayout.Override.ActiveRowAppearance=Appearance142;
            ucNewVendor.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ucNewVendor.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance143.BackColor=SystemColors.Window;
            ucNewVendor.DisplayLayout.Override.CardAreaAppearance=Appearance143;
            Appearance144.BorderColor=Color.Silver;
            Appearance144.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ucNewVendor.DisplayLayout.Override.CellAppearance=Appearance144;
            ucNewVendor.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ucNewVendor.DisplayLayout.Override.CellPadding=0;
            Appearance145.BackColor=SystemColors.Control;
            Appearance145.BackColor2=SystemColors.ControlDark;
            Appearance145.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance145.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance145.BorderColor=SystemColors.Window;
            ucNewVendor.DisplayLayout.Override.GroupByRowAppearance=Appearance145;
            Appearance146.TextHAlignAsString="Left";
            ucNewVendor.DisplayLayout.Override.HeaderAppearance=Appearance146;
            ucNewVendor.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ucNewVendor.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance147.BackColor=SystemColors.Window;
            Appearance147.BorderColor=Color.Silver;
            ucNewVendor.DisplayLayout.Override.RowAppearance=Appearance147;
            ucNewVendor.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance148.BackColor=SystemColors.ControlLight;
            ucNewVendor.DisplayLayout.Override.TemplateAddRowAppearance=Appearance148;
            ucNewVendor.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ucNewVendor.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ucNewVendor.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ucNewVendor.DisplayMember="vdrName";
            ucNewVendor.DropDownStyle=Infragistics.Win.UltraWinGrid.UltraComboStyle.DropDownList;
            ucNewVendor.DropDownWidth=0;
            ucNewVendor.Location=new Point(284, 86);
            ucNewVendor.Margin=new Padding(5, 7, 5, 7);
            ucNewVendor.Name="ucNewVendor";
            ucNewVendor.Size=new Size(556, 42);
            ucNewVendor.TabIndex=17;
            ucNewVendor.ValueMember="vendorid";
            // 
            // urbPendingNewVendor
            // 
            urbPendingNewVendor.GroupManager=UltraRadioButtonGroupManager2;
            urbPendingNewVendor.Location=new Point(283, 387);
            urbPendingNewVendor.Name="urbPendingNewVendor";
            urbPendingNewVendor.Size=new Size(309, 40);
            urbPendingNewVendor.TabIndex=35;
            urbPendingNewVendor.Text="Pending - Keep Dates";
            // 
            // ugAssignedVendors
            // 
            utmAssignedVendors.SetContextMenuUltra(ugAssignedVendors, "PopupAssoignedVendors");
            Appearance161.BackColor=SystemColors.Window;
            Appearance161.BorderColor=SystemColors.InactiveCaption;
            ugAssignedVendors.DisplayLayout.Appearance=Appearance161;
            ugAssignedVendors.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ugAssignedVendors.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance162.BackColor=SystemColors.ActiveBorder;
            Appearance162.BackColor2=SystemColors.ControlDark;
            Appearance162.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance162.BorderColor=SystemColors.Window;
            ugAssignedVendors.DisplayLayout.GroupByBox.Appearance=Appearance162;
            Appearance163.ForeColor=SystemColors.GrayText;
            ugAssignedVendors.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance163;
            ugAssignedVendors.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance164.BackColor=SystemColors.ControlLightLight;
            Appearance164.BackColor2=SystemColors.Control;
            Appearance164.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance164.ForeColor=SystemColors.GrayText;
            ugAssignedVendors.DisplayLayout.GroupByBox.PromptAppearance=Appearance164;
            ugAssignedVendors.DisplayLayout.MaxColScrollRegions=1;
            ugAssignedVendors.DisplayLayout.MaxRowScrollRegions=1;
            Appearance165.BackColor=SystemColors.Window;
            Appearance165.ForeColor=SystemColors.ControlText;
            ugAssignedVendors.DisplayLayout.Override.ActiveCellAppearance=Appearance165;
            Appearance166.BackColor=SystemColors.Highlight;
            Appearance166.ForeColor=SystemColors.HighlightText;
            ugAssignedVendors.DisplayLayout.Override.ActiveRowAppearance=Appearance166;
            ugAssignedVendors.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ugAssignedVendors.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance167.BackColor=SystemColors.Window;
            ugAssignedVendors.DisplayLayout.Override.CardAreaAppearance=Appearance167;
            Appearance168.BorderColor=Color.Silver;
            Appearance168.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ugAssignedVendors.DisplayLayout.Override.CellAppearance=Appearance168;
            ugAssignedVendors.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ugAssignedVendors.DisplayLayout.Override.CellPadding=0;
            Appearance169.BackColor=SystemColors.Control;
            Appearance169.BackColor2=SystemColors.ControlDark;
            Appearance169.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance169.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance169.BorderColor=SystemColors.Window;
            ugAssignedVendors.DisplayLayout.Override.GroupByRowAppearance=Appearance169;
            Appearance170.TextHAlignAsString="Left";
            ugAssignedVendors.DisplayLayout.Override.HeaderAppearance=Appearance170;
            ugAssignedVendors.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ugAssignedVendors.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance171.BackColor=SystemColors.Window;
            Appearance171.BorderColor=Color.Silver;
            ugAssignedVendors.DisplayLayout.Override.RowAppearance=Appearance171;
            ugAssignedVendors.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance172.BackColor=SystemColors.ControlLight;
            ugAssignedVendors.DisplayLayout.Override.TemplateAddRowAppearance=Appearance172;
            ugAssignedVendors.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ugAssignedVendors.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ugAssignedVendors.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ugAssignedVendors.Location=new Point(30, 497);
            ugAssignedVendors.Name="ugAssignedVendors";
            ugAssignedVendors.Size=new Size(2885, 414);
            ugAssignedVendors.TabIndex=17;
            ugAssignedVendors.Text="Assigned Vendors";
            // 
            // ugCosts
            // 
            Appearance149.BackColor=SystemColors.Window;
            Appearance149.BorderColor=SystemColors.InactiveCaption;
            ugCosts.DisplayLayout.Appearance=Appearance149;
            ugCosts.DisplayLayout.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            ugCosts.DisplayLayout.CaptionVisible=Infragistics.Win.DefaultableBoolean.True;
            Appearance150.BackColor=SystemColors.ActiveBorder;
            Appearance150.BackColor2=SystemColors.ControlDark;
            Appearance150.BackGradientStyle=Infragistics.Win.GradientStyle.Vertical;
            Appearance150.BorderColor=SystemColors.Window;
            ugCosts.DisplayLayout.GroupByBox.Appearance=Appearance150;
            Appearance151.ForeColor=SystemColors.GrayText;
            ugCosts.DisplayLayout.GroupByBox.BandLabelAppearance=Appearance151;
            ugCosts.DisplayLayout.GroupByBox.BorderStyle=Infragistics.Win.UIElementBorderStyle.Solid;
            Appearance152.BackColor=SystemColors.ControlLightLight;
            Appearance152.BackColor2=SystemColors.Control;
            Appearance152.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance152.ForeColor=SystemColors.GrayText;
            ugCosts.DisplayLayout.GroupByBox.PromptAppearance=Appearance152;
            ugCosts.DisplayLayout.MaxColScrollRegions=1;
            ugCosts.DisplayLayout.MaxRowScrollRegions=1;
            Appearance153.BackColor=SystemColors.Window;
            Appearance153.ForeColor=SystemColors.ControlText;
            ugCosts.DisplayLayout.Override.ActiveCellAppearance=Appearance153;
            Appearance154.BackColor=SystemColors.Highlight;
            Appearance154.ForeColor=SystemColors.HighlightText;
            ugCosts.DisplayLayout.Override.ActiveRowAppearance=Appearance154;
            ugCosts.DisplayLayout.Override.BorderStyleCell=Infragistics.Win.UIElementBorderStyle.Dotted;
            ugCosts.DisplayLayout.Override.BorderStyleRow=Infragistics.Win.UIElementBorderStyle.Dotted;
            Appearance155.BackColor=SystemColors.Window;
            ugCosts.DisplayLayout.Override.CardAreaAppearance=Appearance155;
            Appearance156.BorderColor=Color.Silver;
            Appearance156.TextTrimming=Infragistics.Win.TextTrimming.EllipsisCharacter;
            ugCosts.DisplayLayout.Override.CellAppearance=Appearance156;
            ugCosts.DisplayLayout.Override.CellClickAction=Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            ugCosts.DisplayLayout.Override.CellPadding=0;
            Appearance157.BackColor=SystemColors.Control;
            Appearance157.BackColor2=SystemColors.ControlDark;
            Appearance157.BackGradientAlignment=Infragistics.Win.GradientAlignment.Element;
            Appearance157.BackGradientStyle=Infragistics.Win.GradientStyle.Horizontal;
            Appearance157.BorderColor=SystemColors.Window;
            ugCosts.DisplayLayout.Override.GroupByRowAppearance=Appearance157;
            Appearance158.TextHAlignAsString="Left";
            ugCosts.DisplayLayout.Override.HeaderAppearance=Appearance158;
            ugCosts.DisplayLayout.Override.HeaderClickAction=Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            ugCosts.DisplayLayout.Override.HeaderStyle=Infragistics.Win.HeaderStyle.WindowsXPCommand;
            Appearance159.BackColor=SystemColors.Window;
            Appearance159.BorderColor=Color.Silver;
            ugCosts.DisplayLayout.Override.RowAppearance=Appearance159;
            ugCosts.DisplayLayout.Override.RowSelectors=Infragistics.Win.DefaultableBoolean.False;
            Appearance160.BackColor=SystemColors.ControlLight;
            ugCosts.DisplayLayout.Override.TemplateAddRowAppearance=Appearance160;
            ugCosts.DisplayLayout.ScrollBounds=Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            ugCosts.DisplayLayout.ScrollStyle=Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            ugCosts.DisplayLayout.ViewStyleBand=Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            ugCosts.Location=new Point(66, 987);
            ugCosts.Name="ugCosts";
            ugCosts.Size=new Size(1845, 768);
            ugCosts.TabIndex=18;
            ugCosts.Text="Costs for Selected Assigned Vendor";
            // 
            // _VendorCosts_Toolbars_Dock_Area_Left
            // 
            _VendorCosts_Toolbars_Dock_Area_Left.AccessibleRole=AccessibleRole.Grouping;
            _VendorCosts_Toolbars_Dock_Area_Left.BackColor=Color.FromArgb(191, 219, 255);
            _VendorCosts_Toolbars_Dock_Area_Left.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            _VendorCosts_Toolbars_Dock_Area_Left.ForeColor=SystemColors.ControlText;
            _VendorCosts_Toolbars_Dock_Area_Left.InitialResizeAreaExtent=16;
            _VendorCosts_Toolbars_Dock_Area_Left.Location=new Point(0, 108);
            _VendorCosts_Toolbars_Dock_Area_Left.Name="_VendorCosts_Toolbars_Dock_Area_Left";
            _VendorCosts_Toolbars_Dock_Area_Left.Size=new Size(16, 1984);
            _VendorCosts_Toolbars_Dock_Area_Left.ToolbarsManager=utmAssignedVendors;
            // 
            // _VendorCosts_Toolbars_Dock_Area_Right
            // 
            _VendorCosts_Toolbars_Dock_Area_Right.AccessibleRole=AccessibleRole.Grouping;
            _VendorCosts_Toolbars_Dock_Area_Right.BackColor=Color.FromArgb(191, 219, 255);
            _VendorCosts_Toolbars_Dock_Area_Right.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            _VendorCosts_Toolbars_Dock_Area_Right.ForeColor=SystemColors.ControlText;
            _VendorCosts_Toolbars_Dock_Area_Right.InitialResizeAreaExtent=16;
            _VendorCosts_Toolbars_Dock_Area_Right.Location=new Point(2933, 108);
            _VendorCosts_Toolbars_Dock_Area_Right.Name="_VendorCosts_Toolbars_Dock_Area_Right";
            _VendorCosts_Toolbars_Dock_Area_Right.Size=new Size(16, 1984);
            _VendorCosts_Toolbars_Dock_Area_Right.ToolbarsManager=utmAssignedVendors;
            // 
            // _VendorCosts_Toolbars_Dock_Area_Top
            // 
            _VendorCosts_Toolbars_Dock_Area_Top.AccessibleRole=AccessibleRole.Grouping;
            _VendorCosts_Toolbars_Dock_Area_Top.BackColor=Color.FromArgb(191, 219, 255);
            _VendorCosts_Toolbars_Dock_Area_Top.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            _VendorCosts_Toolbars_Dock_Area_Top.ForeColor=SystemColors.ControlText;
            _VendorCosts_Toolbars_Dock_Area_Top.Location=new Point(0, 0);
            _VendorCosts_Toolbars_Dock_Area_Top.Name="_VendorCosts_Toolbars_Dock_Area_Top";
            _VendorCosts_Toolbars_Dock_Area_Top.Size=new Size(2949, 73);
            _VendorCosts_Toolbars_Dock_Area_Top.ToolbarsManager=utmAssignedVendors;
            // 
            // _VendorCosts_Toolbars_Dock_Area_Bottom
            // 
            _VendorCosts_Toolbars_Dock_Area_Bottom.AccessibleRole=AccessibleRole.Grouping;
            _VendorCosts_Toolbars_Dock_Area_Bottom.BackColor=Color.FromArgb(191, 219, 255);
            _VendorCosts_Toolbars_Dock_Area_Bottom.DockedPosition=Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            _VendorCosts_Toolbars_Dock_Area_Bottom.ForeColor=SystemColors.ControlText;
            _VendorCosts_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent=16;
            _VendorCosts_Toolbars_Dock_Area_Bottom.Location=new Point(0, 2092);
            _VendorCosts_Toolbars_Dock_Area_Bottom.Name="_VendorCosts_Toolbars_Dock_Area_Bottom";
            _VendorCosts_Toolbars_Dock_Area_Bottom.Size=new Size(2949, 16);
            _VendorCosts_Toolbars_Dock_Area_Bottom.ToolbarsManager=utmAssignedVendors;
            // 
            // SpGetVendorsInUseTableAdapter
            // 
            SpGetVendorsInUseTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetAlphaCodesTableAdapter
            // 
            SpGetAlphaCodesTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetOpenProjectsTableAdapter
            // 
            SpGetOpenProjectsTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetTaxDistrictListTableAdapter
            // 
            SpGetTaxDistrictListTableAdapter.ClearBeforeFill=true;
            // 
            // SpGetResourcesByAlphaTableAdapter
            // 
            SpGetResourcesByAlphaTableAdapter.ClearBeforeFill=true;
            // 
            // utmAssignedVendors
            // 
            utmAssignedVendors.DesignerFlags=1;
            utmAssignedVendors.DockWithinContainer=this;
            utmAssignedVendors.DockWithinContainerBaseType=typeof(Form);
            utmAssignedVendors.HideToolbars=true;
            utmAssignedVendors.MiniToolbar.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { LabelTool1, LabelTool2, LabelTool3, LabelTool4, LabelTool6, LabelTool7, LabelTool8, LabelTool9, LabelTool10 });
            utmAssignedVendors.MiniToolbar.ToolRowCount=8;
            utmAssignedVendors.Ribbon.Visible=true;
            utmAssignedVendors.ShowFullMenusDelay=500;
            UltraToolbar1.DockedColumn=0;
            UltraToolbar1.DockedRow=0;
            UltraToolbar1.FloatingLocation=new Point(1128, 1058);
            UltraToolbar1.FloatingSize=new Size(253, 50);
            UltraToolbar1.Text="utAssignedfVendors";
            utmAssignedVendors.Toolbars.AddRange(new Infragistics.Win.UltraWinToolbars.UltraToolbar[] { UltraToolbar1 });
            LabelTool11.SharedPropsInternal.Caption="Add New Alpha Code for Selected Vendor";
            LabelTool12.SharedPropsInternal.Caption="Change Criteria for Selected Vendor";
            LabelTool13.SharedPropsInternal.Caption="Change Dates to Current Year";
            LabelTool14.SharedPropsInternal.Caption="Change Vendor for Selected Criteria";
            LabelTool16.SharedPropsInternal.Caption="Copy Selected Criteria to another Criteria";
            LabelTool17.SharedPropsInternal.Caption="Mark as Alternate";
            LabelTool18.SharedPropsInternal.Caption="Mark as Not Alternate";
            LabelTool19.SharedPropsInternal.Caption="Mark Pending";
            LabelTool20.SharedPropsInternal.Caption="Mark Not Pending";
            PopupMenuTool1.SharedPropsInternal.Caption="Assoigned Vendors";
            PopupMenuTool1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { LabelTool21, LabelTool22, LabelTool23, LabelTool24, LabelTool25, LabelTool27, LabelTool28, LabelTool29, LabelTool30 });
            utmAssignedVendors.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] { LabelTool11, LabelTool12, LabelTool13, LabelTool14, LabelTool16, LabelTool17, LabelTool18, LabelTool19, LabelTool20, PopupMenuTool1 });
            utmAssignedVendors.Visible=false;
            // 
            // VendorCosts
            // 
            AutoScaleDimensions=new SizeF(16.0f, 31.0f);
            AutoScaleMode=AutoScaleMode.Font;
            AutoSize=true;
            ClientSize=new Size(2949, 2108);
            Controls.Add(upCopyToAnotherCriteria);
            Controls.Add(ugAssignedVendors);
            Controls.Add(ulFilters);
            Controls.Add(upFilters);
            Controls.Add(upCopyToAnotherVendor);
            Controls.Add(upAddResources);
            Controls.Add(ugCosts);
            Controls.Add(_VendorCosts_Toolbars_Dock_Area_Left);
            Controls.Add(_VendorCosts_Toolbars_Dock_Area_Right);
            Controls.Add(tsToolStrip);
            Controls.Add(_VendorCosts_Toolbars_Dock_Area_Bottom);
            Controls.Add(_VendorCosts_Toolbars_Dock_Area_Top);
            Margin=new Padding(3, 2, 3, 2);
            Name="VendorCosts";
            Text="Vendor Costs and Contracts";
            upFilters.ClientArea.ResumeLayout(false);
            upFilters.ClientArea.PerformLayout();
            upFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uceIncludeCAPrices).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceIncludeHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceIncludeGenericSubs).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceIncludePending).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceHideNotInUse).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceFutureOnly).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucVendors).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetVendorsInUseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)HCHDataDSVendorCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucDistricts).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetTaxDistrictListBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetOpenProjectsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucAlphaCodes).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetAlphaCodesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbNoCriteriaFilter).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraRadioButtonGroupManager3).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbFilterByGlobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbFilterByDistrict).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbFilterByProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceFilterByAlphaCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceFilterByVendor).EndInit();
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            upAddAlpha.ClientArea.ResumeLayout(false);
            upAddAlpha.ClientArea.PerformLayout();
            upAddAlpha.ResumeLayout(false);
            upAddAlphs.ClientArea.ResumeLayout(false);
            upAddAlphs.ClientArea.PerformLayout();
            upAddAlphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucAddAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceSelectAllResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)udtToAddAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)udtFromAddAlpha).EndInit();
            upCopyToAnotherCriteria.ClientArea.ResumeLayout(false);
            upCopyToAnotherCriteria.ClientArea.PerformLayout();
            upCopyToAnotherCriteria.ResumeLayout(false);
            upDates.ClientArea.ResumeLayout(false);
            upDates.ClientArea.PerformLayout();
            upDates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)udteToCriteria).EndInit();
            ((System.ComponentModel.ISupportInitialize)udteFromCriteriaToCopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucDistrictToCopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)uceCopyAllResourcesForCriteria).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucProjectToCopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbGlobal).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraRadioButtonGroupManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbDistricts).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbProjects).EndInit();
            upAddResources.ClientArea.ResumeLayout(false);
            upAddResources.ClientArea.PerformLayout();
            upAddResources.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ugResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucResources).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpGetResourcesByAlphaBindingSource).EndInit();
            upCopyToAnotherVendor.ClientArea.ResumeLayout(false);
            upCopyToAnotherVendor.ClientArea.PerformLayout();
            upCopyToAnotherVendor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)urbHistoryNewVendor).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraRadioButtonGroupManager2).EndInit();
            ((System.ComponentModel.ISupportInitialize)udteToNewVendor).EndInit();
            ((System.ComponentModel.ISupportInitialize)udteFromNewVendor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucNewVendor).EndInit();
            ((System.ComponentModel.ISupportInitialize)urbPendingNewVendor).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugAssignedVendors).EndInit();
            ((System.ComponentModel.ISupportInitialize)ugCosts).EndInit();
            ((System.ComponentModel.ISupportInitialize)utmAssignedVendors).EndInit();
            Load+=new EventHandler(VendorCosts_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Infragistics.Win.Misc.UltraPanel upFilters;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceFilterByAlphaCode;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceFilterByVendor;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbFilterByProject;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager UltraRadioButtonGroupManager3;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbNoCriteriaFilter;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbFilterByGlobal;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbFilterByDistrict;
        internal ToolStrip tsToolStrip;
        internal ToolStripButton tsBtnAdd;
        internal ToolStripButton tsBtnEdit;
        internal ToolStripButton tsBtnUndo;
        internal ToolStripButton tsBtnDelete;
        internal ToolStripButton tsBtnSave;
        internal ToolStripButton tsButtonHelp;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripSeparator ToolStripSeparator2;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucAlphaCodes;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucProjects;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucDistricts;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucVendors;
        internal ToolStripButton tsBtnPrint;
        internal ToolStripButton tsBtnFind;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceIncludeGenericSubs;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceIncludePending;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceHideNotInUse;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceFutureOnly;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceIncludeCAPrices;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceIncludeHistory;
        internal Infragistics.Win.Misc.UltraLabel ulFilters;
        internal Infragistics.Win.Misc.UltraPanel upAddAlpha;
        internal Infragistics.Win.Misc.UltraLabel ulUpdateCosts;
        internal Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtToAddAlpha;
        internal Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFromAddAlpha;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceSelectAllResources;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel4;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel3;
        internal HCHDataDSVendorCost HCHDataDSVendorCost;
        internal BindingSource SpGetVendorsInUseBindingSource;
        internal HCHDataDSVendorCostTableAdapters.spGetVendorsInUseTableAdapter SpGetVendorsInUseTableAdapter;
        internal BindingSource SpGetAlphaCodesBindingSource;
        internal HCHDataDSVendorCostTableAdapters.spGetAlphaCodesTableAdapter SpGetAlphaCodesTableAdapter;
        internal BindingSource SpGetOpenProjectsBindingSource;
        internal HCHDataDSVendorCostTableAdapters.spGetOpenProjectsTableAdapter SpGetOpenProjectsTableAdapter;
        internal BindingSource SpGetTaxDistrictListBindingSource;
        internal HCHDataDSVendorCostTableAdapters.spGetTaxDistrictListTableAdapter SpGetTaxDistrictListTableAdapter;
        internal Infragistics.Win.Misc.UltraPanel upCopyToAnotherCriteria;
        internal Infragistics.Win.UltraWinEditors.UltraCheckEditor uceCopyAllResourcesForCriteria;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucProjectToCopy;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbGlobal;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbDistricts;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbProjects;
        internal Infragistics.Win.Misc.UltraLabel ulAlphaCodeSelected;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel14;
        internal Infragistics.Win.Misc.UltraLabel ulVendorSelected;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel12;
        internal Infragistics.Win.Misc.UltraLabel ulCriteriaSelected;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel10;
        internal Infragistics.Win.Misc.UltraButton ubSaveUpdatedCosts;
        internal Infragistics.Win.Misc.UltraButton ubSaveAnotherCriteria;
        internal Infragistics.Win.Misc.UltraButton ubCancelUpdatedCosts;
        internal Infragistics.Win.Misc.UltraButton ubCancelSaveAnotherCriteria;
        internal Infragistics.Win.Misc.UltraLabel ulCopyToAnotherCriteria;
        internal Infragistics.Win.Misc.UltraPanel upAddResources;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel11;
        internal Infragistics.Win.Misc.UltraButton ubCancelNewResources;
        internal Infragistics.Win.Misc.UltraButton ubSaveNewResources;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucResources;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel13;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel15;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel16;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel17;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel18;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel19;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel20;
        internal Infragistics.Win.UltraWinGrid.UltraGrid ugResources;
        internal BindingSource SpGetResourcesByAlphaBindingSource;
        internal HCHDataDSVendorCostTableAdapters.spGetResourcesByAlphaTableAdapter SpGetResourcesByAlphaTableAdapter;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager UltraRadioButtonGroupManager1;
        internal Infragistics.Win.Misc.UltraPanel upCopyToAnotherVendor;
        internal Infragistics.Win.Misc.UltraButton ubCancelNewVendor;
        internal Infragistics.Win.Misc.UltraButton ubSaveNewVendor;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel23;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel24;
        internal Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteToNewVendor;
        internal Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteFromNewVendor;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucNewVendor;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbHistoryNewVendor;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButton urbPendingNewVendor;
        internal Infragistics.Win.UltraWinEditors.UltraRadioButtonGroupManager UltraRadioButtonGroupManager2;
        internal Infragistics.Win.UltraWinGrid.UltraGrid ugAssignedVendors;
        internal Infragistics.Win.UltraWinGrid.UltraGrid ugCosts;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsManager utmAssignedVendors;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _VendorCosts_Toolbars_Dock_Area_Left;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _VendorCosts_Toolbars_Dock_Area_Right;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _VendorCosts_Toolbars_Dock_Area_Bottom;
        internal Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _VendorCosts_Toolbars_Dock_Area_Top;
        internal Infragistics.Win.Misc.UltraPopupControlContainer UltraPopupControlContainer1;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel26;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel25;
        internal Infragistics.Win.Misc.UltraPanel upAddAlphs;
        internal Infragistics.Win.Misc.UltraLabel ulCriteriaAddAlpha;
        internal Infragistics.Win.Misc.UltraLabel ulCriteria;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel2;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucAddAlpha;
        internal Infragistics.Win.UltraWinGrid.UltraCombo ucDistrictToCopy;
        internal Infragistics.Win.Misc.UltraPanel upDates;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel7;
        internal Infragistics.Win.Misc.UltraLabel UltraLabel8;
        internal Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteToCriteria;
        internal Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udteFromCriteriaToCopy;
    }
}