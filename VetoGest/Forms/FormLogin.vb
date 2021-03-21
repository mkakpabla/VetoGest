Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        FormMain.Show()
    End Sub

    Private Sub liblExit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles liblExit.LinkClicked
        Application.Exit()
    End Sub
End Class