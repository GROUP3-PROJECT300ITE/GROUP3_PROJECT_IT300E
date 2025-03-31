
Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBookRoom_Click(sender As Object, e As EventArgs) Handles btnBookRoom.Click
        Dim bookRoom As New BookRoom
        bookRoom.Show()
        Me.Hide()
    End Sub

    Private Sub btnGuestDetails_Click(sender As Object, e As EventArgs) Handles btnGuestDetails.Click
        Dim guestDetails As New GuestDetails
        guestDetails.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Dim login As New LoginForm
            login.Show()
            Me.Close()
        End If
    End Sub

End Class