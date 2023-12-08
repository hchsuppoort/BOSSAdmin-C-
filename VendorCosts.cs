using System;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class VendorCosts
    {
        private bool bLoading;
        private string sMode;
        private string sCalledBy;

        public VendorCosts()
        {
            InitializeComponent();
        }

        private void VendorCosts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetTaxDistrictList' table. You can move, or remove it, as needed.
            SpGetTaxDistrictListTableAdapter.Fill(HCHDataDSVendorCost.spGetTaxDistrictList);
            // 'TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetOpenProjects' table. You can move, or remove it, as needed.
            SpGetOpenProjectsTableAdapter.Fill(HCHDataDSVendorCost.spGetOpenProjects);
            // TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetAlphaCodes' table. You can move, or remove it, as needed.
            SpGetAlphaCodesTableAdapter.Fill(HCHDataDSVendorCost.spGetAlphaCodes);
            // TODO: This line of code loads data into the 'HCHDataDSVendorCost.spGetVendorsInUse' table. You can move, or remove it, as needed.
            SpGetVendorsInUseTableAdapter.Fill(HCHDataDSVendorCost.spGetVendorsInUse);



        }
        private void EnableDisable(bool bEnable)
        {
            ucAlphaCodes.Enabled=bEnable;
            ucDistricts.Enabled=bEnable;
            ucProjects.Enabled=bEnable;
            ucVendors.Enabled=bEnable;

        }

        private void uceFilterByAlphaCode_CheckedChanged(object sender, EventArgs e)
        {
            ucAlphaCodes.ActiveRow=null;
            ucAlphaCodes.Text="";
            if (uceFilterByAlphaCode.Checked==true)
            {
                ucAlphaCodes.Enabled=true;
            }
            else
            {
                ucAlphaCodes.Enabled=false;
            }

        }

        private void uceFilterByVendor_CheckedChanged(object sender, EventArgs e)
        {
            ucVendors.ActiveRow=null;
            ucVendors.Text="";
            if (uceFilterByVendor.Checked==true)
            {
                ucVendors.Enabled=true;
            }
            else
            {
                ucVendors.Enabled=false;
            }

        }

        private void UltraRadioButtonGroupManager3_SelectionChanged(object sender, RadioButtonGroupManagerSelectionChangedEventArgs e)
        {
            {
                var withBlock = ucDistricts;
                withBlock.ActiveRow=null;
                withBlock.Text="";
                withBlock.Enabled=false;
            }
            {
                var withBlock1 = ucProjects;
                withBlock1.ActiveRow=null;
                withBlock1.Text="";
                withBlock1.Enabled=false;
            }
            switch (e.NewSelectedRadioButton.Name??"")
            {
                case "urbFilterByDistrict":
                    {
                        ucDistricts.Enabled=true;
                        break;
                    }
                case "urbFilterByProject":
                    {
                        ucProjects.Enabled=true;
                        break;
                    }
                // do nothing
                case "urbFilterByGlobal":
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
                    // do nothing
            }


        }

        private void UltraRadioButtonGroupManager1_SelectionChanged(object sender, RadioButtonGroupManagerSelectionChangedEventArgs e)
        {
            {
                var withBlock = ucDistrictToCopy;
                withBlock.ActiveRow=null;
                withBlock.Text="";
                withBlock.Enabled=false;
            }
            {
                var withBlock1 = ucProjectToCopy;
                withBlock1.ActiveRow=null;
                withBlock1.Text="";
                withBlock1.Enabled=false;
            }
            switch (e.NewSelectedRadioButton.Name??"")
            {
                case "urbFilterByDistrict":
                    {
                        ucDistrictToCopy.Enabled=true;
                        break;
                    }
                case "urbFilterByProject":
                    {
                        ucProjectToCopy.Enabled=true;
                        break;
                    }
                // do nothing
                case "urbFilterByGlobal":
                    {
                        break;
                    }

                default:
                    {
                        break;
                    }
                    // do nothing
            }
        }

        private void utmAssignedVendors_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key??"")
            {
                case "AddAlpha":
                    {
                        AddAlpha();
                        break;
                    }
                case "ChangeCriteriaForVendor":    // LabelTool
                    {
                        ChangeCriteriaForVendor();
                        break;
                    }

                case "ChangeDates":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "ChangeVendor":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "CopyCriteria":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "MarkAlternate":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "UnmarkAlternate":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "MarkPending":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "NotPending":    // LabelTool
                    {
                        break;
                    }
                // Place code here

                case "PopupAssoignedVendors":    // PopupMenuTool
                    {
                        break;
                    }
                    // Place code here

            }

        }

        private void AddAlpha()
        {
            string sStart;
            string sEnd;

            sMode="AddAlpha";
            ucAddAlpha.Visible=true;
            EnableDisableGrids(false, "AddAlpha");
            if (sCalledBy=="AssignVendors")
            {
                ucResources.Visible=true;
            }
            else
            {
                ucResources.Visible=false;
            }
            {
                var withBlock = upAddAlpha;
                withBlock.Visible=true;
                ulUpdateCosts.Text="Add Alpha Code to Selected Vendor";
            }
            // End If '
            sStart="1/1/"+DateTime.Today.Year.ToString()+"";
            sEnd="12/31/"+DateTime.Today.Year.ToString()+"";
            udtFromAddAlpha.Value=sStart; // #1/1/2003#
            udtToAddAlpha.Value=sEnd; // #12/31/2003#
            upAddAlpha.Visible=true;
            if (ucAddAlpha.Rows.Count==0)
            {
                // fill table adapter
            }
            ulCriteriaAddAlpha.Visible=false;
            ulCriteria.Visible=false;
            return;

        }
        private void EnableDisableGrids(bool bEnable, string pCalledBy)
        {
            upFilters.Enabled=bEnable;
            ugAssignedVendors.Enabled=bEnable;

            switch (pCalledBy??"")
            {
                case "UpdateCost":
                case "AddAlpha":
                case "NewResources":
                    {
                        ugCosts.Enabled=true&sCalledBy=="AssignVendors";
                        break;
                    }
                case "AssignNewVendor":
                    {
                        ugCosts.Enabled=true&sCalledBy=="AssignVendors";
                        break;
                    }
                case "CopyCriteria":
                    {
                        ugCosts.Enabled=true&sCalledBy=="AssignVendors";
                        break;
                    }
                case "MarkToDelete": // 9/15/15
                    {
                        ugCosts.Enabled=true;
                        if (bEnable ==true)
                        {
                            ugCosts.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        }
                        else
                        {
                            ugCosts.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                        }
                            break;
                    }

                default:
                    {
                        ugCosts.Enabled=bEnable;
                        if (bEnable==true)
                        { ugCosts.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        }
                        else
                     {
                            ugCosts.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    }
                        break;
                    }
            }
            tsToolStrip.Enabled=bEnable;
        }
        private void ChangeCriteriaForVendor()
        {
            string sAlphaCode;
            int iAlphaID;
            // Dim sCriteria As String '5/11/17 mrb
            sMode="ChangeCriteria";
            ulCopyToAnotherCriteria.Text="Change Criteria for Selected Vendor";
            upCopyToAnotherCriteria.Visible=true;
            upDates.Visible=false;
            // LoadTaxPermitDistricts ssdbCopyDistrict
            // LoadProjects ssdbCopyProject
            EnableDisableGrids(false, "ChangeCriteria");
            EnableDisableMenus(false);

            {
                var withBlock = ugAssignedVendors.ActiveRow;
                sAlphaCode=withBlock.Cells["Alpha Code"].Text+" - "+withBlock.Cells["Description"].Text;
                iAlphaID=(int)(withBlock.Cells["Alpha ID"].Value);
                ulAlphaCodeSelected.Text=sAlphaCode;
                ulVendorSelected.Text=withBlock.Cells["Vendor"].Text;
                // ulCriteriaSelected.Text = GetCriteria(ugAssignedVendors.ActiveRow) add this back
            }

        }
        private void EnableDisableMenus(bool Enable)
        {

        }
        private string GetCriteria()
        {
            string GetCriteriaRet = default;
            string sCriteria = "";

            {
                var withBlock = ugAssignedVendors.ActiveRow;
                if (!string.IsNullOrEmpty(withBlock.Cells["Project"].Text))
                {
                    sCriteria=withBlock.Cells["Project"].Text;
                    urbProjects.Select();
                }
                else if (!string.IsNullOrEmpty(withBlock.Cells["District"].Text))
                {
                    sCriteria=withBlock.Cells["District"].Text;
                    urbDistricts.Select();
                }
                else if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(withBlock.Cells["Global"].Value, Constants.vbNullString, false)))
                {
                    sCriteria="Global";
                    urbGlobal.Select();
                }

            }
            // UltraRadioButtonGroupManager1_SelectionChanged() 'fix this
            GetCriteriaRet=sCriteria;
            return GetCriteriaRet;

        }

        private void upCopyToAnotherCriteria_PaintClient(object sender, PaintEventArgs e)
        {

        }
    }
}