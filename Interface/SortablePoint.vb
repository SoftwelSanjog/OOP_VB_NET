Public Class SortablePoint
    Implements IComparable
    Private m_x As Integer
    Public Property X As Integer
        Get
            Return m_x
        End Get
        Set(value As Integer)
            m_x = value
        End Set
    End Property
    Private m_y As Integer
    Public Property Y As Integer
        Get
            Return m_y
        End Get
        Set(value As Integer)
            m_y = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        m_x = x
        m_y = y
    End Sub
    'The COmpareTo method compares the one class instance me to the another instance of class.Obj.. If the
    'two instances are equal acc to class's defination of sorting ,compareTo return 0.If the me instance
    'is larger (comes second),Compareto Returns positive integer.
    'if the me is smaller (comes first) ,compareto returns a negative integer.

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return Me.SquareDistance() - CType(obj, SortablePoint).SquareDistance
    End Function
    Private Function SquareDistance() As Integer
        Return m_x * m_x + m_y * m_y
    End Function

    'Private Overloads Function ToString(format As String, formatProvider As IFormatProvider) As String Implements IFormattable.ToString
    '    Dim result As String
    '    Select Case format.ToUpper
    '        Case "L"
    '            result = String.Format("({0},{1})", m_x, m_y)
    '        Case "S"
    '            result = String.Format("{0}:{1}", m_x, m_y)
    '        Case Else
    '            result = (m_x.ToString(format, formatProvider) & " " & m_y.ToString(format, formatProvider))

    '    End Select
    '    Return result
    'End Function
    Public Overrides Function ToString() As String
        Return String.Format("({0},{1})", m_x, m_y)
    End Function
    'Public Function ToString(ByVal format As String) As String
    '    Return Me.ToString(format, Nothing)
    'End Function

End Class
