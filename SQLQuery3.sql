create proc sp_Update
(
@ID int,
@CustomerName nvarchar(50),
@CustomerAddress nvarchar(50),
@Ordernumber int,
@Orderdate date,
@OrderDescription nvarchar(50),
@Orderamount int
)
as
begin
declare @Rowcount int = 0
set @Rowcount = (select count(1) from dbo.tbl_Customers where ID = @ID and ID <> @ID)
   begin try
       Update dbo.tbl_Customers
	   set ID = @ID,
	   CustomerName = @CustomerName,
	   CustomerAddress = @CustomerAddress,
	   Ordernumber = @Ordernumber,
	   Orderdate = @Orderdate,
	   OrderDescription = @OrderDescription,
	   Orderamount = @Orderamount
	   Where ID = @ID
		commit tran
    End Try
	begin Catch
	rollback tran
	SELECT ERROR_MESSAGE()
	End Catch
End