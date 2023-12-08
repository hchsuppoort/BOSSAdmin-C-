using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public partial class ProjectMaintenance
    {
        private UltraDropDown ddNSMs = new UltraDropDown();
        private UltraDropDown ddBldr = new UltraDropDown();
        private bool bAddNew = false;

        public ProjectMaintenance()
        {
            InitializeComponent();
        }
        private bool LoadNSMGrid()
        {
            bool LoadNSMGridRet = default;
            var ds2 = new DataSet();
            var cDB = new DBCalls();
            int iProjectID;
            var dsNSMs = new DataSet();
            try
            {
                // select n.SIID, StartDate, EndDate, Inactive, FName, LName, rtrim(FName) + LName as NSMName
                iProjectID=(int)(ucboProject.ActiveRow.Cells["id"].Value);
                grdNSM.DataSource=null;
                if (cDB.GetRecordsFromSP(ref ds2, "spUsersProjectNSMsGet", iProjectID))
                {
                }
                grdNSM.DataSource=ds2;
                grdNSM.DataBind();
                // grdNSM.Height = 200
                // grdNSM.Width = 375
                if (cDB.GetRecordsFromSP(ref dsNSMs, "spUsersByPositionGet", 5))
                {
                    var layout = grdNSM.DisplayLayout;
                    var bands = layout.Bands;
                    // Get the first band, which is the  top-most band in case you had multple bands.
                    var band = bands[0];
                    // Columns property off UltraGridBand returns the collection of columns associated with the band.
                    var oColumns = band.Columns;
                    var oColumnSIID = oColumns["SIID"];
                    // create dropdown for Owner
                    ddNSMs.SetDataBinding(dsNSMs, null);
                    ddNSMs.ValueMember="SIID";
                    ddNSMs.DisplayMember="UserName";
                    // If grdNSM.Rows.Count > 0 Then
                    // End If

                    grdNSM.DisplayLayout.Bands[0].Columns["siid"].ValueList=ddNSMs;
                    grdNSM.DisplayLayout.Bands[0].Columns["siid"].Style=Infragistics.Win.UltraWinGrid.ColumnStyle.DropDown;
                    grdNSM.DisplayLayout.Bands[0].Columns["siid"].ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
                    ddNSMs.DisplayLayout.Bands[0].Columns["SIID"].Hidden=true;
                    ddNSMs.DisplayLayout.Bands[0].Columns["lname"].Hidden=true;
                    ddNSMs.DisplayLayout.Bands[0].Columns["fname"].Hidden=true;

                    UltraGridColumn ugc;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["projectnsmid"];
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["siid"];
                    // do not allow edit until in edit mode
                    // ugc.CellActivation = Activation.Disabled

                    // ugc.Hidden = True
                    ugc.Width=200;
                    ugc.Header.Caption="NSM";
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["fname"];
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["lname"];
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["nsmname"];
                    ugc.Header.Caption="NSM Name";
                    ugc.Width=150;
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["startdate"];
                    ugc.Header.Caption="Start Date";
                    // do not allow edit until in edit mode
                    // ugc.CellActivation = Activation.Disabled

                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["enddate"];
                    ugc.Header.Caption="End Date";
                    // do not allow edit until in edit mode
                    ugc.CellActivation=Activation.Disabled;

                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["inactive"];

                    // do not allow edit until in edit mode
                    // ugc.CellActivation = Activation.Disabled
                    LoadNSMGridRet=true;
                    // this makes the add new button say nsm
                    grdNSM.DisplayLayout.Bands[0].Header.Caption="NSM";
                    if (grdNSM.Rows.Count>0)
                    {
                        grdNSM.Rows[0].Activate();
                        grdNSM.ActiveRow.Selected=true;
                    }
                }
                else
                {
                    LoadNSMGridRet=false;
                    modCommon.ShowError("Error in LoadNSMGrid: "+Information.Err().Description, false, "BOSSAdmin", "Projects: LoadNSMGrid ");
                }
            }
            catch
            {
                LoadNSMGridRet=false;
                modCommon.ShowError("Error in LoadNSMGrid: "+Information.Err().Description, false, "BOSSAdmin", "Projects: LoadNSMGrid ");
            }
            finally
            {
                cDB=null;
            }

            return LoadNSMGridRet;

        }
        private bool LoadProjects()
        {
            bool LoadProjectsRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            string sNotifyCriteria = "";
            try
            {

                ucboProject.DataSource=null;
                ucboProject.DisplayLayout.NewColumnLoadStyle=NewColumnLoadStyle.Hide;

                if (dbCalls.GetRecordsFromSP(ref ds, "spProjectListGet"))
                {
                    ucboProject.DataSource=ds;
                    ucboProject.DataBind();
                } // 
                  // Columns property off UltraGridBand returns the collection of columns associated with the band.
                UltraGridColumn ugc;
                UltraGridBand oBand;
                oBand=ucboProject.DisplayLayout.Bands[0];
                // set all columns hidden in designtime, set those you want to see here
                ugc=oBand.Columns["ProjectName"];
                ugc.Width=200;
                ugc.Hidden=false;

                ugc=oBand.Columns["ProjectID"];
                ugc.Hidden=false;

                // select first row
                // ucboProject.Rows(0).Activate()
                // ucboProject.PerformAction(UltraComboAction.FirstRow)
                // ucboProject.ActiveRow.Selected = True
                // ucboProject.PerformAction(UltraComboAction.CloseDropdown)
                LoadProjectsRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: loadprojects ");
                LoadProjectsRet=false;
            }

            return LoadProjectsRet;
        }

        private void EnableDisableToolStrip(bool bEdit, string sCalledBy)
        {
            bool bCanEdit;
            try
            {
                bCanEdit=modCommon.HasEditSecurity("VPOReasons", "Menu")&!bEdit;
                tsToolStrip.Items["tsBtnAdd"].Enabled=bCanEdit;
                tsToolStrip.Items["tsBtnEdit"].Enabled=bCanEdit;
                tsToolStrip.Items["tsBtnUndo"].Enabled=bEdit;
                tsToolStrip.Items["tsBtnSave"].Enabled=bEdit;
                tsToolStrip.Items["tsBtnPrint"].Enabled=!bEdit;
                // grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.No
                if (!bCanEdit)
                {
                    modCommon.UltraGroupBoxReadOnly(ugbBasicInfo, false);
                    modCommon.UltraGroupBoxReadOnly(ugbUtilities, false);
                    ucboProject.Enabled=false;
                    modCommon.UltraGroupBoxReadOnly(ugbMoreInfo, false);
                    if (sCalledBy=="tsBtnAdd")
                    {
                        grdNSM.DisplayLayout.AddNewBox.Hidden=true;
                        // grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                        grdBuilders.DisplayLayout.AddNewBox.Hidden=true;
                        grdPlanPrices.DisplayLayout.AddNewBox.Hidden=true;
                        ucboProject.Visible=false;
                        txtProjectID.Visible=true;
                    }
                    else
                    {
                        grdNSM.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        grdNSM.DisplayLayout.AddNewBox.Hidden=false;
                        grdNSM.DisplayLayout.Override.AllowAddNew=AllowAddNew.Yes;
                        grdBuilders.DisplayLayout.AddNewBox.Hidden=false;
                        grdBuilders.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        grdBuilders.DisplayLayout.Override.AllowAddNew=AllowAddNew.Yes;
                        grdPlanPrices.DisplayLayout.AddNewBox.Hidden=false;
                        grdPlanPrices.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        grdPlanPrices.DisplayLayout.Override.AllowAddNew=AllowAddNew.Yes;
                        ucboProject.Visible=true;
                        txtProjectID.Visible=false;
                    }
                }
                else
                {
                    grdNSM.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    grdBuilders.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    grdPlanPrices.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    // grdDivisions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    // grdDivisions.DisplayLayout.AddNewBox.Hidden = True
                    // grdNSM.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                    // grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                    grdNSM.DisplayLayout.AddNewBox.Hidden=true;
                    // grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                    grdBuilders.DisplayLayout.AddNewBox.Hidden=true;
                    grdPlanPrices.DisplayLayout.AddNewBox.Hidden=true;
                    modCommon.UltraGroupBoxReadOnly(ugbBasicInfo, true);
                    // ugbUtilities.Enabled = False
                    modCommon.UltraGroupBoxReadOnly(ugbUtilities, true);
                    modCommon.UltraGroupBoxReadOnly(ugbMoreInfo, true);
                    ucboProject.Enabled=true;
                    // uCboDivisionManagers.ReadOnly = bCanEdit
                    // uCboProductionManagers.ReadOnly = bCanEdit
                    // ucboSalesManagers.ReadOnly = bCanEdit
                    // grdNSM.DisplayLayout.AddNewBox.Hidden = bCanEdit

                    // grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                }
            }
            catch
            {
                modCommon.ShowError("Error in EnableDisableToolStrip"+Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: EnableDisableToolStrip ");
            }

        }

        private void ProjectMaintenance_Load(object sender, EventArgs e)
        {
            bool bGoOn = false;
            try
            {
                bGoOn=LoadProjects();
                if (bGoOn)
                {
                    bGoOn=LoadTaxPermitDistricts();
                }
                if (bGoOn)
                {
                    bGoOn=LoadTitleInsCompany();
                }
            }
            // EnableDisableToolStrip(False, "ProjectMaintenance_Load")
            catch (Exception ex)
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: ProjectMaintenance_Load");
                BeginInvoke(new MethodInvoker(Close));
            }

        }

        private void ucboProject_AfterCloseUp(object sender, EventArgs e)
        {
            LoadProjectData();
        }
        private void LoadProjectData()
        {
            try
            {
                LoadNSMGrid();
                LoadBuilders();
                // find correct tax permit district
                ucboTaxPermit.Value=ucboProject.ActiveRow.Cells["TaxPermitID"].Value;
                // find correct title insurance company
                ucboTitleIns.Value=ucboProject.ActiveRow.Cells["TitleInsCompanyId"].Value;
                UltraGridRow oRow;
                oRow=ucboProject.ActiveRow;
                txtCable.Text=oRow.Cells["Cable"].Text;
                txtDrivingDirections.Text=oRow.Cells["DrivingDirections"].Text;
                txtModelPhone.Text=oRow.Cells["ModelPhoneNumber"].Text;
                txtPower.Text=oRow.Cells["Power"].Text;
                txtProjectName.Text=oRow.Cells["ProjectName"].Text;
                txtSetbacksBuffers.Text=oRow.Cells["SetbacksBuffers"].Text;
                txtSewerSeptic.Text=oRow.Cells["SewerOrSeptic"].Text;
                uchkComplete.Checked=Conversions.ToBoolean(oRow.Cells["Inactive"].Value);
                uchkCostPrice.Checked=Conversions.ToBoolean(oRow.Cells["StandardPlan"].Value);
                uchkHCHOwned.Checked=Conversions.ToBoolean(oRow.Cells["HCHOwned"].Value);
                uchkReadyForReleases.Checked=Conversions.ToBoolean(oRow.Cells["ReadyForReleases"].Value);
                txtLotCosts.Text=Strings.FormatCurrency(oRow.Cells["LotCosts"].Text);
                txtWater.Text=oRow.Cells["Water"].Text;
                txtTelephone.Text=oRow.Cells["Telephone"].Text;
                EnableDisableToolStrip(false, "LoadProjectData");
            }
            catch
            {
                modCommon.ShowError("Error in LoadProjectData"+Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: LoadProjectData ");
            }
            finally
            {
            }

        }
        private bool LoadTaxPermitDistricts()
        {
            bool LoadTaxPermitDistrictsRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();

            try
            {

                ucboTaxPermit.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spGetTaxPermitDistrictNames"))
                {
                    ucboTaxPermit.DataSource=ds;
                    ucboTaxPermit.DataBind();

                    // Columns property off UltraGridBand returns the collection of columns associated with the band.

                    // Dim ugc As UltraGridColumn

                    // ugc = ucboTaxPermit.DisplayLayout.Bands(0).Columns("DivisionID")
                    // ugc.Hidden = True

                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                  // select first row
                  // ucboTaxPermit.Rows(0).Activate()
                  // ucboTaxPermit.ActiveRow.Selected = True

                LoadTaxPermitDistrictsRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: loadTaxPermitDistricts ");
                LoadTaxPermitDistrictsRet=false;
            }

            return LoadTaxPermitDistrictsRet;
        }
        private bool LoadTitleInsCompany()
        {
            bool LoadTitleInsCompanyRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();

            try
            {

                ucboTitleIns.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spTitleInsuranceCompanyGet", 1))
                {
                    ucboTitleIns.DataSource=ds;
                    ucboTitleIns.DataBind();

                    // Columns property off UltraGridBand returns the collection of columns associated with the band.

                    // Dim ugc As UltraGridColumn

                    // ugc = ucbotitleins.DisplayLayout.Bands(0).Columns("DivisionID")
                    // ugc.Hidden = True

                    // ugc = ucbotitleins.DisplayLayout.Bands(0).Columns("Division")
                    // ugc.Width = 150


                    // ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Position")
                    // ugc.Width = 120

                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                  // select first row
                  // ucboTitleIns.Rows(0).Activate()
                  // ucboTitleIns.ActiveRow.Selected = True

                LoadTitleInsCompanyRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: LoadTitleInsCompany ");
                LoadTitleInsCompanyRet=false;
            }

            return LoadTitleInsCompanyRet;
        }
        private bool LoadBuilders()
        {
            bool LoadBuildersRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsBldrs = new DataSet();
            string iProjectID = "";

            try
            {
                iProjectID=ucboProject.ActiveRow.Cells["ID"].Text;
                grdBuilders.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spProjectBuildersGet", iProjectID))
                {
                    grdBuilders.DataSource=ds;
                    grdBuilders.DataBind();
                    grdBuilders.DisplayLayout.Bands[0].Columns["username"].Hidden=true;
                    grdBuilders.DisplayLayout.Bands[0].Columns["siid"].Width=150;
                    grdBuilders.DisplayLayout.Bands[0].Columns["siid"].Header.Caption="Builder";
                    grdBuilders.DisplayLayout.Bands[0].Columns["lname"].Hidden=true;
                    grdBuilders.DisplayLayout.Bands[0].Columns["fname"].Hidden=true;
                    grdBuilders.DisplayLayout.Bands[0].Columns["ProjBldrID"].Hidden=true;
                }
                if (dbCalls.GetRecordsFromSP(ref dsBldrs, "spUsersByPositionGet", 1))
                {
                    // Dim layout As UltraGridLayout = grdBuilders.DisplayLayout
                    // Dim bands As BandsCollection = layout.Bands
                    // ' Get the first band, which is the  top-most band in case you had multple bands.
                    // Dim band As UltraGridBand = bands(0)
                    // ' Columns property off UltraGridBand returns the collection of columns associated with the band.
                    // Dim oColumns As ColumnsCollection = band.Columns
                    // Dim oColumnSIID As UltraGridColumn = oColumns("SIID")
                    // create dropdown for Owner
                    ddBldr.SetDataBinding(dsBldrs, null);
                    ddBldr.ValueMember="SIID";
                    ddBldr.DisplayMember="UserName";
                    ddBldr.DisplayLayout.Bands[0].Columns["SIID"].Hidden=true;
                    ddBldr.DisplayLayout.Bands[0].Columns["lname"].Hidden=true;
                    ddBldr.DisplayLayout.Bands[0].Columns["fname"].Hidden=true;
                    if (grdBuilders.Rows.Count>0)
                    {
                        grdBuilders.DisplayLayout.Bands[0].Columns["siid"].ValueList=ddBldr;
                    }
                }
                LoadBuildersRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "ProjectMaintenance: LoadBuilders ");
                LoadBuildersRet=false;
            }

            return LoadBuildersRet;
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            // when saved
            if (SaveSalesManagers())
            {
                LoadProjects();
            }
        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            EnableDisableToolStrip(true, "tsBtnEdit_Click");
        }

        private void tsBtnUndo_Click(object sender, EventArgs e)
        {
            LoadProjectData();
            // EnableDisableToolStrip(False, "tsBtnUndo_Click") called in load project data
        }

        private void grdNSM_afterSelectChange(object sender, BeforeSelectChangeEventArgs e)
        {
            if (grdNSM.Rows.Count>0)
            {
                if (string.IsNullOrEmpty(grdNSM.ActiveRow.Cells["siid"].Text))
                {
                    grdNSM.ActiveRow.Cells["siid"].Activation=Activation.AllowEdit;
                    grdNSM.ActiveRow.Cells["startdate"].Activation=Activation.AllowEdit;
                }
                else
                {
                    grdNSM.DisplayLayout.Bands[0].Override.AllowUpdate=DefaultableBoolean.True;
                    grdNSM.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                    grdNSM.ActiveRow.Cells["siid"].Activation=Activation.Disabled;
                    grdNSM.ActiveRow.Cells["startdate"].Activation=Activation.Disabled;
                    grdNSM.ActiveRow.Cells["enddate"].Activation=Activation.AllowEdit;
                }
            }
        }
        private void grdBuilders_afterSelectChange(object sender, BeforeSelectChangeEventArgs e)
        {
            if (grdBuilders.Rows.Count>0)
            {
                if (string.IsNullOrEmpty(grdBuilders.ActiveRow.Cells["siid"].Text))
                {
                    grdBuilders.ActiveRow.Cells["siid"].Activation=Activation.AllowEdit;
                }
                else
                {
                    grdBuilders.ActiveRow.Cells["siid"].Activation=Activation.Disabled;
                }
            }
        }
        private bool SaveSalesManagers()
        {
            bool SaveSalesManagersRet = default;
            int iSIID = 0;
            int iProjectid = 0;
            var cdb = new DBCalls();
            bool bSaved = false;
            bool bOK = false;
            long lRtn = 0L;
            DateTime dStartDate = default;
            DateTime dEndDate = default;
            int iProjectNSMID = 0;
            string sNSM = "";
            SaveSalesManagersRet=false;
            try
            {
                iProjectid=(int)(ucboProject.ActiveRow.Cells["ID"].Value);
                // create procedure spProjectNSMUpdate
                // @ProjectNSMID int,
                // @EndDate smalldatetime,
                // @UpdatedBy char(10)
                // create procedure spProjectNSMInsert
                // @ProjectID int,
                // @CreatedBy char(10),
                // @SIID INT,
                // @StartDate smalldatetime
                Cursor=Cursors.WaitCursor;

                foreach (var oRow in grdNSM.Rows)
                {
                    if (grdNSM.Rows.Count>1)
                    {
                        if (!(grdNSM.ActiveRow.Cells["ProjectNSMID"].Value is DBNull))
                        {
                            iProjectNSMID=(int)(grdNSM.ActiveRow.Cells["ProjectNSMID"].Value);
                        }
                    }
                    else
                    {
                        iProjectNSMID=0;
                    }
                    dStartDate=Conversions.ToDate(grdNSM.ActiveRow.Cells["StartDate"].Text);
                    if (!string.IsNullOrEmpty(grdNSM.ActiveRow.Cells["EndDate"].Text))
                    {
                        dEndDate=Conversions.ToDate(grdNSM.ActiveRow.Cells["EndDate"].Text);
                    }
                    else
                    {
                        dEndDate=default;
                    }
                    sNSM=grdNSM.ActiveRow.Cells["siid"].Text;
                    iSIID=(int)(grdNSM.ActiveRow.Cells["siid"].Value);
                    if (iProjectNSMID!=0&!((object)dEndDate==null)&grdNSM.ActiveRow.Cells["EndDate"].OriginalValue is DBNull)
                    {
                        lRtn=(long)cdb.GetReturnValueFromSP("spProjectNSMUpdate", iProjectNSMID, dEndDate, modGlobals.gsUserID);
                    }
                    else
                    {
                        // new nsm for this Project
                        lRtn=(long)cdb.GetReturnValueFromSP("spProjectNSMInsert", iProjectid, modGlobals.gsUserID, iSIID, dStartDate);
                    }
                    bOK=lRtn==0L;
                    if (!bOK)
                    {
                        modCommon.ShowError("Unknown Error in saveProjectNSM "+sNSM, true, "BOSSAdmin", "Projects: SaveNewProject ");
                    }
                    else
                    {
                        SaveSalesManagersRet=true;
                    }
                }
            }
            catch
            {
                modCommon.ShowError("Error in savenewProject: "+Information.Err().Description, false, "BOSSAdmin", "Projects: SaveNewProject ");
                SaveSalesManagersRet=false;
            }
            finally
            {
                cdb=null;
                Cursor=Cursors.Default;
            }

            return SaveSalesManagersRet;
        }
        private bool SaveBuilders()
        {
            bool SaveBuildersRet = default;
            int iSIID = 0;
            int iProjectid = 0;
            var cdb = new DBCalls();
            bool bSaved = false;
            bool bOK = false;
            long lRtn = 0L;
            int ProjBldrID = 0;
            string sBuilder = "";
            SaveBuildersRet=false;
            try
            {
                iProjectid=(int)(ucboProject.ActiveRow.Cells["ID"].Value);
                // create PROCEDURE [dbo].[spProjectBuilderAdd]
                // @ProjectID Integer,
                // @BuilderID integer,
                // @CreatedBy char(10)
                Cursor=Cursors.WaitCursor;

                foreach (var oRow in grdNSM.Rows)
                {
                    sBuilder=grdNSM.ActiveRow.Cells["siid"].Text;
                    iSIID=(int)(grdNSM.ActiveRow.Cells["siid"].Value);

                    lRtn=(long)cdb.GetReturnValueFromSP("spProjectBuilderAdd", iProjectid, iSIID, modGlobals.gsUserID);
                    bOK=lRtn==0L;
                    if (!bOK)
                    {
                        modCommon.ShowError("Unknown Error in saveBuilders "+sBuilder, true, "BOSSAdmin", "Projects: SaveBuilders ");
                    }
                    else
                    {
                        SaveBuildersRet=true;
                    }
                }
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Projects: SaveBuilder ");
                SaveBuildersRet=false;
            }
            finally
            {
                cdb=null;
                Cursor=Cursors.Default;
            }

            return SaveBuildersRet;
        }

        private void grdBuilders_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            DeleteBuilder();
        }
        private void DeleteBuilder()
        {
            var cDB = new DBCalls();
            int iProjBldrID = 0;
            int iRtn = 0;

            try
            {
                iProjBldrID=(int)(grdBuilders.ActiveRow.Cells["ProjBldId"].Value);
                if (iProjBldrID!=Conversions.ToDouble(""))
                {
                    iRtn=(int)cDB.GetReturnValueFromSP("spProjectBuilderDelete", iProjBldrID);
                    if (iRtn==0)
                    {
                        Interaction.MsgBox("Builder Deleted", Constants.vbInformation, "DeleteBuilder");
                    }
                    else
                    {
                        modCommon.ShowError(Information.Err().Description, false, "BossAdmin", "ProjectMaintenance.DeleteBuilder");
                    }
                }
            }
            catch (Exception ex)
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Projects: DeleteBuilder ");
            }
            finally
            {
                cDB=null;
            }
        }
    }
}