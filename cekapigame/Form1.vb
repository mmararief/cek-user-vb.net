Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim token As String = "VBSPP-W3YDB-ER8HB-LQHMK"
        Dim id As String = IdTxt.Text
        Dim server As String = ServerTxt.Text
        Dim game As String = ""

        If cmbGame.Text = "Mobile Legends" Then
            game = "ml"
        ElseIf cmbGame.Text = "FreeFire" Then
            game = "ff"
        ElseIf cmbGame.Text = "Call Of Duty Mobile" Then
            game = "cod"

        End If



        Dim url As String = "https://api.enivay.com/games/api/" & game
        Dim data As String = "token=" & token & "&id=" & id & "&server=" & server

        Try
            Using client As New HttpClient()
                Dim content As New StringContent(data, Encoding.UTF8, "application/x-www-form-urlencoded")

                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
                response.EnsureSuccessStatusCode()

                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                ' Deserialize the JSON response
                Dim result As New With {
                    .ok = False,
                    .msg = "",
                    .name = ""
                }
                result = JsonConvert.DeserializeAnonymousType(jsonResponse, result)

                If result.ok Then
                    MessageBox.Show("ID player ditemukan" & vbCrLf & "Name: " & result.name)
                Else
                    MessageBox.Show("ID player tidak ditemukan" & vbCrLf & "Pesan: " & result.msg)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbGame_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGame.SelectedIndexChanged

    End Sub
End Class
