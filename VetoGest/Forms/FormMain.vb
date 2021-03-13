Public Class FormMain



    Private Sub AddToPanel(ByVal Form As Form)
        Form.TopLevel = False
        Form.Dock = DockStyle.Fill
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(Form)
        Form.Show()
    End Sub

    Private Sub btnMed_Click(sender As Object, e As EventArgs) Handles btnMed.Click
        AddToPanel(FormMedecins)
    End Sub

    Private Sub btnAnimaux_Click(sender As Object, e As EventArgs)
        AddToPanel(FormAnimaux)
    End Sub

    Private Sub btnConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click
        AddToPanel(FormConsultations)
    End Sub

    Private Sub btnAccueil_Click(sender As Object, e As EventArgs) Handles btnAccueil.Click
        AddToPanel(FormAccueil)
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        AddToPanel(FormClients)
    End Sub
End Class