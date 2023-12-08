using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace BossAdmin
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class mdiMain : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMain));
            MenuStrip1=new MenuStrip();
            EstimatingMaintenanceToolStripMenuItem=new ToolStripMenuItem();
            PlanEstimateTablesToolStripMenuItem=new ToolStripMenuItem();
            PlanEstimateTablesToolStripMenuItem.Click+=new EventHandler(PlanEstimateTablesToolStripMenuItem_Click);
            TakeoffTablesToolStripMenuItem=new ToolStripMenuItem();
            TakeoffTablesToolStripMenuItem.Click+=new EventHandler(TakeoffTablesToolStripMenuItem_Click);
            ViewEstimateToolStripMenuItem=new ToolStripMenuItem();
            ViewEstimateToolStripMenuItem.Click+=new EventHandler(ViewEstimateToolStripMenuItem_Click);
            MaintenanceToolStripMenuItem=new ToolStripMenuItem();
            MaintenanceToolStripMenuItem.Click+=new EventHandler(MaintenanceToolStripMenuItem_Click);
            DivisionsToolstripMenu=new ToolStripMenuItem();
            DivisionsToolstripMenu.Click+=new EventHandler(ToolStripMenuItem2_Click);
            MilestonesToolStripMenuItem=new ToolStripMenuItem();
            MilestonesToolStripMenuItem.Click+=new EventHandler(MilestonesToolStripMenuItem_Click);
            NotificationsToolStripMenuItem=new ToolStripMenuItem();
            NotificationsToolStripMenuItem.Click+=new EventHandler(NotificationsToolStripMenuItem_Click);
            PositionsToolStripMenuItem=new ToolStripMenuItem();
            PositionsToolStripMenuItem.Click+=new EventHandler(PositionsToolStripMenuItem_Click);
            ProjectsToolStripMenuItem=new ToolStripMenuItem();
            ProjectsToolStripMenuItem.Click+=new EventHandler(ProjectsToolStripMenuItem_Click);
            SecurityToolStripMenuItem=new ToolStripMenuItem();
            UsersToolStripMenuItem=new ToolStripMenuItem();
            UsersToolStripMenuItem.Click+=new EventHandler(UsersToolStripMenuItem_Click);
            VPOReasonsToolStripMenuItem=new ToolStripMenuItem();
            VPOReasonsToolStripMenuItem.Click+=new EventHandler(VPOReasonsToolStripMenuItem_Click);
            VendorsToolStripMenuItem=new ToolStripMenuItem();
            VendorCostToolStripMenuItem=new ToolStripMenuItem();
            VendorCostToolStripMenuItem.Click+=new EventHandler(VendorCostToolStripMenuItem_Click);
            tsMnuItemCostAnalysis=new ToolStripMenuItem();
            tsMnuItemCostAnalysisSearch=new ToolStripMenuItem();
            tsMnuItemCostAnalysisSearch.Click+=new EventHandler(tsMnuItemCostAnalysisSearch_Click);
            tsMnuItemCostAnalysisReports=new ToolStripMenuItem();
            WindowMaintenanceToolStripItem=new ToolStripMenuItem();
            HelpToolStripMenuItem=new ToolStripMenuItem();
            ContentsToolStripMenuItem=new ToolStripMenuItem();
            IndexToolStripMenuItem=new ToolStripMenuItem();
            SearchToolStripMenuItem=new ToolStripMenuItem();
            toolStripSeparator5=new ToolStripSeparator();
            AboutToolStripMenuItem=new ToolStripMenuItem();
            AppStylistRuntime1=new Infragistics.Win.AppStyling.Runtime.AppStylistRuntime(components);
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip1
            // 
            MenuStrip1.GripMargin=new Padding(2, 2, 0, 2);
            MenuStrip1.ImageScalingSize=new Size(20, 20);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { EstimatingMaintenanceToolStripMenuItem, MaintenanceToolStripMenuItem, VendorsToolStripMenuItem, tsMnuItemCostAnalysis, WindowMaintenanceToolStripItem, HelpToolStripMenuItem });
            MenuStrip1.Location=new Point(0, 0);
            MenuStrip1.MdiWindowListItem=WindowMaintenanceToolStripItem;
            MenuStrip1.Name="MenuStrip1";
            MenuStrip1.Padding=new Padding(16, 4, 0, 4);
            MenuStrip1.Size=new Size(2103, 56);
            MenuStrip1.TabIndex=1;
            MenuStrip1.Text="MenuStrip1";
            // 
            // EstimatingMaintenanceToolStripMenuItem
            // 
            EstimatingMaintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PlanEstimateTablesToolStripMenuItem, TakeoffTablesToolStripMenuItem, ViewEstimateToolStripMenuItem });
            EstimatingMaintenanceToolStripMenuItem.Name="EstimatingMaintenanceToolStripMenuItem";
            EstimatingMaintenanceToolStripMenuItem.Size=new Size(379, 48);
            EstimatingMaintenanceToolStripMenuItem.Text="Maintenance - Estimating";
            // 
            // PlanEstimateTablesToolStripMenuItem
            // 
            PlanEstimateTablesToolStripMenuItem.Name="PlanEstimateTablesToolStripMenuItem";
            PlanEstimateTablesToolStripMenuItem.Size=new Size(450, 54);
            PlanEstimateTablesToolStripMenuItem.Text="Plan Estimate Tables";
            // 
            // TakeoffTablesToolStripMenuItem
            // 
            TakeoffTablesToolStripMenuItem.Name="TakeoffTablesToolStripMenuItem";
            TakeoffTablesToolStripMenuItem.Size=new Size(450, 54);
            TakeoffTablesToolStripMenuItem.Text="Take-off Tables";
            // 
            // ViewEstimateToolStripMenuItem
            // 
            ViewEstimateToolStripMenuItem.Name="ViewEstimateToolStripMenuItem";
            ViewEstimateToolStripMenuItem.Size=new Size(450, 54);
            ViewEstimateToolStripMenuItem.Text="View Estimate";
            // 
            // MaintenanceToolStripMenuItem
            // 
            MaintenanceToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DivisionsToolstripMenu, MilestonesToolStripMenuItem, NotificationsToolStripMenuItem, PositionsToolStripMenuItem, ProjectsToolStripMenuItem, SecurityToolStripMenuItem, UsersToolStripMenuItem, VPOReasonsToolStripMenuItem });
            MaintenanceToolStripMenuItem.Name="MaintenanceToolStripMenuItem";
            MaintenanceToolStripMenuItem.Size=new Size(431, 48);
            MaintenanceToolStripMenuItem.Text="Maintenance - Lookup Tables";
            // 
            // DivisionsToolstripMenu
            // 
            DivisionsToolstripMenu.Name="DivisionsToolstripMenu";
            DivisionsToolstripMenu.Size=new Size(448, 54);
            DivisionsToolstripMenu.Text="Divisions";
            // 
            // MilestonesToolStripMenuItem
            // 
            MilestonesToolStripMenuItem.Name="MilestonesToolStripMenuItem";
            MilestonesToolStripMenuItem.Size=new Size(448, 54);
            MilestonesToolStripMenuItem.Text="Milestones";
            // 
            // NotificationsToolStripMenuItem
            // 
            NotificationsToolStripMenuItem.Name="NotificationsToolStripMenuItem";
            NotificationsToolStripMenuItem.Size=new Size(448, 54);
            NotificationsToolStripMenuItem.Text="Notifications";
            NotificationsToolStripMenuItem.Visible=false;
            // 
            // PositionsToolStripMenuItem
            // 
            PositionsToolStripMenuItem.Name="PositionsToolStripMenuItem";
            PositionsToolStripMenuItem.Size=new Size(448, 54);
            PositionsToolStripMenuItem.Text="Positions";
            // 
            // ProjectsToolStripMenuItem
            // 
            ProjectsToolStripMenuItem.Name="ProjectsToolStripMenuItem";
            ProjectsToolStripMenuItem.Size=new Size(448, 54);
            ProjectsToolStripMenuItem.Text="Projects";
            // 
            // SecurityToolStripMenuItem
            // 
            SecurityToolStripMenuItem.Name="SecurityToolStripMenuItem";
            SecurityToolStripMenuItem.Size=new Size(448, 54);
            SecurityToolStripMenuItem.Text="Security";
            SecurityToolStripMenuItem.Visible=false;
            // 
            // UsersToolStripMenuItem
            // 
            UsersToolStripMenuItem.Name="UsersToolStripMenuItem";
            UsersToolStripMenuItem.Size=new Size(448, 54);
            UsersToolStripMenuItem.Text="Users";
            // 
            // VPOReasonsToolStripMenuItem
            // 
            VPOReasonsToolStripMenuItem.Name="VPOReasonsToolStripMenuItem";
            VPOReasonsToolStripMenuItem.Size=new Size(448, 54);
            VPOReasonsToolStripMenuItem.Text="VPO Reasons";
            // 
            // VendorsToolStripMenuItem
            // 
            VendorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { VendorCostToolStripMenuItem });
            VendorsToolStripMenuItem.Name="VendorsToolStripMenuItem";
            VendorsToolStripMenuItem.Size=new Size(151, 48);
            VendorsToolStripMenuItem.Text="Vendors";
            // 
            // VendorCostToolStripMenuItem
            // 
            VendorCostToolStripMenuItem.Name="VendorCostToolStripMenuItem";
            VendorCostToolStripMenuItem.Size=new Size(553, 54);
            VendorCostToolStripMenuItem.Text="Vendor Costs and Contracts";
            // 
            // tsMnuItemCostAnalysis
            // 
            tsMnuItemCostAnalysis.DropDownItems.AddRange(new ToolStripItem[] { tsMnuItemCostAnalysisSearch, tsMnuItemCostAnalysisReports });
            tsMnuItemCostAnalysis.Name="tsMnuItemCostAnalysis";
            tsMnuItemCostAnalysis.Size=new Size(216, 48);
            tsMnuItemCostAnalysis.Text="Cost Analysis";
            // 
            // tsMnuItemCostAnalysisSearch
            // 
            tsMnuItemCostAnalysisSearch.Name="tsMnuItemCostAnalysisSearch";
            tsMnuItemCostAnalysisSearch.Size=new Size(468, 54);
            tsMnuItemCostAnalysisSearch.Text="Cost Analysis Search";
            // 
            // tsMnuItemCostAnalysisReports
            // 
            tsMnuItemCostAnalysisReports.Name="tsMnuItemCostAnalysisReports";
            tsMnuItemCostAnalysisReports.Size=new Size(468, 54);
            tsMnuItemCostAnalysisReports.Text="Cost Analysis Reports";
            // 
            // WindowMaintenanceToolStripItem
            // 
            WindowMaintenanceToolStripItem.Name="WindowMaintenanceToolStripItem";
            WindowMaintenanceToolStripItem.Size=new Size(152, 48);
            WindowMaintenanceToolStripItem.Text="Window";
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ContentsToolStripMenuItem, IndexToolStripMenuItem, SearchToolStripMenuItem, toolStripSeparator5, AboutToolStripMenuItem });
            HelpToolStripMenuItem.Name="HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size=new Size(104, 48);
            HelpToolStripMenuItem.Text="&Help";
            // 
            // ContentsToolStripMenuItem
            // 
            ContentsToolStripMenuItem.Name="ContentsToolStripMenuItem";
            ContentsToolStripMenuItem.Size=new Size(304, 54);
            ContentsToolStripMenuItem.Text="&Contents";
            // 
            // IndexToolStripMenuItem
            // 
            IndexToolStripMenuItem.Name="IndexToolStripMenuItem";
            IndexToolStripMenuItem.Size=new Size(304, 54);
            IndexToolStripMenuItem.Text="&Index";
            // 
            // SearchToolStripMenuItem
            // 
            SearchToolStripMenuItem.Name="SearchToolStripMenuItem";
            SearchToolStripMenuItem.Size=new Size(304, 54);
            SearchToolStripMenuItem.Text="&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name="toolStripSeparator5";
            toolStripSeparator5.Size=new Size(301, 6);
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.Name="AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size=new Size(304, 54);
            AboutToolStripMenuItem.Text="&About...";
            // 
            // mdiMain
            // 
            AutoScaleDimensions=new SizeF(16.0f, 31.0f);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.White;
            BackgroundImage=(Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout=ImageLayout.Stretch;
            ClientSize=new Size(2103, 1173);
            Controls.Add(MenuStrip1);
            IsMdiContainer=true;
            MainMenuStrip=MenuStrip1;
            Margin=new Padding(8);
            Name="mdiMain";
            Text="BOSSAdmin";
            WindowState=FormWindowState.Maximized;
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            Load+=new EventHandler(mdiMain_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem MaintenanceToolStripMenuItem;
        internal ToolStripMenuItem MilestonesToolStripMenuItem;
        internal ToolStripMenuItem NotificationsToolStripMenuItem;
        internal ToolStripMenuItem PositionsToolStripMenuItem;
        internal ToolStripMenuItem SecurityToolStripMenuItem;
        internal ToolStripMenuItem UsersToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem ContentsToolStripMenuItem;
        internal ToolStripMenuItem IndexToolStripMenuItem;
        internal ToolStripMenuItem SearchToolStripMenuItem;
        internal ToolStripSeparator toolStripSeparator5;
        internal ToolStripMenuItem AboutToolStripMenuItem;
        internal ToolStripMenuItem VPOReasonsToolStripMenuItem;
        internal ToolStripMenuItem WindowMaintenanceToolStripItem;
        internal ToolStripMenuItem DivisionsToolstripMenu;
        internal ToolStripMenuItem ProjectsToolStripMenuItem;
        internal Infragistics.Win.AppStyling.Runtime.AppStylistRuntime AppStylistRuntime1;
        internal ToolStripMenuItem EstimatingMaintenanceToolStripMenuItem;
        internal ToolStripMenuItem PlanEstimateTablesToolStripMenuItem;
        internal ToolStripMenuItem TakeoffTablesToolStripMenuItem;
        internal ToolStripMenuItem tsMnuItemCostAnalysis;
        internal ToolStripMenuItem tsMnuItemCostAnalysisSearch;
        internal ToolStripMenuItem tsMnuItemCostAnalysisReports;
        internal ToolStripMenuItem ViewEstimateToolStripMenuItem;
        internal ToolStripMenuItem VendorsToolStripMenuItem;
        internal ToolStripMenuItem VendorCostToolStripMenuItem;
    }
}