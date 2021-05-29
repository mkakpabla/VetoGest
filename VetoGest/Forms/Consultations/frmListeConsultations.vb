
Imports VetoGest.Data.ViewModels

Public Class frmListeConsultations

    Private Property ConsultationViewModel As ConsultationViewModel = New ConsultationViewModel()

    Private Sub frmListeConsultations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsConsultations.DataSource = ConsultationViewModel.GetAll
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        frmNewConsultation.ShowDialog()
    End Sub
End Class