using System;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Threading;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class Login
    {

        private string msMsg;
        private object mvRole;

        public Login()
        {
            InitializeComponent();
        }
        private void cmdOk_Click(object sender, EventArgs e)
        {

            DataSet ds;
            DBCalls cDB;

            var bNoEnvironment = default(bool);
            try
            {
                Cursor=Cursors.WaitCursor;
                modCommon.SetGlobals();

                if (GetBossAdminUpdate())
                {
                    // gsUserID = Trim(txtUserID.Text)
                    switch (cmbEnvironment.Text??"")
                    {
                        case "Cost Analysis":
                            {
                                modGlobals.gsDatabase="HCHDataQA";
                                break;
                            }
                        case "Test":
                            {
                                modGlobals.gsDatabase="HCHDataTest";
                                break;
                            }
                        case "Live":
                            {
                                modGlobals.gsDatabase="HCHData";
                                break;
                            }
                    }    // switch (cmbEnvironment.Text??"")

                    modGlobals.gsUserID=Strings.Trim(txtUserID.Text);

                    if (Conversions.ToBoolean(modCommon.ConnectDB()))
                    {
                        modGlobals.gCN=modGlobals.gCNBoss; // why are we doing this? mrb 12/3/14 we set it back at the end of this procedure
                        cDB=new DBCalls();
                        ds=new DataSet();
                        bool localGetRecordsFromSP() { DataSet argds = (DataSet)ds; var ret = cDB.GetRecordsFromSP(ref argds, "spGetUserInfo", modGlobals.gsUserID, txtPassword.Text); ds=argds; return ret; }

                        if (localGetRecordsFromSP())
                        {
                            DataRow oRow;
                            DataTable table;
                            table= ds.Tables[0];
                            oRow   = table.Rows[0];

                            modGlobals.giRank=(int)oRow["Rank"]; //(int)(oRow["Rank"]);
                            modGlobals.gsUserID=Strings.Trim(txtUserID.Text);
                            if (oRow["eMail"]==null)
                            {
                                modGlobals.gsUserEmail="";
                            }
                            else
                            {
                                modGlobals.gsUserEmail=(string)oRow["eMail"];
                            }
                            modGlobals.giSecurityID=(int)oRow["SIId"];
                            modGlobals.giPositionID=(int)oRow["PositionID"];
                            modCommon.gsUserName=(string)oRow["FName"]+" "+ oRow["LName"];
                            modGlobals.gbValidUser=true;
                            switch (cmbEnvironment.Text??"")
                            {
                                case "Cost Analysis":
                                    {
                                        if ((int)oRow["qa"]==1)
                                        {
                                            modGlobals.gsDatabase="HCHDataQA";
                                        }

                                        break;
                                    }
                                case "Test":
                                    {
                                        if ((int)oRow["test"]==1)
                                        {
                                            modGlobals.gsDatabase="HCHDataTest";
                                        }

                                        break;
                                    }
                                case "Live":
                                    {
                                        if ((int)oRow["live"]==1)
                                            modGlobals.gsDatabase="HCHData";
                                    }

                                    break;
                            }
                        }    // if (localGetRecordsFromSP())

                        bNoEnvironment=string.IsNullOrEmpty(modGlobals.gsDatabase);
                    }
                    else
                    {
                        modGlobals.gbValidUser=false;
                    }    // if (Conversions.ToBoolean(modCommon.ConnectDB()))

                    if (bNoEnvironment==true|modGlobals.gbValidUser==false)
                    {
                        if (bNoEnvironment==true)
                        {
                            msMsg="You do not have permission for this environment!";
                            modGlobals.gbValidUser=false;
                        }
                        else if (modGlobals.gbValidUser==false)
                        {
                            msMsg="Invalid User Name or Password.";
                        }
                        else
                        {
                            modGlobals.gbValidUser=true;
                        }    // }-> If bNoEnvironment = True Then
                        Interaction.MsgBox(msMsg, Constants.vbCritical, "Permission Denied");
                        cmbEnvironment.Focus();
                        Cursor=Cursors.WaitCursor;
                    }
                    else //if (Conversions.ToBoolean(modCommon.ConnectDB()))
                    {
                        cDB=new DBCalls();
                        ds=new DataSet();
                        if (string.IsNullOrEmpty(modGlobals.gsUserEmail))
                        {
                            DataSet argds = (DataSet)ds;
                            bool localGetRecordsFromSP() { DataSet argds = (DataSet)ds; var ret = cDB.GetRecordsFromSP(ref argds, "spGetConfig", "DEFAULTEMAIL"); ds=argds; return ret; }
                            if (localGetRecordsFromSP())
                            {
                                DataRow oRow;
                                DataTable table;
                                table= ds.Tables[0];
                                oRow   = table.Rows[0];
                                //ds=cDB.GetRecordsFromSP(ref argds, "spGetConfig", "DEFAULTEMAIL");
                                //    ds=argds;
                                modGlobals.gsUserEmail=(string)(oRow["ItemValue"]);
                            }
                            ds=new DataSet();
                            bool localGetRecordsFromSP1() { DataSet argds1 = (DataSet)ds; var ret = cDB.GetRecordsFromSP(ref argds1, "spGetSecurityByPositionID", modGlobals.giPositionID); ds=argds1; return ret; }

                            if (localGetRecordsFromSP1())
                            {
                                // SELECT m.EditRank, m.ViewRank, m.ObjectName, m.ObjectType '

                                DataTable table;
                                table= ds.Tables[0];

                                SecurityMatrix oMatrix;
                                foreach (DataRow oRow in table.Rows)
                                {
                                    oMatrix=new SecurityMatrix();
                                    oMatrix.EditRank=(int)(oRow["editrank"]);
                                    oMatrix.ViewRank=(int)(oRow["viewrank"]);
                                    oMatrix.ObjectName=(string)(oRow["objectname"]);
                                    oMatrix.ObjectType=(string)(oRow["objecttype"]);
                                    modGlobals.gSecurityList.Add(oMatrix);
                                }
                                modCommon.ConnectDB();
                                Cursor=Cursors.Default;

                            }//if (localGetRecordsFromSP1())
                        } //if (string.IsNullOrEmpty(modGlobals.gsUserEmail))
                    }
                    //else
                    {
                        Interaction.MsgBox("Unable to connect to the database", MsgBoxStyle.Critical, "Login cmdOk_click");
                    } //if (Conversions.ToBoolean(modCommon.ConnectDB()))
                } //if (GetBossAdminUpdate())
            }  //try
            catch
            {
                switch (Information.Err().Number)
                {
                    case -2147467238:
                    case 462:
                    case 13:
                        {
                            msMsg="Cannot connect to the Estimator Database.  Contact you System Administrator.";
                            Interaction.MsgBox(msMsg, Constants.vbCritical, "Data Connect Error");
                            break;
                        }
                    case 3021:
                        {
                            msMsg="Invalid login attempt.  Please re-enter your User ID and Password.";
                            Interaction.MsgBox(msMsg, Constants.vbExclamation, "Invalid Login");
                            txtUserID.Text=Constants.vbNullString;
                            txtPassword.Text=Constants.vbNullString;
                            txtUserID.Focus();
                            break;
                        }
                    case 70:
                        {
                            msMsg="Cannot establish a database connection.  Please contact your IT Manager for assistance.";
                            Interaction.MsgBox(msMsg, Constants.vbCritical, "Database Connection Error");
                            break;
                        }

                    default:
                        {
                            Interaction.MsgBox("The following error occurred in Form UserLogin, cmdOK_Click: "+Information.Err().Description+" "+Information.Err().Number);
                            break;
                        }
                }    // }-> Select Case Err.Number
                modGlobals.gbValidUser=false;
            }
            finally
            {
                //ds=null;
                //cDB=null;
                Cursor=Cursors.Default;
                if (modGlobals.gbValidUser==true)
                {
                    DialogResult=DialogResult.OK;
                    Close();
                }
            }
        }

        //private void txtPassword_TextChanged(object sender, EventArgs e)
        //{

        //}
        private bool GetBossAdminUpdate()
        {
            bool GetBossAdminUpdateRet ;
            string strLocalEXE;
            string strMasterEXE;
            //string strLocalCfg;
            //string strMasterCfg;
            string strMasterExeDate;
            string strLocalExeDate;
            string strLocalCfgDate;
            string strMasterCfgDate;

            // 'added 9/8/23 
            GetBossAdminUpdateRet=false;
            try
            {
                if (!string.IsNullOrEmpty(modGlobals.gsUpdateFolder))
                {
                    strMasterEXE=modGlobals.gsUpdateFolder+@"\BOSSAdminUpdate.exe";
                    strLocalEXE=My.MyProject.Application.Info.DirectoryPath+@"\BOSSAdminUpdate.exe";
                    strMasterExeDate=Conversions.ToString(FileSystem.FileDateTime(strMasterEXE)); // Format(FileDateTime(strMasterEXE), "YYYYMMDDHHMMSS")
                    strLocalExeDate=Conversions.ToString(FileSystem.FileDateTime(strLocalEXE)); // Format(FileDateTime(My.Application.Info.DirectoryPath & "\BOSSAdminUpdate.exe"), "YYYYMMDDHHMMSS")

                    strMasterCfgDate=Strings.Format(FileSystem.FileDateTime(modGlobals.gsUpdateFolder+@"\BOSSAdminUpdate.exe.config"), "YYYYMMDDHHMMSS");
                    strLocalCfgDate=Strings.Format(FileSystem.FileDateTime(My.MyProject.Application.Info.DirectoryPath+@"\BOSSAdminUpdate.exe.config"), "YYYYMMDDHHMMSS");
                    if (Operators.CompareString(strMasterCfgDate, strLocalCfgDate, false)>0)
                    {
                        FileSystem.FileCopy(modGlobals.gsUpdateFolder+@"\BOSSAdminUpdate.exe.config", My.MyProject.Application.Info.DirectoryPath+@"\BOSSAdminUpdate.exe.config");
                    }
                    if (Operators.CompareString(strMasterExeDate, strLocalExeDate, false)>0)
                    {
                        FileSystem.FileCopy(modGlobals.gsUpdateFolder+@"\BOSSAdminUpdate.exe", My.MyProject.Application.Info.DirectoryPath+@"\BOSSAdminUpdate.exe");
                    }
                    // Else
                    // If Err.Description <> "" Then
                    // MsgBox("The following error occurred in Form UserLogin, GetBOSSAdminUpdate: " & Err.Description & " " & Err.Number)
                    // Else
                    // MsgBox("The following error occurred in Form UserLogin, GetBOSSAdminUpdate: " & "Unable to Get BOSSAdminUpdateFolder")
                    // End If
                    GetBossAdminUpdateRet=true;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("The following error occurred in Form UserLogin, GetBOSSAdminUpdate: "+ex.Message);
                GetBossAdminUpdateRet=false;
            }

            return GetBossAdminUpdateRet;
        }
    }
}