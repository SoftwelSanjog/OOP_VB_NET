'Derived Class
Public Class SavingsAccount
    Inherits BankAccount
    Private m_owner As String
    'Define  Constructor
    Public Sub New(ByVal owner As String)
        m_owner = owner
    End Sub
    Public Overrides ReadOnly Property ID As String
        Get
            Return m_owner & "-S"
        End Get
    End Property
    Private minterest As Decimal = 0.01D
    Public Property Interest As Decimal
        Get
            Return minterest
        End Get
        Set(value As Decimal)
            minterest = value
        End Set
    End Property
    Private m_totalInterest As Decimal = 0D
    Public Function AddIntrest() As Decimal
        Dim interest As Decimal = minterest * Me.Balance
        m_totalInterest += interest
        Me.Deposit(interest) 'Here me will points towards the base class method. As saving acc is the derived class of bankaccount
        Return Me.Balance
    End Function
    Public Overrides Function ToString() As String
        Return ID
    End Function

    Public Overrides Function PrintStatement() As String
        Dim statement As String = String.Format("{1}{0}" & "Opening Balance: $0.00{0} Deposit:{2:C}{0}" &
                                                "Withdrawals :{3:C}{0} Interest:{4:C}{0}Ending Balance: {5:C}{0}", New Object() {ControlChars.CrLf, Me.ID, Me.TotalDeposits - Me.m_totalInterest, Me.TotalWithDrawals, Me.m_totalInterest, Me.Balance})
        Return statement
    End Function
End Class
