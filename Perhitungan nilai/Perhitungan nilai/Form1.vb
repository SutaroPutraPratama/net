Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim nama, keterangan, predikat As String
        Dim tugas, quis, uts, uas, hasil As Double

        nama = Me.TextBox5.Text
        Me.Label2.Text = nama
        tugas = Me.TextBox1.Text * 20 / 100
        quis = Me.TextBox2.Text * 15 / 100
        uts = Me.TextBox3.Text * 30 / 100
        uas = Me.TextBox4.Text * 35 / 100


        hasil = tugas + quis + uts + uas
        Me.Label3.Text = hasil


        If hasil >= 75 Then
            keterangan = "Selamat anda dinyatakan Lulus! dengan predikat"
        Else
            keterangan = "Silahkan untuk melakukan perbaikan! Nilai predikat"
        End If

        Me.Label4.Text = keterangan


        If hasil >= 85 Then
            predikat = "A"
        ElseIf hasil >= 77 Then
            predikat = "B"
        Else
            predikat = "C"
        End If

        Me.Label5.Text = predikat

    End Sub
End Class
