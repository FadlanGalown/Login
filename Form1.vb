Public Class Form1
    Dim usernameadmin As String = "Admin"
    Dim passwordadmin As String = "Admin123"
    Dim usernameuser As String = "User"
    Dim passworduser As String = "User123"
    Dim status As String
    Public fungsi As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub masuk()

        If TextBox1.Text.Trim = usernameadmin And TextBox2.Text.Trim = passwordadmin Then
            fungsi = "Admin"
        ElseIf TextBox1.Text.Trim = usernameuser And TextBox2.Text.Trim = passworduser Then
            fungsi = "User"
        Else
            fungsi = "Salah"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f2 As New Form2
        masuk()
        If fungsi = "Admin" Then
            Me.Hide()
            f2.Show()
        ElseIf fungsi = "User" Then
            Me.Hide()
            f2.Show()
        Else
            MessageBox.Show("Password Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub



End Class
