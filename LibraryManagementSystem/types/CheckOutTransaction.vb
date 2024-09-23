Public Class CheckOutTransaction
    Public Property ID As Integer
    Public Property StartDate As Date
    Public Property EndDate As Date
    Public Property User As New User
    Public Property IsReturned As Boolean
    Public Property DateCreated As DateTime
    Public Property BorrowedBooks As New List(Of Book)
End Class
