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

        Dim products As String() = {"John", "Jack", "Jane"}

        For index As Integer = 0 To products.Length - 1
            Console.WriteLine(products(index))
        Next

        Dim items As New ArrayList From {
            "Harley Davidson",
            1,
            3.33D,
            New Product With {.ProductID = 1}
        }

        Dim listOfProductsAsObjects As New ArrayList From {
            New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP"},
            New Product() With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE"},
            New Product() With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU"}
        }

        For index As Integer = 0 To listOfProductsAsObjects.Count - 1
            ' Direct casting is used to change the data type of the first parameter into the data type of the second one.
            Console.WriteLine(DirectCast(listOfProductsAsObjects(index), Product).Name)
        Next

        Dim productsInMain = LoadProducts()

        'Checks if a specific key exists in the dictionary
        Console.WriteLine(productsInMain.ContainsKey(1))

        'Total number of items in the dictionary
        Console.WriteLine(productsInMain.Count)

        'Removes an item by the key
        'productsInMain.Remove(1)
        'Console.WriteLine(productsInMain.Count)

        'Remove all items
        'productsInMain.Clear()
        'Console.WriteLine(productsInMain.Count)

        'Display the sum of all list prices
        Console.WriteLine(
            productsInMain.Sum(Function(p)
                                   Return p.Value.ListPrice
                               End Function).ToString("c"))

        'Display the average of all list prices
        Console.WriteLine(
            productsInMain.Average(Function(p) p.Value.ListPrice).ToString("c"))

        'Display the minimum of all list prices
        Console.WriteLine(
            productsInMain.Min(Function(p) p.Value.ListPrice).ToString("c"))

        'Display the maximum of all list prices
        Console.WriteLine(
            productsInMain.Max(Function(p) p.Value.ListPrice).ToString("c"))

        Dim listItems = LoadItems()

        'Remove an item by a product object
        listItems.Remove(listItems.Find(Function(p) p.ProductID = 708))
        Console.WriteLine(listItems.Count)

        Dim loopIndex As Integer = 0
        Dim loopSum As Decimal = 0
        Dim min As Decimal = Decimal.MaxValue
        Dim max As Decimal = Decimal.MinValue

        Do While loopIndex < (listItems.Count - 1)
            Console.WriteLine(listItems(loopIndex).ToString())
            loopSum += listItems(loopIndex).ListPrice

            loopIndex += 1
        Loop

        Console.WriteLine("Sum: " & loopSum.ToString("c"))

        Do
            Console.WriteLine(listItems(loopIndex).ToString())
            loopSum += listItems(loopIndex).ListPrice

            loopIndex += 1
        Loop While loopIndex < (listItems.Count - 1)

        Console.WriteLine("Sum: " & loopSum.ToString("c"))

        Do Until loopIndex > (listItems.Count - 1)
            Console.WriteLine(listItems(loopIndex).ToString())

            min = Convert.ToDecimal(
                IIf(listItems(loopIndex).ListPrice < min,
                    listItems(loopIndex).ListPrice,
                    min))

            loopIndex += 1
        Loop

        Console.WriteLine("Min: " & min.ToString("c"))

        Do
            Console.WriteLine(listItems(loopIndex).ToString())

            max = Convert.ToDecimal(
                IIf(listItems(loopIndex).ListPrice > max,
                    listItems(loopIndex).ListPrice,
                    max))

            loopIndex += 1
        Loop Until loopIndex > (listItems.Count - 1)

        Console.WriteLine("Max: " & max.ToString("c"))

        Console.ReadKey()
    End Sub
    Function LoadProducts() As Dictionary(Of Integer, Product)
        Dim products As New Dictionary(Of Integer, Product)
        Dim prod As Product

        prod = New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP", .ListPrice = 1431.5D}
        products.Add(key:=prod.ProductID, value:=prod)

        prod = New Product() With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BH-23", .ListPrice = 102.5D}
        products.Add(prod.ProductID, prod)

        prod = New Product() With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "IT-11", .ListPrice = 131.5D}
        products.Add(prod.ProductID, prod)

        Return products
    End Function

    Function LoadItems() As List(Of Product)
        Dim products As New List(Of Product) From {
            New Product() With {.ProductID = 680, .Name = "Ferrari", .ProductNumber = "FR-201", .ListPrice = 105},
            New Product() With {.ProductID = 706, .Name = "Alfa Romeo", .ProductNumber = "AR-101", .ListPrice = 423},
            New Product() With {.ProductID = 707, .Name = "Alpine", .ProductNumber = "AA-50", .ListPrice = 654},
            New Product() With {.ProductID = 710, .Name = "Aston Martin", .ProductNumber = "AM-22", .ListPrice = 647},
            New Product() With {.ProductID = 711, .Name = "Honda", .ProductNumber = "HD-13", .ListPrice = 767},
            New Product() With {.ProductID = 713, .Name = "Red Bull", .ProductNumber = "RB-11", .ListPrice = 763},
            New Product() With {.ProductID = 714, .Name = "Williams", .ProductNumber = "WS-01", .ListPrice = 987}
        }

        Return products
    End Function

    Sub IncrementListPrice()
        Static ListPrice As Decimal = 0

        ListPrice += 1

        Console.WriteLine(ListPrice)
    End Sub
End Module