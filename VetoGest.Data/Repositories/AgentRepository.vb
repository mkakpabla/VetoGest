Imports Dapper
Imports VetoGest.Data.Models

Namespace Repositories
    Public Class AgentRepository
        Implements IReposiory(Of Agent)

        Public Function GetAll() As List(Of Agent) Implements IReposiory(Of Agent).GetAll
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of Agent)("SELECT * FROM Agents")
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GetById(Id As Integer) As Agent Implements IReposiory(Of Agent).GetById
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of Agent)($"SELECT * FROM Agents WHERE @IdAgt = {Id}")
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Insert(obj As Agent) As Boolean Implements IReposiory(Of Agent).Insert
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Execute("INSERT INTO Agents(NomCompAgt, TelAgt, AdrAgt, FoncAgt, LoginAgt, MdpAgt) VALUES(@NomCompAgt, @TelAgt, @AdrAgt, @FoncAgt, @LoginAgt, @MdpAgt)", obj) > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Update(obj As Agent) As Boolean Implements IReposiory(Of Agent).Update
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Execute("UPDATE Agents SET NomCompAgt = @NomCompAgt, TelAgt = @TelAgt, AdrAgt = @AdrAgt, FoncAgt = @FoncAgt, LoginAgt = @LoginAgt, MdpAgt = @MdpAgt WHERE IdAgt = @IdAgt", obj) > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Delete(Id As Integer) As Integer Implements IReposiory(Of Agent).Delete
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Execute($"DELETE FROM Agents WHERE IdAgt = {Id}") > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
    End Class
End Namespace
