Imports System.Collections.ObjectModel
Imports System.Text
Imports LibraryManagementSystem
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class BookServiceTest

    <TestMethod()> Public Sub InsertTest()
        Dim base As BaseService(Of Book) = New BookService()
        Dim book As New Book With {
            .ISBN = "1234567890",
            .Language = "English",
            .Pages = 500,
            .Summary = "Hello, World",
            .Title = "A TEST",
            .DatePublished = Date.Now
        }
        Assert.AreEqual(base.Add(book), True)
    End Sub

    <TestMethod()> Public Sub UpdateTest()
        Dim base As BaseService(Of Book) = New BookService()
        Dim book As New Book With {
            .ID = 1,
            .ISBN = "1234567890",
            .Language = "Spanish",
            .Pages = 500,
            .Summary = "Hello, World",
            .Title = "A TEST FOR UPDATE",
            .DatePublished = Date.Now
        }

        Assert.AreEqual(base.Update(book), True)
    End Sub

    <TestMethod()> Public Sub ArchiveTest()
        Dim base As BaseService(Of Book) = New BookService()
        Dim book As New Book With {
            .ID = 1,
            .ISBN = "1234567890",
            .Language = "Spanish",
            .Pages = 500,
            .Summary = "Hello, World",
            .Title = "A TEST FOR UPDATE",
            .DatePublished = Date.Now
        }

        Assert.AreEqual(base.Archive(book), True)
    End Sub

    <TestMethod()> Public Sub FetchTest()
        Dim base As BaseService(Of Book) = New BookService()
        Dim collection As ObservableCollection(Of Book) = base.Fetch()
        Assert.IsTrue(collection.Count > 0)
    End Sub

End Class