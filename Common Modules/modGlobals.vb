Option Explicit On
Option Strict Off
Option Infer On
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.Generic
Module modGlobals
    Public msdbServer As String = ""
    Public msConnection As String = ""
    Public giRank As Integer = 0
    Public giPositionID As Integer = 0
    'Public gCN As New SqlConnection
    Public gsVersion As String = ""
    Public gsDatabase As String = ""
    'Public gCN As New SqlConnection
    'Public gCNBoss As New SqlConnection
    'Public mCNLogs As New SqlConnection
    Public gCN As SqlConnection
    Public gCNBoss As SqlConnection
    Public mCNLogs As SqlConnection

    Public msConnectionBoss As String = ""
    Public gsUserID As String = ""
    Public gsRank As String = ""
    Public giSecurityID As Integer
    Public gsUserEmail As String = ""
    Public dsSecurity As DataSet
    Public gSecurityList As New List(Of SecurityMatrix)
    Public gbValidUser As Boolean = False
    Public gsCostAnalysisData As DataSet
    Public gsConnectionString As String
    Public gsPathCost As String
    Public gsUpdateFolder As String ' 9/8/23 mrb
    'Private Function FindSecurity()
    '    gSecurityList.Find(
    'End Function


End Module
