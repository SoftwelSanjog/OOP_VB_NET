Public Class SortedPointList
    Implements IEnumerable
    Public Sub New()

    End Sub
    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return New PointEnumerator(m_points)
    End Function
    Private m_points As New ArrayList
    Public Sub AddRandomPoints(ByVal howmany As Integer, ByVal maximum As Integer)
        m_points.Clear()
        Dim rgen As New System.Random
        Dim count As Integer
        For count = 0 To howmany - 1
            m_points.Add(New SortablePoint(rgen.Next(maximum), rgen.Next(maximum)))
        Next
        m_points.Sort()
    End Sub
    Private Class PointEnumerator
        Implements IEnumerator
        Dim m_points As ArrayList
        Dim m_position As Integer = -1
        Dim m_initialCount As Integer

        Public Sub New(ByVal points As ArrayList)
            m_points = points
            m_initialCount = points.Count
        End Sub
        Public ReadOnly Property Current As Object Implements IEnumerator.Current
            Get
                If m_initialCount <> m_points.Count Then
                    Throw New InvalidOperationException("Collection has changed during Enumeration")
                ElseIf (m_position >= m_points.Count) Then
                    Throw New InvalidOperationException("Enumeration value is invalid")
                Else
                    Return m_points(m_position)
                End If
            End Get
        End Property

        Public Sub Reset() Implements IEnumerator.Reset
            m_position = -1
        End Sub

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            If m_initialCount = m_points.Count Then
                m_position += 1
                If (m_position >= m_points.Count) Then
                    Return False
                Else
                    Return True
                End If
            Else
                Throw New InvalidOperationException("Collection has changed during enumeration")
            End If
        End Function
    End Class
End Class
