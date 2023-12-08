Public Class ErrorLog

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Try
            My.Computer.Clipboard.SetText(uteLog.Text)
            MsgBox("Process Log) is saved to your clipboard.  You can paste it into a document or directly into an email", MsgBoxStyle.Information, "Copy to Clipboard")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        With UltraPrintDocument1
            .Header.TextCenter = "Cost Analysis"
            .Footer.TextCenter = uteLog.Text
            .Print()
        End With

    End Sub
End Class