Create Procedure spCreateSTOCKtable
As
Begin
Begin Transaction
	Create Table STOCK(
		STOCK_ID Varchar(7) Not null,
		STOCK_QUANTITY SMALLINT Not null,
		STOCK_PRICE_EACH Decimal(8,2) Not null,
		STOCK_VALUE Decimal(8,2),
		Primary Key(STOCK_ID))
Commit Transaction
End