Imports Infragistics.Win.AppStyling
Public Class AppMgr

    <STAThread()>
    Shared Sub Main()
        Dim sPathToISL As String
        Dim bGoOn As Boolean
        Try
            sPathToISL = Application.StartupPath & "\resources\Metro.isl"
            StyleManager.Load(sPathToISL)
            Using frmLogin1 As New Login
                bGoOn = frmLogin1.ShowDialog() = DialogResult.OK
            End Using
            'Dim MainForm As New mdiMain
            If bGoOn Then
                If gbValidUser = True Then
                    Dim MainForm As New mdiMain
                    'MainForm.lblConnectionstring.Text = gsConnectionString
                    Application.Run(MainForm)
                Else
                    End
                End If
            End If
        Catch
            ShowError(Err.Description, False, "LoadError", "BOSSAdmin - load application")
        End Try
    End Sub
End Class
