Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Espece


        Public Property IdEsp As Integer

        <Required>
        <MinLength(4, ErrorMessage:="Le libellé est exigé")>
        Public Property LibEsp As String

    End Class
End Namespace
