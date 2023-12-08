using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Login : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing&&components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components=new System.ComponentModel.Container();
            var UltraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Environment");
            var UltraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Key");
            var UltraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("Environmnet");
            var UltraDataColumn8 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("DBKey");
            cmbEnvironment=new ComboBox();
            Label1=new Label();
            Label2=new Label();
            Label3=new Label();
            txtUserID=new TextBox();
            txtPassword=new TextBox();
            //txtPassword.TextChanged+=new EventHandler(txtPassword_TextChanged);
            cmdOk=new Button();
            cmdOk.Click+=new EventHandler(cmdOk_Click);
            UltraDataSource1=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            UltraDataSource2=new Infragistics.Win.UltraWinDataSource.UltraDataSource(components);
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource2).BeginInit();
            SuspendLayout();
            // 
            // cmbEnvironment
            // 
            cmbEnvironment.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
            cmbEnvironment.AutoCompleteSource=AutoCompleteSource.ListItems;
            cmbEnvironment.FormattingEnabled=true;
            cmbEnvironment.Items.AddRange(new object[] { "Cost Analysis", "Live", "Test" });
            cmbEnvironment.Location=new Point(169, 107);
            cmbEnvironment.Margin=new Padding(4);
            cmbEnvironment.Name="cmbEnvironment";
            cmbEnvironment.Size=new Size(132, 24);
            cmbEnvironment.TabIndex=3;
            cmbEnvironment.Text="Live";
            // 
            // Label1
            // 
            Label1.AutoSize=true;
            Label1.Location=new Point(76, 109);
            Label1.Margin=new Padding(4, 0, 4, 0);
            Label1.Name="Label1";
            Label1.Size=new Size(73, 17);
            Label1.TabIndex=1;
            Label1.Text="Database:";
            Label1.TextAlign=ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.AutoSize=true;
            Label2.Location=new Point(76, 68);
            Label2.Margin=new Padding(4, 0, 4, 0);
            Label2.Name="Label2";
            Label2.Size=new Size(73, 17);
            Label2.TabIndex=2;
            Label2.Text="Password:";
            Label2.TextAlign=ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.AutoSize=true;
            Label3.Location=new Point(66, 27);
            Label3.Margin=new Padding(4, 0, 4, 0);
            Label3.Name="Label3";
            Label3.Size=new Size(83, 17);
            Label3.TabIndex=3;
            Label3.Text="User Name:";
            Label3.TextAlign=ContentAlignment.MiddleRight;
            // 
            // txtUserID
            // 
            txtUserID.Location=new Point(169, 27);
            txtUserID.Margin=new Padding(4);
            txtUserID.Name="txtUserID";
            txtUserID.Size=new Size(132, 22);
            txtUserID.TabIndex=1;
            // 
            // txtPassword
            // 
            txtPassword.Location=new Point(169, 67);
            txtPassword.Margin=new Padding(4);
            txtPassword.Name="txtPassword";
            txtPassword.PasswordChar='*';
            txtPassword.Size=new Size(132, 22);
            txtPassword.TabIndex=2;
            txtPassword.UseSystemPasswordChar=true;
            // 
            // cmdOk
            // 
            cmdOk.Location=new Point(144, 161);
            cmdOk.Margin=new Padding(4);
            cmdOk.Name="cmdOk";
            cmdOk.Size=new Size(100, 28);
            cmdOk.TabIndex=4;
            cmdOk.Text="OK";
            cmdOk.UseVisualStyleBackColor=true;
            // 
            // UltraDataSource1
            // 
            UltraDataSource1.Band.AllowAdd=Infragistics.Win.DefaultableBoolean.False;
            UltraDataSource1.Band.AllowDelete=Infragistics.Win.DefaultableBoolean.False;
            UltraDataColumn6.DataType=typeof(short);
            UltraDataSource1.Band.Columns.AddRange(new object[] { UltraDataColumn5, UltraDataColumn6 });
            // 
            // UltraDataSource2
            // 
            UltraDataSource2.Band.Columns.AddRange(new object[] { UltraDataColumn7, UltraDataColumn8 });
            // 
            // Login
            // 
            AcceptButton=cmdOk;
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(389, 213);
            Controls.Add(cmdOk);
            Controls.Add(txtPassword);
            Controls.Add(txtUserID);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(cmbEnvironment);
            Margin=new Padding(4);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="Login";
            SizeGripStyle=SizeGripStyle.Hide;
            Text="BOSSAdmin Login";
            ((System.ComponentModel.ISupportInitialize)UltraDataSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UltraDataSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal ComboBox cmbEnvironment;
        internal Label Label1;
        internal Label Label2;
        internal Label Label3;
        internal TextBox txtUserID;
        internal TextBox txtPassword;
        internal Button cmdOk;
        internal Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource1;
        internal Infragistics.Win.UltraWinDataSource.UltraDataSource UltraDataSource2;
    }
}