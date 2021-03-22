Imports Dapper
Imports VetoGest.Data.Models

Namespace Repositories
    Public Class AnimalRepository
        Implements IReposiory(Of Animal)

        Public Function GetAll() As List(Of Animal) Implements IReposiory(Of Animal).GetAll
            Using Connection = GetConnection
                Connection.Open()
                Return Connection.Query(Of Animal)("SELECT * FROM Animaux").ToList
            End Using
        End Function

        Public Function GetById(Id As Integer) As Animal Implements IReposiory(Of Animal).GetById
            Throw New NotImplementedException()
        End Function

        Public Function Insert(obj As Animal) As Boolean Implements IReposiory(Of Animal).Insert
            Throw New NotImplementedException()
        End Function

        Public Function Update(obj As Animal) As Boolean Implements IReposiory(Of Animal).Update
            Throw New NotImplementedException()
        End Function

        Public Function Delete(Id As Integer) As Integer Implements IReposiory(Of Animal).Delete
            Throw New NotImplementedException()
        End Function

        Public Function Search(ColomnName As String, SearchValue As String) As List(Of Animal) Implements IReposiory(Of Animal).Search
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace
