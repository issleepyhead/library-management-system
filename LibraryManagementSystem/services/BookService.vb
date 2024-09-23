Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class BookService
    Inherits BaseService(Of Book)

    Sub New()
        MyBase.New()
    End Sub

    Public Overrides Sub _AddParameters(data As Book)
        SCommand.Parameters.Clear()
        With SCommand.Parameters
            ' TODO FIX THE IDs
            .AddWithValue("@gid", DBNull.Value)
            .AddWithValue("@pid", DBNull.Value)
            .AddWithValue("@aid", DBNull.Value)
            .AddWithValue("@title", data.Title)
            .AddWithValue("@isbn", data.ISBN)
            .AddWithValue("@pages", data.Pages)
            .AddWithValue("@language", data.Language)
            .AddWithValue("@summary", data.Summary)
            .AddWithValue("@dpublished", data.DatePublished)
        End With
    End Sub

    Public Overrides Function Add(data As Book) As Boolean
        Try
            If Connection IsNot Nothing AndAlso Connection.State <> ConnectionState.Closed Then
                SCommand = New SqlCommand("INSERT INTO tblbooks (
                                                genre_id,
                                                publisher_id,
                                                author_id,
                                                title,
                                                isbn,
                                                pages, 
                                                language, 
                                                summary, 
                                                date_published)
                                        VALUES (@gid, @pid, @aid, @title, @isbn, @pages, @language, @summary, @dpublished)", Connection)
                _AddParameters(data)
            Else
                Return False
            End If
        Catch ex As SqlException
            Return False
        End Try
        Return SCommand.ExecuteNonQuery() > 0
    End Function

    Public Overrides Function Update(data As Book) As Boolean
        Try
            If Connection IsNot Nothing AndAlso Connection.State <> ConnectionState.Closed Then
                ' TODO FIX THE STRING
                SCommand = New SqlCommand("UPDATE tblbooks SET
                                                   genre_id = @gid,
                                                   publisher_id = @pid,
                                                   author_id = @aid,
                                                   title = @title,
                                                   isbn = @isbn,
                                                   pages = @pages,
                                                   language = @language,
                                                   summary = @summary,
                                                   date_published = @dpublished
                                            WHERE id = @id", Connection)
                _AddParameters(data)
                SCommand.Parameters.AddWithValue("@id", data.ID)
            Else
                Return False
            End If
        Catch ex As SqlException
            Return False
        End Try
        Return SCommand.ExecuteNonQuery() > 0
    End Function

    Public Overrides Function Archive(data As Book) As Boolean
        Try
            If Connection IsNot Nothing AndAlso Connection.State <> ConnectionState.Closed Then
                ' TODO FIX THE STRING
                SCommand = New SqlCommand("UPDATE tblbooks SET
                                                   status_id = 2
                                            WHERE id = @id", Connection)
                SCommand.Parameters.AddWithValue("@id", data.ID)
            Else
                Return False
            End If
        Catch ex As SqlException
            Return False
        End Try
        Return SCommand.ExecuteNonQuery() > 0
    End Function

    Public Overrides Function Fetch(Optional pages As Integer = 1) As ObservableCollection(Of Book)
        DataList = New ObservableCollection(Of Book)
        DTable = New DataTable()
        Try
            SCommand = New SqlCommand("SELECT
	                                        b.id book_id,
	                                        s.id status_id,
	                                        g.id genre_id,
	                                        p.id publisher_id,
	                                        a.id author_id,
	                                        s.status_name,
	                                        g.genre_name,
	                                        g.description,
	                                        p.company_name,
	                                        p.address publisher_address,
	                                        p.email,
	                                        p.website,
	                                        a.address author_address,
	                                        a.birthdate,
	                                        a.first_name,
	                                        a.last_name,
                                            a.gender,
                                            a.age,
	                                        b.title,
	                                        b.isbn,
	                                        b.pages,
	                                        b.language,
	                                        b.summary,
	                                        b.date_published
                                        FROM tblbooks b
                                        JOIN tblstatus s ON b.status_id = s.id
                                        FULL JOIN tblgenres g ON b.genre_id = g.id
                                        FULL JOIN tblpublishers p ON b.publisher_id = p.id
                                        FULL JOIN tblauthors a ON b.author_id = a.id
                                        ORDER BY b.id
                                        OFFSET @pages ROWS
                                        FETCH NEXT 30 ROWS ONLY", Connection)
            SCommand.Parameters.AddWithValue("@pages", If(pages > 1, pages * MAX_FETCH, 1))
            SAdapter = New SqlDataAdapter(SCommand)
            SAdapter.Fill(DTable)

            ' TODO Maybe you can use the ids here.
            For Each row As DataRow In DTable.Rows
                Dim genre As Genre = Nothing
                Dim x = row.Item("genre_id")
                If Not IsDBNull(row.Item("genre_id")) Then
                    genre = New Genre With {
                        .ID = row.Item("genre_id"),
                        .Name = row.Item("genre_name"),
                        .Description = If(String.IsNullOrEmpty(row.Item("description")), "", row.Item("description"))
                    }
                End If


                Dim status As New Status With {
                    .ID = row.Item("status_id"),
                    .StatusName = row.Item("status_name")
                }

                Dim publisher As Publisher = Nothing
                If Not IsDBNull(row.Item("publisher_id")) Then
                    publisher = New Publisher With {
                        .ID = row.Item("publisher_id"),
                        .CompanyName = row.Item("company_name"),
                        .Address = row.Item("publisher_address"),
                        .Email = row.Item("email"),
                        .Website = row.Item("website")
                    }
                End If

                Dim author As Author = Nothing
                If Not IsDBNull(row.Item("author_id")) Then
                    author = New Author With {
                        .ID = row.Item("author_id"),
                        .Address = row.Item("author_address"),
                        .BirthDate = row.Item("birthdate"),
                        .FirstName = row.Item("first_name"),
                        .LastName = row.Item("last_name"),
                        .Age = row.Item("age"),
                        .Gender = row.Item("gender")
                    }
                End If


                Dim book As New Book With {
                   .Genre = genre,
                   .Publisher = publisher,
                   .Status = status,
                   .Author = author,
                   .ID = row.Item("book_id"),
                   .ISBN = row.Item("isbn"),
                   .Language = row.Item("language"),
                   .Pages = row.Item("pages"),
                   .Title = row.Item("title"),
                   .Summary = row.Item("summary"),
                   .DatePublished = row.Item("date_published")
                }
                DataList.Add(book)
            Next
        Catch ex As Exception
            Return New ObservableCollection(Of Book)
        End Try
        Return DataList
    End Function

    Public Overrides Function Search() As ObservableCollection(Of Book)
        Throw New NotImplementedException()
    End Function
End Class
