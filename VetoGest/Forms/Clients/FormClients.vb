Imports VetoGest.Data.Models

Public Class FormClients
    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        FormAddClient.ShowDialog()
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim Client As Client = TryCast(bsClients.Current, Client)
        Dim Form As FormAddClient = New FormAddClient(Client)
        Form.ShowDialog()
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
            End If
        End If

    End Sub
End Class