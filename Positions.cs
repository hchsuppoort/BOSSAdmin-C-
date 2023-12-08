using System;
using System.Data;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public partial class Positions
    {
        public Positions()
        {
            InitializeComponent();
        }
        private bool LoadGrid()
        {
            bool LoadGridRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            try
            {
                grdPositions.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spPositionsListGet"))
                {
                    grdPositions.DataSource=ds;
                    grdPositions.DataBind();
                    var layout = grdPositions.DisplayLayout;
                    var bands = layout.Bands;
                    // Get the first band, which is the  top-most band in case you had multple bands.
                    var band = bands[0];
                    // Columns property off UltraGridBand returns the collection of columns associated with the band.
                    var oColumns = band.Columns;

                    // create column to track changes
                    // Dim ugc As UltraGridColumn

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("MilestoneID")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("RelatedMilestoneID")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("RelatedMilestone")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActivityCode")
                    // ugc.Header.Caption = "Activity"
                    // ugc.Header.ToolTipText = "This milestone is created when the activity is paid"
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("GroupID")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Group")
                    // ugc.Width = 100

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("UserAdded")
                    // ugc.Header.Caption = "User" & vbCrLf & "Added"
                    // ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                    // ugc.Header.ToolTipText = "If User Can Add is True, the milestone is available in the Job Maintenance screen for adding.  Otherwise, it is system added."
                    // ugc.Width = iColCheck

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("OrderBy")
                    // ugc.Header.Caption = "Order" & vbCrLf & "By"
                    // ugc.Header.ToolTipText = "This determines the display order within the group."
                    // ugc.Width = iColCheck

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Notify")
                    // ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                    // ugc.Header.ToolTipText = "This determines if anyone is notified when the milestone is completed."
                    // ugc.Width = iColCheck

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActivityCodePaid")
                    // ugc.Header.Caption = "Activity Code" & vbCrLf & "Paid"
                    // 'add tool tips
                    // ugc.Header.ToolTipText = "This milestone is created when the activity listed is paid"
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("NotifyCriteria")
                    // ugc.Header.Caption = "Notify" & vbCrLf & "Criteria"
                    // ugc.Header.ToolTipText = "This indicates the group that is notified by this milestone."
                    // ugc.CellActivation = Activation.NoEdit
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Action")
                    // ugc.Header.ToolTipText = "This is used by PO Payment module to determine an action to be taken."
                    // ugc.CellActivation = Activation.NoEdit
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Message")
                    // ugc.Width = 200

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Description")
                    // ugc.Width = 230

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Other Milestone")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActivityPaid")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("ActionDescription")
                    // ugc.Hidden = True

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Note")
                    // ugc.Hidden = True

                    // ugc = oColumns("CanCancel")
                    // ugc.Header.Caption = "Can" & vbCrLf & "Cancel"
                    // ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                    // ugc.Width = iColCheck
                    // ugc.Header.ToolTipText = "Users can Cancel this milestone."

                    // ugc = oColumns("CanDelete")
                    // ugc.Header.Caption = "Can" & vbCrLf & "Delete"
                    // ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                    // ugc.Width = iColCheck
                    // ugc.Header.ToolTipText = "Users can Delete this milestone."

                    // ugc = oColumns("BuilderCanCancel")
                    // ugc.Header.Caption = "Bldr Can" & vbCrLf & "Cancel"
                    // ugc.Style = UltraWinGrid.ColumnStyle.CheckBox
                    // ugc.Width = iColCheck
                    // ugc.Header.ToolTipText = "Builders can Cancel this milestone from eBOSS."

                    // grdPositions.DisplayLayout.Bands(0).Columns.Add("Changed", "Changed")
                    // grdPositions.DisplayLayout.Bands(0).Columns("Changed").DataType = GetType(Boolean)

                    // ugc = grdPositions.DisplayLayout.Bands(0).Columns("Changed")
                    // ugc.Header.Caption = "Chg"
                    // ugc.Style = Win.UltraWinGrid.ColumnStyle.CheckBox
                    // ugc.Width = iColCheck
                    // ugc.Header.ToolTipText = "This is checked if you have changed this milestone."
                    // band.ColHeaderLines = 2
                    // band.GroupHeaderLines = 2
                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                grdPositions.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                if (grdPositions.Rows.Count>0)
                {
                    if (grdPositions.ActiveRow is not null) // 9/16/16 mrb
                    {
                        grdPositions.ActiveRow.Selected=true;
                    }
                }


                LoadGridRet=true;
            }
            catch
            {
                Interaction.MsgBox("Error in VPOReasons LoadGrid: "+Information.Err().Description, Constants.vbCritical);
                LoadGridRet=false;
            }

            return LoadGridRet;
        }

        private void Positions_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadUserGrid();
            LoadSecurityGrid();
        }
        private bool LoadUserGrid()
        {
            bool LoadUserGridRet = default;
            var ds2 = new DataSet();
            var cDB = new DBCalls();
            int iPositionID;
            iPositionID=(int)(grdPositions.ActiveRow.Cells["PositionID"].Value);
            try
            {
                if (cDB.GetRecordsFromSP(ref ds2, "spUsersByPositionGet", iPositionID))
                {
                    grdUsers.DataSource=ds2;
                    grdUsers.DataBind();
                    grdUsers.Height=200;
                    grdUsers.Width=375;
                }

                grdUsers.DisplayLayout.Bands[0].Columns["Type"].Hidden=true; // 9/20/16 mrb
                LoadUserGridRet=true;
            }
            catch
            {
                LoadUserGridRet=false;
            }
            finally
            {
                cDB=null;

            }

            return LoadUserGridRet;
        }
        private bool LoadSecurityGrid()
        {
            bool LoadSecurityGridRet = default;
            var ds2 = new DataSet();
            var cDB = new DBCalls();
            int iPositionID;
            iPositionID=(int)(grdPositions.ActiveRow.Cells["PositionID"].Value);
            try
            {
                if (cDB.GetRecordsFromSP(ref ds2, "spSecurityByPositionIDGet", iPositionID))
                {
                    grdSecurity.DataSource=ds2;
                    grdSecurity.DataBind();
                    grdSecurity.Height=200;
                    grdSecurity.Width=375;

                    // Dim ugc As UltraGridColumn

                    // ugc = grdSecurity.DisplayLayout.Bands(0).Columns("siid")
                    // ugc.Hidden = True
                }
                LoadSecurityGridRet=true;
            }
            catch
            {
                LoadSecurityGridRet=false;
            }
            finally
            {
                // 9/16/16 mrb    
                if (cDB is not null)
                {
                    cDB=null;
                }
                if (ds2 is not null)
                {
                    ds2=null;
                }
            }

            return LoadSecurityGridRet;
        }
        private void grdpositions_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            LoadUserGrid();
            LoadSecurityGrid();
        }

    }
}