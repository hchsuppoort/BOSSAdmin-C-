Public Class UserRecord
    Public SIId As Integer
    Public PositionID As Integer
    Public Position As String
    Public FName As String
    Public LName As String
    Public TypeID As Integer
    Public Type As String
    Public InActive As Integer
    Public Address As String
    Public City As String
    Public State As String
    Public Zip As String
    Public HPhone As String
    Public Radio As String
    Public Cell As String
    Public Fax As String
    Public EMail As String
    Public UserID As String
    Public Password As String
    Public SupervisorID As Integer

    ' Backing storage -- a generic dictionary
    Dim stateCaps As New Dictionary(Of String, String)

    ' Add items to the dictionary
    'stateCaps.Add( "WA" , "Olympia")
    'stateCaps.Add( "NM" , "Santa Fe")


End Class
Public Class SecurityMatrix
    Public ObjectName As String
    Public ObjectType As String
    Public EditRank As Integer
    Public ViewRank As Integer
    Public PositionID As Integer
End Class