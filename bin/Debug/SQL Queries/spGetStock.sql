Alter Procedure spGetStock
		@StockDate_YYYYMM VarChar(7)
As
Begin
	Select S.STOCK_ID , S.STOCK_QUANTITY , S.STOCK_PRICE_EACH , S.STOCK_VALUE
	From STOCK S
	Where S.STOCK_ID = @StockDate_YYYYMM;
End