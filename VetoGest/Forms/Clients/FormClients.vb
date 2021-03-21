Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories

Public Class FormClients

    'Dim client As Client


    Dim clientRepository As ClientRepository = New ClientRepository()

    Private Sub FormClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub LoadData()
        bsClients.DataSource = clientRepository.GetAll
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        FormAddClient.ShowDialog()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim _client As Client = TryCast(bsClients.Current, Client)
        Dim Form As FormAddClient = New FormAddClient(_client)
        Form.ShowDialog()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Voulez vous vraiment supprimer cet client ?", "Supprimer client", MessageBoxButtons.YesNo)
        Dim _client As Client = TryCast(bsClients.Current, Client)
        If result = DialogResult.Yes Then
            clientRepository.Delete(_client.IdClt)
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
                ModifierToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True
            End If
        End If

    End Sub


    Private Sub dgvClients_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvClients.CellMouseDown

        If e.Button = MouseButtons.Right Then

            If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
                ModifierToolStripMenuItem.Enabled = False
                SupprimerToolStripMenuItem.Enabled = False
            Else
                dgvClients.CurrentCell = dgvClients(e.ColumnIndex, e.RowIndex)
                ModifierToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub



End Class