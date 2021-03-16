Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories

Public Class FormAddClient

    Dim clientRepository As ClientRepository = New ClientRepository()
    Public Sub New()
        InitializeComponent()
        ClientBindingSource.Add(New Client)
    End Sub

    Public Sub New(ByVal client As Client)
        InitializeComponent()
        ClientBindingSource.Add(client)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim client As Client = TryCast(ClientBindingSource.Current, Client)

        If (client.IdClt > 0) Then
            Dim ok As Boolean = clientRepository.Update(client)
            If ok Then
                MessageBox.Show("Les informations du client ont été enrégistrer")
            End If
        Else
            Dim ok As Boolean = clientRepository.Insert(client)
            If ok Then
                MessageBox.Show("Le client à eté ajouter avec succes")
                txtNom.Clear()
                txtPrenom.Clear()
                txtAdr.Clear()
                txtTel.Clear()
                cbxCivilite.Text = Nothing
            End If

        End If
    End Sub
End Class