
Imports VetoGest.Data
Imports VetoGest.Data.ViewModels

Public Class frmListeConsultations

    Private Property ConsultationViewModel As ConsultationViewModel = New ConsultationViewModel()

    Private Sub frmListeConsultations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsConsultations.DataSource = ConsultationViewModel.GetAll
    End Sub

    Private Sub btnNouveau_Click(sender As Object, e As EventArgs) Handles btnNouveau.Click
        frmNewConsultation.ShowDialog()
    End Sub

    Private Sub btnPrintFiche_Click(sender As Object, e As EventArgs) Handles btnPrintFiche.Click
        Dim FicheConsultation As FicheConsultationReport = New FicheConsultationReport()
        Dim Data As ConsultationViewModel = TryCast(bsConsultations.Current, ConsultationViewModel)
        Dim List As IList(Of ConsultationViewModel) = New List(Of ConsultationViewModel)
        List.Add(Data)
        FicheConsultation.SetDataSource(List)
        FormPrint.crpPrint.ReportSource = FicheConsultation
        FormPrint.crpPrint.RefreshReport()
        FormPrint.ShowDialog()
    End Sub
End Class