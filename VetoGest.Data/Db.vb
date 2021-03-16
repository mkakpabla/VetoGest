Imports System.Configuration
Imports System.Data.SqlClient

Module Db

    Public ReadOnly Property GetConnection As SqlConnection
        Get
            Return New SqlConnection(GetConnectionString)
        End Get

    End Property


    Public Function GetConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("VetoGest").ToString()
    End Function

End Module
