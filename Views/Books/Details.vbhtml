@ModelType BookCatalogVB.BookCatalogVB.Models.Book
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.Id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
