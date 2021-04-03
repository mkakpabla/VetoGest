Imports VetoGest.Data
Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblClients.Text = GetClientRepository.GetAll.Count
        lblAml.Text = GetAnimalRepository.GetAll.Count
        lblCons.Text = GetConsultationRepository.GetAll.Count
    End Sub
End Class