CREATE TABLE [dbo].[City]
(
	[IdCity] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PostalCode] NVARCHAR(50) NOT NULL, 
    [Name] NVARCHAR(50) NOT NULL, 
    [IdCountry] NVARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_City_IdCountry] FOREIGN KEY ([IdCountry]) REFERENCES [Country]([IdCountry])
)
