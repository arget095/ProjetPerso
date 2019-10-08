CREATE PROCEDURE [dbo].[AddEvent]
	@Name NVARCHAR(50),
	@Time DATETIME2,
	@Admin int,
	@IdCountry INT,
	@IdCity int,
	@IdCategory int
AS
	insert into [Event](Name,Time,Admin,IdCountry,IdCity,IdCategory)
	values(@Name,@Time,@Admin,@IdCountry,@IdCity,@IdCategory)
