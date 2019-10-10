CREATE TABLE [dbo].[Event]
(
	[IdEvent] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Participant] INT NULL, 
    [Time] DATETIME2 NOT NULL, 
    [Admin] INT NOT NULL, 
    [IdCity] INT NOT NULL, 
    [IdCountry] NVARCHAR(10) NOT NULL,
	[IdLoisir] INT NOT NULL, 
    CONSTRAINT [FK_Event_IdCountry] FOREIGN KEY ([IdCountry]) REFERENCES [Country]([IdCountry]),
	CONSTRAINT [FK_Event_IdCity] FOREIGN KEY ([IdCity]) REFERENCES [City]([IdCity]),
	CONSTRAINT [FK_Event_Admin] FOREIGN KEY ([Admin]) REFERENCES [User]([IdUser]),
	CONSTRAINT [FK_Event_IdLoisir] FOREIGN KEY ([IdLoisir]) REFERENCES [Loisir]([IdLoisir]),
)
