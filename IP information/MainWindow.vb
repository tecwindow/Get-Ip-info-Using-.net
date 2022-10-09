

Public Class MainWindow

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        End
    End Sub

    Private Sub GettingIPButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GettingIPButton.Click
        ReturnInformation = "The information has loaded" & vbNewLine & "your IP is:" & vbNewLine & Functions.GettingIP()
        ViewInfo.ShowDialog()

    End Sub

    Private Sub GettingInformationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GettingInformationButton.Click
        Dim IP As String = Functions.GettingIP()
        Dim information As Dictionary(Of String, String) = Functions.GetInfromation(IP)
        ReturnInformation = "The information has loaded" & vbNewLine & "Ip: " & information("ip") & vbNewLine & "country: " & information("country") & vbNewLine & "country code: " & information("countryCode") & vbNewLine & "city: " & information("city") & vbNewLine & "region: " & information("region")
        ViewInfo.ShowDialog()

    End Sub

    Private Sub GettingExternalIPButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GettingExternalIPButton.Click
        Dim IP As String = InputBox("Typ the IP that you want to get information about it.", "what is IP?")
        If IP = "" Then
            Return
        End If

        Dim information As Dictionary(Of String, String)
        Try
            information = Functions.GetInfromation(IP)
        Catch ex As Exception
            MessageBox.Show("You have typed an incorrect IP.", "Errer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ReturnInformation = "The information has loaded" & vbNewLine & "Ip: " & information("ip") & vbNewLine & "country: " & information("country") & vbNewLine & "country code: " & information("countryCode") & vbNewLine & "city: " & information("city") & vbNewLine & "region: " & information("region")
        ViewInfo.ShowDialog()
    End Sub

    Private Sub AboutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutButton.Click
        MessageBox.Show("Through this tool, you can do the following:" & vbNewLine & "1- You can get  your IP." & vbNewLine & "2- You can get information about any IP." & vbNewLine & "This tool was developed by TecWindow.", "IPInformationV1.0.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
