using System;
using System.Windows.Forms;
using Infragistics.Win.AppStyling;
using Microsoft.VisualBasic;

namespace BossAdmin
{
    public class AppMgr
    {

        [STAThread()]
        public static void Main()
        {
            string sPathToISL;
            bool bGoOn;
            try
            {
                sPathToISL=Application.StartupPath+@"\resources\Metro.isl";
                StyleManager.Load(sPathToISL);
                using (var frmLogin1 = new Login())
                {
                    bGoOn=frmLogin1.ShowDialog()==DialogResult.OK;
                }
                // Dim MainForm As New mdiMain
                if (bGoOn)
                {
                    if (modGlobals.gbValidUser==true)
                    {
                        var MainForm = new mdiMain();
                        // MainForm.lblConnectionstring.Text = gsConnectionString
                        Application.Run(MainForm);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch
            {
                modCommon.ShowError(Information.Err().Description, false, "LoadError", "BOSSAdmin - load application");
            }
        }
    }
}