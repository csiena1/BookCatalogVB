@ModelType BookCatalogVB.BookCatalogVB.Models.Book
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this book?</h3>

<h4>Book</h4>
<hr />
<dl class="dl-horizontal">
    <dt>Title</dt>
    <dd>@Model.Title</dd>

    <dt>Author</dt>
    <dd>@Model.Author</dd>

    <dt>Year Published</dt>
    <dd>@Model.YearPublished</dd>
</dl>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.HiddenFor(Function(m) m.Id)

    @<div class="form-actions no-color">
        <input type="submit" value="Delete" class="btn btn-default" /> |
        @Html.ActionLink("Back to List", "Index")
    </div>

End Using