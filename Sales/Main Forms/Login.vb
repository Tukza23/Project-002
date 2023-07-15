Public Class Login

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If usernameTB.Text = "" Then
            MsgBox("Input username!")
            usernameTB.Focus()
        ElseIf passwordTB.Text = "" Then
            MsgBox("Input password!")
            passwordTB.Focus()
        ElseIf usernameTB.Text = "admin" And passwordTB.Text = "admin" Then
            MsgBox("Welcome! Accessing administration form!")
            usernameTB.Text = ""
            passwordTB.Text = ""
            usernameTB.Focus()
            Me.Hide()
            Admin.Show()
        Else
            MsgBox("Incorrect username or password!")
            usernameTB.Focus()
        End If
    End Sub
End Class
