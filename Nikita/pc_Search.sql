CREATE PROCEDURE pc_ViewAddress
	
	@PersonName nvarchar(50)
	
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT * FROM Address where PersonName=@PersonName
END
GO

--select * from [Address]

select * from Address

