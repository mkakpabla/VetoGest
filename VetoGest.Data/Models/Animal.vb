

Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Animal

        Public Property IdAml As Integer

        <Required(ErrorMessage:="Le nom de l'animal est requis")>
        Public Property NomAml As String

        <Required(ErrorMessage:="Le sexe de l'animal est requis")>
        Public Property SexeAml As String

        <Required(ErrorMessage:="La date de naissancede l'animal est requis")>
        Public Property DateNaissAml As String

        <Required(ErrorMessage:="La couleur l'animal est requis")>
        Public Property CouleurAml As String

        <Required(ErrorMessage:="L'espece de l'animal est requis")>
        Public Property IdEsp As Integer

        <Required(ErrorMessage:="Le client est requis")>
        Public Property IdClt As Integer

    End Class

End Namespace