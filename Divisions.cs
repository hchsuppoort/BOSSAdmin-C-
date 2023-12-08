using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public partial class Divisions
    {
        private UltraDropDown ddNSMs = new UltraDropDown();
        private bool bAddNew = false;
        private int iDivisionManagerID;
        private int iProductionManagerID;
        private int iSalesManagerID;

        public Divisions()
        {
            InitializeComponent();
        }
        private void Divisions_Load(object sender, EventArgs e)
        {
            try
            {
                bool bGoOn;
                bGoOn=LoadDivisions();
                if (bGoOn)
                {
                    bGoOn=LoadDivisionManagers();
                }

                if (bGoOn)
                {
                    bGoOn=LoadProductionManagers();
                }
                if (bGoOn)
                {
                    bGoOn=LoadSalesManagers();
                }
                // 11/1/16 mrb
                iDivisionManagerID=(int)(uCboDivisionManagers.Value);
                iProductionManagerID=(int)(uCboProductionManagers.Value);
                iSalesManagerID=(int)(ucboSalesManagers.Value);
                if (bGoOn)
                {
                    bGoOn=LoadNSMGrid();
                }
                if (bGoOn)
                {
                    EnableDisableToolStrip(false, "Divisions_Load");
                }
                else
                {
                    modCommon.ShowError("Unable to load form.  Divisions_Load", false, "LoadError", "BOSSAdmin");
                    BeginInvoke(new MethodInvoker(Close));
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, MsgBoxStyle.Critical, "Divisions_Load");
            }
        }
        private bool LoadDivisions()
        {
            bool LoadDivisionsRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            string sNotifyCriteria = "";
            try
            {

                grdDivisions.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spDivisionDataGet"))
                {
                    grdDivisions.DataSource=ds;
                    grdDivisions.DataBind();
                    var layout = grdDivisions.DisplayLayout;
                    var bands = layout.Bands;
                    // Get the first band, which is the  top-most band in case you had multple bands.
                    var band = bands[0];
                    // Columns property off UltraGridBand returns the collection of columns associated with the band.

                    UltraGridColumn ugc;

                    ugc=grdDivisions.DisplayLayout.Bands[0].Columns["DivisionID"];
                    ugc.Hidden=true;

                    ugc=grdDivisions.DisplayLayout.Bands[0].Columns["Division"];
                    ugc.Width=150;

                    ugc=grdDivisions.DisplayLayout.Bands[0].Columns["DivisionManagerID"];

                    // ugc = grdNotifyList.DisplayLayout.Bands(0).Columns("Position")
                    // ugc.Width = 120

                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                  // select first row
                grdDivisions.Rows[0].Activate();
                grdDivisions.ActiveRow.Selected=true;

                LoadDivisionsRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Divisions: LoadDivisions ");
                LoadDivisionsRet=false;
            }

            return LoadDivisionsRet;
        }
        private bool LoadDivisionManagers()
        {
            bool LoadDivisionManagersRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            string sNotifyCriteria = "";
            string sManager = "";
            try
            {

                uCboDivisionManagers.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spUsersByPositionGet", 3)) // "spGetUserListByPosition", 3) Then
                {
                    uCboDivisionManagers.DataSource=ds;
                    uCboDivisionManagers.DataBind();

                    UltraGridColumn ugc;

                    ugc=uCboDivisionManagers.DisplayLayout.Bands[0].Columns["SIID"];
                    ugc.Hidden=true;
                    ugc=uCboDivisionManagers.DisplayLayout.Bands[0].Columns["fname"];
                    ugc.Hidden=true;
                    ugc=uCboDivisionManagers.DisplayLayout.Bands[0].Columns["lname"];
                    ugc.Hidden=true;
                    ugc=uCboDivisionManagers.DisplayLayout.Bands[0].Columns["inactive"]; // 11/1/16 mrb
                    ugc.Hidden=true;

                    ugc=uCboDivisionManagers.DisplayLayout.Bands[0].Columns["UserName"];
                    ugc.Header.Caption="User Name";
                    ugc.Width=150;


                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                LoadDivisionManagersRet=true;
                uCboDivisionManagers.Enabled=true;
                uCboDivisionManagers.DisplayMember="UserName";
                uCboDivisionManagers.ValueMember="siid";
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Divisions: LoadDivisionManagers ");
                LoadDivisionManagersRet=false;
            }

            return LoadDivisionManagersRet;
        }
        private bool LoadProductionManagers()
        {
            bool LoadProductionManagersRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            string sNotifyCriteria = "";
            try
            {

                uCboProductionManagers.DataSource=null;
                if (dbCalls.GetRecordsFromSP(ref ds, "spUsersByPositionGet", 2)) // "spGetUserListByPosition", 2) Then 11/1/16
                {
                    uCboProductionManagers.DataSource=ds;
                    uCboProductionManagers.DataBind();

                    UltraGridColumn ugc;

                    ugc=uCboProductionManagers.DisplayLayout.Bands[0].Columns["SIID"];
                    ugc.Hidden=true;
                    ugc=uCboProductionManagers.DisplayLayout.Bands[0].Columns["fname"];
                    ugc.Hidden=true;
                    ugc=uCboProductionManagers.DisplayLayout.Bands[0].Columns["lname"];
                    ugc.Hidden=true;
                    ugc=uCboProductionManagers.DisplayLayout.Bands[0].Columns["inactive"];
                    ugc.Hidden=true;

                    ugc=uCboProductionManagers.DisplayLayout.Bands[0].Columns["UserName"];
                    ugc.Header.Caption="User Name";
                    ugc.Width=150;


                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                uCboProductionManagers.Enabled=true;
                uCboProductionManagers.DisplayMember="UserName";
                uCboProductionManagers.ValueMember="siid";
                LoadProductionManagersRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Divisions: LoadProductionManagers ");
                LoadProductionManagersRet=false;
            }

            return LoadProductionManagersRet;
        }
        private bool LoadSalesManagers()
        {
            bool LoadSalesManagersRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();

            string sNotifyCriteria = "";
            try
            {

                ucboSalesManagers.DataSource=null;
                if (dbCalls.GetRecordsFromSP(ref ds, "spusersbypositionget", 28)) // "spGetUserListByPosition", 28) Then
                {

                    ucboSalesManagers.DataSource=ds;
                    ucboSalesManagers.DataBind();

                    UltraGridColumn ugc;

                    ugc=ucboSalesManagers.DisplayLayout.Bands[0].Columns["SIID"];
                    ugc.Hidden=true;
                    ugc=ucboSalesManagers.DisplayLayout.Bands[0].Columns["fname"];
                    ugc.Hidden=true;
                    ugc=ucboSalesManagers.DisplayLayout.Bands[0].Columns["lname"];
                    ugc.Hidden=true;
                    ugc=ucboSalesManagers.DisplayLayout.Bands[0].Columns["inactive"]; // 11/1/16 mrb
                    ugc.Hidden=true;

                    ugc=ucboSalesManagers.DisplayLayout.Bands[0].Columns["UserName"];
                    ugc.Header.Caption="User Name";
                    ugc.Width=150;


                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                ucboSalesManagers.Enabled=true;
                ucboSalesManagers.DisplayMember="UserName";
                ucboSalesManagers.ValueMember="siid";
                LoadSalesManagersRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Divisions: LoadSalesManagers ");
                LoadSalesManagersRet=false;
            }

            return LoadSalesManagersRet;
        }

        private void EnableDisableToolStrip(bool bEdit, string sCalledBy)
        {
            bool bCanEdit;
            try
            {
                bCanEdit=modCommon.HasEditSecurity("Divisions", "Menu")&!bEdit;
                tsToolStrip.Items["tsBtnAdd"].Enabled=false; // change the way we do adds mrb 11/1/16 bCanEdit
                tsToolStrip.Items["tsBtnEdit"].Enabled=bCanEdit;
                tsToolStrip.Items["tsBtnUndo"].Enabled=bEdit;
                tsToolStrip.Items["tsBtnSave"].Enabled=bEdit;
                tsToolStrip.Items["tsBtnPrint"].Enabled=false; // no report at this time 11/1/16 mrb Not bEdit
                if (bCanEdit&bEdit) // 11/1/16
                {
                    grdDivisions.DisplayLayout.Override.AllowAddNew=AllowAddNew.FixedAddRowOnBottom;
                }
                else
                {
                    grdDivisions.DisplayLayout.Override.AllowAddNew=AllowAddNew.No;
                } // 11/1/16 mrb
                if (bEdit) // bCanEdit Then  11/1/16 mrb
                {
                    // uCboDivisionManagers.ReadOnly = bCanEdit
                    // uCboProductionManagers.ReadOnly = bCanEdit
                    // ucboSalesManagers.ReadOnly = bCanEdit
                    // If sCalledBy = "tsBtnAdd" Then 'this part isn't used anymore mrb 11/1/16
                    // 'grdDivisions.DisplayLayout.AddNewBox.Hidden = False
                    // 'grdDivisions.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.True
                    // 'grdDivisions.DisplayLayout.Bands(0).ColumnFilters("divisionid").FilterConditions.Clear()
                    // 'grdNSM.DisplayLayout.AddNewBox.Hidden = True
                    // 'grdDivisions.DisplayLayout.Override.AllowAddNew = AllowAddNew.Yes
                    // Else
                    if (bCanEdit)
                    {
                        grdDivisions.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        grdDivisions.DisplayLayout.Bands[0].ColumnFilters["divisionid"].FilterConditions.Add(FilterComparisionOperator.Equals, grdDivisions.ActiveRow.Cells["divisionid"].Value);
                        grdDivisions.DisplayLayout.Override.AllowAddNew=AllowAddNew.FixedAddRowOnBottom; // AllowAddNew.Yes 'AllowAddNew.No
                                                                                                         // grdDivisions.DisplayLayout.AddNewBox.Hidden = True
                                                                                                         // grdNSM.DisplayLayout.AddNewBox.Hidden = bCanEdit
                        grdNSM.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                        if (sCalledBy=="tsBtnAdd")
                        {
                            grdNSM.DisplayLayout.Bands[0].Columns["SIID"].CellActivation=Activation.AllowEdit;
                        }
                        if (sCalledBy=="tsBtnEdit")
                        {
                            grdNSM.DisplayLayout.Bands[0].Columns["SIID"].CellActivation=Activation.NoEdit;
                        }
                        // 11/1/16 mrb
                        if (sCalledBy=="tsBtnAdd")
                        {
                            grdNSM.DisplayLayout.Bands[0].Columns["StartDate"].CellActivation=Activation.AllowEdit;
                        }
                        else
                        {
                            grdNSM.DisplayLayout.Bands[0].Columns["StartDate"].CellActivation=Activation.NoEdit;
                        }
                        if (sCalledBy=="tsBtnEdit")
                        {
                            grdNSM.DisplayLayout.Bands[0].Columns["EndDate"].CellActivation=Activation.AllowEdit;
                        }
                        else
                        {
                            grdNSM.DisplayLayout.Bands[0].Columns["EndDate"].CellActivation=Activation.NoEdit;
                        }
                        grdNSM.DisplayLayout.Bands[0].Columns["Inactive"].CellActivation=Activation.NoEdit;
                        grdNSM.DisplayLayout.Override.AllowAddNew=AllowAddNew.FixedAddRowOnBottom; // AllowAddNew.Yes
                                                                                                   // End If
                    }
                }
                else // if not bedit
                {
                    grdDivisions.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    // grdDivisions.DisplayLayout.AddNewBox.Hidden = True
                    grdNSM.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    grdDivisions.DisplayLayout.Bands[0].ColumnFilters["divisionid"].FilterConditions.Clear();
                    uCboDivisionManagers.ReadOnly=true;
                    uCboProductionManagers.ReadOnly=true;
                    ucboSalesManagers.ReadOnly=true;
                    // grdNSM.DisplayLayout.AddNewBox.Hidden = True
                    // uCboDivisionManagers.ReadOnly = bCanEdit
                    // uCboProductionManagers.ReadOnly = bCanEdit
                    // ucboSalesManagers.ReadOnly = bCanEdit
                    // grdNSM.DisplayLayout.AddNewBox.Hidden = bCanEdit

                    // grdReasons.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False
                }
            }
            catch
            {
                modCommon.ShowError("Error in EnableDisableToolStrip"+Information.Err().Description, false, "BOSSAdmin", "Divisions: EnableDisableToolStrip ");
            }

        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            EnableDisableToolStrip(true, "tsBtnAdd");

        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {

            EnableDisableToolStrip(true, "tsBtnEdit");
            bAddNew=false;
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            bool bSaved = false;
            if (bAddNew)
            {
                bSaved=SaveNewDivision();
            }
            else
            {
                bSaved=SaveDivisionChanges();
            }
            if (bSaved)
            {
                LoadNSMGrid();
                EnableDisableToolStrip(false, "tsBtnSave");
                bAddNew=true;
            }
        }
        private bool SaveNewDivision()
        {
            bool SaveNewDivisionRet = default;
            string sDivision = "";
            int iDivisionManagerID = 0;
            int iProductionManagerID = 0;
            int iSalesManagerID = 0;
            var cdb = new DBCalls();
            SaveNewDivisionRet=false;
            try
            {
                sDivision=grdDivisions.ActiveRow.Cells["division"].Text;
                iDivisionManagerID=(int)(uCboDivisionManagers.ActiveRow.Cells["siid"].Value);
                iProductionManagerID=(int)(uCboProductionManagers.ActiveRow.Cells["siid"].Value);
                iSalesManagerID=(int)(ucboSalesManagers.ActiveRow.Cells["siid"].Value);
                // create procedure spDivisionInsert
                // @Division varchar(50),
                // @CreatedBy char(10),
                // @DivisionManagerID int, 
                // @SalesManagerID int, 
                // @ProductionManagerID int
                if (cdb.GetReturnValueFromSP("spDivisionInsert", sDivision, modGlobals.gsUserID, iDivisionManagerID, iSalesManagerID, iProductionManagerID)==0)
                {
                    SaveNewDivisionRet=true;
                }
                else
                {
                    modCommon.ShowError("Unknown Error in savenewdivision ", true, "BOSSAdmin", "Divisions: SaveNewDivision ");
                }
            }
            catch
            {
                modCommon.ShowError("Error in savenewdivision: "+Information.Err().Description, false, "BOSSAdmin", "Divisions: SaveNewDivision ");
                SaveNewDivisionRet=false;
            }
            finally
            {
                cdb=null;
            }

            return SaveNewDivisionRet;
        }
        private bool SaveDivisionChanges()
        {
            bool SaveDivisionChangesRet = default;
            int iDivisionID = 0;
            int iDivisionManagerID = 0;
            int iProductionManagerID = 0;
            int iSalesManagerID = 0;
            var cdb = new DBCalls();
            bool bSaved = false;
            bool bChangesMade = false;
            SaveDivisionChangesRet=false;
            try
            {
                iDivisionID=(int)(grdDivisions.ActiveRow.Cells["DivisionID"].Value);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(uCboDivisionManagers.Value, iDivisionManagerID, false))) // mrb 11/1/16
                {
                    if (!string.IsNullOrEmpty(uCboDivisionManagers.Text))
                    {
                        iDivisionManagerID=(int)(uCboDivisionManagers.ActiveRow.Cells["siid"].Value);
                    }
                    bChangesMade=true;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(uCboProductionManagers.Value, iProductionManagerID, false))) // mrb 11/1/16
                {
                    if (!string.IsNullOrEmpty(uCboProductionManagers.Text))
                    {
                        iProductionManagerID=(int)(uCboProductionManagers.ActiveRow.Cells["siid"].Value);
                    }
                    bChangesMade=true;
                }
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectNotEqual(ucboSalesManagers.Value, iSalesManagerID, false))) // mrb 11/1/16
                {
                    if (!string.IsNullOrEmpty(ucboSalesManagers.Text))
                    {
                        iSalesManagerID=(int)(ucboSalesManagers.ActiveRow.Cells["siid"].Value);
                    }
                    bChangesMade=true;
                }
                // create procedure spDivisionUpdate
                // @DivisionID int,
                // @UpdatedBy char(10),
                // @DivisionManagerID int, 
                // @SalesManagerID int, 
                // @ProductionManagerID int
                if (bChangesMade) // 11/1/16 mrb
                {
                    if (cdb.GetReturnValueFromSP("spDivisionUpdate", iDivisionID, modGlobals.gsUserID, iDivisionManagerID, iSalesManagerID, iProductionManagerID)==0)
                    {
                        bSaved=true;
                        bSaved=SaveSalesManagers();
                        if (bSaved)
                        {
                            SaveDivisionChangesRet=true;
                        }
                    }
                }
                else // 11/1/16 mrb
                {
                    bSaved=SaveSalesManagers();
                    if (bSaved)
                    {
                        SaveDivisionChangesRet=true;
                    }
                }
                if (!bSaved)
                {
                    modCommon.ShowError("Unknown Error in SaveDivisionchanges ", true, "BOSSAdmin", "Divisions: SaveDivisionChanges ");
                }
            }
            catch
            {
                modCommon.ShowError("Error in saveDivisonChanges: "+Information.Err().Description, false, "BOSSAdmin", "Divisions: SaveDivisionChanges ");
                SaveDivisionChangesRet=false;
            }
            finally
            {
                cdb=null;
            }

            return SaveDivisionChangesRet;
        }
        private bool SaveSalesManagers()
        {
            bool SaveSalesManagersRet = default;
            int iSIID = 0;
            int iDivisionid = 0;
            var cdb = new DBCalls();
            bool bSaved = false;
            bool bOK = false;
            long lRtn = 0L;
            DateTime dStartDate = default;
            DateTime dEndDate = default;
            int iDivisionNSMID = 0;
            string sNSM = "";
            SaveSalesManagersRet=true;
            try
            {
                iDivisionid=(int)(grdDivisions.ActiveRow.Cells["DivisionID"].Value);
                // create procedure spDivisionNSMUpdate
                // @DivisionNSMID int,
                // @EndDate smalldatetime,
                // @UpdatedBy char(10)
                // create procedure spDivisionNSMInsert
                // @DivisionID int,
                // @CreatedBy char(10),
                // @SIID INT,
                // @StartDate smalldatetime
                Cursor=Cursors.WaitCursor;

                foreach (var oRow in grdNSM.Rows)
                {
                    if (oRow.DataChanged) // 11/1/16 mrb
                    {
                        if ((grdNSM.ActiveRow.Cells["DivisionNSMID"].Value !=null))
                        {
                            iDivisionNSMID=(int)(grdNSM.ActiveRow.Cells["DivisionNSMID"].Value);
                        }
                        else
                        {
                            iDivisionNSMID=0;
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
                        if (iDivisionNSMID!=0&dEndDate!=null&grdNSM.ActiveRow.Cells["EndDate"].OriginalValue==null)
                        {
                            lRtn=(long)cdb.GetReturnValueFromSP("spDivisionNSMUpdate", iDivisionNSMID, dEndDate, modGlobals.gsUserID);
                        }
                        else
                        {
                            // new nsm for this division
                            lRtn=(long)cdb.GetReturnValueFromSP("spDivisionNSMInsert", iDivisionid, modGlobals.gsUserID, iSIID, dStartDate);
                        }
                        bOK=lRtn==0L;
                        if (!bOK)
                        {
                            modCommon.ShowError("Unknown Error in savedivisionNSM "+sNSM, true, "BOSSAdmin", "Divisions: SaveNewDivision ");
                            SaveSalesManagersRet=false;
                        }
                        else
                        {
                            SaveSalesManagersRet=true;
                        }
                    }
                }
            }
            catch
            {
                modCommon.ShowError("Error in savenewdivision: "+Information.Err().Description, false, "BOSSAdmin", "Divisions: SaveNewDivision ");
                SaveSalesManagersRet=false;
            }
            finally
            {
                cdb=null;
                Cursor=Cursors.Default;
            }

            return SaveSalesManagersRet;
        }
        private void tsBtnUndo_Click(object sender, EventArgs e)
        {
            EnableDisableToolStrip(false, "tsBtnUndo");
            LoadDivisions();
            bAddNew=false;
        }

        private void grdDivisions_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            if (bAddNew)
            {
            }
            else
            {
                uCboDivisionManagers.Value=grdDivisions.ActiveRow.Cells["DivisionManagerID"].Value;
                uCboProductionManagers.Value=grdDivisions.ActiveRow.Cells["ProductionManagerID"].Value;
                ucboSalesManagers.Value=grdDivisions.ActiveRow.Cells["SalesManagerID"].Value;
                LoadNSMGrid();
            }
        }
        private bool LoadNSMGrid()
        {
            bool LoadNSMGridRet = default;
            var ds2 = new DataSet();
            var cDB = new DBCalls();
            int iDivisionID;
            var dsNSMs = new DataSet();
            try
            {
                // select n.SIID, StartDate, EndDate, Inactive, FName, LName, rtrim(FName) + LName as NSMName
                iDivisionID=(int)(grdDivisions.ActiveRow.Cells["divisionid"].Value);
                grdNSM.DataSource=null;
                if (cDB.GetRecordsFromSP(ref ds2, "spUsersDivisionNSMsGet", iDivisionID))
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
                    grdNSM.DisplayLayout.Bands[0].Columns["siid"].ValueList=ddNSMs;
                    ddNSMs.DisplayLayout.Bands[0].Columns["SIID"].Hidden=true;
                    ddNSMs.DisplayLayout.Bands[0].Columns["lname"].Hidden=true;
                    ddNSMs.DisplayLayout.Bands[0].Columns["fname"].Hidden=true;
                    ddNSMs.DisplayLayout.Bands[0].ColumnFilters["Inactive"].ResetKey(); // 11/1/16 mrb
                    ddNSMs.DisplayLayout.Bands[0].Columns["Inactive"].Hidden=true;

                    UltraGridColumn ugc;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["divisionnsmid"];
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["siid"];
                    // do not allow edit until in edit mode
                    ugc.CellActivation=Activation.Disabled;

                    // ugc.Hidden = True
                    ugc.Width=200;
                    ugc.Header.Caption="NSM";
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["fname"];
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["lname"];
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["nsmname"];
                    ugc.Header.Caption="NSM Name";
                    ugc.Width=250; // 150 11/1/16 mrb
                    ugc.Hidden=true;
                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["startdate"];
                    ugc.Header.Caption="Start Date";
                    // do not allow edit until in edit mode
                    ugc.CellActivation=Activation.Disabled;

                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["enddate"];
                    ugc.Header.Caption="End Date";
                    // do not allow edit until in edit mode
                    ugc.CellActivation=Activation.Disabled;

                    ugc=grdNSM.DisplayLayout.Bands[0].Columns["inactive"];

                    // do not allow edit until in edit mode
                    ugc.CellActivation=Activation.Disabled;
                    LoadNSMGridRet=true;
                    // this makes the add new button say nsm
                    grdNSM.DisplayLayout.Bands[0].Header.Caption="NSM";
                    if (grdNSM.Rows.Count>0)
                    {
                        grdNSM.Rows[0].Activate();
                        grdNSM.ActiveRow.Selected=true;
                        // 11/1/16 mrb add filters
                        grdNSM.Text="NSMs filtered by Active Only - change filters on End Date and Inactive to see ALL";
                        grdNSM.DisplayLayout.Bands[0].ColumnFilters["Inactive"].FilterConditions.Add(FilterComparisionOperator.Equals, false);
                        grdNSM.DisplayLayout.Bands[0].ColumnFilters["EndDate"].FilterConditions.Add(FilterComparisionOperator.Equals, DBNull.Value);

                    }
                }
                else
                {
                    LoadNSMGridRet=false;
                    modCommon.ShowError("Error in LoadNSMGrid: "+Information.Err().Description, false, "BOSSAdmin", "Divisions: LoadNSMGrid ");
                }
            }
            catch
            {
                LoadNSMGridRet=false;
                modCommon.ShowError("Error in LoadNSMGrid: "+Information.Err().Description, false, "BOSSAdmin", "Divisions: LoadNSMGrid ");
            }
            finally
            {
                cDB=null;
            }

            return LoadNSMGridRet;

        }

        private void grdNSM_BeforeCellActivate(object sender, CancelableCellEventArgs e)
        {
            if (e.Cell.Column.Key=="SIID") // 11/1/16 MRB
            {
                ddNSMs.DisplayLayout.Override.AllowRowFiltering=DefaultableBoolean.True;
                ddNSMs.DisplayLayout.Bands[0].ColumnFilters["inactive"].FilterConditions.Add(FilterComparisionOperator.Equals, "False");
            }
        }
        private void grdNSM_BeforeRowInsert(object sender, BeforeRowInsertEventArgs e)
        {
            // add new button is clicked
            // this makes sure that the user cannot change the nsm on the existing rows
            UltraGridColumn ugc;
            // enable edit on these two columns
            ugc=grdNSM.DisplayLayout.Bands[0].Columns["startdate"];
            ugc.CellActivation=Activation.AllowEdit;
            ugc=grdNSM.DisplayLayout.Bands[0].Columns["siid"];
            ugc.CellActivation=Activation.AllowEdit;
            ugc=grdNSM.DisplayLayout.Bands[0].Columns["enddate"];
            ugc.CellActivation=Activation.Disabled;

            // grdNSM.ActiveRow.Cells("siid").Activation = Activation.AllowEdit
            grdNSM.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;

        }

        private void grdNSM_afterSelectChange(object sender, BeforeSelectChangeEventArgs e)
        {
            // add mode
            if (string.IsNullOrEmpty(grdNSM.ActiveRow.Cells["siid"].Text))
            {
                grdNSM.ActiveRow.Cells["siid"].Activation=Activation.AllowEdit;
            }

            else
            {
                grdNSM.ActiveRow.Cells["siid"].Activation=Activation.Disabled;
            }
            if (string.IsNullOrEmpty(grdNSM.ActiveRow.Cells["startdate"].Text))
            {
                grdNSM.ActiveRow.Cells["startdate"].Activation=Activation.AllowEdit;
            }
            else
            {
                grdNSM.ActiveRow.Cells["startdate"].Activation=Activation.Disabled;
            }
            // edit mode
            if (string.IsNullOrEmpty(grdNSM.ActiveRow.Cells["enddate"].Text)&!string.IsNullOrEmpty(grdNSM.ActiveRow.Cells["startdate"].Text))
            {
                grdNSM.ActiveRow.Cells["enddate"].Activation=Activation.AllowEdit;
                grdNSM.DisplayLayout.Bands[0].Columns["enddate"].CellActivation=Activation.AllowEdit;
            }
            else
            {
                grdNSM.ActiveRow.Cells["enddate"].Activation=Activation.Disabled;
            }

        }

        private void grdNSM_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {

        }

        private void ucboSalesManagers_AfterCloseUp(object sender, EventArgs e)
        {
            ucboSalesManagers.DisplayLayout.Bands[0].ColumnFilters["inactive"].ResetKey();
        }

        private void ucboSalesManagers_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ucboSalesManagers.DisplayLayout.Override.AllowRowFiltering=DefaultableBoolean.True;
            ucboSalesManagers.DisplayLayout.Bands[0].ColumnFilters["inactive"].FilterConditions.Add(FilterComparisionOperator.Equals, "False");

        }

        private void uCboDivisionManagers_AfterCloseUp(object sender, EventArgs e)
        {
            uCboDivisionManagers.DisplayLayout.Bands[0].ColumnFilters["inactive"].ResetKey();
        }

        private void uCboDivisionManagers_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            uCboDivisionManagers.DisplayLayout.Override.AllowRowFiltering=DefaultableBoolean.True;
            uCboDivisionManagers.DisplayLayout.Bands[0].ColumnFilters["inactive"].FilterConditions.Add(FilterComparisionOperator.Equals, "False");
        }

        private void uCboProductionManagers_AfterCloseUp(object sender, EventArgs e)
        {
            uCboProductionManagers.DisplayLayout.Bands[0].ColumnFilters["inactive"].ResetKey();
        }

        private void uCboProductionManagers_BeforeDropDown(object sender, System.ComponentModel.CancelEventArgs e)
        {
            uCboProductionManagers.DisplayLayout.Override.AllowRowFiltering=DefaultableBoolean.True;
            uCboProductionManagers.DisplayLayout.Bands[0].ColumnFilters["inactive"].FilterConditions.Add(FilterComparisionOperator.Equals, "False");
        }
    }
}