Imports VetoGest.Data
Imports VetoGest.Data.Models

Public Class FormAddAnimaux
    Private Sub FormAddAnimaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsClients.DataSource = GetClientRepository.GetAll
        bsEspece.DataSource = GetEspeceRepository.GetAll
    End Sub


    Public Sub New()

        InitializeComponent()

        bsAnimal.DataSource = New Animal

    End Sub

    Private Sub btnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click
        bsAnimal.EndEdit()
        Dim Animal As Animal = TryCast(bsAnimal.Current, Animal)
        Dim validation As New Validation(Animal)
        If validation.IsValid Then
            If Animal.IdAml > 0 Then

            Else
                MessageBox.Show(Animal.SexeAml)
                If GetAnimalRepository.Insert(Animal) Then
                    MessageBox.Show("L'animal a été ajouté")
                    bsAnimal.DataSource = New Animal
                End If
            End If
        Else
            MessageBox.Show(validation.Errors.First.ErrorMessage)
            Return
        End If

    End Sub
End Class