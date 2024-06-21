Public Class Person
    'Overriding the Tostring property to display the Person Class in Listbox
    Public Overrides Function ToString() As String
        Return mFirstName & " " & mLastName
    End Function
    Public Sub New(ByVal name As String)
        Try
            Dim names() As String = name.Split(" ")
            mFirstName = names(0)
            mLastName = names(1)
        Catch ex As Exception
            Throw New NameFormatIncorretException("Could not found the name or last name", ex)
        End Try

    End Sub
    Private mFirstName As String
    Public Property FirstName As String
        Get
            Return mFirstName
        End Get
        Set(value As String)
            mFirstName = value
        End Set
    End Property
    Private mLastName As String
    Public Property LastName As String
        Get
            Return mLastName
        End Get
        Set(value As String)
            mLastName = value
        End Set
    End Property
End Class
Public Class NameFormatIncorretException
    Inherits System.ApplicationException
    Public Sub New()
        MyBase.New
    End Sub
    Public Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
    Public Sub New(ByVal msg As String, ByVal ex As Exception)
        MyBase.New(msg, ex)
    End Sub
End Class
