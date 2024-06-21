'Designing Base Classes as Abstract Classes
'What will we do?
'Create an abstract base class using the MustInherit or abstract keyword
'Create a derived class from an abstract class
'Derive from a .net abstract class to create a typed collection class
'Seal a class  using the NonInheritable or Sealed keyword
'Hide a base class member using the shadows
Public MustInherit Class BankAccount
    'Base Class
    Public MustOverride ReadOnly Property ID As String
    Public MustOverride Function PrintStatement() As String
    Private m_Balance As Decimal = 0D
    Public ReadOnly Property Balance As Decimal
        Get
            Return m_Balance
        End Get
    End Property
    Private m_totalDeposits As Decimal = 0D
    Public ReadOnly Property TotalDeposits As Decimal
        Get
            Return m_totalDeposits
        End Get
    End Property
    Private m_totalWithDrawals As Decimal = 0D
    Public ReadOnly Property TotalWithDrawals As Decimal
        Get
            Return m_totalWithDrawals
        End Get
    End Property
    Public Function Deposit(ByVal amount As Decimal) As Decimal
        m_Balance += amount
        m_totalDeposits += amount
        Return m_Balance
    End Function
    Public Overridable Function WithDraw(ByVal amount As Decimal) As Decimal
        m_Balance -= amount
        m_totalWithDrawals -= amount
        Return m_Balance
    End Function
    'Note that the Deposite and Withdraw methods maintains the m_totalDeposite and m_totalWithdrawals fields.
    'The TotalDeposits and TotalWithDrawals properties are readonly.When it's Overriding the Withdraw method,the derived class
    'doesn't have acces  to m_totalWithdrawals and m_totalDeposits fields because they're private fields of the BankAccount class.

End Class
