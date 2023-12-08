using System;
using System.Data;
using System.Text.RegularExpressions;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class UserMaintenance
    {

        private Regex m_emailRegEx;
        private Regex EmailRegEx
        {
            get
            {
                if (m_emailRegEx is null)
                {
                    m_emailRegEx=new Regex(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase);
                }

                return m_emailRegEx;
            }
        }

        public UserMaintenance()
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
                grdUsers.DataSource=null;
                // SELECT distinct s.SIId, s.PositionID, p.Position, s.FName, s.LName, 
                // s.Inactive,
                // s.[Address], s.City, s.ST, s.Zip, s.HPhone, s.Cell, s.Radio, s.Fax, s.EMail,
                // s.UserID, s.[password], s.SupervisorID, Live, QA, Test

                if (dbCalls.GetRecordsFromSP(ref ds, "spUserListGet"))
                {
                    grdUsers.DataSource=ds;
                    grdUsers.DataBind();
                    var layout = grdUsers.DisplayLayout;
                    var bands = layout.Bands;
                    // Get the first band, which is the  top-most band in case you had multple bands.
                    var band = bands[0];
                    // Columns property off UltraGridBand returns the collection of columns associated with the band.
                    var oColumns = band.Columns;

                    // create column to track changes
                    UltraGridColumn ugc;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Address"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["City"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["St"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Zip"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["HPhone"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Cell"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Radio"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Fax"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["UserID"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Password"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["SupervisorID"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["PositionID"];
                    ugc.Hidden=true;

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Live"];
                    ugc.Header.Caption="Access to BOSS";

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Test"];
                    ugc.Header.Caption="Access to Test";

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["QA"];
                    ugc.Header.Caption="Access to Cost Analysis";

                    ugc=grdUsers.DisplayLayout.Bands[0].Columns["Live"];
                    ugc.Header.Caption="Access to BOSS";


                    grdUsers.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    if (grdUsers.Rows.Count>0)
                    {
                        if (grdUsers.ActiveRow is not null) // 9/16/16 mrb
                        {
                            grdUsers.ActiveRow.Selected=true;
                        }
                    } // If grdUsers.Rows.Count > 0 Then
                      // grdUsers.DisplayLayout.Bands(0).RowEditTemplate = retMilestones
                    LoadGridRet=true;
                }
                else
                {
                    LoadGridRet=false;
                } // 9/16/16 mrb
                  // If dbCalls.GetRecordsFromSP(ds, "spUserListGet") Then
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: LoadGrid ");
                LoadGridRet=false;
            }
            finally
            {
                // add this 9/16/16 mrb
                if (ds is not null)
                {
                    ds=null;
                }
                if (dbCalls is not null)
                {
                    dbCalls=null;
                }
            }

            return LoadGridRet;
        }

        private void UserMaintenance_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadPositions();
            LoadSupervisors();
            LoadStates();
            // mrb 1/31/13
            EnableDisableToolStrip(false, "UserMaintenance");
            hidefields();

        }
        private void hidefields()
        {
            bool bCanEdit;
            bCanEdit=modCommon.HasEditSecurity("mnuSecurity", "Menu");
            utePassword.Visible=bCanEdit;
        }
        private bool LoadNotifyList()
        {
            bool LoadNotifyListRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            int iSIID = 0;
            try
            {
                iSIID=(int)(grdUsers.ActiveRow.Cells["siid"].Value);

                grdNotifyList.DataSource=null;
                grdNotifyList.ResetDisplayLayout();
                grdNotifyList.Layouts.Clear();


                if (iSIID!=0)
                {
                    if (dbCalls.GetRecordsFromSP(ref ds, "spNotifyListGetByUser", iSIID))
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
                        ugc.Width=200;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["ItemValue2"];
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["Position"];
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["fname"];
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["lname"];
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["Rank"];
                        ugc.Hidden=true;

                        ugc=grdNotifyList.DisplayLayout.Bands[0].Columns["ItemID"];
                        ugc.Hidden=true;

                    } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                    grdNotifyList.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
                    EnableDisableToolStrip(true, "LoadNotifyList");
                }
                else
                {
                    grdNotifyList.Text="Notify";
                    EnableDisableToolStrip(false, "LoadNotifyList");
                } // If snotifycritera <> "" Then
                  // grdNotifyList.Width = 375
                  // grdNotifyList.Height = 200
                LoadNotifyListRet=true;
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: LoadNotifyList ");
                LoadNotifyListRet=false;
            }

            return LoadNotifyListRet;
        }

        private void grdUsers_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
        {
            try
            {
                LoadDetails();
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: grdUsers_AfterSelectChange ");
            }
        }
        private bool LoadPositions()
        {
            bool LoadPositionsRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();

            try
            {
                if (dbCalls.GetRecordsFromSP(ref ds, "spPositionsListGet"))
                {
                    uComboPositions.DataSource=ds;
                    uComboPositions.DataBind();
                }

                UltraGridColumn ugc;

                ugc=uComboPositions.DisplayLayout.Bands[0].Columns["PositionID"];
                ugc.Hidden=true;

                LoadPositionsRet=true;
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: LoadPostions ");
                LoadPositionsRet=false;
            }

            return LoadPositionsRet;
        }
        private bool LoadSupervisors()
        {
            bool LoadSupervisorsRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();

            try
            {
                if (dbCalls.GetRecordsFromSP(ref ds, "spSupervisorListGet"))
                {
                    uComboSupervisor.DataSource=ds;
                    uComboSupervisor.DataBind();
                    // uComboSupervisor.DisplayMember = "Supervisor"
                    // uComboSupervisor.ValueMember = "SupervisorID"
                }
                // note order of list is important for search.  if you want to set value and find first column
                // first column must be what yuo want to show in text field.  can't have a hidden column first
                UltraGridColumn ugc;

                ugc=uComboSupervisor.DisplayLayout.Bands[0].Columns["siID"];
                ugc.Hidden=true;
                ugc=uComboSupervisor.DisplayLayout.Bands[0].Columns["PositionID"];
                ugc.Hidden=true;
                // ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("ItemValue")
                // ugc.Hidden = True

                LoadSupervisorsRet=true;
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: LoadSupervisors ");
                LoadSupervisorsRet=false;
            }

            return LoadSupervisorsRet;
        }
        private bool LoadStates()
        {
            bool LoadStatesRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();

            try
            {
                if (dbCalls.GetRecordsFromSP(ref ds, "spGetStates"))
                {
                    uComboState.DataSource=ds;
                    uComboState.DataBind();
                }

                // Dim ugc As UltraGridColumn

                // ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("siID")
                // ugc.Hidden = True

                // ugc = uComboSupervisor.DisplayLayout.Bands(0).Columns("ItemValue")
                // ugc.Hidden = True

                LoadStatesRet=true;
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: LoadStates ");
                LoadStatesRet=false;
            }

            return LoadStatesRet;
        }
        private void EnableDisableToolStrip(bool bEdit, string sCalledBy)
        {
            bool bCanEdit;
            try
            {
                bCanEdit=modCommon.HasEditSecurity("mnuSecurity", "Menu")&!bEdit; // mrb 9/16/16
                tsToolStrip.Items["tsBtnAdd"].Enabled=bCanEdit;
                tsToolStrip.Items["tsBtnEdit"].Enabled=bCanEdit;
                tsToolStrip.Items["tsBtnUndo"].Enabled=bEdit;
                tsToolStrip.Items["tsBtnSave"].Enabled=bEdit;
                tsToolStrip.Items["tsBtnPrint"].Enabled=!bEdit;

                if (!bCanEdit)
                {
                }
            }

            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: EnableDisableToolStrip ");
            }
        }
        private void EnableDisableForm(bool bEdit)
        {
            grdUsers.Enabled=!bEdit;
            uteLName.ReadOnly=!bEdit;
            uteFName.ReadOnly=!bEdit;
            uteUserID.ReadOnly=!bEdit;
            utePassword.ReadOnly=!bEdit;
            uteAddress.ReadOnly=!bEdit;
            uteCell.ReadOnly=!bEdit;
            uteCity.ReadOnly=!bEdit;
            uteeMail.ReadOnly=!bEdit;
            uteFax.ReadOnly=!bEdit;
            utePhone.ReadOnly=!bEdit;
            uteRadio.ReadOnly=!bEdit;
            uTeZip.ReadOnly=!bEdit;

            uComboSupervisor.ReadOnly=!bEdit;
            uComboPositions.ReadOnly=!bEdit;
            uComboState.ReadOnly=!bEdit;

            uCheckBoss.Enabled=bEdit;
            uCheckCA.Enabled=bEdit;
            uCheckTest.Enabled=bEdit;
            uCheckInactive.Enabled=bEdit;
            uCheckBossman.Enabled=bEdit;

        }

        private void tsBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 9/20/16 added field cleanout
                grdUsers.Selected.Rows.Clear(); // 9/20/16 mrb
                LoadNotifyList(); // 9/20/16 mrb this load is based on siid

                EnableDisableToolStrip(true, "tsBtnAdd_Click");
                EnableDisableForm(true);
                uteLName.Text="";
                uteFName.Text="";
                uteUserID.Text="";
                utePassword.Text="";
                uteAddress.Text="";
                uteCell.Text="";
                uteCity.Text="";
                uteeMail.Text="";
                uteFax.Text="";
                utePhone.Text="";
                uteRadio.Text="";
                uTeZip.Text="";

                uComboSupervisor.Value="";
                uComboPositions.Value="";
                uComboState.Value="";

                uCheckBoss.Checked=Conversions.ToBoolean(Constants.vbFalse);
                uCheckCA.Checked=Conversions.ToBoolean(Constants.vbFalse);
                uCheckTest.Checked=Conversions.ToBoolean(Constants.vbFalse);
                uCheckInactive.Checked=Conversions.ToBoolean(Constants.vbFalse);
                uCheckBossman.Checked=Conversions.ToBoolean(Constants.vbTrue);
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: tsBtnAdd_Click ");
            }

        }

        private void tsBtnEdit_Click(object sender, EventArgs e)
        {
            EnableDisableToolStrip(true, "tsBtnEdit_Click");
            EnableDisableForm(true);
        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            // validate data - require entries userid, password, email, supervisor, first name, last name, position
            Validation oValidateT;

            try
            {
                oValidateT=uv1.Validate("vgText");

                if (oValidateT.IsValid)
                {
                    // save record

                    EnableDisableToolStrip(false, "tsBtnSave_Click");
                    EnableDisableForm(false);
                }
                else
                {
                    Interaction.MsgBox("You have incomplete fields.  Please complete and try again", MsgBoxStyle.Critical, "Validate User");
                }
            }
            catch (Exception ex)
            {
                modCommon.ShowError(ex.Message, false, "", "");
            }

        }

        private void tsBtnUndo_Click(object sender, EventArgs e)
        {
            EnableDisableToolStrip(false, "tsBtnUndo_Click");
            LoadDetails();

        }
        private void LoadDetails()
        {
            try
            {
                LoadNotifyList();

                // If grdUsers.ActiveRow.Cells("Lname").Text <> "" Then
                uteLName.Text=grdUsers.ActiveRow.Cells["Lname"].Text;
                // End If
                // If grdUsers.ActiveRow.Cells("fname").Text <> "" Then
                uteFName.Text=grdUsers.ActiveRow.Cells["fname"].Text;
                // End If
                // If grdUsers.ActiveRow.Cells("userid").Text <> "" Then
                uteUserID.Text=grdUsers.ActiveRow.Cells["userid"].Text;
                // End If
                // If grdUsers.ActiveRow.Cells("password").Text <> "" Then
                utePassword.Text=grdUsers.ActiveRow.Cells["password"].Text;
                // End If
                uteAddress.Text=grdUsers.ActiveRow.Cells["address"].Text;
                uteCell.Text=grdUsers.ActiveRow.Cells["cell"].Text;
                uteCity.Text=grdUsers.ActiveRow.Cells["city"].Text;
                uteeMail.Text=grdUsers.ActiveRow.Cells["email"].Text;
                uteFax.Text=grdUsers.ActiveRow.Cells["fax"].Text;
                utePhone.Text=grdUsers.ActiveRow.Cells["hphone"].Text;
                uteRadio.Text=grdUsers.ActiveRow.Cells["radio"].Text;
                uTeZip.Text=grdUsers.ActiveRow.Cells["zip"].Text;

                uComboSupervisor.Value=grdUsers.ActiveRow.Cells["Supervisor"].Text;

                uComboPositions.Value=grdUsers.ActiveRow.Cells["Position"].Text;
                uComboState.Value=grdUsers.ActiveRow.Cells["st"].Text;

                uCheckBoss.Checked=Conversions.ToBoolean(grdUsers.ActiveRow.Cells["live"].Value);
                uCheckCA.Checked=Conversions.ToBoolean(grdUsers.ActiveRow.Cells["qa"].Value);
                uCheckTest.Checked=Conversions.ToBoolean(grdUsers.ActiveRow.Cells["test"].Value);
                uCheckInactive.Checked=Conversions.ToBoolean(grdUsers.ActiveRow.Cells["inactive"].Value);
            }
            catch (Exception ex)
            {

                modCommon.ShowError(ex.Message, false, "BOSSAdmin", "UserMaintenance: LoadDetails");
            }

        }
        private void tsBtnPrint_Click(object sender, EventArgs e)
        {
            // print report
        }


        private void tsBtnAdd_Click1(object sender, EventArgs e)
        {

        }

        private void uv1_Validating(object sender, ValidatingEventArgs e)
        {
            if (e.Control.Name=="uteeMail")
            {
                if (!string.IsNullOrEmpty(uteeMail.Text))
                {
                    if (!EmailRegEx.IsMatch(uteeMail.Text))
                    {
                        e.IsValid=false;
                        e.ValidationSettings.NotificationSettings.Text="Please reenter the email in a Valid Format.";
                    }
                }
                else
                {
                    e.ValidationSettings.NotificationSettings.Text="EMail is a required field.";
                }
            }
        }

        private void uv1_ValidationError(object sender, Infragistics.Win.Misc.ValidationErrorEventArgs e)
        {

        }
    }
}