CREATE PROCEDURE [dbo].[AddParticipant]
	@IdUser INT,
	@IdEvent int
AS
	insert into [Participant](IdUser,IdEvent)
	values(@IdUser,@IdEvent)
