Imports System.Data.SqlClient

Public Class GuestDetails

    Dim conn As New SqlConnection("server=PAIGE-3JEONMINP; database=hoteldb; integrated security=true")

    Private Sub GuestDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load all guest details when form loads
        LoadGuestDetails()
    End Sub

    ' Function to load all guest details into DataGridView
    Private Sub LoadGuestDetails()
        Try
            conn.Open()
            Dim query As String = "SELECT Bookings.GuestName, Bookings.Phone, Rooms.RoomNumber, Bookings.CheckInDate, Bookings.CheckOutDate, Bookings.Price 
                                   FROM Bookings INNER JOIN Rooms ON Bookings.RoomID = Rooms.RoomID"
            Dim cmd As New SqlCommand(query, conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvGuestDetails.DataSource = table
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading guest details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New Dashboard
        dashboard.Show()
        Me.Close()
    End Sub
End Class
