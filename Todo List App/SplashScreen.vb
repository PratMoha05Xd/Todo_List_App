Public Class SplashScreen
    Private splashTimer As New Timer()

    Sub New()
        InitializeComponent()

        splashTimer.Interval = 3000
        AddHandler splashTimer.Tick, AddressOf SplashScreenTimeout
        splashTimer.Start()
    End Sub


    Private Sub SplashScreenTimeout(ByVal sender As Object, ByVal e As EventArgs)
        splashTimer.Stop()
        splashTimer.Dispose()

        Dim loginForm As New LoginCrud()
        loginForm.Show()

        Me.Hide()
    End Sub

    Private Sub progressBarControl_EditValueChanged(sender As Object, e As EventArgs) Handles progressBarControl.EditValueChanged

    End Sub

    Private Sub peImage_EditValueChanged(sender As Object, e As EventArgs) Handles peImage.EditValueChanged

    End Sub
End Class
