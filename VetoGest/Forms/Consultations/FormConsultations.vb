Imports VetoGest.Data.Models
Imports VetoGest.Data.RepositoryFactory
Public Class FormConsultations

    Dim WithEvents formAddCons As FormAddCons


    Private Sub FormConsultations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsClients.DataSource = GetClientRepository.GetAll
    End Sub

    Private Sub cbxClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxClients.SelectedIndexChanged
        Dim client As Client = TryCast(bsClients.Current, Client)
        If client IsNot Nothing Then
            bsAnimals.DataSource = GetAnimalRepository.GetByIdClt(client.IdClt)
        End If

    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        formAddCons = New FormAddCons()
        formAddCons.ShowDialog()
    End Sub
End Class