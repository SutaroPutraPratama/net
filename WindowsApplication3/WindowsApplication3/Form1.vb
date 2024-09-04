Public Class Form1

    Private Sub looping_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim namaTeman As String
        Dim teman() As String = {"adaddd", "uhuhuh", "kawwww", "titi"}
        For Each namaTeman In teman
            ComboBox1.Items.Add(namaTeman)
        Next
    End Sub
End Class

