﻿// ------------------------------------------------------------------------------
// <auto-generated>
// This code was generated from a template.
// 
// Manual changes to this file may cause unexpected behavior in your application.
// Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace BossAdmin
{

    public partial class HCHDataEntities : DbContext
    {

        public HCHDataEntities() : base("name=HCHDataEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }


        public virtual ObjectResult<spGetAlphaCodes_Result> spGetAlphaCodes()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAlphaCodes_Result>("spGetAlphaCodes");
        }

        // Public Overridable Function spGetProjectsForPlan(planID As String) As ObjectResult(Of spGetProjectsForPlan_Result)
        // Dim planIDParameter As ObjectParameter = If(planID IsNot Nothing, New ObjectParameter("PlanID", planID), New ObjectParameter("PlanID", GetType(String)))

        // Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spGetProjectsForPlan_Result)("spGetProjectsForPlan", planIDParameter)
        // End Function

        public virtual ObjectResult<spGetTaxDistrictList_Result> spGetTaxDistrictList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTaxDistrictList_Result>("spGetTaxDistrictList");
        }

        public virtual ObjectResult<spGetVendorsInUse_Result> spGetVendorsInUse()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetVendorsInUse_Result>("spGetVendorsInUse");
        }

        public virtual ObjectResult<spGetOpenProjects_Result> spGetOpenProjects()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetOpenProjects_Result>("spGetOpenProjects");
        }

    }
}