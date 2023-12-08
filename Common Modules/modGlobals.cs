using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BossAdmin
{
    static class modGlobals
    {
        public static string msdbServer = "";
        public static string msConnection = "";
        public static int giRank = 0;
        public static int giPositionID = 0;
        // Public gCN As New SqlConnection
        public static string gsVersion = "";
        public static string gsDatabase = "";
        // Public gCN As New SqlConnection
        // Public gCNBoss As New SqlConnection
        // Public mCNLogs As New SqlConnection
        public static SqlConnection gCN;
        public static SqlConnection gCNBoss;
        public static SqlConnection mCNLogs;

        public static string msConnectionBoss = "";
        public static string gsUserID = "";
        public static string gsRank = "";
        public static int giSecurityID;
        public static string gsUserEmail = "";
        public static DataSet dsSecurity;
        public static List<SecurityMatrix> gSecurityList = new List<SecurityMatrix>();
        public static bool gbValidUser = false;
        public static DataSet gsCostAnalysisData;
        public static string gsConnectionString;
        public static string gsPathCost;
        public static string gsUpdateFolder; // 9/8/23 mrb
                                             // Private Function FindSecurity()
                                             // gSecurityList.Find(
                                             // End Function


    }
}