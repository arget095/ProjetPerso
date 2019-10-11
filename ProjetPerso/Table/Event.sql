CREATE TABLE [dbo].[Event]
(
	[IdEvent] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Participant] INT NULL DEFAULT 1, 
    [Time] DATETIME2 NOT NULL, 
    [Admin] INT NOT NULL, 
    [IdCityPostalCode] NVARCHAR(50) NOT NULL, 
    [IdCountry] NVARCHAR(10) NOT NULL,
	[IdLoisir] INT NOT NULL, 
    CONSTRAINT [FK_Event_IdCountry] FOREIGN KEY ([IdCountry]) REFERENCES [Country]([IdCountry]),
	CONSTRAINT [FK_Event_IdCityPostalCode] FOREIGN KEY ([IdCityPostalCode]) REFERENCES [City]([PostalCode]),
	CONSTRAINT [FK_Event_Admin] FOREIGN KEY ([Admin]) REFERENCES [User]([IdUser]),
	CONSTRAINT [FK_Event_IdLoisir] FOREIGN KEY ([IdLoisir]) REFERENCES [Loisir]([IdLoisir]),
)
