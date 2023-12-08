using System;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{

    public partial class VPOReasons
    {
        private System.Windows.Forms.ToolTip tooltip2;
        private DataSet ds = new DataSet();
        private UltraDropDown ddOwner = new UltraDropDown();
        private UltraDropDown ddAssignTo = new UltraDropDown();
        private UltraDropDown ultraDropDown1;
        // Instantiate an UltraGridRowEditTemplate object.
        private UltraGridRowEditTemplate templateReason = new UltraGridRowEditTemplate();
        private bool bAddNew = false;

        public VPOReasons()
        {
            InitializeComponent();
        }
        private void VPOReasons_Load(object sender, EventArgs e)
        {
            if (LoadGrid())
            {
                EnableDisableToolStrip(false);
                // Set the template's size, caption, backcolor, 
                // and add it to the Controls collection.
                // With templateReason
                // .Size = New Size(320, 240)
                // .DialogSettings.Caption = "Contact Information"
                // .Appearance.BackColor = Color.White
                // .Visible = False
                // Me.Controls.Add(templateReason)
                // ' Me.grdReasons.DisplayLayout.Bands(0).RowEditTemplate = Me.templateReason
                // End With
            }
        }
        private bool LoadGrid()
        {
            bool LoadGridRet = default;
            var ds = new DataSet();
            var dbCalls = new DBCalls();
            var dsPositions = new DataSet();
            try
            {
                grdReasons.DataSource=null;
                if (dbCalls.GetRecordsFromSP(ref ds, "spGetVPOReasons"))
                {
                    grdReasons.DataSource=ds;
                    if (dbCalls.GetRecordsFromSP(ref dsPositions, "spGetPositions"))
                    {

                    }
                    grdReasons.DataBind();
                    var layout = grdReasons.DisplayLayout;
                    var bands = layout.Bands;
                    // Get the first band, which is the  top-most band in case you had multple bands.
                    var band = bands[0];
                    // Columns property off UltraGridBand returns the collection of columns associated with the band.
                    var oColumns = band.Columns;
                    // You can get a particular column using the column name.
                    var oColumnResponsiblePosition = oColumns["ResponsiblePositionID"];
                    var oColumnAssignmentTo = oColumns["AssignmentToPosition"];
                    // create dropdown for Owner
                    ddOwner.SetDataBinding(dsPositions, null);
                    ddOwner.ValueMember="PositionID";
                    ddOwner.DisplayMember="Position";
                    grdReasons.DisplayLayout.Bands[0].Columns["ResponsiblePositionID"].ValueList=ddOwner;
                    // create dropdown for AssignTo
                    ddAssignTo.SetDataBinding(dsPositions, null);
                    ddAssignTo.ValueMember="PositionID";
                    ddAssignTo.DisplayMember="Position";
                    grdReasons.DisplayLayout.Bands[0].Columns["AssignmentToPosition"].ValueList=ddAssignTo;
                    // create column to track changes
                    grdReasons.DisplayLayout.Bands[0].Columns.Add("Changed", "Changed");
                    grdReasons.DisplayLayout.Bands[0].Columns["Changed"].DataType=typeof(bool);
                    UltraGridColumn ugc;
                    ugc=grdReasons.DisplayLayout.Bands[0].Columns["Changed"];
                    ugc.Style=Infragistics.Win.UltraWinGrid.ColumnStyle.CheckBox;

                } // If dbCalls.GetRecordsFromSP(ds, "spGetVPOReasons") Then
                grdReasons.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;

                LoadGridRet=true;
            }
            catch
            {
                Interaction.MsgBox("Error in VPOReasons LoadGrid: "+Information.Err().Description, Constants.vbCritical);
                LoadGridRet=false;
            }

            return LoadGridRet;
        }

        private void grdReasons_CellChange(object sender, CellEventArgs e)
        {
            grdReasons.ActiveRow.Cells["Changed"].Value=true;
        }
        private void grdReasons_InitializeLayout(object sender, InitializeLayoutEventArgs e)
        {
            // e.Layout.Bands(0).Columns("Int32 1").ValueList = Me.ultraDropDown1
            {
                var withBlock = e.Layout.Bands[0];
                withBlock.Columns["ResponsiblePositionID"].Header.Caption="Owner";

                withBlock.Columns["AssignmentToPosition"].Header.Caption="Assign To";

                withBlock.Columns["Reason"].MaxLength=30;

                withBlock.Columns["ReasonCode"].Header.Caption="Code";
                withBlock.Columns["ReasonCode"].Width=48;
                withBlock.Columns["ReasonCode"].CellActivation=Activation.Disabled; // we don't want this column edited

                withBlock.Columns["Message"].MaxLength=100;

                withBlock.Columns["Inactive"].Width=48;
                withBlock.Columns["Inactive"].DefaultCellValue=Constants.vbFalse;
            }
        }

        private void grdReasons_MouseEnterElement(object sender, UIElementEventArgs e)
        {
            // tool tip over cell 
            string sTip = "";
            UltraGridCell acell = (UltraGridCell)e.Element.GetContext(typeof(UltraGridCell));
            tooltip2=new System.Windows.Forms.ToolTip();

            // If Not acell Is Nothing Then
            // sTip = "cell tool tip for " + acell.Column.Key
            // tooltip2.Active = True
            // Select Case acell.Column.Key
            // Case "ReasonCode"
            // sTip = "This code is used in the Purchase Order"
            // Case "Reason"
            // sTip = "Description of the VPO Reason"
            // Case "ResponsiblePositionID"
            // sTip = "New VPO Investigations will be assigned to this Position"
            // Case "AssignmentToPosition"
            // sTip = "New VPO Investigations will assigned to this Position for review before the Owner review"
            // Case "Message"
            // sTip = "This message is used in the VPO Investigation actions"
            // End Select
            // tooltip2.SetToolTip(sender, sTip)

            // End If

            // tool tip over column header 
            Infragistics.Win.UltraWinGrid.ColumnHeader aColumnHeader = (Infragistics.Win.UltraWinGrid.ColumnHeader)e.Element.GetContext(typeof(Infragistics.Win.UltraWinGrid.ColumnHeader));

            if (aColumnHeader is not null)
            {
                sTip="Column Header Tool Tip for "+aColumnHeader.Column.Key;
                tooltip2.Active=true;
                switch (aColumnHeader.Column.Key??"")
                {
                    case "ReasonCode":
                        {
                            sTip="This code is used in the Purchase Order. It cannot be changed by the user.";
                            break;
                        }
                    case "Reason":
                        {
                            sTip="Description of the VPO Reason";
                            break;
                        }
                    case "ResponsiblePositionID":
                        {
                            sTip="New VPO Investigations will be assigned to this Position";
                            break;
                        }
                    case "AssignmentToPosition":
                        {
                            sTip="New VPO Investigations will assigned to this Position for review before the Owner review";
                            break;
                        }
                    case "Message":
                        {
                            sTip="This message is used in the VPO Investigation actions";
                            break;
                        }
                }
                tooltip2.SetToolTip((Control)sender, sTip);
            }

        }



        private void tsToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name??"")
            {
                case "tsBtnAdd":
                    {
                        // Me.templateReason.Visible = True
                        grdReasons.DisplayLayout.Bands[0].AddNew();
                        EnableDisableToolStrip(true);
                        bAddNew=true;
                        break;
                    }
                case "tsBtnEdit":
                    {
                        EnableDisableToolStrip(true);
                        break;
                    }
                case "tsBtnSave":
                    {
                        if (bAddNew)
                        {
                            if (Conversions.ToBoolean(SaveNewReason()))
                            {
                                LoadGrid();
                                EnableDisableToolStrip(false);
                                Interaction.MsgBox("Add new VPOReason: Changes Saved", MsgBoxStyle.Information);
                            }
                        }
                        else if (UpdateReason())
                        {
                            LoadGrid();
                            EnableDisableToolStrip(false);
                            Interaction.MsgBox("Update VPOReason: Changes Saved", MsgBoxStyle.Information);
                        }

                        break;
                    }

                case "tsBtnUndo":
                    {
                        LoadGrid();
                        EnableDisableToolStrip(false);
                        break;
                    }
                case "tsBtnPrint":
                    {
                        break;
                    }
                case "tsBtnTip":
                    {
                        break;
                    }
            }
        }
        private void EnableDisableToolStrip(bool bEdit)
        {
            bool bCanEdit;

            bCanEdit=modCommon.HasEditSecurity("VPOReasons", "Menu")&!bEdit;
            tsToolStrip.Items["tsBtnAdd"].Enabled=bCanEdit;
            tsToolStrip.Items["tsBtnEdit"].Enabled=bCanEdit;
            tsToolStrip.Items["tsBtnUndo"].Enabled=bEdit;
            tsToolStrip.Items["tsBtnSave"].Enabled=bEdit;
            tsToolStrip.Items["tsBtnPrint"].Enabled=!bEdit;
            if (bEdit)
            {
                grdReasons.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.True;
            }
            else
            {
                grdReasons.DisplayLayout.Override.AllowUpdate=DefaultableBoolean.False;
            }
        }
        private object SaveNewReason()
        {
            object SaveNewReasonRet = default;
            var oDB = new DBCalls();
            long lRtn = 0L;
            string sReason = grdReasons.ActiveRow.Cells["Reason"].Text;
            int iOwner = (int)(grdReasons.ActiveRow.Cells["ResponsiblePositionID"].Value);
            int iAssignTo = (int)(grdReasons.ActiveRow.Cells["AssignmentToPosition"].Value);
            string sMessage = grdReasons.ActiveRow.Cells["Message"].Text;
            bool bInactive = Conversions.ToBoolean(grdReasons.ActiveRow.Cells["Inactive"].Value);
            int iInactive;
            try
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(grdReasons.ActiveRow.Cells["Inactive"].Value, true, false)))
                {
                    iInactive=1;
                }
                else
                {
                    iInactive=0;
                }
                // @CreatedBy char(10),
                // @Reason char(30),
                // @Inactive bit,
                // @ResponsiblePositionID int,
                // @AssignmentToPosition int,
                // @Message varchar(100)

                lRtn=(long)oDB.GetReturnValueFromSP("spVPOReasonInsert", modGlobals.gsUserID, sReason, bInactive, iOwner, iAssignTo, sMessage);
                SaveNewReasonRet=lRtn==0L;
            }
            catch
            {
                Interaction.MsgBox("Error in SaveNewReason: "+Information.Err().Description, MsgBoxStyle.Critical, "Save New Reason");
                SaveNewReasonRet=false;
            }
            finally
            {
                Cursor=Cursors.Default;
            }

            return SaveNewReasonRet;
        }

        private bool UpdateReason()
        {
            bool UpdateReasonRet = default;
            var oDB = new DBCalls();
            long lRtn = 0L;
            bool bOk = true;
            try
            {
                Cursor=Cursors.WaitCursor;

                foreach (var oRow in grdReasons.Rows)
                {
                    if (bOk)
                    {
                        if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(oRow.Cells["Changed"].Value, true, false)))
                        {
                            int iReason = (int)(grdReasons.ActiveRow.Cells["ReasonCode"].Value);
                            string sReason = grdReasons.ActiveRow.Cells["Reason"].Text;
                            int iOwner = (int)(grdReasons.ActiveRow.Cells["ResponsiblePositionID"].Value);
                            // Dim iAssignTo As Integer = 0
                            // If Not IsDBNull(grdReasons.ActiveRow.Cells("AssignmentToPosition").Value) Then
                            var iAssignTo = grdReasons.ActiveRow.Cells["AssignmentToPosition"].Value;
                            // End If
                            string sMessage = grdReasons.ActiveRow.Cells["Message"].Text;
                            bool bInactive = Conversions.ToBoolean(grdReasons.ActiveRow.Cells["Inactive"].Value);
                            int iInactive;
                            if (Conversions.ToBoolean(grdReasons.ActiveRow.Cells["Inactive"].Text)==true)
                            {
                                iInactive=1;
                            }
                            else
                            {
                                iInactive=0;
                            }
                            // alter procedure spVPOReasonUpdate
                            // @UpdatedBy char(10),
                            // @ReasonCode int,
                            // @Reason char(30),
                            // @Inactive bit,
                            // @ResponsiblePositionID int,
                            // @AssignmentToPosition int,
                            // @Message varchar(100)

                            lRtn=(long)oDB.GetReturnValueFromSP("spVPOReasonUpdate", modGlobals.gsUserID, iReason, sReason, iInactive, iOwner, iAssignTo, sMessage);
                            // UpdateReason = lRtn = 0
                            bOk=lRtn==0L;
                        } // if row changed
                    } // if bok
                }
                UpdateReasonRet=bOk;
            }
            catch
            {
                Interaction.MsgBox("Error in UpdateReason: "+Information.Err().Description, MsgBoxStyle.Critical, "Update VPO Reason");
                UpdateReasonRet=false;
            }
            finally
            {
                Cursor=Cursors.Default;
            }

            return UpdateReasonRet;
        }
    }
}