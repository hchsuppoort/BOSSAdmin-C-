using System;
using Microsoft.VisualBasic;

namespace BossAdmin
{
    public partial class ErrorLog
    {
        public ErrorLog()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                My.MyProject.Computer.Clipboard.SetText(uteLog.Text);
                Interaction.MsgBox("Process Log) is saved to your clipboard.  You can paste it into a document or directly into an email", MsgBoxStyle.Information, "Copy to Clipboard");
            }

            catch (Exception ex)
            {

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            {
                var withBlock = UltraPrintDocument1;
                withBlock.Header.TextCenter="Cost Analysis";
                withBlock.Footer.TextCenter=uteLog.Text;
                withBlock.Print();
            }

        }
    }
}