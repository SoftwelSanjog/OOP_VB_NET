Public Class Bank
    'Lesson Target
    'Inherit from a class we develop
    'Use me keyword
    'use mybase
    'create class field using protected
    'create overridable methods
    'create overrides

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim abankacc As New BankAccount("Sanjog")
        'abankacc.Deposit(100)
        'Console.WriteLine(String.Format("{0:C}", abankacc.Balance))

        'Console.WriteLine("Checking Saving Account")
        'Dim asavingacc As New SavingsAccount("Sanjog")
        'asavingacc.Deposit(1000)
        'Console.WriteLine("Current Balance:{0}", asavingacc.Balance)
        'asavingacc.WithDraw(500)
        'Console.WriteLine("Current WithDraw{0}", asavingacc.Balance)
        'asavingacc.Interest = 0.12
        'Console.WriteLine("current Inrest Rate :{0}", asavingacc.Interest)
        'asavingacc.AddIntrest()
        'Console.WriteLine("Current Balance with intrest.{0}", asavingacc.Balance)

        'Console.WriteLine("Checking Checking Amount")
        'Dim acheckingacc As New CheckingAccount("sanjog")
        'acheckingacc.Deposit(10000)
        'Console.WriteLine("Current Balance in Account:{0}", acheckingacc.Balance)
        'acheckingacc.WithDraw(500)
        'Console.WriteLine("Current Balance after checking deduction: {0}", acheckingacc.Balance)

        'Console.WriteLine("Using the Derived Classes polymorphically")
        ''Not only does inheritance let reuse the code , but it also allows to use classes polymorphically.
        ''This means we can refer to an instance of the derived class as though it were an intance of the base class.

        'Dim account As BankAccount
        'account = New CheckingAccount("sanjog")
        'account.Deposit(1200)
        'Console.WriteLine("Current Balance:{0}", account.Balance)

        Dim savings As New SavingsAccount("Sanjog")
        Dim checking As New CheckingAccount("Sanjog")

        cboAccount.Items.Add(savings)
        cboAccount.Items.Add(checking)

        cboAccount.SelectedIndex = 0
        cboAction.SelectedIndex = 0



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim selectedacc As BankAccount
        Dim item As Object = cboAccount.SelectedItem
        selectedacc = CType(item, BankAccount)
        Select Case cboAction.Text
            Case "Deposit"
                selectedacc.Deposit(Decimal.Parse(txtAmount.Text))
            Case "WithDraw"
                selectedacc.WithDraw(Decimal.Parse(txtAmount.Text))
        End Select
        MsgBox(String.Format("{0}:{1:C}", selectedacc.ID, selectedacc.Balance))
    End Sub

    Private Sub cboAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAccount.SelectedIndexChanged

        If TypeOf (cboAccount.SelectedItem) Is SavingsAccount Then

            btnIntrest.Enabled = True
        Else
            btnIntrest.Enabled = False
        End If
    End Sub

    Private Sub btnIntrest_Click(sender As Object, e As EventArgs) Handles btnIntrest.Click
        If TypeOf (cboAccount.SelectedItem) Is SavingsAccount Then
            Dim thesavingacc As SavingsAccount = CType(cboAccount.SelectedItem, SavingsAccount)
            thesavingacc.AddIntrest()
            MsgBox(String.Format("{0}:{1:C}", thesavingacc.ID, thesavingacc.Balance))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedAccount As BankAccount
        Dim item As Object = cboAccount.SelectedItem
        selectedAccount = CType(item, BankAccount)
        MsgBox(selectedAccount.PrintStatement)
    End Sub
End Class
