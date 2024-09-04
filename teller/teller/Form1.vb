Public Class Form1
    Dim sapiObject
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        sapiObject = CreateObject("SAPI.spvoice")
        sapiObject.speak(TextBox1.Text)
    End Sub
End Class
