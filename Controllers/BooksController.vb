Imports System.Web.Mvc
Imports BookCatalogVB.BookCatalogVB.Models


Namespace BookCatalogVB.Controllers
    Public Class BooksController
        Inherits Controller

        ' GET: Books
        Function Index() As ActionResult
            Dim books = BookRepository.GetAll()
            Return View(books)
        End Function

        ' GET: Books/Details/5
        Function Details(id As Integer?) As ActionResult
            If Not id.HasValue Then
                Return New HttpStatusCodeResult(400) ' Bad Request
            End If
            Dim book = BookRepository.GetById(id.Value)
            If book Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' GET: Books/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Books/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(book As Book) As ActionResult
            If ModelState.IsValid Then
                BookRepository.Add(book)
                Return RedirectToAction("Index")
            End If
            Return View(book)
        End Function
        ' GET: Books/Edit/5
        Function Edit(id As Integer?) As ActionResult
            If Not id.HasValue Then
                Return New HttpStatusCodeResult(400)
            End If
            Dim book = BookRepository.GetById(id.Value)
            If book Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: Books/Edit/5
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(book As Book) As ActionResult
            If ModelState.IsValid Then
                BookRepository.Update(book)
                Return RedirectToAction("Index")
            End If
            Return View(book)
        End Function

        ' GET: Books/Delete/5
        Function Delete(id As Integer?) As ActionResult
            If Not id.HasValue Then
                Return New HttpStatusCodeResult(400)
            End If
            Dim book = BookRepository.GetById(id.Value)
            If book Is Nothing Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: Books/Delete/5
        <HttpPost(), ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(id As Integer) As ActionResult
            BookRepository.Delete(id)
            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace
