using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ErrorDisplay : Form
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
            TableLayoutPanel1=new TableLayoutPanel();
            OK_Button=new Button();
            OK_Button.Click+=new EventHandler(OK_Button_Click);
            Cancel_Button=new Button();
            Cancel_Button.Click+=new EventHandler(Cancel_Button_Click);
            txtMessage=new TextBox();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor=AnchorStyles.Bottom|AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount=2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 0, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0);
            TableLayoutPanel1.Location=new Point(161, 145);
            TableLayoutPanel1.Margin=new Padding(4, 4, 4, 4);
            TableLayoutPanel1.Name="TableLayoutPanel1";
            TableLayoutPanel1.RowCount=1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size=new Size(195, 36);
            TableLayoutPanel1.TabIndex=0;
            // 
            // OK_Button
            // 
            OK_Button.Anchor=AnchorStyles.None;
            OK_Button.Location=new Point(4, 4);
            OK_Button.Margin=new Padding(4, 4, 4, 4);
            OK_Button.Name="OK_Button";
            OK_Button.Size=new Size(89, 28);
            OK_Button.TabIndex=0;
            OK_Button.Text="OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor=AnchorStyles.None;
            Cancel_Button.DialogResult=DialogResult.Cancel;
            Cancel_Button.Location=new Point(101, 4);
            Cancel_Button.Margin=new Padding(4, 4, 4, 4);
            Cancel_Button.Name="Cancel_Button";
            Cancel_Button.Size=new Size(89, 28);
            Cancel_Button.TabIndex=1;
            Cancel_Button.Text="Cancel";
            Cancel_Button.Visible=false;
            // 
            // txtMessage
            // 
            txtMessage.Location=new Point(43, 42);
            txtMessage.Multiline=true;
            txtMessage.Name="txtMessage";
            txtMessage.Size=new Size(428, 70);
            txtMessage.TabIndex=1;
            // 
            // ErrorDisplay
            // 
            AcceptButton=OK_Button;
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            CancelButton=Cancel_Button;
            ClientSize=new Size(517, 196);
            Controls.Add(txtMessage);
            Controls.Add(TableLayoutPanel1);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            Margin=new Padding(4, 4, 4, 4);
            MaximizeBox=false;
            MinimizeBox=false;
            Name="ErrorDisplay";
            ShowInTaskbar=false;
            StartPosition=FormStartPosition.CenterParent;
            Text="ErrorDisplay";
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal TextBox txtMessage;

    }
}