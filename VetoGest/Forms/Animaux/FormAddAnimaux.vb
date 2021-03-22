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
End Class