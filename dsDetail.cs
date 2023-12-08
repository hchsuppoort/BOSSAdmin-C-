using System.Data;

namespace BossAdmin
{
    public partial class dsDetail
    {
        public partial class spPlanEstimatesGetDataTable
        {

            private void spPlanEstimatesGetDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
            {
                if ((e.Column.ColumnName??"")==(ActivityCodeColumn.ColumnName??""))
                {
                    // Add user code here
                }

            }

            private void spPlanEstimatesGetDataTable_RowChanged(object sender, DataRowChangeEventArgs e)
            {
                // '            e.Row.Item("UpdatedBy") = gsUserID
                // Me. = e.Row.Item("PlanEstimateID")
            }
        }

    }

    namespace dsDetailTableAdapters
    {

        public partial class spPlanEstimatesGetTableAdapter
        {

        }
    }
}