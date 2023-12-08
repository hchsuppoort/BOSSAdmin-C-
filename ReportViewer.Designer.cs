using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ReportViewer : Form
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
            crViewer=new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            SuspendLayout();
            // 
            // crViewer
            // 
            crViewer.ActiveViewIndex=-1;
            crViewer.BorderStyle=BorderStyle.FixedSingle;
            crViewer.Cursor=Cursors.Default;
            crViewer.DisplayStatusBar=false;
            crViewer.Dock=DockStyle.Fill;
            crViewer.Location=new Point(0, 0);
            crViewer.Name="crViewer";
            crViewer.Size=new Size(1186, 793);
            crViewer.TabIndex=0;
            // 
            // ReportViewer
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1186, 793);
            Controls.Add(crViewer);
            Name="ReportViewer";
            StartPosition=FormStartPosition.CenterScreen;
            Text="ReportViewer";
            WindowState=FormWindowState.Minimized;
            Load+=new EventHandler(ReportViewer_Load);
            ResumeLayout(false);

        }
        internal CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}