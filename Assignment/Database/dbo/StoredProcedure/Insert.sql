CREATE PROCEDURE [dbo].[Insert]
@rollNo int,
@Name nvarchar(255),
@familyName nvarchar(255),
@Address nvarchar(255),
@contactNumber nvarchar(255)
AS
BEGIN
INSERT INTO [dbo].[Students](Name, rollNo, familyName, Address, contactNumber)
VALUES(@Name, @rollNo, @familyName, @Address, @contactNumber);
END