Imports System.Data.SqlClient

Public Class BookRoom

    Dim conn As New SqlConnection("server=PAIGE-3JEONMINP; database=hoteldb; integrated security=true")

    Private Sub BookRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateRoomStatus()
        ' Load available rooms into ComboBox
        LoadAvailableRooms()
    End Sub

    ' Updates room status if checkout time has passed
    Private Sub UpdateRoomStatus()
        Try
            conn.Open()
            Dim query As String = "UPDATE Rooms SET Status = 'Available' WHERE RoomID IN (SELECT RoomID FROM Bookings WHERE CheckOutDate < GETDATE())"
            Dim cmd As New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error updating room status: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadAvailableRooms()
        Try
            conn.Open()
            Dim query As String = "SELECT RoomNumber FROM Rooms WHERE Status='Available'"
            Dim cmd As New SqlCommand(query, conn)
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            cmbRoomNumber.Items.Clear()
            While reader.Read()
                cmbRoomNumber.Items.Add(reader("RoomNumber").ToString())
            End While

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading rooms: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSaveBooking_Click(sender As Object, e As EventArgs) Handles btnSaveBooking.Click
        Try
            ' Validate input
            If cmbRoomNumber.Text = "" Or txtGuestName.Text = "" Or txtPhone.Text = "" Then
                MessageBox.Show("Please fill all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            ' Check if Room Number is selected
            If cmbRoomNumber.SelectedIndex = -1 Then
                MessageBox.Show("Select a room number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbRoomNumber.Focus()
                Return
            End If

            ' Check if Check-in Date is valid
            If dtpCheckIn.Value.Date < DateTime.Today Then
                MessageBox.Show("Check-in date cannot be in the past!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpCheckIn.Focus()
                Return
            End If

            ' Check if Check-out Date is valid
            If dtpCheckOut.Value <= dtpCheckIn.Value Then
                MessageBox.Show("Check-out date must be after check-in date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpCheckOut.Focus()
                Return
            End If

            ' Check if Price is valid
            If Not IsNumeric(txtPrice.Text) OrElse Convert.ToDecimal(txtPrice.Text) <= 0 Then
                MessageBox.Show("Enter a valid price!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPrice.Focus()
                Return
            End If

            conn.Open()
            Dim query As String = "INSERT INTO Bookings (GuestName, Phone, RoomID, CheckInDate, CheckOutDate,Price) 
                                   VALUES (@guest, @phone, (SELECT RoomID FROM Rooms WHERE RoomNumber = @room), @checkIn, @checkOut, @Price);
                                   UPDATE Rooms SET Status = 'Booked' WHERE RoomNumber = @room"
            Dim cmd As New SqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@guest", txtGuestName.Text)
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text)
            cmd.Parameters.AddWithValue("@room", cmbRoomNumber.SelectedItem)
            cmd.Parameters.AddWithValue("@checkIn", dtpCheckIn.Value)
            cmd.Parameters.AddWithValue("@checkOut", dtpCheckOut.Value)
            cmd.Parameters.AddWithValue("@Price", txtPrice.Text)
            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Room booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadAvailableRooms() ' Refresh room list
            txtGuestName.Clear()
            txtPhone.Clear()
            txtPrice.Clear()
            cmbRoomNumber.SelectedIndex = -1
            dtpCheckIn.Value = DateTime.Now
            dtpCheckOut.Value = DateTime.Now
        Catch ex As Exception
            MessageBox.Show("Error booking room: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim dashboard As New Dashboard
        dashboard.Show()
        Me.Close()
    End Sub

    Private Sub txtGuestName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuestName.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) And Not e.KeyChar = ChrW(Keys.Delete) And Not e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True

            MessageBox.Show("Enter letters only")
            txtGuestName.Focus()

        End If
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) And Not e.KeyChar = ChrW(Keys.Delete) And Not e.KeyChar = ChrW(Keys.Space) Then
            e.Handled = True

            MessageBox.Show("Enter numbers only")
            txtPhone.Focus()

        End If
    End Sub
End Class
