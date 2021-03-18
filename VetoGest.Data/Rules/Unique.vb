Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data.SqlClient
Imports System.Reflection

Namespace Rules
    Public Class Unique
        Inherits ValidationAttribute

        Public Property TableName As String

        Public Property ColumnName As String

        Public Property AdditionalFields As String



        'Public Overrides Function IsValid(value As Object) As Boolean
        '    Using Connection = GetConnection
        '        Connection.Open()
        '        Dim Val As String = TryCast(value, String)
        '        Using Command = New SqlCommand($"SELECT {ColumnName} FROM {TableName} WHERE {ColumnName} = @Value", Connection)
        '            Command.Parameters.Add(New SqlParameter("@Value", Val))
        '            Dim findValue As String = Command.ExecuteScalar()
        '            If findValue = Val Then
        '                Return False
        '            Else
        '                Return True
        '            End If
        '        End Using
        '    End Using
        'End Function


        Protected Overrides Function IsValid(value As Object, validationContext As ValidationContext) As ValidationResult

            Dim additionalPropertyName As PropertyInfo = validationContext.ObjectInstance.GetType().GetProperty(AdditionalFields)
            Dim additionalPropertyValue As String = additionalPropertyName.GetValue(validationContext.ObjectInstance, Nothing)
            Using Connection = GetConnection
                Connection.Open()
                Dim Val As String = TryCast(value, String)
                Using Command = New SqlCommand($"SELECT {ColumnName} FROM {TableName} WHERE {ColumnName} = @Value AND {AdditionalFields} != @AdditionalFields", Connection)
                    With Command
                        .Parameters.Add(New SqlParameter("@AdditionalFields", additionalPropertyValue))
                        .Parameters.Add(New SqlParameter("@Value", Val))
                    End With
                    Dim findValue As String = Command.ExecuteScalar()
                    If findValue Is Nothing Then
                        Return ValidationResult.Success
                    Else
                        Return New ValidationResult(ErrorMessage)
                    End If
                End Using
            End Using
            Return MyBase.IsValid(value, validationContext)
        End Function

    End Class
End Namespace
