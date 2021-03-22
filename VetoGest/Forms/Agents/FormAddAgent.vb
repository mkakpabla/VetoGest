Imports System.ComponentModel.DataAnnotations
Imports VetoGest.Data
Imports VetoGest.Data.Models

Public Class FormAddAgent


    Public Event RefreshGrid()


    Public Sub New()
        InitializeComponent()
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
                Select Case err.MemberNames.First
                    Case "NomCompAgt"
                        txtNom.Focus()
                    Case "TelAgt"
                        txtTel.Focus()
                    Case "AdrAgt"
                        txtAdr.Focus()
                    Case "FoncAgt"
                        cbxFoncAgt.Focus()
                    Case "LoginAgt"
                        txtLogin.Focus()
                    Case "MdpAgt"
                        txtMdp.Focus()
                End Select
                Return
            Next
        Else
            If agent.IdAgt > 0 Then
                If GetAgentRepository.Update(agent) Then
                    MessageBox.Show("Les informations de l'agent de santé ont été mis à jour")
                End If
            Else
                If GetAgentRepository.Insert(agent) Then
                    MessageBox.Show("L'agent de santé a été ajouter")
                    bsAgents.DataSource = New Agent
                    RaiseEvent RefreshGrid()
                End If
            End If

        End If
    End Sub
End Class