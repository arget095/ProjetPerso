CREATE TABLE [dbo].[Loisir]
(
	[IdLoisir] INT NOT NULL PRIMARY KEY identity, 
    [Name] NVARCHAR(50) NOT NULL, 
    [NameCategory] NVARCHAR(50) NOT NULL,
	CONSTRAINT [FK_Event_NameCategory] FOREIGN KEY ([NameCategory]) REFERENCES [Category]([Name]),
)
