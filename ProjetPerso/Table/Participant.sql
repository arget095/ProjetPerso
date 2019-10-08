CREATE TABLE [dbo].[Participant]
(
	[IdUser] INT NOT NULL, 
    [IdEvent] INT NOT NULL, 
    [Id] INT NOT NULL identity, 
    CONSTRAINT [FK_Participant_IdUser] FOREIGN KEY ([IdUser]) REFERENCES [user]([IdUser]),
    CONSTRAINT [FK_Participant_IdEvent] FOREIGN KEY ([IdEvent]) REFERENCES [Event]([IdEvent]),
	CONSTRAINT [UK_Participant] unique(IdEvent,IdUser)
)
