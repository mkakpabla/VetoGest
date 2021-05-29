Imports Dapper
Imports VetoGest.Data.Models

Namespace ViewModels
    Public Class ConsultationViewModel
        Inherits Consultation

        Public Property NomCompAgt As String

        Public Property NomAml As String

        Public Property SexeAml As String

        Public Property DateNaissAml As String

        Public Property CouleurAml As String

        Public Property IdEsp As Integer

        Public Property LibEsp As String

        Public Property IdClt As Integer

        Public Property NomClt As String

        Public Property PrenomClt As String

        Public Property AdrClt As String

        Public Property TelClt As String

        Public Property CiviliteClt As String

        Public ReadOnly Property FullName As String
            Get
                Return NomClt & " " & PrenomClt
            End Get

        End Property



        Public Function GetAll() As List(Of ConsultationViewModel)
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of ConsultationViewModel)($"SELECT * FROM Consultations_List")
                End Using
            Catch ex As Exception

            End Try
            Return Nothing
        End Function
    End Class
End Namespace
