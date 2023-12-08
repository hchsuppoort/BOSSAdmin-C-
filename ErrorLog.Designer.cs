using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class ErrorLog : Form
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
            uteLog=new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            btnPrint=new Button();
            btnPrint.Click+=new EventHandler(btnPrint_Click);
            btnCopy=new Button();
            btnCopy.Click+=new EventHandler(btnCopy_Click);
            PrintDialog1=new PrintDialog();
            UltraPrintDocument1=new Infragistics.Win.Printing.UltraPrintDocument(components);
            ((System.ComponentModel.ISupportInitialize)uteLog).BeginInit();
            SuspendLayout();
            // 
            // uteLog
            // 
            uteLog.Location=new Point(12, 12);
            uteLog.Multiline=true;
            uteLog.Name="uteLog";
            uteLog.Scrollbars=ScrollBars.Both;
            uteLog.Size=new Size(617, 653);
            uteLog.TabIndex=0;
            // 
            // btnPrint
            // 
            btnPrint.Location=new Point(194, 676);
            btnPrint.Name="btnPrint";
            btnPrint.Size=new Size(75, 38);
            btnPrint.TabIndex=1;
            btnPrint.Text="Print";
            btnPrint.UseVisualStyleBackColor=true;
            // 
            // btnCopy
            // 
            btnCopy.Location=new Point(293, 676);
            btnCopy.Name="btnCopy";
            btnCopy.Size=new Size(153, 38);
            btnCopy.TabIndex=2;
            btnCopy.Text="Copy to Clipboard";
            btnCopy.UseVisualStyleBackColor=true;
            // 
            // PrintDialog1
            // 
            PrintDialog1.UseEXDialog=true;
            // 
            // ErrorLog
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(641, 733);
            Controls.Add(btnCopy);
            Controls.Add(btnPrint);
            Controls.Add(uteLog);
            Name="ErrorLog";
            Text="ErrorLog";
            ((System.ComponentModel.ISupportInitialize)uteLog).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        internal Infragistics.Win.UltraWinEditors.UltraTextEditor uteLog;
        internal Button btnPrint;
        internal Button btnCopy;
        internal PrintDialog PrintDialog1;
        internal Infragistics.Win.Printing.UltraPrintDocument UltraPrintDocument1;
    }
}