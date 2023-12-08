using System;
using System.Windows.Forms;

namespace BossAdmin
{
    public partial class mdiMain
    {
        public mdiMain()
        {
            InitializeComponent();
        }

        private void NotificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MilestonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new Milestones();
            OpenMDIChild(oForm);

        }
        private void VPOReasonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           VPOReasons oForm = new VPOReasons();
           OpenMDIChild(oForm);

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="oForm"></param>
        public void OpenMDIChild(Form oForm)
        {
            // this code adds the form to the windows list and allows multiples of the same window
            // if we open a window from within another window, we should use this module
            // if we are setting captions based on criteria, we can set them before the form is passwed3
            //var newMDIChild = new Form();
            Form newMDIChild = new Form();
            newMDIChild=oForm;
            newMDIChild.MdiParent=this;
            newMDIChild.Show();
        }
        private void mdiMain_Load(object sender, EventArgs e)
        {
            string sVersion = "";
            if (string.IsNullOrEmpty(modGlobals.gsDatabase))
            {
                Application.Exit();
            }
            else // mrb 10/21/14
            {
                sVersion=My.MyProject.Application.Info.Version.ToString();
                Text="BOSSAdmin V "+sVersion;
                MenusShow();
            }
        }

        private void MenusShow()
        {
            bool bIsCostAnalysis;
            bIsCostAnalysis=modGlobals.gsDatabase=="HCHDataQA";
            // add security 9/15/16 mrb
            TakeoffTablesToolStripMenuItem.Visible=bIsCostAnalysis==false&modCommon.HasViewSecurity("mnuTakeOffTable", "Menu");
            PlanEstimateTablesToolStripMenuItem.Visible=bIsCostAnalysis==false&modCommon.HasViewSecurity("mnuPlanEstimateTable", "Menu");
            MaintenanceToolStripMenuItem.Visible=bIsCostAnalysis==false;
            tsMnuItemCostAnalysis.Visible=bIsCostAnalysis;
            ViewEstimateToolStripMenuItem.Visible=bIsCostAnalysis==true;
            UsersToolStripMenuItem.Visible=modCommon.HasViewSecurity("mnuBAUserAdmin", "Menu");
            PositionsToolStripMenuItem.Visible=modCommon.HasViewSecurity("mnuBAPositions", "Menu");
            DivisionsToolstripMenu.Visible=modCommon.HasViewSecurity("mnuBAAddEditDivision", "Menu");
            ProjectsToolStripMenuItem.Visible=modCommon.HasViewSecurity("mnuBAProjectMaintenance", "Menu");
            SecurityToolStripMenuItem.Visible=modCommon.HasViewSecurity("mnuBASecurity", "Menu");
            VPOReasonsToolStripMenuItem.Visible=modCommon.HasViewSecurity("mnuBAVPOReasons", "Menu");
            MilestonesToolStripMenuItem.Visible=modCommon.HasViewSecurity("mnuBAMilestones", "Menu");
            // HelpToolStripMenuItem.Visible = False 'mrb 6/22/22
            tsMnuItemCostAnalysisReports.Visible=false; // mrb 6/22/22
        }

        private void PositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Positions oForm = new Positions();
            OpenMDIChild(oForm);
        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new UserMaintenance();
            OpenMDIChild(oForm);
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var oForm = new Divisions();
            OpenMDIChild(oForm);
        }

        private void ProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new ProjectMaintenance();
            OpenMDIChild(oForm);
        }

        private void PlanEstimateTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new PlanEstimateTablesMaintenance();
            OpenMDIChild(oForm);
        }

        private void tsMnuItemCostAnalysisSearch_Click(object sender, EventArgs e)
        {
            var oForm = new CostAnalysisSearch();
            OpenMDIChild(oForm);
        }

        private void ViewEstimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new EstimateView();
            OpenMDIChild(oForm);
        }
        public void ViewEstimateForm(string sJobID)
        {
            var oForm = new EstimateView();
            oForm.msJobID=sJobID;
            oForm.mbLockJobs=false;
            OpenMDIChild(oForm);
        }

        private void TakeoffTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new PlanRoomsMaintenance();
            OpenMDIChild(oForm);
        }

        private void VendorCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var oForm = new VendorCosts();
            OpenMDIChild(oForm);
        }

        private void MaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}