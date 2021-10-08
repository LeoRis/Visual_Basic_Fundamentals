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

        Console.WriteLine("Built-in String Methods")
        Console.WriteLine(Subject.Length)
        Console.WriteLine(Subject.IndexOf(" "))
        Console.WriteLine(Subject.EndsWith("e"))
        Console.WriteLine(Subject.Insert(13, "out"))
        Console.WriteLine(Subject.Remove(0, 9))
        Console.WriteLine(Subject.Replace("Hard", "Soft"))
        Console.WriteLine(Subject.ToUpper())
        Console.WriteLine(Subject.ToLower())

        Console.ReadKey()

    End Sub

    Sub IncrementListPrice()
        Static ListPrice As Decimal = 0

        ListPrice += 1

        Console.WriteLine(ListPrice)
    End Sub

End Module
