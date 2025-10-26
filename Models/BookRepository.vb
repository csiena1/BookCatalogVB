Imports System.Collections.Generic

Namespace BookCatalogVB.Models
    Public NotInheritable Class BookRepository
        Private Shared _books As List(Of Book)
        Private Shared _nextId As Integer = 1

        Shared Sub New()
            _books = New List(Of Book) From {
                New Book With {.Id = _nextId, .Title = "Sample Book 1", .Author = "Author A", .YearPublished = 2010}
            }
            _nextId = 2
        End Sub

        Public Shared Function GetAll() As IEnumerable(Of Book)
            Return _books
        End Function

        Public Shared Function GetById(id As Integer) As Book
            Return _books.FirstOrDefault(Function(b) b.Id = id)
        End Function

        Public Shared Sub Add(book As Book)
            book.Id = _nextId
            _nextId += 1
            _books.Add(book)
        End Sub

        Public Shared Sub Update(updatedBook As Book)
            Dim existing = GetById(updatedBook.Id)
            If existing IsNot Nothing Then
                existing.Title = updatedBook.Title
                existing.Author = updatedBook.Author
                existing.YearPublished = updatedBook.YearPublished
            End If
        End Sub

        Public Shared Sub Delete(id As Integer)
            Dim book = GetById(id)
            If book IsNot Nothing Then
                _books.Remove(book)
            End If


        End Sub
    End Class
End Namespace
