
<Serializable()> Public Class Traingle
    Public Sub New()

    End Sub
    Private m_points() As XYPoint = {New XYPoint(), New XYPoint(), New XYPoint()}
    Public Property Points() As XYPoint()
        Get
            Return m_points
        End Get
        Set(value As XYPoint())
            If (value.Length = 3) Then
                m_points = value
            End If
        End Set
    End Property
    Public Sub New(ByVal a As XYPoint, ByVal b As XYPoint, c As XYPoint)
        m_points = New XYPoint() {a, b, c}
    End Sub
    Public Overrides Function ToString() As String
        Dim trainglestring As String = String.Empty
        Dim point As Integer
        For point = 0 To m_points.Length - 1
            trainglestring += m_points(point).ToString() + " "
        Next
        Return trainglestring
    End Function

End Class
