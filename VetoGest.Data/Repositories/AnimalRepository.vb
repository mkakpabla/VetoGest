Imports Dapper
Imports VetoGest.Data.Models

Namespace Repositories
    Public Class AnimalRepository
        Implements IReposiory(Of Animal)

        Public Function GetAll() As List(Of Animal) Implements IReposiory(Of Animal).GetAll
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of Animal)("SELECT * FROM Animaux").ToList
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GetAll(ByVal ClientId As Integer) As List(Of Animal)
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.Query(Of Animal)($"SELECT * FROM Animaux WHERE IdClt = {ClientId}").ToList
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GetById(Id As Integer) As Animal Implements IReposiory(Of Animal).GetById
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Return Connection.QueryFirstOrDefault(Of Animal)($"SELECT * FROM Animaux WHERE IdAml = {Id}")
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Insert(obj As Animal) As Boolean Implements IReposiory(Of Animal).Insert
            Using Connection = GetConnection
                Connection.Open()
                Dim Query As String = "INSERT INTO Animaux(NomAml, SexeAml, DateNaissAml, CouleurAml, IdEsp, IdClt)
                                           VALUES(@NomAml, @SexeAml, @DateNaissAml, @CouleurAml,@IdEsp,@IdClt)"
                Return Connection.Execute(Query, obj) > 0
            End Using
        End Function

        Public Function Update(obj As Animal) As Boolean Implements IReposiory(Of Animal).Update
            Try
                Using Connection = GetConnection
                    Connection.Open()
                    Dim Query As String = "UPDATE Animaux SET NomAml = @NomAml, SexeAml = @SexeAml,
                                            DateNaissAml = @DateNaissAml, CouleurAml = @CouleurAml, 
                                            IdEsp = @IdEsp, IdClt = @IdClt WHERE IdAml = @IdAml"
                    Return Connection.Execute(Query, obj) > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Delete(Id As Integer) As Integer Implements IReposiory(Of Animal).Delete
            Try
                Using Connection = GetConnection
                    Connection.Open()

                    Return Connection.Execute($"DELETE FROM Animaux WHERE IdAml = {Id}") > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Search(ColomnName As String, SearchValue As String) As List(Of Animal) Implements IReposiory(Of Animal).Search
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
