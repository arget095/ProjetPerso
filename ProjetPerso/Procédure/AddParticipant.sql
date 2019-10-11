CREATE PROCEDURE [dbo].[AddParticipant]
	@IdUser INT,
	@IdEvent int
AS
	insert into [Participant](IdUser,IdEvent) output inserted.Id
	values(@IdUser,@IdEvent)
