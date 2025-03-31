Public Class SplashScreen
    Dim progressValue As Integer = 0
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Set ProgressBar properties
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0

        ' Start Timer
        Timer1.Interval = 30 ' Progress increases every 30ms
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        progressValue += 2
        ProgressBar1.Value = progressValue

        If progressValue >= 100 Then
            Timer1.Stop()
            LoginForm.Show() ' Open the Login Form
            Me.Hide() ' Hide Splash Screen
        End If
    End Sub
End Class
