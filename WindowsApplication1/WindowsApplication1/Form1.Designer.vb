﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Masukan nama"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(133, 39)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(142, 22)
        Me.MaskedTextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cek"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama anda adalah"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(25, 165)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(248, 22)
        Me.MaskedTextBox2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox

End Class
