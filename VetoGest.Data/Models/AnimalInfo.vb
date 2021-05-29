

Namespace Models
    Public Class AnimalInfo
        Inherits Animal

        Public Property NomClt As String

        Public Property PrenomClt As String

        Public Property AdrClt As String

        Public Property TelClt As String

        Public Property CiviliteClt As String

        Public Property LibEsp As String

        Public ReadOnly Property FullName As String
            Get
                Return NomClt & " " & PrenomClt
            End Get

        End Property

    End Class
End Namespace
