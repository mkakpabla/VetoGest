Imports VetoGest.Data.Models
Imports VetoGest.Data.Repositories

Public Class FormEspece


    Dim especeRepository As EspeceRepository = New EspeceRepository()

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        Dim espece As Espece = TryCast(bsEspece.Current, Espece)
        If espece IsNot Nothing Then
            If espece.IdEsp > 0 Then
                bsEspece.Add(New Espece)
                bsEspece.MoveLast()
            Else
                bsEspece.MoveLast()
            End If
        Else
            bsEspece.Add(New Espece)
            bsEspece.MoveLast()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bsEspece.EndEdit()
        Dim espece As Espece = TryCast(bsEspece.Current, Espece)
        If espece.IsValiad Then
            If espece.IdEsp = 0 Then
                If especeRepository.Insert(espece) Then
                    MessageBox.Show("L'espece a été ajouter")
                    LoadEspeces()
                End If
            Else
                If especeRepository.Update(espece) Then
                    MessageBox.Show("L'espece a été mise à jour")
                    LoadEspeces()
                End If
            End If

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        bsEspece.EndEdit()
        Dim espece As Espece = TryCast(bsEspece.Current, Espece)
        If especeRepository.Delete(espece.IdEsp) Then
            MessageBox.Show("L'espece a été supprimer")
            LoadEspeces()
        End If
    End Sub

    Private Sub FormEspece_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEspeces()
    End Sub

    Private Sub LoadEspeces()
        bsEspece.DataSource = especeRepository.GetAll()
    End Sub
End Class