<Serializable()> Public Class TraingleCollection
    Inherits CollectionBase
    Public Sub Add(ByVal tri As Traingle)
        Me.InnerList.Add(tri)
    End Sub
    Public Sub Remove(ByVal tri As Traingle)
        Me.InnerList.Remove(tri)
    End Sub
    Public Overrides Function ToString() As String
        Dim traingles As String = String.Empty
        Dim tri As Traingle
        For Each tri In Me.InnerList
            traingles += tri.ToString & ControlChars.CrLf
        Next
        Return traingles
    End Function
    Public Function ToArray() As Object()
        Dim triangle(Me.Count - 1) As Object
        Dim tri As Integer
        For tri = 0 To Me.Count - 1
            triangle(tri) = InnerList(tri)
        Next
        Return triangle
    End Function
    Default Public Property Item(ByVal index As Integer) As Traingle
        Get
            Return CType(InnerList.Item(index), Traingle)
        End Get
        Set(value As Traingle)
            InnerList.Item(index) = value
        End Set
    End Property
End Class
