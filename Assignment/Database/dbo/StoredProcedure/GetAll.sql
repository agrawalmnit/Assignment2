CREATE PROCEDURE [dbo].[GetAll]
AS
BEGIN
SELECT Name, familyName, Address, contactNumber, rollNo
FROM [dbo].[Students]
END
