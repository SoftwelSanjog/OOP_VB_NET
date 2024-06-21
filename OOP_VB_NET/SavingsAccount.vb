'Derived Class
Public Class SavingsAccount
    Inherits BankAccount
    Public Sub New(ByVal owner As String)
        MyBase.New(owner)
    End Sub
    Public Overrides ReadOnly Property ID As String
        Get
            Return Me.m_owner & "-S"
        End Get
    End Property
    Private mintrest As Decimal = 0.01D
    Public Property Interest As Decimal
        Get
            Return mintrest
        End Get
        Set(value As Decimal)
            mintrest = value
        End Set
    End Property
    Public Function AddIntrest() As Decimal
        Me.Deposit(Me.Balance * mintrest) 'Here me will points towards the base class method. As saving acc is the derived class of bankaccount
        Return Me.Balance
    End Function
    Public Overrides Function ToString() As String
        Return ID
    End Function
End Class
