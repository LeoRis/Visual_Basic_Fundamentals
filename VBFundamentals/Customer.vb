Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New()

        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Protected Overrides Function GetClassData() As String
        Dim stringBuilder As New Text.StringBuilder(1024)

        stringBuilder.AppendLine("Customer ID: " + CustomerID.ToString())
        stringBuilder.AppendLine("Company Name: " + CompanyName)
        stringBuilder.AppendLine("First Name: " + FirstName)
        stringBuilder.AppendLine("Last Name: " + LastName)
        stringBuilder.AppendLine(MyBase.GetClassData())

        Return stringBuilder.ToString()
    End Function

End Class
