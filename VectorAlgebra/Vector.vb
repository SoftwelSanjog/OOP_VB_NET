Public Class Vector
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        m_x = x
        m_y = y
    End Sub
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
    Public Shared Operator =(ByVal avector As Vector, ByVal bvector As Vector) As Boolean
        Return (avector.X = bvector.X) And (avector.Y = bvector.Y)
    End Operator
    Public Shared Operator <>(ByVal avector As Vector, ByVal bvector As Vector) As Boolean
        Return avector = bvector
    End Operator
    Public Shared Operator +(ByVal avector As Vector, ByVal bvector As Vector) As Vector
        Return New Vector((avector.X + bvector.X), (avector.Y + bvector.Y))
    End Operator
    Public Shared Operator -(ByVal avector As Vector) As Vector
        Return New Vector(-avector.X, -avector.Y)
    End Operator
    Public Shared Operator -(ByVal avector As Vector, ByVal bvector As Vector) As Vector
        Return avector + (-bvector)
    End Operator
    Public Shared Operator *(ByVal avector As Vector, ByVal scalar As Integer) As Vector
        Return New Vector(avector.X * scalar, avector.Y * scalar)
    End Operator
    Public Shared Operator /(ByVal avector As Vector, ByVal scalar As Integer) As Vector
        Return New Vector(avector.X / scalar, avector.Y / scalar)
    End Operator
    Public Shared Function Parse(ByVal vectorstring As String) As Vector
        Try
            Dim values() As String
            values = vectorstring.Split(",")
            Dim x As Integer = Integer.Parse(values(0).ToString)
            Dim y As Integer = Integer.Parse(values(1).ToString)
            Return New Vector(x, y)
        Catch ex As Exception
            Throw New ArgumentException("Unable to parse " & vectorstring & "into Vector instance")
        End Try


    End Function

End Class
