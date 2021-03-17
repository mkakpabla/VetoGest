Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Client
        Inherits ModelValidator

        Public Property IdClt As Integer

        <Required(ErrorMessage:="Le nom du client est obligatoire")>
        Public Property NomClt As String

        <Required(ErrorMessage:="Le prénom du client est obligatoire")>
        Public Property PrenomClt As String

        <Required(ErrorMessage:="L'addresse du client est obligatoire")>
        Public Property AdrClt As String

        <Required(ErrorMessage:="Le téléphone du client est obligatoire")>
        <MaxLength(8, ErrorMessage:="La taille maximale du numéro de téléphone doit être 8")>
        <MinLength(8, ErrorMessage:="La taille minimale du numéro de téléphone doit être 8")>
        <Phone(ErrorMessage:="Le numéro de téléphne n'est pas valide")>
        Public Property TelClt As String

        <Required(ErrorMessage:="La civilité du client est obligatoire")>
        Public Property CiviliteClt As String

    End Class

End Namespace