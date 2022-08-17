create proc sp_Insert
(
@CustomerName nvarchar(50),
@CustomerAddress nvarchar(50),
@Ordernumber int,
@Orderdate date,
@OrderDescription nvarchar(50),
@Orderamount int
)
as
begin
   begin try
        insert into dbo.tbl_Customers(CustomerName ,CustomerAddress ,Ordernumber,Orderdate,OrderDescription,Orderamount)
        values(@CustomerName ,@CustomerAddress,@Ordernumber,@Orderdate,@OrderDescription,@Orderamount)
		commit tran
    End Try
	begin Catch
	rollback tran
	SELECT ERROR_MESSAGE()
	End Catch
End