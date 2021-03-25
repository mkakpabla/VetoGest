Imports VetoGest.Data.RepositoryFactory
Public Class FormAddCons
    Private Sub FormAddCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsAgents.DataSource = GetAgentRepository.GetAllByFonc("Médécin")
    End Sub
End Class