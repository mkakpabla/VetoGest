Imports System.ComponentModel.DataAnnotations
Imports VetoGest.Data.Models

Public Class FormAddAgent
    Private Sub FormAddAgent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ErrorProvider1.Clear()
    End Sub


    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        bsAgents.DataSource = New Agent

    End Sub

    Public Sub New(ByVal Agent As Agent)

        InitializeComponent()
        bsAgents.DataSource = Agent

    End Sub

    Private Sub btnEnr_Click(sender As Object, e As EventArgs) Handles btnEnr.Click
        Dim agent As Agent = TryCast(bsAgents.Current, Agent)
        Dim context As ValidationContext = New ValidationContext(agent)
        Dim errors As IList(Of ValidationResult) = New List(Of ValidationResult)
        If Not Validator.TryValidateObject(agent, context, errors, True) Then
            For Each err As ValidationResult In errors
                MessageBox.Show(err.ErrorMessage)


                Return
            Next
        End If
    End Sub
End Class