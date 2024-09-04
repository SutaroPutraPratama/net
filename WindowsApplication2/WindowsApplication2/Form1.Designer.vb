<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jamker = New System.Windows.Forms.MaskedTextBox()
        Me.lembur = New System.Windows.Forms.MaskedTextBox()
        Me.tidakhadir = New System.Windows.Forms.MaskedTextBox()
        Me.hitung = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.MaskedTextBox()
        Me.makan = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(319, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perhitungan Gaji Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jml Jam Kerja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(80, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jml Lembur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(80, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jml Tidak Hadir"
        '
        'jamker
        '
        Me.jamker.Location = New System.Drawing.Point(197, 75)
        Me.jamker.Name = "jamker"
        Me.jamker.Size = New System.Drawing.Size(139, 22)
        Me.jamker.TabIndex = 4
        '
        'lembur
        '
        Me.lembur.Location = New System.Drawing.Point(197, 117)
        Me.lembur.Name = "lembur"
        Me.lembur.Size = New System.Drawing.Size(139, 22)
        Me.lembur.TabIndex = 5
        '
        'tidakhadir
        '
        Me.tidakhadir.Location = New System.Drawing.Point(197, 157)
        Me.tidakhadir.Name = "tidakhadir"
        Me.tidakhadir.Size = New System.Drawing.Size(139, 22)
        Me.tidakhadir.TabIndex = 6
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(80, 194)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(256, 38)
        Me.hitung.TabIndex = 7
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(422, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Gaji"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Uang Makan"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(534, 79)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(132, 22)
        Me.total.TabIndex = 10
        '
        'makan
        '
        Me.makan.Location = New System.Drawing.Point(534, 120)
        Me.makan.Name = "makan"
        Me.makan.Size = New System.Drawing.Size(132, 22)
        Me.makan.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 253)
        Me.Controls.Add(Me.makan)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.tidakhadir)
        Me.Controls.Add(Me.lembur)
        Me.Controls.Add(Me.jamker)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jamker As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lembur As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tidakhadir As System.Windows.Forms.MaskedTextBox
    Friend WithEvents hitung As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.MaskedTextBox
    Friend WithEvents makan As System.Windows.Forms.MaskedTextBox

End Class
