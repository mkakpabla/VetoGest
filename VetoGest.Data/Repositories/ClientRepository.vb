Imports Dapper
Imports VetoGest.Data.Models

Namespace Repositories
    Public Class ClientRepository
        Implements IReposiory(Of Client)

        Public Function GetAll() As List(Of Client) Implements IReposiory(Of Client).GetAll
            Using Connection = GetConnection
                Return Connection.Query(Of Client)("SELECT * FROM Clients").ToList()
            End Using
        End Function

        Public Function GetById(Id As Integer) As Client Implements IReposiory(Of Client).GetById
            Using Connection = GetConnection
                Return Connection.QueryFirstOrDefault(Of Client)("SELECT * FROM Clients WHERE IdClt = @IdClt")
            End Using
        End Function

        Public Function Insert(Client As Client) As Boolean Implements IReposiory(Of Client).Insert
            Using Connection = GetConnection
                Dim Query As String = "INSERT INTO Clients(NomClt, PrenomClt, AdrClt, CiviliteClt, TelClt)
                                       VALUES(@NomClt, @PrenomClt, @AdrClt, @CiviliteClt, @TelClt)"
                Return Connection.Execute(Query, Client) > 0
            End Using
        End Function

        Public Function Update(Client As Client) As Boolean Implements IReposiory(Of Client).Update
            Using Connection = GetConnection
                Dim Query As String = "UPDATE Clients SET NomClt = @NomClt, PrenomClt = @PrenomClt, AdrClt = @AdrClt, CiviliteClt = @CiviliteClt, TelClt = @TelClt
                                        WHERE IdClt = @IdClt"
                Return Connection.Execute(Query, Client) > 0
            End Using
        End Function

        Public Function Delete(Id As Integer) As Integer Implements IReposiory(Of Client).Delete
            Using Connection = GetConnection
                Return Connection.Execute($"DELETE FROM Clients WHERE IdClt = {Id}") > 0
            End Using
        End Function
    End Class
End Namespace
