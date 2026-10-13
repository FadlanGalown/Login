Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.masuk()
        If Form1.fungsi = "Admin" Then
            Button3.Hide()
        ElseIf Form1.fungsi = "User" Then
            Button1.Hide()
            Button2.Hide()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.fungsi = " "
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Me.Close()
        Form1.Show()
    End Sub
End Class