Imports VetoGest.Data.Models
Imports VetoGest.Data.RepositoryFactory
Public Class FormConsultations

    Dim WithEvents formAddCons As FormAddCons


    Private Sub FormConsultations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsClients.DataSource = GetClientRepository.GetAll
    End Sub


    Private Sub RefreshGrid() Handles formAddCons.RefreshGrid
        If Not String.IsNullOrWhiteSpace(cbxAnimals.Text) Then
            bsCons.DataSource = GetConsultationRepository.GetByAnimal(cbxAnimals.SelectedValue)
        Else
            bsCons.DataSource = Nothing
        End If
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        If String.IsNullOrEmpty(cbxAnimals.Text) Then
            MessageBox.Show("Veillez selectionnner un animal")
        Else
            bsAnimals.EndEdit()
            Dim animal As Animal = TryCast(bsAnimals.Current, Animal)
            formAddCons = New FormAddCons(animal)
            formAddCons.ShowDialog()
        End If
    End Sub

    Private Sub ComboBox2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxAnimals.SelectedValueChanged
        If Not String.IsNullOrWhiteSpace(cbxAnimals.Text) Then
            bsCons.DataSource = GetConsultationRepository.GetByAnimal(cbxAnimals.SelectedValue)
        Else
            bsCons.DataSource = Nothing
        End If
    End Sub

    Private Sub cbxClients_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxClients.SelectedValueChanged
        If Not String.IsNullOrWhiteSpace(cbxClients.Text) Then
            bsAnimals.DataSource = GetAnimalRepository.GetByIdClt(cbxClients.SelectedValue)
        End If
    End Sub
End Class