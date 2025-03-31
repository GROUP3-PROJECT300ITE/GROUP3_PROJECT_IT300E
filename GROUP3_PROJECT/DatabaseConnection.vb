Imports System.Data.SqlClient

Module DatabaseConnection

    Public conn As New SqlConnection("Server=PAIGE-3JEONMINP;Database=hoteldb;Trusted_Connection=True;")

    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

End Module
