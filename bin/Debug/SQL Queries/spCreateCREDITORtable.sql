Create Procedure spCreateCREDITORtable
As
Begin
		Create Table CREDITOR(
			CREDITOR_ID Varchar(10),
			CREDITOR_NAME Varchar(75) Not null,
			Primary Key(CREDITOR_ID));
End