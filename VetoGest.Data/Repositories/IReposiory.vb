Namespace Repositories
    Public Interface IReposiory(Of T)


        Function GetAll() As List(Of T)

        Function GetById(ByVal Id As Integer) As T

        Function Insert(ByVal obj As T) As Boolean

        Function Update(ByVal obj As T) As Boolean

        Function Delete(ByVal Id As Integer) As Integer


    End Interface
End Namespace
