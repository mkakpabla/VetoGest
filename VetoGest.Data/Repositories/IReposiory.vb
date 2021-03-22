Namespace Repositories
    Public Interface IReposiory(Of T)


        Function GetAll() As List(Of T)

        Function GetById(ByVal Id As Integer) As T

        Function Insert(ByVal obj As T) As Boolean

        Function Update(ByVal obj As T) As Boolean

        Function Delete(ByVal Id As Integer) As Integer


        Function Search(ByVal ColomnName As String, ByVal SearchValue As String) As List(Of T)

    End Interface
End Namespace
