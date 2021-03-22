Imports System.ComponentModel.DataAnnotations

Public Class Validation


    Private Property _obj As Object

    Private Property _errors As IList(Of ValidationResult) = New List(Of ValidationResult)


    Public Sub New(obj As Object)
        _obj = obj
    End Sub

    Public Function IsValid() As Boolean
        Dim context As ValidationContext = New ValidationContext(_obj)
        Return Validator.TryValidateObject(_obj, context, _errors, True)
    End Function


    Public Function Errors() As IList(Of ValidationResult)
        Return _errors
    End Function

End Class
