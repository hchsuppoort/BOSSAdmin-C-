using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class UserSelect
    {
        // Public oGrid As New UltraGrid
        public DataSet oGridDS = new DataSet();
        public UltraGridLayout oGridLayout = new UltraGridLayout();
        public string sCaption = "";

        public UserSelect()
        {
            InitializeComponent();
        }
        private void UserSelect_Load(object sender, EventArgs e)
        {
            LoadToGrid();
            LoadFromGrid();

        }
        private bool LoadToGrid()
        {
            bool LoadToGridRet = default;
            // Dim ds As New DataSet
            // Dim ds2 As New DataSet
            // Dim dbCalls As New DBCalls
            try
            {
                Text=sCaption;
                grdTo.DataSource=oGridDS;
                grdTo.DataBind();
                grdTo.Height=200;
                grdTo.Width=375;
                grdTo.DisplayLayout.ActiveRow.Activation=Activation.AllowEdit;
                grdTo.DisplayLayout.Load("userlayout");
                LoadToGridRet=true;
            }
            catch
            {
                modCommon.ShowError("Error loading Selected Users: "+Information.Err().Description, false, "BOSSAdmin", "User: LoadToGrid ");
                LoadToGridRet=false;
            }
            finally
            {
                // dbCalls = Nothing
                // ds.Dispose()
                // ds2.Dispose()
                // ds = Nothing
                // ds2 = Nothing
            }

            return LoadToGridRet;

        }
        private bool ReloadToGrid()
        {
            bool ReloadToGridRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            string sNotifyCriteria = "";
            try
            {

                grdTo.DataSource=null;
                grdTo.ResetDisplayLayout();
                grdTo.Layouts.Clear();
                if (!string.IsNullOrEmpty(sCaption))
                {
                    if (dbCalls.GetRecordsFromSP(ref ds, "spNotifyListGet", sCaption))
                    {
                        grdTo.DataSource=ds;
                        grdTo.DataBind();
                        grdTo.Height=200;
                        grdTo.Width=375;
                        grdTo.DisplayLayout.ActiveRow.Activation=Activation.AllowEdit;
                        grdTo.DisplayLayout.Load("userlayout");
                    } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then                
                } // scaption <> ""
                ReloadToGridRet=true;
            }
            catch
            {
                ReloadToGridRet=false;
                modCommon.ShowError("Error in ReloadGrid: "+Information.Err().Description, false, "BOSSAdmin", "User: ReloadToGrid ");
            }
            finally
            {
                dbCalls=null;
            }

            return ReloadToGridRet;

        }
        private bool LoadFromGrid()
        {
            bool LoadFromGridRet = default;
            var ds2 = new DataSet();
            var cDB = new DBCalls();
            try
            {
                if (cDB.GetRecordsFromSP(ref ds2, "spUsersNotNotifiedGet", sCaption))
                {
                    grdFrom.DataSource=ds2;
                    grdFrom.DataBind();
                    grdFrom.Height=200;
                    grdFrom.Width=375;

                    UltraGridColumn ugc;

                    ugc=grdFrom.DisplayLayout.Bands[0].Columns["siid"];
                    ugc.Hidden=true;
                }
                LoadFromGridRet=true;
            }
            catch
            {
                LoadFromGridRet=false;
                modCommon.ShowError("Error in LoadFromGrid: "+Information.Err().Description, false, "BOSSAdmin", "User: LoadFromGrid ");
            }
            finally
            {
                cDB=null;
            }

            return LoadFromGridRet;
        }
        private void grdTo_AfterRowsDeleted(object sender, EventArgs e)
        {
            // 'delete row from config table
            // Dim oDB As New DBCalls
            // Dim sItemID As String = grdTo.ActiveRow.Cells("ItemID").Text
            // Dim iRtn As Integer
            // Try
            // Cursor = Cursors.WaitCursor
            // iRtn = oDB.GetReturnValueFromSP("spNotifyDelete", sItemID)
            // If iRtn = 0 Then
            // MsgBox("User Notification deleted.", MsgBoxStyle.Information, "Delete Notification")
            // Else
            // MsgBox("Problem deleting notification.  Contact your system administrator.", MsgBoxStyle.Critical, "Delete Notification")
            // End If
            // Catch
            // MsgBox("Error deleting notification: " & Err.Description, MsgBoxStyle.Critical, "Delete Notification")
            // Finally
            // Cursor = Cursors.Default
            // End Try
        }

        private void grdTo_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
        {
            // delete row from config table
            var oDB = new DBCalls();
            string sItemID = grdTo.ActiveRow.Cells["ItemID"].Text;
            int iRtn;
            string sUser = grdTo.ActiveRow.Cells["fname"].Text;
            e.DisplayPromptMsg=false;

            try
            {
                if (Interaction.MsgBox("Do you want to delete the notification for "+sCaption+" to: "+sUser+"?", Constants.vbYesNo, "Delete Notification")==MsgBoxResult.Yes)
                {

                    Cursor=Cursors.WaitCursor;
                    iRtn=(int)oDB.GetReturnValueFromSP("spNotifyDelete", sItemID);
                    if (iRtn==0)
                    {
                        Interaction.MsgBox("User Notification deleted.", MsgBoxStyle.Information, "Delete Notification");
                    }
                    else
                    {
                        Interaction.MsgBox("Problem deleting notification.  Contact your system administrator.", MsgBoxStyle.Critical, "Delete Notification");
                    }
                }
                else
                {
                    e.Cancel=true;
                }
            }
            catch
            {
                modCommon.ShowError("Error deleting notification: "+Information.Err().Description, false, "BOSSAdmin", "User: Delete Notification` ");
            }
            finally
            {
                LoadFromGrid();
                Cursor=Cursors.Default;
            }
        }


        private void btnAddusers_Click(object sender, EventArgs e)
        {
            var cDB = new DBCalls();
            long lSIID = 0L;
            long lRtn = 0L;
            // create procedure spNotifyInsert 
            // @Item varchar(50), 
            // @ItemValue varchar(50), 
            // @ItemValue2 varchar(50)
            try
            {
                foreach (UltraGridRow row in grdFrom.Selected.Rows)
                {
                    lSIID=Conversions.ToLong(row.Cells["SIID"].Value);
                    lRtn=(long)cDB.GetReturnValueFromSP("spNotifyInsert", "notification", sCaption, lSIID);
                    // row.Delete()
                }
            }
            catch
            {
                modCommon.ShowError("Error saving new users for notification: "+Information.Err().Description, false, "BOSSAdmin", "User: btnAddUsers_Click ");
            }
            finally
            {
                cDB=null;
                ReloadToGrid();

                LoadFromGrid();

            }
        }
    }
}