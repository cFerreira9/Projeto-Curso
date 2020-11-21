CREATE PROC spAddUser
	@Username nvarchar(25),
	@Password nvarchar(25),
	@Email nvarchar(50),
	@Id int out
AS
BEGIN
	INSERT INTO [Users] (Username, IsActive, IsBlocked)
	VALUES (@Username, '1', '0');
	SELECT @Id = SCOPE_IDENTITY();
	INSERT INTO [Account] (Password, Email)
	VALUES (@Password, @Email);
END