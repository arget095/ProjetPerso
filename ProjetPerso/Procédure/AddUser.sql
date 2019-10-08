CREATE PROCEDURE [dbo].[AddUser]
	@FirstName NVARCHAR(50),
	@LastName nvarchar(50),
	@Pseudo nvarchar(50),
	@Mail NVARCHAR(250),
	@Password nvarchar(250)
	
AS
	insert into [User](FirstName,LastName,Pseudo,Mail,Password,IdRole) output inserted.IdUser
	VALUES(@FirstName,@LastName,@Pseudo,@Mail,@Password,1)
