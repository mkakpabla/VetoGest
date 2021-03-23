Imports VetoGest.Data
Imports VetoGest.Data.Models

Public Class FormAnimaux


    Dim WithEvents formAddAnimal As FormAddAnimaux



    Private Sub RefreshGrid() Handles formAddAnimal.RefreshGrid
        bsAnimal.DataSource = GetAnimalRepository.GetAll(cbxClients.SelectedValue)
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        formAddAnimal = New FormAddAnimaux
        formAddAnimal.ShowDialog()
    End Sub

    Private Sub btnEsp_Click(sender As Object, e As EventArgs) Handles btnEsp.Click
        FormEspece.ShowDialog()
    End Sub

    Private Sub FormAnimaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsAnimal.DataSource = GetAnimalRepository.GetAll
        bsClients.DataSource = GetClientRepository.GetAll
    End Sub

    Private Sub cbxClients_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxClients.SelectedValueChanged
        bsAnimal.DataSource = GetAnimalRepository.GetAll(cbxClients.SelectedValue)
    End Sub

    Private Sub dgvAnimaux_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvAnimaux.CellMouseDown
        If e.Button = MouseButtons.Right Then

            If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
                ModifierToolStripMenuItem.Enabled = False
                SupprimerToolStripMenuItem.Enabled = False
                ImprimerConsulationsToolStripMenuItem.Enabled = False
            Else
                dgvAnimaux.CurrentCell = dgvAnimaux(e.ColumnIndex, e.RowIndex)
                ModifierToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True
                ImprimerConsulationsToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvAnimaux_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvAnimaux.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim Index As Integer = dgvAnimaux.HitTest(e.X, e.Y).RowIndex
            If Index < 0 Then
                ModifierToolStripMenuItem.Enabled = False
                SupprimerToolStripMenuItem.Enabled = False
                ImprimerConsulationsToolStripMenuItem.Enabled = False
            Else
                ModifierToolStripMenuItem.Enabled = True
                SupprimerToolStripMenuItem.Enabled = True
                ImprimerConsulationsToolStripMenuItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        Dim animal As Animal = TryCast(bsAnimal.Current, Animal)
        formAddAnimal = New FormAddAnimaux(animal)
        formAddAnimal.ShowDialog()
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim Result As DialogResult = MessageBox.Show("Voulez vous vraiment supprimer cet animal ?", "Suppression", MessageBoxButtons.YesNo)
        If Result = DialogResult.Yes Then
            Dim animal As Animal = TryCast(bsAnimal.Current, Animal)
            If GetAnimalRepository.Delete(animal.IdAml) Then
                MessageBox.Show("L'animal a été supprimer")
                bsAnimal.DataSource = GetAnimalRepository.GetAll(cbxClients.SelectedValue)
            End If
        End If
    End Sub
End Class