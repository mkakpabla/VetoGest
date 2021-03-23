Imports VetoGest.Data
Imports VetoGest.Data.Models

Public Class FormAddAnimaux


    Public Event RefreshGrid()


    Dim _animal As Animal = New Animal


    Private Sub FormAddAnimaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsClients.DataSource = GetClientRepository.GetAll
        bsEspece.DataSource = GetEspeceRepository.GetAll
        bsAnimal.DataSource = _animal
    End Sub


    Public Sub New(ByVal animal As Animal)
        InitializeComponent()
        _animal = animal
    End Sub

    Private Sub btnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click
        bsAnimal.EndEdit()
        Dim Animal As Animal = TryCast(bsAnimal.Current, Animal)
        Dim validation As New Validation(Animal)
        If validation.IsValid Then
            If Animal.IdAml > 0 Then
                If GetAnimalRepository.Update(Animal) Then
                    MessageBox.Show("Les informations de l'animal ont été mis à jour")
                    RaiseEvent RefreshGrid()
                End If
            Else
                MessageBox.Show(Animal.SexeAml)
                If GetAnimalRepository.Insert(Animal) Then
                    MessageBox.Show("L'animal a été ajouté")
                    bsAnimal.DataSource = New Animal
                    RaiseEvent RefreshGrid()
                End If
            End If
        Else
            MessageBox.Show(validation.Errors.First.ErrorMessage)
            Return
        End If

    End Sub
End Class