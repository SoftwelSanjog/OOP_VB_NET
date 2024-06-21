<System.ComponentModel.DefaultEvent("DistanceChanged")>
Public Class Train
    Public Event DistanceChanged(ByVal sender As System.Object, ByVal e As DistanceChangedEventArgs)
    Private mspeed As Integer = 0
    Public Property Speed As Integer
        Get
            Return mspeed
        End Get
        Set(value As Integer)
            If value > 0 Then
                mspeed = value
            End If

        End Set
    End Property
    Private mDistance As Integer = 0
    Public ReadOnly Property Distance As Integer
        Get
            Return mDistance
        End Get
    End Property
    Public Sub Restart()
        mDistance = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If mspeed > 0 Then
            mDistance += Convert.ToInt32(Convert.ToInt32(mspeed) * Convert.ToDouble(Timer1.Interval) / 1000.0F)
            RaiseEvent DistanceChanged(Me, New DistanceChangedEventArgs(mDistance))
        End If
    End Sub
End Class
Public Class DistanceChangedEventArgs
    Inherits System.EventArgs
    Private mDistance As Integer
    Public Sub New(ByVal distance As Integer)
        mDistance = distance
    End Sub
    Public ReadOnly Property Distance As Integer
        Get
            Return mDistance
        End Get
    End Property
End Class
