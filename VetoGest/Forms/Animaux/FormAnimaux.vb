Public Class FormAnimaux
    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        FormAddAnimaux.ShowDialog()
    End Sub

    Private Sub btnEsp_Click(sender As Object, e As EventArgs) Handles btnEsp.Click
        FormEspece.ShowDialog()
    End Sub
End Class