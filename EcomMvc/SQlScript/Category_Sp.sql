	use EcomDb
	CREATE PROCEDURE GetAllCategories 

	As

	Begin
		Select * FROM Categories 
	END

	EXEC GetAllCategories;