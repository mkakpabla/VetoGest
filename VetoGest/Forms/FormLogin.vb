Imports VetoGest.Data.Models
Imports VetoGest.Data
Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtLogin.Text) Or String.IsNullOrWhiteSpace(txtMdp.Text) Then
            MessageBox.Show("Les identifients de connexion sont obligatoire")
        Else
            Dim Agt As Agent = GetAgentRepository.Login(txtLogin.Text)
            If Agt IsNot Nothing Then
                If Agt.MdpAgt = txtMdp.Text Then
                    GlobalVar.Agent = Agt
                    Hide()
                    FormMain.Show()
                End If
            Else
                MessageBox.Show("Les identifients de connexion sont incorrectes")
            End If
        End If
    End Sub

    Private Sub liblExit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles liblExit.LinkClicked
        Application.Exit()
    End Sub
End Class