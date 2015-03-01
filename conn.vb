Imports System.Data.SqlClient
Module mdlDBConnection
    Public BIS
    Public connBIS As SqlConnection

    Public Sub OpenConnection()
        Try
            connBIS = New SqlConnection
            Dim server_name As String = "localhost" '"localhost\SQLEXPRESS"
            Dim db_name As String = "BONINGS"

            connBIS.ConnectionString = "Server=" + server_name + ";Database=" + db_name + ";Trusted_Connection=Yes;"
            connBIS.Open()
        Catch ex As Exception
            MsgBox("Cannot Connect to Database Server.")
            Application.Exit()
        End Try

    End Sub

    Public Sub CloseConnection()
        connBIS.Close()
        connBIS.Dispose()
    End Sub
End Module
