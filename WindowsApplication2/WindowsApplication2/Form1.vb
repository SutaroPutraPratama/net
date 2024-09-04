Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hitung.Click
        Dim hitung As Double
        hitung = (Me.jamker.Text * 15000 + Me.lembur.Text * 10000 - Me.tidakhadir.Text * 100000)
        Me.total.Text = hitung
        hitung = (Me.jamker.Text * 10000)
        Me.makan.Text = hitung

    End Sub
End Class
