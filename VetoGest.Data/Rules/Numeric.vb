
Imports System.ComponentModel.DataAnnotations

Namespace Rules
    Public Class Numeric
        Inherits ValidationAttribute
        Protected Overrides Function IsValid(value As Object, validationContext As ValidationContext) As ValidationResult


            Using Connection = GetConnection
                Connection.Open()
                Dim Val As String = TryCast(value, String)
                'If Integer.TryParse(Val) Then
                '    Return ValidationResult.Success
                'Else
                '    Return New ValidationResult(ErrorMessage)
                'End If
            End Using
            Return MyBase.IsValid(value, validationContext)
        End Function
    End Class
End Namespace