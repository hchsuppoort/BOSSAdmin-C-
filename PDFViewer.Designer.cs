using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class PDFViewer : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFViewer));
            AxAcroPDF1=new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)AxAcroPDF1).BeginInit();
            SuspendLayout();
            // 
            // AxAcroPDF1
            // 
            AxAcroPDF1.Enabled=true;
            AxAcroPDF1.Location=new Point(16, 12);
            AxAcroPDF1.Name="AxAcroPDF1";
            AxAcroPDF1.OcxState=(AxHost.State)resources.GetObject("AxAcroPDF1.OcxState");
            AxAcroPDF1.Size=new Size(725, 915);
            AxAcroPDF1.TabIndex=12;
            // 
            // PDFViewer
            // 
            AutoScaleDimensions=new SizeF(8.0f, 16.0f);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(764, 952);
            Controls.Add(AxAcroPDF1);
            Name="PDFViewer";
            StartPosition=FormStartPosition.CenterParent;
            Text="PDFViewer";
            ((System.ComponentModel.ISupportInitialize)AxAcroPDF1).EndInit();
            ResumeLayout(false);

        }
        internal AxAcroPDFLib.AxAcroPDF AxAcroPDF1;
    }
}