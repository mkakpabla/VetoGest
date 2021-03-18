Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Linq

Public Class ModelValidator
    Implements IDataErrorInfo
    <Browsable(False)>
    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            Dim propertyDescriptor As PropertyDescriptor = TypeDescriptor.GetProperties(Me)(columnName)

            If propertyDescriptor Is Nothing Then
                Return String.Empty
            End If

            Dim Results As List(Of ValidationResult) = New List(Of ValidationResult)
            Dim Result As Boolean = Validator.TryValidateProperty(propertyDescriptor.GetValue(Me),
                                          New ValidationContext(Me, Nothing, Nothing) With {.MemberName = columnName},
                                          Results)
            If Not Result Then
                Return Results.First().ErrorMessage
            End If
            Return String.Empty
        End Get
    End Property

    <Browsable(False)>
    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Dim Results As List(Of ValidationResult) = New List(Of ValidationResult)
            Dim Result As Boolean = Validator.TryValidateObject(Me, New ValidationContext(Me, Nothing, Nothing),
                                          Results, True)
            If Not Result Then
                Return String.Join("\n", Results.Select(Function(x) x.ErrorMessage))
            Else
                Return Nothing
            End If
        End Get
    End Property
    <Browsable(False)>
    Public Function IsValiad() As Boolean
        Return String.IsNullOrWhiteSpace([Error])
    End Function
End Class
