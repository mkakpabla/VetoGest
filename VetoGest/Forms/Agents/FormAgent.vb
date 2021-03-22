Imports VetoGest.Data
Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories

Public Class FormAgent

    Private WithEvents formAddAgent As New FormAddAgent

    Dim agentRepository As AgentRepository = New AgentRepository()


    Private Sub RefreshGrid() Handles formAddAgent.RefreshGrid
        LoadData()
    End Sub


    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        formAddAgent.ShowDialog()
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
        Dim formAddAgent As FormAddAgent = New FormAddAgent(Agent)
        formAddAgent.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim ReportAgent As ReportAgent = New ReportAgent()
        ReportAgent.SetDataSource(bsAgents)
        FormPrint.crpPrint.ReportSource = ReportAgent
        FormPrint.crpPrint.RefreshReport()
        FormPrint.ShowDialog()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            bsAgents.DataSource = agentRepository.GetAll
        Else
            bsAgents.DataSource = agentRepository.Search("NomCompAgt", txtSearch.Text)
        End If

    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim Result As DialogResult = MessageBox.Show("Voulez vous vraiment supprimer cet agent ?", "Suppression", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Dim Agent As Agent = TryCast(bsAgents.Current, Agent)
            If agentRepository.Delete(Agent.IdAgt) Then
                MessageBox.Show("L'agent a été supprimer")
                bsAgents.DataSource = agentRepository.GetAll
            End If
        End If
    End Sub
End Class