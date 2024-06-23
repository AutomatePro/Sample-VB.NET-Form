Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class EyeOPDDatabase
    Private connectionString As String = "Server = xxx; Database = xxxx; User=xxxx;Pwd= xxxx;"

    ' Method to get a SqlConnection object
    Public Function GetConnection() As SqlConnection
        Dim connection As New SqlConnection(connectionString)
        Return connection
    End Function

    Public Function ExecuteQuery(ByVal query As String) As DataTable
        Dim dataTable As New DataTable()

        Using connection As SqlConnection = GetConnection()
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)

            Try
                connection.Open()
                adapter.Fill(dataTable)
            Catch ex As Exception
                ' Handle any exceptions here
            End Try
        End Using

        Return dataTable
    End Function

    Public Function CreateSqlCommand(ByVal query As String) As SqlCommand
        Dim connection As SqlConnection = GetConnection()
        Dim command As New SqlCommand(query, connection)
        Return command
    End Function

Public Function ExecuteStoredProcedure(storedProcedureName As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim result As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(storedProcedureName, connection)
                command.CommandType = CommandType.StoredProcedure

                ' Add parameters to the command
                For Each param In parameters
                    command.Parameters.AddWithValue(param.Key, param.Value)
                Next

                Using adapter As New SqlDataAdapter(command)
                    connection.Open()
                    adapter.Fill(result)
                End Using
            End Using
        End Using

        Return result
    End Function

    Private Sub AddParameters(ByVal command As SqlCommand, ByVal parameters As Dictionary(Of String, Object))
        If parameters IsNot Nothing AndAlso parameters.Count > 0 Then
            For Each kvp As KeyValuePair(Of String, Object) In parameters
                command.Parameters.AddWithValue(kvp.Key, kvp.Value)
            Next
        End If
    End Sub



End Class

