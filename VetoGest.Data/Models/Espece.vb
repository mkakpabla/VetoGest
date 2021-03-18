Imports System.ComponentModel.DataAnnotations
Imports VetoGest.Data.Rules

Namespace Models
    Public Class Espece
        Inherits ModelValidator


        Public Property IdEsp As Integer

        <Required>
        <MinLength(4, ErrorMessage:="Le libellé est exigé")>
        <Unique(TableName:="Especes", ColumnName:="LibEsp", AdditionalFields:="IdEsp", ErrorMessage:="L'espece existe déja")>
        Public Property LibEsp As String

    End Class
End Namespace
