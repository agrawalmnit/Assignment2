CREATE PROCEDURE [dbo].[Update]
@rollNo int,
@Name nvarchar(255),
@familyName nvarchar(255),
@Address nvarchar(255),
@contactNumber nvarchar(255)
AS
BEGIN
update [dbo].[Students]
set Name = @Name,
familyName = @familyName,
Address = @Address,
contactNumber  = @contactNumber

where rollNo = @rollNo;
end
