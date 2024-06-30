Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb


Public Class EyeOPDDatabase
    Private connectionString As String = "Server = SMJ; Database = EyeOPD; User=AP_User;Pwd= XORMac123#;"

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

    Public Function executeActionQuery(ByVal query As String, ByVal parameters As Dictionary(Of String, Object)) As Integer
        Dim rowsAffected As Integer = 0

        Using connection As SqlConnection = GetConnection()
            Dim command As New SqlCommand(query, connection)

            ' Add parameters to the command
            For Each param In parameters
                command.Parameters.AddWithValue(param.Key, param.Value)
            Next

            Try
                connection.Open()
                rowsAffected = command.ExecuteNonQuery()
            Catch ex As Exception
                ' Log the exception or rethrow it
                Throw New Exception("An error occurred while updating the database.", ex)
            End Try
        End Using

        Return rowsAffected
    End Function

    Public Function CreateSqlCommand(ByVal query As String) As SqlCommand
        Dim connection As SqlConnection = GetConnection()
        Dim command As New SqlCommand(query, connection)
        Return command
    End Function

    Public Function ExecuteStoredProcedure(ByVal storedProcedureName As String, ByVal parameters As Dictionary(Of String, Object)) As DataTable
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



'Public Class EyeOPD_DAL

'    Public Con As New SqlConnection With {.ConnectionString = "Server = SMJ; Database = EyeOPD; User=AP_User;Pwd= XORMac123#;"}
'    Public Cmd As SqlCommand
'    Public Dap As SqlDataAdapter
'    Public Das As DataSet

'    Public Function HasConnection() As Boolean
'        Try
'            Con.Open()
'            Con.Close()
'            Return True
'        Catch ex As Exception
'            MsgBox(ex.Message)
'            Return False
'        End Try
'    End Function

'    Public Sub RunQuery(ByVal Query As String)
'        Try
'            Con.Open()

'            Cmd = New SqlCommand(Query, Con)

'            ' LOAD SQL RECORDS FOR DATAGRID
'            Dap = New SqlDataAdapter(Cmd)
'            Das = New DataSet
'            Dap.Fill(Das)
'            ' READ DIRECTLY FROM DATABASE
'            'Dim R As SqlDataReader = Cmd.ExecuteReader

'            'While R.Read
'            'MsgBox(R.GetName(0) & ": " & R(0))
'            'End While

'            Con.Close()
'            Return Das

'        Catch ex As Exception
'            MsgBox(ex.Message)

'            If Con.State = ConnectionState.Open Then
'                Con.Close()
'            End If
'        End Try
'    End Sub

'    'Public Sub DataInsert(StockID As Integer, StockName As String, Category As String, Quantity As Integer, Dat As String, Time As Integer)
'    '    Try
'    '        Dim AddVal As String = "INSERT INTO TB_Stocks([Stock ID], [Stock Name], Category, Quantity) VALUES ('" & StockID & "', '" & StockName & "', '" & Category & "', '" & Quantity & "', '" & Dat & "', '" & Time & "')"
'    '        MsgBox(AddVal)

'    '        Con.Open()
'    '        Cmd = New SqlCommand(AddVal, Con)

'    '        Cmd.ExecuteNonQuery()
'    '        Con.Close()
'    '    Catch ex As Exception

'    '    End Try

'    'End Sub

'    Public Sub DataDelete(ByVal Command As String)

'        Try
'            Con.Open()

'            Cmd = New SqlCommand(Command, Con)

'            Dim ChangeCount As Integer = Cmd.ExecuteNonQuery

'            Con.Close()

'            'REPORT(RESULTS)

'            If ChangeCount = 0 Then

'                MsgBox("The Item you want to update could not be found.")

'            Else

'                MsgBox(ChangeCount & " Record(s) Affected! ")

'            End If

'        Catch ex As Exception

'            MsgBox(ex.Message)

'        End Try
'    End Sub

'    Public Function DataUpdate(ByVal Command As String) As Integer

'        Try
'            Con.Open()

'            Cmd = New SqlCommand(Command, Con)

'            Dim ChangeCount As Integer = Cmd.ExecuteNonQuery

'            Con.Close()
'            Return ChangeCount

'        Catch ex As Exception

'            MsgBox(ex.Message)

'        End Try
'        Return 0
'    End Function
'End Class
