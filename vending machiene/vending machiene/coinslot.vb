Public Class coinslot
    Public Property Quarters As Integer
    Public Property Nickles As Integer
    Public Property Dimes As Integer
    Public Property Pennies As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property total As Decimal
        Get
            Return Dollars * 1 + Quarters * 0.25 + Dimes * 0.1 + Nickles * 0.05 + Pennies * 0.01
        End Get

    End Property

    Public Sub coinReturn()
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
End Class
