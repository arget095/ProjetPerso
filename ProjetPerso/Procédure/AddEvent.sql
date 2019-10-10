CREATE PROCEDURE [dbo].[AddEvent]
	@Name NVARCHAR(50),
	@Time DATETIME2,
	@Admin int,
	@IdCountry INT,
	@IdCity int,
	@IdLoisir int
AS
	insert into [Event](Name,Time,Admin,IdCountry,IdCity,IdLoisir)
	values(@Name,@Time,@Admin,@IdCountry,@IdCity,@IdLoisir)
