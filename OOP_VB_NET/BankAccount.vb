Public Class BankAccount
    'Base Class
    Public Sub New(ByVal owner As String)
        Me.m_owner = owner
        Me.m_Balance = 0D 'Decimal (Advantage of using Decimal data type is that rounding doesn't occur)
    End Sub
    Protected m_owner As String 'protected fields are available to derived class
    Public Overridable ReadOnly Property ID As String
        Get
            Return m_owner
        End Get
    End Property
    Private m_Balance As Decimal
    Public ReadOnly Property Balance As Decimal
        Get
            Return m_Balance
        End Get
    End Property
    Public Function Deposit(ByVal amount As Decimal) As Decimal
        m_Balance += amount
        Return m_Balance
    End Function
    Public Overridable Function WithDraw(ByVal amount As Decimal) As Decimal
        m_Balance -= amount
        Return m_Balance
    End Function
End Class
