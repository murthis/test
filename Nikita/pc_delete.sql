CREATE PROCEDURE pc_DeleteAddress
	
	@PersonName nvarchar(50)
	
AS
BEGIN
	SET NOCOUNT ON;
	
	Delete FROM Address where PersonName=@PersonName
END
GO



