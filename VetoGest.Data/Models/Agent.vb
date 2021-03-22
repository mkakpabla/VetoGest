Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Agent


        Public Property IdAgt As Integer

        <Required(ErrorMessage:="Le nom complet est requis")>
        <MinLength(4)>
        Public Property NomCompAgt As String

        <Required(ErrorMessage:="Le numéro de téléphone est requis")>
        <Phone(ErrorMessage:="Le numéro de téléphone n'est pas valide")>
        <MinLength(8, ErrorMessage:="Le numéro de téléphone doit avoir au min 8 chiffres")>
        <MaxLength(8, ErrorMessage:="Le numéro de téléphone doit avoir au max 8 chiffres")>
        Public Property TelAgt As String

        <Required(ErrorMessage:="L'addresse est requis")>
        Public Property AdrAgt As String

        <Required(ErrorMessage:="La fonction est requis")>
        Public Property FoncAgt As String

        Public Property LoginAgt As String

        Public Property MdpAgt As String

    End Class
End Namespace
