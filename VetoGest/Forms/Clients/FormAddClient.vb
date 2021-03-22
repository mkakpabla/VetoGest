Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories
Imports VetoGest.Data.Db
Imports System.ComponentModel.DataAnnotations

Public Class FormAddClient

    Public Event RefreshGrid()

    Dim clientRepository As ClientRepository = New ClientRepository()
    Public Sub New()
        InitializeComponent()
        bsClient.DataSource = New Client
    End Sub

    Public Sub New(ByVal client As Client)
        InitializeComponent()
        bsClient.DataSource = client
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim client As Client = TryCast(bsClient.Current, Client)
        Dim validation As New Validation(client)
        If validation.IsValid Then
            If (client.IdClt > 0) Then
                Dim ok As Boolean = clientRepository.Update(client)
                If ok Then
                    MessageBox.Show("Les informations du client ont été enrégistrer")
                    RaiseEvent RefreshGrid()
                End If
            Else
                Dim ok As Boolean = clientRepository.Insert(client)
                If ok Then
                    MessageBox.Show("Le client à eté ajouter avec succes")
                    bsClient.DataSource = New Client
                    RaiseEvent RefreshGrid()
                End If
            End If
        Else
            MessageBox.Show(validation.Errors.First.ErrorMessage)
            Return
        End If

    End Sub


End Class