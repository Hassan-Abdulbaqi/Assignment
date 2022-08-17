create Procedure sp_GetAllCustomers
as
Begin

SELECT * FROM dbo.tbl_Customers with(nolock)

End