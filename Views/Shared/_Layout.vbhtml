<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title - Book Catalog</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <header>
        <nav class="navbar navbar-default">
            <div class="container">
                <div class="navbar-header">
                    @Html.ActionLink("Book Catalog", "Index", "Books", Nothing, New With {.class = "navbar-brand"})
                </div>
            </div>
        </nav>
    </header>

    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - BookCatalogVB</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @RenderSection("Scripts", required:=False)

    <link href="~/Content/site.css" rel="stylesheet" />

</body>
</html>
