Public Class CheckingAccount
    Inherits BankAccount
    Public Sub New(ByVal owner As String)
        MyBase.New(owner)
    End Sub
    Public Overrides ReadOnly Property ID As String
        Get
            Return Me.m_owner & "-C"
        End Get
    End Property
    Public Overrides Function WithDraw(amount As Decimal) As Decimal
        MyBase.WithDraw(amount) 'For each withdraw a certain amount 0.25 is deducted.
        MyBase.WithDraw(0.25D)
        Return MyBase.Balance
    End Function
    Public Overrides Function ToString() As String
        Return ID
    End Function
End Class
