Public Class CheckingAccount
    Inherits BankAccount
    Private m_owner As String
    Public Sub New(ByVal owner As String)
        m_owner = owner
    End Sub
    Public Overrides ReadOnly Property ID As String
        Get
            Return m_owner & "-C"
        End Get
    End Property
    Dim m_checks As Integer = 0
    Public Overrides Function WithDraw(amount As Decimal) As Decimal
        m_checks += 1
        Return MyBase.WithDraw(amount + 0.25D)
    End Function
    Public Overrides Function ToString() As String
        Return ID
    End Function
    Public Overrides Function PrintStatement() As String
        Dim statement As String = String.Format("{1}{0}" & "Opening Balance: $0.00{0} Deposit:{2:C}{0}" &
                                                "Withdrawals :{3:C}{0} Check Written:{4}{0}Checking Charges:" &
                                                "{5:C}{0} Ending Balance:{6:C}{0}",
                                                New Object() {ControlChars.CrLf, Me.ID, Me.TotalDeposits,
                                                Me.TotalWithDrawals - (m_checks * 0.25D), Me.m_checks, Me.m_checks * 0.25D, Me.Balance})
        Return statement
    End Function
End Class
