@ModelType Assignment2.Customer
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Customer</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CustomerAddress)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CustomerAddress)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Ordernumber)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Ordernumber)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Orderdate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Orderdate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.OrderDescription)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.OrderDescription)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Orderamount)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Orderamount)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
