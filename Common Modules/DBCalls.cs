using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BossAdmin
{
    public class DBCalls
    {
        // 6/21/12 mrb    
        internal bool GetDataFromSP(ref DataSet ds, string sStoredProc, params object[] Args)
        {
            bool GetDataFromSPRet = default;
            // 6/20/12 mrb
            var cmd = new SqlCommand();
            var oDataAdapter = new SqlDataAdapter();
            // Dim ds = New DataSet

            try
            {
                int iArgs;
                int X;

                iArgs=Information.UBound(Args, 1);
                {
                    ref var withBlock = ref cmd;
                    withBlock.Connection=modGlobals.gCN;
                    // MsgBox(gCN.ConnectionString, MsgBoxStyle.Information, "GetDataFromSP")
                    withBlock.CommandType=CommandType.StoredProcedure;
                    withBlock.CommandTimeout=300;
                    withBlock.CommandText=sStoredProc;
                }
                SqlCommandBuilder.DeriveParameters(cmd);
                oDataAdapter=new SqlDataAdapter(cmd);

                var loopTo = iArgs;
                for (X=0; X<=loopTo; X++)
                    cmd.Parameters[X+1].Value=Args[X];

                oDataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count>0)
                {
                    GetDataFromSPRet=true;
                }
                else
                {
                    GetDataFromSPRet=false;
                }
            }
            catch
            {
                Information.Err().Raise(Information.Err().Number, "DBCalls GetDataFromSP", Information.Err().Description);
                GetDataFromSPRet=false;
            }
            finally
            {
                oDataAdapter=null;
                // oDataAdapter.Dispose()
                cmd=null;
                // cmd.Dispose()
            }

            return GetDataFromSPRet;
        }
        internal bool GetRecordsFromSP(ref DataSet ds, string sStoredProc, params object[] Args)
        {
            bool GetRecordsFromSPRet = default;
            int iArgs;
            int X;
            // 6/20/12 mrb
            var cmd = new SqlCommand();
            var oDataAdapter = new SqlDataAdapter();

            try
            {
                cmd.Connection=modGlobals.gCN;
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.CommandTimeout=300;
                cmd.CommandText=sStoredProc;
                SqlCommandBuilder.DeriveParameters(cmd);
                if (!(Args==null))
                {
                    iArgs=Information.UBound(Args);
                    var loopTo = iArgs;
                    for (X=0; X<=loopTo; X++)
                        cmd.Parameters[X+1].Value=Args[X];
                }

                oDataAdapter=new SqlDataAdapter(cmd);

                oDataAdapter.Fill(ds);

                if (ds.Tables[0].Rows.Count>0)
                {
                    GetRecordsFromSPRet=true;
                }
                else
                {
                    GetRecordsFromSPRet=false;
                }
            }
            catch
            {
                Information.Err().Raise(Information.Err().Number, "DBCalls GetRecordsFromSP", Information.Err().Description);
                GetRecordsFromSPRet=false;
            }
            finally
            {
                oDataAdapter.Dispose();
                cmd.Dispose();
            }

            return GetRecordsFromSPRet;
        }
        // Friend Function GetReturnParamsFromSP(ByVal sStoredProc As String, ParamArray Args()) As SqlCommand
        // On Error GoTo ErrHandler
        // Dim iArgs As Integer
        // iArgs = UBound(Args, 1)
        // Dim X As Integer
        // ' dbconnect '
        // cmd = New SqlCommand
        // With cmd
        // .Connection = gCN
        // .CommandType = CommandType.StoredProcedure
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300


        // .CommandText = sStoredProc
        // .Parameters.Refresh()
        // End With

        // For X = 0 To iArgs
        // cmd.Parameters(X + 1).Value = Args(X)
        // Next X

        // ds = New ADODB.Recordset
        // With ds
        // .CursorLocation = adUseClient
        // .CursorType = adOpenStatic
        // .LockType = adLockReadOnly
        // .Open(cmd)
        // End With
        // GetReturnParamsFromSP = cmd

        // ds = Nothing
        // cmd = Nothing
        // ' If Not pRS.EOF Then          '
        // ' GetDataFromSP = pRS.GetRows  '
        // ' Else                         '
        // ' GetDataFromSP = "No Records" '
        // ' End If                       '
        // ' Cleanup                      '
        // Exit Function
        // ErrHandler:
        // Err.Raise(Err.Number, "DBCalls - GetReturnParamsFromSP", Err.Description)
        // CleanUpDB(rs, cmd)
        // End Function

        internal VariantType GetReturnValueFromSP(string sStoredProc, params object[] Args)
        {
            VariantType GetReturnValueFromSPRet = default;
            int iArgs;
            int X;
            var cmd = new SqlCommand();
            long lRtn;
            try
            {
                iArgs=Information.UBound(Args, 1);

                cmd.Connection=modGlobals.gCN;
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.CommandTimeout=300;
                cmd.CommandText=sStoredProc;
                SqlCommandBuilder.DeriveParameters(cmd);
                var loopTo = iArgs;
                for (X=0; X<=loopTo; X++)
                    cmd.Parameters[X+1].Value=Args[X];
                // new way to see return value mrb 11/17/14
                var parameter = new SqlParameter();
                parameter.SqlDbType=SqlDbType.Int;
                parameter.ParameterName="@RC";
                parameter.Direction=ParameterDirection.ReturnValue;
                cmd.Parameters.Add(parameter);
                lRtn=cmd.ExecuteNonQuery();
                lRtn=Conversions.ToLong(cmd.Parameters["@RC"].Value);
                GetReturnValueFromSPRet=(VariantType)lRtn; // cmd.Parameters(0).Value
            }
            catch
            {
                Information.Err().Raise(Information.Err().Number, "DBCalls: GetReturnValueFromSP", Information.Err().Description);
                GetReturnValueFromSPRet=(VariantType)Information.Err().Number;
            }
            finally
            {
                cmd.Dispose();
            }

            return GetReturnValueFromSPRet;
        }

        // Public Sub InsertDataBySP(ByVal sStoredProc As String, ParamArray InParams())
        // On Error GoTo InsertDataBySPERR
        // ' Set OC = GetObjectContext '
        // Dim iParams As Integer
        // iParams = UBound(InParams, 1)
        // Dim X As Integer
        // ' dbconnect '
        // cmd = New SqlCommand
        // With cmd
        // .connection = gCN
        // .CommandType = CommandType.StoredProcedure
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300


        // .CommandText = sStoredProc
        // .Parameters.Refresh()
        // End With

        // For X = 0 To iParams
        // cmd.Parameters(X + 1).Value = InParams(X)
        // Next X
        // cmd.Execute()
        // ' oc.SetComplete '
        // CleanUpDB(rs, cmd)
        // Exit Sub

        // InsertDataBySPERR:
        // ' oc.SetAbort '
        // Err.Raise(Err.Number, "DLL = SelectionsMgr, CLASS = DBCalls, METHOD = InsertDataBySP", Err.Description)
        // CleanUpDB(rs, cmd)
        // End Sub


        // Public Sub UpdateDataBySP(ByVal sStoredProc As String, ParamArray UpdateData())
        // On Error GoTo UpdateDataBySPERR
        // ' Set OC = GetObjectContext '
        // ' dbconnect                 '
        // cmd = New SqlCommand
        // With cmd
        // .connection = gCN
        // .CommandType = CommandType.StoredProcedure
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300


        // .CommandText = sStoredProc
        // .Parameters.Refresh()
        // End With
        // If Not IsMissing(UpdateData) Then
        // Dim iCtr As Integer
        // iCtr = UBound(UpdateData, 1)
        // Dim X As Integer

        // For X = 0 To iCtr
        // If Not IsMissing(UpdateData(X)) Then
        // If Not IsNull(UpdateData(X)) Then
        // cmd.Parameters(X + 1).Value = UpdateData(X)
        // End If
        // End If
        // Next X
        // End If
        // cmd.Execute()

        // ' OC.SetComplete '
        // CleanUpDB(rs, cmd)
        // Exit Sub

        // UpdateDataBySPERR:
        // ' OC.SetAbort '
        // Err.Raise(Err.Number, "DBCalls", Err.Description)
        // CleanUpDB(rs, cmd)
        // End Sub

        // Public Sub DeleteDataBySP(ByVal sStoredProc As String, ParamArray DeleteData()) '
        // On Error GoTo DeleteDataBySPERR                                                 '
        // ' Set OC = GetObjectContext                                                     '
        // ' dbconnect                                                                     '
        // Set cmd = New sqlcommand                                                     '
        // With cmd                                                                        '
        // .connection = gCN                                                         '
        // .CommandType = CommandType.StoredProcedure                                                  '
        // .CommandText = sStoredProc                                                      '
        // .Parameters.Refresh                                                             '
        // End With                                                                        '
        // If Not IsMissing(DeleteData) Then                                               '
        // Dim iCtr As Integer                                                             '
        // iCtr = UBound(DeleteData, 1)                                                    '
        // Dim x As Integer                                                                '
        // '
        // For x = 0 To iCtr                                                               '
        // If Not IsMissing(DeleteData(x)) Then                                            '
        // cmd.Parameters(x + 1).Value = DeleteData(x)                                     '
        // End If                                                                          '
        // Next x                                                                          '
        // End If                                                                          '
        // cmd.Execute                                                                     '
        // ' OC.SetComplete                                                                '
        // CleanUpDB rs, cmd                                                               '
        // Exit Sub                                                                        '
        // '
        // DeleteDataBySPERR:                                                              '
        // ' OC.SetAbort                                                                   '
        // Err.Raise Err.Number, "DBCalls", Err.Description                                '
        // CleanUpDB rs, cmd                                                               '
        // End Sub                                                                         '
        // Public Function GetOutputParamFromSP(ByVal sStoredProc As String, ByVal sOutputParam As String, ParamArray InputParams()) As Object
        // On Error GoTo GetOutputParamFromSPERR
        // ' dbconnect '
        // cmd = New SqlCommand
        // With cmd
        // .connection = gCN
        // .CommandType = CommandType.StoredProcedure
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300


        // .CommandText = sStoredProc
        // .Parameters.Refresh()
        // End With
        // If Not IsMissing(InputParams) Then
        // Dim iArgs As Integer
        // iArgs = UBound(InputParams, 1)
        // Dim X As Integer
        // For X = 0 To iArgs
        // cmd.Parameters(X + 1).Value = InputParams(X)
        // Next X
        // End If
        // cmd.Execute()
        // GetOutputParamFromSP = cmd.Parameters(sOutputParam).Value
        // CleanUpDB(rs, cmd)
        // Exit Function

        // GetOutputParamFromSPERR:
        // Err.Raise(Err.Number, "DBCalls", Err.Description)
        // CleanUpDB(rs, cmd)
        // End Function
        // Friend Function GetReturnFromSP(ByVal sStoredProc As String, ParamArray Args()) As String
        // ' dbconnect '
        // cmd = New SqlCommand
        // With cmd
        // .connection = gCN
        // .CommandType = CommandType.StoredProcedure
        // ' ==========================          '
        // ' Michele Brown  5/8/2008             '
        // ' changed timeout from default to 300 '
        // ' ==========================          '
        // .CommandTimeout = 300


        // .CommandText = sStoredProc
        // .Parameters.Refresh()
        // End With
        // If Not IsMissing(Args) Then
        // Dim iArgs As Integer
        // iArgs = UBound(Args, 1)
        // Dim X As Integer

        // For X = 0 To iArgs
        // cmd.Parameters(X + 1).Value = Args(X)
        // Next X
        // End If

        // cmd.Execute()
        // GetReturnFromSP = cmd.Parameters(0).Value
        // CleanUpDB(rs, cmd)
        // Exit Function

        // GetDataFromSPERR:
        // Err.Raise(Err.Number, "DBCalls", Err.Description)
        // CleanUpDB(rs, cmd)
        // End Function

    }
}