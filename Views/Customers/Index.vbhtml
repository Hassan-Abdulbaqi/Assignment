@ModelType IEnumerable(Of Assignment2.Customer)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.CustomerName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CustomerAddress)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Ordernumber)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Orderdate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.OrderDescription)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Orderamount)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CustomerAddress)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Ordernumber)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Orderdate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.OrderDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Orderamount)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID })
        </td>
    </tr>
Next

</table>
