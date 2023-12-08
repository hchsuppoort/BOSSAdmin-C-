Imports System
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class DataHelper

#Region " Constructor"

    Public Sub New(ByVal mvarDatabaseFileName As String)

        Me.mvarDatabaseFileName = mvarDatabaseFileName

    End Sub

#End Region   'Constructor

#Region " Constants"

    Private Const connectionStringTemplate As String = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source={0};Extended Properties="""";Jet OLEDB:System database="""";" & _
        "Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Engine Type=" & _
        "4;Jet OLEDB:Database Locking Mode=0;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLED" & _
        "B:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLEDB:Create" & _
        " System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't Copy Loc" & _
        "ale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet OLEDB:SF" & _
        "P=False"

    Private Const selectCommandTemplate As String = "SELECT * FROM ({0})"

#End Region   'Constants

#Region " Private Members"

    Private mvarOleDbConnection As OleDbConnection = Nothing
    Private mvarDatabaseFileName As String = String.Empty

#End Region   'Private Members

#Region " Private Methods"

#Region " DataPath"
    ' <summary>
    ' Path to the data installed by the install.
    ' </summary>
    Private Shared ReadOnly Property DataPath() As String
        Get
            Return Common.DataPath
        End Get
    End Property

#End Region   ''DataPath

#Region " GetConnectionString"

    Private Function GetConnectionsString(ByVal mvarDatabaseFileName As String) As String
        Return String.Format(connectionStringTemplate, System.IO.Path.Combine(DataPath, mvarDatabaseFileName))
    End Function

#End Region   'GetConnectionString

#End Region   'Private Methods		

#Region " Private Properties"

#Region " OleDbConnection"
    Private ReadOnly Property OleDbConnection() As OleDbConnection
        Get
            If (Me.mvarOleDbConnection Is Nothing) Then
                Me.mvarOleDbConnection = New OleDbConnection(GetConnectionsString(mvarDatabaseFileName))
            End If

            Return Me.mvarOleDbConnection
        End Get
    End Property
#End Region   'OleDbConnection		

#End Region   'Private Properties

#Region " Public Methods"

#Region " GetTable"

    Public Function GetTable(ByVal tableName As String) As DataTable
        Try
            Dim selectCommandText As String = String.Format(selectCommandTemplate, tableName)
            Dim dataAdapter As OleDbDataAdapter = New OleDbDataAdapter(selectCommandText, Me.OleDbConnection)
            Dim table As DataTable = New DataTable(tableName)
            dataAdapter.Fill(table)
            Return table
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error getting data")
        End Try

        Return Nothing
    End Function

#End Region   'GetTable

#End Region   'Public Methods

End Class
