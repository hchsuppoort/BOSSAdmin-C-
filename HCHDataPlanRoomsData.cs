using System;

namespace BossAdmin
{
    public partial class HCHDataPlanRoomsData
    {
        public partial class SpPlanRoomsGetTableAdapter
        {
            public string ConnectionString
            {
                get
                {
                    return Connection.ConnectionString;
                }
                set
                {
                    Connection.ConnectionString=value;
                }
            }

            private object Connection { get; set; }

        }

        private void HCHDataPlanRoomsData_Initialized(object sender, EventArgs e)
        {

        }
    }
}