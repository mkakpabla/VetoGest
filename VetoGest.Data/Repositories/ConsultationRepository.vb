Imports Dapper
Imports VetoGest.Data.Models
Imports VetoGest.Data.ViewModels

Namespace Repositories
    Public Class ConsultationRepository
        Implements IReposiory(Of Consultation)

        Public Function GetAll() As List(Of Consultation) Implements IReposiory(Of Consultation).GetAll
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of Consultation)($"SELECT * FROM Consultations")
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GetById(Id As Integer) As Consultation Implements IReposiory(Of Consultation).GetById
            Throw New NotImplementedException()
        End Function

        Public Function Insert(obj As Consultation) As Boolean Implements IReposiory(Of Consultation).Insert
            Using Connection = GetConnection
                Connection.Open()
                Dim Query As String = "INSERT INTO Consultations(DateCons, ObsCons, RaisonCons, PrixCons, IdMed, IdAgt, IdAml) VALUES(@DateCons, @ObsCons, @RaisonCons, @PrixCons, @IdMed, @IdAgt, @IdAml)"
                Return Connection.Execute(Query, obj)
            End Using

        End Function

        Public Function Update(obj As Consultation) As Boolean Implements IReposiory(Of Consultation).Update
            Throw New NotImplementedException()
        End Function

        Public Function Delete(Id As Integer) As Integer Implements IReposiory(Of Consultation).Delete
            Throw New NotImplementedException()
        End Function

        Public Function Search(ColomnName As String, SearchValue As String) As List(Of Consultation) Implements IReposiory(Of Consultation).Search
            Throw New NotImplementedException()
        End Function


        Public Function GetByAnimal(ByVal IdAml As Integer) As List(Of ConsultationViewModel)
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of ConsultationViewModel)($"SELECT IdCons, DateCons, ObsCons, RaisonCons, PrixCons, IdMed, c.IdAgt, IdAml, NomCompAgt FROM Consultations c,Agents a WHERE c.IdAgt = a.IdAgt AND IdAml = {IdAml}")
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
