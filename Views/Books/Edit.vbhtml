@ModelType BookCatalogVB.BookCatalogVB.Models.Book
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm()) 
 @Html.AntiForgeryToken()
 @<div class="form-horizontal">
 <h4>Book</h4>
 <hr />
 @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
 @Html.HiddenFor(Function(m) m.Id)

 <div class="form-group">
 @Html.LabelFor(Function(m) m.Title, htmlAttributes:=New With {.class = "control-label col-md-2"})
 <div class="col-md-10">
 @Html.EditorFor(Function(m) m.Title, New With { .htmlAttributes = New With {.class = "form-control"} })
 @Html.ValidationMessageFor(Function(m) m.Title, "", New With {.class = "text-danger"})
 </div>
 </div>

 <div class="form-group">
 @Html.LabelFor(Function(m) m.Author, htmlAttributes:=New With {.class = "control-label col-md-2"})
 <div class="col-md-10">
 @Html.EditorFor(Function(m) m.Author, New With { .htmlAttributes = New With {.class = "form-control"} })
 @Html.ValidationMessageFor(Function(m) m.Author, "", New With {.class = "text-danger"})
 </div>
 </div>

 <div class="form-group">
 @Html.LabelFor(Function(m) m.YearPublished, htmlAttributes:=New With {.class = "control-label col-md-2"})
 <div class="col-md-10">
 @Html.EditorFor(Function(m) m.YearPublished, New With { .html_attributes = New With {.class = "form-control"} })
 @Html.ValidationMessageFor(Function(m) m.YearPublished, "", New With {.class = "text-danger"})
 </div>
 </div>

 <div class="form-group">
 <div class="col-md-offset-2 col-md-10">
 <input type = "submit" value="Save" class="btn btn-primary" />
 @Html.ActionLink("Back to List", "Index", Nothing, New With {.class = "btn btn-default"})
 </div>
 </div>
 </div>
End Using

