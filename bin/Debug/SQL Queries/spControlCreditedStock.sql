CREATE Procedure spControlCreditedStock
				@STOCK_ID Varchar(7),
				@CREDITOR_ID Varchar(10),
				@CREDITOR_NAME varchar(50),
				@AMOUNT_TO_BE_PAID Decimal(8,2)
As
Begin
Begin Transaction
	If (Select Count(*) From CREDITEDSTOCK CS Where CS.CREDITOR_ID = @CREDITOR_ID And CS.STOCK_ID = @STOCK_ID) > 0
	Begin
			Update CREDITEDSTOCK
			Set CREDITEDSTOCK.AMOUNT_TO_BE_PAID = CREDITEDSTOCK.AMOUNT_TO_BE_PAID + @AMOUNT_TO_BE_PAID
			Where CREDITEDSTOCK.CREDITOR_ID = @CREDITOR_ID And CREDITEDSTOCK.STOCK_ID = @STOCK_ID

			If @@ERROR <> 0
			Begin
				Rollback Transaction
				Return
			End
	End
	Else
	Begin
			If (Select Count(*) From CREDITOR C Where C.CREDITOR_ID = @CREDITOR_ID) = 0
			Begin
				Insert Into CREDITOR vALUES(@CREDITOR_ID,@CREDITOR_NAME)
				If @@ERROR <> 0
				Begin
					Rollback Transaction
					Return
				End
			End

			Insert Into CREDITEDSTOCK Values(@STOCK_ID,@CREDITOR_ID,@AMOUNT_TO_BE_PAID,GETDATE())
	End
Commit Transaction
End