using System;

namespace BossAdmin
{
    public partial class EstimateView
    {
        internal string msJobID;
        internal bool mbLockJobs = false;

        public EstimateView()
        {
            InitializeComponent();
        }
        private void EstimateView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HCHDataQADataSet1.spGetAllJobs' table. You can move, or remove it, as needed.
            SpGetAllJobsTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
            SpGetAllJobsTableAdapter.Fill(HCHDataQADataSet1.spGetAllJobs);
            if (msJobID!=default&!string.IsNullOrEmpty(msJobID))
            {
                // ucJobs.Text = msJobID
                ucJobs.SelectedText=msJobID;
            }

            else
            {
                ucJobs.Text="";
            }
            ucJobs.Enabled=!mbLockJobs;
        }

        private void ucJobs_RowSelected(object sender, Infragistics.Win.UltraWinGrid.RowSelectedEventArgs e)
        {
            if (e.Row is not null)
            {
                msJobID=e.Row.Cells["JobID"].Text;
                SpGetJobDetailsTableAdapter.Connection.ConnectionString=modGlobals.gsConnectionString;
//                SpGetJobDetailsTableAdapter.Fill(HCHDataQAJobDetails.Tables[0], msJobID);
                SpGetJobDetailsTableAdapter.Fill(HCHDataQAJobDetails.spGetJobDetails, msJobID);

                ulPlanID.Text=e.Row.Cells["PlanID"].Text;
            }
        }
    }
}