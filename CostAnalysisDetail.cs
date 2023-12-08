using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public partial class CostAnalysisDetail
    {
        internal DataSet msDataSet = new DataSet();
        public long miAnalysisID;
        internal bool mbAddNew;
        internal long mlPID;
        private CostAnalysisSearch mParent;
        private string msProcessLog = "";
        private void CostAnalysisDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            modGlobals.gsCostAnalysisData=null;
        }
        public CostAnalysisDetail(CostAnalysisSearch frm1)
        {
            InitializeComponent();
            mParent=frm1;
        }


        private void CostAnalysisDetail_Load(object sender, EventArgs e)
        {
            try
            {
                GetDataDate();
                // TODO: This line of code loads data into the 'HCHDataQAAlphaCodes.spGetAlphaCodes' table. You can move, or remove it, as needed.
                if (HCHDataQAAlphaCodes.Tables[0].Rows.Count==0)
                {
                    SpGetAlphaCodesTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                    SpGetAlphaCodesTableAdapter.Fill(HCHDataQAAlphaCodes.spGetAlphaCodes);
                }
                // TODO: This line of code loads data into the 'HCHDataQADistricts.spGetTaxDistrictList' table. You can move, or remove it, as needed.
                if (HCHDataQADistricts.Tables[0].Rows.Count==0)
                {
                    SpGetTaxDistrictListTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                    SpGetTaxDistrictListTableAdapter.Fill(HCHDataQADistricts.spGetTaxDistrictList);
                }
                // TODO: This line of code loads data into the 'HCHDataQAProjectList.spGetOpenProjects' table. You can move, or remove it, as needed.
                if (HCHDataQAProjectList.Tables[0].Rows.Count==0)
                {
                    SpGetOpenProjectsTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                    SpGetOpenProjectsTableAdapter.Fill(HCHDataQAProjectList.spGetOpenProjects);
                }
                else
                {
                }

                // LoadDetailGrid() moved into if not mbaddnew mrb 12/21/14
                // SpGetAnalysesHeaderTableAdapter.Fill(HCHDataQADataSet.Tables(0), miAnalysisID) move down 12/21/14
                mbAddNew=miAnalysisID==0L|miAnalysisID==default;

                if (!mbAddNew)
                {
                    LoadDetailGrid();
                    SpGetAnalysesHeaderTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                    SpGetAnalysesHeaderTableAdapter.Fill((HCHDataQADataSet.spGetAnalysesHeaderDataTable)HCHDataQADataSet.Tables[0], (int?)miAnalysisID);

                    {
                        var withBlock = HCHDataQADataSet.Tables[0].Rows[0];

                        if ((ucProjectStandard.Text??"")==(ucProjectOptions.Text??"")&(ucProjectOptions.Text??"")==(ucProjectsPlans.Text??"")&(ucProjectsPlans.Text??"")==(ucProjectsCosts.Text??""))
                        {
                            chkUseInfoFromStandardProject.CheckState=CheckState.Checked;
                        }
                        else
                        {
                            chkUseInfoFromStandardProject.CheckState=CheckState.Unchecked;
                        }
                    }

                    EnableDisable(false, mbAddNew);
                    EnableDisableProjects(false);
                }
                else
                {
                    ucProjectStandard.Text="";
                    ucProjectStandard.Value=Constants.vbNull;
                    ucProjectOptions.Text="";
                    ucProjectOptions.Value=Constants.vbNull;
                    ucProjectsCosts.Text="";
                    ucProjectsCosts.Value=Constants.vbNull;
                    ucProjectsPlans.Text="";
                    ucProjectsPlans.Value=Constants.vbNull;
                    ucAlphaCodes.Text="";
                    ucAlphaCodes.Value=Constants.vbNull;
                    ucAlphaCodes.SelectedRow=null;
                    // ucDistricts.Text = ""
                    ucDistricts.Value=Constants.vbNull;
                    ucDistricts.SelectedRow=null;
                    ckPlansSelected.CheckState=CheckState.Unchecked;
                    EnableDisable(true, mbAddNew);
                    EnableDisableProjects(true);
                }
                modCommon.GetCostPlanPath();
                // The following lines of code create and set up the Popup menu. 

                ugDetails.ContextMenuStrip=ContextMenuStrip1;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Cost Analysis Detail Load: "+ex.Message, MsgBoxStyle.Critical, "CostAnalysisDetail_Load");
            }
        }
        private void LoadDetailGrid()
        {
            try
            {
                SpGetAnalysisTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
                int v=SpGetAnalysisTableAdapter.Fill((HCHDataAnalysisDetail.spGetAnalysisDataTable)HCHDataAnalysisDetail.Tables[0], (int?)miAnalysisID);
                ugDetails.DataBind();
                ugDetails.ActiveRow=null;
                ugDetails.Selected.Rows.Clear();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in LoadDetailGrid: "+ex.Message, MsgBoxStyle.Critical, "LoadDetailGrid");
            }
        }
        private void EnableDisable(bool bEdit, bool bAddNew)
        {
            try
            {
                pnlFields.Enabled=bEdit;

                // tool strip
                tsBtnEdit.Enabled=bEdit==false&bAddNew==false;
                tsBtnPrint.Enabled=bEdit==false;
                tsBtnSave.Enabled=bEdit&!bAddNew;
                tsBtnPrintRpt2.Enabled=bEdit==false;
                tsBtnUndo.Enabled=bEdit;
                tsBtnRecalculateGrid.Enabled=bEdit;
                // project select
                chkDoNotUse.Enabled=bEdit;
                ckPlansSelected.Enabled=false;
                ucAlphaCodes.Enabled=bEdit&bAddNew;
                ucDistricts.Enabled=bEdit&bAddNew;
                btnSelectPlans.Enabled=bEdit&bAddNew;
                gpBoxStandardAnalysis.Enabled=bEdit&bAddNew;
                gpCustomAnalysis.Enabled=bEdit&bAddNew;
                uteAnalysisName.ReadOnly=bEdit==false;
                uteNewMargin.ReadOnly=bEdit==false;
                uteNotes.ReadOnly=bEdit==false;
                utePeriod.ReadOnly=bEdit==false;
                uteProjectID.ReadOnly=bEdit==false&bAddNew;
                uteProjectName.ReadOnly=bEdit==false;
                uteSoftCosts.ReadOnly=bEdit==false;
                tsBtnRecalculateGrid.Enabled=bEdit;
                {
                    var withBlock = ugDetails.DisplayLayout.Bands[0];
                    if (bEdit)
                    {
                        withBlock.Override.AllowUpdate=DefaultableBoolean.True;
                        withBlock.Columns["AnalysisPrice"].CellActivation=Activation.AllowEdit;
                    }
                    else
                    {
                        withBlock.Override.AllowUpdate=DefaultableBoolean.False;
                        withBlock.Columns["AnalysisPrice"].CellActivation=Activation.NoEdit;
                    }
                }
                btnSelectPlans.Enabled=bEdit&bAddNew&!string.IsNullOrEmpty(ucProjectsPlans.Text);
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Enable/Disable: "+ex.Message, MsgBoxStyle.Critical, "EnableDisable");

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CostAnalysisPlanChooser.msPlanProjectID=ucProjectsPlans.Text;
            My.MyProject.Forms.CostAnalysisPlanChooser.ShowDialog();
            ckPlansSelected.Checked=modGlobals.gsCostAnalysisData is not null;
        }

        private void ucProjectStandard_RowSelected(object sender, RowSelectedEventArgs e)
        {
            try
            {
                if (e.Row is not null)
                {
                    ChangeProjectDropdowns();
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Row Selected: "+ex.Message, MsgBoxStyle.Critical, "ucProjectStandard_RowSelected");
            }
        }
        private void EnableDisableProjects(bool bEnable)
        {
            ucProjectOptions.ReadOnly=!bEnable;
            ucProjectsPlans.ReadOnly=!bEnable;
            ucProjectsCosts.ReadOnly=!bEnable;

        }
        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            EnableDisable(true, mbAddNew);
        }
        private void ChangeProjectDropdowns()
        {
            if (mbAddNew)
            {
                if (chkUseInfoFromStandardProject.CheckState==CheckState.Checked)
                {
                    ucProjectOptions.Value=ucProjectStandard.Value;
                    ucProjectsPlans.Value=ucProjectStandard.Value;
                    ucProjectsCosts.Value=ucProjectStandard.Value;
                    ucDistricts.Value=ucProjectStandard.SelectedRow.Cells["TaxPermitID"].Value;
                    EnableDisableProjects(false);
                }
                else
                {
                    EnableDisableProjects(true);
                }

            }
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            Enabled=false;
            My.MyProject.Forms.mdiMain.UseWaitCursor=true;
            if (!string.IsNullOrEmpty(ucProjectStandard.Text)&mbAddNew|!mbAddNew)
            {
                if (ValidData())
                {
                    if (SaveRecord())
                    {
                        mbAddNew=false;
                        EnableDisable(false, mbAddNew);
                    }
                }
            }
            else
            {
                Interaction.MsgBox("You must select a Copy Project to complete the analysis.", Constants.vbInformation, "ButtonClick_Save");
            }
            My.MyProject.Forms.mdiMain.UseWaitCursor=false;
            Enabled=true;
        }
        private bool ValidData()
        {
            bool ValidDataRet = default;
            string sMsg = "";

            try
            {

                ValidDataRet=true;
                switch (Strings.Len(uteProjectID.Text))
                {
                    case 0:
                        {
                            ValidDataRet=false;
                            sMsg="Project ID is required";
                            break;
                        }
                    case var case1 when case1<5:
                        {
                            ValidDataRet=false;
                            sMsg="Project ID must be 5 characters";
                            break;
                        }
                }

                if (Strings.Len(uteNewMargin.Text)==0)
                {
                    ValidDataRet=false;
                    sMsg=sMsg+Constants.vbCrLf+"Margin is required";
                }
                if (Strings.Len(uteProjectName.Text)==0)
                {
                    ValidDataRet=false;
                    sMsg=sMsg+Constants.vbCrLf+"Project Name is required";
                }
                if (Strings.Len(uteAnalysisName.Text)==0)
                {
                    ValidDataRet=false;
                    sMsg=sMsg+Constants.vbCrLf+"Analysis Name is required";
                }

                if (Strings.Len(sMsg)>0)
                {
                    Interaction.MsgBox(sMsg, Constants.vbInformation, "ValidData");
                    ValidDataRet=false;
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbCritical, "ValidData");
                ValidDataRet=false;
            }

            return ValidDataRet;

        }
        public bool SaveRecord()
        {
            bool SaveRecordRet = default;
            SqlCommand oCMD;
            bool bGoOn;
            long lRtn = 0L;
            try
            {

                My.MyProject.Forms.mdiMain.UseWaitCursor=true;
                Enabled=false;

                if (mbAddNew)
                {
                    UltraStatusBar1.Panels["CurrentProcess"].Text="Copying Project to Cost Analysis Project";
                    bGoOn=CopyProject();
                    msProcessLog="Copy Project: "+uteProjectID.Text+" to Cost Analysis Project: "+ucProjectStandard.Text;
                    if (bGoOn)
                    {
                        if (CreateJobs(true))
                        {
                            bGoOn=true;
                        }
                    }
                }
                else
                {
                    UltraStatusBar1.Panels["CurrentProcess"].Text="Beginning Save Jobs Process";

                    bGoOn=SaveJobs();

                    if (!bGoOn)
                    {
                        Interaction.MsgBox("Analysis Changes Saved with some Problems", Constants.vbInformation, "SaveRecord");
                    }
                    // bGoOn = False we want to reload data even if some jobs didn't save right
                    else
                    {
                        // MsgBox("Analysis Changes Saved", vbInformation, "SaveRecord")
                        // bGoOn = True
                    }


                }
                if (bGoOn)
                {
                    UltraStatusBar1.Panels["CurrentProcess"].Text="Creating new Analysis record"+uteProjectID.Text;
                    msProcessLog=msProcessLog+"Creating New Analysis record for: "+uteProjectID.Text; // 1/14/15
                    bGoOn=UpdateAnalysis();
                }
                if (bGoOn)
                {
                    LoadDetailGrid();
                    mParent.LoadSearchGrid();
                    if (mbAddNew)
                    {
                        var argthisGrid = mParent.UltraGrid1;
                        ScrollGrid(ref argthisGrid, 0);
                        mParent.UltraGrid1=argthisGrid;
                    }
                }

                SaveRecordRet=bGoOn;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error Saving Record: "+ex.Message, MsgBoxStyle.Critical, "SaveRecord");
                SaveRecordRet=false;
            }
            finally
            {
                if (mbAddNew)
                {
                    var oErrorLog = new ErrorLog();
                    oErrorLog.Text="Progress creating Cost Analysis";
                    oErrorLog.uteLog.Text=msProcessLog;
                    oErrorLog.ShowDialog();
                }

                oCMD=null;
                My.MyProject.Forms.mdiMain.UseWaitCursor=false;
                Enabled=true;
            }

            return SaveRecordRet;
        }
        private bool CopyProject()
        {
            bool CopyProjectRet = default;
            DBCalls cDB;
            string sProjectID;
            string sProjectIDNew;
            string sProjectName;
            string sOptionProject;
            string sPlanProject;
            string sCostProject;
            var iDoNotCopyPlans = default(int);
            var iDoNotCopyOptions = default(int);
            var iDoNotCopyPrices = default(int);
            string sMsg = "";
            int iTaxPermitID;
            bool bGoOn = true;

            try
            {

                // @ProjectID varchar(5),         '
                // @ProjectIDNew varchar(5),      '
                // @ProjectName varchar(50),      '
                // @CreatedBy char(10),           '
                // @StandardPlan tinyint,         '
                // @CreateProject tinyint = 1,    '
                // @DoNotCopyOptions tinyint = 0, '
                // @DoNotCopyPlans tinyint = 0,   '
                // @TaxPermitIDNew int = 0        '
                // @DoNotCopyPrices int = 0       '

                cDB=new DBCalls();
                sProjectID=ucProjectStandard.Text;
                sProjectIDNew=uteProjectID.Text;
                sProjectName=uteProjectName.Text;

                sPlanProject=ucProjectsPlans.Text;
                if ((sPlanProject??"")!=(sProjectID??""))
                {
                    iDoNotCopyPlans=1;
                }
                sOptionProject=ucProjectOptions.Text;
                if ((sOptionProject??"")!=(sProjectID??""))
                {
                    iDoNotCopyOptions=1;
                }
                sCostProject=ucProjectsCosts.Text;
                if ((sCostProject??"")!=(sProjectID??""))
                {
                    iDoNotCopyPrices=1;
                }
                iTaxPermitID=(int)(ucDistricts.Value);

                // if all things are copied then use this one            '
                if (!MakeProject(sProjectID, sProjectIDNew, sProjectName, iDoNotCopyOptions, iDoNotCopyPlans, iTaxPermitID, 1, iDoNotCopyPrices))
                {
                    sMsg="Error Posting new project."+Information.Err().Description;
                    bGoOn=false;
                }
                // the project is copied, now copy the options '
                if (bGoOn)
                {
                    if (iDoNotCopyPlans==1&(sPlanProject??"")!=(sProjectID??""))
                    {
                        if (!MakeProject(sPlanProject, sProjectIDNew, sProjectName, 1, 0, iTaxPermitID, 0, 1))
                        {
                            sMsg="Error Posting Plans to project.";
                            bGoOn=false;
                        }
                    }
                }
                if (bGoOn)
                {
                    // the project and plans are copied, now copy the options '
                    if (iDoNotCopyOptions==1&(sOptionProject??"")!=(sProjectID??""))
                    {
                        if (!MakeProject(sOptionProject, sProjectIDNew, sProjectName, 0, 1, iTaxPermitID, 0, 1))
                        {
                            sMsg="Error Posting options to project.";
                            bGoOn=false;
                        }
                    }
                }
                // now copy prices '
                if (bGoOn)
                {
                    if (iDoNotCopyPrices==1&(sCostProject??"")!=(sProjectID??""))
                    {
                        if (!MakeProject(sCostProject, sProjectIDNew, sProjectName, 1, 1, iTaxPermitID, 0, 0))
                        {
                            sMsg="Error Posting prices for project.";
                            bGoOn=false;
                        }
                    }
                }
                CopyProjectRet=bGoOn;
            }

            catch (Exception ex)
            {
                Interaction.MsgBox(sMsg+" "+ex.Message, Constants.vbCritical, "CopyProject");
                CopyProjectRet=false;
            }

            return CopyProjectRet;
        }
        private bool MakeProject(string sProjectID, string sProjectIDNew, string sProjectName, int iDoNotCopyOptions, int iDoNotCopyPlans, int iTaxPermitID, int iCreateProject, int iDoNotCopyPrices)



        {
            bool MakeProjectRet = default;
            SqlCommand oCMD;
            string sMsg = "";
            bool bGoOn = true;
            long lRtn = 0L;
            // Dim lPID As Long = 0
            try
            {
                oCMD=new SqlCommand();
                // @ProjectID varchar(5),         '
                // @ProjectIDNew varchar(5),      '
                // @ProjectName varchar(50),      '
                // @CreatedBy char(10),           '
                // @StandardPlan tinyint,         '
                // @CreateProject tinyint = 1,    '
                // @DoNotCopyOptions tinyint = 0, '
                // @DoNotCopyPlans tinyint = 0,   '
                // @TaxPermitIDNew int = 0,       '
                // @PID INT OUTPUT                '

                {
                    ref var withBlock = ref oCMD;
                    withBlock.Connection=modGlobals.gCN;
                    withBlock.CommandType=CommandType.StoredProcedure;
                    withBlock.CommandTimeout=300;
                    withBlock.CommandText="spCopyProject";
                    // Add the input parameter and set its properties. 
                    var parameter = new SqlParameter();
                    parameter.ParameterName="@PID";
                    parameter.SqlDbType=SqlDbType.Int;
                    parameter.Direction=ParameterDirection.Output;
                    withBlock.Parameters.Add(parameter);
                    withBlock.Parameters.AddWithValue("@ProjectID", sProjectID);
                    withBlock.Parameters.AddWithValue("@ProjectIDNew", sProjectIDNew);
                    withBlock.Parameters.AddWithValue("@ProjectName", sProjectName);
                    withBlock.Parameters.AddWithValue("@DoNotCopyOptions", iDoNotCopyOptions);
                    withBlock.Parameters.AddWithValue("@DoNotCopyPlans", iDoNotCopyPlans);
                    withBlock.Parameters.AddWithValue("@TaxPermitIDNew", iTaxPermitID);
                    withBlock.Parameters.AddWithValue("@CreatedBy", modGlobals.gsUserID);
                    withBlock.Parameters.AddWithValue("@CreateProject", iCreateProject);
                    withBlock.Parameters.AddWithValue("@StandardPlan", 1);
                    withBlock.Parameters.AddWithValue("@DoNotCopyPrices", iDoNotCopyPrices);
                    parameter=new SqlParameter();
                    parameter.SqlDbType=SqlDbType.Int;
                    parameter.ParameterName="@RC";
                    parameter.Direction=ParameterDirection.ReturnValue;
                    oCMD.Parameters.Add(parameter);

                    lRtn=oCMD.ExecuteNonQuery(); // change to executescalar
                    lRtn=Conversions.ToLong(oCMD.Parameters["@RC"].Value);
                    if (lRtn==0L)
                    {
                        if (iCreateProject==1)
                        {
                            mlPID=Conversions.ToLong(withBlock.Parameters["@PID"].Value);
                        }
                        bGoOn=true;
                    }
                    else
                    {
                        if (lRtn==11L)
                        {
                            sMsg="Project ID: "+sProjectIDNew+" already exists.";
                        }
                        Interaction.MsgBox(sMsg, MsgBoxStyle.Critical, "MakeProject");
                        bGoOn=false;
                    }
                }    // }-> With oCMD
                MakeProjectRet=bGoOn;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Unable to copy project."+" "+sMsg+ex.Message, Constants.vbCritical, "MakeProject");
                MakeProjectRet=false;
            }
            finally
            {
                oCMD=null;
            }

            return MakeProjectRet;
        }
        private void ScrollGrid(ref UltraGrid thisGrid, int iRow)
        {

            // Get the row to scroll into view.
            var row = thisGrid.Rows[iRow];

            // Set the back color of the row so we can identify it on the screen.
            row.Appearance.BackColor=Color.LightSkyBlue;

            // Call ScrollRowIntoView on the active row-scroll-region to scroll the row into 
            // view vertically.
            thisGrid.ActiveRowScrollRegion.ScrollRowIntoView(row);

            // Call the ScrollRowIntoView on the active col-scroll-region to scroll the row into view 
            // vertically.
            thisGrid.ActiveColScrollRegion.ScrollRowIntoView(row, thisGrid.ActiveRowScrollRegion);

        }
        private bool SaveJobs()
        {
            bool SaveJobsRet = default;
            var oCMD = new SqlCommand();
            string sJobID;
            long lPlanPrice;
            var bTrans = default(bool);
            // Dim lRtn As Long
            SqlTransaction transaction = null;
            string sNote;
            try
            {
                // Start a local transaction
                transaction=modGlobals.gCN.BeginTransaction("SaveJobs");
                // With oCMD
                // .Connection = gCN
                // .Transaction = transaction
                // .CommandType = CommandType.StoredProcedure
                // .CommandTimeout = 300
                // .CommandText = "spUpdateJobForCostAnalysis"
                // End With
                bTrans=true; // DataRow
                SaveJobsRet=true;
                foreach (var oRow in ugDetails.Rows) // HCHDataAnalysisDetail.Tables(0).Rows
                {
                    // If SaveJobs = False Then
                    // Exit For
                    // End If
                    sJobID=oRow.Cells["JobID"].Text; // .Item("JobID").Text
                    if (oRow.Cells["UpdatedPrice"].Text=="")
                    {
                        lPlanPrice=0;
                    }
                    else
                    {
                        lPlanPrice=Conversions.ToLong(oRow.Cells["UpdatedPrice"].Value);
                    }
                    sNote=oRow.Cells["Note"].Text;
                    UltraStatusBar1.Panels["JobBeingProcessed"].Text="Job Being Processed: "+sJobID;
                    UltraStatusBar1.Panels["CurrentProcess"].Text="Saving Job: "+sJobID;
                    if (!SaveJob(sJobID, lPlanPrice, sNote, ref transaction))
                    {
                        SaveJobsRet=false;
                        break;
                    }
                }

                if (SaveJobsRet)
                {
                    transaction.Commit();
                    bTrans=false;
                }
                else
                {
                    transaction.Rollback();
                    bTrans=false;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error posting changes to job record."+ex.Message, Constants.vbCritical, "SaveJob");
                if (bTrans)
                {
                    transaction.Rollback();
                }
                SaveJobsRet=false;
            }
            finally
            {
                // oCMD = Nothing
            }

            return SaveJobsRet;
        }
        private bool CreateJobs(bool bCreateJob)
        {
            bool CreateJobsRet = default;
            DBCalls cDB;
            DataSet rs;
            string sFile;
            SqlCommand oCMD;
            string sProject;
            string sPlan = "";
            int iJob;
            SqlCommand oCMD2;
            string sJobID = "";
            string sBlock;
            string sLot;
            long lErr;
            DateTime dFileDate;
            string sMsg = "";
            bool bTrans;
            string sPlanProject;
            string sCopyProject;
            var lCostProjectID = default(long);
            long lAlphaCode;
            int iTaxPermitDistrict;
            bool bGoOn;
            string sPlanType = "";
            string sMsg2 = "";
            var bDontCost = default(bool);
            try
            {
                msProcessLog=msProcessLog+Constants.vbCrLf+"Creating Jobs";
                if ((ucProjectsCosts.Text??"")!=(ucProjectStandard.Text??""))
                {
                    lCostProjectID=Conversions.ToLong(Interaction.IIf(!string.IsNullOrEmpty(ucProjectsCosts.Text), ucProjectsCosts.Value, 0));
                }
                lAlphaCode=Conversions.ToLong(Interaction.IIf(!string.IsNullOrEmpty(ucAlphaCodes.Text), ucAlphaCodes.Value, 0));
                iTaxPermitDistrict=(int)(Interaction.IIf(!string.IsNullOrEmpty(ucDistricts.Text), ucDistricts.Value, 0));
                sPlanProject=ucProjectsPlans.Text;
                sCopyProject=ucProjectStandard.Text;
                sProject=uteProjectID.Text;
                cDB=new DBCalls();
                oCMD=new SqlCommand();
                oCMD2=new SqlCommand();
                bGoOn=true;
                oCMD.CommandType=CommandType.StoredProcedure;
                oCMD.CommandTimeout=600;
                oCMD.Connection=modGlobals.gCN;
                oCMD2.CommandType=CommandType.StoredProcedure;
                oCMD2.CommandTimeout=600;
                oCMD2.Connection=modGlobals.gCN;
                sBlock="000";
                iJob=0;
                foreach (DataRow oRow in modGlobals.gsCostAnalysisData.Tables[0].Rows)
                {
                    sPlanType=Conversions.ToString(oRow["Use"]);
                    if (sPlanType!="Do Not Use"&!string.IsNullOrEmpty(sPlanType))
                    {
                        iJob=iJob+1;
                        sLot=Strings.Right("00"+Strings.Trim(iJob.ToString()), 3);
                        sJobID=sProject+sLot+sBlock;
                        sPlan=Conversions.ToString(oRow["PlanID"]);
                        if (bCreateJob)
                        {
                            msProcessLog=msProcessLog+Constants.vbCrLf+"Creating New Job:  "+sJobID;
                            UltraStatusBar1.Panels["CurrentProcess"].Text="Create Job: "+sJobID+" PlanID: "+sPlan;
                            oCMD2.CommandText="spCreateNewJob";
                            oCMD2.CommandType=CommandType.StoredProcedure;
                            oCMD2.Parameters.Clear();
                            // .Parameters.Refresh()
                            oCMD2.Parameters.AddWithValue("@JobID", sJobID);
                            oCMD2.Parameters.AddWithValue("@ProjectID", sProject);
                            oCMD2.Parameters.AddWithValue("@PlanID", sPlan);
                            oCMD2.Parameters.AddWithValue("@JobName", sJobID+" "+sPlan);
                            oCMD2.Parameters.AddWithValue("@Block", sBlock);
                            oCMD2.Parameters.AddWithValue("@Lot", sLot);
                            oCMD2.Parameters.AddWithValue("@CreatedBy", modGlobals.gsUserID);
                            oCMD2.Parameters.AddWithValue("@Address", "");
                            oCMD2.Parameters.AddWithValue("@City", "");
                            oCMD2.Parameters.AddWithValue("@ST", "");
                            oCMD2.Parameters.AddWithValue("@Zip", "");
                            oCMD2.Parameters.AddWithValue("@LotCostAdjustment", 0);
                            oCMD2.Parameters.AddWithValue("@BuilderID", 0);
                            oCMD2.Parameters.AddWithValue("@Spec", 0);
                            oCMD2.Parameters.AddWithValue("@Garage", 0);
                            oCMD2.Parameters.AddWithValue("@Status", 9);   // standard plan '
                            var parameter = new SqlParameter();
                            parameter.Direction=ParameterDirection.Output;
                            parameter.Size=2000;
                            parameter.SqlDbType=SqlDbType.NVarChar;
                            parameter.ParameterName="@ErrMsg";
                            oCMD2.Parameters.Add(parameter);

                            parameter=new SqlParameter();
                            parameter.Direction=ParameterDirection.Output;
                            parameter.SqlDbType=SqlDbType.Int;
                            parameter.ParameterName="@CID";
                            oCMD2.Parameters.Add(parameter);

                            parameter=new SqlParameter();
                            parameter.Direction=ParameterDirection.Output;
                            parameter.SqlDbType=SqlDbType.Int;
                            parameter.ParameterName="@JobIDInt";
                            oCMD2.Parameters.Add(parameter);

                            parameter=new SqlParameter();
                            parameter.SqlDbType=SqlDbType.Int;
                            parameter.ParameterName="@RC";
                            parameter.Direction=ParameterDirection.ReturnValue;

                            oCMD2.Parameters.Add(parameter);

                            lErr=oCMD2.ExecuteNonQuery();
                            lErr=Conversions.ToLong(oCMD2.Parameters["@RC"].Value);

                            Application.DoEvents();

                            if (lErr>1L)
                            {
                                sMsg=Conversions.ToString(Operators.ConcatenateObject(sMsg+"Problem posting Job records for Job: "+sJobID+Constants.vbCrLf, oCMD2.Parameters["@ErrMsg"].Value));
                                msProcessLog=Conversions.ToString(Operators.ConcatenateObject(msProcessLog+Constants.vbCrLf+"Problem posting Job records for Job: "+sJobID+Constants.vbCrLf, oCMD2.Parameters["@ErrMsg"].Value));
                                // add bDontCost so jobs with permitting cost issues will still import mrb 10/27/15
                                if (lErr==1L)
                                {
                                    sMsg=sMsg+" You must select a permitting option for this job."+Constants.vbCrLf;
                                    msProcessLog=msProcessLog+Constants.vbCrLf+" You must select a permitting option for this job.";
                                    bGoOn=false;
                                    bDontCost=false;
                                }
                                else if (lErr==4L)
                                {
                                    bGoOn=true;
                                    bDontCost=true;
                                }
                                else
                                {
                                    bGoOn=false;
                                    bDontCost=false;
                                }
                            }
                            else
                            {
                                bGoOn=true;
                                bDontCost=false;
                            }
                        }    // }-> If bCreateJob Then
                             // import CAD                                                                      '
                             // EXEC @RC = spImportCAD @JobID, @FileName, @CreatedBy, @FileDate, @ErrMsg OUTPUT '
                        if (bGoOn)
                        {
                            dFileDate=DateTime.Today; // f.DateLastModified
                            if (oRow["FileName"]==null)
                            {
                                sFile="";
                            }
                            else
                            {
                                sFile=Conversions.ToString(oRow["FileName"]);
                            }
                            UltraStatusBar1.Panels["CurrentProcess"].Text="Import CAD for Job: "+sJobID+" PlanID: "+sPlan;
                            oCMD2.CommandText="spImportCAD";
                            oCMD2.Parameters.Clear();
                            oCMD2.Parameters.AddWithValue("@JobID", sJobID);
                            oCMD2.Parameters.AddWithValue("@FileName", sFile);
                            oCMD2.Parameters.AddWithValue("@CreatedBy", modGlobals.gsUserID);
                            oCMD2.Parameters.AddWithValue("@FileDate", dFileDate);

                            var parameter = new SqlParameter();
                            parameter.Direction=ParameterDirection.Output;
                            parameter.Size=2000;
                            parameter.SqlDbType=SqlDbType.NVarChar;
                            parameter.ParameterName="@ErrMsg";
                            oCMD2.Parameters.Add(parameter);

                            parameter=new SqlParameter();
                            parameter.SqlDbType=SqlDbType.Int;
                            parameter.ParameterName="@RC";
                            parameter.Direction=ParameterDirection.ReturnValue;
                            oCMD2.Parameters.Add(parameter);

                            lErr=oCMD2.ExecuteNonQuery();
                            lErr=Conversions.ToLong(oCMD2.Parameters["@RC"].Value);
                            Application.DoEvents();
                            if (lErr!=0L|!(oCMD2.Parameters["@ErrMsg"].Value is DBNull))
                            {
                                // If lErr <> 0 Then '
                                sMsg2=Conversions.ToString(Operators.ConcatenateObject("Problem Importing CAD for Job: "+sJobID+" Plan: "+sPlan+sFile+Constants.vbCrLf, oCMD2.Parameters["@ErrMsg"].Value));
                                sMsg=sMsg+Constants.vbCrLf+sMsg2+Constants.vbCrLf;
                                msProcessLog=msProcessLog+Constants.vbCrLf+sMsg2+Constants.vbCrLf;
                                bGoOn=false;
                                // ugDetails.ActiveRow = ugDetails.Rows(ugDetails.Rows.Count - 1)
                                SqlTransaction arglocalTransaction = null;
                                SaveJob(sJobID, 0L, sMsg2, localTransaction: ref arglocalTransaction);
                            }
                            else
                            {
                                msProcessLog=msProcessLog+Constants.vbCrLf+"CAD Imported for plan: "+sJobID+sFile;
                            }
                            // LoadDetailGrid() 'ugDetails.DataBind()
                        }
                        if (bGoOn&bDontCost==false) // mrb 10/27/15
                        {

                            UltraStatusBar1.Panels["CurrentProcess"].Text="Apply Cost for Job"+sJobID+" PlanID: "+sPlan;
                            msProcessLog=msProcessLog+Constants.vbCrLf+"Applying Cost for Job"+sJobID+" PlanID: "+sPlan;

                            oCMD2.CommandText="spApplyCostToJob";
                            oCMD2.Parameters.Clear();
                            oCMD2.Parameters.AddWithValue("@JobID", sJobID);
                            oCMD2.Parameters.AddWithValue("@CreatedBy", modGlobals.gsUserID);
                            if (iTaxPermitDistrict!=0)
                            {
                                oCMD2.Parameters.AddWithValue("@TaxPermitID", iTaxPermitDistrict);
                            }
                            if (lCostProjectID!=0L)
                            {
                                oCMD2.Parameters.AddWithValue("@ProjectID", lCostProjectID);
                            }
                            SqlParameter parameter;
                            parameter=new SqlParameter();
                            parameter.SqlDbType=SqlDbType.Int;
                            parameter.ParameterName="@RC";
                            parameter.Direction=ParameterDirection.ReturnValue;
                            oCMD2.Parameters.Add(parameter);
                            parameter=new SqlParameter();
                            parameter.SqlDbType=SqlDbType.NVarChar;
                            parameter.ParameterName="@ErrMsg";
                            parameter.Direction=ParameterDirection.ReturnValue;
                            oCMD2.Parameters.Add(parameter);
                            lErr=oCMD2.ExecuteNonQuery();
                            lErr=Conversions.ToLong(oCMD2.Parameters["@RC"].Value);
                            Application.DoEvents();
                            sMsg2=Conversions.ToString(oCMD2.Parameters["@ErrMsg"].Value);  // 10/29/15 mrb
                            if (lErr!=0L|sMsg2!=default) // 10/29/15 mrb
                            {
                                sMsg=sMsg+"Problem Applying Costs to Job: "+sJobID+sPlan+Constants.vbCrLf+sMsg2;
                                msProcessLog=msProcessLog+Constants.vbCrLf+"Problem Applying Costs to Job: "+sJobID+sPlan;
                                // bGoOn = False
                                SqlTransaction arglocalTransaction1 = null;
                                SaveJob(sJobID, 0L, sMsg, localTransaction: ref arglocalTransaction1);
                            }
                            else
                            {
                                sMsg2="Costs applied to Job: "+sJobID+" Plan: "+sPlan;
                                msProcessLog=msProcessLog+Constants.vbCrLf+sMsg2;
                                SqlTransaction arglocalTransaction2 = null;
                                SaveJob(sJobID, 0L, sMsg2, localTransaction: ref arglocalTransaction2);
                            }
                        }
                        else // if bgoon and bDontCost = false mrb 10/27/15
                        {
                            sMsg=sMsg+"Costs NOT applied to this job due to early permitting or site work cost issue: "+sJobID+" Plan: "+sPlan;
                        }
                        bTrans=false;
                        LoadDetailGrid();
                        Application.DoEvents();
                    }
                }     // row in dataset created in choose plans
                if (Strings.Len(sMsg)>0)
                {
                    CreateJobsRet=false;
                }
                else
                {
                    CreateJobsRet=true;
                }

                cDB=null;
                rs=null;
            }

            catch (Exception ex)
            {
                // MsgBox(sMsg & " " & ex.Message, vbCritical, "CreateJobs")
                msProcessLog=msProcessLog+Constants.vbCrLf+sMsg+" Error in Create Jobs: "+ex.Message+" PlanID: "+sPlan+" JobID: "+sJobID;
                CreateJobsRet=false;
            }
            finally
            {
                cDB=null;
                rs=null;
            }

            return CreateJobsRet;
        }

        private void btnSelectPlans_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.CostAnalysisPlanChooser.msPlanProjectID=ucProjectsPlans.Text;
            My.MyProject.Forms.CostAnalysisPlanChooser.ShowDialog();
            ckPlansSelected.Checked=modGlobals.gsCostAnalysisData is not null;
            if (ckPlansSelected.CheckState==CheckState.Checked)
            {
                tsBtnSave.Enabled=true;
            }
        }

        private void ucProjectsPlans_RowSelected(object sender, RowSelectedEventArgs e)
        {
            if (e.Row is not null)
            {
                btnSelectPlans.Enabled=mbAddNew&!string.IsNullOrEmpty(ucProjectsPlans.Text);
            }
        }
        private void GetDataDate()
        {
            DBCalls cDB;
            try
            {
                cDB=new DBCalls();
                var ds = new DataSet();
                DateTime sDate;
                if (cDB.GetRecordsFromSP(ref ds, "spCostAnalysisDateGet"))
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        sDate=Conversions.ToDate(row["UpdateEnded"].ToString());
                        tsLblLastReloadDate.Text="Last Reload Date: "+Conversions.ToString(sDate);
                    }
                }
                ds=null;
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.Message, Constants.vbCritical, "GetDataDate");
            }
            finally
            {
                cDB=null;
            }
        }
        private void tsBtnReloadData_Click(object sender, EventArgs e)
        {
            Enabled=false;
            modCommon.ReloadCostAnalysisData();
            Enabled=true;
            GetDataDate();
        }
        private bool UpdateAnalysis()
        {
            bool UpdateAnalysisRet = default;
            long lCostProjectID;
            long lPlanProjectid;
            long lCopyProjectID;
            long lOptionProjectID;
            long lAlphaCode;
            int iTaxPermitDistrict;
            int iSoftCosts;
            decimal cCostIncrease;
            decimal cNewMargin;
            int iPremium;
            SqlCommand oCmd;
            long lRtn;
            bool bGoOn;
            string sMsg = "";

            try
            {
                lCostProjectID=Conversions.ToLong(ucProjectsCosts.Value);
                lPlanProjectid=Conversions.ToLong(ucProjectsPlans.Value);
                lOptionProjectID=Conversions.ToLong(ucProjectsPlans.Value);
                lCopyProjectID=Conversions.ToLong(ucProjectStandard.Value);
                lAlphaCode=Conversions.ToLong(ucAlphaCodes.Value);
                iTaxPermitDistrict=(int)(ucDistricts.Value);
                iSoftCosts=(int)(uteSoftCosts.Value);
                cCostIncrease=Conversions.ToDecimal(uteCostIncreasePercent.Value);
                cNewMargin=Conversions.ToDecimal(uteNewMargin.Value);
                iPremium=(int)(uteProjectPremium.Value);

                oCmd=new SqlCommand();
                {
                    ref var withBlock = ref oCmd;
                    withBlock.Connection=modGlobals.gCN;
                    withBlock.CommandType=CommandType.StoredProcedure;
                    withBlock.CommandTimeout=300;
                    withBlock.CommandText="spUpdateCostAnalysisNew";
                    var parameter = new SqlParameter();
                    parameter.SqlDbType=SqlDbType.Int;
                    parameter.ParameterName="@AnalysisID";
                    parameter.Direction=ParameterDirection.InputOutput;
                    parameter.Value=miAnalysisID;
                    oCmd.Parameters.Add(parameter);
                    withBlock.Parameters.AddWithValue("@VersionName", uteAnalysisName.Text);
                    withBlock.Parameters.AddWithValue("@CostProjectID", lCostProjectID);
                    withBlock.Parameters.AddWithValue("@CostedDate", DateTime.Today);
                    withBlock.Parameters.AddWithValue("@CreatedBy", modGlobals.gsUserID);
                    withBlock.Parameters.AddWithValue("@ProjectMargin", cNewMargin);
                    withBlock.Parameters.AddWithValue("@Notes", uteNotes.Text);
                    withBlock.Parameters.AddWithValue("@OptionProjectID", lOptionProjectID);
                    withBlock.Parameters.AddWithValue("@PlanProjectID", lPlanProjectid);
                    withBlock.Parameters.AddWithValue("@CostIncreaseAlpha", lAlphaCode);
                    withBlock.Parameters.AddWithValue("@CostIncreasePercent", cCostIncrease);
                    withBlock.Parameters.AddWithValue("@TaxPermitID", iTaxPermitDistrict);
                    withBlock.Parameters.AddWithValue("@CopyProjectID", lCopyProjectID);
                    withBlock.Parameters.AddWithValue("@SoftCosts", iSoftCosts);
                    withBlock.Parameters.AddWithValue("@ProjectName", uteProjectName.Text);
                    withBlock.Parameters.AddWithValue("@ProjectID", uteProjectID.Text);
                    withBlock.Parameters.AddWithValue("@Period", utePeriod.Text);
                    withBlock.Parameters.AddWithValue("@ProjectPremium", iPremium);
                    withBlock.Parameters.AddWithValue("@DoNotUse", chkDoNotUse.CheckState);
                    parameter=new SqlParameter();
                    parameter.SqlDbType=SqlDbType.Int;
                    parameter.ParameterName="@RC";
                    parameter.Direction=ParameterDirection.ReturnValue;
                    oCmd.Parameters.Add(parameter);
                    lRtn=oCmd.ExecuteNonQuery();
                    lRtn=Conversions.ToLong(oCmd.Parameters["@RC"].Value);
                    if (lRtn!=0L)
                    {
                        sMsg="Unable to save changes for Analysis: "+uteProjectName.Text;
                        Interaction.MsgBox(sMsg, MsgBoxStyle.Critical, "UpdateAnalysis");
                        bGoOn=false;
                    }
                    else
                    {
                        miAnalysisID=Conversions.ToLong(oCmd.Parameters["@AnalysisID"].Value);
                        bGoOn=true;
                        Interaction.MsgBox("Changes Saved");
                    }
                }    // )-> With oCMD
                UpdateAnalysisRet=bGoOn;
            }
            catch (Exception ex)
            {
                UpdateAnalysisRet=false;
                Interaction.MsgBox("Error Updating or Creating Analysis record: "+ex.Message, MsgBoxStyle.Critical, "UpdateAnalysis");
            }
            finally
            {
                oCmd=null;

            }

            return UpdateAnalysisRet;
        }


        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            decimal cCost;
            decimal cMargin;
            long lPrice;
            string sVersion;
            long lCurrentPrice;

            try
            {
                cMargin=Math.Round(Conversions.ToDecimal(uteNewMargin.Value), 2, MidpointRounding.AwayFromZero);
                sVersion=uteAnalysisName.Text;
                // ugDetails.DisplayLayout.Bands(0).Columns("NewMargin").CellActivation = Activation.AllowEdit
                ugDetails.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
                foreach (var oRow in ugDetails.Rows)
                {
                    cCost=Conversions.ToDecimal(oRow.Cells["BudgetCost"].Value); // ssdbgPlans
                    lPrice=CalculatePrice(cMargin, cCost);
                    oRow.Cells["AnalysisPrice"].Value=lPrice;
                    oRow.Cells["UpdatedPrice"].Value=lPrice;
                    oRow.Cells["NewMargin"].Activation=Activation.AllowEdit;
                    oRow.Cells["NewMargin"].Value=cMargin;

                    lCurrentPrice=Conversions.ToLong(Interaction.IIf(string.IsNullOrEmpty(oRow.Cells["PlanPrice"].Text), 0, oRow.Cells["PlanPrice"].Text));
                    oRow.Cells["Increase"].Value=lPrice-lCurrentPrice;
                }
                // ugDetails.DisplayLayout.Bands(0).Columns("NewMargin").CellActivation = Activation.NoEdit

                uteAnalysisName.Focus();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Recalculate Grid: "+ex.Message, MsgBoxStyle.Critical, "tsBtnRecalculateGrid_click");
            }

        }

        public long CalculatePrice(decimal cMargin, decimal cCost, decimal cLotCost = 0m)
        {
            long CalculatePriceRet = 0L;//default;
            decimal cTemp;
            object cRound;
            try
            {
                // Round to either xxx400 or xxx900 mb 3/23/04 '

                if (cCost!=0m)
                {
                    // cTemp = (cMargin + 1) * cCost '
                    cTemp=cCost/(1m-cMargin)+cLotCost;
                    cRound=Math.Round(cTemp/1000m, 0)*1000m;
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectGreater(cTemp, cRound, false)))
                    {
                        cTemp=Conversions.ToDecimal(Operators.AddObject(cRound, 400));
                    }
                    else
                    {
                        cTemp=Conversions.ToDecimal(Operators.SubtractObject(cRound, 100));
                    }
                    // If cTemp < 100000 Then                          '
                    // cTemp = (Round(cTemp / 1000, 0) * 1000) - 100   '
                    // Else                                            '
                    // cTemp = (Round(cTemp / 10000, 0) * 10000) - 100 '
                    // End If                                          '
                    // cTemp = cTemp - 100                             '
                    CalculatePriceRet=(long)Math.Round(cTemp);
                }
                else
                {
                    CalculatePriceRet=0L;
                }    // }-> If cCost <> 0 Then
                return CalculatePriceRet;
            }
            catch
            {
                CalculatePriceRet=0L;
                Interaction.MsgBox(Information.Err().Description, Constants.vbCritical, "CalculatePrice");
            }
        }

        private void HelpToolStripButton_Click(object sender, EventArgs e)
        {
            modCommon.ShowPDFHelp(Application.StartupPath+@"\BOSS Cost Analysis.pdf");
        }



        private void chkUseInfoFromStandardProject_CheckedChanged(object sender, EventArgs e)
        {
            if (ucProjectStandard.SelectedRow is not null)
            {
                ChangeProjectDropdowns();
            }
        }
        private bool SaveJob(string sJobID, long lUpdatedPrice, string sNote, [Optional, DefaultParameterValue(null)] ref SqlTransaction localTransaction)
        {
            bool SaveJobRet = default;
            var oCMD = new SqlCommand();
            // Dim lPlanPrice As Long
            long lRtn;
            try
            {
                {
                    ref var withBlock = ref oCMD;
                    withBlock.Connection=modGlobals.gCN;

                    withBlock.CommandType=CommandType.StoredProcedure;
                    withBlock.CommandTimeout=300;
                    withBlock.CommandText="spUpdateJobForCostAnalysis";
                    withBlock.Transaction=localTransaction;
                }
                msProcessLog=msProcessLog+"Begin Update Job for Cost Analysis for Job: "+sJobID;
                SaveJobRet=true;


                UltraStatusBar1.Panels["CurrentProcess"].Text="Saving Job: "+sJobID;
                {
                    ref var withBlock1 = ref oCMD;
                    withBlock1.Parameters.AddWithValue("@UpdatedBy", modGlobals.gsUserID);
                    withBlock1.Parameters.AddWithValue("@AnalysisPrice", lUpdatedPrice);
                    withBlock1.Parameters.AddWithValue("@JobID", sJobID);
                    withBlock1.Parameters.AddWithValue("@Note", sNote);
                    var parameter = new SqlParameter();
                    parameter.SqlDbType=SqlDbType.Int;
                    parameter.ParameterName="@RC";
                    parameter.Direction=ParameterDirection.ReturnValue;
                    oCMD.Parameters.Add(parameter);

                    lRtn=oCMD.ExecuteNonQuery();
                    lRtn=Conversions.ToLong(oCMD.Parameters["@RC"].Value);
                    if (lRtn!=0L)
                    {
                        SaveJobRet=false;
                    }
                    else
                    {
                        SaveJobRet=true;
                    }
                }
            }

            catch (Exception ex)
            {
                Interaction.MsgBox("Error in Save Job: "+ex.Message, MsgBoxStyle.Critical, "SaveJob");
                msProcessLog=msProcessLog+" Error in Save Job: "+ex.Message+" Job: "+sJobID;
                SaveJobRet=false;
            }
            finally
            {
                oCMD=null;
            }

            return SaveJobRet;

        }

        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            var rptViewer = new ReportViewer();
            rptViewer.sReportToRun="Cost Analysis - Review";
            rptViewer.sReportTitle="Cost Analysis - Review for: "+uteProjectID.Text;
            rptViewer.sCriteria=miAnalysisID.ToString();
            rptViewer.Show();
        }

        private void tsBtnPrintRpt2_Click(object sender, EventArgs e)
        {
            var rptViewer = new ReportViewer();
            rptViewer.sReportToRun="Cost Analysis - Sales";
            rptViewer.sReportTitle="Cost Analysis - Sales: "+uteProjectID.Text;
            rptViewer.sCriteria=miAnalysisID.ToString();

            rptViewer.Show();
        }



        private void ugDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right&ugDetails.Selected.Rows.Count>0)
            {
                ugDetails.ContextMenuStrip.Hide();
                var point = new Point(e.X, e.Y);
                var uiElement = ((UltraGridBase)sender).DisplayLayout.UIElement.ElementFromPoint(point);
                UltraGridCell cell = (UltraGridCell)uiElement.GetContext(typeof(UltraGridCell));

                if (cell is not null) // AndAlso UseThisContextMenu(cell) Then
                {
                    ugDetails.ContextMenuStrip.Show();
                }
            }

        }

        private bool UseThisContextMenu(UltraGridRow oRow)
        {
            bool UseThisContextMenuRet = default;
            string sJobID;
            var oForm = new EstimateView();
            try
            {
                sJobID=oRow.Cells["JobID"].Text;
                oForm.msJobID=sJobID;
                oForm.mbLockJobs=true;
                oForm.ShowDialog();
                UseThisContextMenuRet=true;
            }
            catch (Exception ex)
            {
                UseThisContextMenuRet=false;
                Interaction.MsgBox("Error in View Estimate"+ex.Message, MsgBoxStyle.Critical, "UseThisContextMenu");
            }

            return UseThisContextMenuRet;
        }

        private void tsViewEstimate_Click(object sender, EventArgs e)
        {
            if (ugDetails.Selected.Rows.Count>0)
            {
                UseThisContextMenu(ugDetails.Selected.Rows[0]);
            }
        }

        private void tsEstimateCostedRpt_Click(object sender, EventArgs e)
        {
            var rptViewer = new ReportViewer();
            string sJobID;
            if (ugDetails.Selected.Rows.Count>0)
            {
                sJobID=ugDetails.Selected.Rows[0].Cells["JobID"].Text;
                rptViewer.sReportToRun="Job Estimate - Costed";
                rptViewer.sReportTitle="Job Estimate Cossted: "+sJobID;
                rptViewer.sJobID=sJobID;
                rptViewer.Show();
            }
        }

        private void tsSummaryBudgetRpt_Click(object sender, EventArgs e)
        {

            var rptViewer = new ReportViewer();
            string sJobID;
            if (ugDetails.Selected.Rows.Count>0)
            {
                sJobID=ugDetails.Selected.Rows[0].Cells["JobID"].Text;
                rptViewer.sReportToRun="Summary Budget Report";
                rptViewer.sReportTitle="Summary Budget Report: "+sJobID;
                rptViewer.sJobID=sJobID;
                rptViewer.Show();
            }
        }
    }
}