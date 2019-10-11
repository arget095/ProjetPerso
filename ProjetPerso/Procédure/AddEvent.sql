CREATE PROCEDURE [dbo].[AddEvent]
	@Name NVARCHAR(50),
	@Time DATETIME2,
	@Admin int,
	@IdCountry Nvarchar(10),
	@IdCityPostalCode NVARCHAR(50),
	@IdLoisir int
AS
	insert into [Event](Name,Time,Admin,IdCountry,IdCityPostalCode,IdLoisir) output inserted.IdEvent
	values(@Name,@Time,@Admin,@IdCountry,@IdCityPostalCode,@IdLoisir)
