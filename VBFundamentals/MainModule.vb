Module MainModule
    Dim Title As String = "Jason Bourne"

    'Private Const DEFAULT_ACTIVE As Boolean = True
    'Private Const DEFAULT_LIST_PRICE As Decimal = 999.99D


    Sub Main()
        Dim ProductID As Integer
        Dim isActive As Boolean
        Dim Name As String
        Dim ListPrice As Decimal
        Dim SellStartDate As DateTime
        Dim ProductNumber As String = "10-SP"


        ProductID = 1
        isActive = ClassConstants.DEFAULT_ACTIVE
        Name = "John McClane"
        ListPrice = ClassConstants.DEFAULT_LIST_PRICE
        SellStartDate = #12/13/2014#

        Console.WriteLine(Title)

        IncrementListPrice()
        IncrementListPrice()
        IncrementListPrice()

        'Object data type can hold multiple data types - not recommended to use
        Dim theData As Object

        theData = "Viper"
        Console.WriteLine(theData)

        theData = 3
        Console.WriteLine(theData)

        theData = 12.3D
        Console.WriteLine(theData)

        Dim Subject As String = "Die Hard With A Vengance."

        'vbCrLf is used to add a new row.
        Console.WriteLine(vbCrLf & "Built-in String Methods")
        Console.WriteLine(Subject.Length)
        Console.WriteLine(Subject.IndexOf(" "))
        Console.WriteLine(Subject.EndsWith("e"))
        Console.WriteLine(Subject.Insert(13, "out"))
        Console.WriteLine(Subject.Remove(0, 9))
        Console.WriteLine(Subject.Replace("Hard", "Soft"))
        Console.WriteLine(Subject.ToUpper())
        Console.WriteLine(Subject.ToLower())

        Dim Price As Decimal = 999.99D

        'vbCrLf is used to add a new row.
        Console.WriteLine(vbCrLf & "Built-in Numeric Methods")
        Console.WriteLine(Price.Equals(999.99D))
        Console.WriteLine(Decimal.MinValue)
        Console.WriteLine(Decimal.MaxValue)
        Console.WriteLine(Decimal.Ceiling(Price)) 'The next highest whole number
        Console.WriteLine(Decimal.Floor(Price)) 'The next lowest whole number

        Decimal.TryParse("55.01", Price)
        Console.WriteLine(Price)

        Dim SellDate As DateTime = #9/13/1990 08:00:01 AM#

        'vbCrLf is used to add a new row.
        Console.WriteLine(vbCrLf & "Build-in DateTime Methods")
        Console.WriteLine(SellDate.AddDays(10))
        Console.WriteLine(SellDate.AddDays(-10))
        Console.WriteLine(SellDate.AddYears(31))
        Console.WriteLine(SellDate.AddYears(-2))

        Console.WriteLine(SellDate.Date)
        Console.WriteLine(SellDate.Day)
        Console.WriteLine(SellDate.DayOfWeek)
        Console.WriteLine(SellDate.Year)
        Console.WriteLine(SellDate.DayOfYear)

        Console.WriteLine(SellDate.Hour)
        Console.WriteLine(SellDate.Minute)
        Console.WriteLine(SellDate.Second)

        Dim prod As New Product(1000)
        Dim sellingDate As DateTime

        prod.SellStartDate = #1/1/2021#

        sellingDate = prod.CalculateSellEndDate(30)

        Console.WriteLine("Sell date with use of a function: " + sellingDate)

        prod.CalculateSellEndDate(20, sellingDate)

        Console.WriteLine(sellingDate)

        Console.WriteLine("This is the end date " + prod.SellEndDate)

        'prod.StandardCost = 250
        'prod.ListPrice = 500

        Console.WriteLine(prod.CalculateProfit())
        'Console.WriteLine(prod.CalculateProfit(700))

        Console.WriteLine(Product.CalculateTheProfit(900, 1400))

        Dim latestProduct As New Product With {
            .ProductID = 700,
            .Name = "10 Specialized Bike",
            .ProductNumber = "10-SP"
        }

        Console.WriteLine(latestProduct.ToString())

        Dim latestCustomer As New Customer With {
            .CustomerID = 1,
            .CompanyName = "Apple Computers Inc.",
            .FirstName = "James",
            .LastName = "Bond"
        }

        Console.WriteLine(latestCustomer.ToString())

        Console.ReadKey()
    End Sub

    Sub IncrementListPrice()
        Static ListPrice As Decimal = 0

        ListPrice += 1

        Console.WriteLine(ListPrice)
    End Sub

End Module
