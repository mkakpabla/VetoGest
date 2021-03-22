Imports Dapper
Imports VetoGest.Data.Models

Namespace Repositories
    Public Class EspeceRepository
        Implements IReposiory(Of Espece)

        Public Function GetAll() As List(Of Espece) Implements IReposiory(Of Espece).GetAll
            Try
                Using Connection = GetConnection
                    Return Connection.Query(Of Espece)("SELECT * FROM Especes").ToList
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function GetById(Id As Integer) As Espece Implements IReposiory(Of Espece).GetById
            Try
                Using Connection = GetConnection
                    Return Connection.QueryFirstOrDefault(Of Espece)("SELECT * FROM Clients WHERE IdClt = @IdClt")
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Insert(obj As Espece) As Boolean Implements IReposiory(Of Espece).Insert
            Try
                Using Connection = GetConnection
                    Return Connection.Execute("INSERT INTO Especes(LibEsp) VALUES(@LibEsp)", obj) > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Update(obj As Espece) As Boolean Implements IReposiory(Of Espece).Update
            Try
                Using Connection = GetConnection
                    Return Connection.Execute("UPDATE Especes SET LibEsp = @LibEsp WHERE IdEsp = @IdEsp", obj) > 0
                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

        Public Function Delete(Id As Integer) As Integer Implements IReposiory(Of Espece).Delete
            Try
                Using Connection = GetConnection
                    Return Connection.Execute($"DELETE FROM Especes WHERE IdEsp = {Id}") > 0
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Search(ColomnName As String, SearchValue As String) As List(Of Espece) Implements IReposiory(Of Espece).Search
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
