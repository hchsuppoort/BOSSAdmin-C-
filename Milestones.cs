using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public partial class Milestones
    {
        private int iColCheck = 60;
        private UltraDropDown ddNotifyCriteria = new UltraDropDown();
        private UltraDropDown ddGroup = new UltraDropDown();

        public Milestones()
        {
            InitializeComponent();
        }

        private void Milestones_Enter(object sender, EventArgs e)
        {

            LoadGrid();
            LoadNotifyList();
            // LoadCriteriaList()??

        }
        private void LoadCriteriaList()
        {
            var cDB = new DBCalls();
            var dsCriteria = new DataSet();
            try
            {
                if (grdMilestones.Rows.Count>0)
                {
                    if (cDB.GetRecordsFromSP(ref dsCriteria, "spNotifyCriteriaGet"))
                    {
                        // create dropdown for Owner
                        ddNotifyCriteria.SetDataBinding(dsCriteria, null);
                        ddNotifyCriteria.ValueMember="NotifyCriteria";
                        ddNotifyCriteria.DisplayMember="NotifyCriteria";
                        grdMilestones.DisplayLayout.Bands[0].Columns["NotifyCriteria"].ValueList=ddNotifyCriteria;
                    }
                }
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: LoadCriteriaList ");
            }
            finally
            {
                cDB=null;
            }

        }
        private void LoadGroupList()
        {
            // 9/21/12 mrb
            var cDB = new DBCalls();
            var dsGroup = new DataSet();
            try
            {
                if (grdMilestones.Rows.Count>0)
                {
                    if (cDB.GetRecordsFromSP(ref dsGroup, "spMilestoneGroupGet"))
                    {
                        // create dropdown for Owner
                        ddGroup.SetDataBinding(dsGroup, null);
                        ddGroup.ValueMember="GroupID";
                        ddGroup.DisplayMember="Group";
                        grdMilestones.DisplayLayout.Bands[0].Columns["GroupID"].ValueList=ddGroup;
                        UltraGridColumn ugc;

                        ugc=ddGroup.DisplayLayout.Bands[0].Columns["Groupid"];
                        ugc.Hidden=true;
                    }
                }
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: LoadGroupList ");
            }
            finally
            {
                cDB=null;
            }

        }
        private void Milestones_Load(object sender, EventArgs e)
        {
            try // mrb 10/28/16 
            {
                modCommon.EnableDisableToolStrip(false, tsToolStrip, grdMilestones, "Milestones", "Menu");
                if (LoadGrid())
                {
                    // FormatTemplate()
                    LoadCriteriaList();
                    LoadGroupList();
                    LoadDetail();
                }
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "Milestones: Milestones_Load ");
            }
        }
        private bool FormatTemplate()
        {
            bool FormatTemplateRet = default;
            try
            {
                retMilestones.Controls.Clear();

                var ulblDescription = new Label();
                ulblDescription.Text="Description";
                ulblDescription.Width=100;
                ulblDescription.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblDescription);

                var ulblUserAdded = new Label();
                ulblUserAdded.Text="User Added";
                ulblUserAdded.Width=100;
                ulblUserAdded.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblUserAdded);

                var ulblMessage = new Label();
                ulblMessage.Text="eMail Message";
                ulblMessage.Width=100;
                ulblMessage.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblMessage);

                var ulblSubject = new Label();
                ulblSubject.Text="eMail Subject";
                ulblSubject.Width=100;
                ulblSubject.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblSubject);
                var ulblSubjectHint = new Label();
                ulblSubjectHint.Text="The description is used if there is no subject for eMail.";
                ulblSubjectHint.Width=200;
                ulblSubjectHint.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblSubjectHint);
                var ulblGroup = new Label();
                ulblGroup.Text="Group";
                ulblGroup.Width=100;
                ulblGroup.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblGroup);

                var ulblOrderBy = new Label();
                ulblOrderBy.Text="Order By";
                ulblOrderBy.Width=100;
                ulblOrderBy.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblOrderBy);


                var ulblNotify = new Label();
                ulblNotify.Text="Notify";
                ulblNotify.Width=100;
                ulblNotify.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblNotify);

                var ulblNotifyCriteria = new Label();
                ulblNotifyCriteria.Text="Notify Criteria";
                ulblNotifyCriteria.Width=100;
                ulblNotifyCriteria.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblNotifyCriteria);

                var ulblBuilderCanCancel = new Label();
                ulblBuilderCanCancel.Text="Builder Can Cancel";
                ulblBuilderCanCancel.Width=100;
                ulblBuilderCanCancel.TextAlign=ContentAlignment.MiddleRight;
                retMilestones.Controls.Add(ulblBuilderCanCancel);

                ugbLayoutMgr.SetGridBagConstraint(ulblDescription, new GridBagConstraint(0, 0, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblUserAdded, new GridBagConstraint(0, 1, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblMessage, new GridBagConstraint(0, 2, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblSubject, new GridBagConstraint(0, 3, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblSubjectHint, new GridBagConstraint(2, 3, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblNotify, new GridBagConstraint(0, 4, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblNotifyCriteria, new GridBagConstraint(0, 5, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblBuilderCanCancel, new GridBagConstraint(0, 6, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblGroup, new GridBagConstraint(0, 7, 1, 1));
                ugbLayoutMgr.SetGridBagConstraint(ulblOrderBy, new GridBagConstraint(0, 8, 1, 1));
                // Instatiate a new UltraButton object.
                // Dim accept As Infragistics.Win.Misc.UltraButton = New Infragistics.Win.Misc.UltraButton()
                // Set the button's text.
                var accept = new UltraButton();
                accept.Text="OK";
                // Add the button to the template's Controls collection.
                retMilestones.Controls.Add(accept);
                // Create a handler for the accept button.
                accept.Click+=accept_Click;
                ugbLayoutMgr.SetGridBagConstraint(accept, new GridBagConstraint(1, 9, 1, 1));


                // Instatiate a new UltraButton object.
                var cancel = new UltraButton();
                // Set the button's text.
                cancel.Text="Cancel";
                // Add the button to the template's Controls collection.
                retMilestones.Controls.Add(cancel);
                // Create a handler for the cancel button.
                cancel.Click+=cancel_Click;
                // Place the button in row 3, column 2 of the grid bag's layout.
                ugbLayoutMgr.SetGridBagConstraint(cancel, new GridBagConstraint(2, 9, 1, 1));
                // Instantiate a new UltraGridCellProxy object.


                var proxy1 = new UltraGridCellProxy();
                // Set the proxy to show data from the ContactName column.
                proxy1.ColumnKey="Description";
                proxy1.Size=new Size(300, 20);
                proxy1.Appearance.TextHAlign=HAlign.Left;
                proxy1.UseAppStyling=true;
                proxy1.UseGridAppearances=true;

                // 9/15/12 mrb 
                retMilestones.Enabled=true;
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy1);
                // Place the proxy in row 1, column 2 of the grid bag layout.
                ugbLayoutMgr.SetGridBagConstraint(proxy1, new GridBagConstraint(1, 0, 1, 1));


                var proxy2 = new UltraGridCellProxy();
                proxy2.ColumnKey="UserAdded";
                proxy2.Size=new Size(20, 20);
                proxy2.Appearance.TextHAlign=HAlign.Left;
                proxy2.UseAppStyling=true;
                proxy2.UseGridAppearances=true;
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy2);
                ugbLayoutMgr.SetGridBagConstraint(proxy2, new GridBagConstraint(1, 1, 1, 1));

                var proxy3 = new UltraGridCellProxy();
                proxy3.ColumnKey="Message";
                proxy3.Size=new Size(300, 20);
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy3);
                ugbLayoutMgr.SetGridBagConstraint(proxy3, new GridBagConstraint(1, 2, 1, 1));

                var proxy4 = new UltraGridCellProxy();
                proxy4.ColumnKey="Notify";
                proxy4.Size=new Size(20, 20);
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy4);
                ugbLayoutMgr.SetGridBagConstraint(proxy4, new GridBagConstraint(1, 4, 1, 1));

                var proxy5 = new UltraGridCellProxy();
                proxy5.ColumnKey="NotifyCriteria";
                proxy5.Size=new Size(100, 30);
                retMilestones.Controls.Add(proxy5);

                ugbLayoutMgr.SetGridBagConstraint(proxy5, new GridBagConstraint(1, 5, 1, 1));
                var proxy6 = new UltraGridCellProxy();
                proxy6.ColumnKey="BuilderCanCancel";
                proxy6.Size=new Size(20, 20);


                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy6);
                ugbLayoutMgr.SetGridBagConstraint(proxy6, new GridBagConstraint(1, 6, 1, 1));

                var proxy7 = new UltraGridCellProxy();
                proxy7.ColumnKey="Subject";
                proxy7.Size=new Size(300, 20);
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy7);
                ugbLayoutMgr.SetGridBagConstraint(proxy7, new GridBagConstraint(1, 3, 1, 1));

                var proxy8 = new UltraGridCellProxy();
                proxy8.ColumnKey="GroupID";
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(proxy8);
                ugbLayoutMgr.SetGridBagConstraint(proxy8, new GridBagConstraint(1, 7, 1, 1));


                var Proxy9 = new UltraGridCellProxy();
                Proxy9.ColumnKey="OrderBy";
                // Add the proxy to the template's Controls collection.
                retMilestones.Controls.Add(Proxy9);
                ugbLayoutMgr.SetGridBagConstraint(Proxy9, new GridBagConstraint(1, 8, 1, 1));
                retMilestones.AutoSizeMode=AutoSizeMode.GrowAndShrink;
                retMilestones.AutoSize=true;

                FormatTemplateRet=true;
            }
            catch
            {
                FormatTemplateRet=false;
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: FormatTemplate ");
            }

            return FormatTemplateRet;
        }
        private bool LoadGrid()
        {
            bool LoadGridRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsCriteria = new DataSet();
            try
            {
                grdMilestones.DataSource=null;

                if (dbCalls.GetRecordsFromSP(ref ds, "spMilestoneListGet"))
                {
                    grdMilestones.DataSource=ds;
                    grdMilestones.DataBind();

                    var layout = grdMilestones.DisplayLayout;
                    var bands = layout.Bands;
                    // Get the first band, which is the  top-most band in case you had multple bands.
                    var band = bands[0];
                    // Columns property off UltraGridBand returns the collection of columns associated with the band.
                    var oColumns = band.Columns;
                    grdMilestones.DisplayLayout.Bands[0].Columns["NotifyCriteria"].ValueList=ddNotifyCriteria;
                    // 9/21/12 mrb
                    band.Columns["GroupID"].ValueList=ddGroup;
                    // create column to track changes
                    UltraGridColumn ugc;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["MilestoneID"];
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["RelatedMilestoneID"];
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["RelatedMilestone"];
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["ActivityCode"];
                    ugc.Header.Caption="Activity";
                    ugc.Header.ToolTipText="This milestone is created when the activity is paid";
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["GroupID"];
                    // ugc.Hidden = True
                    ugc.Width=100;
                    ugc.Header.Caption="Group";
                    ugc.CellActivation=Activation.NoEdit;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Group"];
                    ugc.Width=100;
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["UserAdded"];
                    ugc.Header.Caption="User"+Constants.vbCrLf+"Added";
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                    ugc.Header.ToolTipText="If User Can Add is True, the milestone is available in the Job Maintenance screen for adding.  Otherwise, it is system added.";
                    ugc.Width=iColCheck;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["OrderBy"];
                    ugc.Header.Caption="Order"+Constants.vbCrLf+"By";
                    ugc.Header.ToolTipText="This determines the display order within the group.";
                    ugc.Width=iColCheck;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Notify"];
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                    ugc.Header.ToolTipText="This determines if anyone is notified when the milestone is completed.";
                    ugc.Width=iColCheck;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["ActivityCodePaid"];
                    ugc.Header.Caption="Activity Code"+Constants.vbCrLf+"Paid";
                    // add tool tips
                    ugc.Header.ToolTipText="This milestone is created when the activity listed is paid";
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["NotifyCriteria"];
                    ugc.Header.Caption="Notify"+Constants.vbCrLf+"Criteria";
                    ugc.Header.ToolTipText="This indicates the group that is notified by this milestone.";
                    ugc.CellActivation=Activation.NoEdit;
                    ugc.Width=80;
                    ugc.Hidden=false;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Action"];
                    ugc.Header.ToolTipText="This is used by PO Payment module to determine an action to be taken.";
                    ugc.CellActivation=Activation.NoEdit;
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Subject"];
                    ugc.Header.Caption="eMail Subject";
                    ugc.MaxLength=50;
                    ugc.Width=70;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Message"];
                    ugc.Header.Caption="eMail Message";
                    ugc.MaxLength=250;
                    ugc.Width=200;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Description"];
                    ugc.MaxLength=100;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Description"];
                    ugc.Width=230;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Other Milestone"];
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["ActivityPaid"];
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["ActionDescription"];
                    ugc.Hidden=true;

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Note"];
                    ugc.Hidden=true;

                    ugc=oColumns["CanCancel"];
                    ugc.Header.Caption="Can"+Constants.vbCrLf+"Cancel";
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                    ugc.Width=iColCheck;
                    ugc.Header.ToolTipText="Users can Cancel this milestone.";

                    ugc=oColumns["CanDelete"];
                    ugc.Header.Caption="Can"+Constants.vbCrLf+"Delete";
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                    ugc.Width=iColCheck;
                    ugc.Header.ToolTipText="Users can Delete this milestone.";

                    ugc=oColumns["BuilderCanCancel"];
                    ugc.Header.Caption="Bldr Can"+Constants.vbCrLf+"Cancel";
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                    ugc.Width=iColCheck;
                    ugc.Header.ToolTipText="Builders can Cancel this milestone from eBOSS.";

                    grdMilestones.DisplayLayout.Bands[0].Columns.Add("Changed", "Changed");
                    grdMilestones.DisplayLayout.Bands[0].Columns["Changed"].DataType=typeof(bool);

                    ugc=grdMilestones.DisplayLayout.Bands[0].Columns["Changed"];
                    ugc.Header.Caption="Chg";
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;
                    ugc.Width=iColCheck;
                    ugc.Header.ToolTipText="This is checked if you have changed this milestone.";
                    band.ColHeaderLines=2;
                    band.GroupHeaderLines=2;
                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                grdMilestones.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                if (grdMilestones.Rows.Count>0)
                {
                    if (grdMilestones.ActiveRow is not null) // 10/28/16 add check for activerow
                    {
                        grdMilestones.ActiveRow.Selected=true;
                    }
                    else
                    {
                        grdMilestones.ActiveRow=grdMilestones.Rows[0]; // 10/28/16 mrb
                        LoadPositionToNotifyList();
                        LoadNotifyList();

                    }
                }
                // mrb 9/3/12 take out for now
                // 9/15/12 move to edit mode
                // grdMilestones.DisplayLayout.Bands(0).RowEditTemplate = retMilestones
                LoadGridRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: LoadGrid ");
                LoadGridRet=false;
            }

            return LoadGridRet;
        }

        private void grdMilestones_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            // If grdMilestones.ActiveRow.Cells("Notify").Text = DefaultableBoolean.True Then
            try
            {
                if (grdMilestones.ActiveRow.IsAddRow)
                {
                }
                else
                {
                    LoadNotifyList();
                    LoadPositionToNotifyList();
                    LoadDetail();
                    // If grdMilestones.ActiveRow.Cells("RelatedMilestone").Text <> "" Then
                    // lblRelatedMilestone.Text = "Related Milestone: " & grdMilestones.ActiveRow.Cells("RelatedMilestone").Text
                    // Else
                    // lblRelatedMilestone.Text = "Related Milestone: "
                    // End If
                    // If grdMilestones.ActiveRow.Cells("ActivityPaid").Text <> "" Then
                    // lblActivityPaid.Text = "Created when Activity Paid: " & grdMilestones.ActiveRow.Cells("ActivityPaid").Text
                    // Else
                    // lblActivityPaid.Text = "Create when Activity Paid: "
                    // End If
                    // If grdMilestones.ActiveRow.Cells("Action").Text <> "" Then
                    // lblAction.Text = "Action Performed when Activity Paid: " & grdMilestones.ActiveRow.Cells("Action").Text
                    // lblActionDescription.Text = grdMilestones.ActiveRow.Cells("ActionDescription").Text
                    // lblActionDescription.Visible = True
                    // Else
                    // lblAction.Text = "Action Performed when Activity Paid: "
                    // lblActionDescription.Visible = False
                    // End If
                    // If grdMilestones.ActiveRow.Cells("Note").Text <> "" Then
                    // lblNote.Text = "Created By: " & grdMilestones.ActiveRow.Cells("Note").Text
                    // Else
                    // lblNote.Text = "Created By: "
                    // End If
                    // End If
                } // move load to loaddetail
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: grdMilestons_AfterSelectChange ");
            }
        }
        private void LoadDetail()
        {
            try
            {
                if (grdMilestones.ActiveRow is not null)
                {
                    if (!string.IsNullOrEmpty(grdMilestones.ActiveRow.Cells["RelatedMilestone"].Text))
                    {
                        lblRelatedMilestone.Text="Related Milestone: "+grdMilestones.ActiveRow.Cells["RelatedMilestone"].Text;
                    }
                    else
                    {
                        lblRelatedMilestone.Text="Related Milestone: ";
                    }
                    if (!string.IsNullOrEmpty(grdMilestones.ActiveRow.Cells["ActivityPaid"].Text))
                    {
                        lblActivityPaid.Text="Created when Activity Paid: "+grdMilestones.ActiveRow.Cells["ActivityPaid"].Text;
                    }
                    else
                    {
                        lblActivityPaid.Text="Create when Activity Paid: ";
                    }
                    if (!string.IsNullOrEmpty(grdMilestones.ActiveRow.Cells["Action"].Text))
                    {
                        lblAction.Text="Action Performed when Activity Paid: "+grdMilestones.ActiveRow.Cells["Action"].Text;
                        lblActionDescription.Text=grdMilestones.ActiveRow.Cells["ActionDescription"].Text;
                        lblActionDescription.Visible=true;
                    }
                    else
                    {
                        lblAction.Text="Action Performed when Activity Paid: ";
                        lblActionDescription.Visible=false;
                    }
                    if (!string.IsNullOrEmpty(grdMilestones.ActiveRow.Cells["Note"].Text))
                    {
                        lblNote.Text="Created By: "+grdMilestones.ActiveRow.Cells["Note"].Text;
                    }
                    else
                    {
                        lblNote.Text="Created By: ";
                    }
                }
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "Milestones: LoadDetail ");
            }
        }
        public bool LoadNotifyList()
        {
            bool LoadNotifyListRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            string sNotifyCriteria = "";
            try
            {
                sNotifyCriteria=grdMilestones.ActiveRow.Cells["notifycriteria"].Text;

                grdNotifyList.DataSource=null;
                grdNotifyList.ResetDisplayLayout();
                grdNotifyList.Layouts.Clear();


                if (!string.IsNullOrEmpty(sNotifyCriteria))
                {
                    if (dbCalls.GetRecordsFromSP(ref ds, "spNotifyListGet", sNotifyCriteria))
                    {
                        grdNotifyList.DataSource=ds;
                        grdNotifyList.DataBind();
                        var layout = grdNotifyList.DisplayLayout;
                        var bands = layout.Bands;
                        // Get the first band, which is the  top-most band in case you had multple bands.
                        var band = bands[0];
                        // Columns property off UltraGridBand returns the collection of columns associated with the band.

                        UltraGridColumn ugc;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["ItemValue"];
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["ItemValue2"];
                        ugc.Width=120;
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["Position"];
                        ugc.Width=180; // 120
                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["ItemID"];
                        ugc.Hidden=true;
                    } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                    grdNotifyList.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    grdNotifyList.Text="Users to Notify Criteria: "+sNotifyCriteria;
                    btnChangeUsers.Enabled=modCommon.HasEditSecurity("milestones", "menu");
                }
                else
                {
                    grdNotifyList.Text="Users to Notify";
                    btnChangeUsers.Enabled=false;
                } // If snotifycritera <> "" Then
                  // grdNotifyList.Width = 375
                  // grdNotifyList.Height = 200
                LoadNotifyListRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: LoadNotifyList ");
                LoadNotifyListRet=false;
            }

            return LoadNotifyListRet;
        }
        public bool LoadPositionToNotifyList()
        {
            bool LoadPositionToNotifyListRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            long iMilestoneID = 0L;
            try
            {
                if (!string.IsNullOrEmpty(grdMilestones.ActiveRow.Cells["milestoneid"].Text))
                {
                    iMilestoneID=Conversions.ToLong(grdMilestones.ActiveRow.Cells["milestoneid"].Text);

                    grdPositionsToNotify.DataSource=null;

                    if (iMilestoneID!=0L)
                    {
                        if (dbCalls.GetRecordsFromSP(ref ds, "spNotifyPositionListGet", iMilestoneID))
                        {
                            // SELECT   p.Position, p.[rank], n.PositionToNotifyID, p.PositionID
                            grdPositionsToNotify.DataSource=ds;
                            grdPositionsToNotify.DataBind();
                            var layout = grdPositionsToNotify.DisplayLayout;
                            var bands = layout.Bands;
                            // Get the first band, which is the  top-most band in case you had multple bands.
                            var band = bands[0];
                            // Columns property off UltraGridBand returns the collection of columns associated with the band.

                            UltraGridColumn ugc;

                            // ugc = band.Columns("ItemValue")
                            // ugc.Hidden = True


                            ugc=band.Columns["PositionID"];
                            ugc.Hidden=true;
                            ugc=band.Columns["PositionToNotifyID"];
                            ugc.Hidden=true;
                        } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                        grdPositionsToNotify.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    }

                    else
                    {

                        btnChangeUsers.Enabled=false;
                    } // If snotifycritera <> "" Then
                      // grdPositionsToNotify.Width = 375
                      // grdPositionsToNotify.Height = 200
                }
                LoadPositionToNotifyListRet=true;
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: LoadPositionToNotifyList ");
                LoadPositionToNotifyListRet=false;
            }

            return LoadPositionToNotifyListRet;
        }

        // Private Sub grdMilestones_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles grdMilestones.ClickCellButton
        // 'If grdMilestones.ActiveRow.Cells("Edit").IsActiveCell Then

        // 'End If
        // End Sub

        // Private Sub grdMilestones_Enter(sender As Object, e As System.EventArgs) Handles grdMilestones.Enter

        // End Sub
        private void grdMilestones_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            e.Layout.Bands[0].Override.AllowRowFiltering=DefaultableBoolean.True;
            e.Layout.Bands[0].Override.RowFilterMode=RowFilterMode.AllRowsInBand;
        }

        private void btnChangeUsers_Click(object sender, EventArgs e)
        {
            var oUser = new UserSelect();
            try
            {
                oUser.oGridDS=(DataSet)grdNotifyList.DataSource;
                // .oGridLayout = grdNotifyList.Layouts(0)
                grdNotifyList.DisplayLayout.Save("userlayout");
                oUser.sCaption=grdMilestones.ActiveRow.Cells["NotifyCriteria"].Text;
                oUser.ShowDialog();
                LoadNotifyList();
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: btnChangeUsers_Click ");
            }
        }
        public void accept_Click(object sender, EventArgs e)
        {
            // Close the template and save any pending changes.
            grdMilestones.ActiveRow.Cells["Changed"].Value=true;
            LoadNotifyList();
            retMilestones.Close(true);
            grdMilestonesLock();
        } // accept_Click


        public void cancel_Click(object sender, EventArgs e)
        {
            // Close the template and discard any pending changes.
            // grdMilestones.ActiveRow.CancelUpdate()
            retMilestones.Close(false);
            grdMilestonesLock();
        } // cancel_Click

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            // mrb 9/21/12 move to grdMilestones_RowEditTemplateRequested
            // With grdMilestones.DisplayLayout.Bands(0)
            // .Columns("Description").CellActivation = Activation.AllowEdit
            // .Columns("NotifyCriteria").CellActivation = Activation.AllowEdit
            // .Columns("notifycriteria").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            // .Columns("GroupID").CellActivation = Activation.AllowEdit
            // .Columns("GroupID").ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always
            // End With
            modCommon.EnableDisableToolStrip(true, tsToolStrip, grdMilestones, "Milestones", "menu");
            // 9/15/12 move to edit mode
            grdMilestones.DisplayLayout.Bands[0].RowEditTemplate=retMilestones;

            FormatTemplate();

        }

        private void tsBtnUndo_Click(object sender, EventArgs e)
        {
            LoadGrid();
            modCommon.EnableDisableToolStrip(false, tsToolStrip, grdMilestones, "Milestones", "menu");
            EnableDisableForm(false);
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            if (SaveMilestones())
            {
                LoadGrid();
                modCommon.EnableDisableToolStrip(false, tsToolStrip, grdMilestones, "Milestones", "menu");
                EnableDisableForm(false);
            }
        }
        private void EnableDisableForm(bool bEdit)
        {
            grdNotifyList.Enabled=!bEdit;
        }
        private bool SaveMilestones()
        {
            bool SaveMilestonesRet = default;
            var cDB = new DBCalls();
            long iMilestoneID = 0L;
            string sDescription = "";
            int iUserAdded = 0;
            int iOrderBy = 0;
            int iNotify = 0;
            string sNotifyCriteria = "";
            string sMessage = "";
            bool bCanCancel = false;
            bool bBuilderCanCancel = false;
            string sSubject = "";
            string sNote = "";
            int iGroupID = 0;


            // create procedure spMilestoneUpdate
            // @MilestoneID as int,
            // @Description varchar(100),
            // @UserAdded tinyint,
            // @OrderBy int,
            // @Notify tinyint,
            // @NotifyCriteria varchar(50),
            // @Message varchar(250),
            // @CanCancel bit,
            // @BuilderCanCancel bit,
            // @Subject varchar(50),
            // @Note varchar(200),
            // @UpdatedBy char(10)
            try
            {
                long iRtn;
                foreach (var oRow in grdMilestones.Rows)
                {
                    // check for changes
                    if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(oRow.Cells["Changed"].Value, true, false)))
                    {
                        // save changes
                        if (oRow.Cells["MilestoneID"].Value is DBNull)
                        {
                            iMilestoneID=0L;
                        }
                        else
                        {
                            iMilestoneID=Conversions.ToLong(oRow.Cells["MilestoneID"].Text);
                        }
                        sDescription=oRow.Cells["Description"].Text;
                        if (!string.IsNullOrEmpty(oRow.Cells["UserAdded"].Text))
                        {
                            iUserAdded=(int)(oRow.Cells["UserAdded"].Value);
                        }
                        else
                        {
                            iUserAdded=(int)0;
                        }
                        if (oRow.Cells["OrderBy"].Value is DBNull)
                        {
                            iOrderBy=0;
                        }
                        else
                        {
                            iOrderBy=(int)(oRow.Cells["OrderBy"].Value);
                        }
                        if (oRow.Cells["Notify"].Value is DBNull)
                        {
                            iNotify=0;
                        }
                        else
                        {
                            iNotify=(int)(oRow.Cells["Notify"].Value);
                        }
                        // mrb 9/21/12
                        if (oRow.Cells["GroupID"].Value is DBNull)
                        {
                            iGroupID=0;
                        }
                        else
                        {
                            iGroupID=(int)(oRow.Cells["GroupID"].Value);
                        }

                        sNotifyCriteria=oRow.Cells["NotifyCriteria"].Text;
                        sMessage=oRow.Cells["Message"].Text;
                        if (!string.IsNullOrEmpty(oRow.Cells["CanCancel"].Text))
                        {
                            bCanCancel=Conversions.ToBoolean(oRow.Cells["CanCancel"].Text);
                        }
                        else
                        {
                            bCanCancel=false;
                        }
                        if (!string.IsNullOrEmpty(oRow.Cells["BuilderCanCancel"].Text))
                        {
                            bBuilderCanCancel=Conversions.ToBoolean(oRow.Cells["BuilderCanCancel"].Text);
                        }
                        else
                        {
                            bBuilderCanCancel=false;
                        }
                        sSubject=oRow.Cells["Subject"].Text;
                        sNote=oRow.Cells["Note"].Text;
                        iRtn=(long)cDB.GetReturnValueFromSP("spMilestoneUpdate", iMilestoneID, sDescription, iUserAdded, iOrderBy, iNotify, sNotifyCriteria, sMessage, bCanCancel, bBuilderCanCancel, sSubject, sNote, modGlobals.gsUserID, iGroupID);

                        if (iRtn!=0L)
                        {
                            modCommon.ShowError("Unable to save Milestone: "+sDescription, false, "BOSSAdmin", "Milestones: SaveMilestones ");
                        }
                    }
                }
                SaveMilestonesRet=true;
            }
            catch (Exception ex)
            {
                modCommon.ShowError(Information.Err().Description, false, "BOSSAdmin", "Milestones: SaveMilestones ");
                SaveMilestonesRet=false;
            }
            finally
            {
                cDB=null;
            }

            return SaveMilestonesRet;

        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            EnableDisableForm(true);
            modCommon.EnableDisableToolStrip(true, tsToolStrip, grdMilestones, "Milestones", "Menu");
            grdMilestones.Focus();

            var row = grdMilestones.DisplayLayout.Bands[0].AddNew();
            row.Selected=true;
            row.Cells["Description"].Activate();
            // 9/15/12 move to edit mode
            FormatTemplate();
            grdMilestones.DisplayLayout.Bands[0].RowEditTemplate=retMilestones;
            // grdMilestones.PerformAction(UltraGridAction.EnterEditMode)

            row.ShowEditTemplate();

        }


        private void grdMilestonesLock()
        {
            {
                var withBlock = grdMilestones.DisplayLayout.Bands[0];
                withBlock.Columns["Description"].CellActivation=Activation.NoEdit;
                withBlock.Columns["NotifyCriteria"].CellActivation=Activation.NoEdit;
                withBlock.Columns["notifycriteria"].ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate;
                withBlock.Columns["GroupID"].CellActivation=Activation.NoEdit;
                withBlock.Columns["GroupID"].ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.OnCellActivate;
            }
        }

        private void grdMilestones_RowEditTemplateRequested(object sender, RowEditTemplateRequestedEventArgs e)
        {
            {
                var withBlock = grdMilestones.DisplayLayout.Bands[0];
                withBlock.Columns["Description"].CellActivation=Activation.AllowEdit;
                withBlock.Columns["NotifyCriteria"].CellActivation=Activation.AllowEdit;
                withBlock.Columns["notifycriteria"].ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
                withBlock.Columns["GroupID"].CellActivation=Activation.AllowEdit;
                withBlock.Columns["GroupID"].ButtonDisplayStyle=Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always;
            }
        }
    }
}