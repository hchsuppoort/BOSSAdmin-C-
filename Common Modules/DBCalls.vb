Option Explicit On
Imports System.Data.SqlClient
Public Class DBCalls
    '6/21/12 mrb    
    Friend Function GetDataFromSP(ByRef ds As DataSet, ByVal sStoredProc As String, ParamArray Args() As Object) As Boolean
        '6/20/12 mrb
        Dim cmd = New SqlCommand
        Dim oDataAdapter As New System.Data.SqlClient.SqlDataAdapter
        'Dim ds = New DataSet

        Try
            Dim iArgs As Integer
            Dim X As Integer

            iArgs = UBound(Args, 1)
            With cmd
                .Connection = gCN
                ' MsgBox(gCN.ConnectionString, MsgBoxStyle.Information, "GetDataFromSP")
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 300
                .CommandText = sStoredProc
            End With
            SqlCommandBuilder.DeriveParameters(cmd)
            oDataAdapter = New System.Data.SqlClient.SqlDataAdapter(cmd)

            For X = 0 To iArgs
                cmd.Parameters(X + 1).Value = Args(X)
            Next X

            oDataAdapter.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                GetDataFromSP = True
            Else
                GetDataFromSP = False
            End If
        Catch
            Err.Raise(Err.Number, "DBCalls GetDataFromSP", Err.Description)
            GetDataFromSP = False
        Finally
            oDataAdapter = Nothing
            'oDataAdapter.Dispose()
            cmd = Nothing
            'cmd.Dispose()
        End Try
    End Function
    Friend Function GetRecordsFromSP(ByRef ds As DataSet, ByVal sStoredProc As String, ParamArray Args() As Object) As Boolean
        Dim iArgs As Integer
        Dim X As Integer
        '6/20/12 mrb
        Dim cmd = New SqlCommand
        Dim oDataAdapter As New System.Data.SqlClient.SqlDataAdapter

        Try
            With cmd
                .Connection = gCN
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 300
                .CommandText = sStoredProc
            End With
            SqlCommandBuilder.DeriveParameters(cmd)
            If Not IsNothing(Args) Then
                iArgs = UBound(Args)
                For X = 0 To iArgs
                    cmd.Parameters(X + 1).Value = Args(X)
                Next X
            End If

            oDataAdapter = New System.Data.SqlClient.SqlDataAdapter(cmd)

            oDataAdapter.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                GetRecordsFromSP = True
            Else
                GetRecordsFromSP = False
            End If
        Catch
            Err.Raise(Err.Number, "DBCalls GetRecordsFromSP", Err.Description)
            GetRecordsFromSP = False
        Finally
            oDataAdapter.Dispose()
            cmd.Dispose()
        End Try
    End Function
    '    Friend Function GetReturnParamsFromSP(ByVal sStoredProc As String, ParamArray Args()) As SqlCommand
    '        On Error GoTo ErrHandler
    '        Dim iArgs As Integer
    '        iArgs = UBound(Args, 1)
    '        Dim X As Integer
    '        ' dbconnect '
    '        cmd = New SqlCommand
    '        With cmd
    '            .Connection = gCN
    '            .CommandType = CommandType.StoredProcedure
    '            ' ==========================          '
    '            ' Michele Brown  5/8/2008             '
    '            ' changed timeout from default to 300 '
    '            ' ==========================          '
    '            .CommandTimeout = 300


    '            .CommandText = sStoredProc
    '            .Parameters.Refresh()
    '        End With

    '        For X = 0 To iArgs
    '            cmd.Parameters(X + 1).Value = Args(X)
    '        Next X

    '        ds = New ADODB.Recordset
    '        With ds
    '            .CursorLocation = adUseClient
    '            .CursorType = adOpenStatic
    '            .LockType = adLockReadOnly
    '            .Open(cmd)
    '        End With
    '        GetReturnParamsFromSP = cmd

    '        ds = Nothing
    '        cmd = Nothing
    '        ' If Not pRS.EOF Then          '
    '        ' GetDataFromSP = pRS.GetRows  '
    '        ' Else                         '
    '        ' GetDataFromSP = "No Records" '
    '        ' End If                       '
    '        ' Cleanup                      '
    '        Exit Function
    'ErrHandler:
    '        Err.Raise(Err.Number, "DBCalls - GetReturnParamsFromSP", Err.Description)
    '        CleanUpDB(rs, cmd)
    '    End Function

    Friend Function GetReturnValueFromSP(ByVal sStoredProc As String, ParamArray Args() As Object) As VariantType
        Dim iArgs As Integer
        Dim X As Integer
        Dim cmd = New SqlCommand
        Dim lRtn As Long
        Try
            iArgs = UBound(Args, 1)

            With cmd
                .Connection = gCN
                .CommandType = CommandType.StoredProcedure
                .CommandTimeout = 300
                .CommandText = sStoredProc
            End With
            SqlCommandBuilder.DeriveParameters(cmd)
            For X = 0 To iArgs
                cmd.Parameters(X + 1).Value = Args(X)
            Next X
            'new way to see return value mrb 11/17/14
            Dim parameter As New SqlParameter
            parameter.SqlDbType = SqlDbType.Int
            parameter.ParameterName = "@RC"
            parameter.Direction = ParameterDirection.ReturnValue
            cmd.Parameters.Add(parameter)
            lRtn = cmd.ExecuteNonQuery()
            lRtn = cmd.Parameters("@RC").Value
            GetReturnValueFromSP = lRtn 'cmd.Parameters(0).Value
        Catch
            Err.Raise(Err.Number, "DBCalls: GetReturnValueFromSP", Err.Description)
            GetReturnValueFromSP = Err.Number
        Finally
            cmd.Dispose()
        End Try
    End Function

    '    Public Sub InsertDataBySP(ByVal sStoredProc As String, ParamArray InParams())
    '        On Error GoTo InsertDataBySPERR
    '        ' Set OC = GetObjectContext '
    '        Dim iParams As Integer
    '        iParams = UBound(InParams, 1)
    '        Dim X As Integer
    '        ' dbconnect '
    '        cmd = New SqlCommand
    '        With cmd
    '            .connection = gCN
    '            .CommandType = CommandType.StoredProcedure
    '            ' ==========================          '
    '            ' Michele Brown  5/8/2008             '
    '            ' changed timeout from default to 300 '
    '            ' ==========================          '
    '            .CommandTimeout = 300


    '            .CommandText = sStoredProc
    '            .Parameters.Refresh()
    '        End With

    '        For X = 0 To iParams
    '            cmd.Parameters(X + 1).Value = InParams(X)
    '        Next X
    '        cmd.Execute()
    '        ' oc.SetComplete '
    '        CleanUpDB(rs, cmd)
    '        Exit Sub

    'InsertDataBySPERR:
    '        ' oc.SetAbort '
    '        Err.Raise(Err.Number, "DLL = SelectionsMgr, CLASS = DBCalls, METHOD = InsertDataBySP", Err.Description)
    '        CleanUpDB(rs, cmd)
    '    End Sub


    '    Public Sub UpdateDataBySP(ByVal sStoredProc As String, ParamArray UpdateData())
    '        On Error GoTo UpdateDataBySPERR
    '        ' Set OC = GetObjectContext '
    '        ' dbconnect                 '
    '        cmd = New SqlCommand
    '        With cmd
    '            .connection = gCN
    '            .CommandType = CommandType.StoredProcedure
    '            ' ==========================          '
    '            ' Michele Brown  5/8/2008             '
    '            ' changed timeout from default to 300 '
    '            ' ==========================          '
    '            .CommandTimeout = 300


    '            .CommandText = sStoredProc
    '            .Parameters.Refresh()
    '        End With
    '        If Not IsMissing(UpdateData) Then
    '            Dim iCtr As Integer
    '            iCtr = UBound(UpdateData, 1)
    '            Dim X As Integer

    '            For X = 0 To iCtr
    '                If Not IsMissing(UpdateData(X)) Then
    '                    If Not IsNull(UpdateData(X)) Then
    '                        cmd.Parameters(X + 1).Value = UpdateData(X)
    '                    End If
    '                End If
    '            Next X
    '        End If
    '        cmd.Execute()

    '        ' OC.SetComplete '
    '        CleanUpDB(rs, cmd)
    '        Exit Sub

    'UpdateDataBySPERR:
    '        ' OC.SetAbort '
    '        Err.Raise(Err.Number, "DBCalls", Err.Description)
    '        CleanUpDB(rs, cmd)
    '    End Sub

    ' Public Sub DeleteDataBySP(ByVal sStoredProc As String, ParamArray DeleteData()) '
    ' On Error GoTo DeleteDataBySPERR                                                 '
    ' ' Set OC = GetObjectContext                                                     '
    ' ' dbconnect                                                                     '
    ' Set cmd = New sqlcommand                                                     '
    ' With cmd                                                                        '
    ' .connection = gCN                                                         '
    ' .CommandType = CommandType.StoredProcedure                                                  '
    ' .CommandText = sStoredProc                                                      '
    ' .Parameters.Refresh                                                             '
    ' End With                                                                        '
    ' If Not IsMissing(DeleteData) Then                                               '
    ' Dim iCtr As Integer                                                             '
    ' iCtr = UBound(DeleteData, 1)                                                    '
    ' Dim x As Integer                                                                '
    '                                                                                 '
    ' For x = 0 To iCtr                                                               '
    ' If Not IsMissing(DeleteData(x)) Then                                            '
    ' cmd.Parameters(x + 1).Value = DeleteData(x)                                     '
    ' End If                                                                          '
    ' Next x                                                                          '
    ' End If                                                                          '
    ' cmd.Execute                                                                     '
    ' ' OC.SetComplete                                                                '
    ' CleanUpDB rs, cmd                                                               '
    ' Exit Sub                                                                        '
    '                                                                                 '
    ' DeleteDataBySPERR:                                                              '
    ' ' OC.SetAbort                                                                   '
    ' Err.Raise Err.Number, "DBCalls", Err.Description                                '
    ' CleanUpDB rs, cmd                                                               '
    ' End Sub                                                                         '
    '    Public Function GetOutputParamFromSP(ByVal sStoredProc As String, ByVal sOutputParam As String, ParamArray InputParams()) As Object
    '        On Error GoTo GetOutputParamFromSPERR
    '        ' dbconnect '
    '        cmd = New SqlCommand
    '        With cmd
    '            .connection = gCN
    '            .CommandType = CommandType.StoredProcedure
    '            ' ==========================          '
    '            ' Michele Brown  5/8/2008             '
    '            ' changed timeout from default to 300 '
    '            ' ==========================          '
    '            .CommandTimeout = 300


    '            .CommandText = sStoredProc
    '            .Parameters.Refresh()
    '        End With
    '        If Not IsMissing(InputParams) Then
    '            Dim iArgs As Integer
    '            iArgs = UBound(InputParams, 1)
    '            Dim X As Integer
    '            For X = 0 To iArgs
    '                cmd.Parameters(X + 1).Value = InputParams(X)
    '            Next X
    '        End If
    '        cmd.Execute()
    '        GetOutputParamFromSP = cmd.Parameters(sOutputParam).Value
    '        CleanUpDB(rs, cmd)
    '        Exit Function

    'GetOutputParamFromSPERR:
    '        Err.Raise(Err.Number, "DBCalls", Err.Description)
    '        CleanUpDB(rs, cmd)
    '    End Function
    '    Friend Function GetReturnFromSP(ByVal sStoredProc As String, ParamArray Args()) As String
    '        ' dbconnect '
    '        cmd = New SqlCommand
    '        With cmd
    '            .connection = gCN
    '            .CommandType = CommandType.StoredProcedure
    '            ' ==========================          '
    '            ' Michele Brown  5/8/2008             '
    '            ' changed timeout from default to 300 '
    '            ' ==========================          '
    '            .CommandTimeout = 300


    '            .CommandText = sStoredProc
    '            .Parameters.Refresh()
    '        End With
    '        If Not IsMissing(Args) Then
    '            Dim iArgs As Integer
    '            iArgs = UBound(Args, 1)
    '            Dim X As Integer

    '            For X = 0 To iArgs
    '                cmd.Parameters(X + 1).Value = Args(X)
    '            Next X
    '        End If

    '        cmd.Execute()
    '        GetReturnFromSP = cmd.Parameters(0).Value
    '        CleanUpDB(rs, cmd)
    '        Exit Function

    'GetDataFromSPERR:
    '        Err.Raise(Err.Number, "DBCalls", Err.Description)
    '        CleanUpDB(rs, cmd)
    '    End Function

End Class
