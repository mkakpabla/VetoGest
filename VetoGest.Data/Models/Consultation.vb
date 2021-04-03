Imports System.ComponentModel.DataAnnotations

Namespace Models
    Public Class Consultation

        Public Property IdCons As Integer

        <Required(ErrorMessage:="La date de consultation est requise")>
        Public Property DateCons As Date

        <Required(ErrorMessage:="L'observation est requise")>
        Public Property ObsCons As String

        <Required(ErrorMessage:="La raison est requise")>
        Public Property RaisonCons As String

        <Required(ErrorMessage:="Le prix est requise")>
        Public Property PrixCons As Double

        Public Property IdMed As Integer

        Public Property IdAgt As Integer

        Public Property IdAml As Integer

    End Class
End Namespace
