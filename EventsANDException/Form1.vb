Public Class Form1
    Private Sub Track1_CaughtOnFire(sender As Object, e As CaughtOnFireEventArgs) Handles Track1.CaughtOnFire
        fire.Location = New Point(Track1.Left + e.Location, Track1.Top - fire.Height)
    End Sub

    Private Sub Train1_DistanceChanged(sender As Object, e As DistanceChangedEventArgs) Handles Train1.DistanceChanged
        Train1.Left = Track1.Left + e.Distance
        If Train1.Right >= Track1.Right Then
            Train1.Speed = 0
            throttle.Value = 0
        End If
    End Sub

    Private Sub throttle_ValueChanged(sender As Object, e As EventArgs) Handles throttle.ValueChanged
        If Train1.Right < Track1.Right Then
            Train1.Speed = throttle.Value
        Else
            throttle.Value = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Train1.Restart()
        throttle.Value = 0
        Train1.Speed = 0
        Train1.Left = Track1.Left
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
