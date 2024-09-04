Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim message As String = "username dan password tidak terdaftar"
        If Me.TextBox2.Text = "Sutaro" And Me.TextBox1.Text = "admin" Then
            Me.Hide()
            Form2.Show()
        ElseIf Me.TextBox2.Text = "khairul" And Me.TextBox1.Text = "user" Then
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show(message)

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
