Public Class Product
    Private _IsActive As Boolean
    Public Property IsActive() As Boolean
        Get
            Return _IsActive
        End Get
        Set(ByVal value As Boolean)
            _IsActive = value
        End Set
    End Property

    Private _Name As String
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _ProductNumber As String
    Public Property ProductNumber() As String
        Get
            Return _ProductNumber
        End Get
        Set(ByVal value As String)
            _ProductNumber = value
        End Set
    End Property

    'Auto-implemented properties.
    'Public Property IsActive As Boolean
    'Public Property Name As String
    'Public Property ProductNumber As String

    Public ReadOnly Property NameAndNumber() As String
        Get
            Return Name + "-" + ProductNumber
        End Get
    End Property

    Public Property Color As String
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Sub CalculateSellEndDate(ByVal days As Integer,
                             ByRef sellDate As DateTime)
        SellEndDate = SellStartDate.AddDays(days)
        'Set the ByRef parameter
        sellDate = SellEndDate
    End Sub

End Class
