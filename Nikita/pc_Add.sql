CREATE PROCEDURE pc_AddEditAddress
	@AddressID int null,
	@PersonName nvarchar(50),
	@ContactNumber nvarchar(15),
	@AddressLine nvarchar(50),
	@CityID int
AS
BEGIN
	SET NOCOUNT ON;
	IF @AddressID IS NULL
	BEGIN
		INSERT INTO [Address] VALUES (@PersonName, @ContactNumber, @AddressLine, @CityID)
	END
	ELSE
	BEGIN
		UPDATE [Address] SET
		
		PersonName = @PersonName,
		ContactNumber = @ContactNumber,
		AddressLine=@AddressLine,
		CityID = @CityID
		WHERE AddressID=@AddressID
	END
END
GO

--select * from [Address]


