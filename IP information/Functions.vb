Imports Newtonsoft.Json.Linq

Public Class Functions

    Public Shared Function GettingIP() As String
        Dim json As String = New System.Net.WebClient().DownloadString("https://api64.ipify.org?format=json")
        Dim parsejson As JObject = JObject.Parse(json)
        Dim IP = parsejson.SelectToken("ip").ToString()
        Return IP

    End Function



    Public Shared Function GetInfromation(ByVal IP As String) As Dictionary(Of String, String)
        Dim information As New Dictionary(Of String, String)
        Dim json As String = New System.Net.WebClient().DownloadString("http://ip-api.com/json/" & IP)
        Dim parsejson As JObject = JObject.Parse(json)

        information.Add("ip", IP)
        information.Add("country", parsejson.SelectToken("country").ToString())
        information.Add("countryCode", parsejson.SelectToken("countryCode").ToString())
        information.Add("city", parsejson.SelectToken("city").ToString())
        information.Add("region", parsejson.SelectToken("regionName").ToString())
        Return information
    End Function

End Class
