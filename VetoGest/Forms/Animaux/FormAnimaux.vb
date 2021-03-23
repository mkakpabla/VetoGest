Imports VetoGest.Data
Public Class FormAnimaux


    Dim WithEvents formAddAnimal As FormAddAnimaux


    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        formAddAnimal = New FormAddAnimaux
        formAddAnimal.ShowDialog()
    End Sub

    Private Sub btnEsp_Click(sender As Object, e As EventArgs) Handles btnEsp.Click
        FormEspece.ShowDialog()
    End Sub

    Private Sub FormAnimaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsAnimal.DataSource = GetAnimalRepository.GetAll
    End Sub
End Class