@ModelType IEnumerable(Of BookCatalogVB.BookCatalogVB.Models.Book)
@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Add New Book", "Create")
</p>

<table class="table">
    <thead>
        <tr>
            <th>Title</th>
            <th>Author</th>
            <th>Year</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>@item.Title</td>
                <td>@item.Author</td>
                <td>@item.YearPublished</td>
                <td>
                    @Html.ActionLink("Edit", "Edit", New With {.id = item.Id}) |
                    @Html.ActionLink("Details", "Details", New With {.id = item.Id}) |
                    @Html.ActionLink("Delete", "Delete", New With {.id = item.Id})
                </td>
            </tr>
        Next
    </tbody>
</table>


