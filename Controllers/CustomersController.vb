Imports Assignment2.Customers_DAL
Imports System.Web.Mvc

Namespace Controllers
    Public Class CustomersController
        Inherits Controller

        Dim Cusdal As Customers_DAL = New Customers_DAL

        ' GET: Customers
        Function Index() As ActionResult
            Dim customerlist = Cusdal.GetallCustomers()
            Return View(customerlist)
        End Function

        ' GET: Customers/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Customers/Create
        Function Create() As ActionResult
            Return View()

        End Function

        ' POST: Customers/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection, customer As Customer) As ActionResult
            Try
                Dim isinserted As Boolean = False
                If ModelState.IsValid Then
                    isinserted = Cusdal.InsertCustomer(customer)

                End If

                Return RedirectToAction("Index")
            Catch ex As Exception
                Return View()
                MsgBox(ex.Message)
            End Try
        End Function

        ' GET: Customers/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Customers/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection, customer As Customer) As ActionResult
            Try
                Dim isUpdated As Boolean = False
                If ModelState.IsValid Then
                    isUpdated = Cusdal.UpdateCustomer(customer)

                End If

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Customers/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Customers/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection, Customer As Customer) As ActionResult
            Try

                Dim IsDeleted As Boolean = False
                If ModelState.IsValid Then
                    IsDeleted = Cusdal.UpdateCustomer(Customer)

                End If
                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace