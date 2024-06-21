Imports System.Drawing.Graphics
'A caughtOnFire event for the Track Class.
'This Event, generates by the track will be received byt the form so that the code in the form can move the file on the track. 
'The Frequency Property will be moved To the track class To indicate how often the track shoud raise a CaughtOnFire Event.
<System.ComponentModel.DefaultEvent("CaughtOnFire")>
Public Class Track
    Public Event CaughtOnFire(ByVal sender As System.Object, ByVal e As CaughtOnFireEventArgs)
    Private Const TrackHeight As Integer = 25 'Must be divisible by 5
    Private Const BarWidth As Integer = TrackHeight / 5 ' Equal to rail Width.
    Private Const BarSpacing As Integer = BarWidth * 2
    Private mFrequency As Integer = 3
    Public Property Frequency As Integer
        Get
            Return mFrequency
        End Get
        Set(value As Integer)
            If mFrequency > 1 Then
                mFrequency = value
                Timer1.Interval = mFrequency * 1000
            End If
        End Set
    End Property

    Private Sub Track_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 15
    End Sub
    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        Me.Height = TrackHeight
        'width must be divisible by BarSpacing
        Dim nBars As Integer = Me.Width / BarSpacing
        Me.Width = nBars * BarSpacing

    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim gp As New Drawing2D.GraphicsPath
        gp.FillMode = Drawing2D.FillMode.Winding
        Dim height As Integer = TrackHeight / 5
        Dim nBars As Integer = Me.Width / BarSpacing
        Dim bar As Integer
        For bar = 0 To nBars - 1
            gp.AddRectangle(New Rectangle(bar * BarSpacing, height, BarSpacing, height))
            gp.AddRectangle(New RectangleF(bar * BarSpacing, height * 3, BarSpacing, height))
            gp.AddRectangle(New RectangleF(bar * BarSpacing, 0, BarWidth, TrackHeight))
        Next
        e.Graphics.FillPath(Brushes.ForestGreen, gp)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim randomNumber As New Random
        RaiseEvent CaughtOnFire(Me, New CaughtOnFireEventArgs(randomNumber.Next(0, Me.Width)))
    End Sub
End Class
Public Class CaughtOnFireEventArgs
    Inherits System.EventArgs
    'Add the Constructor.Because the CaughtOnFireEventArgs class is instantiated only when a fire Exists.The Constructor requires the location parameter.
    Public Sub New(ByVal Location As Integer)
        mlocation = Location
    End Sub

    'Add a location propertyy that indicates how far along the track in pixels the new fire is located.
    Private mlocation As Integer = 0
    Public ReadOnly Property Location As Integer
        Get
            Return mlocation
        End Get
    End Property
End Class
