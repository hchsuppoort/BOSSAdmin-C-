using System.Collections.Generic;

namespace BossAdmin
{
    public class UserRecord
    {
        public int SIId;
        public int PositionID;
        public string Position;
        public string FName;
        public string LName;
        public int TypeID;
        public string Type;
        public int InActive;
        public string Address;
        public string City;
        public string State;
        public string Zip;
        public string HPhone;
        public string Radio;
        public string Cell;
        public string Fax;
        public string EMail;
        public string UserID;
        public string Password;
        public int SupervisorID;

        // Backing storage -- a generic dictionary
        private Dictionary<string, string> stateCaps = new Dictionary<string, string>();

        // Add items to the dictionary
        // stateCaps.Add( "WA" , "Olympia")
        // stateCaps.Add( "NM" , "Santa Fe")


    }

    public class SecurityMatrix
    {
        public string ObjectName;
        public string ObjectType;
        public int EditRank;
        public int ViewRank;
        public int PositionID;
    }
}