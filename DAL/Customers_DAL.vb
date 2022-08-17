Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports Assignment2.Models
Public Class Customers_DAL

    Dim connectionstring As String = ConfigurationManager.ConnectionStrings("ADoConnectionString").ToString()



    Public Function GetallCustomers() As List(Of Customer)
        Dim custlist As List(Of Customer) = New List(Of Customer)
        Using constr As SqlConnection = New SqlConnection(connectionstring)
            Dim command As SqlCommand = constr.CreateCommand()
            command.CommandType = CommandType.StoredProcedure
            command.CommandText = "sp_GetAllCustomers"
            Dim sqlda As SqlDataAdapter = New SqlDataAdapter(command)
            Dim dt As DataTable = New DataTable
            constr.Open()
            sqlda.Fill(dt)
            constr.Close()
            For Each item As DataRow In dt.Rows
                custlist.Add(New Customer With {
                .ID = Convert.ToInt32(item("ID")),
                .CustomerName = item("CustomerName"),
                .CustomerAddress = item("CustomerAddress"),
                .Orderamount = Convert.ToInt32(item("Orderamount")),
                .Orderdate = Convert.ToDateTime(item("Orderdate")),
                .OrderDescription = item("OrderDescription"),
                .Ordernumber = Convert.ToInt32("Ordernumber")
                })
            Next
        End Using
        Return custlist

    End Function
    Public Function InsertCustomer(customer As Customer) As Boolean
        Dim id As Integer = 0
        Using con As SqlConnection = New SqlConnection(connectionstring)
            Dim command As SqlCommand = New SqlCommand("sp_Insert", con)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CustomerName", customer.CustomerName)
            command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress)
            command.Parameters.AddWithValue("@Ordernumber", customer.Ordernumber)
            command.Parameters.AddWithValue("@Orderdate", customer.Orderdate)
            command.Parameters.AddWithValue("@OrderDescription", customer.OrderDescription)
            command.Parameters.AddWithValue("@Orderamount", customer.Orderamount)
            con.Open()
            id = command.ExecuteNonQuery()
            con.Close()
            If id > 0 Then
                Return True
            Else
                Return False
            End If

        End Using

    End Function
    Public Function UpdateCustomer(customer As Customer)
        Dim id As Integer = 0
        Using con As SqlConnection = New SqlConnection(connectionstring)
            Dim command As SqlCommand = New SqlCommand("sp_Update", con)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@CustomerName", customer.CustomerName)
            command.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress)
            command.Parameters.AddWithValue("@Ordernumber", customer.Ordernumber)
            command.Parameters.AddWithValue("@Orderdate", customer.Orderdate)
            command.Parameters.AddWithValue("@OrderDescription", customer.OrderDescription)
            command.Parameters.AddWithValue("@Orderamount", customer.Orderamount)
            con.Open()
            id = command.ExecuteNonQuery()
            con.Close()
            If id > 0 Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function
    Public Function DeleteCustomer(customer As Customer)
        Dim id As Integer = 0
        Using con As SqlConnection = New SqlConnection(connectionstring)
            Dim command As SqlCommand = New SqlCommand("SP_Delete", con)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@ID", customer.ID)
            con.Open()
            id = command.ExecuteNonQuery()
            con.Close()
            If id > 0 Then
                Return True
            Else
                Return False
            End If
        End Using
    End Function


End Class
