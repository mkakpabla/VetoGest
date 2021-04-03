Imports VetoGest.Data.Models
Imports VetoGest.Data.RepositoryFactory
Public Class FormAddCons

    Dim animal As Animal

    Public Event RefreshGrid()


    Public Sub New(ByVal animal As Animal)

        InitializeComponent()
        bsCons.DataSource = New Consultation
        Me.animal = animal
    End Sub


    Private Sub FormAddCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bsAgents.DataSource = GetAgentRepository.GetAllByFonc("Médécin")
    End Sub

    Private Sub btnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click
        bsCons.EndEdit()
        Dim Cons As Consultation = TryCast(bsCons.Current, Consultation)
        Cons.IdAgt = GlobalVar.Agent.IdAgt
        Cons.DateCons = Date.Now
        Cons.IdAml = animal.IdAml
        Dim validation As New Validation(Cons)
        If validation.IsValid Then
            If Cons.IdCons > 0 Then
            Else
                If Integer.Parse(txtPrixCons.Text) = 0 Then
                    MessageBox.Show("Le prix n'est pas valide")
                    Return
                End If
                If GetConsultationRepository.Insert(Cons) Then
                    MessageBox.Show("La consulation à été enrégistrer")
                    bsCons.DataSource = New Consultation
                    RaiseEvent RefreshGrid()
                End If
            End If
        Else
            MessageBox.Show(validation.Errors.First.ErrorMessage)
            Return
        End If

    End Sub
End Class