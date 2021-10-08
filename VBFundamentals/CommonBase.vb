Public Class CommonBase
    Sub New()
        IsActive = True
        ModifiedDate = DateTime.Now
        CreatedBy = Environment.UserName
    End Sub

    Public Property IsActive As Boolean
    Public Property ModifiedDate As DateTime
    Public Property CreatedBy As String

    Public Overrides Function ToString() As String
        Return GetClassData()
    End Function

    Protected Overridable Function GetClassData() As String
        Dim stringBuilder As New Text.StringBuilder(1024)

        stringBuilder.AppendLine("Is Active: " + IsActive.ToString())
        stringBuilder.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
        stringBuilder.AppendLine("Created By: " + CreatedBy)

        Return stringBuilder.ToString()
    End Function

End Class
