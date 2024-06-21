Imports System.Runtime.Serialization
Imports System.SerializableAttribute
<Serializable()> Public Class XYPoint
    Implements ISerializable
    Private m_x As Integer
    Private m_y As Integer
    Public Property X As Integer
        Get
            Return m_x
        End Get
        Set(value As Integer)
            m_x = value
        End Set
    End Property
    Public Property Y As Integer
        Get
            Return m_y
        End Get
        Set(value As Integer)
            m_y = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return String.Format("({0},{1})", m_x, m_y)
    End Function
    Public Sub New()

    End Sub
    Public Sub New(ByVal x As Integer, ByVal y As Integer)
        m_x = x
        m_y = y
    End Sub

    Public Sub GetObjectData(info As SerializationInfo, context As StreamingContext) Implements ISerializable.GetObjectData
        info.AddValue("X", m_x)
        info.AddValue("Y", m_y)
    End Sub
    Public Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As System.Runtime.Serialization.StreamingContext)
        m_x = info.GetInt32("X")
        m_y = info.GetInt32("Y")
    End Sub

End Class
