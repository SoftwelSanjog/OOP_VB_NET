Public Class PatternMaker
    Private Sub PatternMaker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class PatternButton
    Inherits UserControl
    Private m_pattern As Pattern
    Public Sub New(ByVal Newpattern As Pattern)
        Me.Size = New Size(61, 61)
        m_pattern = Newpattern
        AddHandler Me.Paint, AddressOf Newpattern.Draw
    End Sub
    Public Property pattern() As Pattern
        Get
            Return m_pattern
        End Get
        Set(value As Pattern)
            m_pattern = value
        End Set
    End Property
End Class