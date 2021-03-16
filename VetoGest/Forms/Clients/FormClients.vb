Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories

Public Class FormClients

    Dim client As Client


    Dim clientRepository As ClientRepository = New ClientRepository()



    Private Sub LoadData()
        bsClients.DataSource = clientRepository.GetAll
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        FormAddClient.ShowDialog()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim Form As FormAddClient = New FormAddClient(client)
        Form.ShowDialog()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Voulez vous vraiment supprimer cet client ?", "Supprimer client", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            clientRepository.Delete(client.IdClt)
            LoadData()
        End If
    End Sub

    Private Sub dgvClients_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvClients.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim Index As Integer = dgvClients.HitTest(e.X, e.Y).RowIndex
            If Index < 0 Then
                ModifierToolStripMenuItem.Enabled = False
                SupprimerToolStripMenuItem.Enabled = False
            Else
                dgvClients.ClearSelection()
                dgvClients.Rows(Index).Selected = True
                ModifierToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True

                client = New Client()
                client.IdClt = dgvClients.Rows(Index).Cells("IdClt").Value
                client.NomClt = dgvClients.Rows(Index).Cells("NomClt").Value
                client.PrenomClt = dgvClients.Rows(Index).Cells("PrenomClt").Value
                client.TelClt = dgvClients.Rows(Index).Cells("TelClt").Value
                client.AdrClt = dgvClients.Rows(Index).Cells("AdrClt").Value
                client.CiviliteClt = dgvClients.Rows(Index).Cells("CiviliteClt").Value
            End If
        End If

    End Sub

    Private Sub FormClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

End Class