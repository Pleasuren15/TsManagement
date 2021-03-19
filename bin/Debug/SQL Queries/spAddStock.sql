CREATE Procedure spSubtractStock
			@StockValue SmallInt,
			@StockDate_YYYYMM VarChar(7)
As
Begin
Begin Transaction
	Declare @StockCount Int;

	Select @StockCount = S.STOCK_QUANTITY
	From STOCK S
	Where S.STOCK_ID = @StockDate_YYYYMM;

	If (@StockCount - @StockValue >= 0)
	Begin
		Update STOCK
		Set STOCK_QUANTITY = STOCK_QUANTITY + @StockValue , STOCK_VALUE = (STOCK_QUANTITY + @StockValue) * STOCK_PRICE_EACH 
		Where STOCK_ID = @StockDate_YYYYMM
	End
	Else
	Begin
		Rollback Transaction
		Return;
	End
Commit Transaction
End