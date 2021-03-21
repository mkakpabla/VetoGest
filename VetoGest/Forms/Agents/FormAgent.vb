Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories

Public Class FormAgent


    Dim agentRepository As AgentRepository = New AgentRepository()


    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        FormAddAgent.ShowDialog()
    End Sub

    Private Sub FormAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub


    Private Sub LoadData()
        bsAgents.DataSource = agentRepository.GetAll
    End Sub

    Private Sub dgvAgents_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAgents.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
                EditerToolStripMenuItem.Enabled = False
                SupprimerToolStripMenuItem.Enabled = False
            Else
                dgvAgents.CurrentCell = dgvAgents(e.ColumnIndex, e.RowIndex)
                EditerToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvAgents_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvAgents.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim Index As Integer = dgvAgents.HitTest(e.X, e.Y).RowIndex
            If Index < 0 Then
                EditerToolStripMenuItem.Enabled = False
                SupprimerToolStripMenuItem.Enabled = False
            Else
                EditerToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub EditerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditerToolStripMenuItem.Click
        Dim Agent As Agent = TryCast(bsAgents.Current, Agent)
        Dim form As FormAddAgent = New FormAddAgent(Agent)
        form.ShowDialog()
    End Sub
End Class