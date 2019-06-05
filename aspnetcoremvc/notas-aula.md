## Views/Sellers/Index.cshtml

```html

@model IEnumerable<ProjectName.Models.Seller>

@{
    ViewData["Title"] = "Sellers";
}

<h2>@ViewData["Title"]</h2>

<p>
    <a asp-action="Create" class="btn btn-default">Create New</a>
</p>

<!-- classes do bootstrap (table table-striped table-hover)-->
<table class="table table-striped table-hover">
    <thead>
        <tr class="success">
            <th>
                <!-- recurso do framework(mostrar nome do atributo do objeto "Name" do objeto da lista)
               apenas o nome do atributo, não o valor. Até pq @model é uma lista-->
                @Html.DisplayNameFor(model => model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.Email)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.BirthDate)
            </th>
            <th>
                @Html.DisplayNameFor(model => model.BaseSalary)
            </th>
            <th></th>
        </tr>
    </thead>
      <!-- para cada item da lista -->
    <tbody>
        @foreach (var item in Model)
        {
        <tr>
            <td>
                <!-- DisplayFor mostra o conteúdo da propriedade acessada.
                Usa-se um apelido qualquer "modelItem", o que conta é  "item.Name"-->
                @Html.DisplayFor(modelItem => item.Name)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.Email)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.BirthDate)
            </td>
            <td>
                @Html.DisplayFor(modelItem => item.BaseSalary)
            </td>
            <td>
                <a asp-action="Edit" asp-route-id="@item.Id">Edit</a>
                <a asp-action="Details" asp-route-id="@item.Id">Details</a>
                <a asp-action="Delete" asp-route-id="@item.Id">Delete</a>
            </td>
        </tr>

        }
    </tbody>

</table>

```
