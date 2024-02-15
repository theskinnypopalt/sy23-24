Public Class coinslot
    Public Event dispense(p As Image)
    Public Event coinReturnevent(d As Integer, q As Integer, dm As Integer, n As Integer, p As Integer)
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Pennies As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            _total = Dollars * 1 + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05 + Pennies * 0.01
            Return _total
        End Get

    End Property

    Public Sub coinReturn()
        RaiseEvent coinReturnevent(Dollars, Quarters, Dimes, Nickles, Pennies)
        Dollars = 0
        Quarters = 0
        Dimes = 0
        Nickles = 0
        Pennies = 0
    End Sub
    Public Sub insertQuarter()
        Quarters = Quarters + 1
    End Sub
    Public Sub insertNickles()
        Nickles = Nickles + 1
    End Sub
    Public Sub insertDimes()
        Dimes = Dimes + 1
    End Sub
    Public Sub insertPennies()
        Pennies = Pennies + 1
    End Sub
    Public Sub insertDollars()
        Dollars = Dollars + 1
    End Sub
    Public Sub buy(p As productControl)
        If p.count > 0 And total >= p.price Then
            p.buy()
            _total = _total - p.price
            Dollars = 0
            Quarters = 0
            Dimes = 0
            Pennies = 0
            Nickles = _total / 0.05
            RaiseEvent dispense(p.picture)
        End If
    End Sub
End Class
