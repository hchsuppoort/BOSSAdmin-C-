﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class HCHDataEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=HCHDataEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function spGetAlphaCodes() As ObjectResult(Of spGetAlphaCodes_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spGetAlphaCodes_Result)("spGetAlphaCodes")
    End Function

    'Public Overridable Function spGetProjectsForPlan(planID As String) As ObjectResult(Of spGetProjectsForPlan_Result)
    '    Dim planIDParameter As ObjectParameter = If(planID IsNot Nothing, New ObjectParameter("PlanID", planID), New ObjectParameter("PlanID", GetType(String)))

    '    Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spGetProjectsForPlan_Result)("spGetProjectsForPlan", planIDParameter)
    'End Function

    Public Overridable Function spGetTaxDistrictList() As ObjectResult(Of spGetTaxDistrictList_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spGetTaxDistrictList_Result)("spGetTaxDistrictList")
    End Function

    Public Overridable Function spGetVendorsInUse() As ObjectResult(Of spGetVendorsInUse_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spGetVendorsInUse_Result)("spGetVendorsInUse")
    End Function

    Public Overridable Function spGetOpenProjects() As ObjectResult(Of spGetOpenProjects_Result)
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of spGetOpenProjects_Result)("spGetOpenProjects")
    End Function

End Class
